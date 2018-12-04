using System;
namespace New
{
  class Program 
    {
      static void Main(string[] args)
       {
          var obj=new Calcule();
          int a,b;
          char s;
          Console.WriteLine("start your operation by pressing enter after each entry");
          Console.WriteLine("use + to add;- to substact;* to multiply;/ to divide;# to average");
          Console.Write(":");
          Console.Write("     "); Console.Write("     ");
          a=int.Parse(Console.ReadLine());
          Console.Write(" "); 
          s=char.Parse(Console.ReadLine());
          Console.Write("      ");
          b=int.Parse(Console.ReadLine());
          Console.Write("--------");
          Console.WriteLine(" ");
          Console.Write(" = ");
          Console.Write("  ");
          if(s=='+')
          Console.WriteLine(obj.Sum(a,b));
          else if(s=='-')
          Console.WriteLine(obj.Diff(a,b));
          else if(s=='*')
          Console.WriteLine(obj.Prod(a,b));
          else if(s=='/')
          Console.WriteLine(obj.Quot(a,b));
          else if(s=='#')
          Console.WriteLine(obj.Avg(a,b));
          else
          Console.Write("invalid input(s)");
          Console.WriteLine();
          Console.Write("type dotnet run for another operation.");
        }
    }
}    
