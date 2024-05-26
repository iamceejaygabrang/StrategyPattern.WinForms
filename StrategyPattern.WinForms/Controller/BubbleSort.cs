using StrategyPattern.WinForms.Interface;
using StrategyPattern.WinForms.Models;

namespace StrategyPattern.WinForms.Controller
{
    public class BubbleSort : ISortMethod
    {
        public string SortProcess(string name)
        {
            //Implement sort using BubbleSort
            //Implement code logic for BubbleSort            
            Console.WriteLine($"Sort using BubbleSort: {name}");
            return name;
            
        }
    }
}
