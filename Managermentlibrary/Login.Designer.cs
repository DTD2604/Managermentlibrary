namespace Managermentlibrary
{
    partial class Login
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
            label1 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            dateTimeBirthDay = new DateTimePicker();
            bSignUp = new Button();
            txPasswordSignUp = new TextBox();
            lPasswordSignUp = new Label();
            lBirthDaySignUp = new Label();
            txPhoneSignUp = new TextBox();
            lPhoneSignUp = new Label();
            txEmailSignUp = new TextBox();
            lEmailSignUp = new Label();
            txNameSignUp = new TextBox();
            txUserNameSignUp = new TextBox();
            lNameSignUp = new Label();
            lUserNameSignUp = new Label();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            bSignIn = new Button();
            likRegister = new LinkLabel();
            txpasswordSignIn = new TextBox();
            txUserNameSignIn = new TextBox();
            label7 = new Label();
            lForgotPassword = new Label();
            lPassword = new Label();
            lUserName = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(107, 61);
            label1.Name = "label1";
            label1.Size = new Size(467, 40);
            label1.TabIndex = 0;
            label1.Text = "LIBRARY MEMBER LOGIN FORM";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 611);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(dateTimeBirthDay);
            panel4.Controls.Add(bSignUp);
            panel4.Controls.Add(txPasswordSignUp);
            panel4.Controls.Add(lPasswordSignUp);
            panel4.Controls.Add(lBirthDaySignUp);
            panel4.Controls.Add(txPhoneSignUp);
            panel4.Controls.Add(lPhoneSignUp);
            panel4.Controls.Add(txEmailSignUp);
            panel4.Controls.Add(lEmailSignUp);
            panel4.Controls.Add(txNameSignUp);
            panel4.Controls.Add(txUserNameSignUp);
            panel4.Controls.Add(lNameSignUp);
            panel4.Controls.Add(lUserNameSignUp);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(355, 188);
            panel4.Name = "panel4";
            panel4.Size = new Size(331, 419);
            panel4.TabIndex = 1;
            // 
            // dateTimeBirthDay
            // 
            dateTimeBirthDay.Format = DateTimePickerFormat.Short;
            dateTimeBirthDay.Location = new Point(118, 244);
            dateTimeBirthDay.Name = "dateTimeBirthDay";
            dateTimeBirthDay.Size = new Size(191, 27);
            dateTimeBirthDay.TabIndex = 9;
            dateTimeBirthDay.Value = new DateTime(2023, 11, 9, 0, 0, 0, 0);
            // 
            // bSignUp
            // 
            bSignUp.Location = new Point(118, 344);
            bSignUp.Name = "bSignUp";
            bSignUp.Size = new Size(106, 44);
            bSignUp.TabIndex = 11;
            bSignUp.Text = "Sign Up";
            bSignUp.UseVisualStyleBackColor = true;
            bSignUp.Click += bSignUp_Click;
            // 
            // txPasswordSignUp
            // 
            txPasswordSignUp.Location = new Point(118, 287);
            txPasswordSignUp.Name = "txPasswordSignUp";
            txPasswordSignUp.Size = new Size(191, 27);
            txPasswordSignUp.TabIndex = 10;
            // 
            // lPasswordSignUp
            // 
            lPasswordSignUp.AutoSize = true;
            lPasswordSignUp.Location = new Point(23, 291);
            lPasswordSignUp.Name = "lPasswordSignUp";
            lPasswordSignUp.Size = new Size(70, 20);
            lPasswordSignUp.TabIndex = 17;
            lPasswordSignUp.Text = "Password";
            // 
            // lBirthDaySignUp
            // 
            lBirthDaySignUp.AutoSize = true;
            lBirthDaySignUp.Location = new Point(23, 249);
            lBirthDaySignUp.Name = "lBirthDaySignUp";
            lBirthDaySignUp.Size = new Size(66, 20);
            lBirthDaySignUp.TabIndex = 15;
            lBirthDaySignUp.Text = "BirthDay";
            // 
            // txPhoneSignUp
            // 
            txPhoneSignUp.Location = new Point(118, 201);
            txPhoneSignUp.Name = "txPhoneSignUp";
            txPhoneSignUp.Size = new Size(191, 27);
            txPhoneSignUp.TabIndex = 8;
            // 
            // lPhoneSignUp
            // 
            lPhoneSignUp.AutoSize = true;
            lPhoneSignUp.Location = new Point(23, 204);
            lPhoneSignUp.Name = "lPhoneSignUp";
            lPhoneSignUp.Size = new Size(51, 20);
            lPhoneSignUp.TabIndex = 13;
            lPhoneSignUp.Text = "phone";
            // 
            // txEmailSignUp
            // 
            txEmailSignUp.Location = new Point(118, 159);
            txEmailSignUp.Name = "txEmailSignUp";
            txEmailSignUp.Size = new Size(191, 27);
            txEmailSignUp.TabIndex = 7;
            // 
            // lEmailSignUp
            // 
            lEmailSignUp.AutoSize = true;
            lEmailSignUp.Location = new Point(23, 163);
            lEmailSignUp.Name = "lEmailSignUp";
            lEmailSignUp.Size = new Size(46, 20);
            lEmailSignUp.TabIndex = 11;
            lEmailSignUp.Text = "Email";
            // 
            // txNameSignUp
            // 
            txNameSignUp.Location = new Point(118, 116);
            txNameSignUp.Name = "txNameSignUp";
            txNameSignUp.Size = new Size(191, 27);
            txNameSignUp.TabIndex = 6;
            // 
            // txUserNameSignUp
            // 
            txUserNameSignUp.Location = new Point(118, 73);
            txUserNameSignUp.Name = "txUserNameSignUp";
            txUserNameSignUp.Size = new Size(191, 27);
            txUserNameSignUp.TabIndex = 5;
            // 
            // lNameSignUp
            // 
            lNameSignUp.AutoSize = true;
            lNameSignUp.Location = new Point(23, 119);
            lNameSignUp.Name = "lNameSignUp";
            lNameSignUp.Size = new Size(49, 20);
            lNameSignUp.TabIndex = 8;
            lNameSignUp.Text = "Name";
            // 
            // lUserNameSignUp
            // 
            lUserNameSignUp.AutoSize = true;
            lUserNameSignUp.Location = new Point(23, 73);
            lUserNameSignUp.Name = "lUserNameSignUp";
            lUserNameSignUp.Size = new Size(78, 20);
            lUserNameSignUp.TabIndex = 7;
            lUserNameSignUp.Text = "UserName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 235);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 35);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 1;
            label3.Text = "Sign Up";
            // 
            // panel3
            // 
            panel3.Controls.Add(bSignIn);
            panel3.Controls.Add(likRegister);
            panel3.Controls.Add(txpasswordSignIn);
            panel3.Controls.Add(txUserNameSignIn);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(lForgotPassword);
            panel3.Controls.Add(lPassword);
            panel3.Controls.Add(lUserName);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(11, 188);
            panel3.Name = "panel3";
            panel3.Size = new Size(337, 419);
            panel3.TabIndex = 0;
            // 
            // bSignIn
            // 
            bSignIn.Location = new Point(121, 204);
            bSignIn.Name = "bSignIn";
            bSignIn.Size = new Size(106, 44);
            bSignIn.TabIndex = 3;
            bSignIn.Text = "Sign In";
            bSignIn.UseVisualStyleBackColor = true;
            bSignIn.Click += bSignIn_Click;
            // 
            // likRegister
            // 
            likRegister.AutoSize = true;
            likRegister.Location = new Point(137, 291);
            likRegister.Name = "likRegister";
            likRegister.Size = new Size(63, 20);
            likRegister.TabIndex = 4;
            likRegister.TabStop = true;
            likRegister.Text = "Register";
            likRegister.LinkClicked += likRegister_LinkClicked;
            // 
            // txpasswordSignIn
            // 
            txpasswordSignIn.Location = new Point(121, 119);
            txpasswordSignIn.Name = "txpasswordSignIn";
            txpasswordSignIn.PasswordChar = '*';
            txpasswordSignIn.Size = new Size(191, 27);
            txpasswordSignIn.TabIndex = 2;
            // 
            // txUserNameSignIn
            // 
            txUserNameSignIn.Location = new Point(121, 73);
            txUserNameSignIn.Name = "txUserNameSignIn";
            txUserNameSignIn.Size = new Size(191, 27);
            txUserNameSignIn.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(137, 356);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 4;
            label7.Text = "Or Sign up";
            // 
            // lForgotPassword
            // 
            lForgotPassword.AutoSize = true;
            lForgotPassword.Location = new Point(7, 291);
            lForgotPassword.Name = "lForgotPassword";
            lForgotPassword.Size = new Size(125, 20);
            lForgotPassword.TabIndex = 3;
            lForgotPassword.Text = "Forgot Password?";
            // 
            // lPassword
            // 
            lPassword.AutoSize = true;
            lPassword.Location = new Point(26, 123);
            lPassword.Name = "lPassword";
            lPassword.Size = new Size(70, 20);
            lPassword.TabIndex = 2;
            lPassword.Text = "Password";
            // 
            // lUserName
            // 
            lUserName.AutoSize = true;
            lUserName.Location = new Point(26, 73);
            lUserName.Name = "lUserName";
            lUserName.Size = new Size(78, 20);
            lUserName.TabIndex = 1;
            lUserName.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 35);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 0;
            label2.Text = "Sign In";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(699, 181);
            panel2.TabIndex = 2;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 611);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Label label3;
        private Panel panel3;
        private TextBox txpasswordSignIn;
        private TextBox txUserNameSignIn;
        private Label label7;
        private Label lForgotPassword;
        private Label lPassword;
        private Label lUserName;
        private Label label2;
        private Label label4;
        private LinkLabel likRegister;
        private TextBox txPasswordSignUp;
        private Label lPasswordSignUp;
        private Label lBirthDaySignUp;
        private TextBox txPhoneSignUp;
        private Label lPhoneSignUp;
        private TextBox txEmailSignUp;
        private Label lEmailSignUp;
        private TextBox txNameSignUp;
        private TextBox txUserNameSignUp;
        private Label lNameSignUp;
        private Label lUserNameSignUp;
        private Button bSignUp;
        private Button bSignIn;
        private DateTimePicker dateTimeBirthDay;
    }
}