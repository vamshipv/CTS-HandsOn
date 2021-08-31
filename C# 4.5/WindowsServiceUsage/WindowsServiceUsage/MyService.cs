using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;

using System.Threading.Tasks;
using System.Timers;

namespace WindowsService_Demo
{
    public partial class MyService : ServiceBase
    {
        readonly Timer timer = new Timer();
        public MyService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            WriteToFile("Service is started at " + DateTime.Now);
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 2000; 
            timer.Enabled = true;
        }

        protected override void OnStop()
        {
            WriteToFile("Service stopped at " + DateTime.Now);
        }

        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            WriteToFile("Service recall at " + DateTime.Now);
        }

        public void WriteToFile(string Message)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";
            if (!File.Exists(filepath))
            {
                // Create a file to write to.   
                using (StreamWriter sWrite = File.CreateText(filepath))
                {
                    sWrite.WriteLine(Message);
                }
            }
            else
            {
                using (StreamWriter sWrite = File.AppendText(filepath))
                {
                    sWrite.WriteLine(Message);
                }
            }
        }
    }
}
