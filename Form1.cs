using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;


namespace TAP_U2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button button = new Button();
        private void CrearControl_Click(object sender, EventArgs e)
        {
            //Crear conytoles, en tiempo de ejecución
            //Instanciar una clase de tipo Button
            string speech = string.Format("El nombre del control es:");

            button.Name = "btn1";
            button.Text = "soy nuevo";
            //coordenadas del boton
            button.Top = this.Height / 2;
            button.Left = this.Width/2;
            //tamaño del boton nuevo
            button.Height = 50;
            button.Width = 90;
            //diseñodel boton
            button.FlatStyle = FlatStyle.Flat;
            //Este control hay que ponerlo en el form 1
            this.Controls.Add(button);
            //Asociar el button a un evento
            button.Click += new EventHandler(btn1_click);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //
            this.Controls.Remove(button);
        }

        private void btn1_click (object sender, EventArgs e)
        {
            this.BackColor = Color.Azure;
            MessageBox.Show("Evento creado para este botón");
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            //capturar pantalla de nuestro SO
            //instanciar           
            Bitmap screen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            using (Graphics g= Graphics.FromImage(screen))
            {
                g.CopyFromScreen(0, 0, 0, 0, screen.Size);

                   
            }
            pictureBox1.Image = screen;
        }
    }
}
