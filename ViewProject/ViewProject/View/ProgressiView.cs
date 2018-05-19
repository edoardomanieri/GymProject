using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ViewProject.View;

namespace ViewProject
{
    public partial class ProgressiView : UserControl
    {
        public ProgressiView()
        {
            InitializeComponent();
        }

        private void buttonSalvaAllenamento_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Confermi di voler salvare l'allenamento del " + dateTimePickerDataAllenamento.Value.Day.ToString() + "/" + dateTimePickerDataAllenamento.Value.Month.ToString() + "/" + dateTimePickerDataAllenamento.Value.Year.ToString() + " ?","", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {

                /*
                numeroAllenamenti++;
                labelContatore.Text = numeroAllenamenti.ToString();
                //chart1.DataSource = new List<Allenamento>();
                chartDurata.Series["Durata"].Points.AddXY(dateTimePickerDataAllenamento.Value.Day.ToString() + "/" + dateTimePickerDataAllenamento.Value.Month.ToString(), numericUpDownDurataProgressi.Value);
                chartPeso.Series["Peso"].Points.AddXY(dateTimePickerDataAllenamento.Value.Day.ToString() + "/" + dateTimePickerDataAllenamento.Value.Month.ToString(), numericUpDownPesoProgressi.Value);
                if (progressBarAllenamenti.Value < 20)
                    progressBarAllenamenti.Value++;
                try
                {
                    circularProgressBar.Text = circularProgressBar.Value.ToString() + "%";
                    circularProgressBar.Value += 5;
                    
                }
                catch
                {

                }

    */
            }
        }

        private void buttonIndietroProgressi_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.FindForm();
            UserControl view = (SchermataPrincipaleView)ViewFactory.GetView("SchermataPrincipaleView");
            mainForm.SetView(view);
        }
    }
}
