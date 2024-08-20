using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace AmigoSecreto
{
    public partial class Form1 : Form
    {
        private ArrayList ListaParticipantes;

        public Form1()
        {
            InitializeComponent();
        }


        private void CarregaParticipantes()
        {
            string text = "";
            ListaParticipantes = new ArrayList();
            using (StreamReader streamReader = File.OpenText("Participantes.txt"))
            {
                while (!streamReader.EndOfStream)
                {
                    text = streamReader.ReadLine();
                    ListaParticipantes.Add(text);
                }
                streamReader.Close();
            }
            if (chkEmbaralhar.Checked)
            {
                int count = ListaParticipantes.Count;
                Random random = new Random();
                for (int i = 0; i < ListaParticipantes.Count; i++)
                {
                    int index = random.Next(count);
                    string value = ListaParticipantes[i].ToString();
                    ListaParticipantes[i] = ListaParticipantes[index];
                    ListaParticipantes[index] = value;
                }
            }
            lstParticipantes.Items.Clear();
            lstParticipantes.Items.AddRange(ListaParticipantes.ToArray());
        }

        private void cmdCarregar_Click(object sender, EventArgs e)
        {
            CarregaParticipantes();
            cmdSortear.Enabled = true;
            cmdCarregar.Enabled = false;
        }

        private void cmdReiniciar_Click(object sender, EventArgs e)
        {
            cmdReiniciar.Enabled = false;
            cmdCarregar.Enabled = true;
        }

        private void cmdSortear_Click(object sender, EventArgs e)
        {
            cmdSortear.Enabled = false;
            int count = lstParticipantes.Items.Count;
            string[] array = new string[count];
            string[] array2 = new string[count];
            int i = 0;
            string text = "Sorteio" + DateTime.Now.ToString("yyyyMMdd-HHmmss");
            for (int j = 0; j < count; j++)
            {
                array[j] = lstParticipantes.Items[j].ToString();
            }
            Random random = new Random();
            for (; i < count; i++)
            {
                int num = random.Next(count);
                while (lstParticipantes.Items[num].Equals("*") || array[i].Equals(array[num]))
                {
                    num = random.Next(count);
                }
                array2[i] = array[num];
                if (chkExibir.Checked)
                {
                    MessageBox.Show(array[i].ToString() + " -> " + array2[i].ToString());
                }
                Directory.CreateDirectory(text);
                StreamWriter streamWriter = File.CreateText(Path.Combine(text, array[i].ToString() + ".txt"));
                streamWriter.Write(array2[i].ToString());
                streamWriter.Close();
                lstParticipantes.Items[num] = "*";
            }
            cmdReiniciar.Enabled = true;
        }
    }
}
