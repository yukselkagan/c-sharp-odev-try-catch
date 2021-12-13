using System;

namespace c_sharp_odev_try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number");
                int num1 = Convert.ToInt32( Console.ReadLine() );
                Console.WriteLine("Number: " + num1);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                
                
            }
            finally{
                Console.WriteLine("Process completed");
            }





            try
            {
                string v_str0 = null;
                string v_str1 = "test";
                string v_str2 = "100000000000000000000";

                int num2 = int.Parse(v_str0);

            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Null value");
                Console.WriteLine(e);                
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error");
                Console.WriteLine(e);
            }
            catch(OverflowException e)
            {
                Console.WriteLine("Overflow error");
                Console.WriteLine(e);
            }
            finally{
                Console.WriteLine("Process completed-2");
            }






        }
    }
}
