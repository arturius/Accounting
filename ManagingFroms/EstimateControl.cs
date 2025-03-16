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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Accounting.ManagingFroms
{
    public partial class EstimateControl : UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when estimate amount changes")]
        public event EventHandler AmountChanged;
        public EstimateValue BoundValue
        {
            get
            {
                return _BoundValue;
            }
            set
            {

                _BoundValue = value;
                PopulateValues();
            }
        }

        private EstimateValue _BoundValue;
        BindingList<TagData> tags = new BindingList<TagData>();
        public EstimateControl()
        {
            InitializeComponent();
        }

        public EstimateControl(EstimateValue boundValue)
        {
            InitializeComponent();

            _BoundValue = boundValue;
        }
        private void PopulateCombo()
        {
            if (WNABHome.db != null)
            {

                tags.Add(new TagData(50, "None", "^$"));
                foreach (TagData val in WNABHome.db.Tags)
                {
                    if (val.TagId != 50)
                    {
                        tags.Add(val);
                    }
                }
                combo_Tag.DisplayMember = "Name";
                combo_Tag.DataSource = tags;
            }
        }

        private bool Populating = true;
        private void PopulateValues()
        {
            if (_BoundValue != null)
            {
                Populating = true;
                tb_Description.Text = BoundValue.Description;
                num_Amount.Value = BoundValue.Value;
                cb_Esential.Checked = BoundValue.Esential;
                if (BoundValue.AsscosiatedTagId > 0)
                {
                    combo_Tag.SelectedIndex = tags.IndexOf(tags.Where(b => b.TagId == BoundValue.AsscosiatedTagId).First());
                }
                else
                {
                    combo_Tag.SelectedIndex = 0;
                }
                Populating = false;
            }
        }

        private void EstimateControl_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                PopulateCombo();
                PopulateValues();
            }
        }

        private void combo_Tag_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (_BoundValue != null && !Populating)
            {
                TagData tag = (TagData)combo_Tag.SelectedValue;
                WNABHome.db.EstimateValues.Attach(_BoundValue);
                _BoundValue.AsscosiatedTagId = tag.TagId;
                WNABHome.db.Update(_BoundValue);
                WNABHome.db.SaveChanges();
            }
        }


        private void num_Amount_ValueChanged(object sender, EventArgs e)
        {
            if (_BoundValue != null && !Populating)
            {
                WNABHome.db.EstimateValues.Attach(_BoundValue);
                _BoundValue.Value = num_Amount.Value;
                WNABHome.db.Update(_BoundValue);
                WNABHome.db.SaveChanges();
                AmountChanged.Invoke(this, new EventArgs());
            }

        }


        private void UpdateText()
        {
            if (_BoundValue != null && !Populating)
            {
                WNABHome.db.EstimateValues.Attach(_BoundValue);
                BoundValue.Description = tb_Description.Text;
                WNABHome.db.Update(_BoundValue);
                WNABHome.db.SaveChanges();
            }
        }

        private void tb_Description_Leave(object sender, EventArgs e)
        {
            if (BoundValue?.Description != tb_Description.Text)
            {
                UpdateText();
            }
        }

        private void tb_Description_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdateText();
            }
        }

        private void EstimateControl_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void cb_Esential_CheckedChanged(object sender, EventArgs e)
        {
            if (_BoundValue != null && !Populating)
            {
                WNABHome.db.EstimateValues.Attach(_BoundValue);
                BoundValue.Esential = cb_Esential.Checked;
                WNABHome.db.Update(_BoundValue);
                WNABHome.db.SaveChanges();
            }
        }
    }
}
