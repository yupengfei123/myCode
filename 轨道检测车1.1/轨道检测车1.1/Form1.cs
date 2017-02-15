using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 轨道检测车1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnParaSet_Click(object sender, EventArgs e)
        {
            ParameterSet m_ParameterSet = new ParameterSet();
            m_ParameterSet.Show();
        }
    }
}
