using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        public static void printAll(){
            for(int i =1; i<= 255; i++){
                Console.WriteLine(i);
            }
        }
        public static void printOdd(){
            for(int j =0; j <= 255; j++){
                Console.WriteLine(j);
                j= j +2;
            }
        }
        public static void printSum(){
            int sum = 0;
            for(int i =0; i <= 255; i++){
                Console.WriteLine("New Number is:" +i+ "sum:"+ (sum + i));
                sum = i + sum;
            }
        }
        public static void iterArray(){
        int[] throughArray;
            throughArray = new int[] {2,3,5,6,8,9};    
            for(int i =0; i < throughArray.Length ; i++){
                Console.WriteLine("this is the value {0}", throughArray[i]);
            }
        }
        public static void findMax(){
            int [] max;
            max = new int[] {2,90,6,7,9};
            int sum = 0;
            for(int i =0; i<max.Length; i++){
            if(sum < max[i]){
                sum = max[i];
            }
            }
        Console.WriteLine("the max is:"+ sum );
        }
        public static void findAverage(){
            int [] avg;
            avg = new int[] {2,1,6,7,2};
            int sum = 0;
            for(int i =0; i<avg.Length; i++){
                sum = sum + avg[i];
            }
        Console.WriteLine("the avg is:"+ (sum/avg.Length));
        }

         public static int[] OddArray() {
            List<int> oddA = new List<int>();
            for(int val = 1; val < 256; val++) {
                if(val % 2 == 1) {
                    oddA.Add(val);
                }
            }
            return oddA.ToArray();
        }
         public static void GreaterY(int y) {
             int[] arr;
             arr = new int []{2,4,6,8,4,6,1};
            int count = 0;
            // int y = 0;
            foreach(int val in arr){
                if(val > y) {
                    count++;
                }
            }
            Console.WriteLine($"There are {count} values greater than {y}");
        }

        public static void squareValues() {
            int[] arr;
            arr = new int[]{2,5};
            for(int i = 0; i < arr.Length; i++) {
                arr[i] *= arr[i];
                Console.WriteLine("the square val is:" + arr[i]);
            }
        }

        //Elimate Negative Numbers in an array
        public static void replaceNegatives() {
            int[] arr;
            arr = new int[] {1, -5, 10, 2};
            for(int i = 0; i < arr.Length; i++) {
                if(arr[i] < 0) {    
                    Console.WriteLine(arr[i] +"has been removed");
                    arr[i] = 0;
                }
                    Console.WriteLine(arr[i]);
            }
        }

       //Retrieve the min, max, and average values from an array
        public static void MinMaxAvg(int[] arr) {
            int sum = 0;
            int min = arr[0];
            int max = arr[0];
            foreach(int val in arr) {
                sum += val;
                if(val < min) {
                    min = val;
                }
                if(val > max) {
                    max = val;
                }
            }
            Console.WriteLine("The max of the array is {0}, the min is {1}, and the average is {2}", max, min, (double)sum/(double)arr.Length);
        }

       //Shift an array to the front by one number and add 0 to the end
        public static void ShiftLeft(int[] arr) {
            for(int idx = 0; idx < arr.Length - 1; idx++){
                arr[idx] = arr[idx + 1];
            }
            arr[arr.Length - 1] = 0;
        }

       //replace negatives with "dojo"
        public static object[] ReplaceNumberWithString(object[] arr) {
            for(int idx = 0; idx < arr.Length; idx++) {
                if((int)arr[idx] < 0) {
                    arr[idx] = "Dojo";
                }
            }
            return arr;
        }

        static void Main(string[] args)
        {
            printAll();
            printOdd();
            printSum();
            iterArray();
            findMax();
            findAverage();
            GreaterY(4);
            squareValues();
            replaceNegatives();
        }
    }
}
