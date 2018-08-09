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


namespace multiThread
{
   
    public partial class Form1 : Form
    {
        Thread t1;
        Thread t2;
        public class progressValue
        {
            public int v1 { get; set; }
            public int v2 { get; set; }
            public progressValue(int v1, int v2)
            {
                this.v1 = v1;
                this.v2 = v2;
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        delegate void play1delegate(Object pv);
        delegate void play2delegate(Object pv);

        public void play1(Object pv)
        {

              play1delegate pd1 = new play1delegate(setText1);
      
              for (int i = 0; i < 11; i++)
              {
                  this.Invoke(pd1,pv);
                  //Thread.Sleep(30);

              }
         
          
            
        }
        public void play2(Object pv)
        {

            play2delegate pd1 = new play2delegate(setText2);

            for (int i = 0; i < 10; i++)
            {
                this.Invoke(pd1,pv);
                //Thread.Sleep(300);

            }



        }

        public void setText2(Object obj)
        {
            progressValue pv = (progressValue)obj;
            Monitor.Enter(pv);
            //if (pv.v1 == pv.v2)
            {
               // progressValue pv = new progressValue(progressBar1.Value, progressBar2.Value);
             
                Monitor.PulseAll(pv);
                if (Monitor.Wait(pv, 1000))
                {
                    if (progressBar2.Value < progressBar2.Maximum)
                    {
                        progressBar2.PerformStep();
                        pv.v2 = progressBar2.Value;
                    };

                    listBox1.Items.Add(progressBar2.Name + " Step:" + Convert.ToString(progressBar2.Value));
                    listBox1.Refresh();
                }
               
            }
            Monitor.Exit(pv);    

        }
        public void setText1(Object obj)
        {
           
         
           // while (progressBar1.Value < progressBar2.Value)
           // {
                //progressValue pv = new progressValue(progressBar1.Value, progressBar2.Value); 
                progressValue pv = (progressValue)obj;
                Monitor.Enter(pv);
                //
                while (pv.v1 < pv.v2)
                {
                    Monitor.Wait(pv); 
                    if (progressBar1.Value < progressBar1.Maximum)
                    {
                        progressBar1.PerformStep();
                        pv.v1 = progressBar1.Value;
                    };
                    listBox1.Items.Add(progressBar1.Name + " Step:" + Convert.ToString(progressBar1.Value));
                    listBox1.Refresh();
                    Monitor.PulseAll(pv); 
                }
                listBox1.Items.Add(progressBar1.Name + " Step Comlete:" + Convert.ToString(progressBar1.Value));
                listBox1.Refresh();
               // 
                Monitor.Exit(pv);
           // }
                   
                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Main Thread Start");
            listBox1.Refresh();
            t1 = null;
            t2 = null;
            progressValue pv2 = new progressValue(progressBar1.Value, progressBar2.Value);
            t1 = new Thread(new ParameterizedThreadStart(play1));
            t1.Name = "線程1";
            t1.Start(pv2);

            //
            t2 = new Thread(new ParameterizedThreadStart(play2));
            t2.Name = "線程2";
            t2.Start(pv2);
            //Monitor.TryEnter();
            //t1.Join(); 
          
           /* 
            int i = 0;
            while (i<10) {
                listBox1.Items.Add("Main Thread IDLE");
                listBox1.Refresh();
                Thread.Sleep(300);
                i++;
            }
           */
  

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (t1 !=null)
               if (t1.ThreadState == ThreadState.Running ) 
                   t1.Abort();
            if (t2 != null)
               if (t2.ThreadState == ThreadState.Running ) 
                   t2.Abort();
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* if (t1.ThreadState == ThreadState.Running)
               t1.Suspend();
            if (t2.ThreadState == ThreadState.Running)
               t2.Suspend();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*if (t1.ThreadState == ThreadState.Suspended)
                t1.Resume();
            if (t2.ThreadState == ThreadState.Suspended)
                t2.Resume();*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 1000;
            tmr.Enabled = true;
            tmr.Tick += new EventHandler(mtmrEvent);
        }
        private void mtmrEvent(object o,EventArgs e)
        {
            DateTime dtTime = new DateTime();
            dtTime = DateTime.Now;
            //string strtime = string.Format("{0:yyy/MM/dd HH:mm:ss}",dtTime);
            string strtime = string.Format("{0:F}", dtTime);
            listBox1.Items.Add(strtime);
            listBox1.Refresh();
        }

    }
}
