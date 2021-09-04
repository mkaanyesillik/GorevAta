using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorevAta
{
    public partial class KisayolProgramAtama : Form
    {

        public KisayolProgramAtama()
        {
            InitializeComponent();

        }
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern short GetAsyncKeyState(int Tus); // GetAsyncKeyState windows apisi gönderilen tuşa basılıp basılmadığını kontrol eder (ister uygulama için ister uygulama dışı farketmez.)


        [DllImport("user32.dll")]
        public static extern bool ShowWindowAsync(HandleRef hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr WindowHandle);
        public const int SW_RESTORE = 9;

        string dosya1;
        string dosya2;
        string dosya3;
        string dosya4;
        string dosya5;
        string dosya6;
        string dosya7;


        private void Form1_Load(object sender, EventArgs e)
        {

            string dosya_yolu = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\kısayollar.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();
            while (yazi != null)
            {
                string[] labeldata = yazi.Split(',');
                if (labeldata[0] == "F12")
                {
                    label1.Text = labeldata[1];
                }
                if (labeldata[0] == "F11")
                {
                    label2.Text = labeldata[1];
                }
                if (labeldata[0] == "F10")
                {
                    label3.Text = labeldata[1];
                }
                if (labeldata[0] == "F9")
                {
                    label4.Text = labeldata[1];
                }
                if (labeldata[0] == "F8")
                {
                    label5.Text = labeldata[1];
                }
                if (labeldata[0] == "F7")
                {
                    label6.Text = labeldata[1];
                }
                if (labeldata[0] == "F6")
                {
                    label7.Text = labeldata[1];
                }
                yazi = sw.ReadLine();

            }
            sw.Close();
            fs.Close();

        }
        public static bool TusKontrol(byte Kod) // Windows apisini kullanarak tuş kontrolü yapar.
        {
            if (GetAsyncKeyState((int)Kod) == System.Int16.MinValue + 1)
                return true;
            else
                return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TusKontrol((byte)Keys.F12))
            {
                if (dosya1 == "")
                {

                }
                else
                {
                    Process.Start(dosya1);
                }

            }
            if (TusKontrol((byte)Keys.F11))
            {
                if (dosya2 == "")
                {

                }
                else
                {
                    Process.Start(dosya2);
                }

            }
            if (TusKontrol((byte)Keys.F10))
            {
                if (dosya3 == "")
                {

                }
                else
                {
                    Process.Start(dosya3);
                }

            }
            if (TusKontrol((byte)Keys.F9))
            {
                if (dosya4 == "")
                {

                }
                else
                {
                    Process.Start(dosya4);
                }

            }
            if (TusKontrol((byte)Keys.F8))
            {
                if (dosya5 == "")
                {

                }
                else
                {
                    Process.Start(dosya5);
                }

            }
            if (TusKontrol((byte)Keys.F7))
            {
                if (dosya6 == "")
                {

                }
                else
                {
                    Process.Start(dosya6);
                }

            }
            if (TusKontrol((byte)Keys.F6))
            {
                if (dosya7 == "")
                {

                }
                else
                {
                    Process.Start(dosya7);
                }

            }
        }





        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Uygulama Dosyaları (*.exe)|*.exe";
            ofd.ShowDialog();
            label1.Text = ofd.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Uygulama Dosyaları (*.exe)|*.exe";
            ofd.ShowDialog();
            label2.Text = ofd.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Uygulama Dosyaları (*.exe)|*.exe";
            ofd.ShowDialog();
            label3.Text = ofd.FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Uygulama Dosyaları (*.exe)|*.exe";
            ofd.ShowDialog();
            label4.Text = ofd.FileName;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Uygulama Dosyaları (*.exe)|*.exe";
            ofd.ShowDialog();
            label5.Text = ofd.FileName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Uygulama Dosyaları (*.exe)|*.exe";
            ofd.ShowDialog();
            label6.Text = ofd.FileName;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Uygulama Dosyaları (*.exe)|*.exe";
            ofd.ShowDialog();
            label7.Text = ofd.FileName;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text != "Program Yolu")
            {

                dosya1 = label1.Text;
            }
            if (label2.Text != "Program Yolu")
            {

                dosya2 = label2.Text;
            }
            if (label3.Text != "Program Yolu")
            {

                dosya3 = label3.Text;
            }
            if (label4.Text != "Program Yolu")
            {

                dosya4 = label4.Text;
            }
            if (label5.Text != "Program Yolu")
            {

                dosya5 = label5.Text;
            }
            if (label6.Text != "Program Yolu")
            {

                dosya6 = label6.Text;
            }
            if (label7.Text != "Program Yolu")
            {

                dosya7 = label7.Text;
            }
            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\kısayollar.txt");
            string dosya_yolu = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\kısayollar.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("F12," + dosya1);
            sw.WriteLine("F11," + dosya2);
            sw.WriteLine("F10," + dosya3);
            sw.WriteLine("F9," + dosya4);
            sw.WriteLine("F8," + dosya5);
            sw.WriteLine("F7," + dosya6);
            sw.WriteLine("F6," + dosya7);


            sw.Flush();
            sw.Close();
            fs.Close();

        }


    }
}
