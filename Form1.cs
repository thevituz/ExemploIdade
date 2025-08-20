using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploIdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            // Verificar se o campo está vazio:
            if (txtNome.Text == "")
            {
                MessageBox.Show("Digite o seu nome!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                // Pegar os Valores do Form:
                string nome = txtNome.Text;
                DateTime dataNascimento = dtpNascimento.Value;
                
                // Calcular a idade da pessoa:
                int idade = DateTime.Now.Year - dataNascimento.Year;

                // Verificar se o usuário tem menos de 16 anos:
                if (idade < 16)
                {
                    pibResultado.Image = Properties.Resources.deslike_png;
                    lblResultado.Text = $"{nome} tem {idade} anos\n não pode matricular no senac";
                }
                else
                {
                    // Mudar a imagem:
                    pibResultado.Image = Properties.Resources.ok_png;
                    lblResultado.Text = $"{nome} tem {idade} anos\n e já pode matricular no senac";
                }
            }
        }


    }
}
