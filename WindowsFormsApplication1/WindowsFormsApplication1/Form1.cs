using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Thread Thread_Load;
        Thread Thread_Convert;

        string FileName = null;
        uint version = 0, dataversion = 2;
        DataTable dTableOut = new DataTable();
        DataTable dTableOut1 = new DataTable();
        string[] dirtypes;
        string[] cameratypes;
        string[] spdtypes;

        double Lon_Start = 0.0, Lat_Start = 0.0, Lon_End = 0.0, Lat_End = 0.0;

        long[] poioflargelayer = null;
        int blockcount = 0, smalllayerblockcount = 0, lonblockcount = 0, lonsmalllayerblockcount = 0;

        DataGridView DGV_verifydivision = new DataGridView();
        //ArrayList[] divisionblockcount;
        int layerinfo;

        ArrayList[,] points = null;
        ArrayList[,] tmppoints = null;

        //---Save_File
        string inifile = null;
        string str_datetime = null;
        DateTime CurrentTime = new DateTime();

        public Form1()
        {
            string tmp1 = null, tmp2 = null;

            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            DGV_excel.Rows.Clear();

            Thread_Load = new System.Threading.Thread(LoadExcelFile);
            Thread_Convert = new System.Threading.Thread(SpeedCamConvert);

            //---------获取时间
            CurrentTime = System.DateTime.Now;
            if (CurrentTime.Month < 10)
                tmp1 = "0" + CurrentTime.Month.ToString();
            else
                tmp1 = CurrentTime.Month.ToString();
            if (CurrentTime.Day < 10)
                tmp2 = "0" + CurrentTime.Day.ToString();
            else
                tmp2 = CurrentTime.Day.ToString();
            str_datetime = CurrentTime.Year.ToString() + tmp1 + tmp2;
        }

        public void LoadExcelFile(Object Data)
        {
            Console.WriteLine("--------------------LoadExcelFile----------------------------");

            string excelfile = (string)Data;
            int i = 0; // counter
            string[] words;
            string tmpstr = null;
            double tmp_latstart = double.MaxValue, tmp_latend = double.MinValue;
            double tmp_lonstart = double.MaxValue, tmp_lonend = double.MinValue;
            //bool lonsmallzero = false, latsmallzero = false;
            int csvfilelines = 0;
            string tmpexcelfilename = null;

            TextBox_FilePath.Text = excelfile;
            tmpstr = Application.ExecutablePath; // 获取程序路径
            words = tmpstr.Split('\\'); // 按 "\" 切割路径
            tmpstr = string.Empty;
            for (i = 0; i < words.Length - 1; i++)
                tmpstr += words[i] + "\\";

            // 拼接生成的数据文件路径
            TextBox_BinPath.Text = tmpstr + "Speedcam_Data.bin";

            // 操作 Excel 的固定指令
            string OpenExcelData = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + TextBox_FilePath.Text + ";Extended Properties = 'Excel 8.0;HDR=Yes;IMEX=1;'";

            // OleDbConnection() 操作数据库的函数，这里用来读取 Excel 的内容
            //OleDbConnection ExcelConnection = new OleDbConnection(OpenExcelData);
 
            if (File.Exists(excelfile))
            {
                try
                {
                    tmpexcelfilename = System.IO.Path.GetFileNameWithoutExtension(excelfile);
                    //Console.WriteLine("文件名：" + tmpexcelfilename);

                    if (excelfile.IndexOf(".csv", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        string[] str = File.ReadAllLines(excelfile);
                        string[] temp = str[0].Split(',');
                        csvfilelines = int.Parse(temp[0].ToString());
                        //Console.WriteLine("一共需要读取多少行数据：" + csvfilelines);

                        temp = str[1].Split(',');
                        version = uint.Parse(temp[0].ToString());
                        temp = str[2].Split(',');
                        foreach (string t in temp)
                        {
                            dTableOut1.Columns.Add(t.Trim(), typeof(string));
                        }

                        this.RichTextBox_Log.AppendText("开始加载数据...\n"); 
                        this.ProgressBar.Value = 0;
                        this.ProgressBar.Minimum = 0;
                        this.ProgressBar.Maximum = csvfilelines;
                        for (i = 1; i <= csvfilelines; i++, this.ProgressBar.Value++)
                        {
                            string[] tt = str[2 + i].Split(',');

                            if (tt.Length <= 7)
                            {
                                for (int k = 1; k < 3; k++)  // 20140221, for X, Y
                                {
                                    if (((double.Parse(tt[k])) < 10.0) && ((double.Parse(tt[k])) > 0.0))
                                        tt[k] = "00" + tt[k];
                                    else if (((double.Parse(tt[k])) < 100.0) && ((double.Parse(tt[k])) > 10.0))
                                        tt[k] = '0' + tt[k];
                                }
                                dTableOut1.Rows.Add(tt[0], tt[1], tt[2], tt[3], tt[4], tt[5], tt[6]);
                            }
                            else if (tt.Length == 8)
                            {
                                for (int k = 1; k < 3; k++) //20140221, for X, Y
                                {
                                    if (((double.Parse(tt[k])) < 10.0) && ((double.Parse(tt[k])) > 0.0))
                                        tt[k] = "00" + tt[k];
                                    else if (((double.Parse(tt[k])) < 100.0) && ((double.Parse(tt[k])) > 10.0))
                                        tt[k] = '0' + tt[k];
                                }

                                dTableOut1.Rows.Add(tt[0], double.Parse(tt[1]), double.Parse(tt[2]), double.Parse(tt[3]), int.Parse(tt[4]), int.Parse(tt[5]), int.Parse(tt[6]), int.Parse(tt[7]));
                            }
                            else if (tt.Length > 8)
                            {
                                for (int k = 1; k < 3; k++) //20140221, for X, Y
                                {
                                    if (((double.Parse(tt[k])) < 10.0) && ((double.Parse(tt[k])) > 0.0))
                                        tt[k] = "00" + tt[k];
                                    else if (((double.Parse(tt[k])) < 100.0) && ((double.Parse(tt[k])) > 10.0))
                                        tt[k] = '0' + tt[k];
                                }

                                dTableOut1.Rows.Add(tt[0], double.Parse(tt[1]), double.Parse(tt[2]), double.Parse(tt[3]), int.Parse(tt[4]), int.Parse(tt[5]), int.Parse(tt[6]), int.Parse(tt[7]), int.Parse(tt[8]));
                            }
                        }

                        if (dirtypes == null)
                            dirtypes = "0,1,2".Split(','); // DIR_TYPE 测速方向类型 0：固定、1：单向、2：双向

                        if (cameratypes == null) // CAMERA_TYPE 测速点类型(一般不同类型播报不同的语音)
                        {
                            if (dataversion == 4)
                            {
                                cameratypes = "1,2,3,4,5,6,7,8,9".Split(',');
                            }
                            else
                            {
                                cameratypes = "1,2,3,4,5,6,7".Split(','); // 台湾只有1种类型，俄罗斯有7种类型
                            }
                        }

                        if (spdtypes == null)
                            spdtypes = "0,1,2,3,4,5,6,7,8,9".Split(',');

                        dTableOut1.DefaultView.Sort = dTableOut1.Columns[2].ColumnName + ", " + dTableOut1.Columns[1].ColumnName; // X, Y 
                        DGV_excel.DataSource = dTableOut1.DefaultView;
                        DGV_excel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    }

                    // sort cell                
                    DGV_excel.Sort(DGV_excel.Columns[2], ListSortDirection.Ascending);
                }
                catch (Exception ex)
                {
                    this.RichTextBox_Log.SelectionColor = Color.Red;
                    this.RichTextBox_Log.AppendText("数据读取失败!\n");
                }

                //-----------------------------------------------------------------------------
                if (dTableOut1.Rows.Count > 0)
                {
                    TextBox_DataCount.Text = dTableOut1.Rows.Count.ToString();
                    TextBox_DataCount.Update();

                    this.RichTextBox_Log.AppendText("确定数据值范围...\n");
                    this.ProgressBar.Value = 0;
                    this.ProgressBar.Minimum = 0;
                    this.ProgressBar.Maximum = DGV_excel.RowCount;
                    for (i = 0; i < DGV_excel.RowCount; i++, this.ProgressBar.Value++)
                    {
                        if (double.Parse(DGV_excel.Rows[i].Cells[1].Value.ToString()) < tmp_latstart)
                            tmp_latstart = double.Parse(DGV_excel.Rows[i].Cells[1].Value.ToString());
                        if (double.Parse(DGV_excel.Rows[i].Cells[1].Value.ToString()) > tmp_latend)
                            tmp_latend = double.Parse(DGV_excel.Rows[i].Cells[1].Value.ToString());

                        if (double.Parse(DGV_excel.Rows[i].Cells[2].Value.ToString()) < tmp_lonstart)
                            tmp_lonstart = double.Parse(DGV_excel.Rows[i].Cells[2].Value.ToString());
                        if (double.Parse(DGV_excel.Rows[i].Cells[2].Value.ToString()) > tmp_lonend)
                            tmp_lonend = double.Parse(DGV_excel.Rows[i].Cells[2].Value.ToString());
                    }

                    //TextBox_Lon_Start.Enabled = true;
                    Lon_Start = double.Parse(DGV_excel.Rows[0].Cells[2].Value.ToString());
                    Lon_Start = tmp_lonstart;
                    Lon_Start = Math.Floor(Lon_Start);
                    TextBox_Lon_Start.Text = Lon_Start.ToString();

                    //TextBox_Lon_End.Enabled = true;
                    Lon_End = double.Parse(DGV_excel.Rows[DGV_excel.RowCount - 1].Cells[2].Value.ToString());
                    Lon_End = tmp_lonend;
                    Lon_End = Math.Ceiling(Lon_End);
                    TextBox_Lon_End.Text = Lon_End.ToString();

                    //TextBox_Lat_Start.Enabled = true;
                    tmp_latstart = Math.Floor(tmp_latstart);
                    Lat_Start = tmp_latstart;
                    TextBox_Lat_Start.Text = tmp_latstart.ToString();

                    //TextBox_Lat_End.Enabled = true;
                    tmp_latend = Math.Ceiling(tmp_latend);
                    Lat_End = tmp_latend;
                    TextBox_Lat_End.Text = tmp_latend.ToString();
                }

                this.vScrollBar1.Maximum = dTableOut1.Rows.Count - DGV_excel.DisplayedRowCount(false) + vScrollBar1.LargeChange;
                this.vScrollBar1.Value = 0;
                this.vScrollBar1.Enabled = true;

                this.hScrollBar1.Maximum = dTableOut1.Columns.Count - DGV_excel.DisplayedColumnCount(false) + hScrollBar1.LargeChange;
                this.hScrollBar1.Value = 0;
                this.hScrollBar1.Enabled = true;

                this.DGV_excel.Enabled = true;

                this.Button_Convert.Enabled = true;
                this.RichTextBox_Log.SelectionColor = Color.Green;
                this.RichTextBox_Log.AppendText("加载数据成功!\n");
            }
            else
            {
                this.RichTextBox_Log.SelectionColor = Color.Red;
                this.RichTextBox_Log.AppendText("文件不存在!\n");
            }
        }
        public void SpeedCamConvert()
        {
            Console.WriteLine("--------------------speedcamconvert----------------------------");

            int i = 0, j = 0; // temp counter     

            poioflargelayer = new long[blockcount * lonblockcount];

            int latlargeindex = 0, lonlargeindex = 0;
            int rel_latsmallindex = 0, rel_lonsmallindex = 0;
            int largeindex = 0, smallindex = 0;   // the first one number: 0
            double tmp_Y = 0.0, tmp_X = 0.0;
            double rel_latstart = 0.0, rel_lonstart = 0.0;

            string[] tmpindex = new string[2];
            string tmppointinfo = null;
            int tmplargelayerindex = 0, tmpsmalllayerindex = 0;

            //-------------- new division version variable ---------------------------------------
            bool IsPOIsuminsmallblocklessthanthreshold = true;  //false: the original division; true: new division based on 20140305
            int largetestroundnum = 20, smalltestroundnum = 27; // large: from 10*10 to 20*20, step over 1; small: from 3*3 to 30*30, step over 1;                                    
            int largeteststart = 3, smallteststart = 3;
            int POIsuminsmallblockthreshold = 60000;       //5000,3000
            double tmplatblockwidth = 0.0, tmplonblockwidth = 0.0, tmplatsmallblockwidth = 0.0, tmplonsmallblockwidth = 0.0;
            bool failedcombination = false;
            int r = 0, s = 0;
            int tmprowindex = 0, tmpcolumnindex = 0;
            long tmpPOIsum = 0, tmpnineblockPOI = 0;
            long tmp_POIcontained = 0;
            bool stopupdatepoints = false;

            dTableOut1.Dispose();
            DGV_excel.Columns.Add("Layers", "Layers");

            // DGV_excel.RowCount 表示一共有多少条数据
            layerinfo = DGV_excel.Columns.Count - 1; // 表示每一条数据的最后一个存储位置

            if (((IsPOIsuminsmallblocklessthanthreshold) && (POIsuminsmallblockthreshold > 0))) // DigiLife use this
            {
                Console.WriteLine("------------------------------new version division!---------------------------------------------");

                failedcombination = false;
 
                if (DGV_excel.RowCount > 400000)
                {
                    largeteststart = 19;
                    smallteststart = 24;
                    POIsuminsmallblockthreshold = 10000;// 一个大包数据不能超过这个数 
                }
                else if (DGV_excel.RowCount > 300000)
                {
                    largeteststart = 18;
                    smallteststart = 24;
                    POIsuminsmallblockthreshold = 8000;// 一个大包数据不能超过这个数 
                }
                else if (DGV_excel.RowCount > 200000)
                {
                    largeteststart = 17;
                    smallteststart = 22;
                    POIsuminsmallblockthreshold = 6000;// 一个大包数据不能超过这个数 
                }
                else if (DGV_excel.RowCount > 100000)
                {
                    largeteststart = 16;
                    smallteststart = 20;
                    POIsuminsmallblockthreshold = 6000;// 一个大包数据不能超过这个数 
                }
                else if (DGV_excel.RowCount > 20000)
                {
                    largeteststart = 15;
                    smallteststart = 18;
                    POIsuminsmallblockthreshold = 6000;// 一个大包数据不能超过这个数 
                }
                else if (DGV_excel.RowCount > 6000)
                {
                    largeteststart = 14;
                    smallteststart = 16;
                    POIsuminsmallblockthreshold = 6000;// 一个大包数据不能超过这个数 
                }
                else
                {
                    largeteststart = 1;
                    smallteststart = 1;
                    POIsuminsmallblockthreshold = 6000;// 一个大包数据不能超过这个数 
                }

                largetestroundnum = 22;
                smalltestroundnum = 29;

                DGV_verifydivision.RowCount = largetestroundnum * (smalltestroundnum);
                DGV_verifydivision.ColumnCount = largetestroundnum * (smalltestroundnum);

                points = new ArrayList[largetestroundnum * largetestroundnum, (smalltestroundnum + 3) * (smalltestroundnum + 3)];

                //r: large, s: small             
                //Console.WriteLine("最小经度：" + Lon_Start + ", 最大经度：" + Lon_End);
                //Console.WriteLine("最小纬度：" + Lat_Start + ", 最大纬度：" + Lat_End);

                this.RichTextBox_Log.AppendText("开始转换...\n");
                for (r = largeteststart; r < largetestroundnum; r++)
                {
                    TextBox_Large_Lat_Pack_Counts.Text = r.ToString();
                    TextBox_Large_Lon_Pack_Counts.Text = r.ToString();
                    tmplonblockwidth = (double)(Lon_End - Lon_Start) / r; // 把经度全部数据的范围分成 largeteststart 个大包，表示每个包的经度范围
                    tmplatblockwidth = (double)(Lat_End - Lat_Start) / r; // 纬度同上

                    TextBox_Large_Lat_Width.Text = tmplatblockwidth.ToString();
                    TextBox_Large_Lon_Width.Text = tmplonblockwidth.ToString();

                    for (s = smallteststart; s < smalltestroundnum; s++)
                    {
                        //Console.WriteLine("分成大包的个数：" + r + "，分成小包的个数：" + s);
                        TextBox_Small_Lat_Pack_Counts.Text = s.ToString();
                        TextBox_Small_Lon_Pack_Counts.Text = s.ToString();

                        tmplonsmallblockwidth = (double)tmplonblockwidth / s; // 在一个大包的进度数据里面，在分成 smallteststart 个小包，表示每个小包表示的经度范围
                        tmplatsmallblockwidth = (double)tmplatblockwidth / s; // 纬度同上

                        TextBox_Small_Lat_Width.Text = tmplatsmallblockwidth.ToString();
                        TextBox_Small_Lon_Width.Text = tmplonsmallblockwidth.ToString();

                        TextBox_Large_Lat_Pack_Counts.Update();
                        TextBox_Large_Lon_Pack_Counts.Update();
                        TextBox_Small_Lat_Pack_Counts.Update();
                        TextBox_Small_Lon_Pack_Counts.Update();

                        TextBox_Large_Lat_Width.Update();
                        TextBox_Large_Lon_Width.Update();
                        TextBox_Small_Lat_Width.Update();
                        TextBox_Small_Lon_Width.Update();

                        tmppoints = new ArrayList[r * r, s * s]; // 分配一个2维数组，构成了2维的坐标，x轴表示经度，y轴表示纬度

                        for (i = 0; i < tmppoints.GetLength(0); i++) // 表示一共有多少个大包数据
                        {
                            for (j = 0; j < tmppoints.GetLength(1); j++) // 表示一个大包里面有多少个小包数据
                            {
                                if (tmppoints[i, j] == null)
                                    tmppoints[i, j] = new ArrayList();
                                else if ((tmppoints[i, j] != null) && (tmppoints[i, j].Count > 0))
                                    tmppoints[i, j].Clear();
                            }
                        }

                        //Console.WriteLine("处理数据，一共有多少条数据：" + DGV_excel.RowCount);
                        this.RichTextBox_Log.AppendText("分包处理（" + r + "大包，" + s + "小包）...\n");
                        this.RichTextBox_Log.Select(this.RichTextBox_Log.TextLength, 0);
                        this.RichTextBox_Log.ScrollToCaret();
                        this.ProgressBar.Value = 0;
                        this.ProgressBar.Minimum = 0;
                        this.ProgressBar.Maximum = DGV_excel.RowCount;
                        for (i = 0; i < DGV_excel.RowCount; i++, this.ProgressBar.Value++)
                        {
                            tmp_Y = double.Parse(DGV_excel.Rows[i].Cells[1].Value.ToString());
                            tmp_X = double.Parse(DGV_excel.Rows[i].Cells[2].Value.ToString());
                            //Console.WriteLine("经度值：" + tmp_X + "，纬度值：" + tmp_Y);

                            //通过纬度值，计算出前面 2 维数组中 y 轴坐标
                            latlargeindex = (int)Math.Floor((tmp_Y - Lat_Start) / tmplatblockwidth);
                            if (latlargeindex == r)
                                latlargeindex = r - 1;

                            //经度值在 2 维数组中的 x 轴的坐标
                            lonlargeindex = (int)Math.Floor((tmp_X - Lon_Start) / tmplonblockwidth);
                            if (lonlargeindex == r)
                                lonlargeindex = r - 1;

                            //计算出应该存储在那个大包里面
                            largeindex = latlargeindex * r + lonlargeindex;

                            //上面确定是那一个大包，现在确定是大包中的那一个小包
                            rel_latstart = Lat_Start + latlargeindex * tmplatblockwidth;
                            rel_lonstart = Lon_Start + lonlargeindex * tmplonblockwidth;
                            rel_latsmallindex = (int)Math.Floor((tmp_Y - rel_latstart) / tmplatsmallblockwidth);
                            if (rel_latsmallindex == s)
                                rel_latsmallindex = s - 1;
                            rel_lonsmallindex = (int)Math.Floor((tmp_X - rel_lonstart) / tmplonsmallblockwidth);
                            if (rel_lonsmallindex == s)
                                rel_lonsmallindex = s - 1;

                            //计算出在那一个小包里面
                            smallindex = rel_latsmallindex * s + rel_lonsmallindex;

                            //Console.WriteLine("在大包的存储位置：" + largeindex + "，在小包的存储位置：" + smallindex);
                            // 把本条数据存储的位置信息，保存在这个数组的最后一个位置
                            DGV_excel.Rows[i].Cells[layerinfo].Value = largeindex.ToString() + "," + smallindex.ToString();
                        }

                        for (i = 0; i < largetestroundnum * largetestroundnum; i++)
                        {
                            for (j = 0; j < (smalltestroundnum + 3) * (smalltestroundnum + 3); j++)
                            {
                                if (points[i, j] == null)
                                    points[i, j] = new ArrayList();
                                else if (!stopupdatepoints)
                                    points[i, j].Clear();
                            }
                        }

                        tmp_POIcontained = 0;
                        //Console.WriteLine("保存数据，一共有多少条数据：" + DGV_excel.RowCount);
                        this.RichTextBox_Log.AppendText("数据分包存储中...\n");
                        this.RichTextBox_Log.Select(this.RichTextBox_Log.TextLength, 0);
                        this.RichTextBox_Log.ScrollToCaret();
                        this.ProgressBar.Value = 0;
                        this.ProgressBar.Minimum = 0;
                        this.ProgressBar.Maximum = DGV_excel.RowCount;
                        for (i = 0; i < DGV_excel.RowCount; i++, this.ProgressBar.Value++)
                        {
                            if ((DGV_excel.Rows[i].Cells[layerinfo].Value == null) || (DGV_excel.Rows[i].Cells[layerinfo].Value.ToString().Length == 0))
                                continue;

                            tmpindex = DGV_excel.Rows[i].Cells[layerinfo].Value.ToString().Split(','); // layer: (large, small)
                            tmplargelayerindex = int.Parse(tmpindex[0]); // large layer index
                            tmpsmalllayerindex = int.Parse(tmpindex[1]); // small layer index
                            tmppointinfo = i.ToString();
                            //Console.WriteLine("这是第" + tmppointinfo + "条数据：" + "大包位置：" + tmplargelayerindex + "，小包位置：" + tmpsmalllayerindex);

                            if ((tmplargelayerindex > -1) && (tmpsmalllayerindex > -1))
                            {
                                tmppoints[tmplargelayerindex, tmpsmalllayerindex].Add(tmppointinfo);
                                if (!stopupdatepoints)
                                    points[tmplargelayerindex, tmpsmalllayerindex].Add(tmppointinfo);
                                tmp_POIcontained++;
                            }
                        }

                        //Console.WriteLine("一共保存了" + tmp_POIcontained + "条数据!");
                        //Console.WriteLine("初始化 2 维数组：行：" + DGV_verifydivision.RowCount + "，列：" + DGV_verifydivision.ColumnCount);
                        for (i = 0; i < DGV_verifydivision.RowCount; i++)
                            for (j = 0; j < DGV_verifydivision.ColumnCount; j++)
                                DGV_verifydivision.Rows[i].Cells[j].Value = "";

                        //Console.WriteLine("tmppoints.GetLength(0)=" + tmppoints.GetLength(0) + ",tmppoints.GetLength(1)=" + tmppoints.GetLength(1));                        
                        this.ProgressBar.Value = 0;
                        this.ProgressBar.Minimum = 0;
                        this.ProgressBar.Maximum = DGV_excel.RowCount;
                        for (i = 0; i < tmppoints.GetLength(0); i++)
                        {
                            for (j = 0; j < tmppoints.GetLength(1); j++)
                            {
                                tmprowindex = (i / r) * s + (j / s);
                                tmpcolumnindex = (i % r) * s + (j % s);
                                DGV_verifydivision.Rows[(r * s - 1) - tmprowindex].Cells[tmpcolumnindex].Value = tmppoints[i, j].Count.ToString();
                                //Console.WriteLine("第" + i + "大包中第" + j + "个小包存储了多少条数据:" + tmppoints[i, j].Count + ", tmprowindex=" + tmprowindex + ", tmpcolumnindex=" + tmpcolumnindex);
                            }
                        }

                        failedcombination = false;

                        this.RichTextBox_Log.AppendText("分包大小检查...\n");
                        this.RichTextBox_Log.Select(this.RichTextBox_Log.TextLength, 0);
                        this.RichTextBox_Log.ScrollToCaret();
                        for (i = 1; i < (r * s - 1); i++)
                        {
                            for (j = 1; j < (r * s - 1); j++)
                            {
                                tmpnineblockPOI = (long.Parse(DGV_verifydivision.Rows[i - 1].Cells[j - 1].Value.ToString()) +
                                long.Parse(DGV_verifydivision.Rows[i].Cells[j - 1].Value.ToString()) +
                                long.Parse(DGV_verifydivision.Rows[i + 1].Cells[j - 1].Value.ToString()) +

                                long.Parse(DGV_verifydivision.Rows[i - 1].Cells[j].Value.ToString()) +
                                long.Parse(DGV_verifydivision.Rows[i].Cells[j].Value.ToString()) +
                                long.Parse(DGV_verifydivision.Rows[i + 1].Cells[j].Value.ToString()) +

                                long.Parse(DGV_verifydivision.Rows[i - 1].Cells[j + 1].Value.ToString()) +
                                long.Parse(DGV_verifydivision.Rows[i].Cells[j + 1].Value.ToString()) +
                                long.Parse(DGV_verifydivision.Rows[i + 1].Cells[j + 1].Value.ToString()));

                                if (tmpnineblockPOI >= POIsuminsmallblockthreshold)
                                {
                                    failedcombination = true;
                                    break;
                                }
                            }

                            if (failedcombination)
                                break;
                        }

                        if (!failedcombination)
                        {
                            this.RichTextBox_Log.SelectionColor = Color.Green;
                            this.RichTextBox_Log.AppendText("分包成功！\n");
                            this.RichTextBox_Log.Select(this.RichTextBox_Log.TextLength, 0);
                            this.RichTextBox_Log.ScrollToCaret();
                            //divisionblockcount[0].Add(r.ToString() + ", " + s.ToString());
                            //if (divisionblockcount[0].Count == 1)
                            {
                                stopupdatepoints = true;
                                blockcount = r;
                                lonblockcount = r;
                                smalllayerblockcount = s;
                                lonsmalllayerblockcount = s;

                                //verify POI counts
                                tmp_POIcontained = 0;
                                for (i = 0; i < points.GetLength(0); i++)
                                    for (j = 0; j < points.GetLength(1); j++)
                                        tmp_POIcontained += points[i, j].Count;

                                this.Button_Save_File.Enabled = true;
                                //Console.WriteLine("数据总数：" + tmp_POIcontained);
                                this.RichTextBox_Log.SelectionColor = Color.Black;
                                this.RichTextBox_Log.AppendText("数据总数：" + tmp_POIcontained + "\n");
                                this.RichTextBox_Log.Select(this.RichTextBox_Log.TextLength, 0);
                                this.RichTextBox_Log.ScrollToCaret();
                                return;
                            }
                        }

                        //Console.WriteLine("超过限制,进行更小的分包操作！");
                        this.RichTextBox_Log.SelectionColor = Color.Red;
                        this.RichTextBox_Log.AppendText("超过限制,进行更小的分包操作！\n");
                        this.RichTextBox_Log.Select(this.RichTextBox_Log.TextLength, 0);
                        this.RichTextBox_Log.ScrollToCaret();

                        tmpPOIsum = 0;
                        for (i = 0; i < r * s; i++)
                            for (j = 0; j < r * s; j++)
                                tmpPOIsum += long.Parse(DGV_verifydivision.Rows[i].Cells[j].Value.ToString());

                        if (tmpPOIsum != DGV_excel.RowCount)
                            MessageBox.Show("Wrong Division!!!");

                        for (i = 0; i < tmppoints.GetLength(0); i++)
                        {
                            for (j = 0; j < tmppoints.GetLength(1); j++)
                            {
                                tmppoints[i, j].Clear();
                                if (!stopupdatepoints)
                                    points[i, j].Clear();
                            }
                        }
                    } // end of small < testnum
                } // end of large < testnum
                //Console.WriteLine("分包失败！");
                this.RichTextBox_Log.SelectionColor = Color.Yellow;
                this.RichTextBox_Log.AppendText("分包失败！\n");
                this.RichTextBox_Log.Select(this.RichTextBox_Log.TextLength, 0);
                this.RichTextBox_Log.ScrollToCaret();
            } // end of else
        }
        public void SaveExcelFile(string excelfile)
        {
            Console.WriteLine("--------------------SaveExcelFile----------------------------");

            int i = 0, j = 0, k = 0;
            int ii = 0, jj = 0;
            long tmp_POIcontained2 = 0;
            int tmpcount = 0, tmplonindex = 0, tmplatindex = 0, tmplonsmallindex = 0, tmplatsmallindex = 0;
            int[] largelayer = new int[blockcount * lonblockcount];
            int[] largelayerbytes = new int[blockcount * lonblockcount];
            int tmppoint = 0, largelayeroffset = 0, smalllayeroffset = 0, tmpoffset = 0, tmpsmalloffset = 0;
            int sizeofeachcamera = 0, sizeofsmallblockheader = 0, sizeoflargeblockheader = 0, sizeofglobalheader = 0;
            double tmpcamx = 0.0, tmpcamy = 0.0;
            FileStream output;
            BinaryWriter outputwriter;          

            //for debug
            ArrayList debuglist = new ArrayList();

            double camdegree = 0.0, camdegree_float = 0.0;
            int camdegree_int = 0;

            if (!System.IO.Directory.Exists(TextBox_BinPath.Text.Trim()))
                System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(TextBox_BinPath.Text.Trim()));

            output = File.Create(TextBox_BinPath.Text);
            outputwriter = new BinaryWriter(output);

            // output order: Global, Large layer, Small layer
            // 1. Global header            
            outputwriter.Write((ushort)Lon_Start); // Start position of Longitude
            outputwriter.Write((ushort)Lat_Start);  // Start position of Latitude
            outputwriter.Write((ushort)Lon_End);  // End position of Longitude
            outputwriter.Write((ushort)Lat_End);   // End position of Latitude

            outputwriter.Write((ushort)lonsmalllayerblockcount); // Small Layer Block Number of Longitude
            outputwriter.Write((ushort)smalllayerblockcount);   // Small Layer Block Number of Latitude
            outputwriter.Write((ushort)lonblockcount); // Large Layer Block Number of Longitude
            outputwriter.Write((ushort)blockcount);  // Small Layer Block Number of Latitude                               

            // version of the camera data
            outputwriter.Write((byte)(dataversion));

            //for 4-byte alignment
            for (i = 1; i <= 3; i++)
                outputwriter.Write((byte)' ');

            // for MiTAC mioversion [4]
            outputwriter.Write((uint)version);

            //for systemtime [12]
            str_datetime += '\0';
            char[] tmpchar1 = str_datetime.ToCharArray();
            for (i = 0; i < tmpchar1.Length; i++)
            {
                outputwriter.Write((byte)tmpchar1[i]);
            }

            for (i = 1; i <= (12 - tmpchar1.Length); i++)
                outputwriter.Write((byte)' ');

            sizeofglobalheader = sizeof(ushort) * 8 + sizeof(byte) * 4 + sizeof(uint) * 1 + sizeof(byte) * 12; // new add: Version[4], SysteTime[12]
            sizeoflargeblockheader = sizeof(ushort) * 5;
            sizeofsmallblockheader = sizeof(ushort) * 5;

              
            sizeofeachcamera = sizeof(double) * 2 + sizeof(byte) * 4 + 1; // 21

            //verify POI counts
            tmp_POIcontained2 = 0;
            for (ii = 0; ii < points.GetLength(0); ii++)
                for (jj = 0; jj < points.GetLength(1); jj++)
                    tmp_POIcontained2 += points[ii, jj].Count;
            tmp_POIcontained2 = 0;

            // largelayer[i]: # of points contained in the i-th large layer                                             
            for (i = 0; i < blockcount * lonblockcount; i++)
            {
                tmpcount = 0;
                for (j = 0; j < smalllayerblockcount * lonsmalllayerblockcount; j++)
                {
                    tmpcount += points[i, j].Count;
                }
                largelayer[i] = tmpcount;
            }

            int tttt = 0;  // tttt: total number of points
            for (i = 0; i < blockcount * lonblockcount; i++)
            {
                tttt += largelayer[i];
            }

            // largelayerbytes[i]: # of bytes required for the i-th large layer
            for (i = 0; i < blockcount * lonblockcount; i++)
            {
                largelayerbytes[i] = largelayer[i] * sizeofeachcamera + sizeofsmallblockheader * smalllayerblockcount * lonsmalllayerblockcount +
                                                    sizeof(uint) * smalllayerblockcount * lonsmalllayerblockcount + sizeoflargeblockheader;
            }

            // for large layer # 0
            largelayeroffset = sizeofglobalheader + sizeof(uint) * blockcount * lonblockcount;
            outputwriter.Write((uint)(largelayeroffset));
            Console.WriteLine("获取第0个数据包需要偏移:" + largelayeroffset);

            // for subsequent large layer
            tmpoffset = largelayeroffset;
            for (i = 1; i < blockcount * lonblockcount; i++)
            {
                tmpoffset = tmpoffset + largelayerbytes[i - 1];
                outputwriter.Write((uint)(tmpoffset));
                Console.WriteLine("获取第" + i + "个数据包需要偏移:" + tmpoffset);
            }

            // 2. Larger layer header                        
            for (i = 0; i < blockcount * lonblockcount; i++)
            {
                outputwriter.Write((ushort)largelayer[i]); // # of points
                tmplatindex = (int)Math.Floor((double)(i / lonblockcount));
                tmplonindex = i - tmplatindex * lonblockcount;

                outputwriter.Write((ushort)(Lat_Start)); // Start Latitude
                outputwriter.Write((ushort)(Lon_Start)); // Start Lontitude

                outputwriter.Write((ushort)Lat_End);
                outputwriter.Write((ushort)Lon_End);

                // for smaller block # 0
                if (i == 0)
                    smalllayeroffset = largelayeroffset + sizeoflargeblockheader + sizeof(uint) * smalllayerblockcount * lonsmalllayerblockcount;
                else
                {
                    tmpsmalloffset = 0;
                    for (j = i; j > 0; j--)
                    {
                        tmpsmalloffset = tmpsmalloffset + largelayerbytes[j - 1];
                    }
                    smalllayeroffset = largelayeroffset + tmpsmalloffset + sizeoflargeblockheader + sizeof(uint) * smalllayerblockcount * lonsmalllayerblockcount;
                }

                outputwriter.Write((uint)(smalllayeroffset));

                // for subsequent smaller block
                tmpsmalloffset = smalllayeroffset;
                for (j = 1; j < smalllayerblockcount * lonsmalllayerblockcount; j++)
                {
                    tmpsmalloffset = tmpsmalloffset + sizeofsmallblockheader + sizeofeachcamera * points[i, j - 1].Count;
                    // a. # of points in each small layer
                    outputwriter.Write((uint)(tmpsmalloffset));
                }

                // 3. Small Layer header, for each point in each small layer
                for (j = 0; j < smalllayerblockcount * lonsmalllayerblockcount; j++)
                {
                    outputwriter.Write((ushort)points[i, j].Count); // # of points
                    tmplatsmallindex = (int)Math.Floor((double)j / lonsmalllayerblockcount);
                    tmplonsmallindex = j - tmplatsmallindex * lonsmalllayerblockcount;

                    outputwriter.Write((ushort)(Lat_Start)); // Start Latitude
                    outputwriter.Write((ushort)(Lon_Start)); // Start of Lon

                    outputwriter.Write((ushort)(Lat_End)); // End of Lat
                    outputwriter.Write((ushort)(Lon_End)); // End of Lon

                    tmpcamx = 0.0;
                    tmpcamy = 0.0;
                    for (k = 0; k < points[i, j].Count; k++)
                    {
                        camdegree = 0.0;
                        camdegree_float = 0.0;
                        camdegree_int = 0;

                        tmppoint = int.Parse(points[i, j][k].ToString());

                        camdegree = double.Parse(DGV_excel.Rows[tmppoint].Cells[1].Value.ToString());
                        camdegree_int = (int)Math.Truncate(camdegree);
                        camdegree_float = camdegree - camdegree_int;
                        camdegree = camdegree_int * 100 + camdegree_float * 60;
                        if (k == 0)
                            tmpcamx = camdegree;

                        //输出经度
                        outputwriter.Write((double)camdegree);

                        //---------------------------- X ---------------------------------------------//
                        camdegree = double.Parse(DGV_excel.Rows[tmppoint].Cells[2].Value.ToString());
                        camdegree_int = (int)Math.Truncate(camdegree);
                        camdegree_float = camdegree - camdegree_int;
                        camdegree = camdegree_int * 100 + camdegree_float * 60;
                        if (k == 0)
                            tmpcamy = camdegree;

                        //输出纬度
                        outputwriter.Write((double)camdegree);

                        outputwriter.Write((byte)(double.Parse(DGV_excel.Rows[tmppoint].Cells[4].Value.ToString()))); //ubSpeed

                        outputwriter.Write((byte)(double.Parse(DGV_excel.Rows[tmppoint].Cells[3].Value.ToString()) / 2)); //ubDirection

                        outputwriter.Write((byte)(int.Parse(DGV_excel.Rows[tmppoint].Cells[5].Value.ToString()))); // ubCamera type

                        outputwriter.Write((byte)(int.Parse(DGV_excel.Rows[tmppoint].Cells[6].Value.ToString()))); //ubDir type

                        outputwriter.Write((byte)(int.Parse(DGV_excel.Rows[tmppoint].Cells[7].Value.ToString()))); //ubSPD type                        if (Isdebug) debuglist.Add(DGV_excel.Rows[tmppoint].Cells[7].Value.ToString());
                    }
                }

            }   // end of for (i = 0; i < blockcount*lonblockcount; i++)

            // Clear and Dispose
            outputwriter.Flush();
            output.Flush();
            outputwriter.Close();
            output.Close();

            for (i = 0; i < blockcount * lonblockcount; i++)
                for (j = 0; j < smalllayerblockcount * lonsmalllayerblockcount; j++)
                    points[i, j].Clear();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Console.WriteLine("--------------------openFileDialog1_FileOk----------------------------");

            if (openFileDialog1.CheckFileExists)
            {
                FileName = Application.StartupPath + "\\speedcam_settings.ini";
                Thread_Load.Start(openFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("File no exists");
               // btn_openexcel.Focus();
            }
        }

        private void Save_File_Click(object sender, EventArgs e)
        {
            SaveExcelFile(openFileDialog1.FileName);
            this.RichTextBox_Log.SelectionColor = Color.Green;
            this.RichTextBox_Log.AppendText("保存成功！软件自动关闭！\n");
            Thread.Sleep(2);
            Application.Exit();
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            Thread_Convert.Start();
        }

        private void Browse_File_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void DIR_TYPE_Statue(object sender, EventArgs e)
        {
            Console.WriteLine("CheckBox_DIR_TYPE");
        }

        private void SPE_TYPE_Statue(object sender, EventArgs e)
        {
            Console.WriteLine("CheckBox_SPE_TYPE");
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            DGV_excel.FirstDisplayedScrollingRowIndex = vScrollBar1.Value;
            //Console.WriteLine("vScrollBar1_Scroll:" + vScrollBar1.Value);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            DGV_excel.FirstDisplayedScrollingColumnIndex = hScrollBar1.Value;
            //Console.WriteLine("hScrollBar1_Scroll:" + hScrollBar1.Value);
        }
    }
}
