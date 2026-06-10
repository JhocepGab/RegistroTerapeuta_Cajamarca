namespace GUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // ── Panel Pacientes (ABB) ────────────────────────────────────────────
        private System.Windows.Forms.GroupBox gPacientes;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnRegistrarPaciente;
        private System.Windows.Forms.ListBox lbPacientes;

        // ── Panel Terapeutas (Lista Simple) ──────────────────────────────────
        private System.Windows.Forms.GroupBox gTerapeutas;
        private System.Windows.Forms.Label lblNombreTer;
        private System.Windows.Forms.TextBox txtNombreTer;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.Button btnAgregarTer;
        private System.Windows.Forms.Button btnEliminarTer;
        private System.Windows.Forms.ListBox lbTerapeutas;

        // ── Panel Citas ──────────────────────────────────────────────────────
        private System.Windows.Forms.GroupBox gCitas;
        private System.Windows.Forms.Label lblSelPaciente;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.Label lblSelTerapeuta;
        private System.Windows.Forms.ComboBox cmbTerapeuta;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.RadioButton rb30;
        private System.Windows.Forms.RadioButton rb60;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnVerDisp;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnDeshacer;
        private System.Windows.Forms.ListBox lbCitas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.gPacientes = new System.Windows.Forms.GroupBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnRegistrarPaciente = new System.Windows.Forms.Button();
            this.lbPacientes = new System.Windows.Forms.ListBox();
            this.gTerapeutas = new System.Windows.Forms.GroupBox();
            this.lblNombreTer = new System.Windows.Forms.Label();
            this.txtNombreTer = new System.Windows.Forms.TextBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.btnAgregarTer = new System.Windows.Forms.Button();
            this.btnEliminarTer = new System.Windows.Forms.Button();
            this.lbTerapeutas = new System.Windows.Forms.ListBox();
            this.gCitas = new System.Windows.Forms.GroupBox();
            this.lblSelPaciente = new System.Windows.Forms.Label();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.lblSelTerapeuta = new System.Windows.Forms.Label();
            this.cmbTerapeuta = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.rb30 = new System.Windows.Forms.RadioButton();
            this.rb60 = new System.Windows.Forms.RadioButton();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnVerDisp = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnDeshacer = new System.Windows.Forms.Button();
            this.lbCitas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gPacientes.SuspendLayout();
            this.gTerapeutas.SuspendLayout();
            this.gCitas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gPacientes
            // 
            this.gPacientes.Controls.Add(this.lblDNI);
            this.gPacientes.Controls.Add(this.txtDNI);
            this.gPacientes.Controls.Add(this.lblNombre);
            this.gPacientes.Controls.Add(this.txtNombre);
            this.gPacientes.Controls.Add(this.lblTelefono);
            this.gPacientes.Controls.Add(this.txtTelefono);
            this.gPacientes.Controls.Add(this.btnRegistrarPaciente);
            this.gPacientes.Controls.Add(this.lbPacientes);
            this.gPacientes.Location = new System.Drawing.Point(16, 15);
            this.gPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.gPacientes.Name = "gPacientes";
            this.gPacientes.Padding = new System.Windows.Forms.Padding(4);
            this.gPacientes.Size = new System.Drawing.Size(400, 468);
            this.gPacientes.TabIndex = 0;
            this.gPacientes.TabStop = false;
            this.gPacientes.Text = "Registro de Pacientes ";
            // 
            // lblDNI
            // 
            this.lblDNI.Location = new System.Drawing.Point(11, 30);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(87, 20);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(107, 27);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(159, 22);
            this.txtDNI.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(11, 66);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 64);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(265, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Location = new System.Drawing.Point(11, 103);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(87, 20);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(107, 101);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(265, 22);
            this.txtTelefono.TabIndex = 5;
            // 
            // btnRegistrarPaciente
            // 
            this.btnRegistrarPaciente.Location = new System.Drawing.Point(107, 138);
            this.btnRegistrarPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            this.btnRegistrarPaciente.Size = new System.Drawing.Size(173, 32);
            this.btnRegistrarPaciente.TabIndex = 6;
            this.btnRegistrarPaciente.Text = "Registrar Paciente";
            this.btnRegistrarPaciente.Click += new System.EventHandler(this.BtnRegistrarPaciente_Click);
            // 
            // lbPacientes
            // 
            this.lbPacientes.ItemHeight = 16;
            this.lbPacientes.Location = new System.Drawing.Point(11, 185);
            this.lbPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.lbPacientes.Name = "lbPacientes";
            this.lbPacientes.Size = new System.Drawing.Size(372, 260);
            this.lbPacientes.TabIndex = 7;
            // 
            // gTerapeutas
            // 
            this.gTerapeutas.Controls.Add(this.lblNombreTer);
            this.gTerapeutas.Controls.Add(this.txtNombreTer);
            this.gTerapeutas.Controls.Add(this.lblEspecialidad);
            this.gTerapeutas.Controls.Add(this.txtEspecialidad);
            this.gTerapeutas.Controls.Add(this.btnAgregarTer);
            this.gTerapeutas.Controls.Add(this.btnEliminarTer);
            this.gTerapeutas.Controls.Add(this.lbTerapeutas);
            this.gTerapeutas.Location = new System.Drawing.Point(429, 15);
            this.gTerapeutas.Margin = new System.Windows.Forms.Padding(4);
            this.gTerapeutas.Name = "gTerapeutas";
            this.gTerapeutas.Padding = new System.Windows.Forms.Padding(4);
            this.gTerapeutas.Size = new System.Drawing.Size(400, 468);
            this.gTerapeutas.TabIndex = 1;
            this.gTerapeutas.TabStop = false;
            this.gTerapeutas.Text = "Registro de Terapeutas ";
            // 
            // lblNombreTer
            // 
            this.lblNombreTer.Location = new System.Drawing.Point(11, 30);
            this.lblNombreTer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreTer.Name = "lblNombreTer";
            this.lblNombreTer.Size = new System.Drawing.Size(87, 20);
            this.lblNombreTer.TabIndex = 0;
            this.lblNombreTer.Text = "Nombre:";
            // 
            // txtNombreTer
            // 
            this.txtNombreTer.Location = new System.Drawing.Point(107, 27);
            this.txtNombreTer.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreTer.Name = "txtNombreTer";
            this.txtNombreTer.Size = new System.Drawing.Size(265, 22);
            this.txtNombreTer.TabIndex = 1;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.Location = new System.Drawing.Point(11, 66);
            this.lblEspecialidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(93, 20);
            this.lblEspecialidad.TabIndex = 2;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(107, 64);
            this.txtEspecialidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(265, 22);
            this.txtEspecialidad.TabIndex = 3;
            this.txtEspecialidad.TextChanged += new System.EventHandler(this.txtEspecialidad_TextChanged);
            // 
            // btnAgregarTer
            // 
            this.btnAgregarTer.Location = new System.Drawing.Point(107, 101);
            this.btnAgregarTer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarTer.Name = "btnAgregarTer";
            this.btnAgregarTer.Size = new System.Drawing.Size(120, 32);
            this.btnAgregarTer.TabIndex = 4;
            this.btnAgregarTer.Text = "Agregar";
            this.btnAgregarTer.Click += new System.EventHandler(this.BtnAgregarTer_Click);
            // 
            // btnEliminarTer
            // 
            this.btnEliminarTer.Location = new System.Drawing.Point(240, 101);
            this.btnEliminarTer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarTer.Name = "btnEliminarTer";
            this.btnEliminarTer.Size = new System.Drawing.Size(120, 32);
            this.btnEliminarTer.TabIndex = 5;
            this.btnEliminarTer.Text = "Eliminar";
            this.btnEliminarTer.Click += new System.EventHandler(this.BtnEliminarTer_Click);
            // 
            // lbTerapeutas
            // 
            this.lbTerapeutas.ItemHeight = 16;
            this.lbTerapeutas.Location = new System.Drawing.Point(11, 148);
            this.lbTerapeutas.Margin = new System.Windows.Forms.Padding(4);
            this.lbTerapeutas.Name = "lbTerapeutas";
            this.lbTerapeutas.Size = new System.Drawing.Size(372, 292);
            this.lbTerapeutas.TabIndex = 6;
            // 
            // gCitas
            // 
            this.gCitas.Controls.Add(this.label2);
            this.gCitas.Controls.Add(this.label1);
            this.gCitas.Controls.Add(this.lblSelPaciente);
            this.gCitas.Controls.Add(this.cmbPaciente);
            this.gCitas.Controls.Add(this.lblSelTerapeuta);
            this.gCitas.Controls.Add(this.cmbTerapeuta);
            this.gCitas.Controls.Add(this.lblFecha);
            this.gCitas.Controls.Add(this.dtpFecha);
            this.gCitas.Controls.Add(this.lblHora);
            this.gCitas.Controls.Add(this.txtHora);
            this.gCitas.Controls.Add(this.rb30);
            this.gCitas.Controls.Add(this.rb60);
            this.gCitas.Controls.Add(this.lblPrecio);
            this.gCitas.Controls.Add(this.btnVerDisp);
            this.gCitas.Controls.Add(this.btnReservar);
            this.gCitas.Controls.Add(this.btnDeshacer);
            this.gCitas.Controls.Add(this.lbCitas);
            this.gCitas.Location = new System.Drawing.Point(16, 495);
            this.gCitas.Margin = new System.Windows.Forms.Padding(4);
            this.gCitas.Name = "gCitas";
            this.gCitas.Padding = new System.Windows.Forms.Padding(4);
            this.gCitas.Size = new System.Drawing.Size(813, 345);
            this.gCitas.TabIndex = 2;
            this.gCitas.TabStop = false;
            this.gCitas.Text = "Agendar Cita de Masaje";
            // 
            // lblSelPaciente
            // 
            this.lblSelPaciente.Location = new System.Drawing.Point(11, 34);
            this.lblSelPaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelPaciente.Name = "lblSelPaciente";
            this.lblSelPaciente.Size = new System.Drawing.Size(87, 20);
            this.lblSelPaciente.TabIndex = 0;
            this.lblSelPaciente.Text = "Paciente:";
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(107, 31);
            this.cmbPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(292, 24);
            this.cmbPaciente.TabIndex = 1;
            // 
            // lblSelTerapeuta
            // 
            this.lblSelTerapeuta.Location = new System.Drawing.Point(11, 74);
            this.lblSelTerapeuta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelTerapeuta.Name = "lblSelTerapeuta";
            this.lblSelTerapeuta.Size = new System.Drawing.Size(87, 20);
            this.lblSelTerapeuta.TabIndex = 2;
            this.lblSelTerapeuta.Text = "Terapeuta:";
            // 
            // cmbTerapeuta
            // 
            this.cmbTerapeuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTerapeuta.FormattingEnabled = true;
            this.cmbTerapeuta.Location = new System.Drawing.Point(107, 70);
            this.cmbTerapeuta.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTerapeuta.Name = "cmbTerapeuta";
            this.cmbTerapeuta.Size = new System.Drawing.Size(292, 24);
            this.cmbTerapeuta.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(420, 34);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(60, 20);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(480, 31);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(139, 22);
            this.dtpFecha.TabIndex = 5;
            // 
            // lblHora
            // 
            this.lblHora.Location = new System.Drawing.Point(420, 74);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(60, 20);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "Hora:";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(480, 70);
            this.txtHora.Margin = new System.Windows.Forms.Padding(4);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(79, 22);
            this.txtHora.TabIndex = 7;
            this.txtHora.Text = "09:00";
            // 
            // rb30
            // 
            this.rb30.Location = new System.Drawing.Point(11, 113);
            this.rb30.Margin = new System.Windows.Forms.Padding(4);
            this.rb30.Name = "rb30";
            this.rb30.Size = new System.Drawing.Size(173, 21);
            this.rb30.TabIndex = 8;
            this.rb30.Text = "S/.60 (45 min)";
            this.rb30.CheckedChanged += new System.EventHandler(this.RbDuracion_CheckedChanged);
            // 
            // rb60
            // 
            this.rb60.Location = new System.Drawing.Point(200, 113);
            this.rb60.Margin = new System.Windows.Forms.Padding(4);
            this.rb60.Name = "rb60";
            this.rb60.Size = new System.Drawing.Size(173, 21);
            this.rb60.TabIndex = 9;
            this.rb60.Text = "S/.150 (90 min)";
            this.rb60.CheckedChanged += new System.EventHandler(this.RbDuracion_CheckedChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.Location = new System.Drawing.Point(400, 116);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(147, 20);
            this.lblPrecio.TabIndex = 10;
            this.lblPrecio.Text = "Precio: S/. 60";
            // 
            // btnVerDisp
            // 
            this.btnVerDisp.Location = new System.Drawing.Point(11, 148);
            this.btnVerDisp.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerDisp.Name = "btnVerDisp";
            this.btnVerDisp.Size = new System.Drawing.Size(173, 32);
            this.btnVerDisp.TabIndex = 11;
            this.btnVerDisp.Text = "Ver disponibilidad";
            this.btnVerDisp.Click += new System.EventHandler(this.BtnVerDisp_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(197, 148);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(120, 32);
            this.btnReservar.TabIndex = 12;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.Click += new System.EventHandler(this.BtnReservar_Click);
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.Location = new System.Drawing.Point(331, 148);
            this.btnDeshacer.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(120, 32);
            this.btnDeshacer.TabIndex = 13;
            this.btnDeshacer.Text = "Deshacer";
            this.btnDeshacer.Click += new System.EventHandler(this.BtnDeshacer_Click);
            // 
            // lbCitas
            // 
            this.lbCitas.ItemHeight = 16;
            this.lbCitas.Location = new System.Drawing.Point(11, 194);
            this.lbCitas.Margin = new System.Windows.Forms.Padding(4);
            this.lbCitas.Name = "lbCitas";
            this.lbCitas.Size = new System.Drawing.Size(785, 132);
            this.lbCitas.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(363, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(567, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "24 Hrs";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 862);
            this.Controls.Add(this.gPacientes);
            this.Controls.Add(this.gTerapeutas);
            this.Controls.Add(this.gCitas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Centro de Psicoterapia y Masajes";
            this.gPacientes.ResumeLayout(false);
            this.gPacientes.PerformLayout();
            this.gTerapeutas.ResumeLayout(false);
            this.gTerapeutas.PerformLayout();
            this.gCitas.ResumeLayout(false);
            this.gCitas.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
