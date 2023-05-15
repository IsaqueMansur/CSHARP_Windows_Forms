namespace TextBox_RichTextBox
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
            TXT_INPUT = new TextBox();
            RTXT_Inverted = new RichTextBox();
            BTN_invert = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TXT_INPUT
            // 
            TXT_INPUT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TXT_INPUT.BorderStyle = BorderStyle.None;
            TXT_INPUT.Location = new Point(3, 3);
            TXT_INPUT.Name = "TXT_INPUT";
            TXT_INPUT.Size = new Size(318, 16);
            TXT_INPUT.TabIndex = 0;
            // 
            // RTXT_Inverted
            // 
            RTXT_Inverted.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            RTXT_Inverted.BorderStyle = BorderStyle.None;
            RTXT_Inverted.Location = new Point(3, 185);
            RTXT_Inverted.Name = "RTXT_Inverted";
            RTXT_Inverted.Size = new Size(318, 177);
            RTXT_Inverted.TabIndex = 1;
            RTXT_Inverted.Text = "";
            // 
            // BTN_invert
            // 
            BTN_invert.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BTN_invert.BackColor = Color.DodgerBlue;
            BTN_invert.FlatAppearance.BorderColor = Color.White;
            BTN_invert.FlatAppearance.BorderSize = 0;
            BTN_invert.FlatStyle = FlatStyle.Flat;
            BTN_invert.ForeColor = SystemColors.ButtonHighlight;
            BTN_invert.Location = new Point(327, 323);
            BTN_invert.Name = "BTN_invert";
            BTN_invert.Size = new Size(165, 39);
            BTN_invert.TabIndex = 2;
            BTN_invert.Text = "Inverter";
            BTN_invert.UseVisualStyleBackColor = false;
            BTN_invert.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(TXT_INPUT, 0, 0);
            tableLayoutPanel1.Controls.Add(RTXT_Inverted, 0, 1);
            tableLayoutPanel1.Controls.Add(BTN_invert, 1, 1);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(649, 365);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(647, 365);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TXT_INPUT;
        private RichTextBox RTXT_Inverted;
        private Button BTN_invert;
        private TableLayoutPanel tableLayoutPanel1;
    }
}