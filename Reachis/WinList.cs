using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reachis
{
    public partial class WinList : UserControl
    {
        public WinList()
        {
            InitializeComponent();
        }

        public WinList(string TextWL, int Min)
        {
            InitializeComponent();
            label_TaskWL.Text = TextWL;
            label_WL_Time.Text = Min.ToString();
        }

        private void Button_Edit_Task_Click(object sender, EventArgs e)
        {

        }
    }
}
