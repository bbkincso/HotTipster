using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AdvancedProgCA4
{
    public partial class Form1 : Form
    {
        myMethods m = new myMethods();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            
            string result="";
            try
            {
                rtbDisplay.Text = m.ShowAllRecords(result);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //checking if the user provides all the neccessary (valid) data. For datatimepicker and radiobox there is a default value
           if (txtRaceCourse.Text == string.Empty || txtAmount.Text == string.Empty)
            {
                MessageBox.Show("Please provide all information!");
            }
            else
            {
                string raceCourse = txtRaceCourse.Text;
                string date = dtpDate.Text;
                DateTime date2 = Convert.ToDateTime(date);
                try
                {
                    decimal amount = decimal.Parse(txtAmount.Text);

                    string status = "true";
                    if (rdoWon.Checked)
                    {
                        status = "true";
                    }
                    else
                    {
                        status = "false";
                    }
                    try
                    {
                        m.AppendData(raceCourse, date2, amount, status.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    txtRaceCourse.Clear();
                    txtAmount.Clear();
                }
                catch
                {
                    MessageBox.Show("Please provide valid amount!");
                }               
            }          
        }

        private void btnOrderByDate_Click(object sender, EventArgs e)
        {
            rtbDisplay.ResetText();
            string result = "";
            try
            {
                rtbDisplay.Text = m.ShowByDate(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            btnWrite.Enabled = false;
            try
            {
                m.WriteTofile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnTotalProfitLoss_Click(object sender, EventArgs e)
        {
            txtRaceCourse.Clear();
            string result = "";
            try
            {
                rtbDisplay.Text = m.ShowTotalsByYear(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnMostValues_Click(object sender, EventArgs e)
        {
            string result = "";
            try
            {
                lblHighest.Text = m.HighestWonMostLost(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnMostPopRaceCourse_Click(object sender, EventArgs e)
        {
            string result = "";
            try
            {
                lblPopularRCourse.Text = m.MostPopularRaceCourse(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnEfficiency_Click(object sender, EventArgs e)
        {
            string result = "";
            try
            {
                lblEfficiency.Text = m.Success(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
