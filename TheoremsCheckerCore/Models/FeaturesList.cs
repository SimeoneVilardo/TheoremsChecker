using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TheoremsCheckerCore.Models
{
    public class FeaturesList
    {
        [XmlElement("value")]
        public List<string> Value { get; set; }
    }
}
