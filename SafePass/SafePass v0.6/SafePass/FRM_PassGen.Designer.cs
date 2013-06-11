namespace SafePass
{
    partial class FRM_PassGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PassGen));
            this.TXT_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Generate = new System.Windows.Forms.Button();
            this.IMG_Iconos = new System.Windows.Forms.ImageList(this.components);
            this.BTN_Copy = new System.Windows.Forms.Button();
            this.GB_Contenedor = new System.Windows.Forms.GroupBox();
            this.GB_Contenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXT_Password
            // 
            this.TXT_Password.Location = new System.Drawing.Point(14, 33);
            this.TXT_Password.Name = "TXT_Password";
            this.TXT_Password.Size = new System.Drawing.Size(303, 20);
            this.TXT_Password.TabIndex = 0;
            this.TXT_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contraseña generada";
            // 
            // BTN_Generate
            // 
            this.BTN_Generate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Generate.ImageIndex = 0;
            this.BTN_Generate.ImageList = this.IMG_Iconos;
            this.BTN_Generate.Location = new System.Drawing.Point(179, 65);
            this.BTN_Generate.Name = "BTN_Generate";
            this.BTN_Generate.Size = new System.Drawing.Size(66, 31);
            this.BTN_Generate.TabIndex = 2;
            this.BTN_Generate.Text = "Generar";
            this.BTN_Generate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Generate.UseVisualStyleBackColor = true;
            this.BTN_Generate.Click += new System.EventHandler(this.BTN_Generate_Click);
            // 
            // IMG_Iconos
            // 
            this.IMG_Iconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IMG_Iconos.ImageStream")));
            this.IMG_Iconos.TransparentColor = System.Drawing.Color.Transparent;
            this.IMG_Iconos.Images.SetKeyName(0, "key.png");
            this.IMG_Iconos.Images.SetKeyName(1, "clipboard.png");
            // 
            // BTN_Copy
            // 
            this.BTN_Copy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Copy.ImageIndex = 1;
            this.BTN_Copy.ImageList = this.IMG_Iconos;
            this.BTN_Copy.Location = new System.Drawing.Point(251, 65);
            this.BTN_Copy.Name = "BTN_Copy";
            this.BTN_Copy.Size = new System.Drawing.Size(66, 31);
            this.BTN_Copy.TabIndex = 3;
            this.BTN_Copy.Text = "Copiar";
            this.BTN_Copy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Copy.UseVisualStyleBackColor = true;
            this.BTN_Copy.Click += new System.EventHandler(this.BTN_Copy_Click);
            // 
            // GB_Contenedor
            // 
            this.GB_Contenedor.Controls.Add(this.BTN_Copy);
            this.GB_Contenedor.Controls.Add(this.BTN_Generate);
            this.GB_Contenedor.Controls.Add(this.TXT_Password);
            this.GB_Contenedor.Controls.Add(this.label1);
            this.GB_Contenedor.Location = new System.Drawing.Point(12, 12);
            this.GB_Contenedor.Name = "GB_Contenedor";
            this.GB_Contenedor.Size = new System.Drawing.Size(331, 111);
            this.GB_Contenedor.TabIndex = 1;
            this.GB_Contenedor.TabStop = false;
            // 
            // FRM_PassGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 135);
            this.Controls.Add(this.GB_Contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_PassGen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de contraseñas";
            this.Load += new System.EventHandler(this.FRM_PassGen_Load);
            this.GB_Contenedor.ResumeLayout(false);
            this.GB_Contenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_Password;
        private System.Windows.Forms.Button BTN_Generate;
        private System.Windows.Forms.Button BTN_Copy;
        private System.Windows.Forms.ImageList IMG_Iconos;
        private System.Windows.Forms.GroupBox GB_Contenedor;
    }
}