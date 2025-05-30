namespace cursorFlashLight
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStart = new Button();
            txbMessage = new TextBox();
            lblMaessageShowText = new Label();
            lblRadius = new Label();
            txbRadius = new TextBox();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnStart.Location = new Point(12, 126);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(434, 43);
            btnStart.TabIndex = 0;
            btnStart.Text = "Стартиране";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // txbMessage
            // 
            txbMessage.Location = new Point(227, 12);
            txbMessage.Multiline = true;
            txbMessage.Name = "txbMessage";
            txbMessage.Size = new Size(219, 52);
            txbMessage.TabIndex = 1;
            // 
            // lblMaessageShowText
            // 
            lblMaessageShowText.AutoSize = true;
            lblMaessageShowText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMaessageShowText.Location = new Point(12, 9);
            lblMaessageShowText.Name = "lblMaessageShowText";
            lblMaessageShowText.Size = new Size(209, 28);
            lblMaessageShowText.TabIndex = 2;
            lblMaessageShowText.Text = "Въведи съобщение:";
            // 
            // lblRadius
            // 
            lblRadius.AutoSize = true;
            lblRadius.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRadius.Location = new Point(12, 67);
            lblRadius.Name = "lblRadius";
            lblRadius.Size = new Size(285, 56);
            lblRadius.TabIndex = 3;
            lblRadius.Text = "Въведи Радиус на фенерче:\r\n(optional)\r\n";
            // 
            // txbRadius
            // 
            txbRadius.Location = new Point(303, 71);
            txbRadius.Name = "txbRadius";
            txbRadius.Size = new Size(143, 27);
            txbRadius.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 175);
            Controls.Add(txbRadius);
            Controls.Add(lblRadius);
            Controls.Add(lblMaessageShowText);
            Controls.Add(txbMessage);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Lumifly";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private TextBox txbMessage;
        private Label lblMaessageShowText;
        private Label lblRadius;
        private TextBox txbRadius;
    }
}
