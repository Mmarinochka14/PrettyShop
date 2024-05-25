using System;

namespace Db3
{
    partial class LikedForm
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
            this.Liked = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LkBtn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LkBtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Liked);
            this.panel1.Controls.Add(this.LkBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 804);
            this.panel1.TabIndex = 2;
            // 
            // Liked
            // 
            this.Liked.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.Liked.BackColor = System.Drawing.Color.Black;
            this.Liked.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Liked.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1});
            this.Liked.Font = new System.Drawing.Font("SkogenSpelFont", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Liked.ForeColor = System.Drawing.Color.Lavender;
            this.Liked.FullRowSelect = true;
            this.Liked.HideSelection = false;
            this.Liked.Location = new System.Drawing.Point(79, 159);
            this.Liked.Name = "Liked";
            this.Liked.Size = new System.Drawing.Size(653, 257);
            this.Liked.TabIndex = 3;
            this.Liked.UseCompatibleStateImageBehavior = false;
            this.Liked.View = System.Windows.Forms.View.Tile;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            // 
            // LkBtn
            // 
            this.LkBtn.Image = global::Db3.Properties.Resources._1564534_customer_man_user_account_profile_icon;
            this.LkBtn.InitialImage = null;
            this.LkBtn.Location = new System.Drawing.Point(1127, 90);
            this.LkBtn.Name = "LkBtn";
            this.LkBtn.Size = new System.Drawing.Size(50, 50);
            this.LkBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LkBtn.TabIndex = 2;
            this.LkBtn.TabStop = false;
            this.LkBtn.Click += new System.EventHandler(this.LkBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1203, 71);
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
            this.label1.Size = new System.Drawing.Size(1203, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liked";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LikedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LikedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LkBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox LkBtn;
        private System.Windows.Forms.ListView Liked;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}