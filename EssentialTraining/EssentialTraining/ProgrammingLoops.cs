using System;
namespace EssentialTraining
{
    public class ProgrammingLoops
    {
        public int ForLoop() 
        {
            var sum = 0;
            for (var i = 0; i < 100; i++)
            {
                sum = sum + 1;
            }

            return sum;
        }
    }
}
