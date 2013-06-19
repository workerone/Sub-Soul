namespace File_Explorer
{
    partial class FRM_Main
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Main));
            this.CMB_Drives = new System.Windows.Forms.ComboBox();
            this.LSV_Files = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IMG_List = new System.Windows.Forms.ImageList(this.components);
            this.LSV_Folders = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTN_Root = new System.Windows.Forms.Button();
            this.BTN_Prev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CMB_Drives
            // 
            this.CMB_Drives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Drives.FormattingEnabled = true;
            this.CMB_Drives.Location = new System.Drawing.Point(12, 12);
            this.CMB_Drives.Name = "CMB_Drives";
            this.CMB_Drives.Size = new System.Drawing.Size(130, 21);
            this.CMB_Drives.TabIndex = 0;
            this.CMB_Drives.SelectedIndexChanged += new System.EventHandler(this.CMB_Drives_SelectedIndexChanged);
            // 
            // LSV_Files
            // 
            this.LSV_Files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LSV_Files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.LSV_Files.FullRowSelect = true;
            this.LSV_Files.GridLines = true;
            this.LSV_Files.Location = new System.Drawing.Point(241, 12);
            this.LSV_Files.Name = "LSV_Files";
            this.LSV_Files.Size = new System.Drawing.Size(502, 414);
            this.LSV_Files.SmallImageList = this.IMG_List;
            this.LSV_Files.TabIndex = 2;
            this.LSV_Files.UseCompatibleStateImageBehavior = false;
            this.LSV_Files.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File Name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Attributes";
            this.columnHeader3.Width = 180;
            // 
            // IMG_List
            // 
            this.IMG_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IMG_List.ImageStream")));
            this.IMG_List.TransparentColor = System.Drawing.Color.Transparent;
            this.IMG_List.Images.SetKeyName(0, "folder-horizontal.png");
            this.IMG_List.Images.SetKeyName(1, "application-blue.png");
            // 
            // LSV_Folders
            // 
            this.LSV_Folders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LSV_Folders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.LSV_Folders.FullRowSelect = true;
            this.LSV_Folders.GridLines = true;
            this.LSV_Folders.Location = new System.Drawing.Point(12, 39);
            this.LSV_Folders.Name = "LSV_Folders";
            this.LSV_Folders.Size = new System.Drawing.Size(223, 387);
            this.LSV_Folders.SmallImageList = this.IMG_List;
            this.LSV_Folders.TabIndex = 5;
            this.LSV_Folders.UseCompatibleStateImageBehavior = false;
            this.LSV_Folders.View = System.Windows.Forms.View.Details;
            this.LSV_Folders.DoubleClick += new System.EventHandler(this.LSV_Folders_DoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Folder Name";
            this.columnHeader4.Width = 205;
            // 
            // BTN_Root
            // 
            this.BTN_Root.Image = global::File_Explorer.Properties.Resources.home;
            this.BTN_Root.Location = new System.Drawing.Point(192, 11);
            this.BTN_Root.Name = "BTN_Root";
            this.BTN_Root.Size = new System.Drawing.Size(43, 23);
            this.BTN_Root.TabIndex = 4;
            this.BTN_Root.UseVisualStyleBackColor = true;
            this.BTN_Root.Click += new System.EventHandler(this.BTN_Root_Click);
            // 
            // BTN_Prev
            // 
            this.BTN_Prev.Image = global::File_Explorer.Properties.Resources.arrow_turn_180;
            this.BTN_Prev.Location = new System.Drawing.Point(148, 11);
            this.BTN_Prev.Name = "BTN_Prev";
            this.BTN_Prev.Size = new System.Drawing.Size(43, 23);
            this.BTN_Prev.TabIndex = 3;
            this.BTN_Prev.UseVisualStyleBackColor = true;
            this.BTN_Prev.Click += new System.EventHandler(this.BTN_Prev_Click);
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 438);
            this.Controls.Add(this.LSV_Folders);
            this.Controls.Add(this.BTN_Root);
            this.Controls.Add(this.BTN_Prev);
            this.Controls.Add(this.LSV_Files);
            this.Controls.Add(this.CMB_Drives);
            this.Name = "FRM_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Explorer";
            this.Load += new System.EventHandler(this.FRM_Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CMB_Drives;
        private System.Windows.Forms.ListView LSV_Files;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button BTN_Prev;
        private System.Windows.Forms.Button BTN_Root;
        private System.Windows.Forms.ImageList IMG_List;
        private System.Windows.Forms.ListView LSV_Folders;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

