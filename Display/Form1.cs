using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameToolbox.Elements;

namespace Display
{
    public partial class Form1 : Form
    {
        Die die = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void bnInstantiate_Click(object sender, EventArgs e)
        {
            die = new Die((uint)nudSides.Value, (int)nudSeed.Value, cbIZI.Checked);
            tbCPS.Text = die.ChancePerSide.ToString();
        }

        private void bnRoll_Click(object sender, EventArgs e)
        {
            try
            {
                if (nudCount.Value >= 1)
                {
                    Roll();
                }
                else throw new Exception("You cannot roll no dice.");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Roll()
        {
            float roll = 0;
            float rFac = 0;

            if (float.TryParse(tbFac.Text, out float rfac))
            {
                rFac = rfac;
            }
            
            for (int i = 0; i < nudCount.Value; i++)
            {
                if (die.Roll(out int res))
                {
                    if (i == 0) roll += res * rFac;
                    else
                    {
                        if (rbSubstract.Checked) roll -= res * rFac;
                        else if (rbMultiply.Checked) roll *= res * rFac;
                        else if (rbDivide.Checked) roll /= res * rFac;
                        else roll += res * rFac;
                    }
                }
                else throw new Exception($"The roll number {i + 1} was invalid.");
            }
            nudResult.Value = (decimal)roll;
        }

        private void ResChange(object sender, EventArgs e)
        {
            if (float.TryParse(tbResSca.Text, out float resSca))
            {
                tbScaRes.Text = ((float)nudResult.Value * resSca).ToString("0.000");
            }
            else throw new Exception("The scale is no valid number.");
        }

        private void ScaResChanged(object sender, EventArgs e)
        {
            float.TryParse(tbScaRes.Text, out float scaRes);
            float.TryParse(tbAdditiveModifier.Text, out float aM);
            float res = scaRes + aM;
            tbModifiedResult.Text = $"{res:0.000}";
        }
    }
}
