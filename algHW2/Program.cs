using System;

namespace algHW2
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< Updated upstream
=======
            #region add test
            var testCaseAdd1 = new TestCase(0)
            {
                Value = 135
            };
            var testCaseAdd2 = new TestCase(1)
            {
                Value = 989
            };
            var testCaseAdd3 = new TestCase(2)
            {
                Value = 355
            };

            TestListAdd(testCaseAdd1);
            TestListAdd(testCaseAdd2);
            TestListAdd(testCaseAdd3);
            #endregion
            #region getCount test
            var testGetCount1 = new TestCase(0)
            {
                ExpectedLength = 0
            };
            var testGetCount2 = new TestCase(1)
            {
                ExpectedLength = 1
            };
            var testGetCount3 = new TestCase(2)
            {
                ExpectedLength = 2
            };


            TestListGetCount(testGetCount1);
            TestListGetCount(testGetCount2);
            TestListGetCount(testGetCount3);
            #endregion

            var testArray1 = new int[] {-1,0,1,2,3,4,5,10 };
            var testArray2 = new int[] {};
            var testArray3 = new int[] {0,1,2,3,4,5,6};
            var testArray4 = new int[] { 1, 1, 1, 3, 4, 5, 6, 7 };
            var testArray5 = new int[] { 9, 8, 7, 6, 5, 4,3, 2,1 };

            testBinarySearch(testArray1, 1, 2);
            testBinarySearch(testArray2, 1, -1);
            testBinarySearch(testArray3, 0, 0);
            testBinarySearch(testArray4, 1, 0); //при повторяющихся значениях выдает не первое вхождение искомого значения
            testBinarySearch(testArray5, 1, 8); //при сортировке по убыванию алгоритм не работает, требуется доработка
        }

        static void TestListAdd(TestCase testCase)
        {
            try
            {
                testCase.TestedList.AddNode(testCase.Value);

                if (testCase.TestedList.tail.Value == testCase.Value)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch 
            {

            }
>>>>>>> Stashed changes

        }
        static void TestListGetCount(TestCase testCase)
        {
            try
            {
                if (testCase.TestedList.GetCount() == testCase.ExpectedLength)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch 
            {

            }
        }
        static int BinarySearch(int[] inputArray, int searchValue)
        {
            //Асимптотическая сложность О(n)
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[mid])
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }


        static void testBinarySearch(int[] inputArray, int searchValue, int expectedValue)
        {
            try
            {
                var actual = BinarySearch(inputArray, searchValue);
                if (actual==expectedValue)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch
            {

            }
        }


    }
}
