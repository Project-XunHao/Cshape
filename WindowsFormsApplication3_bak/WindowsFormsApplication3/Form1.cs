using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        String Info_Name = @"./Default_Info.ini";
        String Src_Project_Name = @"./Default_Info_.ini";
        String Project_Name;

        FileStream Info_Fs, Project_Fs;
        Type_Info Info = new Type_Info();
        public Form1()
        {
            InitializeComponent();

            if (File.Exists(Info_Name) == false)
            {
                Info_Fs = new FileStream(Info_Name, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                Info_Fs.Close();
                File.SetAttributes(Info_Name, FileAttributes.Hidden);

                DEBUG_TEXTBOX.AppendText("创建配置文件\r\n");
            }
            else 
            {
                Info_Fs = new FileStream(Info_Name, FileMode.Open, FileAccess.Read);
                StreamReader Info_SR = new StreamReader(Info_Fs);

                String Line;
                String[] Project;

                if (!Info_SR.EndOfStream)
                {
                    this.Methods_COMBOBOX.Enabled = true;
                    DEBUG_TEXTBOX.AppendText("读取配置文件\r\n");

                    Line = Info_SR.ReadLine();//读取所有项目
                    Project = Line.Split(';');
                    List<String> list = new List<String>();

                    for (int n = 0; n < Project.Length; n++)
                    {
                        if (Project[n].IndexOfAny(new char[] { '\0', ' ', '\n', '\r' }) != 0 && Project[n].Equals("") == false)
                        {
                            list.Add(Project[n]);
                        }
                    }

                    DEBUG_TEXTBOX.AppendText("读取到项目：");
                    for (int n = 0; n < list.Count; n++)
                    {
                        Info.Add_Info(list[n]);
                        Project_COMBOBOX.Items.Add(list[n]);

                        DEBUG_TEXTBOX.AppendText(list[n]);

                        if (n < list.Count - 1)
                        {
                            DEBUG_TEXTBOX.AppendText("、");
                        }
                    }
                    DEBUG_TEXTBOX.AppendText("\r\n");

                    Line = Info_SR.ReadLine();

                    int Start = Line.LastIndexOf("=");
                    int End = Line.LastIndexOf("=");
                    String StartPos, EndPos;

                    if (Start >= 0 && End >= 0)
                    {
                        StartPos = Line.Substring(0, Start);
                        EndPos = Line.Substring(End + 1);

                        if (StartPos.Equals("DEFAULT") == true)
                        {
                            DEBUG_TEXTBOX.AppendText("当前选择项目:" + EndPos + "\r\n");

                            //下拉列表默认选择那个项目（这里设置完后会调用 Project_COMBOBOX_SelectedIndexChanged 函数）
                            Project_COMBOBOX.SelectedItem = EndPos;
                        }
                    }
                }
                else 
                {
                    DEBUG_TEXTBOX.AppendText("配置文件为空\r\n");                    
                }

                Info_SR.Close();
                Info_Fs.Close();
            }
        }

        private void Read_Methods_File(String Project)
        {
            int Pos = Info_Name.IndexOf(".ini");
            if (Pos >= 0)
            {
                Project_Name = Src_Project_Name.Insert(Pos + 1, Project);

                if (File.Exists(Project_Name) == false)
                {
                    Project_Fs = new FileStream(Project_Name, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    Project_Fs.Close();
                    File.SetAttributes(Project_Name, FileAttributes.Hidden);

                    DEBUG_TEXTBOX.AppendText("创建" + Project + "项目配置文件\r\n");
                }
                else
                {
                    Project_Fs = new FileStream(Project_Name, FileMode.Open, FileAccess.Read);
                    StreamReader Project_SR = new StreamReader(Project_Fs);

                    if (!Project_SR.EndOfStream)
                    {
                        this.Methods_COMBOBOX.Enabled = true;
                        DEBUG_TEXTBOX.AppendText("读取" + Project + "项目配置文件\r\n");
                        
                        int Start, End;
                        String Name, Path, StartPos2, EndPos2, StartPos3, EndPos3;

                        while (!Project_SR.EndOfStream)
                        {
                            Name = Project_SR.ReadLine();//读取一行数据

                            Start = Name.LastIndexOf("=");
                            End = Name.LastIndexOf("=");

                            if (Start >= 0 && End >= 0)
                            {
                                StartPos2 = Name.Substring(0, Start);
                                EndPos2 = Name.Substring(End + 1);
                                if (StartPos2.Equals("NAME") == true)
                                {
                                    Methods_COMBOBOX.Items.Add(EndPos2);
                                    DEBUG_TEXTBOX.AppendText("读取到方法：" + EndPos2 + "\r\n");

                                    Path = Project_SR.ReadLine();
                                    StartPos3 = Path.Substring(0, Path.LastIndexOf("="));
                                    EndPos3 = Path.Substring(Path.LastIndexOf("=") + 1);

                                    Info.Add_Methods(Project, EndPos2, EndPos3);
                                    DEBUG_TEXTBOX.AppendText("读取到路径：" + EndPos3 + "\r\n");
                                }
                                else if (StartPos2.Equals("DEFAULT") == true)
                                {
                                    this.Deal_Image_BUTTON.Enabled = true;

                                    //下拉列表默认选择那种方法
                                    Methods_COMBOBOX.SelectedItem = EndPos2;

                                    //设置数据列表当前项目指向那个方法
                                    //Info.Set_Cur_Methods(Methods_COMBOBOX.SelectedIndex);

                                    DEBUG_TEXTBOX.AppendText("当前项目选择默认方法：" + EndPos2 + "\r\n");
                                }
                            }
                        }
                    }
                    else
                    {
                        DEBUG_TEXTBOX.AppendText(Project + "项目配置文件为空\r\n");
                    }

                    Project_SR.Close();
                    Project_Fs.Close();
                }
            }
        }

        private void Marco_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Marco_CheckBox.Checked == true)
            {
                this.Marco_Name_TEXT.Enabled = true;
                this.Marco_Path_TEXT.Enabled = true;
            }
            else
            {
                this.Marco_Name_TEXT.Enabled = false;
                this.Marco_Path_TEXT.Enabled = false;
            }
        }
      
        //方法选择列表
        private void Methods_COMBOBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            Path_TEXTBOX.Clear();

            Info.Set_Cur_Methods(Methods_COMBOBOX.SelectedIndex);

            List<String> List = Info.Get_Cur_Path_List();
            for (int i = 0; i < List.Count; i++)
            {
                Path_TEXTBOX.AppendText(List[i] + "\n");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Add_Methods_BUTTON_Click(object sender, EventArgs e)
        {
            if (Add_Methods_TEXTBOX.Text.IndexOfAny(new char[] { '\0', '\r', '\n', ' ' }) == 0 || Add_Methods_TEXTBOX.Text.Equals("") == true)
            {
                DEBUG_TEXTBOX.AppendText("添加项目新方法错误！\r\n");
            }
            else
            {
                Methods_COMBOBOX.Items.Add(Add_Methods_TEXTBOX.Text);
                Info.Add_Methods(Add_Methods_TEXTBOX.Text);

                Methods_COMBOBOX.SelectedItem = Add_Methods_TEXTBOX.Text;

                Add_Methods_TEXTBOX.Clear();
            }
        }

        private void Delete_Methods_BUTTON_Click(object sender, EventArgs e)
        {
            if (Methods_COMBOBOX.Items.Count > 0)
            {
                Methods_COMBOBOX.Items.RemoveAt(Info.Get_Cur_Methods());
                Path_TEXTBOX.Clear();

                Info.Del_Methods();
                Methods_COMBOBOX.SelectedIndex = Info.Get_Cur_Methods();

                if (Methods_COMBOBOX.Items.Count == 0)
                {
                    Methods_COMBOBOX.Text = "";
                }
            }
        }

        private void Save_BUTTON_Click(object sender, EventArgs e)
        {
            this.Add_Project_BUTTON.Enabled = false;
            this.Delete_Project_BUTTON.Enabled = false;
            this.Add_Project_TEXTBOX.Enabled = false;

            this.Add_Methods_BUTTON.Enabled = false;
            this.Delete_Methods_BUTTON.Enabled = false;
            this.Add_Methods_TEXTBOX.Enabled = false;

            this.Marco_Name_TEXT.Enabled = false;
            this.Marco_Path_TEXT.Enabled = false;

            this.Save_BUTTON.Enabled = false;

            this.Deal_Image_BUTTON.Enabled = true;
            this.Path_TEXTBOX.Enabled = false;
            String[] Line = Path_TEXTBOX.Text.Split(new char[]{'\n', '\r'});
            Info.Clear_Path();
            Info.Add_Path(Line);

            Project_Fs = new FileStream(Project_Name, FileMode.Truncate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(Project_Fs);
            Info.Save_Methods(sw);
            sw.Close();
            Project_Fs.Close();

            Info_Fs = new FileStream(Info_Name, FileMode.Truncate, FileAccess.ReadWrite);
            sw = new StreamWriter(Info_Fs);
            Info.Save_Info(sw);
            sw.Close();
            Info_Fs.Close();
        }

        private void Add_Project_BUTTON_Click(object sender, EventArgs e)//添加项目
        {
            if (Add_Project_TEXTBOX.Text.IndexOfAny(new char[] { '\0', '\r', '\n', ' ' }) == 0 || Add_Project_TEXTBOX.Text.Equals("") == true)
            {
                DEBUG_TEXTBOX.AppendText("添加新项目错误！\r\n");
            }
            else
            {
                this.Methods_COMBOBOX.Enabled = true;
                this.Add_Methods_BUTTON.Enabled = true;
                this.Add_Methods_TEXTBOX.Enabled = true;
                this.Delete_Methods_BUTTON.Enabled = true;

                Project_COMBOBOX.Items.Add(Add_Project_TEXTBOX.Text);

                Info.Add_Info(Add_Project_TEXTBOX.Text);

                int Pos = Info_Name.IndexOf(".ini");
                Project_Name = Src_Project_Name.Insert(Pos + 1, Add_Project_TEXTBOX.Text);

                Project_Fs = new FileStream(Project_Name, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                Project_Fs.Close();
                File.SetAttributes(Project_Name, FileAttributes.Hidden);

                DEBUG_TEXTBOX.AppendText("创建" + Add_Project_TEXTBOX.Text + "项目配置文件\r\n");
                Path_TEXTBOX.Clear();

                Project_COMBOBOX.SelectedItem = Add_Project_TEXTBOX.Text;
                Add_Project_TEXTBOX.Clear();
            }
        }

        private void Remove_Project_BUTTON_Click(object sender, EventArgs e)
        {
            Info.Del_Info();
            Project_Fs = new FileStream(Project_Name, FileMode.Truncate, FileAccess.ReadWrite);
            Project_Fs.Close();
        }

        private void Project_COMBOBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            Path_TEXTBOX.Clear();
            Methods_COMBOBOX.Items.Clear();
            Info.Set_Cur_Project(Project_COMBOBOX.SelectedIndex);
            Read_Methods_File(Project_COMBOBOX.SelectedItem.ToString());//切换项目，读取相关项目的配置文件
        }

        private void Modify_BUTTON_Click(object sender, EventArgs e)
        {
            this.Add_Project_BUTTON.Enabled = true;
            this.Delete_Project_BUTTON.Enabled = true;
            this.Add_Project_TEXTBOX.Enabled = true;

            this.Add_Methods_BUTTON.Enabled = true;
            this.Delete_Methods_BUTTON.Enabled = true;
            this.Add_Methods_TEXTBOX.Enabled = true;

            this.Marco_Name_TEXT.Enabled = true;
            this.Marco_Path_TEXT.Enabled = true;

            this.Path_TEXTBOX.Enabled = true;
            this.Save_BUTTON.Enabled = true;
        }


        //===================================================================Deal Image=============================================================
        String Compression_Bin_Name = @"./Icon.bin";
        String Bin_Name = @"./Pcm.bin";
        String Bin_IconImage = @"./IconImage.bin";
        String Bin_Font = @"./Font.ttf";

        String Pcm_Head = @"./Font.ttf";
        String Icon_Head = @"./Font.ttf";

        int Icon_Num = 0, Icon_Size = 0;
        int Pcm_Num = 0, Pcm_Size;
 
        List<int> Icon_Num_List = new List<int>();
        List<int> Pcm_Num_List = new List<int>();

        List<String> Icon_Name_List = new List<String>();
        List<String> Pcm_Name_List = new List<String>();

        private void Deal_Image_BUTTON_Click(object sender, EventArgs e)
        {
            Clear_Data();

            String[] Name = this.Path_TEXTBOX.Text.Split(new char[]{'\n','\r'});
            //@"./Test_Image/tmp/"
            for (int i = 0; i < Name.Length; i++)
            {
                //Console.WriteLine(Name[i]);
                if (Name[i].IndexOfAny(new char[] { '\0', ' ', '\n', '\r' }) != 0 && Name[i].Equals("") == false)
                {
                    foreach (String tmp in Directory.GetFiles(Name[i], "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".png") || s.EndsWith(".wav") || s.EndsWith(".bmp") || s.EndsWith(".jpg") || s.EndsWith(".ttf")))
                    {
                        Console.WriteLine(tmp);
                        Deal_Picture(tmp);
                    }
                }
            }
            Merge_Bin();
            Creat_Hear_File();
        }

        public void Creat_Hear_File()
        {
            
        }

        public void Merge_Bin()
        {
            FileStream BinStream = new FileStream(Bin_IconImage, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryWriter sw = new BinaryWriter(BinStream);

            byte[] Buf = new byte[Icon_Size + Pcm_Size + (Pcm_Num + Icon_Num) * 4 + 12];
            int Pos = 0, Sum = 0, Tmp;

            //Icon bin文件拼接
            Tmp = (Icon_Num + 1) * 4;
            Buf[Pos++] = (byte)(Tmp & 0xFF);
            Buf[Pos++] = (byte)((Tmp & 0xFF00) >> 8);
            Buf[Pos++] = (byte)((Tmp & 0xFF0000) >> 16);
            Buf[Pos++] = (byte)((Tmp & 0xFF000000) >> 24);

            for (int i = 0; i < Icon_Num; i++)
            {
                Sum += Icon_Num_List[i];
                Buf[Pos++] = (byte)(Sum & 0xFF);
                Buf[Pos++] = (byte)((Sum & 0xFF00) >> 8);
                Buf[Pos++] = (byte)((Sum & 0xFF0000) >> 16);
                Buf[Pos++] = (byte)((Sum & 0xFF000000) >> 24);
            }

            Buf[Pos++] = 0x7D;
            Buf[Pos++] = 0x3B;
            Buf[Pos++] = 0x0D;
            Buf[Pos++] = 0x0A;

            Buf[Pos++] = (byte)(Icon_Size & 0xFF);
            Buf[Pos++] = (byte)((Icon_Size & 0xFF00) >> 8);
            Buf[Pos++] = (byte)((Icon_Size & 0xFF0000) >> 16);
            Buf[Pos++] = (byte)((Icon_Size & 0xFF000000) >> 24);

            sw.BaseStream.Write(Buf, 0, Pos);
            Pos = 0;

            FileStream BinIcon = new FileStream(Compression_Bin_Name, FileMode.Open, FileAccess.Read);
            int Length = (int)BinIcon.Length;
            Pos += BinIcon.Read(Buf, 0, Length);
            BinIcon.Close();
            sw.BaseStream.Write(Buf, 0, Pos);
            Pos = 0;

            Sum = 0;
            //PCM bin文件拼接
            Tmp = (Pcm_Num + 1) * 4;
            Buf[Pos++] = (byte)(Tmp & 0xFF);
            Buf[Pos++] = (byte)((Tmp & 0xFF00) >> 8);
            Buf[Pos++] = (byte)((Tmp & 0xFF0000) >> 16);
            Buf[Pos++] = (byte)((Tmp & 0xFF000000) >> 24);

            for (int i = 0; i < Pcm_Num; i++)
            {
                Sum += Pcm_Num_List[i];
                Buf[Pos++] = (byte)(Sum & 0xFF);
                Buf[Pos++] = (byte)((Sum & 0xFF00) >> 8);
                Buf[Pos++] = (byte)((Sum & 0xFF0000) >> 16);
                Buf[Pos++] = (byte)((Sum & 0xFF000000) >> 24);
            }

            Buf[Pos++] = 0x7D;
            Buf[Pos++] = 0x3B;
            Buf[Pos++] = 0x0D;
            Buf[Pos++] = 0x0A;

            Buf[Pos++] = (byte)(Pcm_Size & 0xFF);
            Buf[Pos++] = (byte)((Pcm_Size & 0xFF00) >> 8);
            Buf[Pos++] = (byte)((Pcm_Size & 0xFF0000) >> 16);
            Buf[Pos++] = (byte)((Pcm_Size & 0xFF000000) >> 24);

            sw.BaseStream.Write(Buf, 0, Pos);
            Pos = 0;

            FileStream BinPcm = new FileStream(Bin_Name, FileMode.Open, FileAccess.Read);
            Length = (int)BinPcm.Length;
            Pos += BinPcm.Read(Buf, 0, Length);
            BinPcm.Close();
            sw.BaseStream.Write(Buf, 0, Pos);
            Pos = 0;

            //Font 字库
            if (File.Exists(Bin_Font) == true)
            {
                FileStream BinFont = new FileStream(Bin_Font, FileMode.Open, FileAccess.Read);
                Length = (int)BinFont.Length;
                Pos += BinFont.Read(Buf, 0, Length);
                BinFont.Close();
                sw.BaseStream.Write(Buf, 0, Pos);
                Pos = 0;

                BinFont.Close();
            }

            sw.Close();
            BinStream.Close();
        }

        public void Deal_Picture(String Name)
        {
            //读取文件流
            FileStream FS = new FileStream(Name, FileMode.Open, FileAccess.Read);
            int Length = (int)FS.Length;
            byte[] Bytes = new byte[Length];
            FS.Read(Bytes, 0, Length);

            int Ret = 0, Start, End;

            Start = Name.LastIndexOf('\\') + 1;
            End = Name.LastIndexOf('.');

            if (Name.EndsWith(".bmp"))
            {
                Bitmap map = (Bitmap)Bitmap.FromFile(Name);
                Ret = Deal_Data_Compression(map, Bytes);
                Save_Data_Compression(Ret, Bytes);

                Name = Name.Substring(Start, End - Start);
                Console.WriteLine("bmp:" + Name);
                Icon_Name_List.Add(Name);
            }
            else if (Name.EndsWith(".png") || Name.EndsWith(".wav") || Name.EndsWith(".jpg"))
            {
                Ret = Length;
                Save_Data(Ret, Bytes);

                Name = Name.Substring(Start, End - Start);
                Console.WriteLine("pcm:" + Name);
                Pcm_Name_List.Add(Name);
            }
            else if (Name.EndsWith(".ttf"))
            {
                Bin_Font = Name;
            }

            //文件流关閉,文件解除锁定
            FS.Close();
        }

        public int Deal_Data_Compression(Bitmap map, Byte[] Data)
        {
            ushort n = 0;//记数，有多少个连续一样的颜色

            short w = (short)map.Width;
            short h = (short)map.Height;

            ushort F_Buf = 0;//存储前一个颜色
            ushort Buf = 0;//最新读到的颜色

            int Pos = 0;
            Color srcColor;

            int x = 0, y = 0;

            Data[Pos++] = (byte)(w & 0xFF);
            Data[Pos++] = (byte)((w & 0xFF00) >> 8);

            Data[Pos++] = (byte)(h & 0xFF);
            Data[Pos++] = (byte)((h & 0xFF00) >> 8);

            srcColor = map.GetPixel(x, y);
            F_Buf = (ushort)(((srcColor.R & 0xF8) << 8) | ((srcColor.G & 0xFC) << 3) | ((srcColor.B & 0xF8) >> 3));

            for (y = 0; y < h; y++)
            {
                for (x = 0; x < w; x++)
                {
                    srcColor = map.GetPixel(x, y);

                    Buf = (ushort)(((srcColor.R & 0xF8) << 8) | ((srcColor.G & 0xFC) << 3) | ((srcColor.B & 0xF8) >> 3));
                    if (F_Buf == Buf && (y != h - 1 || x != w - 1) && !(y != 0 && x == 0))
                    {
                        n++;
                    }
                    else
                    {
                        if (n > 2)
                        {
                            Data[Pos++] = 0x45;
                            Data[Pos++] = 0xAD;

                            Data[Pos++] = (byte)(n & 0xFF);
                            Data[Pos++] = (byte)((n & 0xFF00) >> 8);

                            Data[Pos++] = (byte)(F_Buf & 0xFF);
                            Data[Pos++] = (byte)((F_Buf & 0xFF00) >> 8);
                        }
                        else
                        {
                            for (int i = 0; i < n; i++)
                            {
                                Data[Pos++] = (byte)(F_Buf & 0xFF);
                                Data[Pos++] = (byte)((F_Buf & 0xFF00) >> 8);
                            }
                        }
                        n = 1;
                        F_Buf = Buf;
                    }
                }
            }
            Data[Pos++] = (byte)(F_Buf & 0xFF);
            Data[Pos++] = (byte)((F_Buf & 0xFF00) >> 8);

            return Pos;
        }

        public void Clear_Data()
        {
            if (File.Exists(Compression_Bin_Name) == true)
            {
                FileStream BinStream = new FileStream(Compression_Bin_Name, FileMode.Truncate, FileAccess.ReadWrite);
                BinaryWriter sw = new BinaryWriter(BinStream);
                sw.Close();
                BinStream.Close();
            }
            else
            {
                FileStream BinStream = new FileStream(Compression_Bin_Name, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryWriter sw = new BinaryWriter(BinStream);
                sw.Close();
                BinStream.Close();
            }

            if (File.Exists(Bin_Name) == true)
            {
                FileStream BinStream = new FileStream(Bin_Name, FileMode.Truncate, FileAccess.ReadWrite);
                BinaryWriter sw = new BinaryWriter(BinStream);
                sw.Close();
                BinStream.Close();
            }
            else
            {
                FileStream BinStream = new FileStream(Bin_Name, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryWriter sw = new BinaryWriter(BinStream);
                sw.Close();
                BinStream.Close();
            }

            if (File.Exists(Bin_IconImage) == true)
            {
                FileStream BinStream = new FileStream(Bin_IconImage, FileMode.Truncate, FileAccess.ReadWrite);
                BinaryWriter sw = new BinaryWriter(BinStream);
                sw.Close();
                BinStream.Close();
            }
            else
            {
                FileStream BinStream = new FileStream(Bin_IconImage, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryWriter sw = new BinaryWriter(BinStream);
                sw.Close();
                BinStream.Close();
            }
        }

        public void Save_Data_Compression(int Num, byte[] Data)
        {
            FileStream BinStream = new FileStream(Compression_Bin_Name, FileMode.Append, FileAccess.Write);
            BinaryWriter sw = new BinaryWriter(BinStream);

            sw.BaseStream.Write(Data, 0, Num);
            Icon_Size += Num;
            Icon_Num_List.Add(Num);
            Icon_Num++;

            sw.Close();
            BinStream.Close();
        }

        public void Save_Data(int Num, byte[] Data)
        {
            FileStream BinStream = new FileStream(Bin_Name, FileMode.Append, FileAccess.Write);
            BinaryWriter sw = new BinaryWriter(BinStream);

            sw.BaseStream.Write(Data, 0, Num);
            Pcm_Num_List.Add(Num);
            Pcm_Size += Num;
            Pcm_Num++;

            sw.Close();
            BinStream.Close();
        }
        //===================================================================Deal Image=============================================================

    }

    class Type_Info
    {
        private int Project_Num = 0, Methods_Num = 0, Cur_Project = -1, Cur_Methods = -1;

        List<String> Project = new List<String>();
        List<String> Methods = new List<String>();
        List<List<String>> Path = new List<List<String>>();
        List<String> Marco = new List<String>();
        List<String> MarcoPath = new List<String>();

        public void Add_Info(String Project)
        {
            if (Project.IndexOfAny(new char[] { '\0', ' ', '\n', '\r' }) != 0 && Project.Equals("") == false)
            {
                this.Project.Add(Project);
                Project_Num++;
            }
        }
        public void Add_Methods(String Name, String Methods, String Path)
        {
            int n = Find_Project_Pos(Name);

            if (n >= 0)
            {
                List<String> SubPath = new List<String>();
                this.Path.Add(SubPath);
                this.Methods.Add(Methods);

                foreach (String Tmp in Path.Split(';'))
                {
                    if (Tmp.IndexOfAny(new char[] { '\0', ' ', '\n', '\r' }) != 0 && Tmp.Equals("") == false)
                    {
                        this.Path[Methods_Num].Add(Tmp);
                    }
                }

                Methods_Num++;
            }
        }
        public void Add_Methods(String Methods)
        {
            List<String> SubPath = new List<String>();
            this.Path.Add(SubPath);
            this.Methods.Add(Methods);
            Methods_Num++;
        }
        public void Add_Path(String Path)
        {
            foreach (String Tmp in Path.Split(';'))
            {
                if (Tmp.IndexOfAny(new char[] { '\0', ' ', '\n', '\r' }) != 0 && Tmp.Equals("") == false)
                {
                    Console.WriteLine(Tmp);
                    this.Path[Cur_Methods].Add(Tmp);
                }
            }
        }
        public void Add_Path(String[] Path)
        {
            Console.WriteLine("Cur_Methods1:" + Cur_Methods);
            for (int n = 0; n < Path.Length; n++)
            {
                if (Path[n].IndexOfAny(new char[] { '\0', ' ', '\n', '\r' }) != 0 && Path[n].Equals("") == false)
                {
                    Console.WriteLine("Path:" + Path[n]);
                    this.Path[Cur_Methods].Add(Path[n]);
                }
            }
        }
        public void Clear_Path()
        {
            this.Path[Cur_Methods].Clear();
        }

        private int Find_Project_Pos(String Name)//根据名字，找存储在数组位置中的下标
        {
            for (int n = 0; n < Project.Count; n++)
            {
                if (Project[n].Equals(Name) == true)
                {
                    return n;
                }
            }
            return -1;
        }
        private int Find_Methods_Pos(String Name)//根据名字，找存储在数组位置中的下标
        {
            for (int n = 0; n < Methods.Count; n++)
            {
                if (Methods[n].Equals(Name) == true)
                {
                    return n;
                }
            }
            return -1;
        }
        public void Del_Info()
        {
            this.Project.RemoveAt(Cur_Project);
            this.Methods.Clear();
            this.Path.Clear();
            this.Marco.Clear();
            this.MarcoPath.Clear();
            Project_Num--;

            if (Cur_Project >= Project_Num)
            {
                Cur_Project = Project_Num - 1;
            }
        }
        public void Del_Methods()
        {
            this.Methods.RemoveAt(Cur_Methods);
            this.Path.RemoveAt(Cur_Methods);
            this.Marco.Clear();
            this.MarcoPath.Clear();
            Methods_Num--;

            if (Cur_Methods >= Methods_Num)
            {
                Cur_Methods = Methods_Num - 1;
            }
        }

        public int Get_Cur_Project()//获取选择第几个当前项目
        {
            return Cur_Project;
        }
        public int Get_Cur_Methods()//获取当前项目使用第几种方法
        {
            return Cur_Methods;
        }
        public void Set_Cur_Project(int n)
        {
            Cur_Methods = -1;
            Methods_Num = 0;
            Methods.Clear();
            Path.Clear();
            this.Cur_Project = n;
        }
        public void Set_Cur_Methods(int n)
        {
            this.Cur_Methods = n;
        }

        public List<String> Get_Cur_Methods_List()
        {
            if (Cur_Project >= 0)
            {
                return Methods;
            }
            else
            {
                return null;
            }
        }
        public List<String> Get_Cur_Path_List()
        {
            if (Cur_Project >= 0 && Cur_Methods >= 0)
            {
                return Path[Cur_Methods];
            }
            else
            {
                return null;
            }
        }
        public void Save_Info(StreamWriter sw)
        {
            for (int n = 0; n < Project_Num; n++)
            {
                sw.Write(Project[n] + ";");
            }
            sw.WriteLine();
            sw.Write("DEFAULT=" + Project[Cur_Project]);
        }
        public void Save_Methods(StreamWriter sw)
        {
            if (Methods_Num > 0)
            {
                for (int n = 0; n < Methods_Num; n++)
                {
                    sw.WriteLine("NAME=" + Methods[n]);
                    sw.Write("PATH=");

                    for (int m = 0; m < Path[n].Count; m++)
                    {
                        sw.Write(Path[n][m] + ";");
                    }

                    sw.WriteLine();
                }
                sw.Write("DEFAULT=" + Methods[Cur_Methods]);
            }
        }
    }
}
