using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    
    public partial class Form1 : Form
    {
        string[][] languageList = new string[][] {
            new string[] { "日语Shift-JIS", "日语" },
            new string[] { "简体中文GBK", "中文（中华人民共和国），中文（香港特别行政区）" },
            new string[] { "韩文", "朝鲜语" }
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initLanguageList();
        }

        private void initLanguageList()
        {
            
            //item.Text = Convert.ToString(listView1.Items.Count + 1);
            foreach(string[] a in languageList) {
                ListViewItem item = new ListViewItem();
                item.Text = a[0];
                item.SubItems.Add(a[1]);
                listView1.Items.Add(item);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
