using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Code.Exceptions
{
    public class Exceptions
    {
        [Test]
        public void ExistingException()
        {
            try
            {
                //int a = 20, b=0;
                //int result = a / b; // arithmetic exception

                int[] arr = { 1, 2, 3, 4, 5 };
                for (int i=0; i<6; i++) // index out of range exception
                    Console.Write(arr[i] + " ");
            }
            catch(ArithmeticException e1)
            {
                Console.WriteLine(e1.Message);
                Console.WriteLine("Arithmetic exception handled");
            }
            catch (IndexOutOfRangeException e2)
            {
                Console.WriteLine(e2.Message);
                Console.WriteLine("Index out of range exception handled");
            }
            finally // executes irrespective try and catch
            {
                Console.WriteLine("All done!!");
            }
        }

        [Test]
        public void CustomException()
        {
            try
            {
                int mark = 102;
                if (mark > 100) // mark out of bound exception
                {
                    throw new Exception("Mark went out of bound");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Mark out of bound exception handled");
            }
            finally
            {
                Console.WriteLine("All good now buddy!");
            }
        }
    }
}
