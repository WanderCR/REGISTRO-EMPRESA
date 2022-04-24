namespace REGISTRO_ESCOLAR
{
    partial class REGISTRO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REGISTRO));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.GUARDAR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.txtpuesto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DATOS = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DATOS)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 636);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1697, 31);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1697, 35);
            this.panel2.TabIndex = 1;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(190, 229);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(314, 26);
            this.txtnombre.TabIndex = 2;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(201, 271);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(303, 26);
            this.txtapellido.TabIndex = 2;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(201, 312);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(303, 26);
            this.txtcorreo.TabIndex = 2;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(207, 357);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(297, 26);
            this.txttelefono.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "CORREO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "TELEFONO";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtbuscar);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.bunifuFlatButton4);
            this.panel1.Controls.Add(this.DATOS);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1697, 667);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(984, 56);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(284, 32);
            this.txtbuscar.TabIndex = 11;
            this.txtbuscar.TextChanged += new System.EventHandler(this.buscar_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(931, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.bunifuFlatButton5);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.bunifuFlatButton3);
            this.panel3.Controls.Add(this.txtnombre);
            this.panel3.Controls.Add(this.bunifuFlatButton2);
            this.panel3.Controls.Add(this.txtapellido);
            this.panel3.Controls.Add(this.GUARDAR);
            this.panel3.Controls.Add(this.txtcorreo);
            this.panel3.Controls.Add(this.txttelefono);
            this.panel3.Controls.Add(this.bunifuFlatButton1);
            this.panel3.Controls.Add(this.txtsalario);
            this.panel3.Controls.Add(this.txtpuesto);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(3, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(654, 586);
            this.panel3.TabIndex = 10;
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.bunifuFlatButton5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 7;
            this.bunifuFlatButton5.ButtonText = "";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage")));
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 50D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(564, 510);
            this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(84, 64);
            this.bunifuFlatButton5.TabIndex = 9;
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::REGISTRO_ESCOLAR.Properties.Resources.R;
            this.pictureBox1.Location = new System.Drawing.Point(271, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.bunifuFlatButton3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 7;
            this.bunifuFlatButton3.ButtonText = "MODIFICAR";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 50D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(190, 510);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(189, 64);
            this.bunifuFlatButton3.TabIndex = 8;
            this.bunifuFlatButton3.Text = "MODIFICAR";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.bunifuFlatButton2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 7;
            this.bunifuFlatButton2.ButtonText = "ELIMINAR";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 50D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(387, 510);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(169, 64);
            this.bunifuFlatButton2.TabIndex = 7;
            this.bunifuFlatButton2.Text = "ELIMINAR";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // GUARDAR
            // 
            this.GUARDAR.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.GUARDAR.BackColor = System.Drawing.SystemColors.HotTrack;
            this.GUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GUARDAR.BorderRadius = 7;
            this.GUARDAR.ButtonText = "AGREGAR";
            this.GUARDAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GUARDAR.DisabledColor = System.Drawing.Color.Gray;
            this.GUARDAR.Iconcolor = System.Drawing.Color.Transparent;
            this.GUARDAR.Iconimage = ((System.Drawing.Image)(resources.GetObject("GUARDAR.Iconimage")));
            this.GUARDAR.Iconimage_right = null;
            this.GUARDAR.Iconimage_right_Selected = null;
            this.GUARDAR.Iconimage_Selected = null;
            this.GUARDAR.IconMarginLeft = 0;
            this.GUARDAR.IconMarginRight = 0;
            this.GUARDAR.IconRightVisible = true;
            this.GUARDAR.IconRightZoom = 0D;
            this.GUARDAR.IconVisible = true;
            this.GUARDAR.IconZoom = 50D;
            this.GUARDAR.IsTab = false;
            this.GUARDAR.Location = new System.Drawing.Point(7, 510);
            this.GUARDAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GUARDAR.Name = "GUARDAR";
            this.GUARDAR.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.GUARDAR.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.GUARDAR.OnHoverTextColor = System.Drawing.Color.White;
            this.GUARDAR.selected = false;
            this.GUARDAR.Size = new System.Drawing.Size(175, 64);
            this.GUARDAR.TabIndex = 7;
            this.GUARDAR.Text = "AGREGAR";
            this.GUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GUARDAR.Textcolor = System.Drawing.Color.White;
            this.GUARDAR.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GUARDAR.Click += new System.EventHandler(this.GUARDAR_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.bunifuFlatButton1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 7;
            this.bunifuFlatButton1.ButtonText = "EXAMINAR";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(264, 141);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(136, 40);
            this.bunifuFlatButton1.TabIndex = 5;
            this.bunifuFlatButton1.Text = "EXAMINAR";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(201, 403);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(303, 26);
            this.txtsalario.TabIndex = 2;
            // 
            // txtpuesto
            // 
            this.txtpuesto.Location = new System.Drawing.Point(201, 447);
            this.txtpuesto.Name = "txtpuesto";
            this.txtpuesto.Size = new System.Drawing.Size(303, 26);
            this.txtpuesto.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "PUESTO";
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "SALARIO";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "APELLIDO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.bunifuFlatButton4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 7;
            this.bunifuFlatButton4.ButtonText = "CALCULADORA";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 50D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(1022, 563);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(236, 64);
            this.bunifuFlatButton4.TabIndex = 9;
            this.bunifuFlatButton4.Text = "CALCULADORA";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // DATOS
            // 
            this.DATOS.AllowUserToAddRows = false;
            this.DATOS.AllowUserToDeleteRows = false;
            this.DATOS.BackgroundColor = System.Drawing.Color.White;
            this.DATOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATOS.Location = new System.Drawing.Point(663, 119);
            this.DATOS.Name = "DATOS";
            this.DATOS.ReadOnly = true;
            this.DATOS.RowHeadersWidth = 62;
            this.DATOS.RowTemplate.Height = 28;
            this.DATOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DATOS.Size = new System.Drawing.Size(1022, 409);
            this.DATOS.TabIndex = 6;
            this.DATOS.DoubleClick += new System.EventHandler(this.DATOS_DoubleClick);
            // 
            // REGISTRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1697, 667);
            this.Controls.Add(this.panel1);
            this.Name = "REGISTRO";
            this.Text = "REGISTRO";
            this.Load += new System.EventHandler(this.REGISTRO_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DATOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DATOS;
        private Bunifu.Framework.UI.BunifuFlatButton GUARDAR;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpuesto;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}