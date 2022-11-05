
namespace Monitor
{
    partial class Monitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monitor));
            this.tabControlMonitoreo = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.cmbSites = new System.Windows.Forms.ComboBox();
            this.txtAddRoom = new System.Windows.Forms.TextBox();
            this.lblAddRoom = new System.Windows.Forms.Label();
            this.GrdRooms = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Website = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autorec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControlMonitoreo.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMonitoreo
            // 
            this.tabControlMonitoreo.Controls.Add(this.TabPage1);
            this.tabControlMonitoreo.Location = new System.Drawing.Point(16, 16);
            this.tabControlMonitoreo.Name = "tabControlMonitoreo";
            this.tabControlMonitoreo.SelectedIndex = 0;
            this.tabControlMonitoreo.Size = new System.Drawing.Size(854, 648);
            this.tabControlMonitoreo.TabIndex = 1;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.BtnRemove);
            this.TabPage1.Controls.Add(this.BtnAdd);
            this.TabPage1.Controls.Add(this.cmbSites);
            this.TabPage1.Controls.Add(this.txtAddRoom);
            this.TabPage1.Controls.Add(this.lblAddRoom);
            this.TabPage1.Controls.Add(this.GrdRooms);
            this.TabPage1.Location = new System.Drawing.Point(4, 25);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(846, 619);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Monitoring";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnRemove
            // 
            this.BtnRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnRemove.Location = new System.Drawing.Point(574, 43);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(92, 33);
            this.BtnRemove.TabIndex = 5;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAdd.Location = new System.Drawing.Point(459, 43);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(92, 33);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // cmbSites
            // 
            this.cmbSites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSites.FormattingEnabled = true;
            this.cmbSites.Location = new System.Drawing.Point(266, 48);
            this.cmbSites.Name = "cmbSites";
            this.cmbSites.Size = new System.Drawing.Size(174, 24);
            this.cmbSites.TabIndex = 3;
            // 
            // txtAddRoom
            // 
            this.txtAddRoom.Location = new System.Drawing.Point(20, 48);
            this.txtAddRoom.Name = "txtAddRoom";
            this.txtAddRoom.Size = new System.Drawing.Size(237, 22);
            this.txtAddRoom.TabIndex = 2;
            // 
            // lblAddRoom
            // 
            this.lblAddRoom.AutoSize = true;
            this.lblAddRoom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAddRoom.Location = new System.Drawing.Point(17, 16);
            this.lblAddRoom.Name = "lblAddRoom";
            this.lblAddRoom.Size = new System.Drawing.Size(240, 17);
            this.lblAddRoom.TabIndex = 1;
            this.lblAddRoom.Text = "Add a room or username to monitor :";
            // 
            // GrdRooms
            // 
            this.GrdRooms.AllowUserToAddRows = false;
            this.GrdRooms.AllowUserToDeleteRows = false;
            this.GrdRooms.ColumnHeadersHeight = 30;
            this.GrdRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GrdRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Website,
            this.Status,
            this.Size,
            this.Autorec});
            this.GrdRooms.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GrdRooms.Location = new System.Drawing.Point(20, 95);
            this.GrdRooms.Name = "GrdRooms";
            this.GrdRooms.RowHeadersVisible = false;
            this.GrdRooms.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GrdRooms.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.GrdRooms.RowTemplate.Height = 24;
            this.GrdRooms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GrdRooms.Size = new System.Drawing.Size(796, 507);
            this.GrdRooms.TabIndex = 0;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Username.Width = 125;
            // 
            // Website
            // 
            this.Website.HeaderText = "Website";
            this.Website.MinimumWidth = 6;
            this.Website.Name = "Website";
            this.Website.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Website.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Status.Width = 125;
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.MinimumWidth = 6;
            this.Size.Name = "Size";
            this.Size.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Size.Width = 125;
            // 
            // Autorec
            // 
            this.Autorec.HeaderText = "Autorec";
            this.Autorec.MinimumWidth = 6;
            this.Autorec.Name = "Autorec";
            this.Autorec.ReadOnly = true;
            this.Autorec.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Autorec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Autorec.Width = 125;
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 689);
            this.Controls.Add(this.tabControlMonitoreo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Monitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graba Vacas 3000";
            this.tabControlMonitoreo.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdRooms)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TabControl tabControlMonitoreo;
        private System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ComboBox cmbSites;
        private System.Windows.Forms.TextBox txtAddRoom;
        private System.Windows.Forms.Label lblAddRoom;
        private System.Windows.Forms.DataGridView GrdRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Website;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Autorec;
    }
}

