using System;

namespace Solvings
{
    public class QuadraticSolve
    {

        private double a;

        private double b;

        private double c;

        public void Enter()
        {
            Console.WriteLine("Enter value for a:");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for b: ");
            double b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for c:");
            double c = Convert.ToInt32(Console.ReadLine());
        }      
        public void getDescriminant()
        {
            int y;
            double r1, r2, d1;

            d1 = b * b - 4 * a * c;
            
            if(d1 == 0)
            {
                y = 0;            
            }else if(d1 > 0)
            {
                y = 2;
            }else if (d1 == 0)
            {
                y = 3;
            }else{
                y = 4;
            }
            switch(y){
                case 1: Console.WriteLine("Not a quadratic equation");
                Console.ReadLine();
                break;

                case 2: Console.WriteLine("Roots are distinct");
                r1 = (-b + Math.Sqrt(d1))/(2 * a);
                r2 = (-b - Math.Sqrt(d1))/(2 * a);
                Console.WriteLine("First root is{0:#.##}", r1);
                Console.WriteLine("Second root is {0:#.##}",r2);
                Console.ReadLine();
                break;
                
            }
        }
        
        
    }
}