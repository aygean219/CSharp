using System;
//Muta elementul de pe indeul dat pe prima pozitie si verifica la final daca sunt ordonate crescator
namespace MoveFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = ReadValuesList();
            int[] positionsToMove = ReadPositions();

            for (int i = 0; i < positionsToMove.Length; i++)
                MoveFirst(values, positionsToMove[i]);

            PrintValuesList(values);
            Console.WriteLine(CheckIfSortedAscending(values));
            Console.Read();
        }

        static bool CheckIfSortedAscending(int[] values)
        {
            
            for(int i=0;i<values.Length;i++)
            {
                if ((i + 1 < values.Length))
                {
                    if ((values[i] > values[i + 1]))
                    {
                        return false;
                    }
                }
            }
            return true;
            
        }

        static void MoveFirst(int[] values, int index)
        {
            int val = values[index];
            for(int i= index; i>=1;i--)
            {
                values[i] = values[i - 1];
            }
            values[0] = val;
        }

        static int[] ReadPositions()
        {
            int positionsNumber = Convert.ToInt32(Console.ReadLine());
            int[] positions = new int[positionsNumber];

            for (int i = 0; i < positionsNumber; i++)
                positions[i] = Convert.ToInt32(Console.ReadLine());

            return positions;
        }

        static int[] ReadValuesList()
        {
            string[] inputValues = Console.ReadLine().Split(' ');
            int[] values = new int[inputValues.Length];

            for (int i = 0; i < values.Length; i++)
                values[i] = Convert.ToInt32(inputValues[i]);

            return values;
        }

        static void PrintValuesList(int[] valuesList)
        {
            for (int i = 0; i < valuesList.Length; i++)
                Console.Write(valuesList[i] + " ");
            Console.Write('\n');
        }

    }
}
