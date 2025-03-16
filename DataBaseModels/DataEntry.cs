using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Accounting
{
    public enum AccountType
    {
        Checking = 0,
        Savings = 1,
        Credit1 = 2, 
        Credit2 = 3,
        Other =4
    }
    public class DataEntry
    {
        [Key]

        [System.ComponentModel.Browsable(false)]
        public int EntryId { get; set; }

        public AccountType Account { get; set; }
        public DateTime Date { get;  set; }
        public decimal Amount
        {
            get
            {
                if (this.isDebt) {
                    return _amount * -1;
                }
                else
                {
                    return _amount;
                }
            }

            set
            {
                _amount = Math.Abs( value);
            }

        }
        public string Note { get; set; }

        [System.ComponentModel.Browsable(false)]
        public bool isDebt { get;  set; } = false;

        [System.ComponentModel.Browsable(false)]
        public int TagID { get; set; } = -1;

        public string Category { 
            get {
                DataBaseContex db = new DataBaseContex();
                var selectedTag = db.Tags.Where(t => t.TagId == TagID).FirstOrDefault();
                if (selectedTag != null)
                {
                    return selectedTag.Name;
                }
                return "Unkown";
            } 
        }
        
        private decimal _amount;

        public DataEntry() { }
        public DataEntry(string[] csvLine, AccountType account = AccountType.Other ) 
        {
            Account = account;
            DateTime date = DateTime.Now;
            DateTime.TryParse(csvLine[0], out date);
            Date = date;
            Note = csvLine[1];
            if (csvLine[2]!= string.Empty)
            {
                isDebt = true;
                if(!decimal.TryParse(csvLine[2],out _amount))
                {
                    decimal.TryParse(csvLine[3], out _amount);
                }
            }
            else
            {
                if (!decimal.TryParse(csvLine[3], out _amount))
                {
                    decimal.TryParse(csvLine[4], out _amount);
                }
            }

        }

        public void AssignTag(List<TagData> tags)
        {
            foreach (TagData tag in tags)
            {
                if (tag.IsTag(Note))
                {
                    TagID = tag.TagId;
                    break;
                }
            }
        }
    }
}
