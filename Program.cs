using System;

namespace ConsoleApp5
{
  
    internal class Program
    {
        //enum Days
        //{
        //    Sunday = 1,
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday
        //}
        static void Main()
        {

            #region part 1
            #region problem1
            // int[] arr1;
            //arr1 = new int[3];
            //arr1[0] = 1; 
            //arr1[1] = 2; 
            //arr1[2] = 3;

            //int[] arr2 = new int[3]{ 1,2,3};


            //int[] arr3 = { 1, 2, 3 };




            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr1[1]);
            //Console.WriteLine(arr1[2]);


            //o Demonstrates an IndexOutOfRangeException. 
            //when we try to print index that not exists in the array like   Console.WriteLine(arr1[3]);

            #endregion
            #region q1
            // Question: What is the default value assigned to array elements in C#? 
            //answer: 0 
            #endregion


            #region problem2
            ////shallow copy
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = { 4,5,6 };
            //arr2 = arr1;
            //arr1[0] = 90;
            //Console.WriteLine(arr2[0]);//90
            //Console.WriteLine(arr1.GetHashCode());//58225482
            //Console.WriteLine(arr1.GetHashCode());//58225482

            // Console.Clear();


            //deep copy
            //int[] arr3 = { 11, 12, 13 };
            //int[] arr4 = { 14, 15, 16 };
            //arr4 = (int[])arr3.Clone();
            //arr3[0] =30;
            //Console.WriteLine(arr4[0]);//11
            //Console.WriteLine(arr3.GetHashCode());//54267293
            //Console.WriteLine(arr4.GetHashCode());//18643596

            #endregion
            #region q2
            //array.clone is a deep copy return a new array with same elements and new address
            //array.copy Copies elements from one array to another existing array.it  is more flixable allows to copy part or all of the array 

            #endregion


            #region problem&q3

            //in day 5 not 4 
            #endregion

            #region problem4
            //int[] arr1 = { 2, 6, 1, 4, 8, 0 };
            //int[] arr2 = { 12, 11, 32 };
            //int[] arr3 = new int[5];
            //Array.Sort(arr1);//0 1 2 4 6 8 
            //Console.WriteLine(arr1[0]);//0
            //Console.WriteLine(arr1[1]);//1
            //Console.WriteLine(arr1[2]);//2


            //Console.WriteLine("------------------------------");


            //Array.Reverse(arr1);//8 6 4 2 1 0
            //Console.WriteLine(arr1[0]);//8
            //Console.WriteLine(arr1[1]);//6
            //Console.WriteLine(arr1[2]);//4


            //Console.WriteLine("------------------------------");


            //Array.Copy(arr1, arr3, 3);// 8 6 4 0 0
            //Console.WriteLine(arr3[0]);//8
            //Console.WriteLine(arr3[1]);//6
            //Console.WriteLine(arr3[2]);//4
            //Console.WriteLine(arr3[3]);//0
            //Console.WriteLine(arr3[4]);//0


            //Console.WriteLine("------------------------------");


            //Array.Clear(arr2,0,2);
            //Console.WriteLine(arr2[0]);//0
            //Console.WriteLine(arr2[1]);//0
            //Console.WriteLine(arr2[2]);//32


            //Console.WriteLine("------------------------------");


            //int index=Array.IndexOf(arr1,8);
            //Console.WriteLine(index);//0 
            #endregion
            #region q4
            /*
                * Question: What is the difference between Array.Copy() and 
                   Array.ConstrainedCopy()?

               array.cope() is no rollback and leave partial data copied if any error occurs 
               array.clone() is roll back and donot copy any data if an error is occured


                */
            #endregion



            #region problem5
            //int[] arr = { 1, 2, 3 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //foreach(int num in arr)
            //{
            //    Console.WriteLine(num);
            //}
            //int index = arr.Length-1;
            //while ( index>=0)
            //{
            //    Console.WriteLine(arr[index]);
            //    index--;
            //}
            #endregion
            #region q5
            /*
                 Question: Why is foreach preferred for read-only operations on arrays? 
               readable and simple in coding
               Prevents Accidental Modification





                */

            #endregion

            #region problem 6
            //int x;
            //do
            //{
            //    Console.WriteLine("enter a positive odd number");
            //    int.TryParse(Console.ReadLine(), out x);


            //}
            //while (x % 2 == 0 || x < 0);

            #endregion
            #region q6
            /*
                  Question: Why is input validation important when working with user inputs? 
                  to prevent errors and protect against security threats


                 */
            #endregion

            #region problem & q7
            //in seccion 5 
            #endregion

            #region problem 8
            //Console.WriteLine("enter a month name");
            //string name=Console.ReadLine();
            //if(name== "January")
            //    Console.WriteLine(1);
            //else if (name== "February")
            //    Console.WriteLine(2);
            //else if (name == "March")
            //    Console.WriteLine(3);
            //else if (name == "April")
            //    Console.WriteLine(4);

            //switch (name)
            //{
            //    case "January":
            //        Console.WriteLine(1);
            //            break;
            //    case "February":
            //        Console.WriteLine(2);
            //        break;
            //    case "March":
            //        Console.WriteLine(3);
            //        break;
            //    case "April":
            //        Console.WriteLine(4);
            //        break;
            //}

            #endregion
            #region q8
            /*
                 Question: When should you prefer a switch statement over if-else? 
                   when you have more conditions in one variable 
                   it is more readablity.

                */
            #endregion

            #region problem9
            //int[] arr = { 10, 20, 30, 20, 40,60,70 };
            ////Array.Sort(arr);//0 2 4 5 8 10
            //Console.WriteLine( Array.IndexOf(arr, 20));
            //Console.WriteLine( Array.LastIndexOf(arr, 20));

            #endregion
            #region q9

            // Question: What is the time complexity of Array.Sort()? 
            //n log n 
            #endregion


            #region problem 10
            //int[] arr = { 1, 2, 3 };
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];            
            //}
            //Console.WriteLine(sum);
            //foreach (int i in arr)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            #endregion
            #region q10
            // For loop is more efficient for calculating the sum of an array because
            //it directly accesses elements by their index, avoiding enumerator overhead.

            #endregion
            #endregion


            #region part2
            //Console.WriteLine("enter a number between 1 and 7");
            //string n =Console.ReadLine();

            //try
            //{
            //    int num = int.Parse(n);
            //    if (num < 1 || num > 7)
            //    {

            //        Console.WriteLine("invalid number");
            //        return;

            //    }
            //    Days day = (Days)Enum.Parse(typeof(Days), num.ToString());
            //    Console.WriteLine($"the day is : {day}");
            //}

            //catch (FormatException)
            //{
            //    Console.WriteLine("invalid num,enter a numeric num");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"error {ex.Message}");
            //} 
            #endregion













        }
    }
}
