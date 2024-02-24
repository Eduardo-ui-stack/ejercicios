namespace ejercicioDos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numeroBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.agregarButton = new System.Windows.Forms.Button();
            this.numerosLista = new System.Windows.Forms.ListBox();
            this.pruebaBox = new System.Windows.Forms.TextBox();
            this.timerUno = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numeroBox
            // 
            this.numeroBox.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.numeroBox.Location = new System.Drawing.Point(110, 79);
            this.numeroBox.MaxLength = 5;
            this.numeroBox.Name = "numeroBox";
            this.numeroBox.Size = new System.Drawing.Size(241, 43);
            this.numeroBox.TabIndex = 0;
            this.numeroBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeroBox.TextChanged += new System.EventHandler(this.numeroBox_TextChanged);
            this.numeroBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroBox_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese 10 números enteros";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // agregarButton
            // 
            this.agregarButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarButton.Location = new System.Drawing.Point(172, 124);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(109, 30);
            this.agregarButton.TabIndex = 2;
            this.agregarButton.Text = "&Agregar";
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // numerosLista
            // 
            this.numerosLista.FormattingEnabled = true;
            this.numerosLista.ItemHeight = 16;
            this.numerosLista.Location = new System.Drawing.Point(110, 199);
            this.numerosLista.Name = "numerosLista";
            this.numerosLista.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.numerosLista.Size = new System.Drawing.Size(241, 196);
            this.numerosLista.TabIndex = 3;
            this.numerosLista.TabStop = false;
            this.numerosLista.UseTabStops = false;
            this.numerosLista.SelectedIndexChanged += new System.EventHandler(this.numerosLista_SelectedIndexChanged);
            // 
            // pruebaBox
            // 
            this.pruebaBox.Cursor = System.Windows.Forms.Cursors.No;
            this.pruebaBox.Location = new System.Drawing.Point(172, 173);
            this.pruebaBox.MaxLength = 15;
            this.pruebaBox.Name = "pruebaBox";
            this.pruebaBox.ReadOnly = true;
            this.pruebaBox.Size = new System.Drawing.Size(109, 22);
            this.pruebaBox.TabIndex = 4;
            this.pruebaBox.TabStop = false;
            this.pruebaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerUno
            // 
            this.timerUno.Interval = 200;
            this.timerUno.Tick += new System.EventHandler(this.timerUno_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(110, 398);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(241, 31);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.numerosLista);
            this.panel2.Controls.Add(this.pruebaBox);
            this.panel2.Controls.Add(this.numeroBox);
            this.panel2.Controls.Add(this.agregarButton);
            this.panel2.Location = new System.Drawing.Point(79, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 569);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 72);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(144, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ultimo número agregado";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(78, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 102);
            this.label3.TabIndex = 8;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(614, 628);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(632, 675);
            this.MinimumSize = new System.Drawing.Size(502, 594);
            this.Name = "Form1";
            this.Text = "ejercicioDos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox numeroBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.ListBox numerosLista;
        private System.Windows.Forms.TextBox pruebaBox;
        private System.Windows.Forms.Timer timerUno;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}

