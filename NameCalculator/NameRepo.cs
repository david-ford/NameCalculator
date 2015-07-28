using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NameCalculator
{
    public class NameRepo
    {
        // Read the txt file and convert it to a list.
        // Sort was not applied here since that is logic that
        // manipulates the data, and we may not always want
        // a sorted list when looking up this data.
        // Replace was used to strip quotes, since all we care about
        // Is the characters in the name.
        public static List<string> ReadNameList (string file)
        {
            return File.ReadAllText(@file).Replace("\"", "").Split(',').ToList();
        }
    }
}