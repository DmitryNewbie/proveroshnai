using System;

string[] array= {"111","2222","333","44","5" };
var result = new string [array.Length];
int size = 0;
foreach(var count in array)
{
   if(count.Length <=3)
   {
       result[size] = count;
        size++;
   }
}
Console.WriteLine(string.Join(Environment.NewLine,result,0,size));
