using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewProject.View;

namespace ViewProject
{
    public partial class SchermataPrincipaleView : UserControl
    {
        public SchermataPrincipaleView()
        {
            InitializeComponent();

            
        }

        private void buttonProfilo_Click(object sender, EventArgs e)
        {
            UserControl view = ViewFactory.GetView("ProfiloView");
            MainForm mainForm = (MainForm)this.FindForm();
            mainForm.SetView(view);

        }

        private void buttonProgressi_Click(object sender, EventArgs e)
        {
            UserControl view = ViewFactory.GetView("ProgressiView");
            MainForm mainForm = (MainForm)this.FindForm();
            mainForm.SetView(view);
        }

        private void buttonVideo_Click(object sender, EventArgs e)
        {
            UserControl view = ViewFactory.GetView("VideoView");
            MainForm mainForm = (MainForm)this.FindForm();
            mainForm.SetView(view);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            UserControl view = ViewFactory.GetView("CreaAccountView");
            MainForm mainForm = (MainForm)this.FindForm();
            mainForm.SetView(view);
        }

        private void buttonModificaScheda_Click(object sender, EventArgs e)
        {
            CreaSchedaManualeView view = (CreaSchedaManualeView)ViewFactory.GetView("CreaSchedaManualeView");
            MainForm mainForm = (MainForm)this.FindForm();
            view.buttonIndietro.Visible = true;
            view.buttonIndietro.Enabled = true;
            mainForm.SetView(view);
        }

        private void buttonFrase_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetFrase(), "La frase pensata per te:");
        }
        public string GetFrase()
        {
            int da = 1;
            int a = 43;
            Random random = new Random();
            int numeroCasuale = random.Next(da, a);
            string line = "";
            StringBuilder frase = new StringBuilder();

            System.IO.StreamReader file = new System.IO.StreamReader(@"../../Frasi.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (line.ElementAt(0).Equals('#'))
                {
                    line = line.Remove(0, 1);
                    if (line.Equals(numeroCasuale.ToString()))
                    {
                        while (!(line = file.ReadLine()).Equals("FINE"))
                        {
                            frase.Append(line);
                        }
                        file.Close();
                        return frase.ToString();
                    }
                }
            }
            file.Close();
            return frase.ToString();
        }
    }
}
