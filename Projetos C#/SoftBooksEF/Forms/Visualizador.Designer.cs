﻿namespace Database_Books.Forms
{
    partial class VisualizadorPDF
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
            this.panelVisualizaPDF = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelVisualizaPDF
            // 
            this.panelVisualizaPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVisualizaPDF.Location = new System.Drawing.Point(12, 12);
            this.panelVisualizaPDF.Name = "panelVisualizaPDF";
            this.panelVisualizaPDF.Size = new System.Drawing.Size(776, 426);
            this.panelVisualizaPDF.TabIndex = 0;
            // 
            // VisualizadorPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelVisualizaPDF);
            this.Name = "VisualizadorPDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisualizadorPDF";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VisualizadorPDF_FormClosed);
            this.Load += new System.EventHandler(this.VisualizadorPDF_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVisualizaPDF;
    }
}