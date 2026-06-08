using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        // Estructuras de datos
        Arbol arbol = new Arbol();
        ListaTerapeutas listaTerapeutas = new ListaTerapeutas();
        ListaCitas listaCitas = new ListaCitas();
        PilaAcciones pila = new PilaAcciones();
        ColaEspera cola = new ColaEspera();

        public Form1()
        {
            InitializeComponent();
            rb30.Checked = true;
            ActualizarPrecio();

            // Cargar las 5 terapeutas predeterminadas en controles
            listaTerapeutas.LlenarListBox(lbTerapeutas);
            listaTerapeutas.LlenarComboBox(cmbTerapeuta);
        }

        // ── Precio dinámico ─────────────────────────────────────────────────
        private void ActualizarPrecio()
        {
            lblPrecio.Text = "Precio: S/. " + (rb30.Checked ? "60" : "150");
        }

        private void RbDuracion_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarPrecio();
        }

        // ── PANEL PACIENTES (ABB) ────────────────────────────────────────────
        private void BtnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            int dni;
            if (!int.TryParse(txtDNI.Text, out dni))
            {
                MessageBox.Show("DNI invalido. Ingrese solo numeros.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            Persona p = new Persona();
            p.dni = dni;
            p.nombre = txtNombre.Text;
            p.telefono = txtTelefono.Text;

            arbol.Insertar(p);
            arbol.Listar(ref lbPacientes);

            // Actualizar combo de pacientes en panel de citas
            ActualizarComboPacientes();

            txtDNI.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
        }

        private void ActualizarComboPacientes()
        {
            string seleccionado = cmbPaciente.SelectedItem != null ? cmbPaciente.SelectedItem.ToString() : "";
            cmbPaciente.Items.Clear();
            foreach (object item in lbPacientes.Items)
            {
                cmbPaciente.Items.Add(item);
            }
            if (seleccionado != "" && cmbPaciente.Items.Contains(seleccionado))
            {
                cmbPaciente.SelectedItem = seleccionado;
            }
        }

        // ── PANEL TERAPEUTAS (Lista Simple) ─────────────────────────────────
        private void BtnAgregarTer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreTer.Text) ||
                string.IsNullOrWhiteSpace(txtEspecialidad.Text))
            {
                MessageBox.Show("Ingrese nombre y especialidad de la terapeuta.");
                return;
            }
            if (listaTerapeutas.Existe(txtNombreTer.Text))
            {
                MessageBox.Show("Ya existe una terapeuta con ese nombre.");
                return;
            }

            listaTerapeutas.Agregar(txtNombreTer.Text, txtEspecialidad.Text);
            listaTerapeutas.LlenarListBox(lbTerapeutas);
            listaTerapeutas.LlenarComboBox(cmbTerapeuta);

            MessageBox.Show("Terapeuta agregada con exito!");
            txtNombreTer.Clear();
            txtEspecialidad.Clear();
        }

        private void BtnEliminarTer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreTer.Text))
            {
                MessageBox.Show("Ingrese el nombre de la terapeuta a eliminar.");
                return;
            }

            bool eliminado = listaTerapeutas.Eliminar(txtNombreTer.Text);

            if (eliminado)
            {
                listaTerapeutas.LlenarListBox(lbTerapeutas);
                listaTerapeutas.LlenarComboBox(cmbTerapeuta);
                MessageBox.Show("Terapeuta eliminada.");
            }
            else
            {
                MessageBox.Show("Terapeuta no encontrada.");
            }

            txtNombreTer.Clear();
            txtEspecialidad.Clear();
        }

        // ── PANEL CITAS ──────────────────────────────────────────────────────
        private Persona ObtenerPacienteSeleccionado()
        {
            if (cmbPaciente.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un paciente.");
                return null;
            }

            // El item del combo es un objeto Persona (de lbPacientes)
            Persona p = cmbPaciente.SelectedItem as Persona;
            if (p == null)
            {
                MessageBox.Show("Seleccione un paciente valido.");
                return null;
            }
            return p;
        }

        private DateTime ObtenerFechaHora()
        {
            DateTime fecha = dtpFecha.Value.Date;
            TimeSpan h;
            if (!TimeSpan.TryParse(txtHora.Text, out h))
            {
                throw new Exception("Hora invalida. Use formato HH:mm (ejemplo: 09:30)");
            }
            return fecha.Add(h);
        }

        private void BtnVerDisp_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTerapeuta.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione una terapeuta.");
                    return;
                }
                DateTime fh = ObtenerFechaHora();
                bool ocupado = listaCitas.ExisteConflicto(cmbTerapeuta.Text, fh);
                MessageBox.Show(ocupado ? "Horario OCUPADO" : "Horario LIBRE");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnReservar_Click(object sender, EventArgs e)
        {
            Persona paciente = ObtenerPacienteSeleccionado();
            if (paciente == null) return;

            if (cmbTerapeuta.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una terapeuta.");
                return;
            }

            try
            {
                DateTime fh = ObtenerFechaHora();
                int dur = rb30.Checked ? 30 : 60;
                decimal precio = rb30.Checked ? 35 : 60;

                if (listaCitas.ExisteConflicto(cmbTerapeuta.Text, fh))
                {
                    Cita ccola = new Cita();
                    ccola.dniPaciente = paciente.dni;
                    ccola.nombrePaciente = paciente.nombre;
                    ccola.terapeuta = cmbTerapeuta.Text;
                    ccola.fechaHoraInicio = fh;
                    ccola.duracionMin = dur;
                    ccola.precio = precio;

                    cola.Encolar(ccola);
                    MessageBox.Show("Horario ocupado. Cita agregada a la cola de espera.");
                    return;
                }

                Cita c = new Cita();
                c.dniPaciente = paciente.dni;
                c.nombrePaciente = paciente.nombre;
                c.terapeuta = cmbTerapeuta.Text;
                c.fechaHoraInicio = fh;
                c.duracionMin = dur;
                c.precio = precio;

                listaCitas.InsertarOrdenado(c);
                listaCitas.LlenarListBox(lbCitas);
                pila.Push("RESERVA", c);
                MessageBox.Show("Cita reservada con exito!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDeshacer_Click(object sender, EventArgs e)
        {
            if (pila.EstaVacia())
            {
                MessageBox.Show("No hay acciones para deshacer.");
                return;
            }

            string acc;
            Cita c;
            if (pila.Pop(out acc, out c) && acc == "RESERVA")
            {
                listaCitas.Eliminar(c);
                listaCitas.LlenarListBox(lbCitas);
                MessageBox.Show("Ultima reserva deshecha.");
            }
        }

        private void txtEspecialidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
