using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting
{
    public enum EstimateRange
    {
        Yearly, Monthly, Weekly, Once
    }

    public class EstimateValue
    {
        [Key]
        [System.ComponentModel.Browsable(false)]
        public int Id { get; set; }
        public string Description { get; set; } = String.Empty;
        public decimal Value { get; set; }
        [System.ComponentModel.Browsable(false)]
        public EstimateRange range { get; set; }
        [System.ComponentModel.Browsable(false)]
        public bool Expense { get; set; }

        [System.ComponentModel.Browsable(false)]
        public int AsscosiatedTagId { get; set; } = -1;

        public DateTime CreationDate { get; set; }

        public bool Esential { get; set; }
        public EstimateValue() { }
    }
}
