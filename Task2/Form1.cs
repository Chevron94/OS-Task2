using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Application.Idle += MyIdle;
        }

        string first_path;
        string second_path;
        bool Accept = true;

        void MyIdle(object sender, EventArgs e)
        {
            Search.Enabled = FirstPath.Text != "" && SecondPath.Text != "" && Accept;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Thread Thread = new Thread(new ThreadStart(Searching));
            Thread.Start();
        }

        void Searching()
        {
            Accept = false;
            DirectorySearch DirectorySearchFirstPath = new DirectorySearch(first_path, ref FirstPathList);
            DirectorySearch DirectorySearchSecondPath = new DirectorySearch(second_path, ref SecondPathList);
            Thread First = new Thread(new ThreadStart(DirectorySearchFirstPath.CountAndPrint));
            Thread Second = new Thread(new ThreadStart(DirectorySearchSecondPath.CountAndPrint));
            First.Start();
            Second.Start();
            First.Join();
            Second.Join();
            string tmp = "В каталоге \""+first_path + "\" " + DirectorySearchFirstPath.Count + " подпапок.\n В каталоге \"" + second_path + "\" " + DirectorySearchSecondPath.Count.ToString() + " подпапок";
            if (DirectorySearchFirstPath.Count > DirectorySearchSecondPath.Count)
                MessageBox.Show("Число подпапок в каталоге \"" + first_path + "\" больше, чем в \"" + second_path +"\"\n " + tmp);
            else if (DirectorySearchFirstPath.Count < DirectorySearchSecondPath.Count)
                MessageBox.Show("Число подпапок в каталоге \"" + first_path + "\" меньше, чем в \"" + second_path + "\"\n " + tmp);
            else MessageBox.Show("Число подпапок в каталоге \"" + first_path + "\" и \"" + second_path +"\" совпадает.\n  Число подпапок в каталогах = " + DirectorySearchSecondPath.Count.ToString());
            Accept = true;
        }

        private void SetSecondPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                second_path = folderBrowserDialog2.SelectedPath;
                SecondPath.Text = second_path;
            }
        }

        private void SetFirstPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                first_path = folderBrowserDialog1.SelectedPath;
                FirstPath.Text = first_path;
            }
        }
    }
}
