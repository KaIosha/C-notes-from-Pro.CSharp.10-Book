using System.Threading.Tasks;

namespace Threading
{
    internal class Program
    {
        static bool Isfinished = false;
        static void Main(string[] args)
        {
            #region Thread Class 
            //  //Thread thread = new Thread(PrintY);
            //  Thread thread = new Thread(() => PrintY(1000));
            //  thread.Start();
            //  thread.IsBackground = true;//while the main thread Finished close
            ////thread.IsBackground = false;//wait until the child also finished
            //  for (int i = 0; i < 1000; i++)
            //  {
            //      Console.Write("X");
            //  } 
            #endregion

            #region Task 
            //Thread Task

            RunThread();
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("X");
            }

        }
        private static async Task RunThread()
        {
            // old version

            //Task<int> task = Task.Run(() => PrintY(1000));
            //task.GetAwaiter().OnCompleted(() => Console.WriteLine($"Counter is {task.Result}"));


            //new Version
            int counter = await Task.Run(() => PrintY(1000));
            Console.WriteLine($"Counter is {counter}");
        }
        static int PrintY(int Max)
        {
            int counter = 0;
            for (int i = 0; i < Max; i++)
            {
                if (i % 2 == 0)
                {
                    counter++;
                }
                Console.Write("Y");
            }
            return counter;
        }


        public async Task<string> InputOutput()
        {
            var msg = "Hello World";
            return msg;
        }
    }
}

#endregion