using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BasicThreadingMartinez
{
    public partial class FrmBasicThread : Form
    {
        private Thread thread1, thread2;
        public FrmBasicThread()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before Starting Thread-");

            ThreadStart basicThreadStart = new ThreadStart(MyThreadClass.Thread1);

            thread1 = new Thread(basicThreadStart);
            thread1.Name = "Thread A";

            thread2 = new Thread(basicThreadStart);
            thread2.Name = "Thread B";

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine("-End of Thread-");
            lblThread.Text = "-End of Thread-";




        }
    }
}
