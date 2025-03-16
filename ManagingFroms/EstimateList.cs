using Microsoft.EntityFrameworkCore;
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
    public partial class EstimateList : UserControl
    {
        public delegate void AmountChangedEventHandler(object sender, EventArgs e);

        public bool IsExpense { 
            get
            {
                if (_IsExpense)
                {
                    this.BackColor = Color.Coral;
                }
                else
                {
                    this.BackColor = Color.Lime;
                }
                return _IsExpense;
            }

            set
            {
                if (_IsExpense != value)
                {
                    _IsExpense = value;
                    PopulateData();
                }
                if (_IsExpense)
                {
                    this.BackColor = Color.Red;
                }
                else
                {
                    this.BackColor = Color.Green;
                }
            }
        }
        [Browsable(true)]
        private bool _IsExpense { get; set; }

        public bool EsentialsOnly { get; set; }


        public EstimateRange Range
        {
            get
            {
                return _Range;
            }
            set
            {
                if (_Range != value)
                {
                    PopulateData();
                }
                _Range = value;
            }
        }
        [Browsable(true)]
        EstimateRange _Range;

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when estimate amount changes")]
        public event EventHandler TotalAmountChanged;

        public EstimateList(EstimateRange range, bool isExpense)
        {
            InitializeComponent();
            _Range = range;
            _IsExpense = isExpense;
            PopulateData();
            Refresh();
        }
        public EstimateList()
        {
            InitializeComponent();
            //
            Refresh();
        }

        public void PopulateData()
        {

            flPnl_Data.Controls.Clear();
            lbl_Title.Text = Range.ToString() + " " + (IsExpense ? "Expenses" : "Income");
            if (!this.DesignMode)
            {
                if (Range == EstimateRange.Once) 
                {
                    foreach (var item in WNABHome.db.EstimateValues.Where(e => e.Expense == IsExpense && e.range == Range && e.CreationDate.Year == DateTime.Now.Year))
                    {
                        AddControl(item);
                    }
                }
                else
                {
                    foreach (var item in WNABHome.db.EstimateValues.Where(e => e.Expense == IsExpense && e.range == Range))
                    {
                        AddControl(item);
                    }
                }

                
            }
            UpdateTotal();
            Refresh();
        }

        bool loaded = false;
        private void EstimateList_Load(object sender, EventArgs e)
        {
            loaded = true;
            PopulateData();
        }
        public void UpdateTotal()
        {
            decimal total = 0;
            if (!this.DesignMode)
            {
                if (EsentialsOnly)
                {
                    total = WNABHome.db.EstimateValues.Where(e => e.Expense == IsExpense && e.range == Range && e.Esential == true).Select(e => e.Value).Sum();
                }
                else
                {
                    total = WNABHome.db.EstimateValues.Where(e => e.Expense == IsExpense && e.range == Range).Select(e => e.Value).Sum();
                }
                
            }
            num_ExpTotal.Value = total;
            if (!this.DesignMode && loaded)
            {
                TotalAmountChanged.Invoke(this, new EventArgs());
            }
        }
        private void btn_WeekExpAdd_Click(object sender, EventArgs e)
        {
            bool a = IsExpense;
            EstimateValue newVal = new EstimateValue();
            newVal.AsscosiatedTagId = 50;
            newVal.range = Range;
            newVal.Expense = IsExpense;
            newVal.CreationDate = DateTime.Today;
            WNABHome.db.Add(newVal);
            WNABHome.db.SaveChanges();
            AddControl(newVal);
            UpdateTotal();
            
        }

        private void AddControl(EstimateValue val)
        {
            var cntl = new EstimateControl(val);
            cntl.AmountChanged += EstimateAmount_Changed;
            cntl.AutoScaleMode = AutoScaleMode.Inherit;
            flPnl_Data.Controls.Add(cntl);
        }
        protected void EstimateAmount_Changed(object sender, EventArgs e)
        {
            UpdateTotal();
        }

    }
}
