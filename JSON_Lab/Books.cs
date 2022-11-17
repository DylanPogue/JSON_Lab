using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Books
    {
        public List<Item> Items { get; set; }

        public Books(List<Item> items)
        {
            Items = items;
        }

        public override string ToString()
        {
            string bookString = "";
            bookString += $"Title: {Items[0].VolumeInfo.Title}\n";
            bookString += $"Authors: {Items[0].VolumeInfo.Authors[0]}\n";
            bookString += $"Description: {Items[0].VolumeInfo.Description}\n";
            bookString += $"ID: {Items[0].Id}\n";
            bookString += $"SelfLink: {Items[0].SelfLink}\n";
            return bookString;
        }
    }
}
