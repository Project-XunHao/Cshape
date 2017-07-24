
namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            if (disposing == true || disposing == false)
                base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_FilePath = new System.Windows.Forms.TextBox();
            this.Button_Browse_File = new System.Windows.Forms.Button();
            this.TextBox_Lat_Start = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_Lat_End = new System.Windows.Forms.TextBox();
            this.TextBox_Lon_Start = new System.Windows.Forms.TextBox();
            this.TextBox_Lon_End = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBox_Large_Lat_Width = new System.Windows.Forms.TextBox();
            this.TextBox_Large_Lon_Width = new System.Windows.Forms.TextBox();
            this.TextBox_Small_Lat_Width = new System.Windows.Forms.TextBox();
            this.TextBox_Small_Lon_Width = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBox_Large_Lat_Pack_Counts = new System.Windows.Forms.TextBox();
            this.TextBox_Large_Lon_Pack_Counts = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TextBox_Small_Lat_Pack_Counts = new System.Windows.Forms.TextBox();
            this.TextBox_Small_Lon_Pack_Counts = new System.Windows.Forms.TextBox();
            this.CheckBox_DIR_TYPE = new System.Windows.Forms.CheckBox();
            this.CheckBox_SPD_TYPE = new System.Windows.Forms.CheckBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label14 = new System.Windows.Forms.Label();
            this.TextBox_BinPath = new System.Windows.Forms.TextBox();
            this.Button_Save_File = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.TextBox_DataCount = new System.Windows.Forms.TextBox();
            this.Button_Convert = new System.Windows.Forms.Button();
            this.DGV_excel = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RichTextBox_Log = new System.Windows.Forms.RichTextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_excel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "加载文件:";
            // 
            // TextBox_FilePath
            // 
            this.TextBox_FilePath.Enabled = false;
            this.TextBox_FilePath.Location = new System.Drawing.Point(74, 13);
            this.TextBox_FilePath.Name = "TextBox_FilePath";
            this.TextBox_FilePath.Size = new System.Drawing.Size(660, 26);
            this.TextBox_FilePath.TabIndex = 1;
            // 
            // Button_Browse_File
            // 
            this.Button_Browse_File.Location = new System.Drawing.Point(741, 13);
            this.Button_Browse_File.Name = "Button_Browse_File";
            this.Button_Browse_File.Size = new System.Drawing.Size(86, 28);
            this.Button_Browse_File.TabIndex = 2;
            this.Button_Browse_File.Text = "打开";
            this.Button_Browse_File.UseVisualStyleBackColor = true;
            this.Button_Browse_File.Click += new System.EventHandler(this.Browse_File_Click);
            // 
            // TextBox_Lat_Start
            // 
            this.TextBox_Lat_Start.Enabled = false;
            this.TextBox_Lat_Start.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_Lat_Start.Location = new System.Drawing.Point(82, 190);
            this.TextBox_Lat_Start.Name = "TextBox_Lat_Start";
            this.TextBox_Lat_Start.Size = new System.Drawing.Size(39, 26);
            this.TextBox_Lat_Start.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lat Start:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(6, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lat End:";
            // 
            // TextBox_Lat_End
            // 
            this.TextBox_Lat_End.Enabled = false;
            this.TextBox_Lat_End.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_Lat_End.Location = new System.Drawing.Point(82, 223);
            this.TextBox_Lat_End.Name = "TextBox_Lat_End";
            this.TextBox_Lat_End.Size = new System.Drawing.Size(39, 26);
            this.TextBox_Lat_End.TabIndex = 6;
            // 
            // TextBox_Lon_Start
            // 
            this.TextBox_Lon_Start.Enabled = false;
            this.TextBox_Lon_Start.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_Lon_Start.Location = new System.Drawing.Point(200, 190);
            this.TextBox_Lon_Start.Name = "TextBox_Lon_Start";
            this.TextBox_Lon_Start.Size = new System.Drawing.Size(40, 26);
            this.TextBox_Lon_Start.TabIndex = 7;
            // 
            // TextBox_Lon_End
            // 
            this.TextBox_Lon_End.Enabled = false;
            this.TextBox_Lon_End.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_Lon_End.Location = new System.Drawing.Point(200, 223);
            this.TextBox_Lon_End.Name = "TextBox_Lon_End";
            this.TextBox_Lon_End.Size = new System.Drawing.Size(40, 26);
            this.TextBox_Lon_End.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lon Start:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lon End:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Large Lat Width:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Large Lon Width:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Small Lat Width:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Small Lon Width:";
            // 
            // TextBox_Large_Lat_Width
            // 
            this.TextBox_Large_Lat_Width.Enabled = false;
            this.TextBox_Large_Lat_Width.Location = new System.Drawing.Point(143, 257);
            this.TextBox_Large_Lat_Width.Name = "TextBox_Large_Lat_Width";
            this.TextBox_Large_Lat_Width.Size = new System.Drawing.Size(97, 26);
            this.TextBox_Large_Lat_Width.TabIndex = 15;
            // 
            // TextBox_Large_Lon_Width
            // 
            this.TextBox_Large_Lon_Width.Enabled = false;
            this.TextBox_Large_Lon_Width.Location = new System.Drawing.Point(143, 292);
            this.TextBox_Large_Lon_Width.Name = "TextBox_Large_Lon_Width";
            this.TextBox_Large_Lon_Width.Size = new System.Drawing.Size(97, 26);
            this.TextBox_Large_Lon_Width.TabIndex = 16;
            // 
            // TextBox_Small_Lat_Width
            // 
            this.TextBox_Small_Lat_Width.Enabled = false;
            this.TextBox_Small_Lat_Width.Location = new System.Drawing.Point(143, 326);
            this.TextBox_Small_Lat_Width.Name = "TextBox_Small_Lat_Width";
            this.TextBox_Small_Lat_Width.Size = new System.Drawing.Size(97, 26);
            this.TextBox_Small_Lat_Width.TabIndex = 17;
            // 
            // TextBox_Small_Lon_Width
            // 
            this.TextBox_Small_Lon_Width.Enabled = false;
            this.TextBox_Small_Lon_Width.Location = new System.Drawing.Point(143, 359);
            this.TextBox_Small_Lon_Width.Name = "TextBox_Small_Lon_Width";
            this.TextBox_Small_Lon_Width.Size = new System.Drawing.Size(97, 26);
            this.TextBox_Small_Lon_Width.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Large Lat Pack Counts:";
            // 
            // TextBox_Large_Lat_Pack_Counts
            // 
            this.TextBox_Large_Lat_Pack_Counts.Enabled = false;
            this.TextBox_Large_Lat_Pack_Counts.Location = new System.Drawing.Point(180, 395);
            this.TextBox_Large_Lat_Pack_Counts.Name = "TextBox_Large_Lat_Pack_Counts";
            this.TextBox_Large_Lat_Pack_Counts.Size = new System.Drawing.Size(60, 26);
            this.TextBox_Large_Lat_Pack_Counts.TabIndex = 20;
            // 
            // TextBox_Large_Lon_Pack_Counts
            // 
            this.TextBox_Large_Lon_Pack_Counts.Enabled = false;
            this.TextBox_Large_Lon_Pack_Counts.Location = new System.Drawing.Point(180, 428);
            this.TextBox_Large_Lon_Pack_Counts.Name = "TextBox_Large_Lon_Pack_Counts";
            this.TextBox_Large_Lon_Pack_Counts.Size = new System.Drawing.Size(60, 26);
            this.TextBox_Large_Lon_Pack_Counts.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Large Lon Pack Counts:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 459);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Small Lat Pack Counts:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 491);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Small Lon Pack Counts:";
            // 
            // TextBox_Small_Lat_Pack_Counts
            // 
            this.TextBox_Small_Lat_Pack_Counts.Enabled = false;
            this.TextBox_Small_Lat_Pack_Counts.Location = new System.Drawing.Point(180, 459);
            this.TextBox_Small_Lat_Pack_Counts.Name = "TextBox_Small_Lat_Pack_Counts";
            this.TextBox_Small_Lat_Pack_Counts.Size = new System.Drawing.Size(60, 26);
            this.TextBox_Small_Lat_Pack_Counts.TabIndex = 25;
            // 
            // TextBox_Small_Lon_Pack_Counts
            // 
            this.TextBox_Small_Lon_Pack_Counts.Enabled = false;
            this.TextBox_Small_Lon_Pack_Counts.Location = new System.Drawing.Point(180, 491);
            this.TextBox_Small_Lon_Pack_Counts.Name = "TextBox_Small_Lon_Pack_Counts";
            this.TextBox_Small_Lon_Pack_Counts.Size = new System.Drawing.Size(60, 26);
            this.TextBox_Small_Lon_Pack_Counts.TabIndex = 26;
            // 
            // CheckBox_DIR_TYPE
            // 
            this.CheckBox_DIR_TYPE.AutoSize = true;
            this.CheckBox_DIR_TYPE.Location = new System.Drawing.Point(10, 120);
            this.CheckBox_DIR_TYPE.Name = "CheckBox_DIR_TYPE";
            this.CheckBox_DIR_TYPE.Size = new System.Drawing.Size(91, 24);
            this.CheckBox_DIR_TYPE.TabIndex = 27;
            this.CheckBox_DIR_TYPE.Text = "DIR_TYPE";
            this.CheckBox_DIR_TYPE.UseVisualStyleBackColor = true;
            this.CheckBox_DIR_TYPE.CheckedChanged += new System.EventHandler(this.DIR_TYPE_Statue);
            this.CheckBox_DIR_TYPE.Enabled = false;
            // 
            // CheckBox_SPD_TYPE
            // 
            this.CheckBox_SPD_TYPE.AutoSize = true;
            this.CheckBox_SPD_TYPE.Location = new System.Drawing.Point(149, 120);
            this.CheckBox_SPD_TYPE.Name = "CheckBox_SPD_TYPE";
            this.CheckBox_SPD_TYPE.Size = new System.Drawing.Size(95, 24);
            this.CheckBox_SPD_TYPE.TabIndex = 28;
            this.CheckBox_SPD_TYPE.Text = "SPD_TYPE";
            this.CheckBox_SPD_TYPE.UseVisualStyleBackColor = true;
            this.CheckBox_SPD_TYPE.CheckedChanged += new System.EventHandler(this.SPE_TYPE_Statue);
            this.CheckBox_SPD_TYPE.Enabled = false;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(10, 636);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(816, 26);
            this.ProgressBar.TabIndex = 29;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 20);
            this.label14.TabIndex = 31;
            this.label14.Text = "生成镜像:";
            // 
            // TextBox_BinPath
            // 
            this.TextBox_BinPath.Enabled = false;
            this.TextBox_BinPath.Location = new System.Drawing.Point(74, 47);
            this.TextBox_BinPath.Name = "TextBox_BinPath";
            this.TextBox_BinPath.Size = new System.Drawing.Size(660, 26);
            this.TextBox_BinPath.TabIndex = 32;
            // 
            // Button_Save_File
            // 
            this.Button_Save_File.Enabled = false;
            this.Button_Save_File.Location = new System.Drawing.Point(741, 47);
            this.Button_Save_File.Name = "Button_Save_File";
            this.Button_Save_File.Size = new System.Drawing.Size(86, 26);
            this.Button_Save_File.TabIndex = 33;
            this.Button_Save_File.Text = "保存";
            this.Button_Save_File.UseVisualStyleBackColor = true;
            this.Button_Save_File.Click += new System.EventHandler(this.Save_File_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "总数据：";
            // 
            // TextBox_DataCount
            // 
            this.TextBox_DataCount.Enabled = false;
            this.TextBox_DataCount.Location = new System.Drawing.Point(74, 85);
            this.TextBox_DataCount.Name = "TextBox_DataCount";
            this.TextBox_DataCount.Size = new System.Drawing.Size(169, 26);
            this.TextBox_DataCount.TabIndex = 35;
            // 
            // Button_Convert
            // 
            this.Button_Convert.Enabled = false;
            this.Button_Convert.Location = new System.Drawing.Point(10, 150);
            this.Button_Convert.Name = "Button_Convert";
            this.Button_Convert.Size = new System.Drawing.Size(233, 33);
            this.Button_Convert.TabIndex = 36;
            this.Button_Convert.Text = "开始转换";
            this.Button_Convert.UseVisualStyleBackColor = true;
            this.Button_Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // DGV_excel
            // 
            this.DGV_excel.AllowUserToAddRows = false;
            this.DGV_excel.AllowUserToDeleteRows = false;
            this.DGV_excel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DGV_excel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_excel.Enabled = false;
            this.DGV_excel.Location = new System.Drawing.Point(249, 79);
            this.DGV_excel.Name = "DGV_excel";
            this.DGV_excel.ReadOnly = true;
            this.DGV_excel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_excel.RowTemplate.ReadOnly = true;
            this.DGV_excel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGV_excel.ShowRowErrors = false;
            this.DGV_excel.Size = new System.Drawing.Size(557, 525);
            this.DGV_excel.TabIndex = 20;
            // 
            // RichTextBox_Log
            // 
            this.RichTextBox_Log.Location = new System.Drawing.Point(10, 524);
            this.RichTextBox_Log.Name = "RichTextBox_Log";
            this.RichTextBox_Log.ReadOnly = true;
            this.RichTextBox_Log.Size = new System.Drawing.Size(230, 106);
            this.RichTextBox_Log.TabIndex = 38;
            this.RichTextBox_Log.Text = "";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Enabled = false;
            this.vScrollBar1.Location = new System.Drawing.Point(806, 85);
            this.vScrollBar1.Maximum = 110;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 541);
            this.vScrollBar1.TabIndex = 39;
            this.vScrollBar1.Value = 1;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Enabled = false;
            this.hScrollBar1.Location = new System.Drawing.Point(249, 604);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(557, 21);
            this.hScrollBar1.TabIndex = 40;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(842, 674);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.DGV_excel);
            this.Controls.Add(this.RichTextBox_Log);
            this.Controls.Add(this.Button_Convert);
            this.Controls.Add(this.TextBox_DataCount);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Button_Save_File);
            this.Controls.Add(this.TextBox_BinPath);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.CheckBox_SPD_TYPE);
            this.Controls.Add(this.CheckBox_DIR_TYPE);
            this.Controls.Add(this.TextBox_Small_Lon_Pack_Counts);
            this.Controls.Add(this.TextBox_Small_Lat_Pack_Counts);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TextBox_Large_Lon_Pack_Counts);
            this.Controls.Add(this.TextBox_Large_Lat_Pack_Counts);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TextBox_Small_Lon_Width);
            this.Controls.Add(this.TextBox_Small_Lat_Width);
            this.Controls.Add(this.TextBox_Large_Lon_Width);
            this.Controls.Add(this.TextBox_Large_Lat_Width);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBox_Lon_End);
            this.Controls.Add(this.TextBox_Lon_Start);
            this.Controls.Add(this.TextBox_Lat_End);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_Lat_Start);
            this.Controls.Add(this.Button_Browse_File);
            this.Controls.Add(this.TextBox_FilePath);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_excel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_FilePath;
        private System.Windows.Forms.Button Button_Browse_File;
        private System.Windows.Forms.TextBox TextBox_Lat_Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_Lat_End;
        private System.Windows.Forms.TextBox TextBox_Lon_Start;
        private System.Windows.Forms.TextBox TextBox_Lon_End;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBox_Large_Lat_Width;
        private System.Windows.Forms.TextBox TextBox_Large_Lon_Width;
        private System.Windows.Forms.TextBox TextBox_Small_Lat_Width;
        private System.Windows.Forms.TextBox TextBox_Small_Lon_Width;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextBox_Large_Lat_Pack_Counts;
        private System.Windows.Forms.TextBox TextBox_Large_Lon_Pack_Counts;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TextBox_Small_Lat_Pack_Counts;
        private System.Windows.Forms.TextBox TextBox_Small_Lon_Pack_Counts;
        private System.Windows.Forms.CheckBox CheckBox_DIR_TYPE;
        private System.Windows.Forms.CheckBox CheckBox_SPD_TYPE;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TextBox_BinPath;
        private System.Windows.Forms.Button Button_Save_File;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TextBox_DataCount;
        private System.Windows.Forms.Button Button_Convert;
        private System.Windows.Forms.DataGridView DGV_excel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox RichTextBox_Log;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}

