using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLength;
            int inputWidth;
            Rectangle rectangle;
            Console.WriteLine("***********Welcome to Rectangle Program************");
            string lengthInput = null;
            string widthInput = null;
            int updatedLength;
            int updatedWidth;
            int userMenuSelection;
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Please enter the Length");
                    lengthInput = Console.ReadLine();
                    Console.WriteLine("Please enter the Width");
                    widthInput = Console.ReadLine();
                } while (!(int.TryParse(lengthInput, out inputLength) && int.TryParse(widthInput, out inputWidth) && inputWidth > 1 && inputLength > 0));
           
            rectangle = new Rectangle(inputLength, inputWidth);          
            do
            {
                Console.WriteLine("\n\nPlease select the number choice given for the below menu options\n\n1. GetLength\n2. SetLength\n3. GetWidth\n4. SetWidth\n5. GetPerimeter\n6. GetArea\n7. Exit");
                bool userSelection = int.TryParse(Console.ReadLine(), out userMenuSelection);
                if (userSelection)
                {
                    Console.Clear();
                    switch (userMenuSelection)
                    {
                        case 1:
                            Console.WriteLine($"Rectangle's length is {rectangle.GetLength()}");
                            break;
                        case 2:
                            Console.WriteLine("Please enter the Length of the rectangle");
                            int.TryParse(Console.ReadLine(), out updatedLength);
                            if (updatedLength > 0)
                            {
                                Console.WriteLine($"You have updated the length and rectangle's new length is {rectangle.SetLength(updatedLength)}");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter positive length");
                                break;
                            }
                        case 3:
                            Console.WriteLine($"Rectangle's width is {rectangle.GetWidth()}");
                            break;
                        case 4:
                            Console.WriteLine("Please enter the Width of the rectangle");
                            int.TryParse(Console.ReadLine(), out updatedWidth);
                            if (updatedWidth > 0)
                            {
                                Console.WriteLine($"You have updated the width and rectangle's new width is {rectangle.SetWidth(updatedWidth)}");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter positive width");
                                break;
                            }                          
                        case 5:
                            Console.WriteLine($"Rectangle's perimeter is {rectangle.GetPerimeter()}");
                            break;
                        case 6:
                            Console.WriteLine($"Area of the rectangle is {rectangle.GetArea()}");
                            break;
                        case 7:
                            System.Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Please enter the right input from the menu");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter only numerics");

                }

            } while (!(userMenuSelection == 7));

            }
            catch (Exception)
            {
                Console.WriteLine("Some error occured while entering and processing the rectangle details. Please close the application and try again.");                
            }
            Console.ReadKey();
        }
       
    }
}
