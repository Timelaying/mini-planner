// Form1.cs
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Form1 : Form
    {
        public const string historyFileName = "task_history.txt";
        private const string tasksFileName = "tasks.txt";
        private List<string> tasksList = new List<string>(); // Maintain a list of tasks

        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
            InitializeComboBox2();
            LoadTasksFromFile(); // Load tasks from the file when the application starts

            // Set form properties for full-page display
            this.WindowState = FormWindowState.Maximized;
        }

        private void InitializeComboBox2()
        {
            // Add options to the ComboBox
            comboBoxRating2.Items.Add("Relaxed");
            comboBoxRating2.Items.Add("Flexible");
            comboBoxRating2.Items.Add("Serious");

            // Set the default selection
            comboBoxRating2.SelectedIndex = 0;
        }

        private void InitializeComboBox()
        {
            // Add options to the ComboBox
            comboBoxRating.Items.Add("Easy");
            comboBoxRating.Items.Add("Average");
            comboBoxRating.Items.Add("Bad");

            // Set the default selection
            comboBoxRating.SelectedIndex = 0;
        }

        // Add Button
        private void AddButton_Click(object sender, EventArgs e)
        {
            string taskName = textBox1.Text;
            DateTime deadline = dateTimePicker2.Value;
            DateTime startdate = dateTimePicker1.Value;
            string difficulty = comboBoxRating.SelectedItem?.ToString(); // Get selected difficulty
            string mode = comboBoxRating2.SelectedItem?.ToString(); // Get selected mode

            if (string.IsNullOrEmpty(taskName))
            {
                MessageBox.Show("Please enter a task name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (IsTaskAlreadyAdded(taskName))
            {
                MessageBox.Show("This task is already added.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int daysDifference = (int)(deadline - startdate).TotalDays; // Calculate the number of days

                string taskDetails = $"{taskName} - Start line: {startdate.ToShortDateString()} - Deadline: {deadline.ToShortDateString()} - Days Difference: {daysDifference} days - Difficulty: {difficulty} - Mode: {mode}";
                listBox1.Items.Add(taskDetails);

                // Save the entry to history file
                SaveEntryToHistory(taskDetails);

                // Add the task to the list to check for duplicates
                tasksList.Add(taskDetails);

                textBox1.Clear();
                dateTimePicker2.Value = DateTime.Now;

                SaveTasksToFile(); // Save tasks to the file after adding a new task
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedTask = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(selectedTask);
                // Update the tasksList by removing the deleted task
                tasksList.Remove(selectedTask);
                SaveTasksToFile(); // Save tasks to the file after deleting a task
            }
            else
            {
                MessageBox.Show("Please select a task to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PlanButton_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the ListBox
            if (listBox1.SelectedItem != null)
            {
                string selectedTask = listBox1.SelectedItem.ToString();
                string[] taskDetails = selectedTask.Split(new[] { " - " }, StringSplitOptions.None);

                // Extract task name, start date, and deadline from the selected item
                string taskName = taskDetails[0];
                DateTime startDate = DateTime.Parse(taskDetails[1].Split(':')[1].Trim());
                DateTime deadline = DateTime.Parse(taskDetails[2].Split(':')[1].Trim().Split('\n')[0].Trim());
                string difficulty = taskDetails[3].Split(':')[1].Trim(); // Extract difficulty

                // Check if there is a fifth element before attempting to access it
                string mode = taskDetails.Length > 4 ? taskDetails[4].Split(':')[1].Trim() : "Default Mode";

                int daysDifference = (int)(deadline - startDate).TotalDays; // Calculate the number of days

                List<string> plan = GeneratePlan(taskName, startDate, deadline, daysDifference, difficulty, mode);
                DisplayPlan(plan);
            }
            else
            {
                MessageBox.Show("Please select a task from the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private List<string> GeneratePlan(string taskName, DateTime startDate, DateTime deadline, int daysDifference, string difficulty, string mode)
        {
            int workFrequencyDays;

            if (daysDifference >= 30)
            {
                workFrequencyDays = 5;
            }
            else if (daysDifference >= 15)
            {
                workFrequencyDays = 3;
            }
            else
            {
                workFrequencyDays = 2;
            }

            int additionalDaysToWork = 0;

            // Adjust additional days based on difficulty
            if (difficulty == "Easy")
            {
                additionalDaysToWork = new Random().Next(0, 3); // 0 to 2 additional days for "Easy"
            }
            else if (difficulty == "Average")
            {
                additionalDaysToWork = new Random().Next(0, 2); // 0 to 1 additional day for "Average"
            }

            int hoursToWork = GetHoursToWork(mode);

            List<string> plan = GenerateWorkPlan(taskName, startDate, deadline, workFrequencyDays, additionalDaysToWork, hoursToWork);

            return plan;
        }

        private int GetHoursToWork(string mode)
        {
            switch (mode)
            {
                case "Relaxed":
                    return 1;
                case "Flexible":
                    return 2;
                case "Serious":
                    return 3;
                default:
                    return 2; // Default to 2 hours for unspecified modes
            }
        }

        private List<string> GenerateWorkPlan(string taskName, DateTime startDate, DateTime deadline, int workFrequencyDays, int additionalDays, int hoursToWork)
        {
            List<string> plan = new List<string>();
            DateTime currentDate = startDate;

            while (currentDate < deadline)
            {
                plan.Add($"Work on {taskName} - Date: {currentDate.ToShortDateString()} - Hours to work: {hoursToWork}");
                currentDate = currentDate.AddDays(workFrequencyDays + additionalDays);
            }

            return plan;
        }

        private void DisplayPlan(List<string> plan)
        {
            PlanForm planForm = new PlanForm(plan, this); // Pass 'this' as the parentForm
            planForm.ShowDialog();
        }

        // History
        private void HistoryButton_Click(object sender, EventArgs e)
        {
            // Show the history in a new form
            HistoryForm historyForm = new HistoryForm();
            historyForm.SetParentForm(this); // Set reference to Form1
            historyForm.SetHistoryEntries(ReadHistory());
            historyForm.ShowDialog();
        }

        private void SaveEntryToHistory(string entry)
        {
            // Append the entry to the history file
            File.AppendAllText(historyFileName, entry);
        }

        private List<string> ReadHistory()
        {
            // Read entries from the history file
            List<string> historyEntries = new List<string>();
            if (File.Exists(historyFileName))
            {
                historyEntries.AddRange(File.ReadAllLines(historyFileName));
            }
            return historyEntries;
        }

        private bool IsTaskAlreadyAdded(string taskName)
        {
            // Check if the task is already added
            return tasksList.Any(task => task.Equals(taskName, StringComparison.OrdinalIgnoreCase));
        }

        private void SaveTasksToFile()
        {
            // Save tasks to the file
            File.WriteAllLines(tasksFileName, tasksList);
        }

        private void LoadTasksFromFile()
        {
            // Load tasks from the file
            if (File.Exists(tasksFileName))
            {
                tasksList.AddRange(File.ReadAllLines(tasksFileName));
                listBox1.Items.AddRange(tasksList.ToArray());
            }
        }


    }
}
