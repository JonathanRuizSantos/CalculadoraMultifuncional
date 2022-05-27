using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Calculadora
{
    public partial class Form1 : Form
    {
        double x, y,z,a,b,c, r,r2,r3;
        CalcBasica cbasica;
        string men;
        string fx;
        string fxy;
        string fxyz;
        string s;

        
        public Form1()
        {
            InitializeComponent();
            cbasica = new CalcBasica();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Suma(x, y, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-proceso-salida");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.resta(x, y, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de Entrada-Proceso-Salida");
            }
        }

        private void Producto_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Producto(x, y, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de Entrada-Proceso-Salida");
            }
        }

        private void Division_Click(object sender, EventArgs e)
        {
            try{ 
            Entrada();
            men=cbasica.Division(x, y, ref r);
            Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
    }

        private void Cos_Click(object sender, EventArgs e)
        {
            try { 
            Entrada();
            men = cbasica.Coseno(x, ref r);
            Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void Seno_Click(object sender, EventArgs e)
        {

            try
            {
                Entrada();
                men = cbasica.Seno(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void XelevadoY_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Potencia(x, y, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-proceso-salida");
            }
        }

        private void Secante_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Secante(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-proceso-salida");
            }
        }

        private void Factorial_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Factoriales(x,ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-proceso-salida");
            }
        }

        private void btfx_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.fu(x,fx, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void Cosh_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Cosh(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void fxy_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.fu2(x,y, fxy, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void btfl_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.raizcuadrada(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-proceso-salida");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.logaritmo(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-proceso-salida");
            }
        }

        private void Tang_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Tangente(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-proceso-salida");
            }
        }

        private void Sinh_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Sinh(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-proceso-salida");
            }
        }

        private void Tanh_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Tanh(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-proceso-salida");
            }
        }

        private void Arcos_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Arcos(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-proceso-salida");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Asin(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-proceso-salida");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Atan(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-proceso-salida");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Cosec(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-proceso-salida");
            }
        }

        private void Cotan_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Cotan(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-proceso-salida");
            }
        }

        private void Xp2_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Xpot2(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-proceso-salida");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Xpot3(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-proceso-salida");
            }
        }

        private void btLog10_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.logaritmo10(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-proceso-salida");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Absoluto(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-proceso-salida");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Maximo(x,y ,ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-proceso-salida");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Exponencial(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-proceso-salida");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Minimo(x, y, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-proceso-salida");
            }
        }

        private void fIRMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WFRuizSJ.exe");
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.RadGrad(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-proceso-salida");
            }
        }

        private void btonGR_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.GradRad(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-proceso-salida");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.FormGeneral(x, y, z, ref r,ref r2,ref s);
                Salida2(r,r2);
                
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void btTeoPit_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.TeoPitagoras(x,y ,ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-proceso-salida");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.AreaCuadrado(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.AreaRectangulo(x,y, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.AreaTriangulo(x, y, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.AreaTrapezoide(x, y, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void btACirculo_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.AreaCirculo(x, y, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void btASCubo_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.SupAreaCubo(x, y, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void btASCilindro_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.SupAreaCilindro(x, y, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void btASCono_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.SupAreaCono(x, y, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void btASEsfera_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.SupAreaesfera(x, y, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void btVolCubo_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.VolumenCubo(x, y, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void btColCilindro_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.VolumenCilindro(x, y, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void btVolCono_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.VolumenCono(x, y, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void btVolEsfera_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.VolumenEsfera(x, y, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.RSerie(x, y,z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void btRparalelo_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.RParalelo(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void btCserie_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.CSerie(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void btCparelelo_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.CParalelo(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.MCM(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void btmmm_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.MMM(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void btcmmm_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.CMMM(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void btkmm_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.KMM(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void btmft_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.MF(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void btmy_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.MY(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void btftcm_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.FCM(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void btftpulg_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.FP(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void btpulgcm_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.PCM(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void buttonmkm_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.MKM(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void buttonlbg_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.LG(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void buttonkglb_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.KGL(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void buttoncm3ml_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.CM3ML(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void buttonlcm3_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.LTCM3(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void buttonltdm3_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.LTDM3(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void buttonGalLt_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.GLT(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.pFnF(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.pFmF(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.nFpF(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.nFmF(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.mFnF(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.mFpF(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void buttonVoltaje_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.ohmVoltaje(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void buttonCorriente_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.ohmCorriente(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void btResistencia_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.ohmResistencia(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void buttonFPBFC_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.FPBFC(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.GOPAMS(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void buttonPotencia_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Poten(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void buttonDif_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Diferencia(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void buttonRD3_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.RD3(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void buttonRD3num_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.RD3num(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void buttonVelocidad_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Velocidad(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void buttonDist_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Distan(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void buttonPeriodo_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Periodo(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void buttonPW_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.PW(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void buttonFrec_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Frecuencia(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void buttonFrecAng_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.FrecAng(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void buttontao_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.Tao(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void buttonXYZ_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.XYEZ(x, y, z, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        private void bt555C1_Click(object sender, EventArgs e)
        {
            

        }

        private void bt555C3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CalculadoraR1R2C1-555C1C2C3.exe");
        }

        private void btGraficadorfx_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("GraficadorV5_P20.exe");
        }

        private void bt555C2_Click(object sender, EventArgs e)
        {
            
        }

        private void bt555C1NR_Click(object sender, EventArgs e)
        {
           
        }

        private void bt555C1T2_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = cbasica.fu3(x, y,z, fxyz, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de entrada-Proceso-Salida");
            }
        }

        public void Entrada()
        {
            try { 
            x = double.Parse(tbd1.Text);
            y = double.Parse(tbd2.Text);
            z = double.Parse(tbd3.Text);
            a = double.Parse(tbd4.Text);
            b = double.Parse(tbd5.Text);
            c = double.Parse(tbd6.Text);
            fx = tbfx.Text;
            fxy = tbfxy.Text;
            fxyz = tbfxyz.Text;

            }
            catch {
                MessageBox.Show("Error de datos");
                    }
        }
        public void Salida(double r)
        {
            listBoxSalida.Items.Add(r);
            textBoxmensaje.Text = men;
        }
        public void Salida2(double r,double r2)
       {
            listBoxSalida.Items.Add(r);
            listBoxSalida.Items.Add(r2);
            textBoxmensaje.Text = men;
        }
        public void Salida3(double r, double r2,double r3)
        {
            listBoxSalida.Items.Add(r);
            listBoxSalida.Items.Add(r2);
            listBoxSalida.Items.Add(r3);
            textBoxmensaje.Text = men;
        }
    }
}
