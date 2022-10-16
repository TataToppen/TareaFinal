// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна 3 символа. 
string[] myArray1 = new string[5] {"2", "23", "hello", "world", "text"};
string[] myArray2 = new string[myArray1.Length];
int count = 0;
for (int i = 0; i < myArray1.Length; i++)
    {
        Console.Write($"{myArray1[i]} ");
    }
Console.WriteLine();
for (int i = 0; i < myArray1.Length; i++)
    {
    if(myArray1[i].Length <= 3)
        {
        myArray2[count] = myArray1[i];
        count++;
        }
    Console.Write($"{myArray2[i]} ");
    }
