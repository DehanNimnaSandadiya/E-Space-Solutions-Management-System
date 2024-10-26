namespace E_Space_Solutions
{
    partial class HouseForm
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
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.txtlnumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tripdataview = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btndelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnupdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnlogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtca = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtsf = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtnor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.tripdataview)).BeginInit();
            this.SuspendLayout();
            // 
            // txtlnumber
            // 
            this.txtlnumber.Location = new System.Drawing.Point(409, 83);
            this.txtlnumber.Name = "txtlnumber";
            this.txtlnumber.Size = new System.Drawing.Size(161, 33);
            this.txtlnumber.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.txtlnumber.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtlnumber.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtlnumber.StateCommon.Border.Rounding = 15;
            this.txtlnumber.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtlnumber.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlnumber.TabIndex = 55;
            this.txtlnumber.Text = "Lot Number";
            // 
            // tripdataview
            // 
            this.tripdataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tripdataview.Location = new System.Drawing.Point(409, 122);
            this.tripdataview.Name = "tripdataview";
            this.tripdataview.Size = new System.Drawing.Size(519, 336);
            this.tripdataview.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.tripdataview.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.tripdataview.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.tripdataview.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tripdataview.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tripdataview.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.tripdataview.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.tripdataview.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tripdataview.StateCommon.HeaderColumn.Border.Rounding = 2;
            this.tripdataview.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.tripdataview.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.tripdataview.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.tripdataview.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tripdataview.StateCommon.HeaderRow.Border.Rounding = 2;
            this.tripdataview.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.tripdataview.TabIndex = 54;
            this.tripdataview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tripdataview_CellClick);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(270, 428);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(90, 29);
            this.btndelete.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btndelete.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btndelete.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btndelete.StateCommon.Border.Rounding = 15;
            this.btndelete.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btndelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btndelete.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btndelete.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btndelete.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btndelete.TabIndex = 53;
            this.btndelete.Values.Text = "DELETE";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(153, 428);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(90, 29);
            this.btnupdate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnupdate.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnupdate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnupdate.StateCommon.Border.Rounding = 15;
            this.btnupdate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnupdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnupdate.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnupdate.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnupdate.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnupdate.TabIndex = 52;
            this.btnupdate.Values.Text = "UPDATE";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click_1);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(32, 428);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(90, 29);
            this.btnlogin.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnlogin.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnlogin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnlogin.StateCommon.Border.Rounding = 15;
            this.btnlogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnlogin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnlogin.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnlogin.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnlogin.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnlogin.TabIndex = 51;
            this.btnlogin.Values.Text = "INSERT";
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtca
            // 
            this.txtca.Location = new System.Drawing.Point(32, 161);
            this.txtca.Name = "txtca";
            this.txtca.Size = new System.Drawing.Size(328, 33);
            this.txtca.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.txtca.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtca.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtca.StateCommon.Border.Rounding = 15;
            this.txtca.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtca.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtca.TabIndex = 49;
            this.txtca.Text = "Colonist Assigned";
            // 
            // txtsf
            // 
            this.txtsf.Location = new System.Drawing.Point(32, 122);
            this.txtsf.Name = "txtsf";
            this.txtsf.Size = new System.Drawing.Size(328, 33);
            this.txtsf.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.txtsf.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsf.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtsf.StateCommon.Border.Rounding = 15;
            this.txtsf.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtsf.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsf.TabIndex = 48;
            this.txtsf.Text = "Square Feet";
            // 
            // txtnor
            // 
            this.txtnor.Location = new System.Drawing.Point(32, 83);
            this.txtnor.Name = "txtnor";
            this.txtnor.Size = new System.Drawing.Size(328, 33);
            this.txtnor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.txtnor.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtnor.StateCommon.Border.Rounding = 15;
            this.txtnor.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtnor.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnor.TabIndex = 47;
            this.txtnor.Text = "Number of Rooms";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(775, 27);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Palette = this.kryptonPalette1;
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonButton1.Size = new System.Drawing.Size(90, 29);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 15;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.kryptonButton1.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.kryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.kryptonButton1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.kryptonButton1.TabIndex = 56;
            this.kryptonButton1.Values.Text = "Dashboard";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // HouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E_Space_Solutions.Properties.Resources.House;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.txtlnumber);
            this.Controls.Add(this.tripdataview);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtca);
            this.Controls.Add(this.txtsf);
            this.Controls.Add(this.txtnor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HouseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "House";
            this.Load += new System.EventHandler(this.HouseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tripdataview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtlnumber;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView tripdataview;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btndelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnupdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnlogin;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtca;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtsf;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtnor;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}