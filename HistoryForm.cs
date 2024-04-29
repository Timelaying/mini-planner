using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class HistoryForm : Form
    {
        private Form1 parentForm; // Reference to the parent Form1

        public HistoryForm()
        {
            InitializeComponent();

            // Set form properties for full-page display
            this.WindowState = FormWindowState.Maximized;
        }

        public void SetParentForm(Form1 form1)
        {
            parentForm = form1;
        }

        public void SetHistoryEntries(List<string> historyEntries)
        {

            for (int i = 0; i < historyEntries.Count; i++)
            {
                string numberedEntry = $"{i + 1}. {historyEntries[i]}"; // Prepend with the entry number
                historyListBox.Items.Add(numberedEntry);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // Close the HistoryForm and show the parent Form1
            this.Close();
            parentForm.Show();
        }

        private void ClearHistoryButton_Click(object sender, EventArgs e)
        {
            // Clear history entries
            historyListBox.Items.Clear();

            // Optionally, you can clear the history file as well
            ClearHistoryFile();
        }

        private void ClearHistoryFile()
        {
            // Delete the history file
            if (File.Exists(Form1.historyFileName))
            {
                File.Delete(Form1.historyFileName);
            }
        }
    }
}
