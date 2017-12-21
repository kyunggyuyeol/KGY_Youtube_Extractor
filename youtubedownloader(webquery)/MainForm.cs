using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;

namespace youtubedownloader_webquery_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //쿼리 생성시 필요한 고정값 부분
        string getlist = "&spf=navigate";
        string youTube = "https://www.youtube.com/results?&q=";
        string playLink = "https://www.youtube.com/watch?v=";
        string logPath = @"videolog.txt";

        public int selectIndex { get; set; }

        int selectSize = 0;

        /// <summary>
        /// 다운로드 시작
        /// </summary>
        public void getdownUrlList()
        {
            for (int i = 0; i < list_Keywords.Items.Count; i++)
            {
                list_Keywords.Invoke(new Action(delegate ()
                {
                    list_Keywords.SelectedIndex = i;
                }));

                //1페이지당 약 20영상 이기때문에 요청 영상 갯수 / 20을 함
                int Moviesize = 0;

                cmb_downfiles.Invoke(new Action(delegate ()
                {
                    Moviesize = int.Parse(cmb_downfiles.SelectedItem.ToString());
                }));

                int turnCount = Moviesize / 20;
                //string querydefult = youTube + list_Keywords.Items[i].ToString();

                string query = "";
                string NextID = "";

                //유튜브 링크 저장
                List<string> linkList = new List<string>();
                linkList.Clear();

                //키워드에 대한 url을 채움
                list_downUrls.Invoke(new Action(delegate ()
                {
                    list_downUrls.BeginUpdate();
                }));
                
                for (int j = 0; j < turnCount; j++)
                {
                    query = youTube + list_Keywords.Items[i].ToString();

                    if (j == 0)
                    {
                        List<string> data = getYouTubeID(query + getlist);
                        for (int k = 0; k < data.Count; k++)
                        {
                            linkList.Add(playLink + data[k]);
                        }
                        NextID = getNextPSID(query);
                    }
                    else
                    {
                        List<string> data = getYouTubeID(query + getlist + NextID);
                        for (int k = 0; k < data.Count; k++)
                        {
                            linkList.Add(playLink + data[k]);
                        }
                        NextID = getNextPSID(query + NextID);
                    }
                }

                list_downUrls.Invoke(new Action(delegate ()
                {
                    list_downUrls.Items.Clear();
                }));

                for (int l = 0; l < linkList.Count; l++)
                {
                    //중복은 넣지 않는다.
                    if (!list_downUrls.Items.Contains(linkList[l]))
                    {
                        list_downUrls.Invoke(new Action(delegate ()
                        {
                            list_downUrls.Items.Add(linkList[l]);
                        }));
                    }
                }

                list_downUrls.Invoke(new Action(delegate ()
                {
                    list_downUrls.EndUpdate();
                }));
                
                //키워드에 대한 url을 종료

                //cnd = new CountdownEvent(1);
                downloadYoutube();
                //cnd.Wait();
            }
        }

        public void downloadYoutube()
        {
            //채워진 url을 이용하여 다운로드 시작
            for (int j = 0; j < list_downUrls.Items.Count; j++)
            {
                list_downUrls.Invoke(new Action(delegate ()
                {
                    list_downUrls.SelectedIndex = j;
                }));

                IEnumerable<VideoInfo> videoinfos = DownloadUrlResolver.GetDownloadUrls(list_downUrls.Items[j].ToString());
                if (videoinfos != null)
                {
                    int displayP = 0;
                    cmb_size.Invoke(new Action(delegate ()
                    {
                        displayP = int.Parse(cmb_size.SelectedItem.ToString());
                    }));

                    //VideoInfo video = videoinfos.First(x => x.VideoType == VideoType.Mp4 && x.Resolution == 720);
                    VideoInfo video = checkP(videoinfos, displayP);

                    if (video != null)
                    {
                        if (video.RequiresDecryption)
                            DownloadUrlResolver.DecryptDownloadUrl(video);

                        string selectItems = string.Empty;

                        list_Keywords.Invoke(new Action(delegate
                        {
                            selectItems = list_Keywords.SelectedItem.ToString();
                        }));

                        //키워드 폴더를 만들어 분류하여 저장함
                        string createfolderPath = Path.Combine(txt_filePath.Text, selectItems);
                        if (!Directory.Exists(createfolderPath))
                        {
                            Directory.CreateDirectory(createfolderPath);
                        }

                        string videotitle = video.Title.Replace(@"\", "").Replace("/", "").Replace(":", "").Replace("*", "").Replace("?", "").Replace("\"", "").Replace("<", "").Replace(">", "").Replace("|", "");
                        string filepath = Path.Combine(createfolderPath, videotitle + video.VideoExtension);

                        //기존 존재하는 파일이 있다면 파일명 뒤에 _1을 붙임
                        //if (File.Exists(filepath))
                        //{
                        //    filepath = Path.Combine(createfolderPath, videotitle + "_1" + video.VideoExtension);
                        //}

                        var videoDownloader = new VideoDownloader(video, filepath);
                        try
                        {
                            videoDownloader.Execute();
                        }
                        catch
                        {
                            string error = string.Empty;
                            list_downUrls.Invoke(new Action(delegate
                            {
                                error = list_downUrls.SelectedItem + "\r\n";
                            }));

                            txt_errorUrls.Invoke(new Action(delegate
                            {
                                txt_errorUrls.Text += error;
                            }));
                        }

                        //파일이름과 링크를 텍스트파일에 저장해야한다.(VideoDB 수집문제)
                        writeLog(videotitle + " : " + list_downUrls.Items[j].ToString());

                    }
                    else
                    {
                        string error = string.Empty;
                        list_downUrls.Invoke(new Action(delegate
                        {
                            error = list_downUrls.SelectedItem + "\r\n";
                        }));

                        txt_errorUrls.Invoke(new Action(delegate
                        {
                            txt_errorUrls.Text += error;
                        }));

                        //txt_errorUrls.Text += list_downUrls.SelectedItem + "\r\n";
                    }
                }
                else
                {
                    string error = string.Empty;
                    list_downUrls.Invoke(new Action(delegate
                    {
                        error = list_downUrls.SelectedItem + "\r\n";
                    }));

                    txt_errorUrls.Invoke(new Action(delegate
                    {
                        txt_errorUrls.Text += error;
                    }));
                }
            }
            //cnd.Signal();
        }

        public void writeLog(string writeString)
        {
            string logfilepath = Path.Combine(txt_filePath.Text, logPath);

            FileStream fs = new FileStream(logfilepath, FileMode.Append, FileAccess.Write);
            StreamWriter file = new StreamWriter(fs, Encoding.UTF8);
            file.WriteLine(writeString);
            file.Flush();
            file.Close();
            fs.Close();
        }


        /// <summary>
        /// 존재하지 않는 해상도를 선택한경우 자동으로 하단의 해상도를 검색해본다.
        /// </summary>
        /// <param name="data">비디오 정보</param>
        /// <param name="Pdata">해상도</param>
        /// <returns></returns>
        public VideoInfo checkP(IEnumerable<VideoInfo> data, int Pdata)
        {
            VideoInfo checkdata = null;

            try
            {
                checkdata = data.First(x => x.VideoType == VideoType.Mp4 && x.Resolution == Pdata);
                selectSize = selectIndex;
            }
            catch
            {
                if (Pdata == 360)
                {
                    return null;
                }

                selectSize++;

                int cmbIndex = 0;
                cmb_size.Invoke(new Action(delegate
                {
                    cmbIndex = cmb_size.SelectedIndex;
                }));


                int indexdata = cmbIndex + selectSize;

                if (cmb_size.Items.Count > indexdata)
                {
                    int nextIndex = int.Parse(cmb_size.Items[indexdata].ToString());
                    checkdata = checkP(data, nextIndex);
                }
            }
            return checkdata;
        }

        /// <summary>
        /// 페이지를 넘기는 번호 'sp=' 값을 구해야한다.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public string getNextPSID(string query)
        {
            WebRequest req = WebRequest.Create(query);
            HttpWebRequest httpreq = (HttpWebRequest)req;
            httpreq.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            httpreq.UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_2) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.135 Safari/537.36";
            httpreq.Referer = "https://www.youtube.com";
            httpreq.ContentType = "text/html; charset=UTF-8";

            HttpWebResponse response = (HttpWebResponse)httpreq.GetResponse();
            Stream stReadData = response.GetResponseStream();
            StreamReader srReadData = new StreamReader(stReadData, Encoding.UTF8);

            // 응답 Stream -> 응답 String 변환
            string strResult = srReadData.ReadToEnd();

            //다음버튼 찾아 값을봐야함 results?sp=
            string[] nextArr = strResult.Replace("results?sp=", "≠").Split('≠');
            string NextData = string.Empty;

            if (nextArr.Length != 1)
            {
                int str = 0;
                int end = nextArr[nextArr.Length - 1].IndexOf("&");
                NextData = nextArr[nextArr.Length - 1].Substring(str, end);
            }
            else if (nextArr.Length == 1)
            {
                string[] splitArr = nextArr[0].Replace("sp=", "≠").Split('≠');
                int str = 0;
                int end = splitArr[splitArr.Length - 1].IndexOf("\"");
                NextData = splitArr[splitArr.Length - 1].Substring(str, end);
            }
            return "&sp=" + NextData;
        }

        /// <summary>
        /// 유튜브 영상 링크를 가져온다.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public List<string> getYouTubeID(string query)
        {
            List<string> idList = new List<string>();
            idList.Clear();

            WebRequest req = WebRequest.Create(query);
            HttpWebRequest httpreq = (HttpWebRequest)req;
            httpreq.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            httpreq.UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_2) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.135 Safari/537.36";
            httpreq.Referer = "https://www.youtube.com";
            httpreq.ContentType = "text/html; charset=UTF-8";

            HttpWebResponse response = (HttpWebResponse)httpreq.GetResponse();
            Stream stReadData = response.GetResponseStream();
            StreamReader srReadData = new StreamReader(stReadData, Encoding.UTF8);

            // 응답 Stream -> 응답 String 변환
            string strResult = srReadData.ReadToEnd();
            //data-context-item-id= 뒤에 유튜브 아이디 존재
            //watch?v
            string[] idArr = strResult.Replace("watch?v", "≠").Split('≠');
            //다음버튼 찾아 값을봐야함 results?sp=
            //string[] nextArr = strResult.Replace("results?sp", "≠").Split('≠');

            for (int i = 0; i < idArr.Length; i++)
            {
                if (idArr[i].IndexOf('=') == 0)
                {
                    int str1 = 1;
                    int end1 = idArr[i].IndexOf('\\') - 1;
                    string dataid1 = idArr[i].Substring(str1, end1);

                    if (!idList.Contains(dataid1))
                    {
                        idList.Add(dataid1);
                    }
                }
            }
            return idList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void resetlistboxnerror()
        {
            list_downUrls.Items.Clear();
            list_Keywords.Items.Clear();
            txt_errorUrls.Text = "";
        }

        private void btn_filePath_Click(object sender, EventArgs e)
        {
            resetlistboxnerror();

            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                txt_filePath.Text = fb.SelectedPath;
            }
        }

        private void btn_addtxt_Click(object sender, EventArgs e)
        {
            resetlistboxnerror();

            OpenFileDialog of = new OpenFileDialog();
            of.Multiselect = false;
            if (of.ShowDialog() == DialogResult.OK)
            {
                txt_txtFile.Text = of.FileName;

                StreamReader txtFile = new StreamReader(of.FileName, Encoding.Default, true);
                string line = string.Empty;

                list_Keywords.BeginUpdate();
                while ((line = txtFile.ReadLine()) != null)
                {
                    list_Keywords.Items.Add(line);
                }
                list_Keywords.EndUpdate();
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (txt_filePath.Text == string.Empty)
            {
                MessageBox.Show("경로를 설정하세요.");
                return;
            }

            if (cmb_downfiles.SelectedIndex == -1)
            {
                MessageBox.Show("다운로드 수량을 선택하세요.");
                return;
            }

            if (cmb_downfiles.SelectedIndex == -1)
            {
                MessageBox.Show("영상의 해상도를 선택해주세요.");
                return;
            }

            selectSize = cmb_size.SelectedIndex;
            selectIndex = cmb_size.SelectedIndex;

            //다운로드 시작
            Task work = new Task(() => getdownUrlList());
            work.Start();

            //getdownUrlList();
        }
    }
}
