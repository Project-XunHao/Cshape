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
            this.Path_TEXTBOX = new System.Windows.Forms.TextBox();
            this.Methods_COMBOBOX = new System.Windows.Forms.ComboBox();
            this.Add_Methods_BUTTON = new System.Windows.Forms.Button();
            this.Add_Methods_TEXTBOX = new System.Windows.Forms.TextBox();
            this.Delete_Methods_BUTTON = new System.Windows.Forms.Button();
            this.TABCONTROL = new System.Windows.Forms.TabControl();
            this.Picture_Deal_TABPAGE = new System.Windows.Forms.TabPage();
            this.Modify_BUTTON = new System.Windows.Forms.Button();
            this.Project_GROUPBOX = new System.Windows.Forms.GroupBox();
            this.Add_Project_Name_LABEL = new System.Windows.Forms.Label();
            this.Add_Project_TEXTBOX = new System.Windows.Forms.TextBox();
            this.Delete_Project_BUTTON = new System.Windows.Forms.Button();
            this.Add_Project_BUTTON = new System.Windows.Forms.Button();
            this.Project_Name_LABEL = new System.Windows.Forms.Label();
            this.Project_COMBOBOX = new System.Windows.Forms.ComboBox();
            this.DEBUG_GROUPBOX = new System.Windows.Forms.GroupBox();
            this.DEBUG_CLEAR_BUTTON = new System.Windows.Forms.Button();
            this.DEBUG_TEXTBOX = new System.Windows.Forms.TextBox();
            this.Save_BUTTON = new System.Windows.Forms.Button();
            this.Marco_GROUPBOX = new System.Windows.Forms.GroupBox();
            this.Marco_CheckBox = new System.Windows.Forms.CheckBox();
            this.Marco_Name_LABEL = new System.Windows.Forms.Label();
            this.Marco_Path_LABEL = new System.Windows.Forms.Label();
            this.Marco_Path_TEXT = new System.Windows.Forms.TextBox();
            this.Marco_Name_TEXT = new System.Windows.Forms.TextBox();
            this.Path_GROUPBOX = new System.Windows.Forms.GroupBox();
            this.Deal_Image_BUTTON = new System.Windows.Forms.Button();
            this.Methods_GROUPBOX = new System.Windows.Forms.GroupBox();
            this.Methods_LABEL = new System.Windows.Forms.Label();
            this.Add_Methods_LABEL = new System.Windows.Forms.Label();
            this.Code_Deal_TABPAGE = new System.Windows.Forms.TabPage();
            this.Edog_TABPAGE = new System.Windows.Forms.TabPage();
            this.ASSIC_TABPAGE = new System.Windows.Forms.TabPage();
            this.TABCONTROL.SuspendLayout();
            this.Picture_Deal_TABPAGE.SuspendLayout();
            this.Project_GROUPBOX.SuspendLayout();
            this.DEBUG_GROUPBOX.SuspendLayout();
            this.Marco_GROUPBOX.SuspendLayout();
            this.Path_GROUPBOX.SuspendLayout();
            this.Methods_GROUPBOX.SuspendLayout();
            this.SuspendLayout();
            // 
            // Path_TEXTBOX
            // 
            this.Path_TEXTBOX.Enabled = false;
            this.Path_TEXTBOX.Location = new System.Drawing.Point(6, 20);
            this.Path_TEXTBOX.Multiline = true;
            this.Path_TEXTBOX.Name = "Path_TEXTBOX";
            this.Path_TEXTBOX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Path_TEXTBOX.Size = new System.Drawing.Size(660, 115);
            this.Path_TEXTBOX.TabIndex = 0;
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
            // Delete_Methods_BUTTON
            // 
            this.Delete_Methods_BUTTON.Enabled = false;
            this.Delete_Methods_BUTTON.Location = new System.Drawing.Point(269, 45);
            this.Delete_Methods_BUTTON.Name = "Delete_Methods_BUTTON";
            this.Delete_Methods_BUTTON.Size = new System.Drawing.Size(89, 23);
            this.Delete_Methods_BUTTON.TabIndex = 5;
            this.Delete_Methods_BUTTON.Text = "删除";
            this.Delete_Methods_BUTTON.UseVisualStyleBackColor = true;
            this.Delete_Methods_BUTTON.Click += new System.EventHandler(this.Delete_Methods_BUTTON_Click);
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
            this.TABCONTROL.Size = new System.Drawing.Size(744, 414);
            this.TABCONTROL.TabIndex = 6;
            // 
            // Picture_Deal_TABPAGE
            // 
            this.Picture_Deal_TABPAGE.Controls.Add(this.Modify_BUTTON);
            this.Picture_Deal_TABPAGE.Controls.Add(this.Project_GROUPBOX);
            this.Picture_Deal_TABPAGE.Controls.Add(this.DEBUG_GROUPBOX);
            this.Picture_Deal_TABPAGE.Controls.Add(this.Save_BUTTON);
            this.Picture_Deal_TABPAGE.Controls.Add(this.Marco_GROUPBOX);
            this.Picture_Deal_TABPAGE.Controls.Add(this.Path_GROUPBOX);
            this.Picture_Deal_TABPAGE.Controls.Add(this.Methods_GROUPBOX);
            this.Picture_Deal_TABPAGE.Location = new System.Drawing.Point(4, 22);
            this.Picture_Deal_TABPAGE.Name = "Picture_Deal_TABPAGE";
            this.Picture_Deal_TABPAGE.Padding = new System.Windows.Forms.Padding(3);
            this.Picture_Deal_TABPAGE.Size = new System.Drawing.Size(736, 388);
            this.Picture_Deal_TABPAGE.TabIndex = 0;
            this.Picture_Deal_TABPAGE.Text = "图片编译";
            this.Picture_Deal_TABPAGE.UseVisualStyleBackColor = true;
            // 
            // Modify_BUTTON
            // 
            this.Modify_BUTTON.Location = new System.Drawing.Point(606, 7);
            this.Modify_BUTTON.Name = "Modify_BUTTON";
            this.Modify_BUTTON.Size = new System.Drawing.Size(59, 54);
            this.Modify_BUTTON.TabIndex = 14;
            this.Modify_BUTTON.Text = "修改";
            this.Modify_BUTTON.UseVisualStyleBackColor = true;
            this.Modify_BUTTON.Click += new System.EventHandler(this.Modify_BUTTON_Click);
            // 
            // Project_GROUPBOX
            // 
            this.Project_GROUPBOX.Controls.Add(this.Add_Project_Name_LABEL);
            this.Project_GROUPBOX.Controls.Add(this.Add_Project_TEXTBOX);
            this.Project_GROUPBOX.Controls.Add(this.Delete_Project_BUTTON);
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
            // Delete_Project_BUTTON
            // 
            this.Delete_Project_BUTTON.Enabled = false;
            this.Delete_Project_BUTTON.Location = new System.Drawing.Point(498, 18);
            this.Delete_Project_BUTTON.Name = "Delete_Project_BUTTON";
            this.Delete_Project_BUTTON.Size = new System.Drawing.Size(62, 23);
            this.Delete_Project_BUTTON.TabIndex = 11;
            this.Delete_Project_BUTTON.Text = "删除项目";
            this.Delete_Project_BUTTON.UseVisualStyleBackColor = true;
            this.Delete_Project_BUTTON.Click += new System.EventHandler(this.Remove_Project_BUTTON_Click);
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
            this.DEBUG_GROUPBOX.Controls.Add(this.DEBUG_CLEAR_BUTTON);
            this.DEBUG_GROUPBOX.Controls.Add(this.DEBUG_TEXTBOX);
            this.DEBUG_GROUPBOX.Location = new System.Drawing.Point(8, 282);
            this.DEBUG_GROUPBOX.Name = "DEBUG_GROUPBOX";
            this.DEBUG_GROUPBOX.Size = new System.Drawing.Size(720, 100);
            this.DEBUG_GROUPBOX.TabIndex = 12;
            this.DEBUG_GROUPBOX.TabStop = false;
            this.DEBUG_GROUPBOX.Text = "输出信息";
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
            // DEBUG_TEXTBOX
            // 
            this.DEBUG_TEXTBOX.Enabled = true;
            this.DEBUG_TEXTBOX.Location = new System.Drawing.Point(3, 16);
            this.DEBUG_TEXTBOX.Multiline = true;
            this.DEBUG_TEXTBOX.Name = "DEBUG_TEXTBOX";
            this.DEBUG_TEXTBOX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DEBUG_TEXTBOX.Size = new System.Drawing.Size(663, 78);
            this.DEBUG_TEXTBOX.TabIndex = 10;
            // 
            // Save_BUTTON
            // 
            this.Save_BUTTON.Enabled = false;
            this.Save_BUTTON.Location = new System.Drawing.Point(671, 6);
            this.Save_BUTTON.Name = "Save_BUTTON";
            this.Save_BUTTON.Size = new System.Drawing.Size(59, 55);
            this.Save_BUTTON.TabIndex = 12;
            this.Save_BUTTON.Text = "保存";
            this.Save_BUTTON.UseVisualStyleBackColor = true;
            this.Save_BUTTON.Click += new System.EventHandler(this.Save_BUTTON_Click);
            // 
            // Marco_GROUPBOX
            // 
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
            this.Marco_Path_TEXT.Size = new System.Drawing.Size(210, 21);
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
            this.Path_GROUPBOX.Controls.Add(this.Deal_Image_BUTTON);
            this.Path_GROUPBOX.Controls.Add(this.Path_TEXTBOX);
            this.Path_GROUPBOX.Location = new System.Drawing.Point(8, 137);
            this.Path_GROUPBOX.Name = "Path_GROUPBOX";
            this.Path_GROUPBOX.Size = new System.Drawing.Size(722, 141);
            this.Path_GROUPBOX.TabIndex = 7;
            this.Path_GROUPBOX.TabStop = false;
            this.Path_GROUPBOX.Text = "打包文件路径";
            // 
            // Deal_Image_BUTTON
            // 
            this.Deal_Image_BUTTON.Enabled = false;
            this.Deal_Image_BUTTON.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Deal_Image_BUTTON.Location = new System.Drawing.Point(672, 20);
            this.Deal_Image_BUTTON.Name = "Deal_Image_BUTTON";
            this.Deal_Image_BUTTON.Size = new System.Drawing.Size(42, 115);
            this.Deal_Image_BUTTON.TabIndex = 1;
            this.Deal_Image_BUTTON.Text = "开始编译图片镜像";
            this.Deal_Image_BUTTON.UseVisualStyleBackColor = true;
            this.Deal_Image_BUTTON.Click += new System.EventHandler(this.Deal_Image_BUTTON_Click);
            // 
            // Methods_GROUPBOX
            // 
            this.Methods_GROUPBOX.Controls.Add(this.Methods_LABEL);
            this.Methods_GROUPBOX.Controls.Add(this.Add_Methods_LABEL);
            this.Methods_GROUPBOX.Controls.Add(this.Methods_COMBOBOX);
            this.Methods_GROUPBOX.Controls.Add(this.Add_Methods_TEXTBOX);
            this.Methods_GROUPBOX.Controls.Add(this.Add_Methods_BUTTON);
            this.Methods_GROUPBOX.Controls.Add(this.Delete_Methods_BUTTON);
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
            // Code_Deal_TABPAGE
            // 
            this.Code_Deal_TABPAGE.Location = new System.Drawing.Point(4, 22);
            this.Code_Deal_TABPAGE.Name = "Code_Deal_TABPAGE";
            this.Code_Deal_TABPAGE.Padding = new System.Windows.Forms.Padding(3);
            this.Code_Deal_TABPAGE.Size = new System.Drawing.Size(736, 388);
            this.Code_Deal_TABPAGE.TabIndex = 1;
            this.Code_Deal_TABPAGE.Text = "代码编译";
            this.Code_Deal_TABPAGE.UseVisualStyleBackColor = true;
            // 
            // Edog_TABPAGE
            // 
            this.Edog_TABPAGE.Location = new System.Drawing.Point(4, 22);
            this.Edog_TABPAGE.Name = "Edog_TABPAGE";
            this.Edog_TABPAGE.Padding = new System.Windows.Forms.Padding(3);
            this.Edog_TABPAGE.Size = new System.Drawing.Size(736, 388);
            this.Edog_TABPAGE.TabIndex = 2;
            this.Edog_TABPAGE.Text = "电子狗数据打包";
            this.Edog_TABPAGE.UseVisualStyleBackColor = true;
            // 
            // ASSIC_TABPAGE
            // 
            this.ASSIC_TABPAGE.Location = new System.Drawing.Point(4, 22);
            this.ASSIC_TABPAGE.Name = "ASSIC_TABPAGE";
            this.ASSIC_TABPAGE.Padding = new System.Windows.Forms.Padding(3);
            this.ASSIC_TABPAGE.Size = new System.Drawing.Size(736, 388);
            this.ASSIC_TABPAGE.TabIndex = 3;
            this.ASSIC_TABPAGE.Text = "字符转换工具";
            this.ASSIC_TABPAGE.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 417);
            this.Controls.Add(this.TABCONTROL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "铂钛科技开发有限公司";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.TABCONTROL.ResumeLayout(false);
            this.Picture_Deal_TABPAGE.ResumeLayout(false);
            this.Project_GROUPBOX.ResumeLayout(false);
            this.Project_GROUPBOX.PerformLayout();
            this.DEBUG_GROUPBOX.ResumeLayout(false);
            this.DEBUG_GROUPBOX.PerformLayout();
            this.Marco_GROUPBOX.ResumeLayout(false);
            this.Marco_GROUPBOX.PerformLayout();
            this.Path_GROUPBOX.ResumeLayout(false);
            this.Path_GROUPBOX.PerformLayout();
            this.Methods_GROUPBOX.ResumeLayout(false);
            this.Methods_GROUPBOX.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Path_TEXTBOX;
        private System.Windows.Forms.ComboBox Methods_COMBOBOX;
        private System.Windows.Forms.Button Add_Methods_BUTTON;
        private System.Windows.Forms.TextBox Add_Methods_TEXTBOX;
        private System.Windows.Forms.Button Delete_Methods_BUTTON;
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
        private System.Windows.Forms.TextBox DEBUG_TEXTBOX;
        private System.Windows.Forms.GroupBox Project_GROUPBOX;
        private System.Windows.Forms.Button Save_BUTTON;
        private System.Windows.Forms.Button Delete_Project_BUTTON;
        private System.Windows.Forms.Button Add_Project_BUTTON;
        private System.Windows.Forms.Label Project_Name_LABEL;
        private System.Windows.Forms.ComboBox Project_COMBOBOX;
        private System.Windows.Forms.Button DEBUG_CLEAR_BUTTON;
        private System.Windows.Forms.Label Add_Project_Name_LABEL;
        private System.Windows.Forms.TextBox Add_Project_TEXTBOX;
        private System.Windows.Forms.Button Modify_BUTTON;
        private System.Windows.Forms.Button Deal_Image_BUTTON;
    }
}

