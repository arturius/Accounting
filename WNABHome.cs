using Accounting;
using Accounting.ManagingFroms;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Globalization;
using System.Security;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Accounting
{
    public partial class WNABHome : Form
    {
        public static DataBaseContex db = new DataBaseContex();

        List<DataEntry> displayDataEntries = new List<DataEntry>();
        //List<DataEntry> allDataEntries = new List<DataEntry>();
        List<string> ImportList = new List<string>();
        TagGroup activeTagGroup = null;

        int activeTagID;
        public WNABHome()
        {
            InitializeComponent();
            comb_Import.DataSource = Enum.GetValues(typeof(AccountType));
            comb_Selection.DataSource = Enum.GetValues(typeof(AccountType));
            dt_RangeStart.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dt_RangeEnd.Value = DateTime.Now;
            dt_Year.Value = dt_RangeStart.Value;
            dt_Month.Value = dt_RangeEnd.Value;

        }
        #region Tags
        BindingList<TagGroup> ActiveTagGroups = new BindingList<TagGroup>();
        private void PopulateGroups()
        {
            ActiveTagGroups.Clear();
            ActiveTagGroups.Add(new TagGroup(0, "All",new List<int>() ));
            foreach (TagGroup val in WNABHome.db.TagGroups)
            {
                if (val.TagGroupId != 0)
                {
                    ActiveTagGroups.Add(val);
                }
            }
            combo_Group.DisplayMember = "Name";
            combo_Group.DataSource = ActiveTagGroups;
            combo_Group.SelectedIndex = 0;
        }

        BindingList<TagData> ActiveTagIds = new BindingList<TagData>();
        private void PopulateTags()
        {
            if (WNABHome.db != null)
            {
                ActiveTagIds.Clear();
                ActiveTagIds.Add(new TagData(50, "All", "^$"));
                if (activeTagGroup != null && activeTagGroup.TagGroupId != 0)
                {
                    foreach (var item in activeTagGroup.Tags.Order())
                    {
                        TagData data = db.Tags.Where(x => x.TagId == item).FirstOrDefault();
                        if (data != null)
                        {
                            ActiveTagIds.Add(data);
                        }
                        else if (item == -1)
                        {
                            ActiveTagIds.Add(new TagData(-1, "Unkown", "()"));
                        }
                        
                    }
                }
                else
                {
                    ActiveTagIds.Add(new TagData(-1, "Unkown", "()"));
                    foreach (TagData val in WNABHome.db.Tags)
                    {
                        if (val.TagId != 50)
                        {
                            ActiveTagIds.Add(val);
                        }
                    }
                }
                
                Combo_IDs.DisplayMember = "Name";
                Combo_IDs.DataSource = ActiveTagIds;
                Combo_IDs.SelectedIndex = 0;
            }
        }

        private void Combo_IDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            TagData tag = (TagData)Combo_IDs.SelectedValue;
            if (tag == null)
            {
                return;
            }    
            if (tag.TagId == 50)
            {
                activeTagID = 0;
            }
            else
            {
                activeTagID = tag.TagId;
            }
            UpdateEntries();
        }

        private void combo_Group_SelectedIndexChanged(object sender, EventArgs e)
        {
            TagGroup tag = (TagGroup)combo_Group.SelectedValue;
            if (tag == null)
            {
                return;
            }
            if (tag.TagGroupId == 0)
            {
                activeTagGroup = null;
            }
            else
            {
                activeTagGroup = tag;
            }

            PopulateTags();
            UpdateEntries();
        }

        #endregion
        private void SetMax()
        {
            num_PrimeDebit.Maximum = Decimal.MaxValue;
            num_PrimeDebit.Minimum = Decimal.MinValue;
            num_PrimeCredit.Maximum = Decimal.MaxValue;
            num_PrimeCredit.Minimum = Decimal.MinValue;
            num_PrimeBalance.Maximum = Decimal.MaxValue;
            num_PrimeBalance.Minimum = Decimal.MinValue;
            num_EstIncome.Maximum = Decimal.MaxValue;
            num_EstIncome.Minimum = Decimal.MinValue;
            num_EstExpenses.Maximum = Decimal.MaxValue;
            num_EstExpenses.Minimum = Decimal.MinValue;
            num_EstBalance.Maximum = Decimal.MaxValue;
            num_EstBalance.Minimum = Decimal.MinValue;
        }

        private void UpdateEntries()
        {
            if (db == null)
            {
                return;
            }

            db.DataEntrys.OrderBy(x => x.Date);
            EnableSelection(db.DataEntrys.Count() > 0);
            if (rb_Range.Checked)
            {
                displayDataEntries = db.DataEntrys.Where(x => x.Date < dt_RangeEnd.Value && x.Date > dt_RangeStart.Value).ToList();
            }
            else if (rb_Year.Checked)
            {
                displayDataEntries = db.DataEntrys.Where(x => x.Date.Year == dt_Year.Value.Year).ToList();
            }
            else
            {
                displayDataEntries = db.DataEntrys.Where(x => x.Date.Year == dt_Month.Value.Year && x.Date.Month == dt_Month.Value.Month).ToList();
            }

            if (activeTagGroup != null)
            {
                displayDataEntries = displayDataEntries.Where(t => activeTagGroup.Tags.Contains(t.TagID)).ToList();
            }

            if (activeTagID != 0)
            {
                displayDataEntries = displayDataEntries.Where(x => x.TagID == activeTagID).ToList();
            }
            if (!cb_All.Checked)
            {
                displayDataEntries = displayDataEntries.Where(x => (int)x.Account == comb_Selection.SelectedIndex).ToList();
            }

            if (!string.IsNullOrEmpty(tb_RegEx.Text))
            {
                Regex rg = new Regex(tb_RegEx.Text);
                displayDataEntries = displayDataEntries.Where(x => rg.IsMatch(x.Note)).ToList();
            }
            displayDataEntries.OrderBy(x => x.Date);
            UpdateSelection();
        }
        #region Imports
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_FileSelect.Text = openFileDialog1.FileName;
            }
        }

        private void tb_FileSelect_TextChanged(object sender, EventArgs e)
        {
            UnlockImport();
        }

        private void UnlockImport()
        {
            if (File.Exists(tb_FileSelect.Text) && comb_Import.SelectedIndex != -1)
            {
                btn_Import.Enabled = true;
            }
            else
            {
                btn_Import.Enabled = false;
            }
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            ImportData();
            UpdateMin();
        }
        private void ImportData()
        {
            if (ImportList.Contains(tb_FileSelect.Text))
            {
                if (MessageBox.Show("Do you want to continue?", "Duplicate Import", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            List<DataEntry> vals = new List<DataEntry>();
            ImportList.Add(tb_FileSelect.Text);
            using (var reader = new StreamReader(tb_FileSelect.Text))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    DataEntry val = new DataEntry(values, (AccountType)comb_Import.SelectedIndex);
                    val.AssignTag(db.Tags.ToList());
                    if (!db.DataEntrys.Select(t => t.Date == val.Date && t.Amount == val.Amount && t.Note.Equals(val.Note)).FirstOrDefault())
                    {
                        db.Add(val);

                    }
                    else
                    {
                        //var a = db.DataEntrys.Where(t => t.Date == val.Date && t.Amount == val.Amount && t.Note.Equals(val.Note)).FirstOrDefault();
                        //allDataEntries.Add(val);
                    }

                }
            }
            db.SaveChanges();
            UpdateEntries();
        }
        #endregion
        

        private void EnableSelection(bool enabled)
        {
            dt_Month.Enabled = enabled;
            dt_Year.Enabled = enabled;
            dt_RangeEnd.Enabled = enabled;
            dt_RangeStart.Enabled = enabled;
            rb_Month.Enabled = enabled;
            rb_Year.Enabled = enabled;
            rb_Range.Enabled = enabled;
        }

        private void UpdateSelection()
        {
            dgv_Display.DataSource = null;
            dgv_Display.Refresh();

            dgv_Display.DataSource = displayDataEntries;
            dgv_Display.Refresh();

            decimal credit = 0;
            decimal debit = 0;
            foreach (var entry in displayDataEntries)
            {
                if (entry.isDebt)
                {
                    debit += entry.Amount;
                }
                else
                {
                    credit += entry.Amount;
                }
            }

            num_PrimeCredit.Value = credit;
            num_PrimeDebit.Value = debit;
        }



        #region Estimates

        private void btn_Estimates_Click(object sender, EventArgs e)
        {
            var b = new Estimates();
            b.Show();
        }
        private void chk_RealData_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_RealData.Checked)
            {
                rb_Year.Checked = true;
            }
            EnableSelection(!chk_RealData.Checked);
            dt_EstimateDate.Value = DateTime.Today;
            dt_EstimateDate.Enabled = !chk_RealData.Checked;
            EstimateTotals();

        }

        private void num_Est_ValueChanged(object sender, EventArgs e)
        {
            EstimateTotals();
        }
        public void EstimateTotals()
        {

            Tuple<decimal, decimal, decimal> expensesVals, incomeVals;
            (decimal, decimal, decimal) totalIncome = GetYearEstimate(dt_EstimateDate.Value, out expensesVals, out incomeVals, chk_RealData.Checked);
            num_WeekExp.Value = expensesVals.Item3;
            num_MonthExp.Value = expensesVals.Item2;
            Num_YearExp.Value = expensesVals.Item1;

            num_WeekIn.Value = incomeVals.Item3;
            num_MonthIn.Value = incomeVals.Item2;
            num_YearIn.Value = incomeVals.Item1;


            decimal income = totalIncome.Item2;
            decimal expenses = totalIncome.Item3;
            if (!chk_RealData.Checked)
            {
                //expenses += (-1) * num_PrimeDebit.Value;
                //income += num_PrimeCredit.Value;
            }
            else
            {

            }
            num_EstExpenses.Value = expenses;
            num_ExpPerMonth.Value = expenses / 12;
            num_ExpPerWeek.Value = expenses / 52;
            num_EstIncome.Value = income;
            num_InPerMonth.Value = income / 12;
            num_InPerWeek.Value = income / 52;

            decimal totalBalance = totalIncome.Item1+ totalIncome.Item2 - totalIncome.Item3;
            num_BaltoDate.Value = totalIncome.Item1;
            num_EstBalance.Value = totalBalance;
            num_BalPerMonth.Value = num_EstBalance.Value / 12;
            num_BalPerWeek.Value = num_EstBalance.Value / 52;
            Refresh();
        }

        public (decimal, decimal, decimal) GetYearEstimate(DateTime estimateDate, out Tuple<decimal, decimal, decimal> expenses, out Tuple<decimal, decimal, decimal> income, bool accountForSpentExpenses = false)
        {
            int estYear = estimateDate.Year;
            int estMonth = estimateDate.Month;
            int estWeek = GetIso8601WeekOfYear(estimateDate);
            decimal weeksLeft = 52 - estWeek+1;
            decimal monthsLeft = 12 - estMonth + 1;
            DateTime yearStart = new DateTime(estYear, 1, 1);
            List<DataEntry> validEntries = db.DataEntrys.Where(e => e.Date.Year == estYear && e.Date < estimateDate).ToList();


            decimal yearExpenses = db.EstimateValues.Where(e => e.Expense == true && e.range == EstimateRange.Yearly).Select(e => e.Value).Sum();
            decimal monthlyExpenses = db.EstimateValues.Where(e => e.Expense == true && e.range == EstimateRange.Monthly).Select(e => e.Value).Sum();
            decimal weeklyExpenses = db.EstimateValues.Where(e => e.Expense == true && e.range == EstimateRange.Weekly).Select(e => e.Value).Sum();
            expenses = new Tuple<decimal, decimal, decimal>(yearExpenses, monthlyExpenses, weeklyExpenses);

            decimal yearIncome = db.EstimateValues.Where(e => e.Expense == false && e.range == EstimateRange.Yearly).Select(e => e.Value).Sum();
            decimal monthlyIncome = db.EstimateValues.Where(e => e.Expense == false && e.range == EstimateRange.Monthly).Select(e => e.Value).Sum();
            decimal weeklyIncome = db.EstimateValues.Where(e => e.Expense == false && e.range == EstimateRange.Weekly).Select(e => e.Value).Sum();
            income = new Tuple<decimal, decimal, decimal>(yearIncome, monthlyIncome, weeklyIncome);

            decimal onceIn = db.EstimateValues.Where(e => e.Expense == false && e.range == EstimateRange.Once && e.CreationDate.Year == estimateDate.Year).Select(e => e.Value).Sum();
            decimal onceExp = db.EstimateValues.Where(e => e.Expense == true && e.range == EstimateRange.Once && e.CreationDate.Year == estimateDate.Year).Select(e => e.Value).Sum();

            decimal amount = validEntries.Select(x => x.Amount).Sum();
            if (!accountForSpentExpenses)
            {
                
                return (amount, (onceIn +yearIncome + weeklyIncome * weeksLeft + monthlyIncome * monthsLeft),  (onceExp +yearExpenses + weeklyExpenses * weeksLeft + monthlyExpenses * monthsLeft));
            }

            IEnumerable<decimal> yearPaidExpense = from de in validEntries
                                                   join ev in db.EstimateValues on de.TagID equals ev.AsscosiatedTagId
                                                   where ev.range == EstimateRange.Yearly && ev.Expense == true
                                                   select de.Amount;
            IEnumerable<decimal> oncePaidExpense = from de in validEntries
                                                   join ev in db.EstimateValues on de.TagID equals ev.AsscosiatedTagId
                                                   where ev.range == EstimateRange.Once && ev.Expense == true && ev.CreationDate.Year == estYear
                                                   select de.Amount;

            IEnumerable<decimal> monthPaidExpense = from de in db.DataEntrys
                                                    join ev in db.EstimateValues on de.TagID equals ev.AsscosiatedTagId
                                                    where de.Date.Year == estYear && de.Date.Month == estMonth
                                                    && ev.range == EstimateRange.Monthly && ev.Expense == true
                                                    select de.Amount;

            var b=  from de in db.DataEntrys
                   join ev in db.EstimateValues on de.TagID equals ev.AsscosiatedTagId
                   where de.Date.Year == estYear && de.Date.Month == estMonth
                   && ev.range == EstimateRange.Monthly && ev.Expense == true 
                   select  new { de.Amount, de.Date};

            IEnumerable<decimal> yearPaidIncome = from de in validEntries
                                                  join ev in db.EstimateValues on de.TagID equals ev.AsscosiatedTagId
                                                  where ev.range == EstimateRange.Yearly && ev.Expense == false
                                                  select de.Amount;
            IEnumerable<decimal> oncePaidIncome = from de in validEntries
                                                  join ev in db.EstimateValues on de.TagID equals ev.AsscosiatedTagId
                                                  where ev.range == EstimateRange.Once && ev.Expense == false && ev.CreationDate.Year == estYear
                                                  select de.Amount;

            IEnumerable<decimal> monthPaidIncome = from de in db.DataEntrys
                                                   join ev in db.EstimateValues on de.TagID equals ev.AsscosiatedTagId
                                                   where de.Date.Year == estYear && de.Date.Month == estMonth
                                                   && ev.range == EstimateRange.Monthly && ev.Expense == false
                                                   select de.Amount;
            decimal yearIn = yearIncome - yearPaidIncome.Sum() - oncePaidIncome.Sum();
            decimal monthIn = monthlyIncome * (monthsLeft-1) + (monthlyIncome - monthPaidIncome.Sum());
            decimal yearEx = yearExpenses + yearPaidExpense.Sum() + oncePaidExpense.Sum();
            decimal monthEx = monthlyExpenses * (monthsLeft - 1) + (monthlyExpenses - monthPaidExpense.Sum());
            return (amount, (yearIn + weeklyIncome * weeksLeft + monthIn), (yearEx + weeklyExpenses * weeksLeft + monthEx));
        }

        public static int GetIso8601WeekOfYear(DateTime time)
        {
            // Seriously cheat.  If its Monday, Tuesday or Wednesday, then it'll 
            // be the same week# as whatever Thursday, Friday or Saturday are,
            // and we always get those right
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            // Return the week of our adjusted day
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
        #endregion

        


        // This presumes that weeks start with Monday.
        // Week 1 is the 1st week of the year with a Thursday in it.
        

        private void num_Prime_ValueChanged(object sender, EventArgs e)
        {
            num_PrimeBalance.Value = num_PrimeCredit.Value + num_PrimeDebit.Value;
        }

        #region Updating Ranges
        private void rb_Year_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEntries();
        }

        private void dt_RangeStart_ValueChanged(object sender, EventArgs e)
        {
            if (rb_Range.Checked)
            {
                UpdateEntries();
            }
        }


        private void dt_Year_ValueChanged(object sender, EventArgs e)
        {
            if (rb_Year.Checked)
            {
                UpdateEntries();
            }
        }

        private void dt_Month_ValueChanged(object sender, EventArgs e)
        {
            if (rb_Month.Checked)
            {
                UpdateEntries();
            }
        }

        private void UpdateMin()
        {
            if (!rb_Range.Checked && db.DataEntrys.Count() > 0)
            {
                dt_RangeStart.Value = db.DataEntrys.Min(x => x.Date);
            }
        }

        private void comb_Selection_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEntries();
        }

        private void cb_All_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEntries();
        }

        

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            UpdateEntries();
        }
        #endregion
        private void btn_TagEdit_Click(object sender, EventArgs e)
        {
            var tags = new TagManager();
            tags.ShowDialog();
            PopulateGroups();
            PopulateTags();
            UpdateMin();
            EstimateTotals();
            Refresh();
        }

        private void WNABHome_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                db = new DataBaseContex();
                SetMax();
                EnableSelection(false);
                PopulateGroups();
                PopulateTags();
                UpdateMin();
                EstimateTotals();
                Refresh();
            }
        }

        

        private void dgv_Display_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           DataEntry selelectedEntry =(DataEntry) dgv_Display.Rows[e.RowIndex].DataBoundItem;
        }
    }
}
