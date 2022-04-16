namespace PRESENTACION
{
    partial class FrmVehiculo
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
            this.DgVehiculo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.PbBuscar = new System.Windows.Forms.PictureBox();
            this.BtnMirar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RbtnModelo = new System.Windows.Forms.RadioButton();
            this.RbtnMarca = new System.Windows.Forms.RadioButton();
            this.RbtnColor = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // DgVehiculo
            // 
            this.DgVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgVehiculo.Location = new System.Drawing.Point(16, 108);
            this.DgVehiculo.Name = "DgVehiculo";
            this.DgVehiculo.Size = new System.Drawing.Size(440, 330);
            this.DgVehiculo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehiculos Disponibles";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(16, 82);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(358, 22);
            this.TxtBuscar.TabIndex = 2;
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // PbBuscar
            // 
            this.PbBuscar.BackColor = System.Drawing.Color.LightGray;
            this.PbBuscar.Image = global::PRESENTACION.Properties.Resources.Busqueda;
            this.PbBuscar.Location = new System.Drawing.Point(370, 82);
            this.PbBuscar.Name = "PbBuscar";
            this.PbBuscar.Size = new System.Drawing.Size(86, 20);
            this.PbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbBuscar.TabIndex = 3;
            this.PbBuscar.TabStop = false;
            // 
            // BtnMirar
            // 
            this.BtnMirar.Location = new System.Drawing.Point(481, 12);
            this.BtnMirar.Name = "BtnMirar";
            this.BtnMirar.Size = new System.Drawing.Size(107, 23);
            this.BtnMirar.TabIndex = 4;
            this.BtnMirar.Text = "Mostrar";
            this.BtnMirar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Busqueda por:";
            // 
            // RbtnModelo
            // 
            this.RbtnModelo.AutoSize = true;
            this.RbtnModelo.Location = new System.Drawing.Point(466, 128);
            this.RbtnModelo.Name = "RbtnModelo";
            this.RbtnModelo.Size = new System.Drawing.Size(60, 17);
            this.RbtnModelo.TabIndex = 6;
            this.RbtnModelo.TabStop = true;
            this.RbtnModelo.Text = "Modelo";
            this.RbtnModelo.UseVisualStyleBackColor = true;
            // 
            // RbtnMarca
            // 
            this.RbtnMarca.AutoSize = true;
            this.RbtnMarca.Location = new System.Drawing.Point(466, 178);
            this.RbtnMarca.Name = "RbtnMarca";
            this.RbtnMarca.Size = new System.Drawing.Size(55, 17);
            this.RbtnMarca.TabIndex = 7;
            this.RbtnMarca.TabStop = true;
            this.RbtnMarca.Text = "Marca";
            this.RbtnMarca.UseVisualStyleBackColor = true;
            // 
            // RbtnColor
            // 
            this.RbtnColor.AutoSize = true;
            this.RbtnColor.Location = new System.Drawing.Point(466, 235);
            this.RbtnColor.Name = "RbtnColor";
            this.RbtnColor.Size = new System.Drawing.Size(49, 17);
            this.RbtnColor.TabIndex = 8;
            this.RbtnColor.TabStop = true;
            this.RbtnColor.Text = "Color";
            this.RbtnColor.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(466, 297);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(55, 17);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Precio";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // FrmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.RbtnColor);
            this.Controls.Add(this.RbtnMarca);
            this.Controls.Add(this.RbtnModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnMirar);
            this.Controls.Add(this.PbBuscar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgVehiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVehiculo";
            this.Text = "FrmVehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.DgVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgVehiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.PictureBox PbBuscar;
        private System.Windows.Forms.Button BtnMirar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RbtnModelo;
        private System.Windows.Forms.RadioButton RbtnMarca;
        private System.Windows.Forms.RadioButton RbtnColor;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}