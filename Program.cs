using System;
namespace New_folder

{
    class program
    {
        private static void Main()
        {
            Console.WriteLine("Enter Size of numbers : ");
            var max = 0 ;
            var Size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The numbers : ");
            for(var i =1; i<=Size;i++){
                
                var num = Convert.ToInt32(Console.ReadLine());

                if(num>max){

                    max=num;
                }
                
            }
            Console.WriteLine("The Max Number is : " + max);
        }
    }
}