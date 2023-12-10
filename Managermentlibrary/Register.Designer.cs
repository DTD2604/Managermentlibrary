namespace Managermentlibrary
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txPhoneRegister = new TextBox();
            lPhoneSignUp = new Label();
            txEmailRegister = new TextBox();
            lEmailSignUp = new Label();
            lNameSignUp = new Label();
            lUserNameRegister = new Label();
            pInfor = new Panel();
            txNameRegister = new TextBox();
            txUserNameRegister = new TextBox();
            bConfirm = new Button();
            pPassword = new Panel();
            bSubmit = new Button();
            txConfirmPasswordRegister = new TextBox();
            lConfirmPassword = new Label();
            txPasswordRegister = new TextBox();
            lPasswordRegister = new Label();
            pInfor.SuspendLayout();
            pPassword.SuspendLayout();
            SuspendLayout();
            // 
            // txPhoneRegister
            // 
            txPhoneRegister.Location = new Point(115, 153);
            txPhoneRegister.Name = "txPhoneRegister";
            txPhoneRegister.Size = new Size(191, 27);
            txPhoneRegister.TabIndex = 28;
            // 
            // lPhoneSignUp
            // 
            lPhoneSignUp.AutoSize = true;
            lPhoneSignUp.Location = new Point(3, 155);
            lPhoneSignUp.Name = "lPhoneSignUp";
            lPhoneSignUp.Size = new Size(51, 20);
            lPhoneSignUp.TabIndex = 27;
            lPhoneSignUp.Text = "phone";
            // 
            // txEmailRegister
            // 
            txEmailRegister.Location = new Point(115, 110);
            txEmailRegister.Name = "txEmailRegister";
            txEmailRegister.Size = new Size(191, 27);
            txEmailRegister.TabIndex = 26;
            // 
            // lEmailSignUp
            // 
            lEmailSignUp.AutoSize = true;
            lEmailSignUp.Location = new Point(3, 113);
            lEmailSignUp.Name = "lEmailSignUp";
            lEmailSignUp.Size = new Size(46, 20);
            lEmailSignUp.TabIndex = 25;
            lEmailSignUp.Text = "Email";
            // 
            // lNameSignUp
            // 
            lNameSignUp.AutoSize = true;
            lNameSignUp.Location = new Point(3, 69);
            lNameSignUp.Name = "lNameSignUp";
            lNameSignUp.Size = new Size(49, 20);
            lNameSignUp.TabIndex = 22;
            lNameSignUp.Text = "Name";
            // 
            // lUserNameRegister
            // 
            lUserNameRegister.AutoSize = true;
            lUserNameRegister.Location = new Point(3, 24);
            lUserNameRegister.Name = "lUserNameRegister";
            lUserNameRegister.Size = new Size(78, 20);
            lUserNameRegister.TabIndex = 21;
            lUserNameRegister.Text = "UserName";
            // 
            // pInfor
            // 
            pInfor.Controls.Add(txNameRegister);
            pInfor.Controls.Add(txUserNameRegister);
            pInfor.Controls.Add(bConfirm);
            pInfor.Controls.Add(lUserNameRegister);
            pInfor.Controls.Add(lNameSignUp);
            pInfor.Controls.Add(lEmailSignUp);
            pInfor.Controls.Add(txPhoneRegister);
            pInfor.Controls.Add(txEmailRegister);
            pInfor.Controls.Add(lPhoneSignUp);
            pInfor.Location = new Point(14, 16);
            pInfor.Margin = new Padding(3, 4, 3, 4);
            pInfor.Name = "pInfor";
            pInfor.Size = new Size(324, 303);
            pInfor.TabIndex = 33;
            // 
            // txNameRegister
            // 
            txNameRegister.Location = new Point(115, 66);
            txNameRegister.Name = "txNameRegister";
            txNameRegister.Size = new Size(191, 27);
            txNameRegister.TabIndex = 35;
            // 
            // txUserNameRegister
            // 
            txUserNameRegister.Location = new Point(115, 21);
            txUserNameRegister.Name = "txUserNameRegister";
            txUserNameRegister.Size = new Size(191, 27);
            txUserNameRegister.TabIndex = 34;
            // 
            // bConfirm
            // 
            bConfirm.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bConfirm.Location = new Point(115, 224);
            bConfirm.Margin = new Padding(3, 4, 3, 4);
            bConfirm.Name = "bConfirm";
            bConfirm.Size = new Size(86, 55);
            bConfirm.TabIndex = 33;
            bConfirm.Text = "Confirm";
            bConfirm.UseVisualStyleBackColor = true;
            bConfirm.Click += bConfirm_Click;
            // 
            // pPassword
            // 
            pPassword.Controls.Add(bSubmit);
            pPassword.Controls.Add(txConfirmPasswordRegister);
            pPassword.Controls.Add(lConfirmPassword);
            pPassword.Controls.Add(txPasswordRegister);
            pPassword.Controls.Add(lPasswordRegister);
            pPassword.Enabled = false;
            pPassword.Location = new Point(14, 327);
            pPassword.Margin = new Padding(3, 4, 3, 4);
            pPassword.Name = "pPassword";
            pPassword.Size = new Size(324, 164);
            pPassword.TabIndex = 34;
            // 
            // bSubmit
            // 
            bSubmit.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bSubmit.Location = new Point(115, 99);
            bSubmit.Margin = new Padding(3, 4, 3, 4);
            bSubmit.Name = "bSubmit";
            bSubmit.Size = new Size(86, 55);
            bSubmit.TabIndex = 36;
            bSubmit.Text = "Submit";
            bSubmit.UseVisualStyleBackColor = true;
            bSubmit.Click += bSubmit_Click;
            // 
            // txConfirmPasswordRegister
            // 
            txConfirmPasswordRegister.Location = new Point(136, 40);
            txConfirmPasswordRegister.Name = "txConfirmPasswordRegister";
            txConfirmPasswordRegister.Size = new Size(170, 27);
            txConfirmPasswordRegister.TabIndex = 35;
            // 
            // lConfirmPassword
            // 
            lConfirmPassword.AutoSize = true;
            lConfirmPassword.Location = new Point(3, 47);
            lConfirmPassword.Name = "lConfirmPassword";
            lConfirmPassword.Size = new Size(127, 20);
            lConfirmPassword.TabIndex = 34;
            lConfirmPassword.Text = "Confirm Password";
            // 
            // txPasswordRegister
            // 
            txPasswordRegister.Location = new Point(136, 3);
            txPasswordRegister.Name = "txPasswordRegister";
            txPasswordRegister.Size = new Size(170, 27);
            txPasswordRegister.TabIndex = 33;
            // 
            // lPasswordRegister
            // 
            lPasswordRegister.AutoSize = true;
            lPasswordRegister.Location = new Point(3, 11);
            lPasswordRegister.Name = "lPasswordRegister";
            lPasswordRegister.Size = new Size(104, 20);
            lPasswordRegister.TabIndex = 32;
            lPasswordRegister.Text = "New Password";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 494);
            Controls.Add(pPassword);
            Controls.Add(pInfor);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Register";
            Text = "Register";
            pInfor.ResumeLayout(false);
            pInfor.PerformLayout();
            pPassword.ResumeLayout(false);
            pPassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lPasswordSignUp;
        private TextBox txPhoneRegister;
        private Label lPhoneSignUp;
        private TextBox txEmailRegister;
        private Label lEmailSignUp;
        private TextBox txNameSignUp;
        private TextBox txUserNameSignUp;
        private Label lNameSignUp;
        private Label lUserNameRegister;
        private Panel pInfor;
        private Panel pPassword;
        private TextBox txConfirmPasswordRegister;
        private Label lConfirmPassword;
        private TextBox txPasswordRegister;
        private Label lPasswordRegister;
        private Button bConfirm;
        private Button bSubmit;
        private TextBox txNameRegister;
        private TextBox txUserNameRegister;
    }
}