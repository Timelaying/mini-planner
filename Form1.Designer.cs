namespace CourseWork
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelmenu = new Panel();
            dateTimePicker2 = new DateTimePicker();
            comboBoxRating2 = new ComboBox();
            label4 = new Label();
            comboBoxRating = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label5 = new Label();
            panelmenu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelmenu
            // 
            panelmenu.BackColor = SystemColors.InactiveCaption;
            panelmenu.Controls.Add(label2);
            panelmenu.Controls.Add(dateTimePicker2);
            panelmenu.Controls.Add(comboBoxRating2);
            panelmenu.Controls.Add(label4);
            panelmenu.Controls.Add(comboBoxRating);
            panelmenu.Controls.Add(label3);
            panelmenu.Controls.Add(button1);
            panelmenu.Controls.Add(panel1);
            panelmenu.Dock = DockStyle.Left;
            panelmenu.Location = new Point(0, 0);
            panelmenu.Name = "panelmenu";
            panelmenu.Size = new Size(200, 416);
            panelmenu.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(0, 128);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 2;
            // 
            // comboBoxRating2
            // 
            comboBoxRating2.FormattingEnabled = true;
            comboBoxRating2.Location = new Point(3, 235);
            comboBoxRating2.Name = "comboBoxRating2";
            comboBoxRating2.Size = new Size(121, 23);
            comboBoxRating2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 217);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 4;
            label4.Text = "Mode";
            // 
            // comboBoxRating
            // 
            comboBoxRating.FormattingEnabled = true;
            comboBoxRating.Location = new Point(0, 181);
            comboBoxRating.Name = "comboBoxRating";
            comboBoxRating.Size = new Size(121, 23);
            comboBoxRating.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 163);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 2;
            label3.Text = "Course Difficulty";
            // 
            // button1
            // 
            button1.Location = new Point(3, 264);
            button1.Name = "button1";
            button1.Size = new Size(200, 37);
            button1.TabIndex = 1;
            button1.Text = "Add Task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 110);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 110);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Deadline";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(0, 74);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 56);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 2;
            label1.Text = "From";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "hu";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(206, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(666, 349);
            listBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(878, 3);
            button2.Name = "button2";
            button2.Size = new Size(89, 28);
            button2.TabIndex = 2;
            button2.Text = "History";
            button2.UseVisualStyleBackColor = true;
            button2.Click += HistoryButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(206, 355);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Plan Task";
            button3.UseVisualStyleBackColor = true;
            button3.Click += PlanButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(366, 355);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "Delete Task";
            button4.UseVisualStyleBackColor = true;
            button4.Click += DeleteButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 3);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 3;
            label5.Text = "Course Title";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(968, 416);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(panelmenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Course Planner";
            panelmenu.ResumeLayout(false);
            panelmenu.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelmenu;
        private Panel panel1;
        private Button button1;
        private TextBox textBox1;
        private ListBox listBox1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private Button button2;
        private Button button3;
        private Label label3;
        private ComboBox comboBoxRating;
        private ComboBox comboBoxRating2;
        private Label label4;
        private Button button4;
        private Label label5;
    }
}