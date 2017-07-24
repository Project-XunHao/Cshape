namespace WindowsFormsApplication3
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
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Methods_COMBOBOX = new System.Windows.Forms.ComboBox();
            this.Add_Methods_BUTTON = new System.Windows.Forms.Button();
            this.Add_Methods_TEXTBOX = new System.Windows.Forms.TextBox();
            this.Del_Methods_BUTTON = new System.Windows.Forms.Button();
            this.TABCONTROL = new System.Windows.Forms.TabControl();
            this.Picture_Deal_TABPAGE = new System.Windows.Forms.TabPage();
            this.Modify_BUTTON = new System.Windows.Forms.Button();
            this.Project_GROUPBOX = new System.Windows.Forms.GroupBox();
            this.Add_Project_Name_LABEL = new System.Windows.Forms.Label();
            this.Add_Project_TEXTBOX = new System.Windows.Forms.TextBox();
            this.Del_Project_BUTTON = new System.Windows.Forms.Button();
            this.Add_Project_BUTTON = new System.Windows.Forms.Button();
            this.Project_Name_LABEL = new System.Windows.Forms.Label();
            this.Project_COMBOBOX = new System.Windows.Forms.ComboBox();
            this.DEBUG_GROUPBOX = new System.Windows.Forms.GroupBox();
            this.DEBUG_RICHTEXTBOX = new System.Windows.Forms.RichTextBox();
            this.DEBUG_CLEAR_BUTTON = new System.Windows.Forms.Button();
            this.Marco_GROUPBOX = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.Marco_CheckBox = new System.Windows.Forms.CheckBox();
            this.Marco_Name_LABEL = new System.Windows.Forms.Label();
            this.Marco_Path_LABEL = new System.Windows.Forms.Label();
            this.Marco_Path_TEXT = new System.Windows.Forms.TextBox();
            this.Marco_Name_TEXT = new System.Windows.Forms.TextBox();
            this.Path_GROUPBOX = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.Head_File_Dir_TEXTBOX = new System.Windows.Forms.TextBox();
            this.Head_File_Dir_LABEL = new System.Windows.Forms.Label();
            this.Reset_Path_BUTTON = new System.Windows.Forms.Button();
            this.Clear_Path_BUTTON = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Image_Dir_LABEL = new System.Windows.Forms.Label();
            this.Image_Dir_TEXTBOX = new System.Windows.Forms.TextBox();
            this.Add_Path_LABEL = new System.Windows.Forms.Label();
            this.Path_LABEL = new System.Windows.Forms.Label();
            this.Del_Path_BUTTON = new System.Windows.Forms.Button();
            this.Add_Path_BUTTON = new System.Windows.Forms.Button();
            this.Add_Path_TEXTBOX = new System.Windows.Forms.TextBox();
            this.Path_COMBOBOX = new System.Windows.Forms.ComboBox();
            this.Methods_GROUPBOX = new System.Windows.Forms.GroupBox();
            this.Methods_LABEL = new System.Windows.Forms.Label();
            this.Add_Methods_LABEL = new System.Windows.Forms.Label();
            this.Deal_Image_BUTTON = new System.Windows.Forms.Button();
            this.Code_Deal_TABPAGE = new System.Windows.Forms.TabPage();
            this.Edog_TABPAGE = new System.Windows.Forms.TabPage();
            this.ASSIC_TABPAGE = new System.Windows.Forms.TabPage();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.TABCONTROL.SuspendLayout();
            this.Picture_Deal_TABPAGE.SuspendLayout();
            this.Project_GROUPBOX.SuspendLayout();
            this.DEBUG_GROUPBOX.SuspendLayout();
            this.Marco_GROUPBOX.SuspendLayout();
            this.Path_GROUPBOX.SuspendLayout();
            this.Methods_GROUPBOX.SuspendLayout();
            this.SuspendLayout();
            // 
            // Methods_COMBOBOX
            // 
            this.Methods_COMBOBOX.FormattingEnabled = true;
            this.Methods_COMBOBOX.Location = new System.Drawing.Point(94, 17);
            this.Methods_COMBOBOX.Name = "Methods_COMBOBOX";
            this.Methods_COMBOBOX.Size = new System.Drawing.Size(169, 20);
            this.Methods_COMBOBOX.TabIndex = 2;
            this.Methods_COMBOBOX.SelectedIndexChanged += new System.EventHandler(this.Methods_COMBOBOX_SelectedIndexChanged);
            // 
            // Add_Methods_BUTTON
            // 
            this.Add_Methods_BUTTON.Enabled = false;
            this.Add_Methods_BUTTON.Location = new System.Drawing.Point(269, 15);
            this.Add_Methods_BUTTON.Name = "Add_Methods_BUTTON";
            this.Add_Methods_BUTTON.Size = new System.Drawing.Size(89, 23);
            this.Add_Methods_BUTTON.TabIndex = 3;
            this.Add_Methods_BUTTON.Text = "添加";
            this.Add_Methods_BUTTON.UseVisualStyleBackColor = true;
            this.Add_Methods_BUTTON.Click += new System.EventHandler(this.Add_Methods_BUTTON_Click);
            // 
            // Add_Methods_TEXTBOX
            // 
            this.Add_Methods_TEXTBOX.Enabled = false;
            this.Add_Methods_TEXTBOX.Location = new System.Drawing.Point(93, 45);
            this.Add_Methods_TEXTBOX.Name = "Add_Methods_TEXTBOX";
            this.Add_Methods_TEXTBOX.Size = new System.Drawing.Size(170, 21);
            this.Add_Methods_TEXTBOX.TabIndex = 4;
            // 
            // Del_Methods_BUTTON
            // 
            this.Del_Methods_BUTTON.Enabled = false;
            this.Del_Methods_BUTTON.Location = new System.Drawing.Point(269, 45);
            this.Del_Methods_BUTTON.Name = "Del_Methods_BUTTON";
            this.Del_Methods_BUTTON.Size = new System.Drawing.Size(89, 23);
            this.Del_Methods_BUTTON.TabIndex = 5;
            this.Del_Methods_BUTTON.Text = "删除";
            this.Del_Methods_BUTTON.UseVisualStyleBackColor = true;
            this.Del_Methods_BUTTON.Click += new System.EventHandler(this.Delete_Methods_BUTTON_Click);
            // 
            // TABCONTROL
            // 
            this.TABCONTROL.Controls.Add(this.Picture_Deal_TABPAGE);
            this.TABCONTROL.Controls.Add(this.Code_Deal_TABPAGE);
            this.TABCONTROL.Controls.Add(this.Edog_TABPAGE);
            this.TABCONTROL.Controls.Add(this.ASSIC_TABPAGE);
            this.TABCONTROL.Location = new System.Drawing.Point(3, 3);
            this.TABCONTROL.Name = "TABCONTROL";
            this.TABCONTROL.SelectedIndex = 0;
            this.TABCONTROL.Size = new System.Drawing.Size(744, 429);
            this.TABCONTROL.TabIndex = 6;
            // 
            // Picture_Deal_TABPAGE
            // 
            this.Picture_Deal_TABPAGE.Controls.Add(this.Modify_BUTTON);
            this.Picture_Deal_TABPAGE.Controls.Add(this.Project_GROUPBOX);
            this.Picture_Deal_TABPAGE.Controls.Add(this.DEBUG_GROUPBOX);
            this.Picture_Deal_TABPAGE.Controls.Add(this.Marco_GROUPBOX);
            this.Picture_Deal_TABPAGE.Controls.Add(this.Path_GROUPBOX);
            this.Picture_Deal_TABPAGE.Controls.Add(this.Methods_GROUPBOX);
            this.Picture_Deal_TABPAGE.Controls.Add(this.Deal_Image_BUTTON);
            this.Picture_Deal_TABPAGE.Location = new System.Drawing.Point(4, 22);
            this.Picture_Deal_TABPAGE.Name = "Picture_Deal_TABPAGE";
            this.Picture_Deal_TABPAGE.Padding = new System.Windows.Forms.Padding(3);
            this.Picture_Deal_TABPAGE.Size = new System.Drawing.Size(736, 403);
            this.Picture_Deal_TABPAGE.TabIndex = 0;
            this.Picture_Deal_TABPAGE.Text = "图片打包";
            this.Picture_Deal_TABPAGE.UseVisualStyleBackColor = true;
            // 
            // Modify_BUTTON
            // 
            this.Modify_BUTTON.Location = new System.Drawing.Point(586, 7);
            this.Modify_BUTTON.Name = "Modify_BUTTON";
            this.Modify_BUTTON.Size = new System.Drawing.Size(51, 46);
            this.Modify_BUTTON.TabIndex = 14;
            this.Modify_BUTTON.Text = "修改";
            this.Modify_BUTTON.UseVisualStyleBackColor = true;
            this.Modify_BUTTON.Click += new System.EventHandler(this.Modify_BUTTON_Click);
            // 
            // Project_GROUPBOX
            // 
            this.Project_GROUPBOX.Controls.Add(this.Add_Project_Name_LABEL);
            this.Project_GROUPBOX.Controls.Add(this.Add_Project_TEXTBOX);
            this.Project_GROUPBOX.Controls.Add(this.Del_Project_BUTTON);
            this.Project_GROUPBOX.Controls.Add(this.Add_Project_BUTTON);
            this.Project_GROUPBOX.Controls.Add(this.Project_Name_LABEL);
            this.Project_GROUPBOX.Controls.Add(this.Project_COMBOBOX);
            this.Project_GROUPBOX.Location = new System.Drawing.Point(8, 7);
            this.Project_GROUPBOX.Name = "Project_GROUPBOX";
            this.Project_GROUPBOX.Size = new System.Drawing.Size(571, 46);
            this.Project_GROUPBOX.TabIndex = 13;
            this.Project_GROUPBOX.TabStop = false;
            this.Project_GROUPBOX.Text = "项目";
            // 
            // Add_Project_Name_LABEL
            // 
            this.Add_Project_Name_LABEL.AutoSize = true;
            this.Add_Project_Name_LABEL.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Add_Project_Name_LABEL.Location = new System.Drawing.Point(205, 22);
            this.Add_Project_Name_LABEL.Name = "Add_Project_Name_LABEL";
            this.Add_Project_Name_LABEL.Size = new System.Drawing.Size(84, 14);
            this.Add_Project_Name_LABEL.TabIndex = 14;
            this.Add_Project_Name_LABEL.Text = "添加项目名:";
            // 
            // Add_Project_TEXTBOX
            // 
            this.Add_Project_TEXTBOX.Enabled = false;
            this.Add_Project_TEXTBOX.Location = new System.Drawing.Point(293, 18);
            this.Add_Project_TEXTBOX.Name = "Add_Project_TEXTBOX";
            this.Add_Project_TEXTBOX.Size = new System.Drawing.Size(130, 21);
            this.Add_Project_TEXTBOX.TabIndex = 13;
            // 
            // Del_Project_BUTTON
            // 
            this.Del_Project_BUTTON.Enabled = false;
            this.Del_Project_BUTTON.Location = new System.Drawing.Point(498, 18);
            this.Del_Project_BUTTON.Name = "Del_Project_BUTTON";
            this.Del_Project_BUTTON.Size = new System.Drawing.Size(62, 23);
            this.Del_Project_BUTTON.TabIndex = 11;
            this.Del_Project_BUTTON.Text = "删除项目";
            this.Del_Project_BUTTON.UseVisualStyleBackColor = true;
            this.Del_Project_BUTTON.Click += new System.EventHandler(this.Remove_Project_BUTTON_Click);
            // 
            // Add_Project_BUTTON
            // 
            this.Add_Project_BUTTON.Enabled = false;
            this.Add_Project_BUTTON.Location = new System.Drawing.Point(431, 18);
            this.Add_Project_BUTTON.Name = "Add_Project_BUTTON";
            this.Add_Project_BUTTON.Size = new System.Drawing.Size(61, 23);
            this.Add_Project_BUTTON.TabIndex = 10;
            this.Add_Project_BUTTON.Text = "添加项目";
            this.Add_Project_BUTTON.UseVisualStyleBackColor = true;
            this.Add_Project_BUTTON.Click += new System.EventHandler(this.Add_Project_BUTTON_Click);
            // 
            // Project_Name_LABEL
            // 
            this.Project_Name_LABEL.AutoSize = true;
            this.Project_Name_LABEL.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Project_Name_LABEL.Location = new System.Drawing.Point(6, 23);
            this.Project_Name_LABEL.Name = "Project_Name_LABEL";
            this.Project_Name_LABEL.Size = new System.Drawing.Size(56, 14);
            this.Project_Name_LABEL.TabIndex = 1;
            this.Project_Name_LABEL.Text = "项目名:";
            // 
            // Project_COMBOBOX
            // 
            this.Project_COMBOBOX.FormattingEnabled = true;
            this.Project_COMBOBOX.Location = new System.Drawing.Point(66, 20);
            this.Project_COMBOBOX.Name = "Project_COMBOBOX";
            this.Project_COMBOBOX.Size = new System.Drawing.Size(121, 20);
            this.Project_COMBOBOX.TabIndex = 0;
            this.Project_COMBOBOX.SelectedIndexChanged += new System.EventHandler(this.Project_COMBOBOX_SelectedIndexChanged);
            // 
            // DEBUG_GROUPBOX
            // 
            this.DEBUG_GROUPBOX.Controls.Add(this.DEBUG_RICHTEXTBOX);
            this.DEBUG_GROUPBOX.Controls.Add(this.DEBUG_CLEAR_BUTTON);
            this.DEBUG_GROUPBOX.Location = new System.Drawing.Point(8, 301);
            this.DEBUG_GROUPBOX.Name = "DEBUG_GROUPBOX";
            this.DEBUG_GROUPBOX.Size = new System.Drawing.Size(720, 100);
            this.DEBUG_GROUPBOX.TabIndex = 12;
            this.DEBUG_GROUPBOX.TabStop = false;
            this.DEBUG_GROUPBOX.Text = "输出信息";
            // 
            // DEBUG_RICHTEXTBOX
            // 
            this.DEBUG_RICHTEXTBOX.Location = new System.Drawing.Point(5, 16);
            this.DEBUG_RICHTEXTBOX.Name = "DEBUG_RICHTEXTBOX";
            this.DEBUG_RICHTEXTBOX.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.DEBUG_RICHTEXTBOX.Size = new System.Drawing.Size(661, 78);
            this.DEBUG_RICHTEXTBOX.TabIndex = 13;
            this.DEBUG_RICHTEXTBOX.Text = "";
            this.DEBUG_RICHTEXTBOX.ReadOnly = true;
            // 
            // DEBUG_CLEAR_BUTTON
            // 
            this.DEBUG_CLEAR_BUTTON.Location = new System.Drawing.Point(672, 16);
            this.DEBUG_CLEAR_BUTTON.Name = "DEBUG_CLEAR_BUTTON";
            this.DEBUG_CLEAR_BUTTON.Size = new System.Drawing.Size(42, 78);
            this.DEBUG_CLEAR_BUTTON.TabIndex = 12;
            this.DEBUG_CLEAR_BUTTON.Text = "清空";
            this.DEBUG_CLEAR_BUTTON.UseVisualStyleBackColor = true;
            // 
            // Marco_GROUPBOX
            // 
            this.Marco_GROUPBOX.Controls.Add(this.button5);
            this.Marco_GROUPBOX.Controls.Add(this.Marco_CheckBox);
            this.Marco_GROUPBOX.Controls.Add(this.Marco_Name_LABEL);
            this.Marco_GROUPBOX.Controls.Add(this.Marco_Path_LABEL);
            this.Marco_GROUPBOX.Controls.Add(this.Marco_Path_TEXT);
            this.Marco_GROUPBOX.Controls.Add(this.Marco_Name_TEXT);
            this.Marco_GROUPBOX.Location = new System.Drawing.Point(381, 59);
            this.Marco_GROUPBOX.Name = "Marco_GROUPBOX";
            this.Marco_GROUPBOX.Size = new System.Drawing.Size(347, 73);
            this.Marco_GROUPBOX.TabIndex = 8;
            this.Marco_GROUPBOX.TabStop = false;
            this.Marco_GROUPBOX.Text = "自动设置镜像大小";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(298, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Marco_CheckBox
            // 
            this.Marco_CheckBox.AutoSize = true;
            this.Marco_CheckBox.Location = new System.Drawing.Point(10, 21);
            this.Marco_CheckBox.Name = "Marco_CheckBox";
            this.Marco_CheckBox.Size = new System.Drawing.Size(48, 16);
            this.Marco_CheckBox.TabIndex = 5;
            this.Marco_CheckBox.Text = "启用";
            this.Marco_CheckBox.UseVisualStyleBackColor = true;
            this.Marco_CheckBox.CheckedChanged += new System.EventHandler(this.Marco_CheckBox_CheckedChanged);
            // 
            // Marco_Name_LABEL
            // 
            this.Marco_Name_LABEL.AutoSize = true;
            this.Marco_Name_LABEL.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Marco_Name_LABEL.Location = new System.Drawing.Point(72, 23);
            this.Marco_Name_LABEL.Name = "Marco_Name_LABEL";
            this.Marco_Name_LABEL.Size = new System.Drawing.Size(56, 14);
            this.Marco_Name_LABEL.TabIndex = 4;
            this.Marco_Name_LABEL.Text = "宏名字:";
            // 
            // Marco_Path_LABEL
            // 
            this.Marco_Path_LABEL.AutoSize = true;
            this.Marco_Path_LABEL.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Marco_Path_LABEL.Location = new System.Drawing.Point(16, 48);
            this.Marco_Path_LABEL.Name = "Marco_Path_LABEL";
            this.Marco_Path_LABEL.Size = new System.Drawing.Size(112, 14);
            this.Marco_Path_LABEL.TabIndex = 3;
            this.Marco_Path_LABEL.Text = "宏所在文件路径:";
            // 
            // Marco_Path_TEXT
            // 
            this.Marco_Path_TEXT.Location = new System.Drawing.Point(131, 45);
            this.Marco_Path_TEXT.Multiline = true;
            this.Marco_Path_TEXT.Name = "Marco_Path_TEXT";
            this.Marco_Path_TEXT.Size = new System.Drawing.Size(167, 21);
            this.Marco_Path_TEXT.TabIndex = 1;
            // 
            // Marco_Name_TEXT
            // 
            this.Marco_Name_TEXT.Location = new System.Drawing.Point(131, 19);
            this.Marco_Name_TEXT.Name = "Marco_Name_TEXT";
            this.Marco_Name_TEXT.Size = new System.Drawing.Size(210, 21);
            this.Marco_Name_TEXT.TabIndex = 0;
            // 
            // Path_GROUPBOX
            // 
            this.Path_GROUPBOX.Controls.Add(this.button9);
            this.Path_GROUPBOX.Controls.Add(this.Head_File_Dir_TEXTBOX);
            this.Path_GROUPBOX.Controls.Add(this.Head_File_Dir_LABEL);
            this.Path_GROUPBOX.Controls.Add(this.Reset_Path_BUTTON);
            this.Path_GROUPBOX.Controls.Add(this.Clear_Path_BUTTON);
            this.Path_GROUPBOX.Controls.Add(this.button4);
            this.Path_GROUPBOX.Controls.Add(this.button3);
            this.Path_GROUPBOX.Controls.Add(this.Image_Dir_LABEL);
            this.Path_GROUPBOX.Controls.Add(this.Image_Dir_TEXTBOX);
            this.Path_GROUPBOX.Controls.Add(this.Add_Path_LABEL);
            this.Path_GROUPBOX.Controls.Add(this.Path_LABEL);
            this.Path_GROUPBOX.Controls.Add(this.Del_Path_BUTTON);
            this.Path_GROUPBOX.Controls.Add(this.Add_Path_BUTTON);
            this.Path_GROUPBOX.Controls.Add(this.Add_Path_TEXTBOX);
            this.Path_GROUPBOX.Controls.Add(this.Path_COMBOBOX);
            this.Path_GROUPBOX.Location = new System.Drawing.Point(8, 137);
            this.Path_GROUPBOX.Name = "Path_GROUPBOX";
            this.Path_GROUPBOX.Size = new System.Drawing.Size(722, 158);
            this.Path_GROUPBOX.TabIndex = 7;
            this.Path_GROUPBOX.TabStop = false;
            this.Path_GROUPBOX.Text = "打包文件路径";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(671, 100);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(46, 23);
            this.button9.TabIndex = 16;
            this.button9.Text = "...";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // Head_File_Dir_TEXTBOX
            // 
            this.Head_File_Dir_TEXTBOX.Location = new System.Drawing.Point(122, 101);
            this.Head_File_Dir_TEXTBOX.Name = "Head_File_Dir_TEXTBOX";
            this.Head_File_Dir_TEXTBOX.Size = new System.Drawing.Size(549, 21);
            this.Head_File_Dir_TEXTBOX.TabIndex = 15;
            // 
            // Head_File_Dir_LABEL
            // 
            this.Head_File_Dir_LABEL.AutoSize = true;
            this.Head_File_Dir_LABEL.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Head_File_Dir_LABEL.Location = new System.Drawing.Point(4, 104);
            this.Head_File_Dir_LABEL.Name = "Head_File_Dir_LABEL";
            this.Head_File_Dir_LABEL.Size = new System.Drawing.Size(112, 14);
            this.Head_File_Dir_LABEL.TabIndex = 14;
            this.Head_File_Dir_LABEL.Text = "头文件生成目录:";
            // 
            // Reset_Path_BUTTON
            // 
            this.Reset_Path_BUTTON.Location = new System.Drawing.Point(536, 129);
            this.Reset_Path_BUTTON.Name = "Reset_Path_BUTTON";
            this.Reset_Path_BUTTON.Size = new System.Drawing.Size(182, 23);
            this.Reset_Path_BUTTON.TabIndex = 13;
            this.Reset_Path_BUTTON.Text = "恢复默认值";
            this.Reset_Path_BUTTON.UseVisualStyleBackColor = true;
            // 
            // Clear_Path_BUTTON
            // 
            this.Clear_Path_BUTTON.Location = new System.Drawing.Point(365, 129);
            this.Clear_Path_BUTTON.Name = "Clear_Path_BUTTON";
            this.Clear_Path_BUTTON.Size = new System.Drawing.Size(167, 23);
            this.Clear_Path_BUTTON.TabIndex = 12;
            this.Clear_Path_BUTTON.Text = "清空";
            this.Clear_Path_BUTTON.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(671, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(671, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Image_Dir_LABEL
            // 
            this.Image_Dir_LABEL.AutoSize = true;
            this.Image_Dir_LABEL.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Image_Dir_LABEL.Location = new System.Drawing.Point(4, 77);
            this.Image_Dir_LABEL.Name = "Image_Dir_LABEL";
            this.Image_Dir_LABEL.Size = new System.Drawing.Size(98, 14);
            this.Image_Dir_LABEL.TabIndex = 9;
            this.Image_Dir_LABEL.Text = "镜像生成目录:";
            // 
            // Image_Dir_TEXTBOX
            // 
            this.Image_Dir_TEXTBOX.Location = new System.Drawing.Point(108, 74);
            this.Image_Dir_TEXTBOX.Name = "Image_Dir_TEXTBOX";
            this.Image_Dir_TEXTBOX.Size = new System.Drawing.Size(563, 21);
            this.Image_Dir_TEXTBOX.TabIndex = 8;
            // 
            // Add_Path_LABEL
            // 
            this.Add_Path_LABEL.AutoSize = true;
            this.Add_Path_LABEL.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Add_Path_LABEL.Location = new System.Drawing.Point(3, 50);
            this.Add_Path_LABEL.Name = "Add_Path_LABEL";
            this.Add_Path_LABEL.Size = new System.Drawing.Size(84, 14);
            this.Add_Path_LABEL.TabIndex = 7;
            this.Add_Path_LABEL.Text = "添加新路径:";
            // 
            // Path_LABEL
            // 
            this.Path_LABEL.AutoSize = true;
            this.Path_LABEL.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Path_LABEL.Location = new System.Drawing.Point(2, 23);
            this.Path_LABEL.Name = "Path_LABEL";
            this.Path_LABEL.Size = new System.Drawing.Size(84, 14);
            this.Path_LABEL.TabIndex = 6;
            this.Path_LABEL.Text = "文件夹路径:";
            // 
            // Del_Path_BUTTON
            // 
            this.Del_Path_BUTTON.Location = new System.Drawing.Point(184, 129);
            this.Del_Path_BUTTON.Name = "Del_Path_BUTTON";
            this.Del_Path_BUTTON.Size = new System.Drawing.Size(175, 23);
            this.Del_Path_BUTTON.TabIndex = 5;
            this.Del_Path_BUTTON.Text = "删除当前选择项";
            this.Del_Path_BUTTON.UseVisualStyleBackColor = true;
            // 
            // Add_Path_BUTTON
            // 
            this.Add_Path_BUTTON.Location = new System.Drawing.Point(0, 129);
            this.Add_Path_BUTTON.Name = "Add_Path_BUTTON";
            this.Add_Path_BUTTON.Size = new System.Drawing.Size(178, 23);
            this.Add_Path_BUTTON.TabIndex = 4;
            this.Add_Path_BUTTON.Text = "确认添加";
            this.Add_Path_BUTTON.UseVisualStyleBackColor = true;
            this.Add_Path_BUTTON.Click += new System.EventHandler(this.Add_Path_BUTTON_Click);
            // 
            // Add_Path_TEXTBOX
            // 
            this.Add_Path_TEXTBOX.Location = new System.Drawing.Point(91, 46);
            this.Add_Path_TEXTBOX.Name = "Add_Path_TEXTBOX";
            this.Add_Path_TEXTBOX.Size = new System.Drawing.Size(580, 21);
            this.Add_Path_TEXTBOX.TabIndex = 3;
            // 
            // Path_COMBOBOX
            // 
            this.Path_COMBOBOX.FormattingEnabled = true;
            this.Path_COMBOBOX.Location = new System.Drawing.Point(92, 20);
            this.Path_COMBOBOX.Name = "Path_COMBOBOX";
            this.Path_COMBOBOX.Size = new System.Drawing.Size(624, 20);
            this.Path_COMBOBOX.TabIndex = 2;
            // 
            // Methods_GROUPBOX
            // 
            this.Methods_GROUPBOX.Controls.Add(this.Methods_LABEL);
            this.Methods_GROUPBOX.Controls.Add(this.Add_Methods_LABEL);
            this.Methods_GROUPBOX.Controls.Add(this.Methods_COMBOBOX);
            this.Methods_GROUPBOX.Controls.Add(this.Add_Methods_TEXTBOX);
            this.Methods_GROUPBOX.Controls.Add(this.Add_Methods_BUTTON);
            this.Methods_GROUPBOX.Controls.Add(this.Del_Methods_BUTTON);
            this.Methods_GROUPBOX.Location = new System.Drawing.Point(6, 59);
            this.Methods_GROUPBOX.Name = "Methods_GROUPBOX";
            this.Methods_GROUPBOX.Size = new System.Drawing.Size(365, 73);
            this.Methods_GROUPBOX.TabIndex = 6;
            this.Methods_GROUPBOX.TabStop = false;
            this.Methods_GROUPBOX.Text = "方法";
            // 
            // Methods_LABEL
            // 
            this.Methods_LABEL.AutoSize = true;
            this.Methods_LABEL.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Methods_LABEL.Location = new System.Drawing.Point(9, 20);
            this.Methods_LABEL.Name = "Methods_LABEL";
            this.Methods_LABEL.Size = new System.Drawing.Size(77, 14);
            this.Methods_LABEL.TabIndex = 7;
            this.Methods_LABEL.Text = "选择方法：";
            // 
            // Add_Methods_LABEL
            // 
            this.Add_Methods_LABEL.AutoSize = true;
            this.Add_Methods_LABEL.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Add_Methods_LABEL.Location = new System.Drawing.Point(6, 48);
            this.Add_Methods_LABEL.Name = "Add_Methods_LABEL";
            this.Add_Methods_LABEL.Size = new System.Drawing.Size(84, 14);
            this.Add_Methods_LABEL.TabIndex = 6;
            this.Add_Methods_LABEL.Text = "添加方法名:";
            // 
            // Deal_Image_BUTTON
            // 
            this.Deal_Image_BUTTON.Enabled = false;
            this.Deal_Image_BUTTON.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Deal_Image_BUTTON.Location = new System.Drawing.Point(643, 7);
            this.Deal_Image_BUTTON.Name = "Deal_Image_BUTTON";
            this.Deal_Image_BUTTON.Size = new System.Drawing.Size(87, 46);
            this.Deal_Image_BUTTON.TabIndex = 1;
            this.Deal_Image_BUTTON.Text = "打包图片数据";
            this.Deal_Image_BUTTON.UseVisualStyleBackColor = true;
            this.Deal_Image_BUTTON.Click += new System.EventHandler(this.Deal_Image_BUTTON_Click);
            // 
            // Code_Deal_TABPAGE
            // 
            this.Code_Deal_TABPAGE.Location = new System.Drawing.Point(4, 22);
            this.Code_Deal_TABPAGE.Name = "Code_Deal_TABPAGE";
            this.Code_Deal_TABPAGE.Padding = new System.Windows.Forms.Padding(3);
            this.Code_Deal_TABPAGE.Size = new System.Drawing.Size(736, 403);
            this.Code_Deal_TABPAGE.TabIndex = 1;
            this.Code_Deal_TABPAGE.Text = "代码打包";
            this.Code_Deal_TABPAGE.UseVisualStyleBackColor = true;
            // 
            // Edog_TABPAGE
            // 
            this.Edog_TABPAGE.Location = new System.Drawing.Point(4, 22);
            this.Edog_TABPAGE.Name = "Edog_TABPAGE";
            this.Edog_TABPAGE.Padding = new System.Windows.Forms.Padding(3);
            this.Edog_TABPAGE.Size = new System.Drawing.Size(736, 403);
            this.Edog_TABPAGE.TabIndex = 2;
            this.Edog_TABPAGE.Text = "电子狗数据打包";
            this.Edog_TABPAGE.UseVisualStyleBackColor = true;
            // 
            // ASSIC_TABPAGE
            // 
            this.ASSIC_TABPAGE.Location = new System.Drawing.Point(4, 22);
            this.ASSIC_TABPAGE.Name = "ASSIC_TABPAGE";
            this.ASSIC_TABPAGE.Padding = new System.Windows.Forms.Padding(3);
            this.ASSIC_TABPAGE.Size = new System.Drawing.Size(736, 403);
            this.ASSIC_TABPAGE.TabIndex = 3;
            this.ASSIC_TABPAGE.Text = "字符转换工具";
            this.ASSIC_TABPAGE.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 433);
            this.Controls.Add(this.TABCONTROL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "铂钛科技开发有限公司 - 开发工具集";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.TABCONTROL.ResumeLayout(false);
            this.Picture_Deal_TABPAGE.ResumeLayout(false);
            this.Project_GROUPBOX.ResumeLayout(false);
            this.Project_GROUPBOX.PerformLayout();
            this.DEBUG_GROUPBOX.ResumeLayout(false);
            this.Marco_GROUPBOX.ResumeLayout(false);
            this.Marco_GROUPBOX.PerformLayout();
            this.Path_GROUPBOX.ResumeLayout(false);
            this.Path_GROUPBOX.PerformLayout();
            this.Methods_GROUPBOX.ResumeLayout(false);
            this.Methods_GROUPBOX.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Methods_COMBOBOX;
        private System.Windows.Forms.Button Add_Methods_BUTTON;
        private System.Windows.Forms.TextBox Add_Methods_TEXTBOX;
        private System.Windows.Forms.Button Del_Methods_BUTTON;
        private System.Windows.Forms.TabControl TABCONTROL;
        private System.Windows.Forms.TabPage Picture_Deal_TABPAGE;
        private System.Windows.Forms.TabPage Code_Deal_TABPAGE;
        private System.Windows.Forms.TabPage Edog_TABPAGE;
        private System.Windows.Forms.GroupBox Methods_GROUPBOX;
        private System.Windows.Forms.GroupBox Path_GROUPBOX;
        private System.Windows.Forms.TabPage ASSIC_TABPAGE;
        private System.Windows.Forms.GroupBox Marco_GROUPBOX;
        private System.Windows.Forms.Label Marco_Name_LABEL;
        private System.Windows.Forms.Label Marco_Path_LABEL;
        private System.Windows.Forms.TextBox Marco_Path_TEXT;
        private System.Windows.Forms.TextBox Marco_Name_TEXT;
        private System.Windows.Forms.CheckBox Marco_CheckBox;
        private System.Windows.Forms.Label Methods_LABEL;
        private System.Windows.Forms.Label Add_Methods_LABEL;
        private System.Windows.Forms.GroupBox DEBUG_GROUPBOX;
        private System.Windows.Forms.GroupBox Project_GROUPBOX;
        private System.Windows.Forms.Button Del_Project_BUTTON;
        private System.Windows.Forms.Button Add_Project_BUTTON;
        private System.Windows.Forms.Label Project_Name_LABEL;
        private System.Windows.Forms.ComboBox Project_COMBOBOX;
        private System.Windows.Forms.Button DEBUG_CLEAR_BUTTON;
        private System.Windows.Forms.Label Add_Project_Name_LABEL;
        private System.Windows.Forms.TextBox Add_Project_TEXTBOX;
        private System.Windows.Forms.Button Deal_Image_BUTTON;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Reset_Path_BUTTON;
        private System.Windows.Forms.Button Clear_Path_BUTTON;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Image_Dir_LABEL;
        private System.Windows.Forms.TextBox Image_Dir_TEXTBOX;
        private System.Windows.Forms.Label Add_Path_LABEL;
        private System.Windows.Forms.Label Path_LABEL;
        private System.Windows.Forms.Button Del_Path_BUTTON;
        private System.Windows.Forms.Button Add_Path_BUTTON;
        private System.Windows.Forms.TextBox Add_Path_TEXTBOX;
        private System.Windows.Forms.ComboBox Path_COMBOBOX;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button Modify_BUTTON;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox Head_File_Dir_TEXTBOX;
        private System.Windows.Forms.Label Head_File_Dir_LABEL;
        private System.Windows.Forms.RichTextBox DEBUG_RICHTEXTBOX;
    }
}

