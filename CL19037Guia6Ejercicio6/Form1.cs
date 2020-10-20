using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CL19037Guia6Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //mensajes de ayuda para el usuario
            ttAyuda.SetToolTip(txtNumeros, "Ingrese numeros enteros positivos mayores a 0");
            ttAyuda.SetToolTip(txtNumeroC, "Ingrese numeros positivos mayores a 0 que desee cambiar");
            ttAyuda.SetToolTip(nudCambiar, "Elija el numero que desea cambiar de los ya ingresados");
            ttAyuda.SetToolTip(lblNum1, "numero 1");
            ttAyuda.SetToolTip(lblNum2, "numero 2");
            ttAyuda.SetToolTip(lblNum3, "numero 3");
            ttAyuda.SetToolTip(lblNum4, "numero 4");
            ttAyuda.SetToolTip(lblNum5, "numero 5");
            ttAyuda.SetToolTip(lblNum6, "numero 6");
            ttAyuda.SetToolTip(lblNum7, "numero 7");
            ttAyuda.SetToolTip(lblNum8, "numero 8");
            ttAyuda.SetToolTip(lblNum9, "numero 9");
            ttAyuda.SetToolTip(lblNum10, "numero 10");
            ttAyuda.SetToolTip(lblContador, "Cuantos numeros ha ingresado");
            ttAyuda.SetToolTip(lblMult3, "Cantidad de numeros Multiplos de 3");
            ttAyuda.SetToolTip(lblMult5, "Cantidad de numeros Multiplos de 5");
        }
        //evento para agregar los datos
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int.TryParse(lblContador.Text, out contador);
            if (txtNumeros.Text != string.Empty)
            {
                if (lblContador.Text == "0")
                {
                    contador++;
                    lblNum1.Text = txtNumeros.Text;
                                        lblContador.Text = contador.ToString();
                }else if (lblContador.Text == "1")
                {
                    contador++;
                    lblContador.Text = contador.ToString();
                    lblNum2.Text = txtNumeros.Text;
                }else if (lblContador.Text == "2")
                {
                    contador++;
                    lblContador.Text = contador.ToString();
                    lblNum3.Text = txtNumeros.Text;
                }else if (lblContador.Text == "3")
                {
                    contador++;
                    lblContador.Text = contador.ToString();
                    lblNum4.Text = txtNumeros.Text;
                }else if (lblContador.Text == "4")
                {
                    contador++;
                    lblContador.Text = contador.ToString();
                    lblNum5.Text = txtNumeros.Text;
                }else if (lblContador.Text == "5")
                {
                    contador++;
                    lblContador.Text = contador.ToString();
                    lblNum6.Text = txtNumeros.Text;
                }else if (lblContador.Text == "6")
                {
                    contador++;
                    lblContador.Text = contador.ToString(); contador++;
                    lblNum7.Text = txtNumeros.Text;
                }else if (lblContador.Text == "7")
                {
                    contador++;
                    lblContador.Text = contador.ToString();
                    lblNum8.Text = txtNumeros.Text;
                }else if (lblContador.Text == "8")
                {
                    contador++;
                    lblContador.Text = contador.ToString();
                    lblNum9.Text = txtNumeros.Text;
                }else if (lblContador.Text == "9")
                {
                    contador++;
                    lblContador.Text = contador.ToString();
                    lblNum10.Text = txtNumeros.Text;
                }else if (lblContador.Text == "10")
                {
                    MessageBox.Show("Ya se han ingresado todos los numeros", "advertencia");
                }
                txtNumeros.Clear();
            }
            else if (txtNumeros.Text == string.Empty)
            {
                MessageBox.Show("No se han elegido valores, por favor llene todos los campos", "advertencia");
            }
            this.txtNumeros.Focus();
        }
        //evento para cambiar el valor de algun dato
        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (txtNumeroC.Text != string.Empty)
            {
                if (nudCambiar.Value == 1)
                {
                    lblNum1.Text = txtNumeroC.Text;
                    txtNumeroC.Clear();
                    nudCambiar.Value = 0;
                }
                else if (nudCambiar.Value == 2)
                {
                    lblNum2.Text = txtNumeroC.Text;
                    txtNumeroC.Clear();
                    nudCambiar.Value = 0;
                }
                else if (nudCambiar.Value == 3)
                {
                    lblNum3.Text = txtNumeroC.Text;
                    txtNumeroC.Clear();
                    nudCambiar.Value = 0;
                }
                else if (nudCambiar.Value == 4)
                {
                    lblNum4.Text = txtNumeroC.Text;
                    txtNumeroC.Clear();
                    nudCambiar.Value = 0;
                }
                else if (nudCambiar.Value == 5)
                {
                    lblNum5.Text = txtNumeroC.Text;
                    txtNumeroC.Clear();
                    nudCambiar.Value = 0;
                }
                else if (nudCambiar.Value == 6)
                {
                    lblNum6.Text = txtNumeroC.Text;
                    txtNumeroC.Clear();
                    nudCambiar.Value = 0;
                }
                else if (nudCambiar.Value == 7)
                {
                    lblNum7.Text = txtNumeroC.Text;
                    txtNumeroC.Clear();
                    nudCambiar.Value = 0;
                }
                else if (nudCambiar.Value == 8)
                {
                    lblNum8.Text = txtNumeroC.Text;
                    txtNumeroC.Clear();
                    nudCambiar.Value = 0;
                }
                else if (nudCambiar.Value == 9)
                {
                    lblNum9.Text = txtNumeroC.Text;
                    txtNumeroC.Clear();
                    nudCambiar.Value = 0;
                }
                else if (nudCambiar.Value == 10)
                {
                    lblNum10.Text = txtNumeroC.Text;
                    txtNumeroC.Clear();
                    nudCambiar.Value = 0;
                }
                else if (nudCambiar.Value == 0)
                {
                    MessageBox.Show("Eliga que numero desea cambiar", "Advertencia");
                }
            }
            else if (txtNumeroC.Text == string.Empty)
            {
                MessageBox.Show("No se ha elegido un valor para cambiar", "Advertencia");
            }
        }
        //evento para procesar los datos
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Procesar operaciones = new Procesar();
            int i, contador3 = 0, contador5 = 0;
            for (i = 1; i <= 10; i++)
            {
                if (i == 1)
                {
                    operaciones.Numero = int.Parse(lblNum1.Text);
                    if (operaciones.Divi3() == 0)
                    {
                        cbMult3.Items.Add(lblNum1.Text + " / 3 = " + operaciones.resultado3().ToString().ToString());
                        contador3++;
                        lblMult3.Text = contador3.ToString();
                    }
                    if (operaciones.Divi5() == 0)
                    {
                        cbMult5.Items.Add(lblNum1.Text + " / 5 = " + operaciones.resultado5().ToString());
                        contador5++;
                        lblMult5.Text = contador5.ToString();
                    }
                }
                else if (i == 2)
                {
                    operaciones.Numero = int.Parse(lblNum2.Text);
                    if (operaciones.Divi3() == 0)
                    {
                        cbMult3.Items.Add(lblNum2.Text + " / 3 = " + operaciones.resultado3().ToString().ToString());
                        contador3++;
                        lblMult3.Text = contador3.ToString();
                    }
                    if (operaciones.Divi5() == 0)
                    {
                        cbMult5.Items.Add(lblNum2.Text + " / 5 = " + operaciones.resultado5().ToString());
                        contador5++;
                        lblMult5.Text = contador5.ToString();
                    }
                }
                else if (i == 3)
                {
                    operaciones.Numero = int.Parse(lblNum3.Text);
                    if (operaciones.Divi3() == 0)
                    {
                        cbMult3.Items.Add(lblNum3.Text + " / 3 = " + operaciones.resultado3().ToString());
                        contador3++;
                        lblMult3.Text = contador3.ToString();
                    }
                    if (operaciones.Divi5() == 0)
                    {
                        cbMult5.Items.Add(lblNum3.Text + " / 5 = " + operaciones.resultado5().ToString());
                        contador5++;
                        lblMult5.Text = contador5.ToString();
                    }
                }
                else if (i == 4)
                {
                    operaciones.Numero = int.Parse(lblNum4.Text);
                    if (operaciones.Divi3() == 0)
                    {
                        cbMult3.Items.Add(lblNum4.Text + " / 3 = " + operaciones.resultado3().ToString());
                        contador3++;
                        lblMult3.Text = contador3.ToString();
                    }
                    if (operaciones.Divi5() == 0)
                    {
                        cbMult5.Items.Add(lblNum4.Text + " / 5 = " + operaciones.resultado5().ToString());
                        contador5++;
                        lblMult5.Text = contador5.ToString();
                    }
                }
                else if (i == 5)
                {
                    operaciones.Numero = int.Parse(lblNum5.Text);
                    if (operaciones.Divi3() == 0)
                    {
                        cbMult3.Items.Add(lblNum5.Text + " / 3 = " + operaciones.resultado3().ToString());
                        contador3++;
                        lblMult3.Text = contador3.ToString();
                    }
                    if (operaciones.Divi5() == 0)
                    {
                        cbMult5.Items.Add(lblNum5.Text + " / 5 = " + operaciones.resultado5().ToString());
                        contador5++;
                        lblMult5.Text = contador5.ToString();
                    }
                }
                else if (i == 6)
                {
                    operaciones.Numero = int.Parse(lblNum6.Text);
                    if (operaciones.Divi3() == 0)
                    {
                        cbMult3.Items.Add(lblNum6.Text + " / 3 = " + operaciones.resultado3().ToString());
                        contador3++;
                        lblMult3.Text = contador3.ToString();
                    }
                    if (operaciones.Divi5() == 0)
                    {
                        cbMult5.Items.Add(lblNum6.Text + " / 5 = " + operaciones.resultado5().ToString());
                        contador5++;
                        lblMult5.Text = contador5.ToString();
                    }
                }
                else if (i == 7)
                {
                    operaciones.Numero = int.Parse(lblNum7.Text);
                    if (operaciones.Divi3() == 0)
                    {
                        cbMult3.Items.Add(lblNum7.Text + " / 3 = " + operaciones.resultado3().ToString());
                        contador3++;
                        lblMult3.Text = contador3.ToString();
                    }
                    if (operaciones.Divi5() == 0)
                    {
                        cbMult5.Items.Add(lblNum7.Text + " / 5 = " + operaciones.resultado5().ToString());
                        contador5++;
                        lblMult5.Text = contador5.ToString();
                    }
                }
                else if (i == 8)
                {
                    operaciones.Numero = int.Parse(lblNum8.Text);
                    if (operaciones.Divi3() == 0)
                    {
                        cbMult3.Items.Add(lblNum8.Text + " / 3 = " + operaciones.resultado3().ToString());
                        contador3++;
                        lblMult3.Text = contador3.ToString();
                    }
                    if (operaciones.Divi5() == 0)
                    {
                        cbMult5.Items.Add(lblNum8.Text + " / 5 = " + operaciones.resultado5().ToString());
                        contador5++;
                        lblMult5.Text = contador5.ToString();
                    }
                }
                else if (i == 9)
                {
                    operaciones.Numero = int.Parse(lblNum9.Text);
                    if (operaciones.Divi3() == 0)
                    {
                        cbMult3.Items.Add(lblNum9.Text + " / 3 = " + operaciones.resultado3().ToString());
                        contador3++;
                        lblMult3.Text = contador3.ToString();
                    }
                    if (operaciones.Divi5() == 0)
                    {
                        cbMult5.Items.Add(lblNum9.Text + " / 5 = " + operaciones.resultado5().ToString());
                        contador5++;
                        lblMult5.Text = contador5.ToString();
                    }
                }
                else if (i == 10)
                {
                    operaciones.Numero = int.Parse(lblNum10.Text);
                    if (operaciones.Divi3() == 0)
                    {
                        cbMult3.Items.Add(lblNum10.Text + " / 3 = " + operaciones.resultado3().ToString());
                        contador3++;
                        lblMult3.Text = contador3.ToString();
                    }
                    if (operaciones.Divi5() == 0)
                    {
                        cbMult5.Items.Add(lblNum10.Text + " / 5 = " + operaciones.resultado5().ToString());
                        contador5++;
                        lblMult5.Text = contador5.ToString();
                    }
                }
            }
        }
        //evento para limpiar todos los datos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblContador.Text = "0";
            lblMult3.Text = "-";
            lblMult5.Text = "-";
            lblNum1.Text = "-";
            lblNum2.Text = "-";
            lblNum3.Text = "-";
            lblNum4.Text = "-";
            lblNum5.Text = "-";
            lblNum6.Text = "-";
            lblNum7.Text = "-";
            lblNum8.Text = "-";
            lblNum9.Text = "-";
            lblNum10.Text = "-";
            cbMult3.Items.Clear();
            cbMult5.Items.Clear();
        }
        //evento para limitar a solo numeros enteros
        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 58 && e.KeyChar <= 255 || e.KeyChar == 46)
            {
                epError.SetError(txtNumeros, ("ESTE CAMPO SOLO ADMITE NUMEROS ENTEROS"));
                e.Handled = true;
                return;
            }
            else
            {
                epError.Clear();
            }
        }
        //evento para limitar a solo numeros enteros
        private void txtNumeroC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 58 && e.KeyChar <= 255 || e.KeyChar == 46)
            {
                epError.SetError(txtNumeroC, ("ESTE CAMPO SOLO ADMITE NUMEROS ENTEROS"));
                e.Handled = true;
                return;
            }
            else
            {
                epError.Clear();
            }
        }
    }
}
