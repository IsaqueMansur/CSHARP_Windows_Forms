namespace MaskedBox
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
            masked4Numbers = new MaskedTextBox();
            masked4Letters = new MaskedTextBox();
            maskDate = new MaskedTextBox();
            maskPlacesOfCars = new MaskedTextBox();
            maskPassword = new MaskedTextBox();
            BTN_Verify = new Button();
            SuspendLayout();
            // 
            // masked4Numbers
            // 
            masked4Numbers.Location = new Point(12, 12);
            masked4Numbers.Name = "masked4Numbers";
            masked4Numbers.Size = new Size(227, 23);
            masked4Numbers.TabIndex = 0;
            // 
            // masked4Letters
            // 
            masked4Letters.Location = new Point(12, 55);
            masked4Letters.Name = "masked4Letters";
            masked4Letters.Size = new Size(227, 23);
            masked4Letters.TabIndex = 1;
            masked4Letters.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // maskDate
            // 
            maskDate.Location = new Point(12, 96);
            maskDate.Name = "maskDate";
            maskDate.Size = new Size(227, 23);
            maskDate.TabIndex = 4;
            // 
            // maskPlacesOfCars
            // 
            maskPlacesOfCars.Location = new Point(12, 134);
            maskPlacesOfCars.Name = "maskPlacesOfCars";
            maskPlacesOfCars.Size = new Size(227, 23);
            maskPlacesOfCars.TabIndex = 6;
            // 
            // maskPassword
            // 
            maskPassword.Location = new Point(12, 174);
            maskPassword.Name = "maskPassword";
            maskPassword.Size = new Size(227, 23);
            maskPassword.TabIndex = 7;
            // 
            // BTN_Verify
            // 
            BTN_Verify.Location = new Point(164, 203);
            BTN_Verify.Name = "BTN_Verify";
            BTN_Verify.Size = new Size(75, 23);
            BTN_Verify.TabIndex = 8;
            BTN_Verify.Text = "Verifica";
            BTN_Verify.UseVisualStyleBackColor = true;
            BTN_Verify.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 234);
            Controls.Add(BTN_Verify);
            Controls.Add(maskPassword);
            Controls.Add(maskPlacesOfCars);
            Controls.Add(maskDate);
            Controls.Add(masked4Letters);
            Controls.Add(masked4Numbers);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox masked4Numbers;
        private MaskedTextBox masked4Letters;
        private MaskedTextBox maskDate;
        private MaskedTextBox maskPlacesOfCars;
        private MaskedTextBox maskPassword;
        private Button BTN_Verify;
    }
}