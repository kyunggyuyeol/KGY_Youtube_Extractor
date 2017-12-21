namespace youtubedownloader_webquery_
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_filePath = new System.Windows.Forms.TextBox();
            this.btn_filePath = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_addtxt = new System.Windows.Forms.Button();
            this.txt_txtFile = new System.Windows.Forms.TextBox();
            this.cmb_downfiles = new System.Windows.Forms.ComboBox();
            this.cmb_size = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.list_Keywords = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.list_downUrls = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_errorUrls = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.63758F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.36242F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.97313F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.02687F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(894, 521);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 171);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txt_filePath, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_filePath, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_start, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn_addtxt, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_txtFile, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmb_downfiles, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmb_size, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(395, 151);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Path:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "*.txt File:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "DownFiles :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Size :";
            // 
            // txt_filePath
            // 
            this.txt_filePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_filePath.Location = new System.Drawing.Point(82, 3);
            this.txt_filePath.Name = "txt_filePath";
            this.txt_filePath.ReadOnly = true;
            this.txt_filePath.Size = new System.Drawing.Size(231, 21);
            this.txt_filePath.TabIndex = 1;
            // 
            // btn_filePath
            // 
            this.btn_filePath.Location = new System.Drawing.Point(319, 3);
            this.btn_filePath.Name = "btn_filePath";
            this.btn_filePath.Size = new System.Drawing.Size(73, 23);
            this.btn_filePath.TabIndex = 2;
            this.btn_filePath.Text = "....";
            this.btn_filePath.UseVisualStyleBackColor = true;
            this.btn_filePath.Click += new System.EventHandler(this.btn_filePath_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(319, 123);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(73, 23);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "DownLoad";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_addtxt
            // 
            this.btn_addtxt.Location = new System.Drawing.Point(319, 33);
            this.btn_addtxt.Name = "btn_addtxt";
            this.btn_addtxt.Size = new System.Drawing.Size(73, 23);
            this.btn_addtxt.TabIndex = 2;
            this.btn_addtxt.Text = "...";
            this.btn_addtxt.UseVisualStyleBackColor = true;
            this.btn_addtxt.Click += new System.EventHandler(this.btn_addtxt_Click);
            // 
            // txt_txtFile
            // 
            this.txt_txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_txtFile.Location = new System.Drawing.Point(82, 33);
            this.txt_txtFile.Name = "txt_txtFile";
            this.txt_txtFile.ReadOnly = true;
            this.txt_txtFile.Size = new System.Drawing.Size(231, 21);
            this.txt_txtFile.TabIndex = 1;
            // 
            // cmb_downfiles
            // 
            this.cmb_downfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_downfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_downfiles.FormattingEnabled = true;
            this.cmb_downfiles.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.cmb_downfiles.Location = new System.Drawing.Point(82, 63);
            this.cmb_downfiles.Name = "cmb_downfiles";
            this.cmb_downfiles.Size = new System.Drawing.Size(231, 20);
            this.cmb_downfiles.TabIndex = 3;
            // 
            // cmb_size
            // 
            this.cmb_size.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_size.FormattingEnabled = true;
            this.cmb_size.Items.AddRange(new object[] {
            "1080",
            "720",
            "480",
            "360"});
            this.cmb_size.Location = new System.Drawing.Point(82, 93);
            this.cmb_size.Name = "cmb_size";
            this.cmb_size.Size = new System.Drawing.Size(231, 20);
            this.cmb_size.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.list_Keywords);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(410, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 171);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KeyWords";
            // 
            // list_Keywords
            // 
            this.list_Keywords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_Keywords.FormattingEnabled = true;
            this.list_Keywords.ItemHeight = 12;
            this.list_Keywords.Location = new System.Drawing.Point(3, 17);
            this.list_Keywords.Name = "list_Keywords";
            this.list_Keywords.Size = new System.Drawing.Size(475, 151);
            this.list_Keywords.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.list_downUrls);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 338);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DownLoads URL";
            // 
            // list_downUrls
            // 
            this.list_downUrls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_downUrls.FormattingEnabled = true;
            this.list_downUrls.ItemHeight = 12;
            this.list_downUrls.Location = new System.Drawing.Point(3, 17);
            this.list_downUrls.Name = "list_downUrls";
            this.list_downUrls.Size = new System.Drawing.Size(395, 318);
            this.list_downUrls.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_errorUrls);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(410, 180);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(481, 338);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Error URLs";
            // 
            // txt_errorUrls
            // 
            this.txt_errorUrls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_errorUrls.Location = new System.Drawing.Point(3, 17);
            this.txt_errorUrls.Multiline = true;
            this.txt_errorUrls.Name = "txt_errorUrls";
            this.txt_errorUrls.ReadOnly = true;
            this.txt_errorUrls.Size = new System.Drawing.Size(475, 318);
            this.txt_errorUrls.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 521);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "YoutubeDownloader(Web)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_filePath;
        private System.Windows.Forms.Button btn_filePath;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_addtxt;
        private System.Windows.Forms.TextBox txt_txtFile;
        private System.Windows.Forms.ComboBox cmb_downfiles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox list_Keywords;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox list_downUrls;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_errorUrls;
        private System.Windows.Forms.ComboBox cmb_size;
    }
}

