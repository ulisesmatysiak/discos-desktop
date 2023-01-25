namespace presentacion
{
    partial class frmDiscos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pboDiscos = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtbTitulo = new System.Windows.Forms.TextBox();
            this.txtbImagen = new System.Windows.Forms.TextBox();
            this.cboEstilo = new System.Windows.Forms.ComboBox();
            this.lblCanciones = new System.Windows.Forms.Label();
            this.numCanciones = new System.Windows.Forms.NumericUpDown();
            this.lblFormato = new System.Windows.Forms.Label();
            this.cboFormato = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCanciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(18, 391);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(241, 391);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pboDiscos
            // 
            this.pboDiscos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pboDiscos.Location = new System.Drawing.Point(346, 21);
            this.pboDiscos.Name = "pboDiscos";
            this.pboDiscos.Size = new System.Drawing.Size(442, 417);
            this.pboDiscos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboDiscos.TabIndex = 2;
            this.pboDiscos.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(15, 74);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(36, 13);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(15, 272);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(35, 13);
            this.lblEstilo.TabIndex = 4;
            this.lblEstilo.Text = "Estilo:";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(15, 220);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(61, 13);
            this.lblImagen.TabIndex = 5;
            this.lblImagen.Text = "Url Imagen:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(15, 121);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(114, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha de lanzamiento:";
            // 
            // txtbTitulo
            // 
            this.txtbTitulo.Location = new System.Drawing.Point(135, 71);
            this.txtbTitulo.Name = "txtbTitulo";
            this.txtbTitulo.Size = new System.Drawing.Size(205, 20);
            this.txtbTitulo.TabIndex = 0;
            // 
            // txtbImagen
            // 
            this.txtbImagen.Location = new System.Drawing.Point(135, 217);
            this.txtbImagen.Name = "txtbImagen";
            this.txtbImagen.Size = new System.Drawing.Size(205, 20);
            this.txtbImagen.TabIndex = 3;
            this.txtbImagen.Leave += new System.EventHandler(this.txtbImagen_Leave);
            // 
            // cboEstilo
            // 
            this.cboEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstilo.FormattingEnabled = true;
            this.cboEstilo.Location = new System.Drawing.Point(135, 269);
            this.cboEstilo.Name = "cboEstilo";
            this.cboEstilo.Size = new System.Drawing.Size(205, 21);
            this.cboEstilo.TabIndex = 4;
            // 
            // lblCanciones
            // 
            this.lblCanciones.AutoSize = true;
            this.lblCanciones.Location = new System.Drawing.Point(15, 175);
            this.lblCanciones.Name = "lblCanciones";
            this.lblCanciones.Size = new System.Drawing.Size(60, 13);
            this.lblCanciones.TabIndex = 11;
            this.lblCanciones.Text = "Canciones:";
            // 
            // numCanciones
            // 
            this.numCanciones.Location = new System.Drawing.Point(135, 170);
            this.numCanciones.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numCanciones.Name = "numCanciones";
            this.numCanciones.Size = new System.Drawing.Size(205, 20);
            this.numCanciones.TabIndex = 2;
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Location = new System.Drawing.Point(18, 328);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(48, 13);
            this.lblFormato.TabIndex = 13;
            this.lblFormato.Text = "Formato:";
            // 
            // cboFormato
            // 
            this.cboFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormato.FormattingEnabled = true;
            this.cboFormato.Location = new System.Drawing.Point(135, 325);
            this.cboFormato.Name = "cboFormato";
            this.cboFormato.Size = new System.Drawing.Size(205, 21);
            this.cboFormato.TabIndex = 5;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(136, 121);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // btnAgregarImg
            // 
            this.btnAgregarImg.Location = new System.Drawing.Point(93, 215);
            this.btnAgregarImg.Name = "btnAgregarImg";
            this.btnAgregarImg.Size = new System.Drawing.Size(36, 22);
            this.btnAgregarImg.TabIndex = 14;
            this.btnAgregarImg.Text = "+";
            this.btnAgregarImg.UseVisualStyleBackColor = true;
            this.btnAgregarImg.Click += new System.EventHandler(this.btnAgregarImg_Click);
            // 
            // frmDiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarImg);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cboFormato);
            this.Controls.Add(this.lblFormato);
            this.Controls.Add(this.numCanciones);
            this.Controls.Add(this.lblCanciones);
            this.Controls.Add(this.cboEstilo);
            this.Controls.Add(this.txtbImagen);
            this.Controls.Add(this.txtbTitulo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pboDiscos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.MaximizeBox = false;
            this.Name = "frmDiscos";
            this.Text = "Discos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmDiscos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCanciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pboDiscos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtbTitulo;
        private System.Windows.Forms.TextBox txtbImagen;
        private System.Windows.Forms.ComboBox cboEstilo;
        private System.Windows.Forms.Label lblCanciones;
        private System.Windows.Forms.NumericUpDown numCanciones;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.ComboBox cboFormato;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnAgregarImg;
    }
}