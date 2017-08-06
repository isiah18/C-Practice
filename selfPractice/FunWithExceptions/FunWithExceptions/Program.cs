using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //CauseException();
            //HandleException();
            //HandleSpecificException();
            //DispalyException();
            //ThrowAnException();
            ThrowSpecificExpection();

            Console.ReadLine();
        }

        static void CauseException()
        {
                int x = 5;
                int y = 0;
                Console.WriteLine(x/y);
        }

        static void HandleException()
        {
            try
            {
                int x = 5;
                int y = 0;
                Console.WriteLine(x / y);
            }
            catch
            {
                Console.WriteLine("You fucked up.");
            }
        }

        static void HandleSpecificException()
        {
            try
            {
                int[] myarray = new[] {1, 3, 6, 3, 7};
                myarray[5] = 6;
                myarray[0] = 12;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index Out Of Range Exception was caught.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide by zero exception was caught.");
            }
        }

        static void DispalyException()
        {
            try
            {
                int x = 5;
                int y = 0;
                Console.WriteLine(x/y);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.HelpLink);
            }
            finally
            {
                Console.WriteLine("Finallyyyy");
            }
        }

        static void ThrowAnException()
        {
            try
            {
                Console.WriteLine("Before Exception!\n");
                throw new NullReferenceException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.HelpLink);
            }
            finally
            {
                Console.WriteLine("Finally Block is run!");
            }
        }

        static void ThrowSpecificExpection()
        {
            try
            {
                Console.WriteLine("Before Exception!\n");
                throw new MySpecificException("Something stupid happened");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.HelpLink);
            }
            finally
            {
                Console.WriteLine("Finally Block is run!");
            }
        }
    }
}
