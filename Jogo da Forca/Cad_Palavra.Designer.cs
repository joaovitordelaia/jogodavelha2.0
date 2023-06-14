namespace Jogo_da_Forca
{
    partial class Cad_Palavra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cad_Palavra));
            this.cb_Categoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Cad_Palavra = new System.Windows.Forms.Button();
            this.txt_Cad_Palavra = new System.Windows.Forms.TextBox();
            this.txt_Cad_Dica = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_Categoria
            // 
            this.cb_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Categoria.FormattingEnabled = true;
            this.cb_Categoria.Items.AddRange(new object[] {
            "Animais",
            "Cidades",
            "Times",
            "Objetos",
            "Frutas",
            "Carros"});
            this.cb_Categoria.Location = new System.Drawing.Point(17, 46);
            this.cb_Categoria.Name = "cb_Categoria";
            this.cb_Categoria.Size = new System.Drawing.Size(219, 28);
            this.cb_Categoria.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Palavra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dica";
            // 
            // btn_Cad_Palavra
            // 
            this.btn_Cad_Palavra.BackColor = System.Drawing.Color.White;
            this.btn_Cad_Palavra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cad_Palavra.Location = new System.Drawing.Point(89, 209);
            this.btn_Cad_Palavra.Name = "btn_Cad_Palavra";
            this.btn_Cad_Palavra.Size = new System.Drawing.Size(80, 40);
            this.btn_Cad_Palavra.TabIndex = 4;
            this.btn_Cad_Palavra.Text = "Cadastrar";
            this.btn_Cad_Palavra.UseVisualStyleBackColor = false;
            // 
            // txt_Cad_Palavra
            // 
            this.txt_Cad_Palavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cad_Palavra.Location = new System.Drawing.Point(17, 105);
            this.txt_Cad_Palavra.Name = "txt_Cad_Palavra";
            this.txt_Cad_Palavra.Size = new System.Drawing.Size(219, 26);
            this.txt_Cad_Palavra.TabIndex = 5;
            // 
            // txt_Cad_Dica
            // 
            this.txt_Cad_Dica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cad_Dica.Location = new System.Drawing.Point(17, 164);
            this.txt_Cad_Dica.Name = "txt_Cad_Dica";
            this.txt_Cad_Dica.Size = new System.Drawing.Size(219, 26);
            this.txt_Cad_Dica.TabIndex = 6;
            // 
            // Cad_Palavra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 259);
            this.Controls.Add(this.txt_Cad_Dica);
            this.Controls.Add(this.txt_Cad_Palavra);
            this.Controls.Add(this.btn_Cad_Palavra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Categoria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cad_Palavra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar palavra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Categoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Cad_Palavra;
        private System.Windows.Forms.TextBox txt_Cad_Palavra;
        private System.Windows.Forms.TextBox txt_Cad_Dica;
    }
}