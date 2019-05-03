using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFrontEnd
{
    public partial class Form1 : Form
    {        
        Balloon myFirstBallon;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                //I must intantiate my object =)
                myFirstBallon = new Balloon()
                {
                    Colour = txtColor.Text.Trim(),
                    Diameter = Convert.ToDecimal(txtDiameter.Text),
                    Height = Convert.ToDecimal(txtHeight.Text),
                };
                //myFirstBallon.Colour = txtColor.Text.Trim();
                //myFirstBallon.Diameter = Convert.ToDecimal(txtDiameter.Text);
                //myFirstBallon.Height = Convert.ToDecimal(txtHeight.Text);
            }
            catch(DataException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            lblOutput.Text = $"Colour: {myFirstBallon.Colour}\n" +
            $"Height: {myFirstBallon.Height.ToString()}\n" +
            $"Diameter: {myFirstBallon.Diameter.ToString()}";
        }
    }
}
