namespace E_Space_Solutions
{
    partial class Jet
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
            this.txtweight = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtjetcode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pilotdataview = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btndelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnupdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnlogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtmodelyear = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtpseats = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtpowersource = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtenginetype = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pilotdataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtenginetype)).BeginInit();
            this.SuspendLayout();
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(32, 200);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(328, 33);
            this.txtweight.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.txtweight.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtweight.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtweight.StateCommon.Border.Rounding = 15;
            this.txtweight.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtweight.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtweight.TabIndex = 56;
            this.txtweight.Text = "Weight";
            // 
            // txtjetcode
            // 
            this.txtjetcode.Location = new System.Drawing.Point(409, 83);
            this.txtjetcode.Name = "txtjetcode";
            this.txtjetcode.Size = new System.Drawing.Size(161, 33);
            this.txtjetcode.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.txtjetcode.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtjetcode.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtjetcode.StateCommon.Border.Rounding = 15;
            this.txtjetcode.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtjetcode.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjetcode.TabIndex = 55;
            this.txtjetcode.Text = "Jet Code";
            // 
            // pilotdataview
            // 
            this.pilotdataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pilotdataview.Location = new System.Drawing.Point(409, 122);
            this.pilotdataview.Name = "pilotdataview";
            this.pilotdataview.Size = new System.Drawing.Size(519, 336);
            this.pilotdataview.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.pilotdataview.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.pilotdataview.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.pilotdataview.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pilotdataview.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilotdataview.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.pilotdataview.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.pilotdataview.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pilotdataview.StateCommon.HeaderColumn.Border.Rounding = 2;
            this.pilotdataview.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.pilotdataview.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.pilotdataview.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.pilotdataview.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pilotdataview.StateCommon.HeaderRow.Border.Rounding = 2;
            this.pilotdataview.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.pilotdataview.TabIndex = 54;
            this.pilotdataview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pilotdataview_CellClick_1);
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
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
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
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
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
            // 
            // txtmodelyear
            // 
            this.txtmodelyear.Location = new System.Drawing.Point(32, 161);
            this.txtmodelyear.Name = "txtmodelyear";
            this.txtmodelyear.Size = new System.Drawing.Size(328, 33);
            this.txtmodelyear.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.txtmodelyear.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmodelyear.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtmodelyear.StateCommon.Border.Rounding = 15;
            this.txtmodelyear.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtmodelyear.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodelyear.TabIndex = 49;
            this.txtmodelyear.Text = "Model Year";
            // 
            // txtpseats
            // 
            this.txtpseats.Location = new System.Drawing.Point(32, 83);
            this.txtpseats.Name = "txtpseats";
            this.txtpseats.Size = new System.Drawing.Size(328, 33);
            this.txtpseats.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.txtpseats.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpseats.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtpseats.StateCommon.Border.Rounding = 15;
            this.txtpseats.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtpseats.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpseats.TabIndex = 47;
            this.txtpseats.Text = "Passenger Seats";
            // 
            // txtpowersource
            // 
            this.txtpowersource.Location = new System.Drawing.Point(32, 239);
            this.txtpowersource.Name = "txtpowersource";
            this.txtpowersource.Size = new System.Drawing.Size(328, 33);
            this.txtpowersource.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.txtpowersource.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpowersource.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtpowersource.StateCommon.Border.Rounding = 15;
            this.txtpowersource.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtpowersource.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpowersource.TabIndex = 58;
            this.txtpowersource.Text = "Power Source";
            // 
            // txtenginetype
            // 
            this.txtenginetype.DropDownWidth = 151;
            this.txtenginetype.Items.AddRange(new object[] {
            "Nuclear",
            "Nuclear-Hydro Splitter",
            "Hydro-Nuc"});
            this.txtenginetype.Location = new System.Drawing.Point(32, 122);
            this.txtenginetype.Name = "txtenginetype";
            this.txtenginetype.Size = new System.Drawing.Size(328, 29);
            this.txtenginetype.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.txtenginetype.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtenginetype.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtenginetype.StateCommon.ComboBox.Border.Rounding = 15;
            this.txtenginetype.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.White;
            this.txtenginetype.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtenginetype.TabIndex = 59;
            this.txtenginetype.Text = "Engine Type";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(772, 24);
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
            this.kryptonButton1.TabIndex = 60;
            this.kryptonButton1.Values.Text = "Dashboard";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // Jet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E_Space_Solutions.Properties.Resources.Jet;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.txtenginetype);
            this.Controls.Add(this.txtpowersource);
            this.Controls.Add(this.txtweight);
            this.Controls.Add(this.txtjetcode);
            this.Controls.Add(this.pilotdataview);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtmodelyear);
            this.Controls.Add(this.txtpseats);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Jet";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 10;
            this.Text = "Jet";
            this.Load += new System.EventHandler(this.Jet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pilotdataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtenginetype)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtweight;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtjetcode;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView pilotdataview;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btndelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnupdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnlogin;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtmodelyear;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtpseats;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtpowersource;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox txtenginetype;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}