namespace SafePass
{
    partial class FRM_Auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Auth));
            this.IMG_Iconos = new System.Windows.Forms.ImageList(this.components);
            this.TXT_Pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Cancelar = new System.Windows.Forms.Button();
            this.BTN_Aceptar = new System.Windows.Forms.Button();
            this.GB_Contenedor = new System.Windows.Forms.GroupBox();
            this.GB_Contenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // IMG_Iconos
            // 
            this.IMG_Iconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IMG_Iconos.ImageStream")));
            this.IMG_Iconos.TransparentColor = System.Drawing.Color.Transparent;
            this.IMG_Iconos.Images.SetKeyName(0, "sticky-note-text.png");
            this.IMG_Iconos.Images.SetKeyName(1, "tick.png");
            this.IMG_Iconos.Images.SetKeyName(2, "cross.png");
            this.IMG_Iconos.Images.SetKeyName(3, "key.png");
            // 
            // TXT_Pass
            // 
            this.TXT_Pass.Location = new System.Drawing.Point(9, 32);
            this.TXT_Pass.Name = "TXT_Pass";
            this.TXT_Pass.PasswordChar = '*';
            this.TXT_Pass.Size = new System.Drawing.Size(276, 20);
            this.TXT_Pass.TabIndex = 6;
            this.TXT_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_Pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_Pass_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contraseña";
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.ImageIndex = 2;
            this.BTN_Cancelar.ImageList = this.IMG_Iconos;
            this.BTN_Cancelar.Location = new System.Drawing.Point(210, 63);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(75, 31);
            this.BTN_Cancelar.TabIndex = 8;
            this.BTN_Cancelar.Text = "Cancelar";
            this.BTN_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Cancelar.UseVisualStyleBackColor = true;
            this.BTN_Cancelar.Click += new System.EventHandler(this.BTN_Cancelar_Click);
            // 
            // BTN_Aceptar
            // 
            this.BTN_Aceptar.ImageIndex = 1;
            this.BTN_Aceptar.ImageList = this.IMG_Iconos;
            this.BTN_Aceptar.Location = new System.Drawing.Point(129, 63);
            this.BTN_Aceptar.Name = "BTN_Aceptar";
            this.BTN_Aceptar.Size = new System.Drawing.Size(75, 31);
            this.BTN_Aceptar.TabIndex = 7;
            this.BTN_Aceptar.Text = "Aceptar";
            this.BTN_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Aceptar.UseVisualStyleBackColor = true;
            this.BTN_Aceptar.Click += new System.EventHandler(this.BTN_Aceptar_Click);
            // 
            // GB_Contenedor
            // 
            this.GB_Contenedor.Controls.Add(this.BTN_Cancelar);
            this.GB_Contenedor.Controls.Add(this.BTN_Aceptar);
            this.GB_Contenedor.Controls.Add(this.label1);
            this.GB_Contenedor.Controls.Add(this.TXT_Pass);
            this.GB_Contenedor.Location = new System.Drawing.Point(12, 12);
            this.GB_Contenedor.Name = "GB_Contenedor";
            this.GB_Contenedor.Size = new System.Drawing.Size(291, 105);
            this.GB_Contenedor.TabIndex = 1;
            this.GB_Contenedor.TabStop = false;
            // 
            // FRM_Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 129);
            this.Controls.Add(this.GB_Contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Auth";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentificación";
            this.GB_Contenedor.ResumeLayout(false);
            this.GB_Contenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Cancelar;
        private System.Windows.Forms.Button BTN_Aceptar;
        private System.Windows.Forms.TextBox TXT_Pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList IMG_Iconos;
        private System.Windows.Forms.GroupBox GB_Contenedor;
    }
}