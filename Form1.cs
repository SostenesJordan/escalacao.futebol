using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Prova___tecnicas_de_programação
{
    public partial class Login : Form
    {
        Thread tela_2;
        public Login()
        {
            InitializeComponent();
        }
        // essa form tem por padrão um "user" e "senha" para entrar no sitema da form2.

        private void entrarBtn_Click(object sender, EventArgs e)
        {
            if (usuario.Text == "admin" && senha.Text == "admin")
            {
                //se a informação estiver correta ele vai iniciar a form:
                tela_2 = new Thread(Form_2);
                tela_2.SetApartmentState(ApartmentState.STA);
                tela_2.Start();
                
            }
            else
            {
                MessageBox.Show("Senha ou usuario incorreto!");
            }
        }

        private void Form_2()
        {
            Application.Run(new Form2());
        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void senha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
