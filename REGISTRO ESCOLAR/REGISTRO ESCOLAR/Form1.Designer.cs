namespace REGISTRO_ESCOLAR
{
    partial class INICIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INICIO));
            this.USUARIO = new System.Windows.Forms.TextBox();
            this.CONTRASEÑA = new System.Windows.Forms.TextBox();
            this.ENTER = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // USUARIO
            // 
            this.USUARIO.Location = new System.Drawing.Point(157, 204);
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.Size = new System.Drawing.Size(216, 26);
            this.USUARIO.TabIndex = 0;
            // 
            // CONTRASEÑA
            // 
            this.CONTRASEÑA.Location = new System.Drawing.Point(189, 250);
            this.CONTRASEÑA.Name = "CONTRASEÑA";
            this.CONTRASEÑA.PasswordChar = '*';
            this.CONTRASEÑA.Size = new System.Drawing.Size(184, 26);
            this.CONTRASEÑA.TabIndex = 0;
            // 
            // ENTER
            // 
            this.ENTER.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.ENTER.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ENTER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ENTER.BorderRadius = 7;
            this.ENTER.ButtonText = "ENTRAR";
            this.ENTER.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ENTER.DisabledColor = System.Drawing.Color.Gray;
            this.ENTER.Iconcolor = System.Drawing.Color.Transparent;
            this.ENTER.Iconimage = ((System.Drawing.Image)(resources.GetObject("ENTER.Iconimage")));
            this.ENTER.Iconimage_right = null;
            this.ENTER.Iconimage_right_Selected = null;
            this.ENTER.Iconimage_Selected = null;
            this.ENTER.IconMarginLeft = 0;
            this.ENTER.IconMarginRight = 0;
            this.ENTER.IconRightVisible = true;
            this.ENTER.IconRightZoom = 0D;
            this.ENTER.IconVisible = true;
            this.ENTER.IconZoom = 90D;
            this.ENTER.IsTab = false;
            this.ENTER.Location = new System.Drawing.Point(68, 294);
            this.ENTER.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ENTER.Name = "ENTER";
            this.ENTER.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.ENTER.OnHovercolor = System.Drawing.SystemColors.MenuHighlight;
            this.ENTER.OnHoverTextColor = System.Drawing.Color.White;
            this.ENTER.selected = false;
            this.ENTER.Size = new System.Drawing.Size(305, 74);
            this.ENTER.TabIndex = 1;
            this.ENTER.Text = "ENTRAR";
            this.ENTER.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ENTER.Textcolor = System.Drawing.Color.White;
            this.ENTER.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENTER.Click += new System.EventHandler(this.ENTER_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::REGISTRO_ESCOLAR.Properties.Resources.icons8_nombre_de_usuario_48;
            this.pictureBox1.Location = new System.Drawing.Point(189, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "USUARIO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "CONTRESEÑA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ENTER);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.USUARIO);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CONTRASEÑA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 484);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 33);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 448);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(471, 36);
            this.panel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "INICIO DE SECION";
            // 
            // INICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 478);
            this.Controls.Add(this.panel1);
            this.Name = "INICIO";
            this.Text = "INICIO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox USUARIO;
        private System.Windows.Forms.TextBox CONTRASEÑA;
        private Bunifu.Framework.UI.BunifuFlatButton ENTER;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}

