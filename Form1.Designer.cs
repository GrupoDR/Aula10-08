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
            this.tEX = new System.Windows.Forms.TextBox();
            this.Adicionar = new System.Windows.Forms.Button();
            this.Apagar = new System.Windows.Forms.Button();
            this.Lista_da_caixa = new System.Windows.Forms.ListBox();
            this.COMFLITO_SE_VIRA_RODRIGAO = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            // tEX
            // 
            this.tEX.Location = new System.Drawing.Point(6, 50);
            this.tEX.Name = "tEX";
            this.tEX.Size = new System.Drawing.Size(421, 23);
            this.tEX.TabIndex = 1;
            // 
            // Adicionar
            // 
            this.Adicionar.Location = new System.Drawing.Point(514, 92);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(174, 115);
            this.Adicionar.TabIndex = 2;
            this.Adicionar.Text = "&ADICIONAR";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Apagar
            // 
            this.Apagar.Location = new System.Drawing.Point(514, 225);
            this.Apagar.Name = "Apagar";
            this.Apagar.Size = new System.Drawing.Size(174, 141);
            this.Apagar.TabIndex = 3;
            this.Apagar.Text = "&APAGAR";
            this.Apagar.UseVisualStyleBackColor = true;
            this.Apagar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lista_da_caixa
            // 
            this.Lista_da_caixa.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Lista_da_caixa.Font = new System.Drawing.Font("Monotype Sorts", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Lista_da_caixa.FormattingEnabled = true;
            this.Lista_da_caixa.ItemHeight = 27;
            this.Lista_da_caixa.Items.AddRange(new object[] {
            "UM",
            "DOIS ",
            "TRÊS"});
            this.Lista_da_caixa.Location = new System.Drawing.Point(22, 92);
            this.Lista_da_caixa.Name = "Lista_da_caixa";
            this.Lista_da_caixa.Size = new System.Drawing.Size(421, 274);
            this.Lista_da_caixa.TabIndex = 4;
            // 
            // COMFLITO_SE_VIRA_RODRIGAO
            // 
            this.COMFLITO_SE_VIRA_RODRIGAO.Controls.Add(this.Apagar);
            this.COMFLITO_SE_VIRA_RODRIGAO.Controls.Add(this.Adicionar);
            this.COMFLITO_SE_VIRA_RODRIGAO.Controls.Add(this.Lista_da_caixa);
            this.COMFLITO_SE_VIRA_RODRIGAO.Controls.Add(this.tEX);
            this.COMFLITO_SE_VIRA_RODRIGAO.Controls.Add(this.TEXTO);
            this.COMFLITO_SE_VIRA_RODRIGAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMFLITO_SE_VIRA_RODRIGAO.Location = new System.Drawing.Point(7, 12);
            this.COMFLITO_SE_VIRA_RODRIGAO.Name = "COMFLITO_SE_VIRA_RODRIGAO";
            this.COMFLITO_SE_VIRA_RODRIGAO.Size = new System.Drawing.Size(716, 394);
            this.COMFLITO_SE_VIRA_RODRIGAO.TabIndex = 5;
            this.COMFLITO_SE_VIRA_RODRIGAO.TabStop = false;
            this.COMFLITO_SE_VIRA_RODRIGAO.Text = "TESTE GIT";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::aula10_08.Properties.Resources.git;
            this.groupBox1.Location = new System.Drawing.Point(729, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 406);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(953, 442);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.COMFLITO_SE_VIRA_RODRIGAO);
            this.Name = "Form1";
            this.Text = "Git";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.COMFLITO_SE_VIRA_RODRIGAO.ResumeLayout(false);
            this.COMFLITO_SE_VIRA_RODRIGAO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TEXTO;

        private System.Windows.Forms.TextBox tEX;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Button Apagar;
        private System.Windows.Forms.ListBox Lista_da_caixa;
        private System.Windows.Forms.GroupBox COMFLITO_SE_VIRA_RODRIGAO;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}

