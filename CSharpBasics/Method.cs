using System;
using System.Linq;

class Methods 
{
    void PrintInfo()
    {
        Console.WriteLine("Printig....");
        Multiply(23.4f, 2314.1f);
     
      Sum (2.3,4.5);
      Sum (1.2,22.1,34.1);

      Greet ("Hello" , "Good day");
      Greet ("Anusha");

    byte[] numbbers = {2,1,3,4,5,6,18};
     (byte Min ,byte Max) result = FindMinMax(numbers);

        //Named arguments
        PrintCustomerDetails(age : 23 , name : "ABC" , isMale:true , address 
        "ktm")

    }
    void PrintSomething(string message)
    {
        Console.WriteLine(message);
    }


    

        //Varaible number of arguments
        double Sum(params double[] numbers)
        {
            double sum = 0;
            foreach(double num in numbers)
            {
                sum =sum + num;
            }
                return sum ;


        }
         //Optional arguments

        string Greet(string name , string prefix ="Morning")
        {
           string fullname = $" {prefix} , {name}"; //String interpolation
           return fullname; 
    

        //Returning Multiple values :using tuples
        (byte , byte) FindMinMax(byte[] numbers)
        {
          byte max = numbers.Max();
          byte min = numbers.Min();

        return (min,max);
        }

       void PrintCustomerDetails( String name ,string address , byte age , bool isMale)
       
    {
        Console.WriteLine($"{name} [{age}] ,{address}");
    }


        //Expression bodied method syntax
        float Subtract(float firstNum , float secondNum) => firstNum - secondNum;
      
      

}