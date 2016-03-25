using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 作业
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Name.Text = "";
            Sex.Text = "";
            Score.Text = "";
            Rank.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string m_strName = Name.Text;
            string m_strSex = Sex.Text;
            string m_strScore = Score.Text;
            string m_strRank = Rank.Text;
            try{
                ListViewItem m_listviewItem1 = new ListViewItem();
                m_listviewItem1.SubItems[0].Text = m_strName;
                //m_listviewItem1.SubItems.Add(m_strName);
                m_listviewItem1.SubItems.Add(m_strSex);
                m_listviewItem1.SubItems.Add(m_strScore);
                m_listviewItem1.SubItems.Add(m_strRank);
                listView1.Items.Add(m_listviewItem1);
                MessageBox.Show("添加成功");
            }
            catch
            {
                MessageBox.Show("添加失败！");
            }


        }
    }
}
