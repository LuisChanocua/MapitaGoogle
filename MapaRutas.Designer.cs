namespace MapitaGoogle
{
    partial class form_MapaRutas
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
            this.gmc_mr = new GMap.NET.WindowsForms.GMapControl();
            this.dtg_paradas_m = new System.Windows.Forms.DataGridView();
            this.btn_eliminarubi = new System.Windows.Forms.Button();
            this.btn_agregarubi = new System.Windows.Forms.Button();
            this.lbl_long = new System.Windows.Forms.Label();
            this.lbl_latitud = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_paradas_m)).BeginInit();
            this.SuspendLayout();
            // 
            // gmc_mr
            // 
            this.gmc_mr.Bearing = 0F;
            this.gmc_mr.CanDragMap = true;
            this.gmc_mr.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmc_mr.GrayScaleMode = false;
            this.gmc_mr.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmc_mr.LevelsKeepInMemmory = 5;
            this.gmc_mr.Location = new System.Drawing.Point(12, 12);
            this.gmc_mr.MarkersEnabled = true;
            this.gmc_mr.MaxZoom = 2;
            this.gmc_mr.MinZoom = 2;
            this.gmc_mr.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmc_mr.Name = "gmc_mr";
            this.gmc_mr.NegativeMode = false;
            this.gmc_mr.PolygonsEnabled = true;
            this.gmc_mr.RetryLoadTile = 0;
            this.gmc_mr.RoutesEnabled = true;
            this.gmc_mr.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmc_mr.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmc_mr.ShowTileGridLines = false;
            this.gmc_mr.Size = new System.Drawing.Size(570, 426);
            this.gmc_mr.TabIndex = 20;
            this.gmc_mr.Zoom = 0D;
            // 
            // dtg_paradas_m
            // 
            this.dtg_paradas_m.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_paradas_m.Location = new System.Drawing.Point(613, 224);
            this.dtg_paradas_m.Name = "dtg_paradas_m";
            this.dtg_paradas_m.ReadOnly = true;
            this.dtg_paradas_m.Size = new System.Drawing.Size(175, 200);
            this.dtg_paradas_m.TabIndex = 19;
            // 
            // btn_eliminarubi
            // 
            this.btn_eliminarubi.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_eliminarubi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_eliminarubi.Location = new System.Drawing.Point(694, 160);
            this.btn_eliminarubi.Name = "btn_eliminarubi";
            this.btn_eliminarubi.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminarubi.TabIndex = 18;
            this.btn_eliminarubi.Text = "Eliminar";
            this.btn_eliminarubi.UseVisualStyleBackColor = false;
            // 
            // btn_agregarubi
            // 
            this.btn_agregarubi.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_agregarubi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_agregarubi.Location = new System.Drawing.Point(613, 160);
            this.btn_agregarubi.Name = "btn_agregarubi";
            this.btn_agregarubi.Size = new System.Drawing.Size(75, 23);
            this.btn_agregarubi.TabIndex = 17;
            this.btn_agregarubi.Text = "Agregar";
            this.btn_agregarubi.UseVisualStyleBackColor = false;
            // 
            // lbl_long
            // 
            this.lbl_long.AutoSize = true;
            this.lbl_long.Location = new System.Drawing.Point(617, 118);
            this.lbl_long.Name = "lbl_long";
            this.lbl_long.Size = new System.Drawing.Size(48, 13);
            this.lbl_long.TabIndex = 16;
            this.lbl_long.Text = "Longitud";
            // 
            // lbl_latitud
            // 
            this.lbl_latitud.AutoSize = true;
            this.lbl_latitud.Location = new System.Drawing.Point(620, 72);
            this.lbl_latitud.Name = "lbl_latitud";
            this.lbl_latitud.Size = new System.Drawing.Size(39, 13);
            this.lbl_latitud.TabIndex = 15;
            this.lbl_latitud.Text = "Latitud";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(617, 25);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 14;
            this.lbl_nombre.Text = "Nombre";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(617, 134);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(617, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(617, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // form_MapaRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gmc_mr);
            this.Controls.Add(this.dtg_paradas_m);
            this.Controls.Add(this.btn_eliminarubi);
            this.Controls.Add(this.btn_agregarubi);
            this.Controls.Add(this.lbl_long);
            this.Controls.Add(this.lbl_latitud);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "form_MapaRutas";
            this.Text = "Mapa Rutas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_paradas_m)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl gmc_mr;
        private System.Windows.Forms.DataGridView dtg_paradas_m;
        private System.Windows.Forms.Button btn_eliminarubi;
        private System.Windows.Forms.Button btn_agregarubi;
        private System.Windows.Forms.Label lbl_long;
        private System.Windows.Forms.Label lbl_latitud;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

