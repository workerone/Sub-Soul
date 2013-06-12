namespace SafePass
{
    partial class FRM_Entry
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Entry));
            this.TB_Ficha = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BTN_Cancelar = new System.Windows.Forms.Button();
            this.IMG_Iconos = new System.Windows.Forms.ImageList(this.components);
            this.BTN_Aceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CMB_Grupos = new System.Windows.Forms.ComboBox();
            this.TXT_Detalles = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_URL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_Pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_Usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_Titulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Ficha.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Ficha
            // 
            this.TB_Ficha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Ficha.Controls.Add(this.tabPage2);
            this.TB_Ficha.ImageList = this.IMG_Iconos;
            this.TB_Ficha.Location = new System.Drawing.Point(1, 1);
            this.TB_Ficha.Name = "TB_Ficha";
            this.TB_Ficha.SelectedIndex = 0;
            this.TB_Ficha.Size = new System.Drawing.Size(430, 286);
            this.TB_Ficha.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BTN_Cancelar);
            this.tabPage2.Controls.Add(this.BTN_Aceptar);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.ImageIndex = 0;
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(422, 259);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ficha";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.ImageIndex = 2;
            this.BTN_Cancelar.ImageList = this.IMG_Iconos;
            this.BTN_Cancelar.Location = new System.Drawing.Point(339, 228);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancelar.TabIndex = 7;
            this.BTN_Cancelar.Text = "Cancelar";
            this.BTN_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Cancelar.UseVisualStyleBackColor = true;
            this.BTN_Cancelar.Click += new System.EventHandler(this.BTN_Cancelar_Click);
            // 
            // IMG_Iconos
            // 
            this.IMG_Iconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IMG_Iconos.ImageStream")));
            this.IMG_Iconos.TransparentColor = System.Drawing.Color.Transparent;
            this.IMG_Iconos.Images.SetKeyName(0, "sticky-note-text.png");
            this.IMG_Iconos.Images.SetKeyName(1, "tick.png");
            this.IMG_Iconos.Images.SetKeyName(2, "cross.png");
            // 
            // BTN_Aceptar
            // 
            this.BTN_Aceptar.ImageIndex = 1;
            this.BTN_Aceptar.ImageList = this.IMG_Iconos;
            this.BTN_Aceptar.Location = new System.Drawing.Point(258, 228);
            this.BTN_Aceptar.Name = "BTN_Aceptar";
            this.BTN_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Aceptar.TabIndex = 6;
            this.BTN_Aceptar.Text = "Aceptar";
            this.BTN_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Aceptar.UseVisualStyleBackColor = true;
            this.BTN_Aceptar.Click += new System.EventHandler(this.BTN_Aceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CMB_Grupos);
            this.groupBox1.Controls.Add(this.TXT_Detalles);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TXT_URL);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TXT_Pass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXT_Usuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TXT_Titulo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Grupos:";
            // 
            // CMB_Grupos
            // 
            this.CMB_Grupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Grupos.FormattingEnabled = true;
            this.CMB_Grupos.Location = new System.Drawing.Point(112, 187);
            this.CMB_Grupos.Name = "CMB_Grupos";
            this.CMB_Grupos.Size = new System.Drawing.Size(285, 21);
            this.CMB_Grupos.TabIndex = 5;
            // 
            // TXT_Detalles
            // 
            this.TXT_Detalles.Location = new System.Drawing.Point(112, 132);
            this.TXT_Detalles.MaxLength = 200;
            this.TXT_Detalles.Multiline = true;
            this.TXT_Detalles.Name = "TXT_Detalles";
            this.TXT_Detalles.Size = new System.Drawing.Size(285, 49);
            this.TXT_Detalles.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Detalles:";
            // 
            // TXT_URL
            // 
            this.TXT_URL.Location = new System.Drawing.Point(112, 102);
            this.TXT_URL.MaxLength = 100;
            this.TXT_URL.Name = "TXT_URL";
            this.TXT_URL.Size = new System.Drawing.Size(285, 20);
            this.TXT_URL.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "URL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 8;
            // 
            // TXT_Pass
            // 
            this.TXT_Pass.Location = new System.Drawing.Point(112, 73);
            this.TXT_Pass.MaxLength = 50;
            this.TXT_Pass.Name = "TXT_Pass";
            this.TXT_Pass.PasswordChar = '*';
            this.TXT_Pass.Size = new System.Drawing.Size(285, 20);
            this.TXT_Pass.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña:";
            // 
            // TXT_Usuario
            // 
            this.TXT_Usuario.Location = new System.Drawing.Point(112, 42);
            this.TXT_Usuario.MaxLength = 50;
            this.TXT_Usuario.Name = "TXT_Usuario";
            this.TXT_Usuario.Size = new System.Drawing.Size(285, 20);
            this.TXT_Usuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario:";
            // 
            // TXT_Titulo
            // 
            this.TXT_Titulo.Location = new System.Drawing.Point(112, 13);
            this.TXT_Titulo.MaxLength = 20;
            this.TXT_Titulo.Name = "TXT_Titulo";
            this.TXT_Titulo.Size = new System.Drawing.Size(285, 20);
            this.TXT_Titulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo:";
            // 
            // FRM_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 287);
            this.Controls.Add(this.TB_Ficha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Entry";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva entrada";
            this.Load += new System.EventHandler(this.FRM_NuevaEntrada_Load);
            this.TB_Ficha.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TB_Ficha;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList IMG_Iconos;
        private System.Windows.Forms.TextBox TXT_Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_Pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_Detalles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXT_URL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_Aceptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CMB_Grupos;
        private System.Windows.Forms.Button BTN_Cancelar;
    }
}