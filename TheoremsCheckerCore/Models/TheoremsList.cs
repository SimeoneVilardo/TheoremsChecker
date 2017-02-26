using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TheoremsCheckerCore.Models { 
    [XmlRoot("theorems")]
    public class TheoremsList
    {
        [XmlElement("theorem")]
        public List<Theorem> Theorems { get; set; }
    }
}
