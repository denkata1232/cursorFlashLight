﻿namespace cursorFlashLight
{
    partial class FormPlayState
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
            lblHiddenMessage = new Label();
            SuspendLayout();
            // 
            // lblHiddenMessage
            // 
            lblHiddenMessage.AutoSize = true;
            lblHiddenMessage.BackColor = Color.Transparent;
            lblHiddenMessage.Font = new Font("Imprint MT Shadow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHiddenMessage.Location = new Point(104, 115);
            lblHiddenMessage.Name = "lblHiddenMessage";
            lblHiddenMessage.Size = new Size(48, 27);
            lblHiddenMessage.TabIndex = 0;
            lblHiddenMessage.Text = "text";
            // 
            // FormPlayState
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHiddenMessage);
            MinimizeBox = false;
            Name = "FormPlayState";
            ShowIcon = false;
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHiddenMessage;
    }
}