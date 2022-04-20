namespace FinalProject_643450091_3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addquantity = new System.Windows.Forms.TextBox();
            this.Addname = new System.Windows.Forms.TextBox();
            this.Addprice = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Addbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bname,
            this.Bprice,
            this.quantity});
            this.dataGridView1.Location = new System.Drawing.Point(12, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(344, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // Bname
            // 
            this.Bname.HeaderText = "name";
            this.Bname.Name = "Bname";
            // 
            // Bprice
            // 
            this.Bprice.HeaderText = "price";
            this.Bprice.Name = "Bprice";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "quantity";
            this.quantity.Name = "quantity";
            // 
            // Addquantity
            // 
            this.Addquantity.Location = new System.Drawing.Point(127, 95);
            this.Addquantity.Name = "Addquantity";
            this.Addquantity.Size = new System.Drawing.Size(100, 23);
            this.Addquantity.TabIndex = 1;
            // 
            // Addname
            // 
            this.Addname.Location = new System.Drawing.Point(12, 44);
            this.Addname.Name = "Addname";
            this.Addname.Size = new System.Drawing.Size(100, 23);
            this.Addname.TabIndex = 2;
            // 
            // Addprice
            // 
            this.Addprice.Location = new System.Drawing.Point(127, 44);
            this.Addprice.Name = "Addprice";
            this.Addprice.Size = new System.Drawing.Size(100, 23);
            this.Addprice.TabIndex = 3;
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(176, 495);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 23);
            this.total.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "quantity";
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(281, 47);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 74);
            this.Addbutton.TabIndex = 11;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "total";
            // 
            // pay
            // 
            this.pay.Location = new System.Drawing.Point(299, 495);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(46, 34);
            this.pay.TabIndex = 14;
            this.pay.Text = "pay";
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 561);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.Addprice);
            this.Controls.Add(this.Addname);
            this.Controls.Add(this.Addquantity);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox Addquantity;
        private TextBox Addname;
        private TextBox Addprice;
        private TextBox total;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Addbutton;
        private Label label5;
        private DataGridViewTextBoxColumn Bname;
        private DataGridViewTextBoxColumn Bprice;
        private DataGridViewTextBoxColumn quantity;
        private Button pay;
    }
}