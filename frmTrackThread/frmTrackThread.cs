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

namespace frmTrackThread
{
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                label1.Text = "Thread Starts...";
                Refresh();

                Thread threadA = new Thread(new ThreadStart(MyThreadClass.Thread1));
                Thread threadB = new Thread(new ThreadStart(MyThreadClass.Thread2));
                Thread threadC = new Thread(new ThreadStart(MyThreadClass.Thread2));
                Thread threadD = new Thread(new ThreadStart(MyThreadClass.Thread1));

                threadA.Priority = ThreadPriority.Highest;
                threadB.Priority = ThreadPriority.Normal;
                threadC.Priority = ThreadPriority.AboveNormal;
                threadD.Priority = ThreadPriority.BelowNormal;

                threadA.Name = "Thread A";
                threadB.Name = "Thread B";
                threadC.Name = "Thread C";
                threadD.Name = "Thread D";


                threadA.Start();
                threadB.Start();
                threadC.Start();
                threadD.Start();

                threadA.Join();
                threadB.Join();
                threadC.Join();
                threadD.Join();

                label1.Text = "End of Thread.";
            }
        }
    }
}
