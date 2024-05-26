using StrategyPattern.WinForms.Interface;

namespace StrategyPattern.WinForms.Controller
{
    public class QuickSort : ISortMethod
    {
        public string SortProcess(string name)
        {
            //Implement sort using QuickSort
            //Implement code logic for QuickSort
            Console.WriteLine($"Sort using QuickSort {name}");
            return name;
        }
    }
}
