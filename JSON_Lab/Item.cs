using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Item
    {
        public VolumeInfo VolumeInfo { get; set; }
        public string Id { get; set; }
        public string SelfLink { get; set; }

        public Item(VolumeInfo volumeInfo, string id, string selfLink)
        {
            VolumeInfo = volumeInfo;
            Id = id;
            SelfLink = selfLink;
        }
    }
}