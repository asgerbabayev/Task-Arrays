using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 6 elementli integer arrayi yaradılsın ve sort edilsin.
            //int[] numbArray = new int[6];
            //int smallIndex;
            //Console.WriteLine("Deyerleri daxil edin.");
            //for (int i = 0; i < numbArray.Length; i++)
            //{
            //    numbArray[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < numbArray.Length; i++)
            //{
            //    smallIndex = i;
            //    for (int j = i; j < numbArray.Length; j++)
            //    {
            //        if (numbArray[j] < numbArray[smallIndex])
            //        {
            //            smallIndex = j;
            //        }
            //    }

            //    int temp = numbArray[i];
            //    numbArray[i] = numbArray[smallIndex];
            //    numbArray[smallIndex] = temp;
            //}
            //foreach (var item in numbArray)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion

            #region 1-dən 20-ə kimi  ədədlərin kvadları cəmi ekrana yazdırılsın.
            //for (int i = 1; i < 20; i++)
            //{
            //    int a = Convert.ToInt32(Math.Pow(i, 2));
            //    Console.WriteLine(a + a);
            //}
            #endregion

            #region Foreach istifadə edərək string arrayi ekrana yazdırılsın.
            //string[] textArray = { "Matrix", "Training", "Center" };
            //foreach (var text in textArray)
            //{
            //    Console.Write(text + " ");
            //}
            #endregion

            #region 0-la 200 arasında ədəd generasiya olunsun
            //Random rd = new Random();
            //Console.WriteLine("Enter the number");
            //int userInput = Convert.ToInt32(Console.ReadLine());
            //int rdNumber = 0;
            //int sum = 0;
            //for (int i = 0; i < userInput; i++)
            //{
            //    rdNumber = rd.Next(0, 200);
            //    Console.WriteLine($"Number {i+1} = {rdNumber}");
            //    sum += rdNumber;

            //}
            //Console.WriteLine($"Sum = {sum}");

            #endregion

            #region 10 elementli array yaradılsın.
            //int[] numbArray = new int[10] { 10, 15, 24, 35, 74, 15, 2, 45, 22, 36 };
            //Console.WriteLine(numbArray.Min());
            #endregion

            #region Number dəyər daxil edilsin. Daxil edilmiş number olan int tipli array yaradılsın
            //Console.Write("Enter the array size = ");
            //int userInput = Convert.ToInt32(Console.ReadLine());
            //int[] numbArray = new int[userInput];
            //for (int i = 0; i < numbArray.Length; i++)
            //{
            //    Console.Write("Enter number = ");
            //    numbArray[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.Write($"The max element of the array = {numbArray.Max()}");
            #endregion

            #region 2 ölçülü array
            //int rdNumber = 0;
            //int sum = 0;
            //Console.Write("Enter the row number = ");
            //int arrRow = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the column number = ");
            //int arrColumn = Convert.ToInt32(Console.ReadLine());
            //int[,] numbArray = new int[arrRow, arrColumn];
            //Random rnd = new Random();
            //for (int i = 0; i < arrRow; i++)
            //{
            //    for (int j = 0; j < arrColumn; j++)
            //    {
            //        numbArray[i, j] = rnd.Next(0, 100);
            //        rdNumber = numbArray[i, j];
            //        Console.Write(numbArray[i, j] + " ");
            //        sum += rdNumber;
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine(sum);
            #endregion

            #region 2misli ilə əvəz edilərək ekrana yazdırılsın
            //Console.Write("Enter the size of the array = ");
            //int userInput = Convert.ToInt32(Console.ReadLine());
            //int[] numbArray = new int[userInput];
            //for (int i = 0; i < numbArray.Length; i++)
            //{
            //    Console.Write("Enter the number = ");
            //    numbArray[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //foreach (var multiply in numbArray)
            //{
            //    Console.WriteLine(multiply * 2);
            //}
            #endregion

            #region arrayin tək elementləri ekrana yazdırılsın.
            //Console.Write("Enter the size of the array = ");
            //int userInput = Convert.ToInt32(Console.ReadLine());
            //int[] numbArray = new int[userInput];
            //for (int i = 0; i < numbArray.Length; i++)
            //{
            //    Console.Write("Enter the number = ");
            //    numbArray[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //foreach (var singleNum in numbArray)
            //{
            //    if (singleNum % 2 != 0)
            //    {
            //        Console.WriteLine(singleNum);
            //    }
            //}
            #endregion
            Console.ReadKey();
        }
    }
}
