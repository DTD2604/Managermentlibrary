namespace Managermentlibrary
{
    partial class Main
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
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            bUpdateUser = new Button();
            dateTimeBirthDay = new DateTimePicker();
            txEmail = new TextBox();
            txPhone = new TextBox();
            txNameUser = new TextBox();
            txUserName = new TextBox();
            txIDUser = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            bFind = new Button();
            txAuthor = new TextBox();
            txCatergories = new TextBox();
            txNameBook = new TextBox();
            txIdBook = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            panel3 = new Panel();
            txBorrowId = new TextBox();
            label23 = new Label();
            dateTimeDueBack = new DateTimePicker();
            dateTimeBorrow = new DateTimePicker();
            bReturned = new Button();
            bReset = new Button();
            bBorrowed = new Button();
            numUpDownQuantity = new NumericUpDown();
            label18 = new Label();
            label16 = new Label();
            label15 = new Label();
            dgvListOfBooks = new DataGridView();
            dgvID = new DataGridViewTextBoxColumn();
            dgvName = new DataGridViewTextBoxColumn();
            dgvCatergories = new DataGridViewTextBoxColumn();
            dgvAuthor = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            bReturnFine = new Button();
            txTimeOverDue = new TextBox();
            txReturnFine = new TextBox();
            DateTimeReturn = new DateTimePicker();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label14 = new Label();
            label17 = new Label();
            label19 = new Label();
            dgvListBorrow = new DataGridView();
            IDListBorrow = new DataGridViewTextBoxColumn();
            NameListBorrow = new DataGridViewTextBoxColumn();
            StartDateListBorrow = new DataGridViewTextBoxColumn();
            EndDateListBorrow = new DataGridViewTextBoxColumn();
            dgvIdBookBorrow = new DataGridViewTextBoxColumn();
            IdUserListBorrow = new DataGridViewTextBoxColumn();
            dgvListBorrowLate = new DataGridView();
            dgvIdBorrowLate = new DataGridViewTextBoxColumn();
            dgvDateLate = new DataGridViewTextBoxColumn();
            dgvFineLate = new DataGridViewTextBoxColumn();
            dgvIdOverDues = new DataGridViewTextBoxColumn();
            label24 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDownQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListOfBooks).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListBorrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListBorrowLate).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GrayText;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(11, 99);
            label1.Name = "label1";
            label1.Size = new Size(236, 38);
            label1.TabIndex = 0;
            label1.Text = "Libarary Member";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GrayText;
            button1.Dock = DockStyle.Top;
            button1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(1412, 96);
            button1.TabIndex = 2;
            button1.Text = "  Libarary Management Systems   ";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GrayText;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(380, 99);
            label2.Name = "label2";
            label2.Size = new Size(189, 38);
            label2.TabIndex = 3;
            label2.Text = "Books Details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GrayText;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(713, 99);
            label3.Name = "label3";
            label3.Size = new Size(264, 38);
            label3.TabIndex = 4;
            label3.Text = "Library Borrow Info";
            // 
            // panel1
            // 
            panel1.Controls.Add(bUpdateUser);
            panel1.Controls.Add(dateTimeBirthDay);
            panel1.Controls.Add(txEmail);
            panel1.Controls.Add(txPhone);
            panel1.Controls.Add(txNameUser);
            panel1.Controls.Add(txUserName);
            panel1.Controls.Add(txIDUser);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(11, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 252);
            panel1.TabIndex = 5;
            // 
            // bUpdateUser
            // 
            bUpdateUser.Location = new Point(218, 3);
            bUpdateUser.Name = "bUpdateUser";
            bUpdateUser.Size = new Size(94, 40);
            bUpdateUser.TabIndex = 20;
            bUpdateUser.Text = "Update";
            bUpdateUser.UseVisualStyleBackColor = true;
            bUpdateUser.Click += bUpdateUser_Click;
            // 
            // dateTimeBirthDay
            // 
            dateTimeBirthDay.Format = DateTimePickerFormat.Short;
            dateTimeBirthDay.Location = new Point(111, 124);
            dateTimeBirthDay.Name = "dateTimeBirthDay";
            dateTimeBirthDay.Size = new Size(239, 27);
            dateTimeBirthDay.TabIndex = 19;
            // 
            // txEmail
            // 
            txEmail.Location = new Point(111, 205);
            txEmail.Name = "txEmail";
            txEmail.Size = new Size(239, 27);
            txEmail.TabIndex = 18;
            // 
            // txPhone
            // 
            txPhone.Location = new Point(111, 164);
            txPhone.Name = "txPhone";
            txPhone.Size = new Size(239, 27);
            txPhone.TabIndex = 17;
            // 
            // txNameUser
            // 
            txNameUser.Location = new Point(111, 88);
            txNameUser.Name = "txNameUser";
            txNameUser.Size = new Size(239, 27);
            txNameUser.TabIndex = 15;
            // 
            // txUserName
            // 
            txUserName.Location = new Point(111, 49);
            txUserName.Name = "txUserName";
            txUserName.Size = new Size(239, 27);
            txUserName.TabIndex = 14;
            // 
            // txIDUser
            // 
            txIDUser.Enabled = false;
            txIDUser.Location = new Point(111, 11);
            txIDUser.Name = "txIDUser";
            txIDUser.Size = new Size(38, 27);
            txIDUser.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 203);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 12;
            label9.Text = "Email:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 164);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 11;
            label8.Text = "Phone:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 124);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 3;
            label7.Text = "BirthDay:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 88);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 2;
            label6.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 49);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 1;
            label5.Text = "User Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 11);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 0;
            label4.Text = "Customer ID:";
            // 
            // panel2
            // 
            panel2.Controls.Add(bFind);
            panel2.Controls.Add(txAuthor);
            panel2.Controls.Add(txCatergories);
            panel2.Controls.Add(txNameBook);
            panel2.Controls.Add(txIdBook);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(378, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(318, 211);
            panel2.TabIndex = 6;
            // 
            // bFind
            // 
            bFind.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bFind.Location = new Point(166, 3);
            bFind.Name = "bFind";
            bFind.Size = new Size(62, 40);
            bFind.TabIndex = 27;
            bFind.Text = "Find";
            bFind.UseVisualStyleBackColor = true;
            bFind.Click += bFind_Click;
            // 
            // txAuthor
            // 
            txAuthor.Location = new Point(102, 167);
            txAuthor.Name = "txAuthor";
            txAuthor.Size = new Size(212, 27);
            txAuthor.TabIndex = 20;
            // 
            // txCatergories
            // 
            txCatergories.Location = new Point(102, 131);
            txCatergories.Name = "txCatergories";
            txCatergories.Size = new Size(212, 27);
            txCatergories.TabIndex = 19;
            // 
            // txNameBook
            // 
            txNameBook.Location = new Point(102, 91);
            txNameBook.Name = "txNameBook";
            txNameBook.Size = new Size(212, 27);
            txNameBook.TabIndex = 18;
            // 
            // txIdBook
            // 
            txIdBook.Location = new Point(87, 7);
            txIdBook.Name = "txIdBook";
            txIdBook.Size = new Size(50, 27);
            txIdBook.TabIndex = 17;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(2, 169);
            label13.Name = "label13";
            label13.Size = new Size(57, 20);
            label13.TabIndex = 4;
            label13.Text = "Author:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(2, 133);
            label12.Name = "label12";
            label12.Size = new Size(88, 20);
            label12.TabIndex = 3;
            label12.Text = "Catergories:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(2, 95);
            label11.Name = "label11";
            label11.Size = new Size(52, 20);
            label11.TabIndex = 2;
            label11.Text = "Name:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 11);
            label10.Name = "label10";
            label10.Size = new Size(65, 20);
            label10.TabIndex = 1;
            label10.Text = "Book ID:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txBorrowId);
            panel3.Controls.Add(label23);
            panel3.Controls.Add(dateTimeDueBack);
            panel3.Controls.Add(dateTimeBorrow);
            panel3.Controls.Add(bReturned);
            panel3.Controls.Add(bReset);
            panel3.Controls.Add(bBorrowed);
            panel3.Controls.Add(numUpDownQuantity);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label15);
            panel3.Location = new Point(713, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(331, 252);
            panel3.TabIndex = 7;
            // 
            // txBorrowId
            // 
            txBorrowId.Enabled = false;
            txBorrowId.Location = new Point(103, 124);
            txBorrowId.Name = "txBorrowId";
            txBorrowId.Size = new Size(50, 27);
            txBorrowId.TabIndex = 32;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(3, 124);
            label23.Name = "label23";
            label23.Size = new Size(79, 20);
            label23.TabIndex = 31;
            label23.Text = "Borrow ID:";
            // 
            // dateTimeDueBack
            // 
            dateTimeDueBack.Format = DateTimePickerFormat.Short;
            dateTimeDueBack.Location = new Point(103, 49);
            dateTimeDueBack.Name = "dateTimeDueBack";
            dateTimeDueBack.Size = new Size(218, 27);
            dateTimeDueBack.TabIndex = 30;
            // 
            // dateTimeBorrow
            // 
            dateTimeBorrow.Format = DateTimePickerFormat.Short;
            dateTimeBorrow.Location = new Point(103, 11);
            dateTimeBorrow.Name = "dateTimeBorrow";
            dateTimeBorrow.Size = new Size(218, 27);
            dateTimeBorrow.TabIndex = 29;
            dateTimeBorrow.Visible = false;
            // 
            // bReturned
            // 
            bReturned.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bReturned.Location = new Point(168, 208);
            bReturned.Name = "bReturned";
            bReturned.Size = new Size(160, 40);
            bReturned.TabIndex = 28;
            bReturned.Text = "Returned";
            bReturned.UseVisualStyleBackColor = true;
            bReturned.Click += bReturned_Click;
            // 
            // bReset
            // 
            bReset.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bReset.Location = new Point(3, 208);
            bReset.Name = "bReset";
            bReset.Size = new Size(160, 40);
            bReset.TabIndex = 27;
            bReset.Text = "Reset";
            bReset.UseVisualStyleBackColor = true;
            bReset.Click += bReset_Click;
            // 
            // bBorrowed
            // 
            bBorrowed.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bBorrowed.Location = new Point(89, 162);
            bBorrowed.Name = "bBorrowed";
            bBorrowed.Size = new Size(160, 40);
            bBorrowed.TabIndex = 26;
            bBorrowed.Text = "Borrowed";
            bBorrowed.UseVisualStyleBackColor = true;
            bBorrowed.Click += bBorrowed_Click;
            // 
            // numUpDownQuantity
            // 
            numUpDownQuantity.Location = new Point(103, 87);
            numUpDownQuantity.Name = "numUpDownQuantity";
            numUpDownQuantity.Size = new Size(218, 27);
            numUpDownQuantity.TabIndex = 14;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(3, 91);
            label18.Name = "label18";
            label18.Size = new Size(68, 20);
            label18.TabIndex = 5;
            label18.Text = "Quantity:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 51);
            label16.Name = "label16";
            label16.Size = new Size(110, 20);
            label16.TabIndex = 3;
            label16.Text = "Date Due Back:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 11);
            label15.Name = "label15";
            label15.Size = new Size(102, 20);
            label15.TabIndex = 2;
            label15.Text = "Date Borrows:";
            // 
            // dgvListOfBooks
            // 
            dgvListOfBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListOfBooks.Columns.AddRange(new DataGridViewColumn[] { dgvID, dgvName, dgvCatergories, dgvAuthor });
            dgvListOfBooks.Location = new Point(1, 444);
            dgvListOfBooks.Name = "dgvListOfBooks";
            dgvListOfBooks.RowHeadersWidth = 51;
            dgvListOfBooks.RowTemplate.Height = 29;
            dgvListOfBooks.Size = new Size(507, 244);
            dgvListOfBooks.TabIndex = 10;
            dgvListOfBooks.CellContentClick += dgvListOfBooks_CellContentClick;
            // 
            // dgvID
            // 
            dgvID.DataPropertyName = "ID";
            dgvID.HeaderText = "ID";
            dgvID.MinimumWidth = 6;
            dgvID.Name = "dgvID";
            dgvID.Width = 50;
            // 
            // dgvName
            // 
            dgvName.DataPropertyName = "NameBooks";
            dgvName.HeaderText = "Name";
            dgvName.MinimumWidth = 6;
            dgvName.Name = "dgvName";
            dgvName.Width = 135;
            // 
            // dgvCatergories
            // 
            dgvCatergories.DataPropertyName = "NameCatergories";
            dgvCatergories.HeaderText = "Catergories";
            dgvCatergories.MinimumWidth = 6;
            dgvCatergories.Name = "dgvCatergories";
            dgvCatergories.Width = 130;
            // 
            // dgvAuthor
            // 
            dgvAuthor.DataPropertyName = "NameAuthor";
            dgvAuthor.HeaderText = "Author";
            dgvAuthor.MinimumWidth = 6;
            dgvAuthor.Name = "dgvAuthor";
            dgvAuthor.Width = 130;
            // 
            // panel4
            // 
            panel4.Controls.Add(bReturnFine);
            panel4.Controls.Add(txTimeOverDue);
            panel4.Controls.Add(txReturnFine);
            panel4.Controls.Add(DateTimeReturn);
            panel4.Controls.Add(label22);
            panel4.Controls.Add(label21);
            panel4.Controls.Add(label20);
            panel4.Location = new Point(1061, 141);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(331, 211);
            panel4.TabIndex = 11;
            // 
            // bReturnFine
            // 
            bReturnFine.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bReturnFine.Location = new Point(89, 163);
            bReturnFine.Name = "bReturnFine";
            bReturnFine.Size = new Size(160, 40);
            bReturnFine.TabIndex = 35;
            bReturnFine.Text = "Return Fine";
            bReturnFine.UseVisualStyleBackColor = true;
            bReturnFine.Click += bReturnFine_Click;
            // 
            // txTimeOverDue
            // 
            txTimeOverDue.Location = new Point(114, 99);
            txTimeOverDue.Name = "txTimeOverDue";
            txTimeOverDue.Size = new Size(206, 27);
            txTimeOverDue.TabIndex = 34;
            // 
            // txReturnFine
            // 
            txReturnFine.Location = new Point(114, 53);
            txReturnFine.Name = "txReturnFine";
            txReturnFine.Size = new Size(206, 27);
            txReturnFine.TabIndex = 33;
            // 
            // DateTimeReturn
            // 
            DateTimeReturn.Format = DateTimePickerFormat.Short;
            DateTimeReturn.Location = new Point(114, 12);
            DateTimeReturn.Name = "DateTimeReturn";
            DateTimeReturn.Size = new Size(206, 27);
            DateTimeReturn.TabIndex = 32;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(1, 103);
            label22.Name = "label22";
            label22.Size = new Size(117, 20);
            label22.TabIndex = 8;
            label22.Text = "Time Over Dues:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(3, 57);
            label21.Name = "label21";
            label21.Size = new Size(118, 20);
            label21.TabIndex = 7;
            label21.Text = "Late Return Fine:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(3, 20);
            label20.Name = "label20";
            label20.Size = new Size(91, 20);
            label20.TabIndex = 6;
            label20.Text = "Date Return:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.GrayText;
            label14.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(1061, 99);
            label14.Name = "label14";
            label14.Size = new Size(221, 38);
            label14.TabIndex = 12;
            label14.Text = "Late Return Info";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = SystemColors.GrayText;
            label17.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.Control;
            label17.Location = new Point(527, 401);
            label17.Name = "label17";
            label17.Size = new Size(227, 38);
            label17.TabIndex = 13;
            label17.Text = "List of borrowed";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = SystemColors.GrayText;
            label19.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.Control;
            label19.Location = new Point(1, 401);
            label19.Name = "label19";
            label19.Size = new Size(181, 38);
            label19.TabIndex = 14;
            label19.Text = "List of Books";
            // 
            // dgvListBorrow
            // 
            dgvListBorrow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListBorrow.Columns.AddRange(new DataGridViewColumn[] { IDListBorrow, NameListBorrow, StartDateListBorrow, EndDateListBorrow, dgvIdBookBorrow, IdUserListBorrow });
            dgvListBorrow.Location = new Point(523, 444);
            dgvListBorrow.Name = "dgvListBorrow";
            dgvListBorrow.RowHeadersWidth = 51;
            dgvListBorrow.RowTemplate.Height = 29;
            dgvListBorrow.Size = new Size(506, 244);
            dgvListBorrow.TabIndex = 15;
            dgvListBorrow.CellContentClick += dgvListBorrow_CellContentClick;
            // 
            // IDListBorrow
            // 
            IDListBorrow.DataPropertyName = "ID";
            IDListBorrow.HeaderText = "ID";
            IDListBorrow.MinimumWidth = 6;
            IDListBorrow.Name = "IDListBorrow";
            IDListBorrow.Width = 50;
            // 
            // NameListBorrow
            // 
            NameListBorrow.DataPropertyName = "NameBooks";
            NameListBorrow.HeaderText = "Name";
            NameListBorrow.MinimumWidth = 6;
            NameListBorrow.Name = "NameListBorrow";
            NameListBorrow.Width = 135;
            // 
            // StartDateListBorrow
            // 
            StartDateListBorrow.DataPropertyName = "StartDate";
            StartDateListBorrow.HeaderText = "StartDate";
            StartDateListBorrow.MinimumWidth = 6;
            StartDateListBorrow.Name = "StartDateListBorrow";
            StartDateListBorrow.Width = 130;
            // 
            // EndDateListBorrow
            // 
            EndDateListBorrow.DataPropertyName = "EndDate";
            EndDateListBorrow.HeaderText = "EndDate";
            EndDateListBorrow.MinimumWidth = 6;
            EndDateListBorrow.Name = "EndDateListBorrow";
            EndDateListBorrow.Width = 130;
            // 
            // dgvIdBookBorrow
            // 
            dgvIdBookBorrow.DataPropertyName = "IdBook";
            dgvIdBookBorrow.HeaderText = "IdBook";
            dgvIdBookBorrow.MinimumWidth = 6;
            dgvIdBookBorrow.Name = "dgvIdBookBorrow";
            dgvIdBookBorrow.Visible = false;
            dgvIdBookBorrow.Width = 125;
            // 
            // IdUserListBorrow
            // 
            IdUserListBorrow.DataPropertyName = "IdUser";
            IdUserListBorrow.HeaderText = "IdUser";
            IdUserListBorrow.MinimumWidth = 6;
            IdUserListBorrow.Name = "IdUserListBorrow";
            IdUserListBorrow.Visible = false;
            IdUserListBorrow.Width = 125;
            // 
            // dgvListBorrowLate
            // 
            dgvListBorrowLate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListBorrowLate.Columns.AddRange(new DataGridViewColumn[] { dgvIdBorrowLate, dgvDateLate, dgvFineLate, dgvIdOverDues });
            dgvListBorrowLate.Location = new Point(1047, 444);
            dgvListBorrowLate.Name = "dgvListBorrowLate";
            dgvListBorrowLate.RowHeadersWidth = 51;
            dgvListBorrowLate.RowTemplate.Height = 29;
            dgvListBorrowLate.Size = new Size(363, 244);
            dgvListBorrowLate.TabIndex = 16;
            dgvListBorrowLate.CellContentClick += dgvListBorrowLate_CellContentClick;
            // 
            // dgvIdBorrowLate
            // 
            dgvIdBorrowLate.DataPropertyName = "IDBorrow";
            dgvIdBorrowLate.HeaderText = "ID";
            dgvIdBorrowLate.MinimumWidth = 6;
            dgvIdBorrowLate.Name = "dgvIdBorrowLate";
            dgvIdBorrowLate.Width = 50;
            // 
            // dgvDateLate
            // 
            dgvDateLate.DataPropertyName = "Date";
            dgvDateLate.HeaderText = "Date";
            dgvDateLate.MinimumWidth = 6;
            dgvDateLate.Name = "dgvDateLate";
            dgvDateLate.Width = 130;
            // 
            // dgvFineLate
            // 
            dgvFineLate.DataPropertyName = "Fine";
            dgvFineLate.HeaderText = "Fine";
            dgvFineLate.MinimumWidth = 6;
            dgvFineLate.Name = "dgvFineLate";
            dgvFineLate.Width = 125;
            // 
            // dgvIdOverDues
            // 
            dgvIdOverDues.DataPropertyName = "ID";
            dgvIdOverDues.HeaderText = "IDOverDue";
            dgvIdOverDues.MinimumWidth = 6;
            dgvIdOverDues.Name = "dgvIdOverDues";
            dgvIdOverDues.Visible = false;
            dgvIdOverDues.Width = 125;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = SystemColors.GrayText;
            label24.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = SystemColors.Control;
            label24.Location = new Point(1047, 401);
            label24.Name = "label24";
            label24.Size = new Size(213, 38);
            label24.TabIndex = 17;
            label24.Text = "List Return Late";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1412, 692);
            Controls.Add(label24);
            Controls.Add(dgvListBorrowLate);
            Controls.Add(dgvListBorrow);
            Controls.Add(label19);
            Controls.Add(label17);
            Controls.Add(label14);
            Controls.Add(panel4);
            Controls.Add(dgvListOfBooks);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Main";
            Text = "Main";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDownQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListOfBooks).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListBorrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListBorrowLate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private DataGridView dgvListOfBooks;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox txEmail;
        private TextBox txPhone;
        private TextBox textBox4;
        private TextBox txNameUser;
        private TextBox txUserName;
        private TextBox txIDUser;
        private TextBox txAuthor;
        private TextBox txCatergories;
        private TextBox txNameBook;
        private TextBox txIdBook;
        private TextBox textBox11;
        private NumericUpDown numUpDownQuantity;
        private Label label18;
        private Label label16;
        private Label label15;
        private DateTimePicker dateTimeBirthDay;
        private Button bBorrowed;
        private Button bReturned;
        private Button bReset;
        private Panel panel4;
        private Label label14;
        private Label label17;
        private Label label19;
        private DateTimePicker dateTimeDueBack;
        private DateTimePicker dateTimeBorrow;
        private TextBox txReturnFine;
        private DateTimePicker DateTimeReturn;
        private Label label22;
        private Label label21;
        private Label label20;
        private Button bReturnFine;
        private TextBox txTimeOverDue;
        private Button bFind;
        private Button bUpdateUser;
        private TextBox txBorrowId;
        private Label label23;
        private DataGridViewTextBoxColumn dgvID;
        private DataGridViewTextBoxColumn dgvName;
        private DataGridViewTextBoxColumn dgvCatergories;
        private DataGridViewTextBoxColumn dgvAuthor;
        private DataGridView dgvListBorrow;
        private DataGridView dgvListBorrowLate;
        private Label label24;
        private DataGridViewTextBoxColumn IDListBorrow;
        private DataGridViewTextBoxColumn NameListBorrow;
        private DataGridViewTextBoxColumn StartDateListBorrow;
        private DataGridViewTextBoxColumn EndDateListBorrow;
        private DataGridViewTextBoxColumn dgvIdBookBorrow;
        private DataGridViewTextBoxColumn IdUserListBorrow;
        private DataGridViewTextBoxColumn dgvIdBorrowLate;
        private DataGridViewTextBoxColumn dgvDateLate;
        private DataGridViewTextBoxColumn dgvFineLate;
        private DataGridViewTextBoxColumn dgvIdOverDues;
    }
}