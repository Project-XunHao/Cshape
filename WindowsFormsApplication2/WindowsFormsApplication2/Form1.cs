using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        string Name_Array = "TEXT";
        string Language_Array = "Other";
        string All_Name_Array = "TEXT";

        public Form1()
        {
            InitializeComponent();
            textBox4.Text = All_Name_Array;
        }

        private void button1_Click(object sender, EventArgs e) //  Unicode To Ascii
        {
            string[] Array = textBox1.Text.Split(';');
            int Start_Char, End_Char, i;
            string _Array = "";

            //把字符串数组，按链表的方式存储起来
            List<string> list = Array.ToList();

            for (i = 0; i < list.Count; i++)
            { 
                Start_Char = Array[i].IndexOf("/*");
                End_Char = Array[i].IndexOf("*/");
                if (Start_Char >= 0 && End_Char >= 0 && End_Char != Start_Char)
                {
                    list[i] = list[i].Remove(Start_Char, End_Char - Start_Char + 2);
                }
            }

            textBox2.AppendText("/*\r\n");

            for (i = 0; i < list.Count - 1; i++)
            {
                Start_Char = list[i].IndexOf('{');
                End_Char = list[i].IndexOf('}');

                if (Start_Char >= 0 && End_Char >= 0)
                {
                    _Array = list[i].Substring(Start_Char + 1, End_Char - Start_Char - 1);
                    string[] Result = _Array.Split(',');

                    textBox2.AppendText("<" + (i + 1) + ">");

                    for (int j = 0; j < Result.Length; j++)
                    {
                        if (Result[j][0] == '0' && Result[j][1] == 'x')
                        {
                            string str = Result[j].Substring(2);
                            string bytes = "";

                            bytes += (char)int.Parse(str, System.Globalization.NumberStyles.HexNumber);
                            textBox2.AppendText(bytes);
                        } 
                    }
                    textBox2.AppendText("\r\n");
                } else if (Array[i].IndexOf('L') >= 0) {
                    Start_Char = Array[i].IndexOf('\"');
                    End_Char = Array[i].LastIndexOf("\"");
                    _Array = Array[i].Substring(Start_Char + 1, End_Char - Start_Char - 1);
                    textBox2.AppendText(_Array + "\r\n");
                }
            }
            textBox2.AppendText("*/\r\n"); 
        }

        private void button2_Click(object sender, EventArgs e) // Ascii To Unicode
        {
            int Start_Char, End_Char, i, j, n;

            //按照 '\n' 来分割字符串
            string[] Array = textBox1.Text.Split(new char[] {'\n'});

            //把字符串数组，按链表的方式存储起来
            List<string> list = Array.ToList();

            Start_Char = textBox1.Text.IndexOf("<");
            End_Char = textBox1.Text.IndexOf(">");
            if (Start_Char >= 0 && End_Char >= 0 && End_Char != Start_Char)
            {
                Language_Array = textBox1.Text.Substring(Start_Char + 1, End_Char - Start_Char - 1);
            }

            //去除一些无关的行(空行等)
            for (i = 0; i < list.Count;)
            {
                if (list[i].ToString().IndexOf("/*") >= 0 || list[i].ToString().IndexOf("*/") >= 0 || list[i].ToString() == null || list[i].Equals("") == true)
                {
                    list.RemoveAt(i);
                }
                else if (list[i].ToString().IndexOfAny(new char[] { '\0', '\r', '\n'}) == 0)
                {
                    list.RemoveAt(i);
                }
                else if (list[i].ToString().IndexOf("<") >= 0 && list[i].ToString().IndexOf(">") >= 0)
                {
                    //是否有标识是那种语言 (默认Other)
                    if (list[i].ToString().IndexOf("LANGUAGE=") >= 0) {
                        Start_Char = list[i].ToString().IndexOf("=");
                        End_Char = list[i].ToString().IndexOf(">");
                        Language_Array = list[i].ToString().Substring(Start_Char + 1, End_Char - Start_Char - 1);
                        list.RemoveAt(i);
                    }
                    //是否有标识名字 (默认Other)
                    else if (list[i].ToString().IndexOf("NAME=") >= 0)
                    {
                        Start_Char = list[i].ToString().IndexOf("=");
                        End_Char = list[i].ToString().IndexOf(">");
                        Name_Array = list[i].ToString().Substring(Start_Char + 1, End_Char - Start_Char - 1);
                        list.RemoveAt(i);
                    }
                    else 
                    {
                        Start_Char = list[i].ToString().IndexOf("<");
                        End_Char = list[i].ToString().IndexOf(">");
                        list[i] = list[i].Remove(Start_Char, End_Char - Start_Char + 1);
                    }
                }
                else
                {
                    i++;
                }
            }

            //最终需要处理的文字行，打印出来
            textBox2.AppendText("/*\r\n");
            textBox2.AppendText("<LANGUAGE=" + Language_Array + ">\r\n");
            textBox2.AppendText("<NAME=" + Name_Array + ">\r\n");
            for (i = 0, n = 0; i < list.Count; i++)
            {
                textBox2.AppendText("<" + ++n + ">" + list[i].ToString() + "\n"); 
            }
            textBox2.AppendText("*/\r\n");

            //转换过来后的可用字符数组
            for (i = 0, n = 0; i < list.Count; i++)
            {
                //这里数组的命名，根据自动检测到的语言(默认：Other) + 输入的名字(默认：TEXT) + 序号( n )
                textBox2.AppendText("static const unsigned short " + Language_Array + Name_Array + "_" + ++n + "[] = {");
                for (j = 0; j < list[i].Length; j++)
                {
                    if (list[i][j] != '\r')
                        textBox2.AppendText("0x" + ((int)list[i][j]).ToString("x") + ",");
                } 
                textBox2.AppendText("0x00};\r\n");
            }

            //前面字符数组的集合，保存到一个二维数组里面
            textBox2.AppendText("static const unsigned short *" + Language_Array + Name_Array + "[] = {");
            for (j = 0; j < i; j++)
            {
                textBox2.AppendText(Language_Array + Name_Array + "_" + (j + 1) + ",");
            }
            textBox2.AppendText("};\r\n");

            textBox3.AppendText(Language_Array + Name_Array + "\r\n");
            All_Name_Array = Name_Array;
        }

        private void button3_Click(object sender, EventArgs e) // Clear
        {
            //清除所有内容
            textBox3.Clear();
            textBox2.Clear();
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i;
            string[] Array = textBox3.Text.Split(new char[] {'\n'});

            //前面字符数组的集合，保存到一个二维数组里面
            textBox2.AppendText("const unsigned short **" + Language_Array + Name_Array + "[] = {");

            for (i = 0; i < Array.Length; i++)
            {
                textBox2.AppendText(Array[i] + ",");
            }
            textBox2.AppendText("};\r\n");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            All_Name_Array = textBox4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
