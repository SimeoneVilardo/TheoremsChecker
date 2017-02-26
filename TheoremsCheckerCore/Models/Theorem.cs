using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TheoremsCheckerCore.Models
{
    public class Theorem
    {
        public Theorem()
        {
            Intervals = new IntervalsList();
            Intervals.Value = new List<string>();
            Features = new FeaturesList();
            Features.Value = new List<string>();
        }


        [XmlElement("id")]
        public int Id { get; set; }
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("intervals")]
        public IntervalsList Intervals { get; set; }
        [XmlElement("features")]
        public FeaturesList Features { get; set; }
        [XmlElement("body")]
        public string Body { get; set; }
    }
}
