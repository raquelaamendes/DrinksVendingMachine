using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaVendaBebidas
{
    public partial class SelecaoMoedas : Form
    {
        #region Variaveis do forms de selecionar as moedas
        public float valor;
        byte[] _quantidadeMoedasMaxMaquina;
        byte[] _quantidadeMoedasMaquina;
        #endregion Variaveis do forms de selecionar as moedas

        public SelecaoMoedas(byte[] quantidadeMoedasMaxMaquina, byte[] quantidadeMoedasMaquina)
        {
            InitializeComponent();
            _quantidadeMoedasMaquina = quantidadeMoedasMaquina;
            _quantidadeMoedasMaxMaquina = quantidadeMoedasMaxMaquina;

            disableMoedas(); //Verificar que moedeiros estão cheio e desativar a moeda respetiva

            btn2EUR.Parent = this;
            btn1EUR.Parent = this;
            btn50CENT.Parent = this;
            btn20CENT.Parent = this;
            btn10CENT.Parent = this;
            btn5CENT.Parent = this;
            btnBW2EUR.Parent = this;
            btnBW1EUR.Parent = this;
            btnBW50CENT.Parent = this;
            btnBW20CENT.Parent = this;
            btnBW10CENT.Parent = this;
            btnBW5CENT.Parent = this;

        }

        //Desativar a moeda quando o respetivo moedeiro estiver cheio
        private void disableMoedas()
        {
            for (int i = 0; i < _quantidadeMoedasMaquina.Length; i++)
            {
                if (_quantidadeMoedasMaquina[i] == _quantidadeMoedasMaxMaquina[i])
                {
                    switch (i)
                    {
                        case 0:
                            btn2EUR.Enabled = false;
                            btnBW2EUR.Visible = true;
                            break;
                        case 1:
                            btn1EUR.Enabled = false;
                            btnBW1EUR.Visible = true;
                            break;
                        case 2:
                            btn50CENT.Enabled = false;
                            btnBW50CENT.Visible = true;
                            break;
                        case 3:
                            btn20CENT.Enabled = false;
                            btnBW20CENT.Visible = true;
                            break;
                        case 4:
                            btn10CENT.Enabled = false;
                            btnBW10CENT.Visible = true;
                            break;
                        case 5:
                            btn5CENT.Enabled = false;
                            btnBW5CENT.Visible = true;
                            break;
                    }
                }

            }
        }

        #region Cliques das diferentes moedas
        private void btn2EUR_Click(object sender, EventArgs e)
        {
            //Somar o valor ao saldo e incrementar o moedeiro da moeda.
            valor = 2.00f;
            _quantidadeMoedasMaquina[0]++;
            Close();
        }

        private void btn1EUR_Click(object sender, EventArgs e)
        {
            //Somar o valor ao saldo e incrementar o moedeiro da moeda.
            valor = 1.00f;
            _quantidadeMoedasMaquina[1]++;
            Close();
        }

        private void btn50CENT_Click(object sender, EventArgs e)
        {
            //Somar o valor ao saldo e incrementar o moedeiro da moeda.
            valor = 0.50f;
            _quantidadeMoedasMaquina[2]++;
            //DESATIVAR A MOEDA SE JA ESTA NO MAX.
            Close();
        }

        private void btn20CENT_Click(object sender, EventArgs e)
        {
            //Somar o valor ao saldo e incrementar o moedeiro da moeda.
            valor = 0.20f;
            _quantidadeMoedasMaquina[3]++;
            //DESATIVAR A MOEDA SE JA ESTA NO MAX.
            Close();
        }

        private void btn10CENT_Click(object sender, EventArgs e)
        {
            //Somar o valor ao saldo e incrementar o moedeiro da moeda.
            valor = 0.10f;
            _quantidadeMoedasMaquina[4]++;
            //DESATIVAR A MOEDA SE JA ESTA NO MAX.
            Close();
        }

        private void btn5CENT_Click(object sender, EventArgs e)
        {
            //Somar o valor ao saldo e incrementar o moedeiro da moeda.
            valor = 0.05f;
            _quantidadeMoedasMaquina[5]++;
            //DESATIVAR A MOEDA SE JA ESTA NO MAX.
            Close();
        }

        private void btnCancelarMoeda_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion Cliques das diferentes moedas
    }
}
