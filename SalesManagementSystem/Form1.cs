using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem
{
    public partial class SalesManagementSystem : Form
    {

        double Results;
        string options;



        double bed = 25;
        double skirt = 15;
        double shirt = 15;
        double dress = 20;
        double jumper = 10;
        double sport = 17;
        double boot = 30;
        double jacket = 25;
        double jean = 17;

        double Total, SubTotal, Tax = 4;

        public SalesManagementSystem()
        {
            InitializeComponent();
        }

        //================================functions=====================================================================
        private void ResetTextBox()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);
            };
            func(Controls);

        }

        //---------------------------------EnableTextBox-----------------------------------------------------------------

        private void EnableTextBox()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);

        }

        //---------------------------------EnableCheckBox-----------------------------------------------------------------

        private void EnableCheckBox()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);

        }

        //==============================================================================================================
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox19.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(0, 0));
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Sale Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(iExit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void SalesManagementSystem_Load(object sender, EventArgs e)
        {
            PicSales.Image = Properties.Resources.Icon;

            textBox19.Clear();
            EnableTextBox();
            ResetTextBox();
            EnableCheckBox();


        }

        private void ChkJeans_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkJeans.Checked)
            {
                TxtJeans.Text = "";
                TxtJeans.Enabled = true;

                TxtJeans.Focus();
                PicSales.Image = Properties.Resources.jeans;
            }
            else
            {
                TxtJeans.Text = "0";
                TxtJeans.Enabled = false;

                PicSales.Image = Properties.Resources.Icon;
            }
        }

        private void ChkJacket_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkJacket.Checked)
            {
                TxtJacket.Text = "";
                TxtJacket.Enabled = true;

                TxtJacket.Focus();
                PicSales.Image = Properties.Resources.jacket;
            }
            else
            {
                TxtJacket.Text = "0";
                TxtJacket.Enabled = false;

                PicSales.Image = Properties.Resources.Icon;
            }
        }

        private void ChkSport_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkSport.Checked)
            {
                TxtSport.Text = "";
                TxtSport.Enabled = true;

                TxtSport.Focus();
                PicSales.Image = Properties.Resources.sport;
            }
            else
            {
                TxtSport.Text = "0";
                TxtSport.Enabled = false;

                PicSales.Image = Properties.Resources.Icon;
            }
        }

        private void ChkDress_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkDress.Checked)
            {
                TxtDress.Text = "";
                TxtDress.Enabled = true;

                TxtDress.Focus();
                PicSales.Image = Properties.Resources.Dress;
            }
            else
            {
                TxtDress.Text = "0";
                TxtDress.Enabled = false;

                PicSales.Image = Properties.Resources.Icon;
            }
        }

        private void ChkSkirt_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkSkirt.Checked)
            {
                TxtSkirt.Text = "";
                TxtSkirt.Enabled = true;

                TxtSkirt.Focus();
                PicSales.Image = Properties.Resources.skirt;
            }
            else
            {
                TxtSkirt.Text = "0";
                TxtSkirt.Enabled = false;

                PicSales.Image = Properties.Resources.Icon;
            }
        }

        private void ChkBed_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkBed.Checked)
            {
                TxtBed.Text = "";
                TxtBed.Enabled = true;

                TxtBed.Focus();
                PicSales.Image = Properties.Resources.bed;
            }
            else
            {
                TxtBed.Text = "0";
                TxtBed.Enabled = false;

                PicSales.Image = Properties.Resources.Icon;
            }
        }

        private void ChkShirt_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkShirt.Checked)
            {
                TxtShirt.Text = "";
                TxtShirt.Enabled = true;

                TxtShirt.Focus();
                PicSales.Image = Properties.Resources.shirt;
            }
            else
            {
                TxtShirt.Text = "0";
                TxtShirt.Enabled = false;

                PicSales.Image = Properties.Resources.Icon;
            }
        }

        private void ChkBoot_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkBoot.Checked)
            {
                TxtBoot.Text = "";
                TxtBoot.Enabled = true;

                TxtBoot.Focus();
                PicSales.Image = Properties.Resources.boot;
            }
            else
            {
                TxtBoot.Text = "0";
                TxtBoot.Enabled = false;

                PicSales.Image = Properties.Resources.Icon;
            }
        }

        private void ChkJumper_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkJumper.Checked)
            {
                TxtJumper.Text = "";
                TxtJumper.Enabled = true;

                TxtJumper.Focus();
                PicSales.Image = Properties.Resources.jumpers;
            }
            else
            {
                TxtJumper.Text = "0";
                TxtJumper.Enabled = false;

                PicSales.Image = Properties.Resources.Icon;
            }
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            textBox19.Clear();
            EnableTextBox();
            ResetTextBox();
            EnableCheckBox();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if ((TxtDisplay.Text == "0"))
                TxtDisplay.Text = "";
        }

        private void Btn_Receipt_Click(object sender, EventArgs e)
        {
            textBox19.Clear();

            textBox19.AppendText("\t" + "David Fotsing Management System " + "\n");
            textBox19.AppendText("\t" + "\t" + "Douala Akwa Street" + "\n");
            textBox19.AppendText("=================================" + "\n");
            textBox19.AppendText("Jeans and jagers" + "\t" + "\t" + "\t"   + TxtJeans.Text + "\n");
            textBox19.AppendText("Coats Jacket    " + "\t" + "\t" + "\t" + TxtJacket.Text + "\n");
            textBox19.AppendText("Dress           " + "\t" + "\t" + "\t"  + TxtDress.Text + "\n");
            textBox19.AppendText("Sport Wears     " + "\t" + "\t" + "\t" + TxtSport.Text + "\n");
            textBox19.AppendText("Skirt           " + "\t" + "\t" + "\t" + TxtSkirt.Text + "\n");
            textBox19.AppendText("Jumpers         " + "\t" + "\t" + "\t" + TxtJumper.Text + "\n");
            textBox19.AppendText("Shirts          " + "\t" + "\t" + "\t" + TxtShirt.Text + "\n");
            textBox19.AppendText("Men Boots       " + "\t" + "\t" + "\t" + TxtBoot.Text + "\n");
            textBox19.AppendText("Bed sheet       " + "\t" + "\t"  + "\t" + TxtBed.Text + "\n" + "\n");
            textBox19.AppendText("SubTotal        " + "\t" + "\t" + "\t" + TxtSubTotal.Text + "\n");
            textBox19.AppendText("Tax             " + "\t" + "\t" + "\t" + TxtTax.Text + "\n");
            textBox19.AppendText("Total           " + "\t" + "\t" + "\t" + TxtTotal.Text + "\n");


            textBox19.AppendText("=================================" + "\n");
            textBox19.AppendText("\t" + "\t" + "Thank you" + "\n");

        }

        private void Btn_total_Click(object sender, EventArgs e)
        {

            SubTotal = (bed * Convert.ToDouble(TxtBed.Text)) + (boot * Convert.ToDouble(TxtBoot.Text)) + (jacket * Convert.ToDouble(TxtJacket.Text)) + (jean * Convert.ToDouble(TxtJeans.Text)) + (jumper * Convert.ToDouble(TxtJumper.Text)) + (skirt * Convert.ToDouble(TxtSkirt.Text)) + (shirt * Convert.ToDouble(TxtShirt.Text)) + (sport * Convert.ToDouble(TxtSport.Text)) + (dress * Convert.ToDouble(TxtDress.Text));

            Total = SubTotal + Tax;

            TxtTax.Text = string.Format("{0:C}", Tax);
            TxtSubTotal.Text = string.Format("{0:C}", SubTotal);
            TxtTotal.Text = string.Format("{0:C}", Total);

        }
    }
}
