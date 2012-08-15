namespace aula10_08
{
    partial class Form1
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
            this.TEXTO = new System.Windows.Forms.Label();
            this.Oquedeveadicionar = new System.Windows.Forms.TextBox();
            this.Adicionar = new System.Windows.Forms.Button();
            this.Apagar = new System.Windows.Forms.Button();
            this.Lista_da_caixa = new System.Windows.Forms.ListBox();
            this.COMFLITO_SE_VIRA_RODRIGAO = new System.Windows.Forms.GroupBox();
            this.Fechar = new System.Windows.Forms.Button();
            this.COMFLITO_SE_VIRA_RODRIGAO.SuspendLayout();
            this.SuspendLayout();
            // 
            // TEXTO
            // 
            this.TEXTO.AutoSize = true;
            this.TEXTO.Location = new System.Drawing.Point(6, 30);
            this.TEXTO.Name = "TEXTO";
            this.TEXTO.Size = new System.Drawing.Size(130, 17);
            this.TEXTO.TabIndex = 0;
            this.TEXTO.Text = "PARA COMPRAR";
            // 
            // Oquedeveadicionar
            // 
            this.Oquedeveadicionar.Location = new System.Drawing.Point(6, 50);
            this.Oquedeveadicionar.Name = "Oquedeveadicionar";
            this.Oquedeveadicionar.Size = new System.Drawing.Size(421, 23);
            this.Oquedeveadicionar.TabIndex = 1;
            // 
            // Adicionar
            // 
            this.Adicionar.Location = new System.Drawing.Point(514, 50);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(174, 32);
            this.Adicionar.TabIndex = 2;
            this.Adicionar.Text = "&ADD";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Apagar
            // 
            this.Apagar.Location = new System.Drawing.Point(514, 108);
            this.Apagar.Name = "Apagar";
            this.Apagar.Size = new System.Drawing.Size(174, 34);
            this.Apagar.TabIndex = 3;
            this.Apagar.Text = "&DELETE";
            this.Apagar.UseVisualStyleBackColor = true;
            this.Apagar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lista_da_caixa
            // 
            this.Lista_da_caixa.FormattingEnabled = true;
            this.Lista_da_caixa.ItemHeight = 16;
            this.Lista_da_caixa.Location = new System.Drawing.Point(6, 108);
            this.Lista_da_caixa.Name = "Lista_da_caixa";
            this.Lista_da_caixa.Size = new System.Drawing.Size(421, 276);
            this.Lista_da_caixa.TabIndex = 4;
            // 
            // COMFLITO_SE_VIRA_RODRIGAO
            // 
            this.COMFLITO_SE_VIRA_RODRIGAO.Controls.Add(this.Fechar);
            this.COMFLITO_SE_VIRA_RODRIGAO.Controls.Add(this.Apagar);
            this.COMFLITO_SE_VIRA_RODRIGAO.Controls.Add(this.Adicionar);
            this.COMFLITO_SE_VIRA_RODRIGAO.Controls.Add(this.Lista_da_caixa);
            this.COMFLITO_SE_VIRA_RODRIGAO.Controls.Add(this.Oquedeveadicionar);
            this.COMFLITO_SE_VIRA_RODRIGAO.Controls.Add(this.TEXTO);
            this.COMFLITO_SE_VIRA_RODRIGAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMFLITO_SE_VIRA_RODRIGAO.Location = new System.Drawing.Point(7, 12);
            this.COMFLITO_SE_VIRA_RODRIGAO.Name = "COMFLITO_SE_VIRA_RODRIGAO";
            this.COMFLITO_SE_VIRA_RODRIGAO.Size = new System.Drawing.Size(716, 394);
            this.COMFLITO_SE_VIRA_RODRIGAO.TabIndex = 5;
            this.COMFLITO_SE_VIRA_RODRIGAO.TabStop = false;
            this.COMFLITO_SE_VIRA_RODRIGAO.Text = "TESTE GIT";
            // 
            // Fechar
            // 
            this.Fechar.Location = new System.Drawing.Point(514, 168);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(174, 34);
            this.Fechar.TabIndex = 5;
            this.Fechar.Text = "&SAIR";
            this.Fechar.UseVisualStyleBackColor = true;
            this.Fechar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(735, 418);
            this.Controls.Add(this.COMFLITO_SE_VIRA_RODRIGAO);
            this.Name = "Form1";
            this.Text = "Git";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.COMFLITO_SE_VIRA_RODRIGAO.ResumeLayout(false);
            this.COMFLITO_SE_VIRA_RODRIGAO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TEXTO;
        private System.Windows.Forms.TextBox Oquedeveadicionar;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Button Apagar;
        private System.Windows.Forms.ListBox Lista_da_caixa;
        private System.Windows.Forms.GroupBox COMFLITO_SE_VIRA_RODRIGAO;
        private System.Windows.Forms.Button Fechar;
    }
}

