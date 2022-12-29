//количество нужных строк в массиве
int NumRightStrings(string[] array, int leght)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if ( array[i].Length<leght ) result++;
    }
    return result;
}
//запись нового массива из подходящих строк
string[] RecordRightStrings (string[] array , int count, int leght)
{
    int index = 0;
    string[] result = new string[count];
    for (int i = 0; i < count; i++)
    {
        if (array[i].Length< leght) 
        {
            result[index] = array[i];
            index++;
        }
    }
    return result;
}