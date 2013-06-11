namespace SafePass
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.TB_General = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SC_Contenedor = new System.Windows.Forms.SplitContainer();
            this.TRV_Lista = new System.Windows.Forms.TreeView();
            this.IMG_Iconos = new System.Windows.Forms.ImageList(this.components);
            this.LSV_Data = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MN_Datos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSM_NuevaEntrada = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_EditarEntrada = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_EliminarEntrada = new System.Windows.Forms.ToolStripMenuItem();
            this.STS_Estado = new System.Windows.Forms.StatusStrip();
            this.TSL_TotalEntradas = new System.Windows.Forms.ToolStripStatusLabel();
            this.MN_Global = new System.Windows.Forms.MenuStrip();
            this.MN_Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.MN_NuevaDB = new System.Windows.Forms.ToolStripMenuItem();
            this.MN_Abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.MN_ClaveMaestra = new System.Windows.Forms.ToolStripMenuItem();
            this.MN_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.MN_Herramientas = new System.Windows.Forms.ToolStripMenuItem();
            this.MN_GenClaves = new System.Windows.Forms.ToolStripMenuItem();
            this.MN_Ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.MN_AcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_BarraMenu = new System.Windows.Forms.ToolStrip();
            this.TS_NuevaDB = new System.Windows.Forms.ToolStripButton();
            this.TS_Abrir = new System.Windows.Forms.ToolStripButton();
            this.TS_Refrescar = new System.Windows.Forms.ToolStripButton();
            this.TS_NuevaEntrada = new System.Windows.Forms.ToolStripButton();
            this.MN_Grupos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSM_NuevoGrupo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Editar = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.TB_General.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SC_Contenedor)).BeginInit();
            this.SC_Contenedor.Panel1.SuspendLayout();
            this.SC_Contenedor.Panel2.SuspendLayout();
            this.SC_Contenedor.SuspendLayout();
            this.MN_Datos.SuspendLayout();
            this.STS_Estado.SuspendLayout();
            this.MN_Global.SuspendLayout();
            this.TS_BarraMenu.SuspendLayout();
            this.MN_Grupos.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_General
            // 
            this.TB_General.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_General.Controls.Add(this.tabPage2);
            this.TB_General.ImageList = this.IMG_Iconos;
            this.TB_General.Location = new System.Drawing.Point(2, 52);
            this.TB_General.Name = "TB_General";
            this.TB_General.SelectedIndex = 0;
            this.TB_General.Size = new System.Drawing.Size(798, 395);
            this.TB_General.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SC_Contenedor);
            this.tabPage2.ImageIndex = 0;
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Base de datos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SC_Contenedor
            // 
            this.SC_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SC_Contenedor.Location = new System.Drawing.Point(3, 3);
            this.SC_Contenedor.Name = "SC_Contenedor";
            // 
            // SC_Contenedor.Panel1
            // 
            this.SC_Contenedor.Panel1.Controls.Add(this.TRV_Lista);
            // 
            // SC_Contenedor.Panel2
            // 
            this.SC_Contenedor.Panel2.Controls.Add(this.LSV_Data);
            this.SC_Contenedor.Size = new System.Drawing.Size(784, 362);
            this.SC_Contenedor.SplitterDistance = 242;
            this.SC_Contenedor.TabIndex = 0;
            // 
            // TRV_Lista
            // 
            this.TRV_Lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TRV_Lista.ImageIndex = 0;
            this.TRV_Lista.ImageList = this.IMG_Iconos;
            this.TRV_Lista.Location = new System.Drawing.Point(0, 0);
            this.TRV_Lista.Name = "TRV_Lista";
            this.TRV_Lista.SelectedImageIndex = 0;
            this.TRV_Lista.Size = new System.Drawing.Size(242, 362);
            this.TRV_Lista.TabIndex = 0;
            this.TRV_Lista.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TRV_Lista_NodeMouseClick);
            // 
            // IMG_Iconos
            // 
            this.IMG_Iconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IMG_Iconos.ImageStream")));
            this.IMG_Iconos.TransparentColor = System.Drawing.Color.Transparent;
            this.IMG_Iconos.Images.SetKeyName(0, "database--arrow.png");
            this.IMG_Iconos.Images.SetKeyName(1, "windows.png");
            this.IMG_Iconos.Images.SetKeyName(2, "mail.png");
            this.IMG_Iconos.Images.SetKeyName(3, "globe.png");
            this.IMG_Iconos.Images.SetKeyName(4, "inbox-document.png");
            this.IMG_Iconos.Images.SetKeyName(5, "star.png");
            this.IMG_Iconos.Images.SetKeyName(6, "key-solid.png");
            this.IMG_Iconos.Images.SetKeyName(7, "wallet.png");
            // 
            // LSV_Data
            // 
            this.LSV_Data.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.LSV_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_Data.FullRowSelect = true;
            this.LSV_Data.GridLines = true;
            this.LSV_Data.Location = new System.Drawing.Point(0, 0);
            this.LSV_Data.Name = "LSV_Data";
            this.LSV_Data.Size = new System.Drawing.Size(538, 362);
            this.LSV_Data.TabIndex = 0;
            this.LSV_Data.UseCompatibleStateImageBehavior = false;
            this.LSV_Data.View = System.Windows.Forms.View.Details;
            this.LSV_Data.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LSV_Data_MouseUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Titulo";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Usuario";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Contraseña";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "URL";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Detalles";
            this.columnHeader5.Width = 200;
            // 
            // MN_Datos
            // 
            this.MN_Datos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_NuevaEntrada,
            this.TSM_EditarEntrada,
            this.TSM_EliminarEntrada});
            this.MN_Datos.Name = "MN_Datos";
            this.MN_Datos.Size = new System.Drawing.Size(118, 70);
            // 
            // TSM_NuevaEntrada
            // 
            this.TSM_NuevaEntrada.Image = global::SafePass.Properties.Resources.document__plus;
            this.TSM_NuevaEntrada.Name = "TSM_NuevaEntrada";
            this.TSM_NuevaEntrada.Size = new System.Drawing.Size(117, 22);
            this.TSM_NuevaEntrada.Text = "Añadir";
            this.TSM_NuevaEntrada.Click += new System.EventHandler(this.TSM_NuevaEntrada_Click);
            // 
            // TSM_EditarEntrada
            // 
            this.TSM_EditarEntrada.Image = global::SafePass.Properties.Resources.document__pencil;
            this.TSM_EditarEntrada.Name = "TSM_EditarEntrada";
            this.TSM_EditarEntrada.Size = new System.Drawing.Size(117, 22);
            this.TSM_EditarEntrada.Text = "Editar";
            this.TSM_EditarEntrada.Click += new System.EventHandler(this.TSM_EditarEntrada_Click);
            // 
            // TSM_EliminarEntrada
            // 
            this.TSM_EliminarEntrada.Image = global::SafePass.Properties.Resources.document__minus;
            this.TSM_EliminarEntrada.Name = "TSM_EliminarEntrada";
            this.TSM_EliminarEntrada.Size = new System.Drawing.Size(117, 22);
            this.TSM_EliminarEntrada.Text = "Eliminar";
            this.TSM_EliminarEntrada.Click += new System.EventHandler(this.TSM_EliminarEntrada_Click);
            // 
            // STS_Estado
            // 
            this.STS_Estado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSL_TotalEntradas});
            this.STS_Estado.Location = new System.Drawing.Point(0, 450);
            this.STS_Estado.Name = "STS_Estado";
            this.STS_Estado.Size = new System.Drawing.Size(801, 22);
            this.STS_Estado.TabIndex = 1;
            this.STS_Estado.Text = "statusStrip1";
            // 
            // TSL_TotalEntradas
            // 
            this.TSL_TotalEntradas.Name = "TSL_TotalEntradas";
            this.TSL_TotalEntradas.Size = new System.Drawing.Size(93, 17);
            this.TSL_TotalEntradas.Text = "Total entrada(s):";
            // 
            // MN_Global
            // 
            this.MN_Global.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MN_Archivo,
            this.MN_Herramientas,
            this.MN_Ayuda});
            this.MN_Global.Location = new System.Drawing.Point(0, 0);
            this.MN_Global.Name = "MN_Global";
            this.MN_Global.Size = new System.Drawing.Size(801, 24);
            this.MN_Global.TabIndex = 2;
            this.MN_Global.Text = "menuStrip1";
            // 
            // MN_Archivo
            // 
            this.MN_Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MN_NuevaDB,
            this.MN_Abrir,
            this.MN_ClaveMaestra,
            this.MN_Salir});
            this.MN_Archivo.Name = "MN_Archivo";
            this.MN_Archivo.Size = new System.Drawing.Size(60, 20);
            this.MN_Archivo.Text = "Archivo";
            // 
            // MN_NuevaDB
            // 
            this.MN_NuevaDB.Image = global::SafePass.Properties.Resources.database__plus;
            this.MN_NuevaDB.Name = "MN_NuevaDB";
            this.MN_NuevaDB.Size = new System.Drawing.Size(183, 22);
            this.MN_NuevaDB.Text = "Nueva base de datos";
            this.MN_NuevaDB.Click += new System.EventHandler(this.MN_NuevaDB_Click);
            // 
            // MN_Abrir
            // 
            this.MN_Abrir.Image = global::SafePass.Properties.Resources.folder_open_document;
            this.MN_Abrir.Name = "MN_Abrir";
            this.MN_Abrir.Size = new System.Drawing.Size(183, 22);
            this.MN_Abrir.Text = "Abrir";
            this.MN_Abrir.Click += new System.EventHandler(this.MN_Abrir_Click);
            // 
            // MN_ClaveMaestra
            // 
            this.MN_ClaveMaestra.Image = global::SafePass.Properties.Resources.safe;
            this.MN_ClaveMaestra.Name = "MN_ClaveMaestra";
            this.MN_ClaveMaestra.Size = new System.Drawing.Size(183, 22);
            this.MN_ClaveMaestra.Text = "Clave maestra";
            this.MN_ClaveMaestra.Click += new System.EventHandler(this.MN_ClaveMaestra_Click);
            // 
            // MN_Salir
            // 
            this.MN_Salir.Image = global::SafePass.Properties.Resources.door_open_out;
            this.MN_Salir.Name = "MN_Salir";
            this.MN_Salir.Size = new System.Drawing.Size(183, 22);
            this.MN_Salir.Text = "Salir";
            this.MN_Salir.Click += new System.EventHandler(this.MN_Salir_Click);
            // 
            // MN_Herramientas
            // 
            this.MN_Herramientas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MN_GenClaves});
            this.MN_Herramientas.Name = "MN_Herramientas";
            this.MN_Herramientas.Size = new System.Drawing.Size(90, 20);
            this.MN_Herramientas.Text = "Herramientas";
            // 
            // MN_GenClaves
            // 
            this.MN_GenClaves.Image = global::SafePass.Properties.Resources.key;
            this.MN_GenClaves.Name = "MN_GenClaves";
            this.MN_GenClaves.Size = new System.Drawing.Size(164, 22);
            this.MN_GenClaves.Text = "Generador claves";
            this.MN_GenClaves.Click += new System.EventHandler(this.MN_GenClaves_Click);
            // 
            // MN_Ayuda
            // 
            this.MN_Ayuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MN_AcercaDe});
            this.MN_Ayuda.Name = "MN_Ayuda";
            this.MN_Ayuda.Size = new System.Drawing.Size(53, 20);
            this.MN_Ayuda.Text = "Ayuda";
            // 
            // MN_AcercaDe
            // 
            this.MN_AcercaDe.Image = global::SafePass.Properties.Resources.information_frame;
            this.MN_AcercaDe.Name = "MN_AcercaDe";
            this.MN_AcercaDe.Size = new System.Drawing.Size(126, 22);
            this.MN_AcercaDe.Text = "Acerca de";
            this.MN_AcercaDe.Click += new System.EventHandler(this.MN_AcercaDe_Click);
            // 
            // TS_BarraMenu
            // 
            this.TS_BarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_NuevaDB,
            this.TS_Abrir,
            this.TS_Refrescar,
            this.TS_NuevaEntrada});
            this.TS_BarraMenu.Location = new System.Drawing.Point(0, 24);
            this.TS_BarraMenu.Name = "TS_BarraMenu";
            this.TS_BarraMenu.Size = new System.Drawing.Size(801, 25);
            this.TS_BarraMenu.TabIndex = 3;
            // 
            // TS_NuevaDB
            // 
            this.TS_NuevaDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TS_NuevaDB.Image = global::SafePass.Properties.Resources.database__plus;
            this.TS_NuevaDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_NuevaDB.Name = "TS_NuevaDB";
            this.TS_NuevaDB.Size = new System.Drawing.Size(23, 22);
            this.TS_NuevaDB.Text = "Nueva base de datos";
            this.TS_NuevaDB.Click += new System.EventHandler(this.TS_NuevaDB_Click);
            // 
            // TS_Abrir
            // 
            this.TS_Abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TS_Abrir.Image = global::SafePass.Properties.Resources.folder_open_document;
            this.TS_Abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Abrir.Name = "TS_Abrir";
            this.TS_Abrir.Size = new System.Drawing.Size(23, 22);
            this.TS_Abrir.Text = "Abrir";
            this.TS_Abrir.Click += new System.EventHandler(this.TS_Abrir_Click);
            // 
            // TS_Refrescar
            // 
            this.TS_Refrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TS_Refrescar.Image = global::SafePass.Properties.Resources.arrow_circle_double_135;
            this.TS_Refrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Refrescar.Name = "TS_Refrescar";
            this.TS_Refrescar.Size = new System.Drawing.Size(23, 22);
            this.TS_Refrescar.Text = "Refrescar";
            this.TS_Refrescar.Click += new System.EventHandler(this.TS_Refrescar_Click);
            // 
            // TS_NuevaEntrada
            // 
            this.TS_NuevaEntrada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TS_NuevaEntrada.Image = global::SafePass.Properties.Resources.document__plus;
            this.TS_NuevaEntrada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_NuevaEntrada.Name = "TS_NuevaEntrada";
            this.TS_NuevaEntrada.Size = new System.Drawing.Size(23, 22);
            this.TS_NuevaEntrada.Text = "Nueva entrada";
            this.TS_NuevaEntrada.Click += new System.EventHandler(this.TS_NuevaEntrada_Click);
            // 
            // MN_Grupos
            // 
            this.MN_Grupos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_NuevoGrupo,
            this.TSM_Editar,
            this.TSM_Eliminar});
            this.MN_Grupos.Name = "MN_Grupos";
            this.MN_Grupos.Size = new System.Drawing.Size(118, 70);
            // 
            // TSM_NuevoGrupo
            // 
            this.TSM_NuevoGrupo.Image = global::SafePass.Properties.Resources.drawer__plus;
            this.TSM_NuevoGrupo.Name = "TSM_NuevoGrupo";
            this.TSM_NuevoGrupo.Size = new System.Drawing.Size(117, 22);
            this.TSM_NuevoGrupo.Text = "Nuevo";
            this.TSM_NuevoGrupo.Click += new System.EventHandler(this.TSM_NuevoGrupo_Click);
            // 
            // TSM_Editar
            // 
            this.TSM_Editar.Image = global::SafePass.Properties.Resources.drawer__pencil;
            this.TSM_Editar.Name = "TSM_Editar";
            this.TSM_Editar.Size = new System.Drawing.Size(117, 22);
            this.TSM_Editar.Text = "Editar";
            this.TSM_Editar.Click += new System.EventHandler(this.TSM_Editar_Click);
            // 
            // TSM_Eliminar
            // 
            this.TSM_Eliminar.Image = global::SafePass.Properties.Resources.drawer__minus;
            this.TSM_Eliminar.Name = "TSM_Eliminar";
            this.TSM_Eliminar.Size = new System.Drawing.Size(117, 22);
            this.TSM_Eliminar.Text = "Eliminar";
            this.TSM_Eliminar.Click += new System.EventHandler(this.TSM_Eliminar_Click);
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 472);
            this.Controls.Add(this.TS_BarraMenu);
            this.Controls.Add(this.STS_Estado);
            this.Controls.Add(this.MN_Global);
            this.Controls.Add(this.TB_General);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MN_Global;
            this.Name = "FRM_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SafePass v0.6";
            this.Load += new System.EventHandler(this.FRM_Main_Load);
            this.TB_General.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.SC_Contenedor.Panel1.ResumeLayout(false);
            this.SC_Contenedor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SC_Contenedor)).EndInit();
            this.SC_Contenedor.ResumeLayout(false);
            this.MN_Datos.ResumeLayout(false);
            this.STS_Estado.ResumeLayout(false);
            this.STS_Estado.PerformLayout();
            this.MN_Global.ResumeLayout(false);
            this.MN_Global.PerformLayout();
            this.TS_BarraMenu.ResumeLayout(false);
            this.TS_BarraMenu.PerformLayout();
            this.MN_Grupos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TB_General;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer SC_Contenedor;
        private System.Windows.Forms.StatusStrip STS_Estado;
        private System.Windows.Forms.ToolStripStatusLabel TSL_TotalEntradas;
        private System.Windows.Forms.MenuStrip MN_Global;
        private System.Windows.Forms.ToolStripMenuItem MN_Archivo;
        private System.Windows.Forms.ToolStripMenuItem MN_Abrir;
        private System.Windows.Forms.ToolStripMenuItem MN_ClaveMaestra;
        private System.Windows.Forms.ToolStripMenuItem MN_Salir;
        private System.Windows.Forms.ToolStripMenuItem MN_Herramientas;
        private System.Windows.Forms.ToolStripMenuItem MN_GenClaves;
        private System.Windows.Forms.ToolStripMenuItem MN_Ayuda;
        private System.Windows.Forms.ToolStripMenuItem MN_AcercaDe;
        private System.Windows.Forms.ToolStrip TS_BarraMenu;
        private System.Windows.Forms.ToolStripButton TS_NuevaDB;
        private System.Windows.Forms.ImageList IMG_Iconos;
        private System.Windows.Forms.ToolStripButton TS_Abrir;
        private System.Windows.Forms.ToolStripButton TS_NuevaEntrada;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ContextMenuStrip MN_Grupos;
        private System.Windows.Forms.ToolStripMenuItem TSM_NuevoGrupo;
        private System.Windows.Forms.ToolStripMenuItem TSM_Eliminar;
        private System.Windows.Forms.ContextMenuStrip MN_Datos;
        private System.Windows.Forms.ToolStripMenuItem TSM_Editar;
        private System.Windows.Forms.ToolStripMenuItem TSM_EditarEntrada;
        private System.Windows.Forms.ToolStripMenuItem TSM_EliminarEntrada;
        private System.Windows.Forms.ToolStripMenuItem TSM_NuevaEntrada;
        private System.Windows.Forms.ToolStripButton TS_Refrescar;
        internal System.Windows.Forms.ListView LSV_Data;
        private System.Windows.Forms.ToolStripMenuItem MN_NuevaDB;
        internal System.Windows.Forms.TreeView TRV_Lista;

    }
}

