namespace CourseWork
{
    partial class SavedDaysForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavedDaysForm));
            checkedListBoxSavedDays = new CheckedListBox();
            backButton = new Button();
            label1 = new Label();
            progressBar = new ProgressBar();
            progressLabel = new Label();
            SuspendLayout();
            // 
            // checkedListBoxSavedDays
            // 
            checkedListBoxSavedDays.FormattingEnabled = true;
            checkedListBoxSavedDays.Location = new Point(12, 12);
            checkedListBoxSavedDays.Name = "checkedListBoxSavedDays";
            checkedListBoxSavedDays.Size = new Size(753, 310);
            checkedListBoxSavedDays.TabIndex = 0;
            checkedListBoxSavedDays.ItemCheck += CheckedListBoxSavedDays_ItemCheck;
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 334);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 1;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += BackButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 371);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 2;
            label1.Text = "Progress";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 400);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(100, 23);
            progressBar.TabIndex = 3;
            // 
            // progressLabel
            // 
            progressLabel.AutoSize = true;
            progressLabel.Location = new Point(12, 426);
            progressLabel.Name = "progressLabel";
            progressLabel.Size = new Size(38, 15);
            progressLabel.TabIndex = 4;
            progressLabel.Text = "label2";
            // 
            // SavedDaysForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressLabel);
            Controls.Add(progressBar);
            Controls.Add(label1);
            Controls.Add(backButton);
            Controls.Add(checkedListBoxSavedDays);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SavedDaysForm";
            Text = "SavedDaysForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBoxSavedDays;
        private Button backButton;
        private Label label1;
        private ProgressBar progressBar;
        private Label progressLabel;
    }
}