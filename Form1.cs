using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dagongdong_Activity5
{
    public partial class Form1 : Form
    {

        private double danielleTotal = 0;
        private double edwardTotal = 0;
        private double fatimaTotal = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void getSalesPerson_Amount(
            String salesInitial, double salesAmount)
        {
            string salesPersonName = " ";
            double currentTotal = 0;

            switch (salesInitial.ToUpper())
            {
                case "D":
                    danielleTotal = salesAmount;
                    salesPersonName = "Danielle";
                    currentTotal = danielleTotal;
                    break;

                case "E":
                    edwardTotal = salesAmount;
                    salesPersonName = "Edward";
                    currentTotal = edwardTotal;
                    break;

                case "F":
                    fatimaTotal = salesAmount;
                    salesPersonName = "Fatima";
                    currentTotal = fatimaTotal;
                    break;
            }
            lblOutput.Text = $"Output Area : \nSale recorded for {salesPersonName}: ₱{salesAmount:N2}\n" +
                $"{salesPersonName} Total: ₱{currentTotal:N2}";
        }

        private void clearEntry()
        {
            txtBoxInitial.Clear();
            txtBoxAmount.Clear();
            lblOutput.Text = "";
            txtBoxInitial.Focus();
        }


        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            string initial = txtBoxInitial.Text.Trim().ToUpper();
            double amount;

            // Check if salesperson initial is valid
            if (initial != "D" && initial != "E" && initial != "F")
            {
                MessageBox.Show("Please enter D, E, or F only.");
                return;
            }

            // Check if the amount is a valid number
            if (!double.TryParse(txtBoxAmount.Text.Trim(), out amount))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }

            // Check if the amount is positive
            if (amount <= 0)
            {
                MessageBox.Show("Please enter a positive sales amount.");
                return;
            }

            // Record the sale
            getSalesPerson_Amount(initial, amount);
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            clearEntry();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Form2 report = new Form2(
                danielleTotal,
                edwardTotal,
                fatimaTotal);

            report.ShowDialog();
        }
    }
}
