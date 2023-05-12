namespace EventosEInformacoes
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
            confimationBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // confimationBtn
            // 
            confimationBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            confimationBtn.AutoSize = true;
            confimationBtn.BackColor = Color.PaleGreen;
            confimationBtn.Location = new Point(686, 412);
            confimationBtn.Name = "confimationBtn";
            confimationBtn.Size = new Size(102, 32);
            confimationBtn.TabIndex = 0;
            confimationBtn.Text = "Confirm Box";
            confimationBtn.UseVisualStyleBackColor = false;
            confimationBtn.Click += confimationBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(686, 394);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Confirmar";
            label1.MouseClick += label1_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(confimationBtn);
            MinimumSize = new Size(200, 200);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button confimationBtn;
        private Label label1;
    }
}