//using System;

//class Program
//{
//    static void Main()
//    {
//        #region Problem 1 - 1D Array Initialization
//        int[] arr1 = new int[3];
//        arr1[0] = 10; arr1[1] = 20; arr1[2] = 30;

//        int[] arr2 = new int[] { 1, 2, 3 };
//        int[] arr3 = { 5, 6, 7 };

//        foreach (int x in arr1) Console.WriteLine(x);
//        foreach (int x in arr2) Console.WriteLine(x);
//        foreach (int x in arr3) Console.WriteLine(x);

        
//        #endregion


//        #region Problem 2 - Shallow vs Deep Copy
//        int[] a1 = { 1, 2, 3 };

//        int[] a2 = a1;          
//        a2[0] = 99;

//        int[] a3 = (int[])a1.Clone(); 
//        a3[1] = 88;
//        #endregion


//        #region Problem 3 - 2D Array Student Grades
//        int[,] grades = new int[3, 3];

//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 3; j++)
//            {
//                Console.Write($"Student {i + 1}, Subject {j + 1}: ");
//                grades[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        for (int i = 0; i < 3; i++)
//        {
//            Console.Write($"Student {i + 1}: ");
//            for (int j = 0; j < 3; j++)
//                Console.Write(grades[i, j] + " ");
//            Console.WriteLine();
//        }
//        #endregion


//        #region Problem 4 - Array Methods
//        int[] nums = { 5, 2, 9, 1 };

//        Array.Sort(nums);
//        Array.Reverse(nums);
//        int index = Array.IndexOf(nums, 2);

//        int[] copy = new int[nums.Length];
//        Array.Copy(nums, copy, nums.Length);

//        Array.Clear(nums, 0, nums.Length);
//        #endregion


//        #region Problem 5 - Loops
//        int[] loopArr = { 1, 2, 3, 4 };

//        for (int i = 0; i < loopArr.Length; i++)
//            Console.WriteLine(loopArr[i]);

//        foreach (int x in loopArr)
//            Console.WriteLine(x);

//        int k = loopArr.Length - 1;
//        while (k >= 0)
//        {
//            Console.WriteLine(loopArr[k]);
//            k--;
//        }
//        #endregion


//        #region Problem 6 - Defensive Coding
//        int number;
//        do
//        {
//            Console.Write("Enter positive odd number: ");
//        }
//        while (!int.TryParse(Console.ReadLine(), out number) || number <= 0 || number % 2 == 0);
//        #endregion


//        #region Problem 7 - Fixed 2D Array
//        int[,] matrix =
//        {
//            {1,2,3},
//            {4,5,6},
//            {7,8,9}
//        };

//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//                Console.Write(matrix[i, j] + "\t");
//            Console.WriteLine();
//        }
//        #endregion


//        #region Problem 8 - Month Name
//        int month = int.Parse(Console.ReadLine());

//        if (month == 1) Console.WriteLine("January");
//        else if (month == 2) Console.WriteLine("February");
//        else Console.WriteLine("Invalid");

//        switch (month)
//        {
//            case 1: Console.WriteLine("January"); break;
//            case 2: Console.WriteLine("February"); break;
//            default: Console.WriteLine("Invalid"); break;
//        }
//        #endregion


//        #region Problem 9 - Sort & Search
//        int[] searchArr = { 4, 1, 7, 1 };
//        Array.Sort(searchArr);
//        Console.WriteLine(Array.IndexOf(searchArr, 1));
//        Console.WriteLine(Array.LastIndexOf(searchArr, 1));
//        #endregion


//        #region Problem 10 - Sum
//        int sum1 = 0, sum2 = 0;

//        for (int i = 0; i < searchArr.Length; i++)
//            sum1 += searchArr[i];

//        foreach (int x in searchArr)
//            sum2 += x;

//        Console.WriteLine(sum1);
//        Console.WriteLine(sum2);
//        #endregion
//    }
//}
