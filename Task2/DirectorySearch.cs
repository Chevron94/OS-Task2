using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task2
{
    class DirectorySearch
    {
        string path;
        int count = 0;
        ListBox lb;
        public DirectorySearch(string _path, ref ListBox _lb)
        {
            path = _path;
            lb = _lb;
        }

        public void CountAndPrint()
        {
            foreach (string dir in RsdnDirectory.GetAllDirectories(path))
            {
                lb.Invoke(new Action(() => lb.Items.Add(dir)));
                count++;
            }
        }

        public int Count
        {
            get { return count; }
        }
        
    }
}
