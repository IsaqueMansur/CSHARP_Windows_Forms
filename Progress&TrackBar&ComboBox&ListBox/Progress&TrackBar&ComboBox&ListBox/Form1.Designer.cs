namespace Progress_TrackBar_ComboBox_ListBox
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
            trackBar = new TrackBar();
            progressBar = new ProgressBar();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label = new Label();
            listBox1 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar).BeginInit();
            SuspendLayout();
            // 
            // trackBar
            // 
            trackBar.Location = new Point(153, 12);
            trackBar.Maximum = 100;
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(356, 45);
            trackBar.TabIndex = 0;
            trackBar.ValueChanged += trackBar_ValueChanged;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(153, 63);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(356, 23);
            progressBar.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ednaldo Pereira", "Daniel Orivaldo", "Jailson Mendes", "Chico Bioca" });
            comboBox1.Location = new Point(12, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // button1
            // 
            button1.Location = new Point(58, 63);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Gerar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(515, 22);
            label.Name = "label";
            label.Size = new Size(74, 15);
            label.TabIndex = 4;
            label.Text = "Valor atual: 0";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Bolo" });
            listBox1.Location = new Point(12, 180);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(206, 79);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(143, 278);
            button2.Name = "button2";
            button2.Size = new Size(75, 41);
            button2.TabIndex = 6;
            button2.Text = "Remover animal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 278);
            button3.Name = "button3";
            button3.Size = new Size(75, 41);
            button3.TabIndex = 7;
            button3.Text = "Adicionar  animal";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(label);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(progressBar);
            Controls.Add(trackBar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar;
        private ProgressBar progressBar;
        private ComboBox comboBox1;
        private Button button1;
        private Label label;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
    }
}