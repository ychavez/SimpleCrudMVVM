using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCrudMVVM.Models
{
    public class MainMenuItem
    {

        public string Title { get; set; }
        public string Icon { get; set; }
        public Type TargetType { get; set; }
    }
}
