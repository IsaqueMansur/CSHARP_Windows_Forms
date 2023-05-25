namespace ProjetoCadastro
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
            FORM_MAIN = new TabControl();
            TAB_CADASTER_USER = new TabPage();
            BTN_CADASTER_USER = new Button();
            label1 = new Label();
            INPUT_NUMBERHOUSE_USER = new TextBox();
            INPUT_STREET_USER = new TextBox();
            INPUT_BIRTHDAY_USER = new MaskedTextBox();
            INPUT_DOC_USER = new MaskedTextBox();
            INPUT_NAME_USER = new TextBox();
            LABEL_NUMBER_OF_HOUSE_USER = new Label();
            LABEL_NAME_STREET_USER = new Label();
            LABEL_BIRTHDAY_USER = new Label();
            LABEL_DOC_USER = new Label();
            LABEL_NAME_USER = new Label();
            TAB_MOVIMENT_CADASTER_USER = new TabPage();
            BTN_FIND_USER_DOC = new Button();
            BTN_DELETE_USER = new Button();
            LABEL_NUMBERHOUSE_USER_MOV = new Label();
            LABEL_STREET_USER_MOV = new Label();
            LABEL_BIRTHDAY_USER_MOV = new Label();
            LABEL_NAME_USER_MOV = new Label();
            INPUT_FIND_USER_DOC = new MaskedTextBox();
            label8 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            FORM_MAIN.SuspendLayout();
            TAB_CADASTER_USER.SuspendLayout();
            TAB_MOVIMENT_CADASTER_USER.SuspendLayout();
            SuspendLayout();
            // 
            // FORM_MAIN
            // 
            FORM_MAIN.Controls.Add(TAB_CADASTER_USER);
            FORM_MAIN.Controls.Add(TAB_MOVIMENT_CADASTER_USER);
            FORM_MAIN.Dock = DockStyle.Fill;
            FORM_MAIN.Location = new Point(0, 0);
            FORM_MAIN.Margin = new Padding(0);
            FORM_MAIN.Name = "FORM_MAIN";
            FORM_MAIN.SelectedIndex = 0;
            FORM_MAIN.Size = new Size(564, 450);
            FORM_MAIN.TabIndex = 0;
            // 
            // TAB_CADASTER_USER
            // 
            TAB_CADASTER_USER.Controls.Add(BTN_CADASTER_USER);
            TAB_CADASTER_USER.Controls.Add(label1);
            TAB_CADASTER_USER.Controls.Add(INPUT_NUMBERHOUSE_USER);
            TAB_CADASTER_USER.Controls.Add(INPUT_STREET_USER);
            TAB_CADASTER_USER.Controls.Add(INPUT_BIRTHDAY_USER);
            TAB_CADASTER_USER.Controls.Add(INPUT_DOC_USER);
            TAB_CADASTER_USER.Controls.Add(INPUT_NAME_USER);
            TAB_CADASTER_USER.Controls.Add(LABEL_NUMBER_OF_HOUSE_USER);
            TAB_CADASTER_USER.Controls.Add(LABEL_NAME_STREET_USER);
            TAB_CADASTER_USER.Controls.Add(LABEL_BIRTHDAY_USER);
            TAB_CADASTER_USER.Controls.Add(LABEL_DOC_USER);
            TAB_CADASTER_USER.Controls.Add(LABEL_NAME_USER);
            TAB_CADASTER_USER.Location = new Point(4, 24);
            TAB_CADASTER_USER.Name = "TAB_CADASTER_USER";
            TAB_CADASTER_USER.Padding = new Padding(3);
            TAB_CADASTER_USER.Size = new Size(556, 422);
            TAB_CADASTER_USER.TabIndex = 0;
            TAB_CADASTER_USER.Text = "Cadastro";
            TAB_CADASTER_USER.UseVisualStyleBackColor = true;
            // 
            // BTN_CADASTER_USER
            // 
            BTN_CADASTER_USER.BackColor = Color.PaleGreen;
            BTN_CADASTER_USER.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_CADASTER_USER.Location = new Point(396, 303);
            BTN_CADASTER_USER.Name = "BTN_CADASTER_USER";
            BTN_CADASTER_USER.Size = new Size(125, 37);
            BTN_CADASTER_USER.TabIndex = 11;
            BTN_CADASTER_USER.Text = "Cadastrar";
            BTN_CADASTER_USER.UseVisualStyleBackColor = false;
            BTN_CADASTER_USER.Click += BTN_CADASTER_USER_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 44);
            label1.Name = "label1";
            label1.Size = new Size(133, 21);
            label1.TabIndex = 10;
            label1.Text = "Cadastrar usuário";
            // 
            // INPUT_NUMBERHOUSE_USER
            // 
            INPUT_NUMBERHOUSE_USER.Location = new Point(32, 274);
            INPUT_NUMBERHOUSE_USER.Name = "INPUT_NUMBERHOUSE_USER";
            INPUT_NUMBERHOUSE_USER.Size = new Size(489, 23);
            INPUT_NUMBERHOUSE_USER.TabIndex = 9;
            // 
            // INPUT_STREET_USER
            // 
            INPUT_STREET_USER.Location = new Point(32, 230);
            INPUT_STREET_USER.Name = "INPUT_STREET_USER";
            INPUT_STREET_USER.Size = new Size(489, 23);
            INPUT_STREET_USER.TabIndex = 8;
            // 
            // INPUT_BIRTHDAY_USER
            // 
            INPUT_BIRTHDAY_USER.Location = new Point(32, 186);
            INPUT_BIRTHDAY_USER.Mask = "00/00/0000";
            INPUT_BIRTHDAY_USER.Name = "INPUT_BIRTHDAY_USER";
            INPUT_BIRTHDAY_USER.Size = new Size(489, 23);
            INPUT_BIRTHDAY_USER.TabIndex = 7;
            // 
            // INPUT_DOC_USER
            // 
            INPUT_DOC_USER.Location = new Point(32, 142);
            INPUT_DOC_USER.Mask = "000,000,000-00";
            INPUT_DOC_USER.Name = "INPUT_DOC_USER";
            INPUT_DOC_USER.Size = new Size(489, 23);
            INPUT_DOC_USER.TabIndex = 6;
            // 
            // INPUT_NAME_USER
            // 
            INPUT_NAME_USER.Location = new Point(32, 98);
            INPUT_NAME_USER.Name = "INPUT_NAME_USER";
            INPUT_NAME_USER.Size = new Size(489, 23);
            INPUT_NAME_USER.TabIndex = 5;
            // 
            // LABEL_NUMBER_OF_HOUSE_USER
            // 
            LABEL_NUMBER_OF_HOUSE_USER.AutoSize = true;
            LABEL_NUMBER_OF_HOUSE_USER.Location = new Point(32, 256);
            LABEL_NUMBER_OF_HOUSE_USER.Name = "LABEL_NUMBER_OF_HOUSE_USER";
            LABEL_NUMBER_OF_HOUSE_USER.Size = new Size(93, 15);
            LABEL_NUMBER_OF_HOUSE_USER.TabIndex = 4;
            LABEL_NUMBER_OF_HOUSE_USER.Text = "Número da casa";
            // 
            // LABEL_NAME_STREET_USER
            // 
            LABEL_NAME_STREET_USER.AutoSize = true;
            LABEL_NAME_STREET_USER.Location = new Point(32, 212);
            LABEL_NAME_STREET_USER.Name = "LABEL_NAME_STREET_USER";
            LABEL_NAME_STREET_USER.Size = new Size(76, 15);
            LABEL_NAME_STREET_USER.TabIndex = 3;
            LABEL_NAME_STREET_USER.Text = "Nome da rua";
            // 
            // LABEL_BIRTHDAY_USER
            // 
            LABEL_BIRTHDAY_USER.AutoSize = true;
            LABEL_BIRTHDAY_USER.Location = new Point(32, 168);
            LABEL_BIRTHDAY_USER.Name = "LABEL_BIRTHDAY_USER";
            LABEL_BIRTHDAY_USER.Size = new Size(112, 15);
            LABEL_BIRTHDAY_USER.TabIndex = 2;
            LABEL_BIRTHDAY_USER.Text = "Data de nascimento";
            // 
            // LABEL_DOC_USER
            // 
            LABEL_DOC_USER.AutoSize = true;
            LABEL_DOC_USER.Location = new Point(32, 124);
            LABEL_DOC_USER.Name = "LABEL_DOC_USER";
            LABEL_DOC_USER.Size = new Size(165, 15);
            LABEL_DOC_USER.TabIndex = 1;
            LABEL_DOC_USER.Text = "Número do documento (CPF)";
            // 
            // LABEL_NAME_USER
            // 
            LABEL_NAME_USER.AutoSize = true;
            LABEL_NAME_USER.Location = new Point(32, 80);
            LABEL_NAME_USER.Name = "LABEL_NAME_USER";
            LABEL_NAME_USER.Size = new Size(94, 15);
            LABEL_NAME_USER.TabIndex = 0;
            LABEL_NAME_USER.Text = "Nome completo";
            // 
            // TAB_MOVIMENT_CADASTER_USER
            // 
            TAB_MOVIMENT_CADASTER_USER.Controls.Add(BTN_FIND_USER_DOC);
            TAB_MOVIMENT_CADASTER_USER.Controls.Add(BTN_DELETE_USER);
            TAB_MOVIMENT_CADASTER_USER.Controls.Add(LABEL_NUMBERHOUSE_USER_MOV);
            TAB_MOVIMENT_CADASTER_USER.Controls.Add(LABEL_STREET_USER_MOV);
            TAB_MOVIMENT_CADASTER_USER.Controls.Add(LABEL_BIRTHDAY_USER_MOV);
            TAB_MOVIMENT_CADASTER_USER.Controls.Add(LABEL_NAME_USER_MOV);
            TAB_MOVIMENT_CADASTER_USER.Controls.Add(INPUT_FIND_USER_DOC);
            TAB_MOVIMENT_CADASTER_USER.Controls.Add(label8);
            TAB_MOVIMENT_CADASTER_USER.Controls.Add(label2);
            TAB_MOVIMENT_CADASTER_USER.Controls.Add(label3);
            TAB_MOVIMENT_CADASTER_USER.Controls.Add(label4);
            TAB_MOVIMENT_CADASTER_USER.Controls.Add(label5);
            TAB_MOVIMENT_CADASTER_USER.Controls.Add(label6);
            TAB_MOVIMENT_CADASTER_USER.Location = new Point(4, 24);
            TAB_MOVIMENT_CADASTER_USER.Name = "TAB_MOVIMENT_CADASTER_USER";
            TAB_MOVIMENT_CADASTER_USER.Padding = new Padding(3);
            TAB_MOVIMENT_CADASTER_USER.Size = new Size(556, 422);
            TAB_MOVIMENT_CADASTER_USER.TabIndex = 1;
            TAB_MOVIMENT_CADASTER_USER.Text = "Movimentar";
            TAB_MOVIMENT_CADASTER_USER.UseVisualStyleBackColor = true;
            // 
            // BTN_FIND_USER_DOC
            // 
            BTN_FIND_USER_DOC.BackColor = SystemColors.GradientActiveCaption;
            BTN_FIND_USER_DOC.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_FIND_USER_DOC.Location = new Point(434, 117);
            BTN_FIND_USER_DOC.Name = "BTN_FIND_USER_DOC";
            BTN_FIND_USER_DOC.Size = new Size(94, 28);
            BTN_FIND_USER_DOC.TabIndex = 23;
            BTN_FIND_USER_DOC.Text = "Buscar";
            BTN_FIND_USER_DOC.UseVisualStyleBackColor = false;
            BTN_FIND_USER_DOC.Click += BTN_FIND_USER_DOC_Click;
            // 
            // BTN_DELETE_USER
            // 
            BTN_DELETE_USER.BackColor = Color.LightCoral;
            BTN_DELETE_USER.FlatAppearance.BorderSize = 0;
            BTN_DELETE_USER.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_DELETE_USER.Location = new Point(39, 353);
            BTN_DELETE_USER.Name = "BTN_DELETE_USER";
            BTN_DELETE_USER.Size = new Size(94, 36);
            BTN_DELETE_USER.TabIndex = 24;
            BTN_DELETE_USER.Text = "Deletar";
            BTN_DELETE_USER.UseVisualStyleBackColor = false;
            BTN_DELETE_USER.Click += BTN_DELETE_USER_Click;
            // 
            // LABEL_NUMBERHOUSE_USER_MOV
            // 
            LABEL_NUMBERHOUSE_USER_MOV.AutoSize = true;
            LABEL_NUMBERHOUSE_USER_MOV.Location = new Point(183, 302);
            LABEL_NUMBERHOUSE_USER_MOV.Name = "LABEL_NUMBERHOUSE_USER_MOV";
            LABEL_NUMBERHOUSE_USER_MOV.Size = new Size(12, 15);
            LABEL_NUMBERHOUSE_USER_MOV.TabIndex = 22;
            LABEL_NUMBERHOUSE_USER_MOV.Text = "-";
            // 
            // LABEL_STREET_USER_MOV
            // 
            LABEL_STREET_USER_MOV.AutoSize = true;
            LABEL_STREET_USER_MOV.Location = new Point(183, 258);
            LABEL_STREET_USER_MOV.Name = "LABEL_STREET_USER_MOV";
            LABEL_STREET_USER_MOV.Size = new Size(12, 15);
            LABEL_STREET_USER_MOV.TabIndex = 21;
            LABEL_STREET_USER_MOV.Text = "-";
            // 
            // LABEL_BIRTHDAY_USER_MOV
            // 
            LABEL_BIRTHDAY_USER_MOV.AutoSize = true;
            LABEL_BIRTHDAY_USER_MOV.Location = new Point(183, 215);
            LABEL_BIRTHDAY_USER_MOV.Name = "LABEL_BIRTHDAY_USER_MOV";
            LABEL_BIRTHDAY_USER_MOV.Size = new Size(12, 15);
            LABEL_BIRTHDAY_USER_MOV.TabIndex = 20;
            LABEL_BIRTHDAY_USER_MOV.Text = "-";
            // 
            // LABEL_NAME_USER_MOV
            // 
            LABEL_NAME_USER_MOV.AutoSize = true;
            LABEL_NAME_USER_MOV.Location = new Point(183, 172);
            LABEL_NAME_USER_MOV.Name = "LABEL_NAME_USER_MOV";
            LABEL_NAME_USER_MOV.Size = new Size(12, 15);
            LABEL_NAME_USER_MOV.TabIndex = 19;
            LABEL_NAME_USER_MOV.Text = "-";
            // 
            // INPUT_FIND_USER_DOC
            // 
            INPUT_FIND_USER_DOC.Location = new Point(39, 88);
            INPUT_FIND_USER_DOC.Mask = "000,000,000-00";
            INPUT_FIND_USER_DOC.Name = "INPUT_FIND_USER_DOC";
            INPUT_FIND_USER_DOC.Size = new Size(489, 23);
            INPUT_FIND_USER_DOC.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 70);
            label8.Name = "label8";
            label8.Size = new Size(165, 15);
            label8.TabIndex = 17;
            label8.Text = "Número do documento (CPF)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 26);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 16;
            label2.Text = "Encontrar usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 302);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 15;
            label3.Text = "Número da casa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 258);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 14;
            label4.Text = "Nome da rua";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 215);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 13;
            label5.Text = "Data de nascimento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 172);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 12;
            label6.Text = "Nome do usuário";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(564, 450);
            Controls.Add(FORM_MAIN);
            MaximumSize = new Size(580, 489);
            MinimumSize = new Size(580, 489);
            Name = "Form1";
            Text = "Form1";
            FORM_MAIN.ResumeLayout(false);
            TAB_CADASTER_USER.ResumeLayout(false);
            TAB_CADASTER_USER.PerformLayout();
            TAB_MOVIMENT_CADASTER_USER.ResumeLayout(false);
            TAB_MOVIMENT_CADASTER_USER.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl FORM_MAIN;
        private TabPage TAB_CADASTER_USER;
        private TabPage TAB_MOVIMENT_CADASTER_USER;
        private MaskedTextBox INPUT_BIRTHDAY_USER;
        private MaskedTextBox INPUT_DOC_USER;
        private TextBox INPUT_NAME_USER;
        private Label LABEL_NUMBER_OF_HOUSE_USER;
        private Label LABEL_NAME_STREET_USER;
        private Label LABEL_BIRTHDAY_USER;
        private Label LABEL_DOC_USER;
        private Label LABEL_NAME_USER;
        private Button BTN_CADASTER_USER;
        private Label label1;
        private TextBox INPUT_NUMBERHOUSE_USER;
        private TextBox INPUT_STREET_USER;
        private Label label8;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button BTN_FIND_USER_DOC;
        private Button BTN_DELETE_USER;
        private Label LABEL_NUMBERHOUSE_USER_MOV;
        private Label LABEL_STREET_USER_MOV;
        private Label LABEL_BIRTHDAY_USER_MOV;
        private Label LABEL_NAME_USER_MOV;
        private MaskedTextBox INPUT_FIND_USER_DOC;
    }
}