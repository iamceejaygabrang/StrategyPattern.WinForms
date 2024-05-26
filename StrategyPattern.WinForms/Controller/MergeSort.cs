using StrategyPattern.WinForms.Interface;

namespace StrategyPattern.WinForms.Controller
{
    public class MergeSort : ISortMethod
    {
        public string SortProcess(string name)
        {

            //Implement sort using MergeSort
            //Implement code logic for MergeSort
            Console.WriteLine($"Sort using MergeSort {name}");
            return name;
        }
    }
}
