using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightAngleTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string asterisk = "";
            int choice = 0;

            Console.WriteLine("Veuillez insérer un entier");
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                while(choice == 0)
                {
                    try
                    {
                        Console.WriteLine(e.Message + " Veuillez recommencer");
                        choice = Convert.ToInt32(Console.ReadLine());
                    }
                    catch(Exception ex)
                    {

                    }
                    finally
                    {

                    }
                }
            }

            Console.WriteLine();
            for(int i = 1; i <= choice; i++)
            {
                asterisk += "*";
                Console.WriteLine(asterisk);
            }

            Console.ReadLine();
        }
    }
}
