namespace cuarto_ejer
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
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addjuntar = new System.Windows.Forms.PictureBox();
            this.lista_de_musica = new System.Windows.Forms.ListBox();
            this.reproductor_musica = new AxWMPLib.AxWindowsMediaPlayer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resultadoText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.promTresText = new System.Windows.Forms.TextBox();
            this.promDosText = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.promUnoText = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buscadordeArchivos = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addjuntar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reproductor_musica)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(6, 6);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(605, 378);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Reproducir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(343, 500);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "pausar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(497, 500);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 52);
            this.button4.TabIndex = 4;
            this.button4.Text = "continuar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(928, 597);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.addjuntar);
            this.tabPage2.Controls.Add(this.lista_de_musica);
            this.tabPage2.Controls.Add(this.reproductor_musica);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(920, 568);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "musicas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // addjuntar
            // 
            this.addjuntar.Image = global::cuarto_ejer.Properties.Resources.R;
            this.addjuntar.Location = new System.Drawing.Point(43, 486);
            this.addjuntar.Name = "addjuntar";
            this.addjuntar.Size = new System.Drawing.Size(51, 55);
            this.addjuntar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addjuntar.TabIndex = 2;
            this.addjuntar.TabStop = false;
            this.addjuntar.Click += new System.EventHandler(this.addjuntar_Click);
            // 
            // lista_de_musica
            // 
            this.lista_de_musica.FormattingEnabled = true;
            this.lista_de_musica.ItemHeight = 16;
            this.lista_de_musica.Location = new System.Drawing.Point(615, 77);
            this.lista_de_musica.Name = "lista_de_musica";
            this.lista_de_musica.Size = new System.Drawing.Size(288, 484);
            this.lista_de_musica.TabIndex = 1;
            this.lista_de_musica.SelectedIndexChanged += new System.EventHandler(this.lista_de_musica_SelectedIndexChanged);
            // 
            // reproductor_musica
            // 
            this.reproductor_musica.Enabled = true;
            this.reproductor_musica.Location = new System.Drawing.Point(3, 24);
            this.reproductor_musica.Name = "reproductor_musica";
            this.reproductor_musica.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("reproductor_musica.OcxState")));
            this.reproductor_musica.Size = new System.Drawing.Size(911, 47);
            this.reproductor_musica.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(920, 568);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "promedios";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.resultadoText);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.promTresText);
            this.panel2.Controls.Add(this.promDosText);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.promUnoText);
            this.panel2.Location = new System.Drawing.Point(10, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 536);
            this.panel2.TabIndex = 1;
            // 
            // resultadoText
            // 
            this.resultadoText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultadoText.Cursor = System.Windows.Forms.Cursors.Default;
            this.resultadoText.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoText.Location = new System.Drawing.Point(276, 466);
            this.resultadoText.MaxLength = 4;
            this.resultadoText.Name = "resultadoText";
            this.resultadoText.ReadOnly = true;
            this.resultadoText.Size = new System.Drawing.Size(477, 59);
            this.resultadoText.TabIndex = 5;
            this.resultadoText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resultadoText.TextChanged += new System.EventHandler(this.resultadoText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Light", 20F);
            this.label1.Location = new System.Drawing.Point(0, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "El promedio es: ";
            // 
            // promTresText
            // 
            this.promTresText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.promTresText.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.promTresText.Location = new System.Drawing.Point(476, 88);
            this.promTresText.MaxLength = 3;
            this.promTresText.Name = "promTresText";
            this.promTresText.Size = new System.Drawing.Size(360, 34);
            this.promTresText.TabIndex = 3;
            this.promTresText.TextChanged += new System.EventHandler(this.promTresText_TextChanged);
            this.promTresText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.promTresText_KeyPress);
            // 
            // promDosText
            // 
            this.promDosText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.promDosText.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.promDosText.Location = new System.Drawing.Point(476, 186);
            this.promDosText.MaxLength = 3;
            this.promDosText.Name = "promDosText";
            this.promDosText.Size = new System.Drawing.Size(360, 34);
            this.promDosText.TabIndex = 2;
            this.promDosText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.promDosText_KeyPress);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Font = new System.Drawing.Font("Yu Gothic UI Light", 10F);
            this.button5.Location = new System.Drawing.Point(586, 246);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 50);
            this.button5.TabIndex = 1;
            this.button5.Text = "Promediar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // promUnoText
            // 
            this.promUnoText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.promUnoText.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.promUnoText.Location = new System.Drawing.Point(476, 142);
            this.promUnoText.MaxLength = 3;
            this.promUnoText.Name = "promUnoText";
            this.promUnoText.Size = new System.Drawing.Size(360, 34);
            this.promUnoText.TabIndex = 0;
            this.promUnoText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.promUnoText_KeyPress);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.axWindowsMediaPlayer1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(920, 568);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Videos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buscadordeArchivos
            // 
            this.buscadordeArchivos.FileName = "openFileDialog2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 601);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addjuntar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reproductor_musica)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox resultadoText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox promTresText;
        private System.Windows.Forms.TextBox promDosText;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox promUnoText;
        private AxWMPLib.AxWindowsMediaPlayer reproductor_musica;
        private System.Windows.Forms.PictureBox addjuntar;
        private System.Windows.Forms.ListBox lista_de_musica;
        private System.Windows.Forms.OpenFileDialog buscadordeArchivos;
        private System.Windows.Forms.Label label2;
    }
}

