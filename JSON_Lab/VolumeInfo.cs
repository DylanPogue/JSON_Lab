using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class VolumeInfo
    {
        public string Title { get; set; }
        public List<string> Authors { get; set; }
        public string Description { get; set; }

        public VolumeInfo(string title, List<string> authors, string description)
        {
            Title = title;
            Authors = authors;
            Description = description;
        }
    }
}
