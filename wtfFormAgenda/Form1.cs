using System;
using System.Windows.Forms;
using System.IO;

namespace wtfFormAgenda {
    public partial class formAgenda : Form {
        public formAgenda() {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void txtTelemovel_KeyPress(object sender, KeyPressEventArgs e) {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8 ) {
                e.Handled = true;
            }
        }

        private void txtNomeCompleto_KeyPress(object sender, KeyPressEventArgs e) {
            if (Char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            limparFormulario();
        }

        public void limparFormulario() {
            txtNomeCompleto.Text = "";
            txtTelemovel.Text = "";
            dtpDataNascimento.Value = DateTime.Now;
            cboxGenero.Text = "Masculino";
        }

        private void btnGravar_Click(object sender, EventArgs e) {
            gravarNovaAgenda();
        }

        public void gravarNovaAgenda() {
            // Criando nova agenda //
            Agenda novaAgenda = new Agenda();
            novaAgenda.nomeCompleto = txtNomeCompleto.Text;
            novaAgenda.telemovel = txtTelemovel.Text;
            novaAgenda.dataNascimento = dtpDataNascimento.Value;
            novaAgenda.genero = cboxGenero.Text;

            // Gravar os dados em um ficheiro //
            TextWriter  arquivoAgenda = new StreamWriter(@"E:\ESCOLA\C#\Agendamento\agenda.txt", true);

            arquivoAgenda.WriteLine(" Nome completo : " + novaAgenda.nomeCompleto);
            arquivoAgenda.WriteLine(" Telemóvel : " + novaAgenda.telemovel);
            arquivoAgenda.WriteLine(" Data de nascimeto : " + novaAgenda.dataNascimento.ToShortDateString());
            arquivoAgenda.WriteLine(" Género : " + novaAgenda.genero + "\n\n");

            arquivoAgenda.Close();

            // Apresentação dos dados na tela //
            MessageBox.Show("\n Nome completo : "+ novaAgenda.nomeCompleto + "\n Telemóvel : "+ novaAgenda.telemovel + "\n Data de Nascimento : " + novaAgenda.dataNascimento.ToShortDateString() + "\n Género : "+ novaAgenda.genero);
        }
    }
}
