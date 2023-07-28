string[] arr = { "qwerty", "q1we", "asdf" };
string[] answer = { };

string[] createArray(string[] inputArr)
{
    string[] outputArray = { };
    for (int i = 0; i < inputArr.Length; i++)
    {
        if (inputArr[i].Length <= 3)
        {
            Array.Resize(ref outputArray, outputArray.Length + 1);
            outputArray[outputArray.Length - 1] = inputArr[i];
        }
    }
    return outputArray;
}

void printArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}


answer = createArray(arr);
if (answer.Length > 0)
{
    printArray(answer);
}
else
{
    System.Console.WriteLine(" Массив пустой!");
}