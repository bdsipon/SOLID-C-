using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicToAdvance
{
    class Exception1
    {
        public void Exce()
        {
            try
            {
                string input = Console.ReadLine();
                int convertedNumber;
                bool isConvertedSucccessfully = int.TryParse(input, out convertedNumber);

                if (!isConvertedSucccessfully)
                {
                    throw new System.Exception("Converstion was not successful.");

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ther was an error:{0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("The Rest of my application is running");
            }
           
        }
       
    }
}
