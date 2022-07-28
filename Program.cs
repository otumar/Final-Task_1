void ReducedArray (string [] array1, string [] array2, int MaxLenght)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= MaxLenght)
        {
            array2 [count] = array1[i];
            count++;
        }
    }
}

void PrintArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($" {array [i]} ");
    }
System.Console.WriteLine();
}

string [] array1  = new string [] {"one", "two", "three",  "four"};
string [] array2 = new string [array1.Length];
int MaxLenght = 3;
ReducedArray (array1, array2, MaxLenght);
PrintArray (array2);