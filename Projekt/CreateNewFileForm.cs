using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoP_RaEd
{
    public partial class CreateNewFileForm : Form
    {

        public CreateNewFileForm()
        {
            InitializeComponent();
            CBRatio.SelectedIndex = 0;
        }

        private void TBWidth_TextChanged(object sender, EventArgs e)
        {
            ValuesChanged();          
        }
        private void ValuesChanged()
        {
            if (TBWidth.Text != "")
            { 
                try
                {
                    checked
                    {
                        if (CBRatio.SelectedIndex == 1)
                        {
                            TBHeight.Text = "" + (int.Parse(TBWidth.Text));
                        }
                        else if (CBRatio.SelectedIndex == 2)
                        {
                            TBHeight.Text = "" + (int.Parse(TBWidth.Text) * 2);
                        }
                        else if (CBRatio.SelectedIndex == 3)
                        {
                            TBHeight.Text = "" + (int.Parse(TBWidth.Text) / 4 * 3);
                        }
                        else if (CBRatio.SelectedIndex == 4)
                        {
                            TBHeight.Text = "" + (int.Parse(TBWidth.Text) / 16 * 9);
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Number required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (OverflowException)
                {
                    MessageBox.Show("The number you entered is too high!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                int numberInput = int.Parse(TBHeight.Text);
                numberInput = int.Parse(TBWidth.Text);
                this.DialogResult = DialogResult.OK;
                this.Hide();

            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect input ", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number you entered is too damm high!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CBRatio_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void CBRatio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBRatio.SelectedIndex == 0)
            {
                TBHeight.Enabled = true;
            }
            else if(CBRatio.SelectedIndex >= 1)
            {
                TBHeight.Enabled = false;
            }
            ValuesChanged();
        }
    }
}
