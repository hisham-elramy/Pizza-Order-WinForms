using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_App
{
    public partial class frmMakeYourPizza : Form
    {

        public frmMakeYourPizza()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdatePizzaPrice() 
        {
            int Price = 0;

            if (rbSmall.Checked)
                Price += 10;

            if (rbMedium.Checked)
                Price += 20;

            if (rbLarge.Checked)
                Price += 30;

            if (chkExtraCheese.Checked)
                Price += 5;

            if (chkMushrooms.Checked)
                Price += 5;

            if (chkTomatos.Checked)
                Price += 5;

            if (chkOnion.Checked)
                Price += 5;

            if (chkOlives.Checked)
                Price += 5;

            if (chkGreenPeppers.Checked)
                Price += 5;

            if (rbThinCrust.Checked)
                Price += 5;

            if (rbThickCrust.Checked)
                Price += 10;

            if (rbEatIn.Checked)
                Price += 5;

            string PriceInString = Price.ToString() + '$';

            lblUserTotalPrice.Text = PriceInString;
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            lblUserSize.Text = "Small";
            UpdatePizzaPrice();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            lblUserSize.Text = "Medium";
            UpdatePizzaPrice();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            lblUserSize.Text = "Large";

            UpdatePizzaPrice();
        }

        private void UpdatePizzaToppings()
        {
            string sToppings = "";

            if (chkExtraCheese.Checked)
                sToppings += "Extra Cheese, \n";
            
            if (chkMushrooms.Checked)
                sToppings += "Mushrooms, \n";
            
            if (chkTomatos.Checked)
                sToppings += "Tomatoes, \n";
            
            if (chkOnion.Checked)
                sToppings += "Onion, \n";
            
            if (chkOlives.Checked)
                sToppings += "Olives, \n";

            if (chkGreenPeppers.Checked)
                sToppings += "Green Peppers, \n";



            if (sToppings.Length > 2)
                lblUserToppings.Text = sToppings.Substring(0, sToppings.Length - 2);
            else
                lblUserToppings.Text = "No Toppings";

        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePizzaToppings();
            UpdatePizzaPrice();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePizzaToppings();
            UpdatePizzaPrice();
        }

        private void chkTomatos_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePizzaToppings();
            UpdatePizzaPrice();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePizzaToppings();
            UpdatePizzaPrice();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePizzaToppings();
            UpdatePizzaPrice();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePizzaToppings();
            UpdatePizzaPrice();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            lblUserCrustType.Text = "Thin";
            UpdatePizzaPrice();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            lblUserCrustType.Text = "Thick";
            UpdatePizzaPrice();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            lblUserWhereToEat.Text = "Eat In";
            UpdatePizzaPrice();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            lblUserWhereToEat.Text = "Take Out";
            UpdatePizzaPrice();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Confirm Order", "Confirm!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            gbSize.Enabled = false;
            gbCrust.Enabled = false;
            gbToppings.Enabled = false;
            gbWhereToEat.Enabled = false;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = true;
            gbCrust.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;

            this.ResetText();
        }
    }
}
