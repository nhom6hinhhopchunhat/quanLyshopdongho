namespace QLShopDongHo
{
    partial class uc_SanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_SanPham));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_timkiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.btn_tatca = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(195, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC SẢN PHẨM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Activecolor = System.Drawing.Color.Teal;
            this.btn_timkiem.BackColor = System.Drawing.Color.Teal;
            this.btn_timkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_timkiem.BorderRadius = 0;
            this.btn_timkiem.ButtonText = "Tìm";
            this.btn_timkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_timkiem.DisabledColor = System.Drawing.Color.Gray;
            this.btn_timkiem.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_timkiem.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_timkiem.Iconimage")));
            this.btn_timkiem.Iconimage_right = null;
            this.btn_timkiem.Iconimage_right_Selected = null;
            this.btn_timkiem.Iconimage_Selected = null;
            this.btn_timkiem.IconMarginLeft = 0;
            this.btn_timkiem.IconMarginRight = 0;
            this.btn_timkiem.IconRightVisible = true;
            this.btn_timkiem.IconRightZoom = 0D;
            this.btn_timkiem.IconVisible = true;
            this.btn_timkiem.IconZoom = 90D;
            this.btn_timkiem.IsTab = false;
            this.btn_timkiem.Location = new System.Drawing.Point(373, 62);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Normalcolor = System.Drawing.Color.Teal;
            this.btn_timkiem.OnHovercolor = System.Drawing.Color.Teal;
            this.btn_timkiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_timkiem.selected = false;
            this.btn_timkiem.Size = new System.Drawing.Size(95, 39);
            this.btn_timkiem.TabIndex = 2;
            this.btn_timkiem.Text = "Tìm";
            this.btn_timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiem.Textcolor = System.Drawing.Color.White;
            this.btn_timkiem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 188);
            this.dataGridView1.TabIndex = 3;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(119, 62);
            this.txt_timkiem.Multiline = true;
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(234, 39);
            this.txt_timkiem.TabIndex = 4;
            // 
            // btn_tatca
            // 
            this.btn_tatca.Activecolor = System.Drawing.Color.Teal;
            this.btn_tatca.BackColor = System.Drawing.Color.Teal;
            this.btn_tatca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_tatca.BorderRadius = 0;
            this.btn_tatca.ButtonText = "Tất cả";
            this.btn_tatca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tatca.DisabledColor = System.Drawing.Color.Gray;
            this.btn_tatca.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_tatca.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_tatca.Iconimage")));
            this.btn_tatca.Iconimage_right = null;
            this.btn_tatca.Iconimage_right_Selected = null;
            this.btn_tatca.Iconimage_Selected = null;
            this.btn_tatca.IconMarginLeft = 0;
            this.btn_tatca.IconMarginRight = 0;
            this.btn_tatca.IconRightVisible = true;
            this.btn_tatca.IconRightZoom = 0D;
            this.btn_tatca.IconVisible = true;
            this.btn_tatca.IconZoom = 90D;
            this.btn_tatca.IsTab = false;
            this.btn_tatca.Location = new System.Drawing.Point(486, 62);
            this.btn_tatca.Name = "btn_tatca";
            this.btn_tatca.Normalcolor = System.Drawing.Color.Teal;
            this.btn_tatca.OnHovercolor = System.Drawing.Color.Teal;
            this.btn_tatca.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_tatca.selected = false;
            this.btn_tatca.Size = new System.Drawing.Size(95, 39);
            this.btn_tatca.TabIndex = 5;
            this.btn_tatca.Text = "Tất cả";
            this.btn_tatca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tatca.Textcolor = System.Drawing.Color.White;
            this.btn_tatca.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tatca.Click += new System.EventHandler(this.btn_tatca_Click);
            // 
            // uc_SanPham_frmNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.btn_tatca);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.label1);
            this.Name = "uc_SanPham_frmNV";
            this.Size = new System.Drawing.Size(620, 397);
            this.Load += new System.EventHandler(this.uc_SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_timkiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_timkiem;
        private Bunifu.Framework.UI.BunifuFlatButton btn_tatca;
    }
}
