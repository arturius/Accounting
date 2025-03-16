using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.ManagingFroms
{
    public partial class Estimates : Form
    {
        public delegate void TotalAmountChangedEventHandler(object sender, EventArgs e);
        public Estimates()
        {
            InitializeComponent();
            combo_TypeSelection.SelectedIndex = 0;
        }

        private void combo_TypeSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isExpense = (combo_TypeSelection.SelectedIndex == 0);

            estLst_OnceEstimates.IsExpense = isExpense;
            estLst_WeekEstimates.IsExpense = isExpense;
            estLst_MonthEstimates.IsExpense = isExpense;
            estLst_YearEstimates.IsExpense = isExpense;
            Refresh();
        }

        protected void EstimateAmount_Changed(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        public void CalculateTotals()
        {
            bool isExpense = combo_TypeSelection.SelectedIndex == 0;
            decimal weekTotalExp, monthTotalExp, yearTotalExp, weekTotalIn, monthTotalIn, yearTotalIn, onceIn, onceExp;
            if (cb_Esentials.Checked)
            {
                 weekTotalExp = WNABHome.db.EstimateValues.Where(e => e.Expense == true && e.range == EstimateRange.Weekly && e.Esential).Select(e => e.Value).Sum();
                 monthTotalExp = WNABHome.db.EstimateValues.Where(e => e.Expense == true && e.range == EstimateRange.Monthly && e.Esential).Select(e => e.Value).Sum();
                 yearTotalExp = WNABHome.db.EstimateValues.Where(e => e.Expense == true && e.range == EstimateRange.Yearly && e.Esential).Select(e => e.Value).Sum();

                 weekTotalIn = WNABHome.db.EstimateValues.Where(e => e.Expense == false && e.range == EstimateRange.Weekly && e.Esential).Select(e => e.Value).Sum();
                 monthTotalIn = WNABHome.db.EstimateValues.Where(e => e.Expense == false && e.range == EstimateRange.Monthly && e.Esential).Select(e => e.Value).Sum();
                 yearTotalIn = WNABHome.db.EstimateValues.Where(e => e.Expense == false && e.range == EstimateRange.Yearly && e.Esential).Select(e => e.Value).Sum();

                onceIn = WNABHome.db.EstimateValues.Where(e => e.Expense == false && e.range == EstimateRange.Once && e.Esential && e.CreationDate.Year == DateTime.Now.Year).Select(e => e.Value).Sum();
                onceExp = WNABHome.db.EstimateValues.Where(e => e.Expense == true && e.range == EstimateRange.Once && e.Esential && e.CreationDate.Year == DateTime.Now.Year).Select(e => e.Value).Sum();
            }
            else
            {
                weekTotalExp = WNABHome.db.EstimateValues.Where(e => e.Expense == true && e.range == EstimateRange.Weekly).Select(e => e.Value).Sum();
                monthTotalExp = WNABHome.db.EstimateValues.Where(e => e.Expense == true && e.range == EstimateRange.Monthly).Select(e => e.Value).Sum();
                yearTotalExp = WNABHome.db.EstimateValues.Where(e => e.Expense == true && e.range == EstimateRange.Yearly).Select(e => e.Value).Sum();

                weekTotalIn = WNABHome.db.EstimateValues.Where(e => e.Expense == false && e.range == EstimateRange.Weekly).Select(e => e.Value).Sum();
                monthTotalIn = WNABHome.db.EstimateValues.Where(e => e.Expense == false && e.range == EstimateRange.Monthly).Select(e => e.Value).Sum();
                yearTotalIn = WNABHome.db.EstimateValues.Where(e => e.Expense == false && e.range == EstimateRange.Yearly).Select(e => e.Value).Sum();

                onceIn = WNABHome.db.EstimateValues.Where(e => e.Expense == false && e.range == EstimateRange.Once && e.CreationDate.Year == DateTime.Now.Year).Select(e => e.Value).Sum();
                onceExp = WNABHome.db.EstimateValues.Where(e => e.Expense == true && e.range == EstimateRange.Once && e.CreationDate.Year == DateTime.Now.Year).Select(e => e.Value).Sum();
            }
            

            decimal totalExp = onceExp + yearTotalExp + monthTotalExp * 12 + weekTotalExp * 52;
            decimal totalIn = onceIn + yearTotalIn + monthTotalIn * 12 + weekTotalIn * 52;
            num_Balance.Value = totalIn - totalExp;
            num_Total.Value = isExpense ? totalExp : totalIn;
        }

        private void cb_Esentials_CheckedChanged(object sender, EventArgs e)
        {
            estLst_OnceEstimates.EsentialsOnly = cb_Esentials.Checked;
            estLst_WeekEstimates.EsentialsOnly = cb_Esentials.Checked;
            estLst_MonthEstimates.EsentialsOnly = cb_Esentials.Checked;
            estLst_YearEstimates.EsentialsOnly = cb_Esentials.Checked;
            CalculateTotals();
        }
    }
}
