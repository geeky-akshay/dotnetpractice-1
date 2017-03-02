using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            TestingMethod();
        }

        private void TestingMethod()
        {
            var entities = new List<Employee>{
                new Employee{Id = 1, Name = "Amit", Salary = 34000, DeptName = "Sales"},
                new Employee{Id = 2, Name = "Bandhu", Salary = 28000, DeptName = "Sales"},
                new Employee{Id = 3, Name = "Chirag", Salary = 25000, DeptName = "Marketing"},
            };
            foreach (var e in entities.GetByPredicate<Employee>(e => e.Name.Contains('i')))
            {
                Console.WriteLine($"{e.Id} - {e.Name}");
            }
        }

        private void btnAddNewCriteria_Click(object sender, EventArgs e)
        {
            var control = new SearchCriteriaBox();
            control.RemoveClicked += Control_RemoveClicked;
            flowPanelSearchCriterias.Controls.Add(control);
        }

        private void Control_RemoveClicked(object sender, EventArgs e)
        {
            flowPanelSearchCriterias.Controls.Remove(sender as Control);
            (sender as Control).Dispose();
        }
    }

    public static class ExtensionClass
    {
        public static IEnumerable<T> GetByPredicate<T>(this IEnumerable<T> source, Expression<Func<T, bool>> predicate)
        {
            return source.Where(predicate.Compile());
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string DeptName { get; set; }
    }
}
