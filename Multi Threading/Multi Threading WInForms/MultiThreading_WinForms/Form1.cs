using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreading_WinForms
{
    public partial class MultiThreading : Form
    {
        public MultiThreading()
        {
            InitializeComponent();
        }

        private void btn_freeze_Click(object sender, EventArgs e)
        {
            btn_freeze.Enabled = false;
            btn_printList.Enabled = false;

            Thread freezingThread = new Thread(freezeBtnFunction);
            freezingThread.Start();
            //freezeBtnFunction();

            btn_freeze.Enabled = true;
            btn_printList.Enabled = true;
        }

        public void freezeBtnFunction()
        {
            Thread.Sleep(5000);
        }

        private void btn_printList_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 10; i++) 
            {
                listBox.Items.Add("Item : " + i);
            }
        }
    }
}
