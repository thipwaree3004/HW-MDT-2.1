using System;

class Program
{
    static void Main()
    {
        int rowNumber;
        do
        {
            Console.Write("Enter the row number of Pascal's Triangle: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out rowNumber) || rowNumber < 0)
            {
                Console.WriteLine("Invalid Pascal's triangle row number.");
                continue;
            }

            // แสดงผลรูปสามเหลี่ยมปาสคาล
            Console.WriteLine("Pascal's Triangle:");
            for (int i = 0; i <= rowNumber; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(CalculatePascalValue(i, j) + " ");
                }
                Console.WriteLine();
            }

            break;
        } while (true);
    }

    static int CalculatePascalValue(int row, int column)
    {
        if (column == 0 || column == row)
        {
            return 1;
        }
        else
        {
            return CalculatePascalValue(row - 1, column - 1) + CalculatePascalValue(row - 1, column);
        }
    }
}
