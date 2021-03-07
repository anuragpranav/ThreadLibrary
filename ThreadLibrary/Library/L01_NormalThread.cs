using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadLibrary.Library
{
    public class L01_NormalThread
    {
        static int i = 0;
        public static void Logic()
        {
            for (i = 0; i < 5; i++)
            {
                new Thread(LongRunningThread).Start();
            }
        }

        private static void LongRunningThread()
        {
            Console.WriteLine("Thread started : "+i);
            Thread.Sleep(2000);
            Console.WriteLine("Thread ended : " + i);

        }
    }

}
