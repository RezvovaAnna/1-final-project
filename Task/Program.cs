﻿string[] inPutArray = new string[4] {"hello", "2", "world", ":-)"};

string[] CreateArr(string[] array, int size)
{
    int j = 0; 
   string[] outArr = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
   
        if (array[i].Length < size+1)
        {
            outArr[j] = array[i];
            j++;
       }
      

    return outArr;
}

void PrintArray(string[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
   Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] outPutArray = CreateArr(inPutArray,3);
PrintArray(outPutArray);