using Arrray.Generic;

var arr = Array.CreateInstance(typeof(int), 4);
arr.SetValue(23, 0);
arr.SetValue(24, 1);
arr.SetValue(25, 2);
arr.SetValue(26, 3);



//Console.WriteLine(arr.GetValue(0));

var _arr = new DataStructures.Arrray.Array(1, 2, 3);
foreach (var item in _arr)
{
    Console.WriteLine(item);
}