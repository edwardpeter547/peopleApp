using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    internal class PersonModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }

        public string FullName
        {
            get
            {
                return $"{Name} {Family}";
            }
        }
    }
}
