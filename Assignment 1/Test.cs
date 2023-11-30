
using System;

class Test
{
static bool IsSumOfTwoZero(int []arr)
	{
	  int n = arr.Length;
	int l, r, min_sum, sum, min_l, min_r;
	
	/* Array should have at least two elements*/
	if (n < 2)
	{
		Console.Write("Invalid Input");
		return false;
	}
	
	/* Initialization of values */
	min_l = 0;
	min_r = 1;
	min_sum = arr[0] + arr[1];
	
	for (l = 0; l < n - 1; l++)
	{
		for (r = l+1; r < n; r++)
		{
		if((arr[l] + arr[r]) ==0){
		  return true;
		}
		}
	}
		return false;
	}


 // Prints all triplets in arr[] with 0 sum
    static bool IsSumOfThreeZero(int[] arr)
    {
          int n = arr.Length;
        for (int i = 0; i < n - 2; i++) {
            for (int j = i + 1; j < n - 1; j++) {
                for (int k = j + 1; k < n; k++) {
                    if (arr[i] + arr[j] + arr[k] == 0) {
                        return true;
                    }
                }
            }
        }
 
       		return false;
           
    }
	
	// main function
	public static void Main () 
	{
		int []arr ;
		
		Console.Write("Enter Numbers : ");
		arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '),Convert.ToInt32);

               bool resultOfTwo = IsSumOfTwoZero(arr);
	           bool resultOfThree =  IsSumOfThreeZero(arr);
		
		Console.Write("\nSum of two zero : " + resultOfTwo);
		Console.Write("\nSum of three zero : " + resultOfThree);
	}
	
}


