namespace Mailgonderme
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
            textBox1Epost = new TextBox();
            textBoxMovzu = new TextBox();
            textBoxMesaj = new TextBox();
            labelEpost = new Label();
            label2Movzu = new Label();
            label3Message = new Label();
            buttonSend = new Button();
            SuspendLayout();
            // 
            // textBox1Epost
            // 
            textBox1Epost.Location = new Point(139, 67);
            textBox1Epost.Name = "textBox1Epost";
            textBox1Epost.Size = new Size(230, 27);
            textBox1Epost.TabIndex = 1;
            // 
            // textBoxMovzu
            // 
            textBoxMovzu.Location = new Point(139, 113);
            textBoxMovzu.Name = "textBoxMovzu";
            textBoxMovzu.Size = new Size(230, 27);
            textBoxMovzu.TabIndex = 2;
            // 
            // textBoxMesaj
            // 
            textBoxMesaj.Location = new Point(139, 174);
            textBoxMesaj.Multiline = true;
            textBoxMesaj.Name = "textBoxMesaj";
            textBoxMesaj.Size = new Size(230, 236);
            textBoxMesaj.TabIndex = 3;
            // 
            // labelEpost
            // 
            labelEpost.AutoSize = true;
            labelEpost.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelEpost.Location = new Point(46, 63);
            labelEpost.Name = "labelEpost";
            labelEpost.Size = new Size(73, 28);
            labelEpost.TabIndex = 1;
            labelEpost.Text = "E-Post";
            // 
            // label2Movzu
            // 
            label2Movzu.AutoSize = true;
            label2Movzu.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2Movzu.Location = new Point(45, 109);
            label2Movzu.Name = "label2Movzu";
            label2Movzu.Size = new Size(74, 28);
            label2Movzu.TabIndex = 1;
            label2Movzu.Text = "Movzu";
            // 
            // label3Message
            // 
            label3Message.AutoSize = true;
            label3Message.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3Message.Location = new Point(200, 143);
            label3Message.Name = "label3Message";
            label3Message.Size = new Size(91, 28);
            label3Message.TabIndex = 1;
            label3Message.Text = "Message";
            // 
            // buttonSend
            // 
            buttonSend.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonSend.Location = new Point(411, 67);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(163, 61);
            buttonSend.TabIndex = 4;
            buttonSend.Text = "Gonder";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSend);
            Controls.Add(label3Message);
            Controls.Add(label2Movzu);
            Controls.Add(labelEpost);
            Controls.Add(textBoxMesaj);
            Controls.Add(textBoxMovzu);
            Controls.Add(textBox1Epost);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1Epost;
        private TextBox textBoxMovzu;
        private TextBox textBoxMesaj;
        private Label labelEpost;
        private Label label2Movzu;
        private Label label3Message;
        private Button buttonSend;
    }
}