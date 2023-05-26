//using Microsoft.VisualBasic;

namespace SaveListToFile
{
    public class DataAccess<T> where T: new()
    {
        public event EventHandler<T> BadEntryFound;

        // Create a Generic Extension method
        public void SaveToCSV(List<T> items, string filePath)
        {
            List<string> rows = new List<string>();
            T entry = new T();
            // Get the type of objects it is and get the list of properties that
            // are on that type.
            // Introduction to reflection: System.Reflection.Property
            var cols = entry.GetType().GetProperties();

            // Add the Header row
            string row = "";
            foreach (var col in cols)
            {
                row += $",{col.Name}";
            }
            row = row.Substring(1);  //-- Example: FirstName,LastName,Email
            rows.Add(row);

            // Add the value rows
            foreach (var item in items)
            {
                row = "";
                bool badWordDetected = false;

                foreach (var col in cols)
                {
                    string val = col.GetValue(item, null).ToString();

                    badWordDetected = BadWordDetector(val);

                    if (badWordDetected == true)
                    {
                        BadEntryFound?.Invoke(this, item);
                        break;
                    }

                    row += $",{val}";
                }

                if (badWordDetected == false)
                {
                    row = row.Substring(1);
                    rows.Add(row);
                }
            }

            //File.WriteAllLines(string path, IEnumerable<string> contents)
            File.WriteAllLines(filePath, rows);
        }

        public bool BadWordDetector(string stringToTest)
        {
            bool output = false;
            string lowerCaseTest = stringToTest.ToLower();

            if (lowerCaseTest.Contains("darn") || lowerCaseTest.Contains("heck"))
            {
                output = true;
            }

            return output;
        }
    }
}
