using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*checks the number of even and odd numbers in the selected range
*/
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            uint even=0;
            uint odd=0;
    Console.WriteLine("Enter the first number of the range: ");       
    int current = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Enter the last number of the range: ");       
    int limit = int.Parse(Console.ReadLine());  
            
            while (current <= limit )
            {
               if (current % 2==0)
               {
                even++;   
               }
               else
               odd++;
               current ++;
            }
            
 
  Console.WriteLine("Number of even numbers = "+even);
  
  Console.WriteLine("Number of odd numbers = "+odd);
            
        }
    }
}
