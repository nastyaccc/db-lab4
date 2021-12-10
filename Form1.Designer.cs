namespace iut_dbm_lw4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.hotelsDataGridView = new System.Windows.Forms.DataGridView();
            this.HotelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelsDataGridViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelsLabel = new System.Windows.Forms.Label();
            this.carriersLable = new System.Windows.Forms.Label();
            this.routesDataGridView = new System.Windows.Forms.DataGridView();
            this.routesLabel = new System.Windows.Forms.Label();
            this.carriersDataGridViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.routesDataGridViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.carriersDataGridView = new System.Windows.Forms.DataGridView();
            this.CarrierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarrierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RouteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeFio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsDataGridView)).BeginInit();
            this.hotelsDataGridViewContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routesDataGridView)).BeginInit();
            this.carriersDataGridViewContextMenuStrip.SuspendLayout();
            this.routesDataGridViewContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carriersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hotelsDataGridView
            // 
            this.hotelsDataGridView.AllowUserToDeleteRows = false;
            this.hotelsDataGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.hotelsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotelsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HotelId,
            this.HotelName});
            this.hotelsDataGridView.Location = new System.Drawing.Point(16, 31);
            this.hotelsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.hotelsDataGridView.Name = "hotelsDataGridView";
            this.hotelsDataGridView.RowHeadersWidth = 51;
            this.hotelsDataGridView.Size = new System.Drawing.Size(257, 185);
            this.hotelsDataGridView.TabIndex = 0;
            this.hotelsDataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.hotelsDataGridView_CellMouseUp);
            this.hotelsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.hotelsDataGridView_CellValueChanged);
            this.hotelsDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.hotelsDataGridView_UserDeletingRow);
            // 
            // HotelId
            // 
            this.HotelId.Frozen = true;
            this.HotelId.HeaderText = "Id";
            this.HotelId.MinimumWidth = 6;
            this.HotelId.Name = "HotelId";
            this.HotelId.ReadOnly = true;
            this.HotelId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HotelId.Width = 50;
            // 
            // HotelName
            // 
            this.HotelName.Frozen = true;
            this.HotelName.HeaderText = "Название";
            this.HotelName.MinimumWidth = 6;
            this.HotelName.Name = "HotelName";
            this.HotelName.Width = 125;
            // 
            // hotelsDataGridViewContextMenuStrip
            // 
            this.hotelsDataGridViewContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.hotelsDataGridViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.hotelsDataGridViewContextMenuStrip.Name = "hotelsDataGridViewContextMenuStrip";
            this.hotelsDataGridViewContextMenuStrip.Size = new System.Drawing.Size(123, 28);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // hotelsLabel
            // 
            this.hotelsLabel.AutoSize = true;
            this.hotelsLabel.Location = new System.Drawing.Point(12, 11);
            this.hotelsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hotelsLabel.Name = "hotelsLabel";
            this.hotelsLabel.Size = new System.Drawing.Size(50, 17);
            this.hotelsLabel.TabIndex = 1;
            this.hotelsLabel.Text = "Отели";
            // 
            // carriersLable
            // 
            this.carriersLable.AutoSize = true;
            this.carriersLable.Location = new System.Drawing.Point(277, 11);
            this.carriersLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.carriersLable.Name = "carriersLable";
            this.carriersLable.Size = new System.Drawing.Size(95, 17);
            this.carriersLable.TabIndex = 3;
            this.carriersLable.Text = "Перевозчики";
            // 
            // routesDataGridView
            // 
            this.routesDataGridView.AllowUserToDeleteRows = false;
            this.routesDataGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.routesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.routesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RouteId,
            this.routeFio});
            this.routesDataGridView.Location = new System.Drawing.Point(548, 32);
            this.routesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.routesDataGridView.Name = "routesDataGridView";
            this.routesDataGridView.ReadOnly = true;
            this.routesDataGridView.RowHeadersWidth = 51;
            this.routesDataGridView.Size = new System.Drawing.Size(257, 185);
            this.routesDataGridView.TabIndex = 4;
            this.routesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.routesDataGridView_CellContentClick);
            this.routesDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.routesDataGridView_CellMouseDoubleClick);
            this.routesDataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.routesDataGridView_CellMouseUp);
            // 
            // routesLabel
            // 
            this.routesLabel.AutoSize = true;
            this.routesLabel.Location = new System.Drawing.Point(544, 11);
            this.routesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.routesLabel.Name = "routesLabel";
            this.routesLabel.Size = new System.Drawing.Size(78, 17);
            this.routesLabel.TabIndex = 5;
            this.routesLabel.Text = "Маршруты";
            this.routesLabel.Click += new System.EventHandler(this.routesLabel_Click);
            // 
            // carriersDataGridViewContextMenuStrip
            // 
            this.carriersDataGridViewContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.carriersDataGridViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.carriersDataGridViewContextMenuStrip.Name = "carriersDataGridViewContextMenuStrip";
            this.carriersDataGridViewContextMenuStrip.Size = new System.Drawing.Size(123, 28);
            this.carriersDataGridViewContextMenuStrip.Click += new System.EventHandler(this.carriersDataGridViewContextMenuStrip_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(122, 24);
            this.toolStripMenuItem1.Text = "Delete";
            // 
            // routesDataGridViewContextMenuStrip
            // 
            this.routesDataGridViewContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.routesDataGridViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.routesDataGridViewContextMenuStrip.Name = "hotelsDataGridViewContextMenuStrip";
            this.routesDataGridViewContextMenuStrip.Size = new System.Drawing.Size(123, 28);
            this.routesDataGridViewContextMenuStrip.Click += new System.EventHandler(this.routesDataGridViewContextMenuStrip_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(122, 24);
            this.toolStripMenuItem2.Text = "Delete";
            // 
            // carriersDataGridView
            // 
            this.carriersDataGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.carriersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carriersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarrierId,
            this.CarrierName});
            this.carriersDataGridView.Location = new System.Drawing.Point(283, 32);
            this.carriersDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.carriersDataGridView.Name = "carriersDataGridView";
            this.carriersDataGridView.RowHeadersWidth = 51;
            this.carriersDataGridView.Size = new System.Drawing.Size(257, 185);
            this.carriersDataGridView.TabIndex = 6;
            this.carriersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carriersDataGridView_CellContentClick);
            this.carriersDataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.carriersDataGridView_CellMouseUp);
            this.carriersDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.carriersDataGridView_CellValueChanged);
            // 
            // CarrierId
            // 
            this.CarrierId.HeaderText = "Id";
            this.CarrierId.MinimumWidth = 6;
            this.CarrierId.Name = "CarrierId";
            this.CarrierId.ReadOnly = true;
            this.CarrierId.Width = 50;
            // 
            // CarrierName
            // 
            this.CarrierName.HeaderText = "Название";
            this.CarrierName.MinimumWidth = 6;
            this.CarrierName.Name = "CarrierName";
            this.CarrierName.Width = 125;
            // 
            // RouteId
            // 
            this.RouteId.Frozen = true;
            this.RouteId.HeaderText = "Id";
            this.RouteId.MinimumWidth = 6;
            this.RouteId.Name = "RouteId";
            this.RouteId.ReadOnly = true;
            this.RouteId.Width = 50;
            // 
            // routeFio
            // 
            this.routeFio.Frozen = true;
            this.routeFio.HeaderText = "Маршрут";
            this.routeFio.MinimumWidth = 6;
            this.routeFio.Name = "routeFio";
            this.routeFio.ReadOnly = true;
            this.routeFio.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(821, 233);
            this.Controls.Add(this.carriersDataGridView);
            this.Controls.Add(this.routesLabel);
            this.Controls.Add(this.routesDataGridView);
            this.Controls.Add(this.carriersLable);
            this.Controls.Add(this.hotelsLabel);
            this.Controls.Add(this.hotelsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelsDataGridView)).EndInit();
            this.hotelsDataGridViewContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.routesDataGridView)).EndInit();
            this.carriersDataGridViewContextMenuStrip.ResumeLayout(false);
            this.routesDataGridViewContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carriersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView hotelsDataGridView;
        private System.Windows.Forms.ContextMenuStrip hotelsDataGridViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label hotelsLabel;
        private System.Windows.Forms.Label carriersLable;
        private System.Windows.Forms.DataGridView routesDataGridView;
        private System.Windows.Forms.Label routesLabel;
        private System.Windows.Forms.ContextMenuStrip carriersDataGridViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip routesDataGridViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.DataGridView carriersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarrierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarrierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RouteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeFio;
    }
}

