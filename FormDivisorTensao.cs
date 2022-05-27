using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_DivisorTensao
{
    public partial class FormDivisorTensao : Form// : Conceito de erança 
    {
        double VR1, VR2, E1, R1, R2, I1;

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbCorrente.Text = "";
            txbFonte1.Text = "";
            txbR1.Text = " ";
            txbR2.Text = " ";
            txbVR1.Text = " ";
            txbVR2.Text = " ";
            txbFonte1.Focus();

        }

        void LeituraDados()
        {
            try // nao ocorreu erro
            {
                E1 = Convert.ToDouble(txbFonte1.Text.Trim());
                R1 = Convert.ToDouble(txbR1.Text.Trim());
                R2 = Convert.ToDouble(txbR2.Text.Trim());
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro na entrada de dados!.." + erro);
            }
        }

        public FormDivisorTensao()// construtor
        {
            InitializeComponent();//Sobe os componentes da camada visual
        }

        private void FormDivisorTensao_Load(object sender, EventArgs e)// metodo privado e vazio
        {
            txbVR1.Enabled = false;
            txbVR2.Enabled = false;
            txbCorrente.Enabled = false;
            MessageBox.Show("Informar a tensão em (volts)!..\nInformar o valor das resistencias em (Ohm)!..");//  mensagem aparece no monitor
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            LeituraDados();
            CalculosR obj_CalculosR = new CalculosR(); // objeto
            I1 = obj_CalculosR.corrente(E1, R1, R2);
            VR1 = obj_CalculosR.VR1(E1, R1, R2);
            VR2 = obj_CalculosR.VR2(E1, R1, R2);
            txbCorrente.Text = I1.ToString();
            txbVR1.Text = VR1.ToString();
            txbVR2.Text = VR2.ToString();
        }
    }
}
