using System;

namespace Db3
{
    partial class OrderForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.addressBox = new System.Windows.Forms.CheckedListBox();
            this.HomeBtn = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderBtn = new System.Windows.Forms.Button();
            this.Order = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.addressBox);
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.OrderBtn);
            this.panel1.Controls.Add(this.Order);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 805);
            this.panel1.TabIndex = 2;
            // 
            // checkBox3
            // 
            this.checkBox3.Font = new System.Drawing.Font("Gilroy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox3.ForeColor = System.Drawing.Color.Lavender;
            this.checkBox3.Location = new System.Drawing.Point(838, 307);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(199, 36);
            this.checkBox3.TabIndex = 22;
            this.checkBox3.Text = "Картой при получении";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Font = new System.Drawing.Font("Gilroy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.ForeColor = System.Drawing.Color.Lavender;
            this.checkBox2.Location = new System.Drawing.Point(838, 265);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(199, 36);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "Наличными";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Gilroy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.ForeColor = System.Drawing.Color.Lavender;
            this.checkBox1.Location = new System.Drawing.Point(651, 368);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(371, 73);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Согласен с условиями использования сервисов PrettyShop и обработки персональных д" +
    "анных";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // addressBox
            // 
            this.addressBox.FormattingEnabled = true;
            this.addressBox.Location = new System.Drawing.Point(838, 185);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(184, 49);
            this.addressBox.TabIndex = 19;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.Image = global::Db3.Properties.Resources._1564508_home_main_room_estate_property_icon;
            this.HomeBtn.InitialImage = null;
            this.HomeBtn.Location = new System.Drawing.Point(1121, 103);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(50, 50);
            this.HomeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeBtn.TabIndex = 17;
            this.HomeBtn.TabStop = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minecraft 1.1", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Lavender;
            this.label4.Location = new System.Drawing.Point(91, 648);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Вернуться в корзину";
            this.label4.Click += new System.EventHandler(this.Cart_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Minecraft 1.1", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Lavender;
            this.label3.Location = new System.Drawing.Point(647, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 47);
            this.label3.TabIndex = 15;
            this.label3.Text = "Способ оплаты";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Minecraft 1.1", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(647, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 46);
            this.label2.TabIndex = 14;
            this.label2.Text = "Адрес доставки";
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listView1.BackColor = System.Drawing.Color.Black;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("SkogenSpelFont", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.Lavender;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(28, 368);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(293, 50);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.Click += new System.EventHandler(this.Cart_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 1;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 0;
            // 
            // OrderBtn
            // 
            this.OrderBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.OrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderBtn.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.OrderBtn.FlatAppearance.BorderSize = 0;
            this.OrderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.OrderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.OrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderBtn.Font = new System.Drawing.Font("Minecraft 1.1", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderBtn.ForeColor = System.Drawing.Color.Lavender;
            this.OrderBtn.Location = new System.Drawing.Point(651, 481);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(371, 70);
            this.OrderBtn.TabIndex = 9;
            this.OrderBtn.Text = "To order";
            this.OrderBtn.UseVisualStyleBackColor = false;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // Order
            // 
            this.Order.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.Order.BackColor = System.Drawing.Color.Black;
            this.Order.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Order.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.Order.Font = new System.Drawing.Font("SkogenSpelFont", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order.ForeColor = System.Drawing.Color.Lavender;
            this.Order.FullRowSelect = true;
            this.Order.HideSelection = false;
            this.Order.Location = new System.Drawing.Point(73, 157);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(518, 394);
            this.Order.TabIndex = 7;
            this.Order.UseCompatibleStateImageBehavior = false;
            this.Order.View = System.Windows.Forms.View.Tile;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 1;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1202, 71);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Minecraft 1.1", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.Lavender;
            this.CloseButton.Location = new System.Drawing.Point(1166, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(22, 20);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "x";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Minecraft 1.1", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1202, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView Order;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox HomeBtn;
        private System.Windows.Forms.CheckedListBox addressBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}