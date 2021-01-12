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

namespace Prova___tecnicas_de_programação
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //essas variaveis do tipo string são para converter as "textbox" para string e dps add no "richtextbox":
        string v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11;
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            v1 = Convert.ToString(textBox1.Text);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            v2 = Convert.ToString(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            v3 = Convert.ToString(textBox3.Text);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // botão para limpar os nomes das textbox e richtectbox
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
            textBox5.Clear(); textBox6.Clear(); textBox7.Clear(); textBox8.Clear();
            textBox9.Clear(); textBox10.Clear(); textBox11.Clear();
            richTextBox1.Clear();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //botão para abrir uma escalação anterior:
            openFileDialog1.Title = "Abrir escalação";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Filter = "Arquivo de Texto (*.txt)|*.txt|" +
                "Todos os Arquivos (*.*)|*.*";

            DialogResult dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader streamReader = new StreamReader(fileStream);
                    richTextBox1.Text = "";

                    string linha = streamReader.ReadLine();
                    while (linha != null)
                    {
                        richTextBox1.Text += linha + "\n";
                        linha = streamReader.ReadLine();
                    }
                    Text = openFileDialog1.FileName = " - escalação";
                    streamReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Botão para salvar escação atual:
            SaveFileDialog SalvarEscalacao = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "*.txt";
            
            SalvarEscalacao.Filter = "Arquivo de Texto (*.txt)|*.txt|" +
                "Todos os Arquivos (*.*)|*.*";
            SalvarEscalacao.Title = "nova escalação";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, new PointF(180, 415));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // esse botão é para imprimir o documento da escalação:
            printDialog1.Document = printDocument1;
            string texto = this.richTextBox1.Text;
            

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            v4 = Convert.ToString(textBox4.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            v5 = Convert.ToString(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            v6 = Convert.ToString(textBox6.Text);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            v7 = Convert.ToString(textBox7.Text);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            v8 = Convert.ToString(textBox8.Text);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            v9 = Convert.ToString(textBox9.Text);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            v10 = Convert.ToString(textBox10.Text);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            v11 = Convert.ToString(textBox11.Text);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            //aqui os nomes das "textbox" são add na rechtextbox :
            richTextBox1.AppendText(v1+"- CENTRO AVANTE" +"\n"); richTextBox1.AppendText(v2 +"-PONTA DIREITA "+ "\n"); richTextBox1.AppendText(v3 +"-PONTA ESQUERDA" + "\n"); richTextBox1.AppendText(v4 +"-MEIO CAMPO"+ "\n");
            richTextBox1.AppendText(v4 +"-VOLANTE"+ "\n"); richTextBox1.AppendText(v5 +"-VOLANTE"+ "\n"); richTextBox1.AppendText(v6 +"-LATERAL ESQUERDO"+ "\n"); richTextBox1.AppendText(v7 +"-ZAGUEIRO"+ "\n");
            richTextBox1.AppendText(v8 +"-ZAGUEIRO"+ "\n"); richTextBox1.AppendText(v9 +"-ZAGUEIRO"+ "\n"); richTextBox1.AppendText(v10 + "-LATERAL DIREITA" + "\n"); richTextBox1.AppendText(v11 +"-GOLEIRO"+ "\n");
        }






    }
}
