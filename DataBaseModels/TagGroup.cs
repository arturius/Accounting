using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting
{
    public class TagGroup
    {
        public int TagGroupId { get;  set; }
        public string Name { get;  set; }
        public List<int> Tags { get; set; } = new List<int>();


        public TagGroup()
        {

        }

        public TagGroup(int id, string tagName, List<int> tags)
        {
            TagGroupId = id;
            Name = tagName;
            Tags = tags;
        }
    }
}
