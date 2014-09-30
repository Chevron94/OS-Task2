namespace Task2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstPathList = new System.Windows.Forms.ListBox();
            this.SecondPathList = new System.Windows.Forms.ListBox();
            this.FirstPath = new System.Windows.Forms.TextBox();
            this.SecondPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SetFirstPath = new System.Windows.Forms.ToolStripMenuItem();
            this.SetSecondPath = new System.Windows.Forms.ToolStripMenuItem();
            this.Search = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstPathList
            // 
            this.FirstPathList.FormattingEnabled = true;
            this.FirstPathList.HorizontalScrollbar = true;
            this.FirstPathList.Location = new System.Drawing.Point(12, 109);
            this.FirstPathList.Name = "FirstPathList";
            this.FirstPathList.Size = new System.Drawing.Size(378, 225);
            this.FirstPathList.TabIndex = 0;
            // 
            // SecondPathList
            // 
            this.SecondPathList.FormattingEnabled = true;
            this.SecondPathList.HorizontalScrollbar = true;
            this.SecondPathList.Location = new System.Drawing.Point(410, 109);
            this.SecondPathList.Name = "SecondPathList";
            this.SecondPathList.Size = new System.Drawing.Size(378, 225);
            this.SecondPathList.TabIndex = 1;
            // 
            // FirstPath
            // 
            this.FirstPath.Location = new System.Drawing.Point(12, 62);
            this.FirstPath.Name = "FirstPath";
            this.FirstPath.ReadOnly = true;
            this.FirstPath.Size = new System.Drawing.Size(341, 20);
            this.FirstPath.TabIndex = 2;
            // 
            // SecondPath
            // 
            this.SecondPath.Location = new System.Drawing.Point(410, 62);
            this.SecondPath.Name = "SecondPath";
            this.SecondPath.ReadOnly = true;
            this.SecondPath.Size = new System.Drawing.Size(341, 20);
            this.SecondPath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Первый каталог:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Второй каталог";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Список подкаталогов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Список подкаталогов";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetFirstPath,
            this.SetSecondPath,
            this.Search});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SetFirstPath
            // 
            this.SetFirstPath.Name = "SetFirstPath";
            this.SetFirstPath.Size = new System.Drawing.Size(145, 20);
            this.SetFirstPath.Text = "Задать первый каталог";
            this.SetFirstPath.Click += new System.EventHandler(this.SetFirstPath_Click);
            // 
            // SetSecondPath
            // 
            this.SetSecondPath.Name = "SetSecondPath";
            this.SetSecondPath.Size = new System.Drawing.Size(142, 20);
            this.SetSecondPath.Text = "Задать второй каталог";
            this.SetSecondPath.Click += new System.EventHandler(this.SetSecondPath_Click);
            // 
            // Search
            // 
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(132, 20);
            this.Search.Text = "Поиск подкаталогов";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondPath);
            this.Controls.Add(this.FirstPath);
            this.Controls.Add(this.SecondPathList);
            this.Controls.Add(this.FirstPathList);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск всех подкаталогов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FirstPathList;
        private System.Windows.Forms.ListBox SecondPathList;
        private System.Windows.Forms.TextBox FirstPath;
        private System.Windows.Forms.TextBox SecondPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SetFirstPath;
        private System.Windows.Forms.ToolStripMenuItem SetSecondPath;
        private System.Windows.Forms.ToolStripMenuItem Search;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
    }
}

