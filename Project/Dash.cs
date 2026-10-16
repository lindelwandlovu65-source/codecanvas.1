using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Project
{
    /// <summary>Small helpers shared by the logged-in pages. The visual design lives in the *.Designer.cs files.</summary>
    internal static class Dash
    {
        public static void LogOut(Form form)
        {
            Session.End();
            form.Hide();
            new frmHome().Show();
        }

        /// <summary>The logged-in user's rows from a file (first column = email), newest first.</summary>
        public static List<string[]> MyRows(string file, int minColumns)
        {
            List<string[]> mine = new List<string[]>();
            foreach (string[] r in DataStore.Read(file))
            {
                if (r.Length >= minColumns && string.Equals(r[0], Session.Email, StringComparison.OrdinalIgnoreCase))
                {
                    mine.Add(r);
                }
            }
            mine.Reverse();
            return mine;
        }

        /// <summary>Fills the list, or shows the "nothing yet" label in its place when there are no rows.</summary>
        public static void ShowRows(ListView list, Label empty, List<string[]> rows)
        {
            list.Items.Clear();
            foreach (string[] r in rows)
            {
                ListViewItem item = new ListViewItem(r[0]);
                for (int i = 1; i < r.Length; i++)
                {
                    item.SubItems.Add(r[i]);
                }
                list.Items.Add(item);
            }
            list.Visible = rows.Count > 0;
            empty.Visible = rows.Count == 0;
        }

        public static string ShortDate(string iso)
        {
            DateTime d;
            if (DateTime.TryParse(iso, CultureInfo.InvariantCulture, DateTimeStyles.None, out d))
            {
                return d.ToString("dd MMM yyyy", CultureInfo.InvariantCulture);
            }
            return iso;
        }

        /// <summary>Whole rand with thousands separators, e.g. R1,250.</summary>
        public static string Rand(long amount)
        {
            return "R" + amount.ToString("N0", CultureInfo.InvariantCulture);
        }

        public static bool PositiveInt(string text, int max, out int value)
        {
            return int.TryParse(text.Trim(), out value) && value > 0 && value <= max;
        }
    }
}
