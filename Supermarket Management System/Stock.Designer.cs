namespace Supermarket_Management_System
{
    partial class Stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProdPrice = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddTb = new System.Windows.Forms.Button();
            this.ProdQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StockDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CatCb);
            this.panel1.Controls.Add(this.ProdPrice);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.AddTb);
            this.panel1.Controls.Add(this.ProdQty);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ProdName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.StockDGV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(144, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 537);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ProdPrice
            // 
            this.ProdPrice.BackColor = System.Drawing.SystemColors.Window;
            this.ProdPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProdPrice.Location = new System.Drawing.Point(118, 276);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(126, 23);
            this.ProdPrice.TabIndex = 36;
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.SystemColors.Window;
            this.ID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ID.Location = new System.Drawing.Point(118, 142);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(126, 23);
            this.ID.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(69, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "PRICE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(29, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "PRODUCT ID";
            // 
            // AddTb
            // 
            this.AddTb.BackColor = System.Drawing.Color.White;
            this.AddTb.FlatAppearance.BorderSize = 0;
            this.AddTb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddTb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AddTb.Location = new System.Drawing.Point(119, 390);
            this.AddTb.Name = "AddTb";
            this.AddTb.Size = new System.Drawing.Size(68, 28);
            this.AddTb.TabIndex = 32;
            this.AddTb.Text = "ADD";
            this.AddTb.UseVisualStyleBackColor = false;
            this.AddTb.Click += new System.EventHandler(this.AddTb_Click);
            // 
            // ProdQty
            // 
            this.ProdQty.BackColor = System.Drawing.SystemColors.Window;
            this.ProdQty.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProdQty.Location = new System.Drawing.Point(118, 226);
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.Size = new System.Drawing.Size(126, 23);
            this.ProdQty.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(42, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "QUANTITY";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ProdName
            // 
            this.ProdName.BackColor = System.Drawing.SystemColors.Window;
            this.ProdName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProdName.Location = new System.Drawing.Point(118, 184);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(126, 23);
            this.ProdName.TabIndex = 22;
            this.ProdName.TextChanged += new System.EventHandler(this.CatIdTb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "PRODUCT NAME";
            // 
            // StockDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.StockDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.StockDGV.BackgroundColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.StockDGV.ColumnHeadersHeight = 30;
            this.StockDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StockDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.StockDGV.GridColor = System.Drawing.Color.DodgerBlue;
            this.StockDGV.Location = new System.Drawing.Point(250, 74);
            this.StockDGV.Name = "StockDGV";
            this.StockDGV.RowHeadersVisible = false;
            this.StockDGV.RowTemplate.Height = 25;
            this.StockDGV.Size = new System.Drawing.Size(531, 445);
            this.StockDGV.TabIndex = 17;
            this.StockDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.StockDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StockDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.StockDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StockDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StockDGV.ThemeStyle.BackColor = System.Drawing.Color.DarkCyan;
            this.StockDGV.ThemeStyle.GridColor = System.Drawing.Color.DodgerBlue;
            this.StockDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.StockDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.StockDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StockDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StockDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StockDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.StockDGV.ThemeStyle.ReadOnly = false;
            this.StockDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.StockDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StockDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StockDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Cyan;
            this.StockDGV.ThemeStyle.RowsStyle.Height = 25;
            this.StockDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Cyan;
            this.StockDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(482, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "STOCK";
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(247, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(241, 39);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button6.Location = new System.Drawing.Point(22, 282);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(116, 39);
            this.button6.TabIndex = 29;
            this.button6.Text = "Transactions";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button7.Location = new System.Drawing.Point(22, 217);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(101, 39);
            this.button7.TabIndex = 28;
            this.button7.Text = "Till";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(920, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CatCb
            // 
            this.CatCb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CatCb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Items.AddRange(new object[] {
            "ADMIN",
            "ATTENDANT"});
            this.CatCb.Location = new System.Drawing.Point(119, 324);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(125, 25);
            this.CatCb.TabIndex = 37;
            this.CatCb.Text = "Select Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(35, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "CATEGORY";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 617);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox ProdQty;
        private Label label5;
        private TextBox ProdName;
        private Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView StockDGV;
        private Label label1;
        private Button button4;
        private Button button6;
        private Button button7;
        private Label label3;
        private Button AddTb;
        private TextBox ProdPrice;
        private TextBox ID;
        private Label label6;
        private Label label4;
        private Label label7;
        private ComboBox CatCb;
    }
}