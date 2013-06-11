namespace SafePass
{
    partial class FRM_Group
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Group));
            this.BTN_Cancelar = new System.Windows.Forms.Button();
            this.IMG_Iconos = new System.Windows.Forms.ImageList(this.components);
            this.BTN_Aceptar = new System.Windows.Forms.Button();
            this.TXT_Grupo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GB_General = new System.Windows.Forms.GroupBox();
            this.GB_General.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.ImageIndex = 2;
            this.BTN_Cancelar.ImageList = this.IMG_Iconos;
            this.BTN_Cancelar.Location = new System.Drawing.Point(172, 58);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancelar.TabIndex = 4;
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
            this.BTN_Aceptar.Location = new System.Drawing.Point(91, 58);
            this.BTN_Aceptar.Name = "BTN_Aceptar";
            this.BTN_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Aceptar.TabIndex = 3;
            this.BTN_Aceptar.Text = "Aceptar";
            this.BTN_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Aceptar.UseVisualStyleBackColor = true;
            this.BTN_Aceptar.Click += new System.EventHandler(this.BTN_Aceptar_Click);
            // 
            // TXT_Grupo
            // 
            this.TXT_Grupo.Location = new System.Drawing.Point(53, 22);
            this.TXT_Grupo.Name = "TXT_Grupo";
            this.TXT_Grupo.Size = new System.Drawing.Size(195, 20);
            this.TXT_Grupo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // GB_General
            // 
            this.GB_General.Controls.Add(this.BTN_Cancelar);
            this.GB_General.Controls.Add(this.BTN_Aceptar);
            this.GB_General.Controls.Add(this.label1);
            this.GB_General.Controls.Add(this.TXT_Grupo);
            this.GB_General.Location = new System.Drawing.Point(12, 12);
            this.GB_General.Name = "GB_General";
            this.GB_General.Size = new System.Drawing.Size(263, 99);
            this.GB_General.TabIndex = 1;
            this.GB_General.TabStop = false;
            // 
            // FRM_Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 127);
            this.Controls.Add(this.GB_General);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Group";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo grupo";
            this.Load += new System.EventHandler(this.FRM_NuevoGrupo_Load);
            this.GB_General.ResumeLayout(false);
            this.GB_General.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_Grupo;
        private System.Windows.Forms.Button BTN_Cancelar;
        private System.Windows.Forms.Button BTN_Aceptar;
        private System.Windows.Forms.ImageList IMG_Iconos;
        private System.Windows.Forms.GroupBox GB_General;
    }
}