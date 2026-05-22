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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            trackBar1 = new TrackBar();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            trackBar2 = new TrackBar();
            groupBox1 = new GroupBox();
            button7 = new Button();
            dateTimePicker1 = new DateTimePicker();
            splitter1 = new Splitter();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(0, 5);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 0;
            button1.Text = "Dead Inside";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(7, 5);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 1;
            button2.Text = "Awful";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(73, 5);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 2;
            button3.Text = "Bad";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(139, 5);
            button4.Name = "button4";
            button4.Size = new Size(60, 60);
            button4.TabIndex = 3;
            button4.Text = "Alright";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(205, 5);
            button5.Name = "button5";
            button5.Size = new Size(60, 60);
            button5.TabIndex = 4;
            button5.Text = "Good";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(271, 5);
            button6.Name = "button6";
            button6.Size = new Size(60, 60);
            button6.TabIndex = 5;
            button6.Text = "Great!";
            button6.UseVisualStyleBackColor = true;
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
            textBox1.Location = new Point(366, 333);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(407, 127);
            textBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(366, 30);
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
            label3.Location = new Point(366, 315);
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
            groupBox1.Location = new Point(366, 132);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 174);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // button7
            // 
            button7.Location = new Point(366, 479);
            button7.Name = "button7";
            button7.Size = new Size(407, 50);
            button7.TabIndex = 14;
            button7.Text = "Save Entry";
            button7.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(541, 30);
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
            // splitContainer1
            // 
            splitContainer1.Location = new Point(366, 65);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(button1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button6);
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Panel2.Controls.Add(button3);
            splitContainer1.Panel2.Controls.Add(button4);
            splitContainer1.Panel2.Controls.Add(button5);
            splitContainer1.Size = new Size(407, 70);
            splitContainer1.SplitterDistance = 65;
            splitContainer1.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 547);
            Controls.Add(splitContainer1);
            Controls.Add(splitter1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button7);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private TrackBar trackBar1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TrackBar trackBar2;
        private GroupBox groupBox1;
        private Button button7;
        private DateTimePicker dateTimePicker1;
        private Splitter splitter1;
        private SplitContainer splitContainer1;
    }
}
