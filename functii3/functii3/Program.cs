using System;
/*
 * Se dă un text pe o linie urmat de N operații de inversare de caractere, fiecare pe câte o linie, 
 * în următorul format: index1, un spațiu, index2.
 * Fiecare operație de inversare aplicată pe textul 
 * primit înseamnă inversarea între ele a caracterelor de la index1 și index2.
 * Să se tipărească la consolă textul modificat după ce s-au aplicat toate operațiile de inversare de caractere.*/
namespace StringSwaps
{
    class Program
    {
        static void Main(string[] args)
        {
            string initialText = Console.ReadLine();
            ReadSwaps(out int[] firstIndex, out int[] secondIndex);

            string updatedText = initialText;

            for (int i = 0; i < firstIndex.Length; i++)
                updatedText = ApplySwap(updatedText, firstIndex[i], secondIndex[i]);

            Console.WriteLine(updatedText);
            Console.Read();
        }

        static string ApplySwap(string text, int firstIndex, int secondIndex)
        {
            char[] arr = text.ToCharArray();
            char temp = arr[firstIndex];
            arr[firstIndex] = arr[secondIndex];
            arr[secondIndex] = temp;
            string s = new string(arr);
            return s;
        }

        static void ReadSwaps(out int[] firstIndex, out int[] secondIndex)
        {
            int swapsNumber = Convert.ToInt32(Console.ReadLine());
            firstIndex = new int[swapsNumber];
            secondIndex = new int[swapsNumber];

            for (int i = 0; i < swapsNumber; i++)
            {
                string[] swapInfo = Console.ReadLine().Split(' ');
                firstIndex[i] = Convert.ToInt32(swapInfo[0]);
                secondIndex[i] = Convert.ToInt32(swapInfo[1]);
            }
        }

    }
}
