// PlanForm.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class PlanForm : Form
    {
        private Form1 parentForm; // Reference to Form1
        private List<PlanItem> planItems;

        public PlanForm(List<string> plan, Form1 parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm; // Set the reference to Form1
            this.WindowState = FormWindowState.Maximized;

            // Create PlanItems from the plan strings
            planItems = new List<PlanItem>();
            foreach (string itemText in plan)
            {
                planItems.Add(new PlanItem { Text = itemText, IsChecked = false });
            }

            // Set up the CheckedListBox
            checkedListBoxPlan.DataSource = planItems;
            checkedListBoxPlan.DisplayMember = "Text";
            checkedListBoxPlan.ItemCheck += CheckedListBoxPlan_ItemCheck;

            // Display the total days and hours in the TextBox
            UpdateTotalDaysAndHours();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // Handle the back button click
            parentForm.Show(); // Show Form1
            this.Close(); // Close PlanForm
        }

        private void CheckedListBoxPlan_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Handle item check events
            planItems[e.Index].IsChecked = (e.NewValue == CheckState.Checked);

            // Update the total days and hours when an item is checked or unchecked
            UpdateTotalDaysAndHours();
        }

        private void UpdateTotalDaysAndHours()
        {
            int totalDays = 0;
            int totalHours = 0;

            foreach (PlanItem item in planItems)
            {
                totalDays++;
                totalHours += GetHoursToWorkFromItemText(item.Text);
            }

            textBoxTotalDaysHours.Text = $"Total Days: {totalDays}, Total Hours: {totalHours}";
        }

        private int GetHoursToWorkFromItemText(string itemText)
        {
            // Extract hours to work from the item text (assuming the format is "Work on {taskName} - Date: {currentDate.ToShortDateString()} - Hours to work: {hoursToWork}")
            int index = itemText.LastIndexOf("Hours to work:");
            if (index != -1)
            {
                string hoursSubstring = itemText.Substring(index + 14).Trim();
                int hoursToWork;
                if (int.TryParse(hoursSubstring, out hoursToWork))
                {
                    return hoursToWork;
                }
            }

            return 0;
        }

        private class PlanItem
        {
            public string Text { get; set; }
            public bool IsChecked { get; set; }
        }

        private void distributeHoursButton_Click(object sender, EventArgs e)
        {
            // Handle the button click to distribute hours evenly among selected days
            List<string> selectedDays = planItems.Where(item => item.IsChecked).Select(item => item.Text).ToList();

            if (selectedDays.Count == 0)
            {
                MessageBox.Show("Please select at least one day to distribute hours.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int totalHours = GetTotalHours();
            int hoursPerDay = totalHours / selectedDays.Count;

            if (hoursPerDay > 12)
            {
                MessageBox.Show("Each day cannot have more than 12 hours. Please select more days or go back to review your plan.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> distributionResult = DistributeHours(selectedDays, hoursPerDay);
            DisplayDistributionResult(distributionResult);

            
        }

        private void ShowSavedDaysForm(List<string> distributionResult)
        {
            SavedDaysForm savedDaysForm = new SavedDaysForm(distributionResult);

            // Add a button to open SavedDaysForm
            Button savedDaysButton = new Button
            {
                Text = "View Saved Days",
                Location = new System.Drawing.Point(10, 240),
                Size = new System.Drawing.Size(150, 30)
            };
            savedDaysButton.Click += (sender, e) => savedDaysForm.ShowDialog();
            savedDaysForm.Controls.Add(savedDaysButton);

            savedDaysForm.ShowDialog();
        }

        private void start_Click(object sender, EventArgs e)
        {
            // Trigger the distribution of hours when start is clicked
            List<string> selectedDays = planItems.Where(item => item.IsChecked).Select(item => item.Text).ToList();

            if (selectedDays.Count == 0)
            {
                MessageBox.Show("Please select at least one day to distribute hours.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int totalHours = GetTotalHours();
            int hoursPerDay = totalHours / selectedDays.Count;

            if (hoursPerDay > 12)
            {
                MessageBox.Show("Each day cannot have more than 12 hours. Please select more days or go back to review your plan.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> distributionResult = DistributeHours(selectedDays, hoursPerDay);
            DisplayDistributionResult(distributionResult);

            // Show the SavedDaysForm after distributing hours only when start is clicked
            SavedDaysForm savedDaysForm = new SavedDaysForm(distributionResult);
            savedDaysForm.ShowDialog();
        }

        private int GetTotalHours()
        {
            return planItems.Sum(item => GetHoursToWorkFromItemText(item.Text));
        }

        private List<string> DistributeHours(List<string> selectedDays, int hoursPerDay)
        {
            List<string> distributionResult = new List<string>();
            foreach (string day in selectedDays)
            {
                string distributedDay = $"{day} - Hours to Work: {hoursPerDay}";
                distributionResult.Add(distributedDay);
            }
            return distributionResult;
        }

        private void DisplayDistributionResult(List<string> distributionResult)
        {
            // Display the distribution result in a ListBox or any other desired way
            listBoxDistributionResult.Items.Clear();
            listBoxDistributionResult.Items.AddRange(distributionResult.ToArray());
        }

    }
}
