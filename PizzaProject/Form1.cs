using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class FormPizzaOrder : Form
    {
        public FormPizzaOrder()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void radSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void radMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void radLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void radThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void radThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void radEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();

        }

        private void radTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            DialogResult dialogResultConfirm = MessageBox.Show(
                "Confirm Order",
                "Confirm",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (dialogResultConfirm == DialogResult.OK)
            {
                DialogResult dialogResultSuccessOrder = MessageBox.Show(
                    "Order Placed Successfully",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                if (dialogResultSuccessOrder == DialogResult.OK)
                {
                    grpContainer.Enabled = false;
                    btnOrderPizza.Enabled = false;
                }
            }
        }

        private void btnRestForm_Click(object sender, EventArgs e)
        {
            RestetForm();
        }

        private void RestetForm()
        {
            chkExtraChees.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatoes.Checked = false;
            chkGreenPeppers.Checked = false;
            radTakeOut.Checked = true;
            radSmall.Checked = true;
            radThinCrust.Checked = true;
            grpContainer.Enabled = true;
            btnOrderPizza.Enabled = true;
        }

        private void UpdateOrderSummary()
        {
            radThinCrust.Checked = true;
            radTakeOut.Checked = true;
            UpdateSize();
            UpdateCrustType();
            UpdateToppings();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }

        private void UpdateSize()
        {
            UpdateTotalPrice();

            if (radSmall.Checked)
            {
                labSizeResult.Text = "Small";
                return;
            }

            if (radMeduim.Checked)
            {
                labSizeResult.Text = "Meduim";
                return;
            }

            if (radLarg.Checked)
            {
                labSizeResult.Text = "Larg";
                return;
            }
        }

        private void UpdateCrustType()
        {
            UpdateTotalPrice();

            if (radThinCrust.Checked)
            {
                labCrustTypeResult.Text = "Thin Crust";
                return;
            }

            if (radThinkCrust.Checked)
            {
                labCrustTypeResult.Text = "Thick Crust";
                return;
            }


        }

        private void UpdateToppings()
        {
            UpdateTotalPrice();

            string sTopping = "";
            if (chkExtraChees.Checked)
            {
                sTopping += "Extra Chees";
            }

            if (chkMushrooms.Checked)
            {
                sTopping += ", Mushrooms";
            }

            if (chkGreenPeppers.Checked)
            {
                sTopping += ", Green Peppers";
            }

            if (chkOlives.Checked)
            {
                sTopping += ", Olives";
            }

            if (chkOnion.Checked)
            {
                sTopping += ", Onion";
            }

            if (chkTomatoes.Checked)
            {
                sTopping += ", Tomatoes";
            }

            if (sTopping.StartsWith(","))
            {
                sTopping = sTopping.Substring(1, sTopping.Length - 1).Trim();
            }

            if (sTopping == "")
            {
                sTopping = "No Toppings";
            }

            txtbToppingsResult.Text = sTopping;
        }

        private void UpdateWhereToEat()
        {
            UpdateTotalPrice();

            if (radEatIn.Checked)
            {
                labWhereEatResult.Text = "Eat In";
                return;
            }

            if (radTakeOut.Checked)
            {
                labWhereEatResult.Text = "Take Out";
                return;
            }
        }

        private float GetSelectedSizePrice()
        {
            if (radSmall.Checked)
            {
                return Convert.ToSingle(radSmall.Tag);
            }
            else if (radMeduim.Checked)
            {
                return Convert.ToSingle(radMeduim.Tag);
            }
            else
            {
                return Convert.ToSingle(radLarg.Tag);
            }
        }

        private float GetSelectedCrustTypePrice()
        {
            if (radThinkCrust.Checked)
            {
                return Convert.ToSingle(radThinkCrust.Tag);
            }
            else
            {
                return Convert.ToSingle(radThinCrust.Tag);
            }
        }

        private float GetSelectedWhereToEatPrice()
        {
            if (radEatIn.Checked)
            {
                return Convert.ToSingle(radEatIn.Tag);
            }
            else
            {
                return Convert.ToSingle(radTakeOut.Tag);
            }
        }

        private float CalculateToppingsPrice()
        {
            float price = 0;
            if (chkExtraChees.Checked)
            {
                price += Convert.ToSingle(chkExtraChees.Tag);
            }

            if (chkMushrooms.Checked)
            {
                price += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkGreenPeppers.Checked)
            {
                price += Convert.ToSingle(chkGreenPeppers.Tag);
            }

            if (chkOlives.Checked)
            {
                price += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkOnion.Checked)
            {
                price += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkTomatoes.Checked)
            {
                price += Convert.ToSingle(chkTomatoes.Tag);
            }
            return price;
        }

        private float calculateTotalPrice()
        {
            return GetSelectedSizePrice() + 
                CalculateToppingsPrice() + 
                GetSelectedCrustTypePrice() +
                GetSelectedWhereToEatPrice();
        }

        private void UpdateTotalPrice()
        {
            labTotalPriceResult.Text = $"${calculateTotalPrice().ToString()}";
        }

    }
}
