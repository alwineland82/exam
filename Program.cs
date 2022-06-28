using System;

class Program 
{
  static void Main() 
  {
    string[] x = {"sdd", "sdsfs", "rty", "sdgsg"};
    
    string[] array = Filter3(x);
    foreach(var i in array)
    {
      Console.WriteLine(i);
    }
  }
  static string[] Filter3(string[] array)
  {
    int counter = 0;
    foreach(var i in array)
    {
      if(i.Length <= 3) counter++;
    }
    string[] result = new string[counter];
    foreach(var i in array)
    {
      if(i.Length <= 3) 
      {
        result[counter-1] = i;
        counter--;
      }
    }
    return result;
  }
}
