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
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        String Compression_Bin_Name = @"./Icon.bin";
        String Bin_Name = @"./Pcm.bin";
        String Bin_IconImage = @"./IconImage.bin";
        String Bin_Font = @"./Font.fon";

        int Icon_Num = 0, Icon_Size = 0;
        int Pcm_Num = 0, Pcm_Size;
        List<int> Icon_List = new List<int>();
        List<int> Pcm_List = new List<int>();

        public Form1()
        {
            InitializeComponent();
            Clear_Data();

            foreach (String tmp in Directory.GetFiles(@"./Test_Image/tmp/", "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".png") || s.EndsWith(".wav") || s.EndsWith(".bmp") || s.EndsWith(".jpg")))
            {
                Deal_Picture(tmp);
            }

            Merge_Bin();
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
                Sum += Icon_List[i];
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
                Sum += Pcm_List[i];
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
            FileStream BinFont = new FileStream(Bin_Font, FileMode.Open, FileAccess.Read);
            Length = (int)BinFont.Length;
            Pos += BinFont.Read(Buf, 0, Length);
            BinFont.Close();
            sw.BaseStream.Write(Buf, 0, Pos);
            Pos = 0;

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

            int Ret = 0;

            if (Name.EndsWith(".bmp"))
            {
                Bitmap map = (Bitmap)Bitmap.FromFile(Name);
                Ret = Deal_Data_Compression(map, Bytes);
                Save_Data_Compression(Ret, Bytes);
            }
            else if (Name.EndsWith(".png") || Name.EndsWith(".wav") || Name.EndsWith(".jpg"))
            {
                Ret = Length;
                Save_Data(Ret, Bytes);
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
            Icon_List.Add(Num);
            Icon_Num++;

            sw.Close();
            BinStream.Close();
        }

        public void Save_Data(int Num, byte[] Data)
        {
            FileStream BinStream = new FileStream(Bin_Name, FileMode.Append, FileAccess.Write);
            BinaryWriter sw = new BinaryWriter(BinStream);

            sw.BaseStream.Write(Data, 0, Num);
            Pcm_List.Add(Num);
            Pcm_Size += Num; 
            Pcm_Num++;

            sw.Close();
            BinStream.Close();
        }
    }
}
