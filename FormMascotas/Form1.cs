using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LibMascotas;

namespace FormMascotas
{
    public partial class Form1 : Form
    {
        Stack<Mascota> pilamascota;
        public Form1()
        {
            InitializeComponent();
            pilamascota = new Stack<Mascota>();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtbNombre.Text==""||txtbEspecie.Text==""||txtbDueño.Text=="")
                {
                    throw new ApplicationException();
                }
                else
                {
                    Mascota mimascota = new Mascota(txtbNombre.Text, txtbEspecie.Text, txtbDueño.Text);
                    pilamascota.Push(mimascota);
                    dgvMascota.Rows.Add(mimascota.Nombre, mimascota.Dueño, mimascota.Especie);
                }
            }
            catch(ApplicationException)
            {
                errorProv.SetError(btnPush, "No ha llenado todos los campos");
            }
        }


        private void btnPop_Click(object sender, EventArgs e)
        {
            if (pilamascota.Count > 0)
            {
                dgvMascota.Rows.RemoveAt(pilamascota.Count - 1);
                MessageBox.Show("Mascota eliminada" + pilamascota.Pop().Nombre, "Borrar");
            }
 
        }

        private void txtbNombre_TextChanged(object sender, EventArgs e)
        {
            errorProv.Clear();
        }
    }
}
