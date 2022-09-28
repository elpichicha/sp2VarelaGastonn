namespace sp2VarelaGaston
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LBLtipo = new System.Windows.Forms.Label();
            this.LBLpersona = new System.Windows.Forms.Label();
            this.LBLdias = new System.Windows.Forms.Label();
            this.LBLadiccionale = new System.Windows.Forms.Label();
            this.LBLforma = new System.Windows.Forms.Label();
            this.LBLnombre = new System.Windows.Forms.Label();
            this.LBLapellido = new System.Windows.Forms.Label();
            this.btnconf = new System.Windows.Forms.Button();
            this.MRCinicio = new System.Windows.Forms.GroupBox();
            this.CMBdias = new System.Windows.Forms.ComboBox();
            this.CMBtipo = new System.Windows.Forms.ComboBox();
            this.CMBpersonas = new System.Windows.Forms.ComboBox();
            this.MRCadicionales = new System.Windows.Forms.GroupBox();
            this.CHKbuffet = new System.Windows.Forms.CheckBox();
            this.CHKwifi = new System.Windows.Forms.CheckBox();
            this.CHKdesa = new System.Windows.Forms.CheckBox();
            this.MRCforma = new System.Windows.Forms.GroupBox();
            this.CMBtrajeta = new System.Windows.Forms.ComboBox();
            this.OPTtarj = new System.Windows.Forms.RadioButton();
            this.OPTefe = new System.Windows.Forms.RadioButton();
            this.MRCdatos = new System.Windows.Forms.GroupBox();
            this.TXTape = new System.Windows.Forms.TextBox();
            this.TXTnom = new System.Windows.Forms.TextBox();
            this.lblcabaña = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MRCinicio.SuspendLayout();
            this.MRCadicionales.SuspendLayout();
            this.MRCforma.SuspendLayout();
            this.MRCdatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLtipo
            // 
            this.LBLtipo.AutoSize = true;
            this.LBLtipo.Location = new System.Drawing.Point(6, 16);
            this.LBLtipo.Name = "LBLtipo";
            this.LBLtipo.Size = new System.Drawing.Size(28, 13);
            this.LBLtipo.TabIndex = 0;
            this.LBLtipo.Text = "Tipo";
            // 
            // LBLpersona
            // 
            this.LBLpersona.AutoSize = true;
            this.LBLpersona.Location = new System.Drawing.Point(163, 16);
            this.LBLpersona.Name = "LBLpersona";
            this.LBLpersona.Size = new System.Drawing.Size(50, 13);
            this.LBLpersona.TabIndex = 1;
            this.LBLpersona.Text = "personas";
            this.LBLpersona.Click += new System.EventHandler(this.label2_Click);
            // 
            // LBLdias
            // 
            this.LBLdias.AutoSize = true;
            this.LBLdias.Location = new System.Drawing.Point(316, 16);
            this.LBLdias.Name = "LBLdias";
            this.LBLdias.Size = new System.Drawing.Size(26, 13);
            this.LBLdias.TabIndex = 2;
            this.LBLdias.Text = "dias";
            // 
            // LBLadiccionale
            // 
            this.LBLadiccionale.AutoSize = true;
            this.LBLadiccionale.Location = new System.Drawing.Point(69, 162);
            this.LBLadiccionale.Name = "LBLadiccionale";
            this.LBLadiccionale.Size = new System.Drawing.Size(64, 13);
            this.LBLadiccionale.TabIndex = 3;
            this.LBLadiccionale.Text = "Adicionales ";
            // 
            // LBLforma
            // 
            this.LBLforma.AutoSize = true;
            this.LBLforma.Location = new System.Drawing.Point(218, 162);
            this.LBLforma.Name = "LBLforma";
            this.LBLforma.Size = new System.Drawing.Size(78, 13);
            this.LBLforma.TabIndex = 4;
            this.LBLforma.Text = "Forma de pago";
            // 
            // LBLnombre
            // 
            this.LBLnombre.AutoSize = true;
            this.LBLnombre.Location = new System.Drawing.Point(14, 16);
            this.LBLnombre.Name = "LBLnombre";
            this.LBLnombre.Size = new System.Drawing.Size(47, 13);
            this.LBLnombre.TabIndex = 6;
            this.LBLnombre.Text = "Nombre ";
            this.LBLnombre.Click += new System.EventHandler(this.label7_Click);
            // 
            // LBLapellido
            // 
            this.LBLapellido.AutoSize = true;
            this.LBLapellido.Location = new System.Drawing.Point(86, 307);
            this.LBLapellido.Name = "LBLapellido";
            this.LBLapellido.Size = new System.Drawing.Size(44, 13);
            this.LBLapellido.TabIndex = 7;
            this.LBLapellido.Text = "Apellido";
            // 
            // btnconf
            // 
            this.btnconf.Location = new System.Drawing.Point(645, 390);
            this.btnconf.Name = "btnconf";
            this.btnconf.Size = new System.Drawing.Size(97, 29);
            this.btnconf.TabIndex = 8;
            this.btnconf.Text = "confirmar";
            this.btnconf.UseVisualStyleBackColor = true;
            this.btnconf.Click += new System.EventHandler(this.button1_Click);
            // 
            // MRCinicio
            // 
            this.MRCinicio.Controls.Add(this.CMBdias);
            this.MRCinicio.Controls.Add(this.CMBtipo);
            this.MRCinicio.Controls.Add(this.CMBpersonas);
            this.MRCinicio.Controls.Add(this.LBLpersona);
            this.MRCinicio.Controls.Add(this.LBLtipo);
            this.MRCinicio.Controls.Add(this.LBLdias);
            this.MRCinicio.Location = new System.Drawing.Point(72, 64);
            this.MRCinicio.Name = "MRCinicio";
            this.MRCinicio.Size = new System.Drawing.Size(449, 92);
            this.MRCinicio.TabIndex = 9;
            this.MRCinicio.TabStop = false;
            // 
            // CMBdias
            // 
            this.CMBdias.Enabled = false;
            this.CMBdias.FormattingEnabled = true;
            this.CMBdias.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CMBdias.Location = new System.Drawing.Point(348, 13);
            this.CMBdias.Name = "CMBdias";
            this.CMBdias.Size = new System.Drawing.Size(70, 21);
            this.CMBdias.TabIndex = 5;
            this.CMBdias.SelectedIndexChanged += new System.EventHandler(this.CMBdias_SelectedIndexChanged);
            // 
            // CMBtipo
            // 
            this.CMBtipo.FormattingEnabled = true;
            this.CMBtipo.Items.AddRange(new object[] {
            "A",
            "B"});
            this.CMBtipo.Location = new System.Drawing.Point(40, 13);
            this.CMBtipo.Name = "CMBtipo";
            this.CMBtipo.Size = new System.Drawing.Size(79, 21);
            this.CMBtipo.TabIndex = 4;
            this.CMBtipo.SelectedIndexChanged += new System.EventHandler(this.CMBtipo_SelectedIndexChanged);
            // 
            // CMBpersonas
            // 
            this.CMBpersonas.Enabled = false;
            this.CMBpersonas.FormattingEnabled = true;
            this.CMBpersonas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CMBpersonas.Location = new System.Drawing.Point(219, 13);
            this.CMBpersonas.Name = "CMBpersonas";
            this.CMBpersonas.Size = new System.Drawing.Size(70, 21);
            this.CMBpersonas.TabIndex = 3;
            this.CMBpersonas.SelectedIndexChanged += new System.EventHandler(this.CMBpersonas_SelectedIndexChanged);
            // 
            // MRCadicionales
            // 
            this.MRCadicionales.Controls.Add(this.CHKbuffet);
            this.MRCadicionales.Controls.Add(this.CHKwifi);
            this.MRCadicionales.Controls.Add(this.CHKdesa);
            this.MRCadicionales.Enabled = false;
            this.MRCadicionales.Location = new System.Drawing.Point(72, 162);
            this.MRCadicionales.Name = "MRCadicionales";
            this.MRCadicionales.Size = new System.Drawing.Size(140, 88);
            this.MRCadicionales.TabIndex = 10;
            this.MRCadicionales.TabStop = false;
            this.MRCadicionales.Enter += new System.EventHandler(this.MRCadicionales_Enter);
            // 
            // CHKbuffet
            // 
            this.CHKbuffet.AutoSize = true;
            this.CHKbuffet.Location = new System.Drawing.Point(9, 65);
            this.CHKbuffet.Name = "CHKbuffet";
            this.CHKbuffet.Size = new System.Drawing.Size(98, 17);
            this.CHKbuffet.TabIndex = 2;
            this.CHKbuffet.Text = "buffet nocturno";
            this.CHKbuffet.UseVisualStyleBackColor = true;
            // 
            // CHKwifi
            // 
            this.CHKwifi.AutoSize = true;
            this.CHKwifi.Location = new System.Drawing.Point(9, 42);
            this.CHKwifi.Name = "CHKwifi";
            this.CHKwifi.Size = new System.Drawing.Size(44, 17);
            this.CHKwifi.TabIndex = 1;
            this.CHKwifi.Text = "Wifi";
            this.CHKwifi.UseVisualStyleBackColor = true;
            // 
            // CHKdesa
            // 
            this.CHKdesa.AutoSize = true;
            this.CHKdesa.Location = new System.Drawing.Point(9, 19);
            this.CHKdesa.Name = "CHKdesa";
            this.CHKdesa.Size = new System.Drawing.Size(72, 17);
            this.CHKdesa.TabIndex = 0;
            this.CHKdesa.Text = "desayuno";
            this.CHKdesa.UseVisualStyleBackColor = true;
            // 
            // MRCforma
            // 
            this.MRCforma.Controls.Add(this.CMBtrajeta);
            this.MRCforma.Controls.Add(this.OPTtarj);
            this.MRCforma.Controls.Add(this.OPTefe);
            this.MRCforma.Enabled = false;
            this.MRCforma.Location = new System.Drawing.Point(218, 162);
            this.MRCforma.Name = "MRCforma";
            this.MRCforma.Size = new System.Drawing.Size(303, 88);
            this.MRCforma.TabIndex = 11;
            this.MRCforma.TabStop = false;
            this.MRCforma.Enter += new System.EventHandler(this.MRCforma_Enter);
            // 
            // CMBtrajeta
            // 
            this.CMBtrajeta.FormattingEnabled = true;
            this.CMBtrajeta.Items.AddRange(new object[] {
            "visa",
            "mastercard",
            "naranja ",
            "prepaga Uala"});
            this.CMBtrajeta.Location = new System.Drawing.Point(173, 53);
            this.CMBtrajeta.Name = "CMBtrajeta";
            this.CMBtrajeta.Size = new System.Drawing.Size(70, 21);
            this.CMBtrajeta.TabIndex = 4;
            // 
            // OPTtarj
            // 
            this.OPTtarj.AutoSize = true;
            this.OPTtarj.Location = new System.Drawing.Point(173, 30);
            this.OPTtarj.Name = "OPTtarj";
            this.OPTtarj.Size = new System.Drawing.Size(54, 17);
            this.OPTtarj.TabIndex = 1;
            this.OPTtarj.TabStop = true;
            this.OPTtarj.Text = "tarjeta";
            this.OPTtarj.UseVisualStyleBackColor = true;
            // 
            // OPTefe
            // 
            this.OPTefe.AutoSize = true;
            this.OPTefe.Location = new System.Drawing.Point(20, 30);
            this.OPTefe.Name = "OPTefe";
            this.OPTefe.Size = new System.Drawing.Size(63, 17);
            this.OPTefe.TabIndex = 0;
            this.OPTefe.TabStop = true;
            this.OPTefe.Text = "efectivo";
            this.OPTefe.UseVisualStyleBackColor = true;
            this.OPTefe.CheckedChanged += new System.EventHandler(this.OPTefe_CheckedChanged);
            // 
            // MRCdatos
            // 
            this.MRCdatos.Controls.Add(this.TXTape);
            this.MRCdatos.Controls.Add(this.TXTnom);
            this.MRCdatos.Controls.Add(this.LBLnombre);
            this.MRCdatos.Location = new System.Drawing.Point(72, 253);
            this.MRCdatos.Name = "MRCdatos";
            this.MRCdatos.Size = new System.Drawing.Size(213, 91);
            this.MRCdatos.TabIndex = 12;
            this.MRCdatos.TabStop = false;
            // 
            // TXTape
            // 
            this.TXTape.Location = new System.Drawing.Point(87, 51);
            this.TXTape.Name = "TXTape";
            this.TXTape.Size = new System.Drawing.Size(85, 20);
            this.TXTape.TabIndex = 7;
            // 
            // TXTnom
            // 
            this.TXTnom.Location = new System.Drawing.Point(87, 13);
            this.TXTnom.Name = "TXTnom";
            this.TXTnom.Size = new System.Drawing.Size(85, 20);
            this.TXTnom.TabIndex = 5;
            // 
            // lblcabaña
            // 
            this.lblcabaña.AutoSize = true;
            this.lblcabaña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcabaña.Location = new System.Drawing.Point(68, 23);
            this.lblcabaña.Name = "lblcabaña";
            this.lblcabaña.Size = new System.Drawing.Size(182, 20);
            this.lblcabaña.TabIndex = 13;
            this.lblcabaña.Text = "CABAÑA SANTA ROSA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sp2VarelaGaston.Properties.Resources.descarga;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblcabaña);
            this.Controls.Add(this.btnconf);
            this.Controls.Add(this.LBLapellido);
            this.Controls.Add(this.LBLforma);
            this.Controls.Add(this.LBLadiccionale);
            this.Controls.Add(this.MRCinicio);
            this.Controls.Add(this.MRCadicionales);
            this.Controls.Add(this.MRCforma);
            this.Controls.Add(this.MRCdatos);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.MRCinicio.ResumeLayout(false);
            this.MRCinicio.PerformLayout();
            this.MRCadicionales.ResumeLayout(false);
            this.MRCadicionales.PerformLayout();
            this.MRCforma.ResumeLayout(false);
            this.MRCforma.PerformLayout();
            this.MRCdatos.ResumeLayout(false);
            this.MRCdatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLtipo;
        private System.Windows.Forms.Label LBLpersona;
        private System.Windows.Forms.Label LBLdias;
        private System.Windows.Forms.Label LBLadiccionale;
        private System.Windows.Forms.Label LBLforma;
        private System.Windows.Forms.Label LBLnombre;
        private System.Windows.Forms.Label LBLapellido;
        private System.Windows.Forms.Button btnconf;
        private System.Windows.Forms.GroupBox MRCinicio;
        private System.Windows.Forms.GroupBox MRCadicionales;
        private System.Windows.Forms.GroupBox MRCforma;
        private System.Windows.Forms.GroupBox MRCdatos;
        private System.Windows.Forms.ComboBox CMBdias;
        private System.Windows.Forms.ComboBox CMBtipo;
        private System.Windows.Forms.ComboBox CMBpersonas;
        private System.Windows.Forms.CheckBox CHKbuffet;
        private System.Windows.Forms.CheckBox CHKwifi;
        private System.Windows.Forms.CheckBox CHKdesa;
        private System.Windows.Forms.ComboBox CMBtrajeta;
        private System.Windows.Forms.RadioButton OPTtarj;
        private System.Windows.Forms.RadioButton OPTefe;
        private System.Windows.Forms.TextBox TXTape;
        private System.Windows.Forms.TextBox TXTnom;
        private System.Windows.Forms.Label lblcabaña;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

