﻿namespace NP_Low_Edition.Menus
{
    partial class ArpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArpForm));
            this.textGetInfo = new System.Windows.Forms.TextBox();
            this.updateBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textGetInfo
            // 
            this.textGetInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textGetInfo.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGetInfo.Location = new System.Drawing.Point(0, 0);
            this.textGetInfo.Multiline = true;
            this.textGetInfo.Name = "textGetInfo";
            this.textGetInfo.ReadOnly = true;
            this.textGetInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textGetInfo.Size = new System.Drawing.Size(488, 206);
            this.textGetInfo.TabIndex = 0;
            // 
            // updateBt
            // 
            this.updateBt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.updateBt.Image = ((System.Drawing.Image)(resources.GetObject("updateBt.Image")));
            this.updateBt.Location = new System.Drawing.Point(0, 206);
            this.updateBt.Name = "updateBt";
            this.updateBt.Size = new System.Drawing.Size(488, 34);
            this.updateBt.TabIndex = 1;
            this.updateBt.UseVisualStyleBackColor = true;
            this.updateBt.Click += new System.EventHandler(this.reloadClick);
            // 
            // ArpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 240);
            this.Controls.Add(this.textGetInfo);
            this.Controls.Add(this.updateBt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arp Protocol";
            this.Load += new System.EventHandler(this.onLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textGetInfo;
        private System.Windows.Forms.Button updateBt;
    }
}