namespace ProyectoCorto
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.error = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cedula = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.conocido = new System.Windows.Forms.Label();
            this.marginal = new System.Windows.Forms.Label();
            this.madre = new System.Windows.Forms.Label();
            this.padre = new System.Windows.Forms.Label();
            this.provincia = new System.Windows.Forms.Label();
            this.canton = new System.Windows.Forms.Label();
            this.distrito = new System.Windows.Forms.Label();
            this.cedulaPadre = new System.Windows.Forms.Label();
            this.cedulaMadre = new System.Windows.Forms.Label();
            this.edad = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.nacionalidad = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(702, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.error);
            this.tabPage1.Controls.Add(this.webBrowser);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(694, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(269, 194);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(86, 13);
            this.error.TabIndex = 4;
            this.error.Text = "Cedula no valida";
            this.error.Visible = false;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(411, 67);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(250, 250);
            this.webBrowser.TabIndex = 3;
            this.webBrowser.Visible = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(242, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar informacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(242, 113);
            this.textBox.MaxLength = 9;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(138, 20);
            this.textBox.TabIndex = 1;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el numero de cedula";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.nacionalidad);
            this.tabPage2.Controls.Add(this.fecha);
            this.tabPage2.Controls.Add(this.edad);
            this.tabPage2.Controls.Add(this.cedulaMadre);
            this.tabPage2.Controls.Add(this.cedulaPadre);
            this.tabPage2.Controls.Add(this.distrito);
            this.tabPage2.Controls.Add(this.canton);
            this.tabPage2.Controls.Add(this.provincia);
            this.tabPage2.Controls.Add(this.padre);
            this.tabPage2.Controls.Add(this.madre);
            this.tabPage2.Controls.Add(this.marginal);
            this.tabPage2.Controls.Add(this.conocido);
            this.tabPage2.Controls.Add(this.nombre);
            this.tabPage2.Controls.Add(this.cedula);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(694, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "DETALLE DEL NACIMIENTO DE ESTA PERSONA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Numero de cedula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre completo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Conocido como:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Edad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nace:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Encargados legales";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Hijo/a del señor:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Hijo/a de la señora:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(397, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Identificacion:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(398, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Identificacion:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(394, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Nacionalidad:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(53, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Marginal:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 239);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Direccion";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 270);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Provincia:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 297);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Canton:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 323);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Distrito:";
            // 
            // cedula
            // 
            this.cedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cedula.Location = new System.Drawing.Point(113, 38);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(245, 13);
            this.cedula.TabIndex = 18;
            // 
            // nombre
            // 
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombre.Location = new System.Drawing.Point(113, 60);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(245, 13);
            this.nombre.TabIndex = 19;
            // 
            // conocido
            // 
            this.conocido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conocido.Location = new System.Drawing.Point(113, 83);
            this.conocido.Name = "conocido";
            this.conocido.Size = new System.Drawing.Size(245, 13);
            this.conocido.TabIndex = 20;
            // 
            // marginal
            // 
            this.marginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.marginal.Location = new System.Drawing.Point(113, 109);
            this.marginal.Name = "marginal";
            this.marginal.Size = new System.Drawing.Size(245, 13);
            this.marginal.TabIndex = 21;
            // 
            // madre
            // 
            this.madre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.madre.Location = new System.Drawing.Point(116, 204);
            this.madre.Name = "madre";
            this.madre.Size = new System.Drawing.Size(245, 13);
            this.madre.TabIndex = 25;
            // 
            // padre
            // 
            this.padre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.padre.Location = new System.Drawing.Point(116, 174);
            this.padre.Name = "padre";
            this.padre.Size = new System.Drawing.Size(245, 13);
            this.padre.TabIndex = 26;
            // 
            // provincia
            // 
            this.provincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.provincia.Location = new System.Drawing.Point(73, 270);
            this.provincia.Name = "provincia";
            this.provincia.Size = new System.Drawing.Size(245, 13);
            this.provincia.TabIndex = 27;
            // 
            // canton
            // 
            this.canton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canton.Location = new System.Drawing.Point(73, 296);
            this.canton.Name = "canton";
            this.canton.Size = new System.Drawing.Size(245, 13);
            this.canton.TabIndex = 28;
            // 
            // distrito
            // 
            this.distrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.distrito.Location = new System.Drawing.Point(73, 323);
            this.distrito.Name = "distrito";
            this.distrito.Size = new System.Drawing.Size(245, 13);
            this.distrito.TabIndex = 29;
            // 
            // cedulaPadre
            // 
            this.cedulaPadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cedulaPadre.Location = new System.Drawing.Point(472, 175);
            this.cedulaPadre.Name = "cedulaPadre";
            this.cedulaPadre.Size = new System.Drawing.Size(192, 13);
            this.cedulaPadre.TabIndex = 30;
            // 
            // cedulaMadre
            // 
            this.cedulaMadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cedulaMadre.Location = new System.Drawing.Point(472, 205);
            this.cedulaMadre.Name = "cedulaMadre";
            this.cedulaMadre.Size = new System.Drawing.Size(192, 13);
            this.cedulaMadre.TabIndex = 31;
            // 
            // edad
            // 
            this.edad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edad.Location = new System.Drawing.Point(471, 38);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(192, 13);
            this.edad.TabIndex = 32;
            // 
            // fecha
            // 
            this.fecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fecha.Location = new System.Drawing.Point(472, 60);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(192, 13);
            this.fecha.TabIndex = 33;
            // 
            // nacionalidad
            // 
            this.nacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nacionalidad.Location = new System.Drawing.Point(471, 83);
            this.nacionalidad.Name = "nacionalidad";
            this.nacionalidad.Size = new System.Drawing.Size(192, 13);
            this.nacionalidad.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Consulta Publica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label padre;
        private System.Windows.Forms.Label madre;
        private System.Windows.Forms.Label marginal;
        private System.Windows.Forms.Label conocido;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label cedula;
        private System.Windows.Forms.Label cedulaMadre;
        private System.Windows.Forms.Label cedulaPadre;
        private System.Windows.Forms.Label distrito;
        private System.Windows.Forms.Label canton;
        private System.Windows.Forms.Label provincia;
        private System.Windows.Forms.Label nacionalidad;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label edad;
    }
}

