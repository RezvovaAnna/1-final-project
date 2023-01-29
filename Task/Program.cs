//Метод чтения данных 
string[] ReadData(string msg)
{
    Console.Write(msg);
    var arr = Console.ReadLine();
    string[] array2 = new string[arr.Length];
    array2 = arr.Split(',');
    //string[] array2 = arr.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries);
    return array2;
} 
// Метод вывода данных
//void PrintData(string msg, string[] result)
//{
//    Console.WriteLine(msg + result);
//}

// Метод создания массива из трехзначных строк
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

string[] Arr = ReadData("Введите массив из символов через запятую: ");
Console.WriteLine(Arr);
//string[] outPutArr = CreateArr(Arr,3);
//Console.WriteLine("Трехзначные символы");
//Console.WriteLine(outPutArr);
//PrintData("Трехзначные символы ", outPutArr);
// Метод генерации массива из строк
