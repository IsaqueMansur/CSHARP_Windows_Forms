namespace TelaDeLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            userInput = new TextBox();
            passwordInput = new MaskedTextBox();
            BTN_login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(84, 20);
            label1.Name = "label1";
            label1.Size = new Size(141, 28);
            label1.TabIndex = 0;
            label1.Text = "Área de acesso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 129);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // userInput
            // 
            userInput.Location = new Point(12, 79);
            userInput.Name = "userInput";
            userInput.Size = new Size(274, 23);
            userInput.TabIndex = 3;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(12, 147);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '*';
            passwordInput.Size = new Size(274, 23);
            passwordInput.TabIndex = 4;
            // 
            // BTN_login
            // 
            BTN_login.BackColor = Color.LightGreen;
            BTN_login.FlatAppearance.BorderColor = Color.White;
            BTN_login.FlatAppearance.BorderSize = 0;
            BTN_login.Location = new Point(145, 194);
            BTN_login.Name = "BTN_login";
            BTN_login.Size = new Size(141, 32);
            BTN_login.TabIndex = 5;
            BTN_login.Text = "Acessar";
            BTN_login.UseVisualStyleBackColor = false;
            BTN_login.Click += BTN_login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 248);
            Controls.Add(BTN_login);
            Controls.Add(passwordInput);
            Controls.Add(userInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Acessar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox userInput;
        private MaskedTextBox passwordInput;
        private Button BTN_login;
    }
}