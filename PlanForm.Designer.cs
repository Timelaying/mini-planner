namespace CourseWork
{
    partial class PlanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanForm));
            checkedListBoxPlan = new CheckedListBox();
            textBoxTotalDaysHours = new TextBox();
            listBoxDistributionResult = new ListBox();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // checkedListBoxPlan
            // 
            checkedListBoxPlan.FormattingEnabled = true;
            checkedListBoxPlan.Location = new Point(60, 33);
            checkedListBoxPlan.Name = "checkedListBoxPlan";
            checkedListBoxPlan.Size = new Size(536, 292);
            checkedListBoxPlan.TabIndex = 0;
            // 
            // textBoxTotalDaysHours
            // 
            textBoxTotalDaysHours.Location = new Point(60, 331);
            textBoxTotalDaysHours.Name = "textBoxTotalDaysHours";
            textBoxTotalDaysHours.Size = new Size(197, 23);
            textBoxTotalDaysHours.TabIndex = 1;
            // 
            // listBoxDistributionResult
            // 
            listBoxDistributionResult.FormattingEnabled = true;
            listBoxDistributionResult.ItemHeight = 15;
            listBoxDistributionResult.Location = new Point(614, 32);
            listBoxDistributionResult.Name = "listBoxDistributionResult";
            listBoxDistributionResult.Size = new Size(371, 289);
            listBoxDistributionResult.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(337, 334);
            button1.Name = "button1";
            button1.Size = new Size(117, 23);
            button1.TabIndex = 3;
            button1.Text = "Rework";
            button1.UseVisualStyleBackColor = true;
            button1.Click += distributeHoursButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 9);
            label1.Name = "label1";
            label1.Size = new Size(179, 15);
            label1.TabIndex = 4;
            label1.Text = "Select Your Avaliabilty to Rework";
            // 
            // button2
            // 
            button2.Location = new Point(640, 331);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BackButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(853, 330);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Start";
            button3.UseVisualStyleBackColor = true;
            button3.Click += start_Click;
            // 
            // PlanForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 358);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listBoxDistributionResult);
            Controls.Add(textBoxTotalDaysHours);
            Controls.Add(checkedListBoxPlan);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PlanForm";
            Text = "PlanForm";
            Click += start_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBoxPlan;
        private TextBox textBoxTotalDaysHours;
        private ListBox listBoxDistributionResult;
        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
    }
}