using System;

namespace ShowClix
{
    class Program
    {
        static void Main(string[] args)
        {
            Theatre theatrics = new Theatre(1, 5);

            //Console.WriteLine(theatrics.SeatChart.Head.SeatObj.ID);
            theatrics.SeatChart.Print();
            Console.Read();
            
        }
    }
}
