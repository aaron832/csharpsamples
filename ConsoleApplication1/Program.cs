using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //A Value type
            int xval = 5; 
            //A Reference Type
            object xref = new object();

            //Boxing and unboxing
            object xvalholder = xval; //boxed -- copy created
            xvalholder = 6;
            int xunbox = (int)xvalholder; //unboxed
            Console.WriteLine("xunbox: " + xunbox.ToString() + " xval: " + xval.ToString()); //xunbox: 6  xval: 5

            //Array
            char[] chararray = new char[] { 'a', 'e', 'i', 'o', 'u' };
            //3 dimensional Rectangular Array
            char[,,] rectArray = new char[2,4,5];
            int[,] localArray = { { 1, 2 }, { 3, 4 } };

            //3 dimensional Jagged Array
            char[][][] jagArray = new char [2][][];
            for (int i = 0; i < 2; i++)
            {
                jagArray[i] = new char[4][];
                for (int j = 0; j < 4; j++)
                {
                    jagArray[i][j] = new char[5];
                }
            }
            
            //assignment difference jagged vs rectagular
            rectArray[0, 0, 0] = jagArray[0][0][0] = 'a';

            //automatic bounds checking with catch/try/finally
            try
            {
                localArray[3,5] = 10;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of range! : " + e.ToString());
            }
            catch 
            {
                Console.WriteLine("Something else bad happened!");
            }
            finally { //always run after try, before a goto in a try, after a catch
                Console.WriteLine("Finally.");
            }

            //localArray[3, 5] = 10;  //This blows things up.

            Console.WriteLine("Start of Program!");
            Console.Write("Write something:");
            String enteredLine = Console.ReadLine();
            Console.WriteLine("You wrote: " + enteredLine);
            Console.ReadLine();
        }
    }
}
