using System;
using System.Collections.Generic; // List<> data type comes from here
using System.Linq;
using System.Text;
using System.Threading; // Thread class comes from here
using System.IO;

    class Calculator{
 

     public static void Menu(){
       Console.Clear();
       Console.WriteLine("Which action do you want to do");
       Console.WriteLine("1. Currency Converter");
       Console.WriteLine("2. Square Root");
       Console.WriteLine("3. Scientific");
        
        
         string answer_calc = Console.ReadLine();
         if (answer_calc == "1"){
           converter();
         }
         if (answer_calc == "2"){
           Squareroot();

         }
         if (answer_calc == "3"){
           Scientific_calc();
           
         }
     }
     

    public static void Scientific_calc(){
       string answer;
       double a;
       double b;
       Console.WriteLine("Please Select Operation\n 1. Division\n 2. Mulplication\n 3. Addition\n 4. Subtraction");
       answer = Console.ReadLine();
      if (answer == "1"){
         Console.WriteLine("Enter 1st Value");
         a = Double.Parse(Console.ReadLine());
         Console.WriteLine("Enter 2nd Value");
         b = Double.Parse(Console.ReadLine());
        if (a == 0 || b == 0){
          Console.WriteLine("Division By Zero is not possible");
           Console.Read();
        }
        Console.WriteLine(a / b);
         Console.Read();
      }
      else if (answer == "2"){
        Console.WriteLine("Enter 1st Value");
        a = Double.Parse(Console.ReadLine());
        Console.WriteLine("Enter 2nd Value");
        b = Double.Parse(Console.ReadLine());
        Console.WriteLine(a * b);
         Console.Read();
      }
      else if(answer=="3"){
        Console.WriteLine("Enter 1st Value");
        a = Double.Parse(Console.ReadLine());
        Console.WriteLine("Enter 2nd Value");
        b = Double.Parse(Console.ReadLine());
        Console.WriteLine(a + b);
         Console.Read();
      }
      else if (answer == "4"){
          Console.WriteLine("Enter 1st Value");
        a = Double.Parse(Console.ReadLine());
        Console.WriteLine("Enter 2nd Value");
        b = Double.Parse(Console.ReadLine());
        Console.WriteLine(a - b);
         Console.Read();
      }
      else{
        Console.WriteLine("Invalid Input");
         Console.Read();
      }
    }
   
      public static void Squareroot(){
        Console.WriteLine("Please Enter The Value You Would Like To Find The Square Root Of:");
        double sqrt = Double.Parse(Console.ReadLine());
        if (sqrt < 0 ){
          Console.WriteLine("This Value is Invalid");
        }
        else{
          Console.WriteLine("Square Root of " + sqrt + " is " + Math.Sqrt(sqrt));
          Console.Read();
        }
      }
     public static void converter(){
       double converted_value;
       double  a;
       Console.Clear();
       Console.WriteLine("1. Convert USD to Euro (EUR)");
       Console.WriteLine("2. Convert USD to British Pound Sterling (GBP)");
       Console.WriteLine("3. Convert USD to Japanese Yen (JPY)");
       Console.WriteLine("4. Convert USD to Canadian Dollar (CAD)");
       Console.WriteLine("---------------------------------------------");
       Console.WriteLine("Select a Choice:");
       string useranswerconvert = Console.ReadLine();
       if (useranswerconvert == "1"){
         Console.WriteLine("Enter A Value To Convert"); 
         a = Double.Parse(Console.ReadLine());
         converted_value = a * 0.94;
         Console.WriteLine("Your Value Is " + converted_value);
         Console.Read();
       }
       else if (useranswerconvert == "2"){
          Console.WriteLine("Enter A Value To Convert"); 
         a = Double.Parse(Console.ReadLine());
         converted_value = a * 0.79;
         Console.WriteLine("Your Value Is " +  converted_value);
          Console.Read();
       }
       else if (useranswerconvert == "3"){
         Console.WriteLine("Enter A Value To Convert"); 
         a = Double.Parse(Console.ReadLine());
         converted_value = a * 113;
         Console.WriteLine("Your Value Is " + converted_value);
          Console.Read();

       }
       else if (useranswerconvert == "4"){
         Console.WriteLine("Enter A Value To Convert"); 
         a = Double.Parse(Console.ReadLine());
         converted_value = a * 1.33;
         Console.WriteLine("Your Value Is " + converted_value);
          Console.Read();
       }
     }
   }
 
 class MainClass {
  public static void Main (string[] args) {
    Calculator.Menu();
  }
}//o