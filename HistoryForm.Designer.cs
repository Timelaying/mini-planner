namespace CourseWork
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            historyListBox = new ListBox();
            panel1 = new Panel();
            panelmenu = new Panel();
            button1 = new Button();
            button2 = new Button();
            panelmenu.SuspendLayout();
            SuspendLayout();
            // 
            // historyListBox
            // 
            historyListBox.FormattingEnabled = true;
            historyListBox.ItemHeight = 15;
            historyListBox.Location = new Point(206, 6);
            historyListBox.Name = "historyListBox";
            historyListBox.Size = new Size(582, 244);
            historyListBox.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 110);
            panel1.TabIndex = 1;
            // 
            // panelmenu
            // 
            panelmenu.BackColor = SystemColors.InactiveCaption;
            panelmenu.Controls.Add(button1);
            panelmenu.Controls.Add(panel1);
            panelmenu.Dock = DockStyle.Left;
            panelmenu.Location = new Point(0, 0);
            panelmenu.Name = "panelmenu";
            panelmenu.Size = new Size(200, 476);
            panelmenu.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(0, 116);
            button1.Name = "button1";
            button1.Size = new Size(200, 37);
            button1.TabIndex = 1;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BackButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(206, 256);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ClearHistoryButton_Click;
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 476);
            Controls.Add(button2);
            Controls.Add(panelmenu);
            Controls.Add(historyListBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HistoryForm";
            Text = "HistoryForm";
            panelmenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox historyListBox;
        private Panel panel1;
        private Panel panelmenu;
        private Button button1;
        private Button button2;
    }
}