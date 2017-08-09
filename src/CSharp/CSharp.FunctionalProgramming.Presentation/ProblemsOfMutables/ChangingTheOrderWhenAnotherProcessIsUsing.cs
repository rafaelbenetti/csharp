using System;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.FunctionalProgramming.Presentation.ProblemsOfMutables
{
    public static class ChangingTheOrderWhenAnotherProcessIsUsing
    {
        public static void Run()
        {
            var nums = Enumerable.Range(-10000, 20001).Reverse().ToList();

            Action task1 = () => Console.WriteLine(nums.Sum());
            Action task2 = () => 
            {
                nums.Sort();
                Console.WriteLine(nums.Sum());
            };

            Parallel.Invoke(task1, task2);
        }
    }
}
