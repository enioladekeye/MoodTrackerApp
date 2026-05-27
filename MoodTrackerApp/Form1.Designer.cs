namespace MoodTrackerApp
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
            numStress = new TrackBar();
            txtNotes = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numEnergy = new TrackBar();
            groupBox1 = new GroupBox();
            btnSave = new Button();
            dateTimePicker1 = new DateTimePicker();
            splitter1 = new Splitter();
            btnMood4 = new Button();
            btnMood3 = new Button();
            btnMood2 = new Button();
            btnMood1 = new Button();
            btnMood5 = new Button();
            btnMood0 = new Button();
            panel1 = new Panel();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numStress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEnergy).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // numStress
            // 
            numStress.LargeChange = 3;
            numStress.Location = new Point(17, 48);
            numStress.Maximum = 9;
            numStress.Name = "numStress";
            numStress.Size = new Size(352, 45);
            numStress.TabIndex = 6;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(13, 314);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(407, 127);
            txtNotes.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 8;
            label1.Text = "How are you feeling?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(17, 30);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 9;
            label2.Text = "Stress";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(13, 296);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 10;
            label3.Text = "Notes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(17, 91);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 12;
            label4.Text = "Energy";
            // 
            // numEnergy
            // 
            numEnergy.LargeChange = 3;
            numEnergy.Location = new Point(17, 109);
            numEnergy.Maximum = 9;
            numEnergy.Name = "numEnergy";
            numEnergy.Size = new Size(352, 45);
            numEnergy.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numStress);
            groupBox1.Controls.Add(numEnergy);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(13, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 174);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(13, 460);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(407, 50);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save Entry";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(188, 11);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(232, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 547);
            splitter1.TabIndex = 16;
            splitter1.TabStop = false;
            // 
            // btnMood4
            // 
            btnMood4.Location = new Point(294, 47);
            btnMood4.Name = "btnMood4";
            btnMood4.Size = new Size(60, 60);
            btnMood4.TabIndex = 4;
            btnMood4.Text = "Good";
            btnMood4.UseVisualStyleBackColor = true;
            // 
            // btnMood3
            // 
            btnMood3.Location = new Point(228, 47);
            btnMood3.Name = "btnMood3";
            btnMood3.Size = new Size(60, 60);
            btnMood3.TabIndex = 3;
            btnMood3.Text = "Alright";
            btnMood3.UseVisualStyleBackColor = true;
            // 
            // btnMood2
            // 
            btnMood2.Location = new Point(162, 47);
            btnMood2.Name = "btnMood2";
            btnMood2.Size = new Size(60, 60);
            btnMood2.TabIndex = 2;
            btnMood2.Text = "Bad";
            btnMood2.UseVisualStyleBackColor = true;
            // 
            // btnMood1
            // 
            btnMood1.Location = new Point(96, 47);
            btnMood1.Name = "btnMood1";
            btnMood1.Size = new Size(60, 60);
            btnMood1.TabIndex = 1;
            btnMood1.Text = "Awful";
            btnMood1.UseVisualStyleBackColor = true;
            btnMood1.Click += btnMood1_Click;
            // 
            // btnMood5
            // 
            btnMood5.Location = new Point(360, 47);
            btnMood5.Name = "btnMood5";
            btnMood5.Size = new Size(60, 60);
            btnMood5.TabIndex = 5;
            btnMood5.Text = "Great!";
            btnMood5.UseVisualStyleBackColor = true;
            // 
            // btnMood0
            // 
            btnMood0.Location = new Point(13, 47);
            btnMood0.Name = "btnMood0";
            btnMood0.Size = new Size(60, 60);
            btnMood0.TabIndex = 0;
            btnMood0.Text = "Dead Inside";
            btnMood0.UseVisualStyleBackColor = true;
            btnMood0.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnMood0);
            panel1.Controls.Add(txtNotes);
            panel1.Controls.Add(btnMood5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnMood1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnMood2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnMood4);
            panel1.Controls.Add(btnMood3);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Location = new Point(202, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 523);
            panel1.TabIndex = 17;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(172, 514);
            listBox1.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 547);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(splitter1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numStress).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEnergy).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TrackBar numStress;
        private TextBox txtNotes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TrackBar numEnergy;
        private GroupBox groupBox1;
        private Button btnSave;
        private DateTimePicker dateTimePicker1;
        private Splitter splitter1;
        private Button btnMood4;
        private Button btnMood3;
        private Button btnMood2;
        private Button btnMood1;
        private Button btnMood5;
        private Button btnMood0;
        private Panel panel1;
        private ListBox listBox1;
    }
}
