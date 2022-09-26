using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public class ArrayExample
    {
        public static void OneDimentional()
        {
            //One dimentional array
            int[] arr = new int[5];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        /// <summary>
        /// The data is stored in tabular form (row * column) which is also known as matrix.
        /// To create multidimensional array, we need to use comma inside the square brackets. For example
        /// int[,] arr=new int[3,3];//declaration of 2D array  
        /// int[,,] arr = new int[3, 3, 3];//declaration of 3D array  
        /// </summary>
        public static void TwoDimentional()
        {
            //One dimentional array
            int[,] arr = new int[3,3] { { 1,2,3},{4,5,6 },{ 7,8,9} };
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3 ; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// In C#, jagged array is also known as "array of arrays" because its elements are arrays. The element size of jagged array can be different.
        /// int[][] arr = new int[2][];  
        /// arr[0] = new int[4];  
        /// arr[1] = new int[6];  
        /// </summary>
        public static void JaggedArray()
        {
            int[][] arr = new int[2][];// Declare the array  

            arr[0] = new int[] { 11, 21, 56, 78 };// Initialize the array          
            arr[1] = new int[] { 42, 61, 37, 41, 59, 63 };

            // Traverse array elements  
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write(arr[i][j] + " ");
                }
                System.Console.WriteLine();
            }
        }

    }
}
