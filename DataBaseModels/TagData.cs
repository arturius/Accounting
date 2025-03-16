using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Accounting
{
    public class TagData
    {
        [Key]
        public int TagId { get; set; }
        public string Name { get; set; }
        public string RegexPattern { get; set; }

        public TagData()
        {

        }

        public TagData(int tagId, string name, string regex)
        {
            TagId = tagId;
            Name = name;
            RegexPattern = regex;
        }

        public bool IsTag(string description)
        {
            Regex rg = new Regex(RegexPattern);
            return rg.IsMatch(description);
        }


        
    }
}
