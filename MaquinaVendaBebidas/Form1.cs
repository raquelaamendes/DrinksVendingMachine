//FEITO POR: Raquel Mendes
//Avaliação da UFCD 5412 Programação de computadores - estruturada
//*****************************************************************
//OBSERVAÇÕES:
//Não criei uma class bebidas exatamente por ser avaliação de programação estruturada

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MaquinaVendaBebidas
{
    public partial class Form1 : Form
    {
        #region Variaveis Form1
        //Valor colocado na maquina pelo utilizador
        float saldo = 0.00f;

        //Bebidas e respetivo valor em €
        //Cafe, Cappuccino, Chocolate, Chá
        string[] nomesBebidas = { "Café", "Cappuccino", "Chocolate", "Chá" };
        float[] valorBebidas = { 0.25f, 0.30f, 0.35f, 0.20f };

        //Quantidade de moedas maximas no segundo moedeiro (moedas colocadas pelo utilizador)
        //2eur, 1eur, 50cent, 20cent, 10cent, 5cent
        byte[] quantidadeMoedasMaxMaquina = { 5, 10, 35, 40, 45, 65 };

        //Quantidade de moedas no moedeiro da maquina pela ordem:
        //2eur, 1eur, 50cent, 20cent, 10cent, 5cent
        //Array usado para testar manutenção:
        //byte[] quantidadeMoedasMaquina = { 5, 10, 35, 39, 44, 0 };
        byte[] quantidadeMoedasMaquina = { 1, 5, 20, 25, 30, 40 };
         

        //Quantidade de moedas no troco pela ordem:
        //2eur, 1eur, 50cent, 20cent, 10cent, 5cent
        byte[] quantidadeMoedasTroco = { 0, 0, 0, 0, 0, 0 };

        float[] moedasValor = { 2.00f, 1.00f, 0.50f, 0.20f, 0.10f, 0.05f };
        #endregion Variaveis Form1

        public Form1()
        {
            InitializeComponent();

            imgMoedaTroco.Parent = this.imgMaquinaBebidas;
            imgColocarMoeda.Parent = this.imgMaquinaBebidas;
            btnTrocoGrande.Parent = this.imgMaquinaBebidas;
            btnCafe.Parent = this.imgMaquinaBebidas;
            btnCappuccino.Parent = this.imgMaquinaBebidas;
            btnChocolate.Parent = this.imgMaquinaBebidas;
            btnCha.Parent = this.imgMaquinaBebidas;
            imgCopo.Parent = this.imgMaquinaBebidas;
            lblVisor.Parent = this.imgMaquinaBebidas;
            imgRanhura.Parent = this.imgMaquinaBebidas;
        }
        #region botoes das bebidas
        private void btnCafe_Click(object sender, EventArgs e)
        {
            OpcoesBebidas(0);
        }

        private void btnCappuccino_Click(object sender, EventArgs e)
        {
            OpcoesBebidas(1);
        }

        private void btnChocolate_Click(object sender, EventArgs e)
        {
            OpcoesBebidas(2);
        }

        private void btnCha_Click(object sender, EventArgs e)
        {
            OpcoesBebidas(3);
        }
        #endregion botoes das bebidas

        //Tratamento do clique dos botoes das bebidas
        private void OpcoesBebidas(int bebida)
        {
            bool verif;
            if (saldo == 0.00)
            {
                lblVisor.Text = $"{nomesBebidas[bebida]} - {valorBebidas[bebida].ToString("n2")}€";
                timer1.Interval = 1000;
                timer1.Start();
            }
            else if (saldo < valorBebidas[bebida])
            {
                lblVisor.Text = "Saldo insuficiente";
                timer2.Interval = 1000;
                timer2.Start();
            }
            else //saldo suficiente
            {

                verif = ExisteTroco(saldo - valorBebidas[bebida]);
                if (verif)
                {
                    saldo -= valorBebidas[bebida];
                    lblVisor.Text = "Retire a bebida";

                    //Desativar botoes
                    OnOff(false);

                    //Ativar o copo
                    imgCopo.Visible = true;
                    imgCopo.Enabled = true;
                }
                else
                {
                    lblVisor.Text = "Sem troco";
                    timer2.Interval = 1000;
                    timer2.Start();
                }
            }
        }

        //Verificar se existe troco na máquina para a bebida que o utilizador quer
        private bool ExisteTroco(float trocoFinal)
        {
            float troco = trocoFinal;
            for (byte i = 0; i < quantidadeMoedasMaquina.Length; i++)
            {
                while (quantidadeMoedasMaquina[i] > 0 && troco >= moedasValor[i])
                {
                    troco -= moedasValor[i];
                    troco = (float)Math.Round(troco, 2);
                }

                if (troco == 0.00)
                {
                    return true;
                }
            }
            return false;
        }

        //Retirar bebida e receber troco
        private void imgCopo_Click(object sender, EventArgs e)
        {
            lblVisor.Text = $"Troco: {saldo.ToString("n2")}€";
            ReceberTroco();
            imgMoedaTroco.Visible = true;
            imgMoedaTroco.Enabled = true;
            imgRanhura.Enabled = false;
            imgCopo.Visible = false;
        }

        //Ativar/Desativar botoes de bebidas e botão retirar moedas
        private void OnOff(bool estado)
        {

            btnTrocoGrande.Enabled = estado;
            btnCha.Enabled = estado;
            btnCafe.Enabled = estado;
            btnCappuccino.Enabled = estado;
            btnChocolate.Enabled = estado;

        }

        #region Ranhura da moeda
        private void imgRanhura_MouseHover(object sender, EventArgs e)
        {
            imgColocarMoeda.Visible = true;
        }

        private void imgColocarMoeda_MouseLeave(object sender, EventArgs e)
        {
            imgColocarMoeda.Visible = false;
        }

        private void imgColocarMoeda_Click(object sender, EventArgs e)
        {
            SelecaoMoedas j1 = new SelecaoMoedas(quantidadeMoedasMaxMaquina, quantidadeMoedasMaquina);
            this.Enabled = false;
            j1.Show();
            j1.FormClosed += j1_FormClosed;
        }
        #endregion

        //Quando o utilizador seleciona um moeda ou cancela
        //o form é fechado e devolve o valor da moeda selecionada
        //o valor que é recebido do form, é adicionado ao saldo
        private void j1_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (sender != null)
            {
                SelecaoMoedas j1 = (SelecaoMoedas)sender;
                saldo += j1.valor;
                saldo = (float)Math.Round(saldo, 2);
            }
            this.Enabled = true;
            lblVisor.Text = $"Saldo: {saldo.ToString("n2")}€";
            btnTrocoGrande.Enabled = true;
        }

        //Se existir saldo na máquina o botão grande de retirar o saldo é ativo
        //para o caso do utilizador desistir de comprar bebida
        private void btnTrocoGrande_Click(object sender, EventArgs e)
        {
            if (saldo > 0)
            {
                ReceberTroco();
                imgMoedaTroco.Visible = true;
                imgMoedaTroco.Enabled = true;
                imgRanhura.Enabled = false;
            }
        }

        //Distribuir as moedas do troco para depois serem mostradas
        private void ReceberTroco()
        {
            for (byte i = 0; i < quantidadeMoedasMaquina.Length; i++)
            {
                while (quantidadeMoedasMaquina[i] > 0 && saldo >= moedasValor[i])
                {
                    saldo -= moedasValor[i];
                    saldo = (float)Math.Round(saldo, 2);
                    quantidadeMoedasMaquina[i]--;
                    quantidadeMoedasTroco[i]++;
                }

                if (saldo == 0.00)
                {
                    break;
                }
            }
        }

        //Mostrar o troco e as respetivas moedas ao utilizador
        private void imgMoedaTroco_Click(object sender, EventArgs e)
        {
            imgRanhura.Enabled = true;
            lblVisor.Text = "Em funcionamento";
            ReceberTroco();
            MostrarTroco j2 = new MostrarTroco(quantidadeMoedasTroco, moedasValor);
            this.Enabled = false;
            j2.Show();
            j2.FormClosed += j2_FormClosed;
        }

        //Quando o form de mostrar o troco é fechado
        //o saldo volta a ser 0€
        //limpo o array das moedas para o troco
        private void j2_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            imgMoedaTroco.Visible = false;
            saldo = 0.00f;
            for (int i = 0; i < quantidadeMoedasTroco.Length; i++)
            {
                quantidadeMoedasTroco[i] = 0;
            }

            OnOff(true);
            VerificaManutencao();
        }

        #region manutenção da maquina
        private void VerificaManutencao()
        {
            bool manutencao = false;

            //Moedeiro de 2EUR, 1EUR, 5CENT e 20CENT estão cheios
            if (quantidadeMoedasMaquina[0] == quantidadeMoedasMaxMaquina[0]
                && quantidadeMoedasMaquina[1] == quantidadeMoedasMaxMaquina[1]
                && quantidadeMoedasMaquina[2] == quantidadeMoedasMaxMaquina[2]
                && quantidadeMoedasMaquina[3] == quantidadeMoedasMaxMaquina[3])
            {
                //Moedeiro de 10CENT tem espaço para uma moeda(max-1) e a bebida mais barata é 20 cent
                if (quantidadeMoedasMaquina[4] >= (quantidadeMoedasMaxMaquina[4] - 1))
                {
                    //Moedeiro de 5CENT tem espaço para tres moedas (max-3) (0.15) e a bebida mais barata é 20 cent
                    if (quantidadeMoedasMaquina[5] >= quantidadeMoedasMaxMaquina[5] - 3)
                    {
                        manutencao = true;
                    }
                }
            }

            if (manutencao)
            {
                //lblVisor.Text = "Em manutenção";
                DesativarMaquina();
                //this.Enabled = false;
            }
        }

        //Desativar a maquina quando entra em manutenção
        private void DesativarMaquina()
        {
            lblVisor.Text = "Em manutenção";
            btnTrocoGrande.Enabled = false;
            btnCappuccino.Enabled = false;
            btnCafe.Enabled = false;
            btnCha.Enabled = false;
            btnChocolate.Enabled = false;
            imgRanhura.Enabled = false;
            imgColocarMoeda.Enabled = false;
            imgMoedaTroco.Enabled = false;
            imgCopo.Enabled = false;

        }
        #endregion manutenção da maquina

        #region timers
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            lblVisor.Text = "Em funcionamento";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();

            lblVisor.Text = $"Saldo: {saldo.ToString("n2")}€";
        }
        #endregion timers
    }
}
