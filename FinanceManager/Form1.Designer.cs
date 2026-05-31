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
            this.label1 = new System.Windows.Forms.Label();
            this.totalSpent = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCatigory = new System.Windows.Forms.ComboBox();
            this.btnAddSpending = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.listViewTransactions = new System.Windows.Forms.ListView();
            this.lblTransactionsTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(800, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = " МЕНЕДЖЕР ФИНАНСОВ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalSpent
            // 
            this.totalSpent.AutoSize = true;
            this.totalSpent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.totalSpent.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.totalSpent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.totalSpent.Location = new System.Drawing.Point(530, 47);
            this.totalSpent.MinimumSize = new System.Drawing.Size(267, 39);
            this.totalSpent.Name = "totalSpent";
            this.totalSpent.Size = new System.Drawing.Size(267, 39);
            this.totalSpent.TabIndex = 2;
            this.totalSpent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.totalSpent.Click += new System.EventHandler(this.totalSpent_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 26);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить новую трату";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(1, 121);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(267, 20);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Location = new System.Drawing.Point(1, 147);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(267, 20);
            this.numericUpDownPrice.TabIndex = 6;
            this.numericUpDownPrice.ValueChanged += new System.EventHandler(this.numericUpDownPrice_ValueChanged);
            // 
            // comboBoxCatigory
            // 
            this.comboBoxCatigory.FormattingEnabled = true;
            this.comboBoxCatigory.Location = new System.Drawing.Point(1, 173);
            this.comboBoxCatigory.Name = "comboBoxCatigory";
            this.comboBoxCatigory.Size = new System.Drawing.Size(267, 21);
            this.comboBoxCatigory.TabIndex = 7;
            this.comboBoxCatigory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCatigory_SelectedIndexChanged);
            // 
            // btnAddSpending
            // 
            this.btnAddSpending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAddSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSpending.Location = new System.Drawing.Point(1, 200);
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
            this.lblBalance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblBalance.Location = new System.Drawing.Point(1, 46);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(267, 39);
            this.lblBalance.TabIndex = 9;
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBalance.Click += new System.EventHandler(this.lblBalance_Click);
            // 
            // listViewTransactions
            // 
            this.listViewTransactions.BackColor = System.Drawing.Color.White;
            this.listViewTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewTransactions.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTransactions.FullRowSelect = true;
            this.listViewTransactions.GridLines = true;
            this.listViewTransactions.HideSelection = false;
            this.listViewTransactions.Location = new System.Drawing.Point(274, 89);
            this.listViewTransactions.Name = "listViewTransactions";
            this.listViewTransactions.Size = new System.Drawing.Size(250, 143);
            this.listViewTransactions.TabIndex = 10;
            this.listViewTransactions.UseCompatibleStateImageBehavior = false;
            this.listViewTransactions.View = System.Windows.Forms.View.Tile;
            this.listViewTransactions.SelectedIndexChanged += new System.EventHandler(this.listViewTransactions_SelectedIndexChanged);
            // 
            // lblTransactionsTitle
            // 
            this.lblTransactionsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTransactionsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTransactionsTitle.Location = new System.Drawing.Point(274, 46);
            this.lblTransactionsTitle.Name = "lblTransactionsTitle";
            this.lblTransactionsTitle.Size = new System.Drawing.Size(250, 39);
            this.lblTransactionsTitle.TabIndex = 11;
            this.lblTransactionsTitle.Text = "История транзакций";
            this.lblTransactionsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTransactionsTitle);
            this.Controls.Add(this.listViewTransactions);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnAddSpending);
            this.Controls.Add(this.comboBoxCatigory);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.totalSpent);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalSpent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.ComboBox comboBoxCatigory;
        private System.Windows.Forms.Button btnAddSpending;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.ListView listViewTransactions;
        private System.Windows.Forms.Label lblTransactionsTitle;
    }
}

