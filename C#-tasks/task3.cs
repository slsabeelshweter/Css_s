using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("1 - Task 1: 3x3 Array (User Input & Print)");
        Console.WriteLine("2 - Task 2: 4x4 Array (Row & Column Sum)");
        Console.WriteLine("3 - Task 3: 5x5 Random Array (Max Row & Min Column)");
        Console.WriteLine("4 - Task 4: Jagged Array (Fixed Rows)");
        Console.WriteLine("5 - Task 5: Jagged Array (User Defined Size)");
        Console.WriteLine("6 - Task 6: Jagged Array (Random & Row Sum)");
        Console.WriteLine("7 - Task 7: List<int> (User Input)");
        Console.WriteLine("8 - Task 8: List<string> (Sort Names)");
        Console.WriteLine("9 - Task 9: List<int> (Until -1, Stats & Sort)");
        Console.WriteLine("\nChoose Task : ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: // Task 1
                int[,] arr3 = new int[3, 3];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"Enter number [{i},{j}]: ");
                        arr3[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("Array:");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                        Console.Write(arr3[i, j] + " ");
                    Console.WriteLine();
                }
                break;

            case 2: // Task 2
                int[,] arr4 =
                {
                    {1,2,3,4},
                    {5,6,7,8},
                    {9,10,11,12},
                    {13,14,15,16}
                };

                for (int i = 0; i < 4; i++)
                {
                    int rSum = 0, cSum = 0;
                    for (int j = 0; j < 4; j++)
                    {
                        rSum += arr4[i, j];
                        cSum += arr4[j, i];
                    }
                    Console.WriteLine($"Row {i} Sum = {rSum}, Column {i} Sum = {cSum}");
                }
                break;


            case 3: // Task 3
                int[,] arr5 = new int[5, 5];
                Random rand = new Random();

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        arr5[i, j] = rand.Next(1, 51);
                        Console.Write(arr5[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < 5; i++)
                {
                    int max = arr5[i, 0];
                    for (int j = 1; j < 5; j++)
                        if (arr5[i, j] > max) max = arr5[i, j];
                    Console.WriteLine($"Max in row {i}: {max}");
                }

                for (int j = 0; j < 5; j++)
                {
                    int min = arr5[0, j];
                    for (int i = 1; i < 5; i++)
                        if (arr5[i, j] < min) min = arr5[i, j];
                    Console.WriteLine($"Min in column {j}: {min}");
                }
                break;


            case 4: // Task 4
                int[][] jag = new int[3][];
                jag[0] = new int[2];
                jag[1] = new int[3];
                jag[2] = new int[4];

                for (int i = 0; i < jag.Length; i++)
                    for (int j = 0; j < jag[i].Length; j++)
                    {
                        Console.Write($"Enter value row {i} col {j}: ");
                        jag[i][j] = int.Parse(Console.ReadLine());
                    }

                for (int i = 0; i < jag.Length; i++)
                {
                    for (int j = 0; j < jag[i].Length; j++)
                        Console.Write(jag[i][j] + " ");
                    Console.WriteLine();
                }
                break;


            case 5: // Task 5
                Console.Write("Enter number of rows: ");
                int rows = int.Parse(Console.ReadLine());
                int[][] jag2 = new int[rows][];

                for (int i = 0; i < rows; i++)
                {
                    Console.Write($"Enter length of row {i}: ");
                    int len = int.Parse(Console.ReadLine());
                    jag2[i] = new int[len];

                    for (int j = 0; j < len; j++)
                    {
                        Console.Write("Enter value: ");
                        jag2[i][j] = int.Parse(Console.ReadLine());
                    }
                }

                for (int i = 0; i < jag2.Length; i++)
                {
                    for (int j = 0; j < jag2[i].Length; j++)
                        Console.Write(jag2[i][j] + " ");
                    Console.WriteLine();
                }
                break;


            case 6: // Task 6
                Random r = new Random();
                int[][] jag3 = new int[5][];

                for (int i = 0; i < 5; i++)
                {
                    jag3[i] = new int[i + 1];
                    int sum = 0;

                    for (int j = 0; j < jag3[i].Length; j++)
                    {
                        jag3[i][j] = r.Next(1, 101);
                        sum += jag3[i][j];
                        Console.Write(jag3[i][j] + " ");
                    }
                    Console.WriteLine($"Sum = {sum}");
                }
                break;


            case 7: // Task 7
                List<int> numbers = new List<int>();
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Enter number: ");
                    numbers.Add(int.Parse(Console.ReadLine()));
                }

                foreach (int n in numbers)
                    Console.WriteLine(n);
                break;

          

            case 8: // Task 8
                List<string> names = new List<string>
                { "farah", "noor", "slsabeel", "dina", "alaa" };

                names.Sort();
                foreach (string name in names)
                    Console.WriteLine(name);
                break;


            case 9: // Task 9
                List<int> nums = new List<int>();

                while (true)
                {
                    Console.Write("Enter number : ");
                    int input = int.Parse(Console.ReadLine());
                    if (input == -1) break;
                    nums.Add(input);
                }

                int sumNums = 0, maxNum = nums[0], minNum = nums[0];
                foreach (int n in nums)
                {
                    sumNums += n;
                    if (n > maxNum) maxNum = n;
                    if (n < minNum) minNum = n;
                }

                Console.WriteLine($"Average = {(double)sumNums / nums.Count}");
                Console.WriteLine($"Max = {maxNum}, Min = {minNum}");

                nums.Sort();
                foreach (int n in nums)
                    Console.Write(n + " ");
                break;


            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}

