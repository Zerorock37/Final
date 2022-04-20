namespace FinalProject_643450091_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            addRow(Addname.Text, Addprice.Text, Addquantity.Text);

            bool numTest;
            double num1 = Convert.ToDouble(Addprice.Text);
            double num2 = Convert.ToDouble(Addquantity.Text);
            double num3 = 0;
            double num4 = 0;
            numTest = Double.TryParse(total.Text, out num4);
            if (!numTest)
            {
                num3 += num1 * num2;
                total.Text = num3.ToString();
            }
            else if (numTest)
            {
                num3 += num1 * num2;
                num3 += num4;
                total.Text = num3.ToString();

            }
            void addRow(string Addname, string Addprice, string Addquantity)
              {
                  String[] row = { Addname, Addprice, Addquantity };
                   dataGridView1.Rows.Add(row);
               }
        }
        private void addRow(string Addname, string Addprice, string Addquantity)
        { 
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pay_Click(object sender, EventArgs e)
        {
            PayForm p=new PayForm();
            p.ShowDialog();
        }
    }
}