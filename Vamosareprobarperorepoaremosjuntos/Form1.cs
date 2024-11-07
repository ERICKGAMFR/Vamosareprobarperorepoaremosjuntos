using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Vamosareprobarperorepoaremosjuntos
{ 
    public partial class Form1 : Form
    {
        string conectadobb = "Server=localhost; Port=3306; Database=Exapractico4; UID=root; Pwd=28112005;";
        public Form1()
        {
            InitializeComponent();
            txtnombre.TextChanged += validarnom;
            txtdia.Leave += validardate;
            txtmes.Leave += validardate;
            txtano.Leave += validardate;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void InsertarRegistrosusuario(string nombre, int dia, int mes, int ano)
        {
            string insertQuery = "INSERT INTO registro(Nom_usuario,  dia,  mes,  ano) VALUES (@nombre, @dia, @mes, @ano)";

            using (MySqlConnection connection = new MySqlConnection(conectadobb))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@dia", dia);
                        command.Parameters.AddWithValue("@mes", mes);
                        command.Parameters.AddWithValue("@ano", ano);
  

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void InsertarRegistrostem(float tem, string estado)
        {
            string insertQuery = "INSERT INTO tem(Tem_detetada,  Estado_servo) VALUES (@tem, @estado)";

            using (MySqlConnection connection = new MySqlConnection(conectadobb))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@tem", tem);
                        command.Parameters.AddWithValue("@estado", estado);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();

                    }
                }
            }
        }
                        /*private void label1_Click_2(object sender, EventArgs e)
                        {

                        }

                        private void label2_Click(object sender, EventArgs e)
                        {

                        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            float tempe = float.Parse(lblectem.Text);
            string estado = "encendido";

            InsertarRegistrostem(tempe, estado);
        }

        private bool Estextovalido(string valor)
        {
            return Regex.IsMatch(valor, @"^^[a-zA-Z\s]+$");
        }

        private bool EsEnteroValido2(string valor)
        {
            long resultado;
            return long.TryParse(valor, out resultado) && valor.Length == 2;
        }

        private void validardate(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Text.Length == 2 && EsEnteroValido2(textbox.Text))
            {
                textbox.BackColor = ColorTranslator.FromHtml("#00FF00");
            }
            else
            {
                textbox.BackColor = ColorTranslator.FromHtml("#FF0000");
                MessageBox.Show("INGRESE UNICAMENTE NUMEROS", "INGRESE UNA FECHA VALIDO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //textbox.Clear();  
            }
        }



        private void validarnom(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!Estextovalido(textBox.Text))
            {
                MessageBox.Show("INGRESE UNIACAMENTE VALORES DE LETRAS", "INGRESE UN NOMBRE VALIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            int dia = int.Parse(txtdia.Text);
            int mes = int.Parse(txtmes.Text);
            int ano = int.Parse(txtano.Text);

            InsertarRegistrosusuario(nombre,dia,mes,ano);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float tempe = float.Parse(lblectem.Text);
            string estado = "apagado";

            InsertarRegistrostem(tempe, estado);
        }
    }
}
