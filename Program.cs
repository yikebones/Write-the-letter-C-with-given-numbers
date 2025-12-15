using System;
using System.Collections.Generic;

class Program
{

    static void Main()
    {
        List<int> arr = new List<int>(); // declare array
        bool run = true;
        do{
            Console.Clear();
            Console.Write("Enter an INTEGER value to add to the array, type `done` if youre done: ");
            string s = Console.ReadLine().ToLower();
            
            if(s == "done") {
                run = false;
            } else {
                arr.Add(int.Parse(s)); // convert input to integer and add it to the end of our array
            }
        }while(run);



        for(int i=0; i<arr.Count; i++){
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();

        for(int j=1; j<arr.Count; j++) {
            if(j+1 == arr.Count)
            {
                // if last element
                Console.Write(arr[j] + " ");   
            } else {
                Console.WriteLine(arr[j]);
            }
            
        }

        for(int j = arr.Count - 2; j >= 0; j--) {
            Console.Write(arr[j] + " ");
        }
        
    }


}