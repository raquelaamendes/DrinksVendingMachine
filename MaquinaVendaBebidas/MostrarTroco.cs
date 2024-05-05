using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaVendaBebidas
{
    public partial class MostrarTroco : Form
    {
        #region Variaveis do forms para mostrar o troco e respetivas moedas
        float troco = 0.00f;
        byte[] moedas;
        float[] valor;
        #endregion Variaveis do forms para mostrar o troco e respetivas moedas

        #region Troco e respetivas moedas
        //Tratamento do troco
        public MostrarTroco(byte[] quantidadeMoedasTroco, float[] moedasValor)
        {
            moedas = quantidadeMoedasTroco;
            valor = moedasValor;
            CalcularTroco();

            InitializeComponent();

            SetLabels();

            img2EUR.Parent = this;
            img1EUR.Parent = this;
            img50CENT.Parent = this;
            img20CENT.Parent = this;
            img10CENT.Parent = this;
            img5CENT.Parent = this;
        }

        //Calcular o valor do troco neste form para o mostrar
        private void CalcularTroco()
        {
            for (int i = 0; i < moedas.Length; i++)
            {
                troco += moedas[i] * valor[i];
                troco = (float)Math.Round(troco,2);
            }

        }

        //Alteração dos labels para mostrar troco e respetivas moedas
        private void SetLabels()
        {
            lblTrocoValor.Text = $"{troco.ToString("n2")}€";
            lbl2EURQuantidade.Text = moedas[0].ToString();
            lbl1EURQuantidade.Text = moedas[1].ToString();
            lbl50CENTQuantidade.Text = moedas[2].ToString();
            lbl20CENTQuantidade.Text = moedas[3].ToString();
            lbl10CENTQuantidade.Text = moedas[4].ToString();
            lbl5CENTQuantidade.Text = moedas[5].ToString();
        }

        private void btnAceitarTroco_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion Troco e respetivas moedas
    }
}
