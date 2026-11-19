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
    public partial class Form2 : Form
    {
        public Form2(double danielle, double edward , double fatima)
        {
            InitializeComponent();

            lblDanielleTotal.Text = $"₱{danielle:N2}";
            lblEdwardTotal.Text = $"₱{edward:N2}";
            lblFatimaTotal.Text = $"₱{fatima:N2}";

            double grandTotal =
                danielle + edward + fatima;

            lblGrandTotal.Text = "GRAND TOTAL: ₱" + grandTotal.ToString("N2");
        }

        private void Btn_Close_Click(
            object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
        