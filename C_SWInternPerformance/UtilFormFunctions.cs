using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_SWInternPerformance
{
    public static class UtilFormFunctions
    {
        // Check for duplicate before adding string entry to a combobox.
        public static void AddUnique(ComboBox comboBox, string entry)
        {
            if (!comboBox.Items.Contains(entry))
                comboBox.Items.Add(entry);
        }

        // Check if combobox elements contain a string.
        public static bool BoxContain (ComboBox comboBox, string text)
        {
            
            foreach(var item in comboBox.Items)
            {
                string itemtxt = comboBox.GetItemText(item);
                if (itemtxt.Equals(text))
                    return true;
            }
            return false;
        }
        // same for a list box.
        public static bool BoxContain(ListBox comboBox, string text)
        {
            
            foreach (var item in comboBox.Items)
            {
                string itemtxt = comboBox.GetItemText(item);
                if (itemtxt.Equals(text))
                    return true;
            }
            return false;
        }
    }
}
