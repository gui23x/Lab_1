
namespace Lab_01
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnExibir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Stencil", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(69, 32);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(644, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Visualizar dados na caixa de texto";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(179, 123);
            this.lblNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(57, 19);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblCurso.Location = new System.Drawing.Point(179, 170);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(64, 19);
            this.lblCurso.TabIndex = 2;
            this.lblCurso.Text = "Curso:";
            // 
            // tbxNome
            // 
            this.tbxNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxNome.Location = new System.Drawing.Point(250, 120);
            this.tbxNome.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(384, 29);
            this.tbxNome.TabIndex = 4;
            // 
            // cbxCurso
            // 
            this.cbxCurso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Items.AddRange(new object[] {
            "PHP",
            "Java",
            "JavaScript",
            "Python",
            "Object-C",
            "C#",
            "C++",
            "C"});
            this.cbxCurso.Location = new System.Drawing.Point(250, 167);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(124, 29);
            this.cbxCurso.TabIndex = 5;
            // 
            // lblMensagem
            // 
            this.lblMensagem.BackColor = System.Drawing.Color.SkyBlue;
            this.lblMensagem.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMensagem.Location = new System.Drawing.Point(182, 219);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(452, 111);
            this.lblMensagem.TabIndex = 6;
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.SkyBlue;
            this.btnExibir.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnExibir.Location = new System.Drawing.Point(358, 355);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(113, 51);
            this.btnExibir.TabIndex = 7;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(782, 436);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.cbxCurso);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1° Laboratório";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnExibir;
    }
}

