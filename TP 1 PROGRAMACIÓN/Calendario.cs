using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_1_PROGRAMACIÓN
{
    public partial class Calendario : Form
    {
        public Calendario()
        {
            InitializeComponent();
        }
        
       
        private void button1_Click(object sender, EventArgs e)
        {
            int mes = 0;
            int dia= System.Convert.ToInt32(txtDia.Text);
            int año = System.Convert.ToInt32(txtAño.Text);
            int Dia = 0;
            Dia = dia + 1;
            
            mes = int.Parse(txtMes.Text);
            string MESEscrito = System.Convert.ToString(mes);
            string AÑO = System.Convert.ToString(año);
           // int mes = 0;
            switch (mes)
            {
                case 1:
                    if (mes == 1)
                    {
                       // string MES = System.Convert.ToString(mes);
                        MESEscrito = "Enero";
                        if (Dia > 0 && Dia < 31)
                        {
                            lblResultado.Text=Dia +" de "+ MESEscrito + " de" + AÑO;
                        }
                        else if (Dia >= 31 && Dia <= 32)
                        {
                            Dia = 1;
                            MESEscrito = "Febrero";
                            lblResultado.Text = Dia + " de " + MESEscrito + " de" + AÑO;
                        }
                        else if (Dia >= 32)
                        {
                            lblResultado.Text= "Error";
                        }
                        else
                        {
                            lblResultado.Text = "Numero de día que no corresponde al mes";
                        }

                        
                    }
                    break;
                case 2:
                    if (mes == 2)
                    {
                        // string MES = System.Convert.ToString(mes);
                        MESEscrito = "Febrero";
                        if (Dia > 0 && Dia < 28)
                        {
                            lblResultado.Text = Dia + " de " + MESEscrito + " de" + AÑO;
                        }
                        else if (Dia >= 31 && Dia <= 28)
                        {
                            Dia = 1;
                            MESEscrito = "Febrero";
                            lblResultado.Text = Dia + " de " + MESEscrito + " de" + AÑO;
                        }
                        else if (Dia >= 31)
                        {
                            lblResultado.Text = "Error";
                        }
                        else
                        {
                            lblResultado.Text = "Numero de día que no corresponde al mes";
                        }


                    }
                    break;
                case 3:
                    if (mes == 3)
                    {
                        // string MES = System.Convert.ToString(mes);
                        MESEscrito = "Marzo";
                        if (Dia > 0 && Dia < 31)
                        {
                            lblResultado.Text = Dia + " de " + MESEscrito + " de" + AÑO;
                        }
                        else if (Dia >= 31 && Dia <= 32)
                        {
                            Dia = 1;
                            MESEscrito = "Marzo";
                            lblResultado.Text = Dia + " de " + MESEscrito + " de" + AÑO;
                        }
                        else if (Dia >= 32)
                        {
                            lblResultado.Text = "Error";
                        }
                        else
                        {
                            lblResultado.Text = "Numero de día que no corresponde al mes";
                        }


                    }
                    break;
                case 4:
                    if (mes == 4)
                    {
                        // string MES = System.Convert.ToString(mes);
                        MESEscrito = "Abril";
                        if (Dia > 0 && Dia < 30)
                        {
                            lblResultado.Text = Dia + " de " + MESEscrito + " de" + AÑO;
                        }
                        else if (Dia >= 31 && Dia <= 32)
                        {
                            Dia = 1;
                            MESEscrito = "Abril";
                            lblResultado.Text = Dia + " de " + MESEscrito + " de" + AÑO;
                        }
                        else if (Dia >= 32)
                        {
                            lblResultado.Text = "Error";
                        }
                        else
                        {
                            lblResultado.Text = "Numero de día que no corresponde al mes";
                        }


                    }
                    break;
                case 5:
                    if (mes == 5)
                    {
                        // string MES = System.Convert.ToString(mes);
                        MESEscrito = "Mayo";
                        if (Dia > 0 && Dia < 31)
                        {
                            lblResultado.Text = Dia + " de " + MESEscrito + " de" + AÑO;
                        }
                        else if (Dia >= 31 && Dia <= 32)
                        {
                            Dia = 1;
                            MESEscrito = "Mayo";
                            lblResultado.Text = Dia + " de " + MESEscrito + " de" + AÑO;
                        }
                        else if (Dia >= 32)
                        {
                            lblResultado.Text = "Error";
                        }
                        else
                        {
                            lblResultado.Text = "Numero de día que no corresponde al mes";
                        }


                    }
                    break;
                case 6:
                    if (mes == 6)
                    {
                        // string MES = System.Convert.ToString(mes);
                        MESEscrito = "Junio";
                        if (Dia > 0 && Dia < 30)
                        {
                            lblResultado.Text = Dia + " de " + MESEscrito + " de" + AÑO;
                        }
                        else if (Dia >= 31 && Dia <= 32)
                        {
                            Dia = 1;
                            MESEscrito = "Junio";
                            lblResultado.Text = Dia + " de " + MESEscrito + " de" + AÑO;
                        }
                        else if (Dia >= 32)
                        {
                            lblResultado.Text = "Error";
                        }
                        else
                        {
                            lblResultado.Text = "Numero de día que no corresponde al mes";
                        }


                    }
                    break;
                case 7:
                    if (mes == 7)
                    {
                        // string MES = System.Convert.ToString(mes);
                        MESEscrito = "Julio";
                        if (Dia > 0 && Dia < 31)
                        {
                            lblResultado.Text = Dia + " de " + MESEscrito + " de" + AÑO;
                        }
                        else if (Dia >= 31 && Dia <= 32)
                        {
                            Dia = 1;
                            MESEscrito = "Julio";
                            lblResultado.Text = Dia + " de " + MESEscrito + " de" + AÑO;
                        }
                        else if (Dia >= 32)
                        {
                            lblResultado.Text = "Error";
                        }
                        else
                        {
                            lblResultado.Text = "Numero de día que no corresponde al mes";
                        }


                    }
                    break;
                case 8:
                    if (mes == 8)
                    {
                        // string MES = System.Convert.ToString(mes);
                        MESEscrito = "Agosto";
                        if (Dia > 0 && Dia < 31)
                        {
                            lblResultado.Text = Dia + " de " + MESEscrito + " de" + AÑO;
                        }
                        else if (Dia >= 31 && Dia <= 32)
                        {
                            Dia = 1;
                            MESEscrito = "Agosto";
                            lblResultado.Text = Dia + " de " + MESEscrito + " de" + AÑO;
                        }
                        else if (Dia >= 32)
                        {
                            lblResultado.Text = "Error";
                        }
                        else
                        {
                            lblResultado.Text = "Numero de día que no corresponde al mes";
                        }


                    }
                    break;
                case 9:
                    if (mes == 9)
                    {
                        // string MES = System.Convert.ToString(mes);
                        MESEscrito = "Septiembre";
                        if (Dia > 0 && Dia < 30)
                        {
                            lblResultado.Text = Dia + " de " + MESEscrito + " de" + AÑO;
                        }
                        else if (Dia >= 30 && Dia <= 32)
                        {
                            Dia = 1;
                            MESEscrito = "Septiembre";
                            lblResultado.Text = Dia + " de " + MESEscrito + " de" + AÑO;
                        }
                        else if (Dia >= 31)
                        {
                            lblResultado.Text = "Error";
                        }
                        else
                        {
                            lblResultado.Text = "Numero de día que no corresponde al mes";
                        }


                    }
                    break;
                case 10:
                    if (mes == 10)
                    {
                        // string MES = System.Convert.ToString(mes);
                        MESEscrito = "Octubre";
                        if (Dia > 0 && Dia < 31)
                        {
                            lblResultado.Text = Dia + " de " + MESEscrito + " de" + AÑO;
                        }
                        else if (Dia >= 31 && Dia <= 32)
                        {
                            Dia = 1;
                            MESEscrito = "Octubre";
                            lblResultado.Text = Dia + " de " + MESEscrito + " de" + AÑO;
                        }
                        else if (Dia >= 32)
                        {
                            lblResultado.Text = "Error";
                        }
                        else
                        {
                            lblResultado.Text = "Numero de día que no corresponde al mes";
                        }


                    }
                    break;
                case 11:
                    if (mes == 11)
                    {
                        // string MES = System.Convert.ToString(mes);
                        MESEscrito = "Noviembre";
                        if (Dia > 0 && Dia < 30)
                        {
                            lblResultado.Text = Dia + " de " + MESEscrito + " de" + AÑO;
                        }
                        else if (Dia >= 30 && Dia <= 31)
                        {
                            Dia = 1;
                            MESEscrito = "Noviembre";
                            lblResultado.Text = Dia + " de " + MESEscrito + " de" + AÑO;
                        }
                        else if (Dia >= 31)
                        {
                            lblResultado.Text = "Error";
                        }
                        else
                        {
                            lblResultado.Text = "Numero de día que no corresponde al mes";
                        }


                    }
                    break;
                case 12:
                    if (mes == 12)
                    {
                        // string MES = System.Convert.ToString(mes);
                        MESEscrito = "Diciembre";
                        if (Dia > 0 && Dia < 31)
                        {
                            lblResultado.Text = Dia + " de " + MESEscrito + " de" + AÑO;
                        }
                        else if (Dia >= 31 && Dia <= 32)
                        {
                            Dia = 1;
                            MESEscrito = "Diciembre";
                            lblResultado.Text = Dia + " de " + MESEscrito + " de" + AÑO;
                        }
                        else if (Dia >= 32)
                        {
                            lblResultado.Text = "Error";
                        }
                        else
                        {
                            lblResultado.Text = "Numero de día que no corresponde al mes";
                        }


                    }
                    break;


                default: lblResultado.Text=   "Error";
                    break;


                


               
            }


        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void Calendario_Load(object sender, EventArgs e)
        {

        }
    }
}







