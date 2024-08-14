
namespace QuanLyCafe_FormNew.All_User_Controlls
{
    partial class QuanLyChung
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyChung));
            this.panel5 = new System.Windows.Forms.Panel();
            this.TongTien_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ThanhToan_BT = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listView_Bill = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flPn_Table = new System.Windows.Forms.FlowLayoutPanel();
            this.flPN_SP = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.NumUP_SL = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSync = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUP_SL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.TongTien_txt);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.ThanhToan_BT);
            this.panel5.Location = new System.Drawing.Point(923, 849);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(705, 103);
            this.panel5.TabIndex = 10;
            // 
            // TongTien_txt
            // 
            this.TongTien_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TongTien_txt.Location = new System.Drawing.Point(125, 30);
            this.TongTien_txt.Margin = new System.Windows.Forms.Padding(4);
            this.TongTien_txt.Name = "TongTien_txt";
            this.TongTien_txt.ReadOnly = true;
            this.TongTien_txt.Size = new System.Drawing.Size(383, 35);
            this.TongTien_txt.TabIndex = 2;
            this.TongTien_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(4, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng tiền:";
            // 
            // ThanhToan_BT
            // 
            this.ThanhToan_BT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ThanhToan_BT.Location = new System.Drawing.Point(517, 21);
            this.ThanhToan_BT.Margin = new System.Windows.Forms.Padding(4);
            this.ThanhToan_BT.Name = "ThanhToan_BT";
            this.ThanhToan_BT.Size = new System.Drawing.Size(171, 49);
            this.ThanhToan_BT.TabIndex = 0;
            this.ThanhToan_BT.Text = "Thanh toán";
            this.ThanhToan_BT.UseVisualStyleBackColor = true;
            this.ThanhToan_BT.Click += new System.EventHandler(this.ThanhToan_BT_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.listView_Bill);
            this.panel4.Location = new System.Drawing.Point(921, 578);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(709, 263);
            this.panel4.TabIndex = 9;
            // 
            // listView_Bill
            // 
            this.listView_Bill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_Bill.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listView_Bill.GridLines = true;
            this.listView_Bill.HideSelection = false;
            this.listView_Bill.Location = new System.Drawing.Point(4, 4);
            this.listView_Bill.Margin = new System.Windows.Forms.Padding(4);
            this.listView_Bill.Name = "listView_Bill";
            this.listView_Bill.Size = new System.Drawing.Size(700, 258);
            this.listView_Bill.TabIndex = 0;
            this.listView_Bill.UseCompatibleStateImageBehavior = false;
            this.listView_Bill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sản phẩm";
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số lượng";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Đơn giá";
            this.columnHeader5.Width = 121;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Thành tiền";
            this.columnHeader6.Width = 129;
            // 
            // flPn_Table
            // 
            this.flPn_Table.AutoScroll = true;
            this.flPn_Table.Location = new System.Drawing.Point(925, 128);
            this.flPn_Table.Margin = new System.Windows.Forms.Padding(4);
            this.flPn_Table.Name = "flPn_Table";
            this.flPn_Table.Size = new System.Drawing.Size(703, 442);
            this.flPn_Table.TabIndex = 11;
            // 
            // flPN_SP
            // 
            this.flPN_SP.AutoScroll = true;
            this.flPN_SP.Location = new System.Drawing.Point(67, 128);
            this.flPN_SP.Margin = new System.Windows.Forms.Padding(4);
            this.flPN_SP.Name = "flPN_SP";
            this.flPN_SP.Size = new System.Drawing.Size(816, 725);
            this.flPN_SP.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 60F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(341, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 122);
            this.label1.TabIndex = 13;
            this.label1.Text = "Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 39.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1063, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(384, 82);
            this.label3.TabIndex = 14;
            this.label3.Text = "Choose a Table";
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // NumUP_SL
            // 
            this.NumUP_SL.BackColor = System.Drawing.Color.Transparent;
            this.NumUP_SL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumUP_SL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumUP_SL.Location = new System.Drawing.Point(387, 870);
            this.NumUP_SL.Margin = new System.Windows.Forms.Padding(4);
            this.NumUP_SL.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NumUP_SL.Name = "NumUP_SL";
            this.NumUP_SL.Size = new System.Drawing.Size(121, 46);
            this.NumUP_SL.TabIndex = 16;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(148, 880);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(203, 29);
            this.guna2HtmlLabel1.TabIndex = 17;
            this.guna2HtmlLabel1.Text = "Nhập số lượng món :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnSync
            // 
            this.btnSync.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSync.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSync.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSync.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSync.FillColor = System.Drawing.Color.White;
            this.btnSync.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSync.ForeColor = System.Drawing.Color.White;
            this.btnSync.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSync.Image = ((System.Drawing.Image)(resources.GetObject("btnSync.Image")));
            this.btnSync.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSync.Location = new System.Drawing.Point(89, 35);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(48, 41);
            this.btnSync.TabIndex = 19;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // QuanLyChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.NumUP_SL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flPN_SP);
            this.Controls.Add(this.flPn_Table);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyChung";
            this.Size = new System.Drawing.Size(1683, 970);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumUP_SL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TongTien_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ThanhToan_BT;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView listView_Bill;
        private System.Windows.Forms.FlowLayoutPanel flPn_Table;
        private System.Windows.Forms.FlowLayoutPanel flPN_SP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumUP_SL;
        private Guna.UI2.WinForms.Guna2Button btnSync;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
