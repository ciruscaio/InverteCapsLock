using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using InverteCapsLock.Code;

namespace InverteCapsLock
{
    public partial class frmPrincipal : Form
    {
        #region DECLARAÇÕES GLOBAIS

        //Para trabalhar com o teclado
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        //Nova tread
        Thread gThread = null;

        #endregion

        public frmPrincipal()
        {
            InitializeComponent();

            this.Location = new Point(0, 0);                                  
        }

        //AÇÕES
        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            try
            {
                ManipulaCapsLock.InverterSeNecessario();
            }
            catch
            {
                ExibirErro();
            }
        }

        private void nfiIconeBandeja_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.Show();
                nfiIconeBandeja.Visible = false;
            }
            catch
            {
                ExibirErro();
            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                nfiIconeBandeja.Visible = false;
            }
            catch
            {
                return;
            }
        }

        //AÇÕES DE BOTÕES
        private void btnInverter_Click(object sender, EventArgs e)
        {
            try
            {
                ManipulaCapsLock.Inverter();

                ExibirMensagem_Sucesso("Simples inversão realizada com sucesso!");
            }
            catch
            {
                ExibirErro();
            }
        }

        private void btnInverterSeNecessario_Click(object sender, EventArgs e)
        {
            try
            {
                ManipulaCapsLock.InverterSeNecessario();

                ExibirMensagem_Sucesso("Inversão lógica realizada com sucesso!");
            }
            catch
            {
                ExibirErro();
            }
        }

        private void btnInverterSeNecessarioEmSegundoPlano_Click(object sender, EventArgs e)
        {
            try
            {
                //Mensagem de confirmação
                DialogResult lResultado = MessageBox.Show("Caso queira continuar, lembre-se de que o sistema ficará escondido na bandeja do Windows (junto ao relógio). \n\nPara voltar a ver o sistema vá até a bandeja e clique duas vezes no ícone do programa. \n\n - Deseja continuar?",
                                                        "Atenção",
                                                        MessageBoxButtons.YesNo);

                //Caso sim:
                if (lResultado == DialogResult.Yes)
                {
                    //Esconde o formulário
                    this.Hide();

                    //Torna o icone da bandeja visível
                    nfiIconeBandeja.Visible = true;
                    nfiIconeBandeja.ShowBalloonTip(5000);

                    //Inicia uma nova thread
                    gThread = new Thread(NovaRotina);
                    gThread.Start();                   

                    //Altera o status
                    btnInverterSeNecessarioEmSegundoPlano.Enabled = false;
                    lblStatus.Visible = true;
                    btnParar.Visible = true;
                }
            }
            catch
            {
                ExibirErro();
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            try
            {
                gThread.Abort();

                //Altera o status
                btnInverterSeNecessarioEmSegundoPlano.Enabled = true;
                lblStatus.Visible = false;
                btnParar.Visible = false;               
            }
            catch
            {
                ExibirErro();
            }
        }

        //OUTRAS FUNÇÕES
        private void ExibirErro()
        {
            MessageBox.Show("CAUSAS PROVÁVEIS: \n\n - O .NET não está atualizado; \n\n - O antivirus está atuando equivocadamente; \n\n - O driver do teclado do seu computador está com problemas.",
                            "Ocorreu um Erro!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1);
        }

        private void ExibirMensagem_Sucesso(string pMenssagem)
        {
            MessageBox.Show(pMenssagem,
                            "Sucesso!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1);
        }

        #region LOGO
        private void lblCaio_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.caiobarbosa.com.br/");
            }
            catch
            {
                ExibirErro();
            }
        }


        private void lblBarbosa_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.caiobarbosa.com.br/");
            }
            catch
            {
                ExibirErro();
            }
        }


        private void pbxLogo_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.caiobarbosa.com.br/");
            }
            catch
            {
                ExibirErro();
            }
        }
        #endregion

        //NOVA TREAD
        private static void NovaRotina()
        {
            do
            {
                ManipulaCapsLock.InverterSeNecessario();
                
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(70));              
            } while (true);
        }

    }
}
