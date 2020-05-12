using System;
using System.Collections.Generic;

namespace FinalProjectDB
{
    public partial class Component
    {
        public int ComponentId { get; set; }
        public string ComponentPartNumber { get; set; }
        public string ComponentName { get; set; }
        public string ComponentDescription { get; set; }
        public string ComponentType { get; set; }
        public string ComponentMemberOf { get; set; }
        public string ComponentNotes { get; set; }
        public DateTime ComponentCreatedDate { get; set; }
    }
}
