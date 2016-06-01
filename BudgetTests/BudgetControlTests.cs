using Budget;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTests
{
    [TestFixture]
    class BudgetControlTests
    {

        [Test]
        public void AddExpense_ValidExpense_ExpenseCountIs1()
        {
            BudgetControl budget = new BudgetControl();

            budget.AddExpense("Katzenfutter", -10);

            Assert.AreEqual(1, budget.expense.Count);
        }

    }
}
