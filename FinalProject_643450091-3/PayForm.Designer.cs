namespace FinalProject_643450091_3
{
    partial class PayForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Ptotal = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Bpay = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 1;
            // 
            // Ptotal
            // 
            this.Ptotal.AutoSize = true;
            this.Ptotal.Location = new System.Drawing.Point(23, 48);
            this.Ptotal.Name = "Ptotal";
            this.Ptotal.Size = new System.Drawing.Size(31, 15);
            this.Ptotal.TabIndex = 2;
            this.Ptotal.Text = "total";
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Location = new System.Drawing.Point(23, 100);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(44, 15);
            this.money.TabIndex = 3;
            this.money.Text = "money";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(23, 188);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 4;
            // 
            // Bpay
            // 
            this.Bpay.Location = new System.Drawing.Point(157, 66);
            this.Bpay.Name = "Bpay";
            this.Bpay.Size = new System.Drawing.Size(75, 75);
            this.Bpay.TabIndex = 5;
            this.Bpay.Text = "button1";
            this.Bpay.UseVisualStyleBackColor = true;
            this.Bpay.Click += new System.EventHandler(this.Bpay_Click);
            // 
            // change
            // 
            this.change.AutoSize = true;
            this.change.Location = new System.Drawing.Point(23, 170);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(46, 15);
            this.change.TabIndex = 6;
            this.change.Text = "change";
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 450);
            this.Controls.Add(this.change);
            this.Controls.Add(this.Bpay);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.money);
            this.Controls.Add(this.Ptotal);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "PayForm";
            this.Text = "PayForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label Ptotal;
        private Label money;
        private TextBox textBox3;
        private Button Bpay;
        private Label change;
    }
}