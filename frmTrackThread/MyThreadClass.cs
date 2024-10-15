using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace frmTrackThread
{
    public class MyThreadClass
    {
        public static void Thread1()
        {
            for (int i = 0; i < 2; i++)
            {
                Thread currentThread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + currentThread.Name + " Process = " + i);
                Thread.Sleep(500);
            }
        }


        public static void Thread2()
        {
            for (int i = 0; i < 6; i++)
            {
                Thread currentThread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + currentThread.Name + " Process = " + i);
                Thread.Sleep(1500); 
            }
        }
    }
}
