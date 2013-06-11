namespace SafePass
{
    partial class FRM_MasterKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MasterKey));
            this.GB_Contenedor = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_ClaveNueva = new System.Windows.Forms.TextBox();
            this.BTN_Cancelar = new System.Windows.Forms.Button();
            this.IMG_Iconos = new System.Windows.Forms.ImageList(this.components);
            this.BTN_Aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_ClaveActual = new System.Windows.Forms.TextBox();
            this.GB_Contenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Contenedor
            // 
            this.GB_Contenedor.Controls.Add(this.label2);
            this.GB_Contenedor.Controls.Add(this.TXT_ClaveNueva);
            this.GB_Contenedor.Controls.Add(this.BTN_Cancelar);
            this.GB_Contenedor.Controls.Add(this.BTN_Aceptar);
            this.GB_Contenedor.Controls.Add(this.label1);
            this.GB_Contenedor.Controls.Add(this.TXT_ClaveActual);
            this.GB_Contenedor.Location = new System.Drawing.Point(12, 12);
            this.GB_Contenedor.Name = "GB_Contenedor";
            this.GB_Contenedor.Size = new System.Drawing.Size(291, 155);
            this.GB_Contenedor.TabIndex = 2;
            this.GB_Contenedor.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nueva contraseña";
            // 
            // TXT_ClaveNueva
            // 
            this.TXT_ClaveNueva.Location = new System.Drawing.Point(9, 78);
            this.TXT_ClaveNueva.Name = "TXT_ClaveNueva";
            this.TXT_ClaveNueva.PasswordChar = '*';
            this.TXT_ClaveNueva.Size = new System.Drawing.Size(276, 20);
            this.TXT_ClaveNueva.TabIndex = 10;
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.ImageIndex = 2;
            this.BTN_Cancelar.ImageList = this.IMG_Iconos;
            this.BTN_Cancelar.Location = new System.Drawing.Point(210, 110);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(75, 31);
            this.BTN_Cancelar.TabIndex = 8;
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
            this.IMG_Iconos.Images.SetKeyName(3, "key.png");
            // 
            // BTN_Aceptar
            // 
            this.BTN_Aceptar.ImageIndex = 1;
            this.BTN_Aceptar.ImageList = this.IMG_Iconos;
            this.BTN_Aceptar.Location = new System.Drawing.Point(129, 110);
            this.BTN_Aceptar.Name = "BTN_Aceptar";
            this.BTN_Aceptar.Size = new System.Drawing.Size(75, 31);
            this.BTN_Aceptar.TabIndex = 7;
            this.BTN_Aceptar.Text = "Aceptar";
            this.BTN_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Aceptar.UseVisualStyleBackColor = true;
            this.BTN_Aceptar.Click += new System.EventHandler(this.BTN_Aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contraseña actual";
            // 
            // TXT_ClaveActual
            // 
            this.TXT_ClaveActual.Location = new System.Drawing.Point(9, 32);
            this.TXT_ClaveActual.Name = "TXT_ClaveActual";
            this.TXT_ClaveActual.PasswordChar = '*';
            this.TXT_ClaveActual.Size = new System.Drawing.Size(276, 20);
            this.TXT_ClaveActual.TabIndex = 6;
            // 
            // FRM_MasterKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 181);
            this.Controls.Add(this.GB_Contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_MasterKey";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de contraseña";
            this.GB_Contenedor.ResumeLayout(false);
            this.GB_Contenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Contenedor;
        private System.Windows.Forms.Button BTN_Cancelar;
        private System.Windows.Forms.Button BTN_Aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_ClaveActual;
        private System.Windows.Forms.ImageList IMG_Iconos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_ClaveNueva;
    }
}