namespace FinanceManager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.totalSpent = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.btnAddSpending = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.listViewTransactions = new System.Windows.Forms.ListView();
            this.lblTransactionsTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIncomeBalace = new System.Windows.Forms.Label();
            this.numericUpDownIncome = new System.Windows.Forms.NumericUpDown();
            this.btnIncomeBlance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(28)))), ((int)(((byte)(185)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(828, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = " МЕНЕДЖЕР ФИНАНСОВ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalSpent
            // 
            this.totalSpent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalSpent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.totalSpent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSpent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.totalSpent.Location = new System.Drawing.Point(561, 47);
            this.totalSpent.MinimumSize = new System.Drawing.Size(267, 39);
            this.totalSpent.Name = "totalSpent";
            this.totalSpent.Size = new System.Drawing.Size(267, 39);
            this.totalSpent.TabIndex = 2;
            this.totalSpent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.totalSpent.Click += new System.EventHandler(this.totalSpent_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(-3, 126);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(267, 20);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Location = new System.Drawing.Point(1, 152);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(263, 20);
            this.numericUpDownPrice.TabIndex = 6;
            this.numericUpDownPrice.ValueChanged += new System.EventHandler(this.numericUpDownPrice_ValueChanged);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(-3, 178);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(267, 21);
            this.comboBoxCategory.TabIndex = 7;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCatigory_SelectedIndexChanged);
            // 
            // btnAddSpending
            // 
            this.btnAddSpending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAddSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSpending.Location = new System.Drawing.Point(-3, 205);
            this.btnAddSpending.Name = "btnAddSpending";
            this.btnAddSpending.Size = new System.Drawing.Size(267, 32);
            this.btnAddSpending.TabIndex = 8;
            this.btnAddSpending.Text = "Добавить трату";
            this.btnAddSpending.UseVisualStyleBackColor = false;
            this.btnAddSpending.Click += new System.EventHandler(this.btnAddSpending_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblBalance.Location = new System.Drawing.Point(-3, 47);
            this.lblBalance.MinimumSize = new System.Drawing.Size(267, 39);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(267, 39);
            this.lblBalance.TabIndex = 9;
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBalance.Click += new System.EventHandler(this.lblBalance_Click);
            // 
            // listViewTransactions
            // 
            this.listViewTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTransactions.BackColor = System.Drawing.Color.White;
            this.listViewTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewTransactions.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTransactions.FullRowSelect = true;
            this.listViewTransactions.GridLines = true;
            this.listViewTransactions.HideSelection = false;
            this.listViewTransactions.Location = new System.Drawing.Point(274, 89);
            this.listViewTransactions.Name = "listViewTransactions";
            this.listViewTransactions.Size = new System.Drawing.Size(278, 148);
            this.listViewTransactions.TabIndex = 10;
            this.listViewTransactions.UseCompatibleStateImageBehavior = false;
            this.listViewTransactions.View = System.Windows.Forms.View.Tile;
            this.listViewTransactions.SelectedIndexChanged += new System.EventHandler(this.listViewTransactions_SelectedIndexChanged);
            // 
            // lblTransactionsTitle
            // 
            this.lblTransactionsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTransactionsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTransactionsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTransactionsTitle.Location = new System.Drawing.Point(277, 47);
            this.lblTransactionsTitle.Name = "lblTransactionsTitle";
            this.lblTransactionsTitle.Size = new System.Drawing.Size(278, 37);
            this.lblTransactionsTitle.TabIndex = 11;
            this.lblTransactionsTitle.Text = "История транзакций";
            this.lblTransactionsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(-3, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "Добавить новую трату";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIncomeBalace
            // 
            this.lblIncomeBalace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIncomeBalace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIncomeBalace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblIncomeBalace.Location = new System.Drawing.Point(558, 89);
            this.lblIncomeBalace.Name = "lblIncomeBalace";
            this.lblIncomeBalace.Size = new System.Drawing.Size(270, 34);
            this.lblIncomeBalace.TabIndex = 13;
            this.lblIncomeBalace.Text = "Пополнить баланс";
            this.lblIncomeBalace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownIncome
            // 
            this.numericUpDownIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownIncome.Location = new System.Drawing.Point(558, 126);
            this.numericUpDownIncome.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDownIncome.Name = "numericUpDownIncome";
            this.numericUpDownIncome.Size = new System.Drawing.Size(270, 20);
            this.numericUpDownIncome.TabIndex = 14;
            this.numericUpDownIncome.ValueChanged += new System.EventHandler(this.numericUpDownIncome_ValueChanged);
            // 
            // btnIncomeBlance
            // 
            this.btnIncomeBlance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncomeBlance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnIncomeBlance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncomeBlance.Location = new System.Drawing.Point(558, 152);
            this.btnIncomeBlance.Name = "btnIncomeBlance";
            this.btnIncomeBlance.Size = new System.Drawing.Size(267, 32);
            this.btnIncomeBlance.TabIndex = 15;
            this.btnIncomeBlance.Text = "Пополнить баланс";
            this.btnIncomeBlance.UseVisualStyleBackColor = false;
            this.btnIncomeBlance.Click += new System.EventHandler(this.btnIncomeBlance_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.btnIncomeBlance);
            this.Controls.Add(this.numericUpDownIncome);
            this.Controls.Add(this.lblIncomeBalace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTransactionsTitle);
            this.Controls.Add(this.listViewTransactions);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnAddSpending);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.totalSpent);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Менеджер финансов";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalSpent;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button btnAddSpending;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.ListView listViewTransactions;
        private System.Windows.Forms.Label lblTransactionsTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIncomeBalace;
        private System.Windows.Forms.NumericUpDown numericUpDownIncome;
        private System.Windows.Forms.Button btnIncomeBlance;
    }
}

