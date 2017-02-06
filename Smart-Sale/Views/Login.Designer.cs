namespace Smart_Sale.Views
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtContrasena = new DevExpress.XtraEditors.TextEdit();
            this.lblContrasenaOlvidada = new DevExpress.XtraEditors.LabelControl();
            this.petVerContrasena = new DevExpress.XtraEditors.PictureEdit();
            this.btnAcceder = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.petSalir = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petVerContrasena.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petSalir.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Californian FB", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(113, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(216, 31);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Acceso Smart-Sale";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(161, 49);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Usuario:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(161, 114);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 17);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(161, 72);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Size = new System.Drawing.Size(317, 24);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(161, 137);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txtContrasena.Properties.Appearance.Options.UseFont = true;
            this.txtContrasena.Properties.PasswordChar = '•';
            this.txtContrasena.Size = new System.Drawing.Size(290, 24);
            this.txtContrasena.TabIndex = 5;
            // 
            // lblContrasenaOlvidada
            // 
            this.lblContrasenaOlvidada.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.lblContrasenaOlvidada.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblContrasenaOlvidada.Appearance.Options.UseFont = true;
            this.lblContrasenaOlvidada.Appearance.Options.UseForeColor = true;
            this.lblContrasenaOlvidada.Location = new System.Drawing.Point(14, 204);
            this.lblContrasenaOlvidada.Name = "lblContrasenaOlvidada";
            this.lblContrasenaOlvidada.Size = new System.Drawing.Size(125, 13);
            this.lblContrasenaOlvidada.TabIndex = 7;
            this.lblContrasenaOlvidada.Text = "¿Olvidaste tu contraseña?\r\n";
            this.lblContrasenaOlvidada.Click += new System.EventHandler(this.lblContrasenaOlvidada_Click);
            // 
            // petVerContrasena
            // 
            this.petVerContrasena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.petVerContrasena.Cursor = System.Windows.Forms.Cursors.Default;
            this.petVerContrasena.EditValue = global::Smart_Sale.Properties.Resources.Visible;
            this.petVerContrasena.Location = new System.Drawing.Point(457, 139);
            this.petVerContrasena.Name = "petVerContrasena";
            this.petVerContrasena.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.petVerContrasena.Properties.Appearance.Options.UseBackColor = true;
            this.petVerContrasena.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.petVerContrasena.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.petVerContrasena.Properties.ShowMenu = false;
            this.petVerContrasena.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.petVerContrasena.Properties.ZoomAccelerationFactor = 1D;
            this.petVerContrasena.Size = new System.Drawing.Size(21, 22);
            this.petVerContrasena.TabIndex = 8;
            this.petVerContrasena.MouseDown += new System.Windows.Forms.MouseEventHandler(this.petVerContrasena_MouseDown);
            this.petVerContrasena.MouseUp += new System.Windows.Forms.MouseEventHandler(this.petVerContrasena_MouseUp);
            // 
            // btnAcceder
            // 
            this.btnAcceder.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.btnAcceder.Appearance.Options.UseFont = true;
            this.btnAcceder.Image = ((System.Drawing.Image)(resources.GetObject("btnAcceder.Image")));
            this.btnAcceder.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAcceder.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAcceder.Location = new System.Drawing.Point(367, 194);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(111, 23);
            this.btnAcceder.TabIndex = 6;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(14, 49);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ShowMenu = false;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(110, 103);
            this.pictureEdit1.TabIndex = 1;
            // 
            // petSalir
            // 
            this.petSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.petSalir.Cursor = System.Windows.Forms.Cursors.Default;
            this.petSalir.EditValue = ((object)(resources.GetObject("petSalir.EditValue")));
            this.petSalir.Location = new System.Drawing.Point(457, 12);
            this.petSalir.Name = "petSalir";
            this.petSalir.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.petSalir.Properties.Appearance.Options.UseBackColor = true;
            this.petSalir.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.petSalir.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.petSalir.Properties.ShowMenu = false;
            this.petSalir.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.petSalir.Properties.ZoomAccelerationFactor = 1D;
            this.petSalir.Size = new System.Drawing.Size(23, 23);
            this.petSalir.TabIndex = 9;
            this.petSalir.Click += new System.EventHandler(this.petSalir_Click);
            // 
            // Login
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 240);
            this.Controls.Add(this.petSalir);
            this.Controls.Add(this.petVerContrasena);
            this.Controls.Add(this.lblContrasenaOlvidada);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petVerContrasena.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petSalir.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.TextEdit txtContrasena;
        private DevExpress.XtraEditors.SimpleButton btnAcceder;
        private DevExpress.XtraEditors.LabelControl lblContrasenaOlvidada;
        private DevExpress.XtraEditors.PictureEdit petVerContrasena;
        private DevExpress.XtraEditors.PictureEdit petSalir;
    }
}