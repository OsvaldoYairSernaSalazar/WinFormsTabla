namespace WinFormsTabla
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
            panelprincipal = new Panel();
            label1 = new Label();
            richTextBoxresultados = new RichTextBox();
            buttonver = new Button();
            textboxnum = new TextBox();
            labelnumero = new Label();
            labeltitule = new Label();
            labelnombre = new Label();
            panelprincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelprincipal
            // 
            panelprincipal.BackColor = SystemColors.ActiveCaption;
            panelprincipal.Controls.Add(labelnombre);
            panelprincipal.Controls.Add(label1);
            panelprincipal.Controls.Add(richTextBoxresultados);
            panelprincipal.Controls.Add(buttonver);
            panelprincipal.Controls.Add(textboxnum);
            panelprincipal.Controls.Add(labelnumero);
            panelprincipal.Controls.Add(labeltitule);
            panelprincipal.Location = new Point(2, 3);
            panelprincipal.Name = "panelprincipal";
            panelprincipal.Size = new Size(799, 369);
            panelprincipal.TabIndex = 0;
            panelprincipal.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // richTextBoxresultados
            // 
            richTextBoxresultados.Location = new Point(382, 56);
            richTextBoxresultados.Name = "richTextBoxresultados";
            richTextBoxresultados.Size = new Size(129, 222);
            richTextBoxresultados.TabIndex = 4;
            richTextBoxresultados.Text = "";
            // 
            // buttonver
            // 
            buttonver.Location = new Point(136, 194);
            buttonver.Name = "buttonver";
            buttonver.Size = new Size(75, 23);
            buttonver.TabIndex = 3;
            buttonver.Text = "Ver tabla";
            buttonver.UseVisualStyleBackColor = true;
            buttonver.Click += buttonver_Click;
            // 
            // textboxnum
            // 
            textboxnum.Location = new Point(110, 141);
            textboxnum.Name = "textboxnum";
            textboxnum.Size = new Size(100, 23);
            textboxnum.TabIndex = 2;
            // 
            // labelnumero
            // 
            labelnumero.AutoSize = true;
            labelnumero.Font = new Font("Viner Hand ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelnumero.Location = new Point(94, 74);
            labelnumero.Name = "labelnumero";
            labelnumero.Size = new Size(160, 26);
            labelnumero.TabIndex = 1;
            labelnumero.Text = "Cual tabla quieres?";
            labelnumero.UseMnemonic = false;
            labelnumero.Click += label1_Click;
            // 
            // labeltitule
            // 
            labeltitule.AutoSize = true;
            labeltitule.Location = new Point(116, 35);
            labeltitule.Name = "labeltitule";
            labeltitule.Size = new Size(110, 15);
            labeltitule.TabIndex = 0;
            labeltitule.Text = "Tabla de Multiplicar";
            // 
            // labelnombre
            // 
            labelnombre.AutoSize = true;
            labelnombre.Location = new Point(328, 17);
            labelnombre.Name = "labelnombre";
            labelnombre.Size = new Size(157, 15);
            labelnombre.TabIndex = 5;
            labelnombre.Text = "Osvaldo Yair Serna SALAZAR";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelprincipal);
            Name = "Form1";
            Text = "Form1";
            panelprincipal.ResumeLayout(false);
            panelprincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelprincipal;
        private Label labeltitule;
        private Label labelnumero;
        private TextBox textboxnum;
        private Button buttonver;
        private RichTextBox richTextBoxresultados;
        private Label label1;
        private Label labelnombre;
    }
}
