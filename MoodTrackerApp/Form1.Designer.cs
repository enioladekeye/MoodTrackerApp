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
            trackBar1 = new TrackBar();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            trackBar2 = new TrackBar();
            groupBox1 = new GroupBox();
            btnSave = new Button();
            dateTimePicker1 = new DateTimePicker();
            splitter1 = new Splitter();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button6 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 3;
            trackBar1.Location = new Point(17, 48);
            trackBar1.Maximum = 9;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(352, 45);
            trackBar1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 314);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(407, 127);
            textBox1.TabIndex = 7;
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
            // trackBar2
            // 
            trackBar2.LargeChange = 3;
            trackBar2.Location = new Point(17, 109);
            trackBar2.Maximum = 9;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(352, 45);
            trackBar2.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(trackBar1);
            groupBox1.Controls.Add(trackBar2);
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
            // button5
            // 
            button5.Location = new Point(294, 47);
            button5.Name = "button5";
            button5.Size = new Size(60, 60);
            button5.TabIndex = 4;
            button5.Text = "Good";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(228, 47);
            button4.Name = "button4";
            button4.Size = new Size(60, 60);
            button4.TabIndex = 3;
            button4.Text = "Alright";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(162, 47);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 2;
            button3.Text = "Bad";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(96, 47);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 1;
            button2.Text = "Awful";
            button2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(360, 47);
            button6.Name = "button6";
            button6.Size = new Size(60, 60);
            button6.TabIndex = 5;
            button6.Text = "Great!";
            button6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(13, 47);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 0;
            button1.Text = "Dead Inside";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
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
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TrackBar trackBar1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TrackBar trackBar2;
        private GroupBox groupBox1;
        private Button btnSave;
        private DateTimePicker dateTimePicker1;
        private Splitter splitter1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button6;
        private Button button1;
        private Panel panel1;
        private ListBox listBox1;
    }
}
