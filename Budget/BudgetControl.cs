using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    public class BudgetControl
    {
        private LinkedList<Expense> _expenses;
        public LinkedList<Expense> expense
        {
            get { return _expenses; }
        }

        public BudgetControl()
        {
            _expenses = new LinkedList<Expense>();
        }

        public void AddExpense(string name, double value)
        {
            if (!string.IsNullOrEmpty(name) && value < 0)
            {
                _expenses.AddLast(new Expense(name, value));
            }
        }
    }
}
