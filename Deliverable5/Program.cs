/* Name: Adil Kedir
 * Date: 2/16/2023
 * Description: Console to randomly populate array's with integers and add all elements
 */
using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter a number between 5 and 15: ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput >= 5 && userInput <= 15)
            {
                int[] array = PopualteArray(userInput);

                Console.WriteLine("The elements of the array are: ");
                foreach (int element in array)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();

                int sum = SumArray(array);
                Console.WriteLine("The sum is: " + sum);
            }
            else
            {
                Console.WriteLine("The number you entered isn't between 5 and 15.");
            }
        }
        catch(FormatException)
        {
            Console.WriteLine();
        }
    }
    static int[] PopualteArray(int length)
    {
        int[] array = new int[length];
        Random random= new Random();

        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(10, 50);
        }
        return array;
    }

    static int SumArray(int[] array)
    {
        int sum = 0;

        foreach (int element in array)
        {
            sum += element;
        }
        return sum;
    }
}
