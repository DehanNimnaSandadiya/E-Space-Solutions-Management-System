namespace E_Space_Solutions
{
    partial class Pilot
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
            this.txtpid = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pilotdataview = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btndelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnupdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnlogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.jetcode = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtpqualification = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtspacehours = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtpname = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtpdesignation = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pilotdataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jetcode)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(409, 83);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(161, 33);
            this.txtpid.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.txtpid.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpid.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtpid.StateCommon.Border.Rounding = 15;
            this.txtpid.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtpid.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpid.TabIndex = 45;
            this.txtpid.Text = "Pilot ID";
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
            this.pilotdataview.TabIndex = 44;
            this.pilotdataview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pilotdataview_CellClick);
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
            this.btndelete.TabIndex = 43;
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
            this.btnupdate.TabIndex = 42;
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
            this.btnlogin.TabIndex = 41;
            this.btnlogin.Values.Text = "INSERT";
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // jetcode
            // 
            this.jetcode.DropDownWidth = 151;
            this.jetcode.Location = new System.Drawing.Point(32, 239);
            this.jetcode.Name = "jetcode";
            this.jetcode.Size = new System.Drawing.Size(161, 29);
            this.jetcode.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.jetcode.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.jetcode.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.jetcode.StateCommon.ComboBox.Border.Rounding = 15;
            this.jetcode.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.White;
            this.jetcode.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jetcode.TabIndex = 40;
            this.jetcode.SelectedIndexChanged += new System.EventHandler(this.jetcode_SelectedIndexChanged);
            // 
            // txtpqualification
            // 
            this.txtpqualification.Location = new System.Drawing.Point(32, 161);
            this.txtpqualification.Name = "txtpqualification";
            this.txtpqualification.Size = new System.Drawing.Size(328, 33);
            this.txtpqualification.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.txtpqualification.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpqualification.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtpqualification.StateCommon.Border.Rounding = 15;
            this.txtpqualification.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtpqualification.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpqualification.TabIndex = 39;
            this.txtpqualification.Text = "Qualification";
            // 
            // txtspacehours
            // 
            this.txtspacehours.Location = new System.Drawing.Point(32, 122);
            this.txtspacehours.Name = "txtspacehours";
            this.txtspacehours.Size = new System.Drawing.Size(328, 33);
            this.txtspacehours.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.txtspacehours.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtspacehours.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtspacehours.StateCommon.Border.Rounding = 15;
            this.txtspacehours.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtspacehours.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtspacehours.TabIndex = 37;
            this.txtspacehours.Text = "Space Hours";
            // 
            // txtpname
            // 
            this.txtpname.Location = new System.Drawing.Point(32, 83);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(328, 33);
            this.txtpname.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.txtpname.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpname.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtpname.StateCommon.Border.Rounding = 15;
            this.txtpname.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtpname.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpname.TabIndex = 35;
            this.txtpname.Text = "Name";
            // 
            // txtpdesignation
            // 
            this.txtpdesignation.Location = new System.Drawing.Point(32, 200);
            this.txtpdesignation.Name = "txtpdesignation";
            this.txtpdesignation.Size = new System.Drawing.Size(328, 33);
            this.txtpdesignation.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.txtpdesignation.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpdesignation.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtpdesignation.StateCommon.Border.Rounding = 15;
            this.txtpdesignation.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtpdesignation.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpdesignation.TabIndex = 46;
            this.txtpdesignation.Text = "Designation";
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
            this.kryptonButton1.TabIndex = 47;
            this.kryptonButton1.Values.Text = "Dashboard";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // Pilot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E_Space_Solutions.Properties.Resources.Pilot;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.txtpdesignation);
            this.Controls.Add(this.txtpid);
            this.Controls.Add(this.pilotdataview);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.jetcode);
            this.Controls.Add(this.txtpqualification);
            this.Controls.Add(this.txtspacehours);
            this.Controls.Add(this.txtpname);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pilot";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 10;
            this.Text = "Pilot";
            this.Load += new System.EventHandler(this.Pilot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pilotdataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jetcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtpid;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView pilotdataview;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btndelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnupdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnlogin;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox jetcode;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtpqualification;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtspacehours;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtpname;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtpdesignation;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}