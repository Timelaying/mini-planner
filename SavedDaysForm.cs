using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CourseWork
{
    public partial class SavedDaysForm : Form
    {
        private List<string> savedDays;

        public SavedDaysForm(List<string> savedDays) //list of saved days
        {
            InitializeComponent();
            this.savedDays = savedDays;
            this.WindowState = FormWindowState.Maximized;


            // Add a CheckedListBox to display saved days            
            checkedListBoxSavedDays.Items.AddRange(savedDays.ToArray());
            Controls.Add(checkedListBoxSavedDays);

            // Add a Back button

            backButton.Click += BackButton_Click;
            Controls.Add(backButton);

            // Handle the ItemCheck event
            checkedListBoxSavedDays.ItemCheck += CheckedListBoxSavedDays_ItemCheck;

        }

        private void CheckedListBoxSavedDays_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Use e.NewValue to get the new state of the item
            int totalDays = savedDays.Count;
            int checkedDays = checkedListBoxSavedDays.CheckedItems.Count;

            // If the item is being checked, increase the count; otherwise, decrease
            checkedDays = e.NewValue == CheckState.Checked ? checkedDays + 1 : checkedDays - 1;

            // Calculate the progress percentage
            int progress = totalDays == 0 ? 0 : (int)((double)checkedDays / totalDays * 100);

            // Update the ProgressBar and Label
            progressBar.Value = progress;
            progressLabel.Text = $"{progress}%";
        }

        private void BackButton_Click(object sender, EventArgs e) =>
            // Handle the back button click
            this.Close(); // Close SavedDaysForm


    }
}
