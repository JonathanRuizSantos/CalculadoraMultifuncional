using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using info.lundin.math;

namespace WF_Calculadora
{
    internal class CalcBasica
    {
        double x, y, r;
        double f;
        double C1;
        double T;
        double T1;
        double T2;
        double R2;
        double R1;
        double T2menor;
        double T2mayor;
        double R1menor;
        double R1mayor;
        double T1menor;
        double T1mayor;
        double R2normalizada;
        double R2menor;
        double R2mayor;
        double Difmenor;
        double Difmayor;
        double Toleranciamenor;
        double Toleranciamayor;

        /*public CalcBasica()
        {

        }*/

        public string Suma(double x, double y, ref double r)
        {
            r = x + y;
            return ("Suma");

        }
        public string resta(double x, double y, ref double r)
        {
            r = x - y;
            return ("Resta");

        }
        public string Producto(double x, double y, ref double r)
        {
            r = x * y;
            return ("Producto");

        }
        public string Division(double x, double y, ref double r)
        {
            r = x / y;
            return ("Division");

        }
        public string Coseno(double x, ref double r)
        {
            r = Math.Cos(x);
            return ("Cos(x)");

        }
        public string Seno(double x, ref double r)
        {
            r = Math.Sin(x);
            return ("Sin(x)");

        }
        public string Potencia(double x, double y, ref double r)
        {
            r = Math.Pow(x, y);
            return ("Potencia");

        }
        public string Secante(double x, ref double r)
        {
            r = 1 / Math.Cos(x);
            return ("Secante(x)");

        }
        public string Factoriales(double x, ref double r)
        {
            r = (Math.Pow(x, x) / Math.Exp(x)) * Math.Sqrt(2 * Math.PI * x);
            return ("Factorial");

        }
        public string fu(double x, string fx, ref double r)
        {
            r = fux(x, fx);
            return ("Funcion de x");

        }
        public double fux(double x, string fx)
        {
            ExpressionParser vparser = new ExpressionParser();
            vparser.Values.Add("x", x);
            return (vparser.Parse(fx));
        }
        public string fu2(double x, double y, string fxy, ref double r)
        {
            r = fuxy(x, y, fxy);
            return ("Funcion de x,y");

        }
        public double fuxy(double x, double y, string fxy)
        {
            ExpressionParser vparser = new ExpressionParser();
            vparser.Values.Add("x", x);
            vparser.Values.Add("y", y);
            return (vparser.Parse(fxy));
        }
        public string Tangente(double x, ref double r)
        {
            r = Math.Tan(x);
            return ("Tang(x)");

        }
        public string Cosh(double x, ref double r)
        {
            r = Math.Cosh(x);
            return ("Cosh(x)");

        }
        public string Sinh(double x, ref double r)
        {
            r = Math.Sinh(x);
            return ("Sinh(x)");

        }
        public string Tanh(double x, ref double r)
        {
            r = Math.Tanh(x);
            return ("Tanh(x)");

        }
        public string Arcos(double x, ref double r)
        {
            r = Math.Acos(x);
            return ("Acos(x)");

        }
        public string Atan(double x, ref double r)
        {
            r = Math.Atan(x);
            return ("Atan(x)");

        }
        public string Asin(double x, ref double r)
        {
            r = Math.Asin(x);
            return ("Asin(x)");

        }
        public string Cosec(double x, ref double r)
        {
            r = 1 / Math.Sin(x);
            return ("Cosec(x)");

        }
        public string Cotan(double x, ref double r)
        {
            r = 1 / Math.Tan(x);
            return ("Cosec(x)");

        }
        public string Xpot2(double x, ref double r)
        {
            r = Math.Pow(x, 2);
            return ("X^2");

        }
        public string Xpot3(double x, ref double r)
        {
            r = Math.Pow(x, 3);

            return ("X^3");

        }
        public string raizcuadrada(double x, ref double r)
        {
            r = Math.Sqrt(x);
            return ("raiz cuadrada de x");


        }
        public string logaritmo(double x, ref double r)
        {
            r = Math.Log(x);
            return ("Log nat (x)");

        }
        public string logaritmo10(double x, ref double r)
        {
            r = Math.Log10(x);
            return ("Logaritmo base 10 de x");

        }
        public string Absoluto(double x, ref double r)
        {
            r = Math.Abs(x);
            return ("Valor absoluto de x");

        }
        public string Maximo(double x, double y, ref double r)
        {
            r = Math.Max(x, y);
            return ("Valor Maximo entre dos numeros");

        }
        public string Exponencial(double x, ref double r)
        {
            r = Math.Exp(x);
            return ("Exponencial de x");

        }
        public string Minimo(double x, double y, ref double r)
        {
            r = Math.Min(x, y);
            return ("Valor Minimo entre dos numeros");

        }
        public string fu3(double x, double y, double z, string fxy, ref double r)
        {
            r = fuxyz(x, y, z, fxy);
            return ("Funcion de x,y,z");

        }
        public double fuxyz(double x, double y, double z, string fxyz)
        {
            ExpressionParser vparser = new ExpressionParser();
            vparser.Values.Add("x", x);
            vparser.Values.Add("y", y);
            vparser.Values.Add("z", z);
            return (vparser.Parse(fxyz));
        }
        public string RadGrad(double x, ref double r)
        {
            r = x * 180 / Math.PI;
            return ("Conversion Radianes a Grados");

        }
        public string GradRad(double x, ref double r)
        {
            r = x * Math.PI / 180;
            return ("Conversion Grados a radianes");

        }
        public string FormGeneral(double x, double y, double z, ref double r, ref double r2, ref string s)
        {
            r = (-y + Math.Sqrt(Math.Pow(y, 2) - 4 * (x * z))) / (2 * x); ;
            r2 = (-y - Math.Sqrt(Math.Pow(y, 2) - 4 * (x * z))) / (2 * x);
            s = r.ToString();
            return ("Formula General de la forma ax^2+bx+c=0");

        }
        public string TeoPitagoras(double x, double y, ref double r)
        {
            r = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return ("Teorema de pitagoras");

        }
        public string AreaCuadrado(double x, ref double r)
        {
            r = Math.Pow(x, 2);
            return ("Area de un Cuadrado");

        }
        public string AreaRectangulo(double x, double y, ref double r)
        {
            r = x * y;
            return ("Area de un Rectangulo");

        }
        public string AreaTriangulo(double x, double y, ref double r)
        {
            r = x * y / 2;
            return ("Area de un Triangulo");

        }
        public string AreaTrapezoide(double x, double y, ref double r)
        {
            r = ((x + Math.Pow(x, 2)) * y) / 2;
            return ("Area de un trapezoide");

        }
        public string AreaCirculo(double x, double y, ref double r)
        {
            r = Math.PI * Math.Pow(x, 2);
            return ("Area de un Circulo");
        }
        public string SupAreaCubo(double x, double y, ref double r)
        {
            r = 6 * Math.Pow(x, 2);
            return ("Area de superficie de un cubo");
        }
        public string SupAreaCilindro(double x, double y, ref double r)
        {
            r = 2 * Math.PI * x * y;
            return ("Area de superficie de un cilindro");
        }
        public string SupAreaCono(double x, double y, ref double r)
        {
            r = Math.PI * Math.Pow(x, 2) + Math.PI * x * y;
            return ("Area de superficie de un Cono");
        }
        public string SupAreaesfera(double x, double y, ref double r)
        {
            r = 4 * Math.PI * Math.Pow(x, 2);
            return ("Area de superficie de una esfera");
        }
        public string VolumenCubo(double x, double y, ref double r)
        {
            r = Math.Pow(x, 3);
            return ("Volumen de un Cubo");
        }
        public string VolumenCilindro(double x, double y, ref double r)
        {
            r = Math.PI * Math.Pow(x, 2) * y;
            return ("Volumen de un Cilindro");
        }
        public string VolumenCono(double x, double y, ref double r)
        {
            r = (Math.PI * Math.Pow(x, 2) * y) / 3;
            return ("Volumen de un cono");
        }
        public string VolumenEsfera(double x, double y, ref double r)
        {
            r = (4 * Math.PI * Math.Pow(x, 3)) / 3;
            return ("Volumen de una esfera");
        }
        public string RSerie(double x, double y, double z, ref double r)
        {
            r = x + y + z;
            return ("Suma resistencias serie");
        }
        public string RParalelo(double x, double y, double z, ref double r)
        {
            r = 1 / (1 / x + 1 / y + 1 / z);
            return ("Suma resistencias Paralelo");
        }
        public string CSerie(double x, double y, double z, ref double r)
        {
            r = 1 / (1 / x + 1 / y + 1 / z);
            return ("Suma Capacitores Serie");
        }
        public string CParalelo(double x, double y, double z, ref double r)
        {
            r = x + y + z;
            return ("Suma resistencias serie");
        }
        public string MCM(double x, double y, double z, ref double r)
        {
            r = x * 100;
            return ("Convercion de x metros a centrimetros");
        }
        public string MMM(double x, double y, double z, ref double r)
        {
            r = x * 1000;
            return ("Convercion de x metros a milimetros");
        }
        public string CMMM(double x, double y, double z, ref double r)
        {
            r = x * 10;
            return ("Convercion de x centimetros a milimetros");
        }
        public string KMM(double x, double y, double z, ref double r)
        {
            r = x * 1000;
            return ("Convercion de x Kilometros a metros");
        }
        public string MF(double x, double y, double z, ref double r)
        {
            r = x * 3.28;
            return ("Convercion de x metros a pies");
        }
        public string MY(double x, double y, double z, ref double r)
        {
            r = x * 1.093;
            return ("Convercion de x metros a yardas");
        }
        public string FCM(double x, double y, double z, ref double r)
        {
            r = x * 30.48;
            return ("Convercion de x pies a centrimetros");
        }
        public string FP(double x, double y, double z, ref double r)
        {
            r = x * 12;
            return ("Convercion de x pies a pulgadas");
        }
        public string PCM(double x, double y, double z, ref double r)
        {
            r = x * 2.54;
            return ("Convercion de x pulgadas a centimetros");
        }
        public string MKM(double x, double y, double z, ref double r)
        {
            r = x * 1.609;
            return ("Convercion de x Millas a Kilometros");
        }
        public string LG(double x, double y, double z, ref double r)
        {
            r = x * 0.5;
            return ("Convercion de x Libras a Gramos");
        }
        public string KGL(double x, double y, double z, ref double r)
        {
            r = x * 2;
            return ("Convercion de x Kilogramos a libras");
        }
        public string CM3ML(double x, double y, double z, ref double r)
        {
            r = x * 1;
            return ("Convercion de x Centimetros cubicos a Mililitros");
        }
        public string LTCM3(double x, double y, double z, ref double r)
        {
            r = x * 1000;
            return ("Convercion de x Litros a Centimetros Cubicos");
        }
        public string LTDM3(double x, double y, double z, ref double r)
        {
            r = x * 1;
            return ("Convercion de x Litros a Decimetros cubicos");
        }
        public string GLT(double x, double y, double z, ref double r)
        {
            r = x * 3.875;
            return ("Convercion de x Galones a litros");
        }
        public string pFnF(double x, double y, double z, ref double r)
        {
            r = x * 0.001;
            return ("Convercion de x pF a nF");
        }
        public string pFmF(double x, double y, double z, ref double r)
        {
            r = x * 0.000001;
            return ("Convercion de x pF a mF");
        }
        public string nFpF(double x, double y, double z, ref double r)
        {
            r = x * 1000;
            return ("Convercion de x nF a pF");
        }
        public string nFmF(double x, double y, double z, ref double r)
        {
            r = x * 0.001;
            return ("Convercion de x nF a mF");
        }
        public string mFnF(double x, double y, double z, ref double r)
        {
            r = x * 1000;
            return ("Convercion de x mF a nF");
        }
        public string mFpF(double x, double y, double z, ref double r)
        {
            r = x * 1000000;
            return ("Convercion de x mF a pF");
        }
        public string ohmVoltaje(double x, double y, double z, ref double r)
        {
            r = x * y;
            return ("Volaje por ley de ohm");
        }
        public string ohmCorriente(double x, double y, double z, ref double r)
        {
            r = x / y;
            return ("Corriente por ley de ohm");
        }
        public string ohmResistencia(double x, double y, double z, ref double r)
        {
            r = x / y;
            return ("Resistencia por ley de ohm");
        }
        public string FPBFC(double x, double y, double z, ref double r)
        {
            r = 1 / (2 * Math.PI * x * y);
            return ("Frecuencia de corte de filtro pasa bajas");
        }
        public string GOPAMS(double x, double y, double z, ref double r)
        {
            r = x / y;
            return ("Frecuencia de corte de filtro pasa bajas");
        }
        public string Poten(double x, double y, double z, ref double r)
        {
            r = x * y;
            return ("Frecuencia de corte de filtro pasa bajas");
        }
        public string Diferencia(double x, double y, double z, ref double r)
        {
            r = x - y;
            return ("Diferencia entre dos numeros");
        }
        public string RD3(double x, double y, double z, ref double r)
        {
            r = (100 * y) / x;
            return ("Regla de 3 Porcentaje = ");
        }
        public string RD3num(double x, double y, double z, ref double r)
        {
            r = (x * y) / 100;
            return ("Regla de 3 cantidad = ");
        }
        public string Velocidad(double x, double y, double z, ref double r)
        {
            r = x / y;
            return ("Velocidad = ");
        }
        public string Distan(double x, double y, double z, ref double r)
        {
            r = x * y;
            return ("Distancia = ");
        }
        public string Periodo(double x, double y, double z, ref double r)
        {
            r = 1 / x;
            return ("Periodo de una señal = ");
        }
        public string PW(double x, double y, double z, ref double r)
        {
            r = x / 2;
            return ("PW de una señal = ");
        }
        public string Frecuencia(double x, double y, double z, ref double r)
        {
            r = 1 / x;
            return ("Frecuencia de una señal = ");
        }
        public string FrecAng(double x, double y, double z, ref double r)
        {
            r = 2 + Math.PI * x;
            return ("Frecuencia angular de una señal = ");
        }
        public string Tao(double x, double y, double z, ref double r)
        {
            r = x * y;
            return ("Tao en un circuito RC = ");
        }
        public string XYEZ(double x, double y, double z, ref double r)
        {
            r = Math.Pow((x / y), z);
            return ("(X/Y)^Z =  ");
        }
        
        

        

        

    }
}

