using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using TheoremsCheckerCore.Models;

namespace TheoremsCheckerCore
{
    public class TheoremsChecker
    {
        private TheoremsList theorems;

        public TheoremsChecker(string Path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TheoremsList));
            using (FileStream fs = File.Open(Path, FileMode.Open))
                theorems = (TheoremsList)serializer.Deserialize(fs);
        }

        public Theorem ParseString(string str)
        {
            Theorem theorem = new Theorem();
            theorem.Body = str;
            var regex = new Regex(@"[\[\(](a,b)[\]\)]");
            foreach (Match match in new Regex(@"[\[\(](a,b)[\]\)]").Matches(theorem.Body))
                theorem.Intervals.Value.Add(match.Value);

            Constants.FEATURES features = new Constants.FEATURES();
            foreach (FieldInfo field in typeof(Constants.FEATURES).GetFields())
            {
                string feature = field.GetValue(features).ToString();

                while (str.Contains(feature))
                {
                    theorem.Features.Value.Add(feature);
                    str = str.Replace(feature, string.Empty);
                }                        
            }
            return theorem;
        }

        private Theorem getTheoremById(int id)
        {
            foreach (Theorem theorem in theorems.Theorems)
                if (theorem.Id == id)
                    return theorem;
            return null;
        }

        public Theorem GetRndTheorem()
        {
            return theorems.Theorems[new Random().Next(theorems.Theorems.Count)];
        }

        public bool CheckTheorem(Theorem Theorem)
        {
            Theorem xmlTheorem = getTheoremById(Theorem.Id);
            for(int i = 0; i < xmlTheorem.Intervals.Value.Count; i++)
                if (!xmlTheorem.Intervals.Value[i].Equals(Theorem.Intervals.Value[i]))
                    return false;
            for (int i = 0; i < xmlTheorem.Features.Value.Count; i++)
                if (!xmlTheorem.Features.Value[i].Equals(Theorem.Features.Value[i]))
                    return false;
            if (textDiff(xmlTheorem.Body, Theorem.Body) > 75)
                return false;
            return true;
        }

        private double textDiff(string str1, string str2)
        {
            double errors = 0;
            int strLen = str1.Length;
            for (int i = 0; i < strLen; i++)
                if (char.ToLower(str1[i]) != char.ToLower(str2[i]))
                    errors++;
            return (errors / strLen) * 100;
        }
    }
}
