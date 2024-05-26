using StrategyPattern.WinForms.Interface;

namespace StrategyPattern.WinForms.Controller
{
    
    public class SortProcess
    {
        private ISortMethod _sortMethod;

        public void SetSortStrategy(ISortMethod sortMethod)
        {
            _sortMethod = sortMethod;
        }

        public string Sorting(string name)
        {
            _sortMethod.SortProcess(name);
            return name;
        }

    }
}
