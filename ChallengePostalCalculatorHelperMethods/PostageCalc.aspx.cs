using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculatorHelperMethods
{
    public partial class PostageCalc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void generateParcelPrice(object sender, EventArgs e)
        {
            calculateVolume();
            calculatePrice();
        }

        //====================================================================//

        /*
        double volume = 0.0;
        double price = 0.0;

        private void calculateVolume()
        {
            double width = Double.Parse(widthTextBox.Text.Trim());
            double height = Double.Parse(heightTextBox.Text.Trim());

            bool lengthBool = Double.TryParse(lengthTextBox.Text.Trim(), out double length);
            
            if (!lengthBool) volume = width * height;
            else
            {
                length = Double.Parse(lengthTextBox.Text);
                volume = width * height * length;
            }

            return;
        }

        private void calculatePrice()
        {
            if (groundRadio.Checked) price = volume * .15;
            else if (airRadio.Checked) price = volume * .25;
            else price = volume * .45;
            resultLabel.Text = "$" + price.ToString();
        }
        */
        //====================================================================//

        double volume;

        private void calculateVolume()
        {

            if (widthTextBox.Text.Trim().Length == 0 
                || heightTextBox.Text.Trim().Length == 0
                || !Double.TryParse(widthTextBox.Text, out double width)
                || !Double.TryParse(heightTextBox.Text, out double height))
            {
                resultLabel.Text = "Please enter both width and height.";
                return;
            }
            else if (lengthTextBox.Text.Trim().Length == 0
                || !Double.TryParse(lengthTextBox.Text, out double length))
            {
                volume = width * height;
                return;
            }
            else volume = width * height * length;
            return;
        }

        private void calculatePrice()
        {
            double price;

            if (groundRadio.Checked) price = volume * .15;
            else if (airRadio.Checked) price = volume * .25;
            else if (nextDayRadio.Checked) price = volume * .45;
            else return;

            resultLabel.Text = "$" + price.ToString();
        }

    }
}