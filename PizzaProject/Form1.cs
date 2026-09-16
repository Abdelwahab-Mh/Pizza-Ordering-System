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
    public partial class Form1 : Form
    {
        string SelectSize()
        {
            UpdateTotalPrice();
            if (radioButtonSmall.Checked)
                return "Small";
            if (radioButtonLarge.Checked)
                return "Larg";
            return "Meduim";
        }
        string CrustType()
        {
            UpdateTotalPrice();
            if (radioButtonThinCrust.Checked)
                return "Thin";
             return "Think";
        }
        string WhereEat()
        {
            UpdateTotalPrice();
            if (radioButtonEatIn.Checked)
                return "Eat In";
            return "Take Out";
        }
        void UpdateToppings()
        {
            UpdateTotalPrice();
            string Toppings = "";
            if (chcExtraChees.Checked)
            {
                Toppings += "Extra Chees";
            }
            if (chcOnion.Checked)
            {
                Toppings += ", Onion";
            }
            if (chcMushrooms.Checked)
            {
                Toppings += ", Mushrooms";
            }
            if (chcOlives.Checked)
            {
                Toppings += ", Olives";
            }
            if (chcTomatoes.Checked)
            {
                Toppings += ", Tomatoes";
            }
            if (chcGreenPeppers.Checked)
            {
                Toppings += ", GreenPeppers";
            }
            if(Toppings.StartsWith(","))
            {
                Toppings = Toppings.Substring(1, Toppings.Length - 1).Trim();
            }
            if (Toppings == "")
                Toppings = "No Toppings";
            lblToppings.Text = Toppings;
        }


        float SizePrice()
        {
            if (radioButtonSmall.Checked)
                return Convert.ToSingle(radioButtonSmall.Tag);
            else if(radioButtonMeduim.Checked)
                    return Convert.ToSingle(radioButtonMeduim.Tag);
            else
                return Convert.ToSingle(radioButtonLarge.Tag);
        }
        float CrustTypePrice()
        {
            if (radioButtonThinCrust.Checked)
                return Convert.ToSingle(radioButtonThinCrust.Tag);
            else 
                return Convert.ToSingle(radioButtonThinkCrust.Tag);
        }
        float ToppingsPrice()
        {
            float TotalPrice = 0;
            if(chcExtraChees.Checked)
            {
                TotalPrice += Convert.ToSingle(chcExtraChees.Tag);
            }
            if(chcOnion.Checked)
            {
                TotalPrice += Convert.ToSingle(chcOnion.Tag);
            }
            if(chcMushrooms.Checked)
            {
                TotalPrice += Convert.ToSingle(chcMushrooms.Tag);
            }
            if(chcOlives.Checked)
            {
                TotalPrice += Convert.ToSingle(chcOlives.Tag);
            }
            if(chcTomatoes.Checked)
            {
                TotalPrice += Convert.ToSingle(chcTomatoes.Tag);
            }
            if(chcGreenPeppers.Checked)
            {
                TotalPrice += Convert.ToSingle(chcGreenPeppers.Tag);
            }
            return TotalPrice;
        }
        float CalcTotalPrice()
        {
            return SizePrice() + CrustTypePrice() + ToppingsPrice();
        }
        void UpdateTotalPrice()
        {
            lblPrice.Text="$"+CalcTotalPrice().ToString();
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonSmall_CheckedChanged(object sender, EventArgs e)
        {
            lblSize.Text = SelectSize();
        }

        private void radioButtonMeduim_CheckedChanged(object sender, EventArgs e)
        {
            lblSize.Text = SelectSize();
        }

        private void radioButtonLarge_CheckedChanged(object sender, EventArgs e)
        {
            lblSize.Text = SelectSize();
        }

        private void radioButtonThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            lblCrustType.Text = CrustType();
        }

        private void radioButtonThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            lblCrustType.Text = CrustType();
        }

        private void radioButtonEatIn_CheckedChanged(object sender, EventArgs e)
        {
            lblEat.Text = WhereEat();
        }

        private void radioButtonTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            lblEat.Text = WhereEat();
        }

        private void chcExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chcOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chcMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chcOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chcGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chcTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        void DisableAll()
        {
            gbCrustType.Enabled = false;
            gbEat.Enabled = false;
            gbSize.Enabled = false;
            gbToppings.Enabled = false;
        }
        void ResetAll()
        {
            gbCrustType.Enabled = true;
            gbEat.Enabled = true;
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            radioButtonMeduim.Checked = true;
            radioButtonEatIn.Checked = true;
            radioButtonThinCrust.Checked = true;
            UpdateTotalPrice();
            chcExtraChees.Checked = false;
            chcGreenPeppers.Checked = false;
            chcMushrooms.Checked = false;
            chcOlives.Checked = false;
            chcOnion.Checked = false;
            chcTomatoes.Checked = false;
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                MessageBox.Show("Order Done Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisableAll();
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectSize();
            CrustType();
            WhereEat();
            UpdateToppings();
            UpdateTotalPrice();
        }
    }
}
