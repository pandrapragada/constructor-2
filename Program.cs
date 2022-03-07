using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//public class Constructor
//{
//    public int num = 10;
//    public static void Main()
//    {
//        Constructor obj1 = new Constructor();
//        Constructor obj2 = new Constructor();
//        Constructor obj3 = new Constructor();
//        Console.WriteLine("obj1.num = " + obj1.num + "\nobj2.num = " + obj2.num
//        + "\nobj3.num = " + obj3.num);
//        Console.ReadLine();
//    }
//}
//copy constructor
//class copyDemo
//{
//   int x;
//   public copyDemo(int i)
//   {
//       x = i;
//   }
//   public copyDemo(copyDemo obj)
//   {
//       x = obj.x;
//   }
//   public void display()
//   {
//       Console.WriteLine("display the value of x:" + x);
//   }
//   static void Main()
//   {
//       copyDemo cd1 = new copyDemo(10);
//       cd1.display();
//       copyDemo cd2 = new copyDemo(cd1);
//       cd2.display();
//       Console.ReadLine();
//   }


//static constructor
public class bank
{
    static readonly int id = 101;

    static bank()
    {
        id = 101;
        Console.WriteLine("employee :"+id);
    }
    public static void Main (String[]args)
   
    {
        bank id = new bank();
      
        Console.ReadLine();
    }


}

