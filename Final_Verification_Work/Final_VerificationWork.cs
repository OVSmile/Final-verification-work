// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше или равна 3 символам.
Console.Clear();

string[] Array = {"hello", "2", "world", ":-)"};
PrintArray(Array);
Console.Write("->");
Array = GetModifiedArray(Array);
PrintArray(Array);

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        
        if(i == array.Length - 1)
            Console.Write($"\"{array[i]}\"");
        else 
            Console.Write($"\"{array[i]}\",");
        
    }
    Console.Write("]");
}

string[] GetModifiedArray(string[] arr)
{
    List<string> temp = new List<string>();
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3) 
        {
            temp.Add(arr[i]);   
        }
    }
    arr = temp.ToArray();
    return arr;
}

