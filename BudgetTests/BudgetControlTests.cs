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

        [Test]
        public void AddExpense_InvalidExpense_PositiveCost_ExpenseCountIs0()
        {
            BudgetControl budget = new BudgetControl();

            budget.AddExpense("Katzenfutter", 10);

            Assert.AreEqual(0, budget.expense.Count);
        }

        [Test]
        public void AddExpense_InvalidExpense_NeutralCost_ExpenseCountIs0()
        {
            BudgetControl budget = new BudgetControl();

            budget.AddExpense("Katzenfutter", 0);

            Assert.AreEqual(0, budget.expense.Count);
        }
    }
}
