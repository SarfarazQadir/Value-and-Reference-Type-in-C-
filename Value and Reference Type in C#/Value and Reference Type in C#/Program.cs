using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_and_Reference_Type_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student myobj = new Student();
            /*   int num = 10;
               Console.WriteLine(myobj.Calculate_value(num));
               Console.WriteLine("The actual value of num is :" + num);*/
            int num = 35;

            Console.WriteLine("The calculated value is :" + myobj.Calculate_value_byref(ref num));
            Console.WriteLine("The Actual value of num is " + num);

            /*   Stack<string> mylist = new Stack<string>();
               mylist.Push("Html");
               mylist.Push("Php");
               mylist.Push("Css");
               mylist.Push("Laravel");
               mylist.Push("C#");
               mylist.Push("Angular");

               foreach (var data in mylist)
               {
                   Console.WriteLine(data);
               }

               Console.WriteLine("Peek Value :" + mylist.Peek());
               Console.WriteLine("Delete Value :" + mylist.Pop());
               Console.WriteLine("Peek Value :" + mylist.Peek());
               Console.WriteLine("Delete Value :" + mylist.Pop());
               Console.WriteLine("Peek Value :" + mylist.Peek());*/

            /* 
              Queue<string> mylist = new Queue<string>();
              mylist.Enqueue("Html");
              mylist.Enqueue("Css");
              mylist.Enqueue("Bootstrap");
              mylist.Enqueue("Javascript");
              mylist.Enqueue("C");
              mylist.Enqueue("C++");

              foreach (var item in mylist)

              {
                  Console.WriteLine(item);
              }
              Console.WriteLine("Peek Value :" + mylist.Peek());
              Console.WriteLine("Delete Value :" + mylist.Dequeue());
              Console.WriteLine("Peek Value :" + mylist.Peek());*/

            Console.ReadKey();

        }
    }
}
