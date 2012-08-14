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
            this.AddDados = new System.Windows.Forms.TextBox();
            this.B_ADD = new System.Windows.Forms.Button();
            this.B_DEL = new System.Windows.Forms.Button();
            this.Caixa_de_lista = new System.Windows.Forms.ListBox();
            this.COMFLITO_SE_VIRA_RODRIGAO = new System.Windows.Forms.GroupBox();
            this.COMFLITO_SE_VIRA_RODRIGAO.SuspendLayout();
            this.SuspendLayout();
            // 
            // TEXTO
            // 
            this.TEXTO.AutoSize = true;
            this.TEXTO.Location = new System.Drawing.Point(40, 36);
            this.TEXTO.Name = "TEXTO";
            this.TEXTO.Size = new System.Drawing.Size(130, 17);
            this.TEXTO.TabIndex = 0;
            this.TEXTO.Text = "PARA COMPRAR";
            // 
            // AddDados
            // 
            this.AddDados.Location = new System.Drawing.Point(43, 52);
            this.AddDados.Name = "AddDados";
            this.AddDados.Size = new System.Drawing.Size(174, 23);
            this.AddDados.TabIndex = 1;
            // 
            // B_ADD
            // 
            this.B_ADD.Location = new System.Drawing.Point(253, 45);
            this.B_ADD.Name = "B_ADD";
            this.B_ADD.Size = new System.Drawing.Size(174, 32);
            this.B_ADD.TabIndex = 2;
            this.B_ADD.Text = "&ADD";
            this.B_ADD.UseVisualStyleBackColor = true;
            this.B_ADD.Click += new System.EventHandler(this.button1_Click);
            // 
            // B_DEL
            // 
            this.B_DEL.Location = new System.Drawing.Point(306, 274);
            this.B_DEL.Name = "B_DEL";
            this.B_DEL.Size = new System.Drawing.Size(121, 34);
            this.B_DEL.TabIndex = 3;
            this.B_DEL.Text = "&DELETE";
            this.B_DEL.UseVisualStyleBackColor = true;
            this.B_DEL.Click += new System.EventHandler(this.button2_Click);
            // 
            // Caixa_de_lista
            // 
            this.Caixa_de_lista.FormattingEnabled = true;
            this.Caixa_de_lista.ItemHeight = 16;
            this.Caixa_de_lista.Location = new System.Drawing.Point(43, 108);
            this.Caixa_de_lista.Name = "Caixa_de_lista";
            this.Caixa_de_lista.Size = new System.Drawing.Size(384, 148);
            this.Caixa_de_lista.TabIndex = 4;
            // 
            // COMFLITO_SE_VIRA_RODRIGAO
            // 
            this.COMFLITO_SE_VIRA_RODRIGAO.Controls.Add(this.B_DEL);
            this.COMFLITO_SE_VIRA_RODRIGAO.Controls.Add(this.B_ADD);
            this.COMFLITO_SE_VIRA_RODRIGAO.Controls.Add(this.Caixa_de_lista);
            this.COMFLITO_SE_VIRA_RODRIGAO.Controls.Add(this.AddDados);
            this.COMFLITO_SE_VIRA_RODRIGAO.Controls.Add(this.TEXTO);
            this.COMFLITO_SE_VIRA_RODRIGAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMFLITO_SE_VIRA_RODRIGAO.Location = new System.Drawing.Point(7, 12);
            this.COMFLITO_SE_VIRA_RODRIGAO.Name = "COMFLITO_SE_VIRA_RODRIGAO";
            this.COMFLITO_SE_VIRA_RODRIGAO.Size = new System.Drawing.Size(455, 323);
            this.COMFLITO_SE_VIRA_RODRIGAO.TabIndex = 5;
            this.COMFLITO_SE_VIRA_RODRIGAO.TabStop = false;
            this.COMFLITO_SE_VIRA_RODRIGAO.Text = "TESTE GIT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(469, 351);
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
        private System.Windows.Forms.TextBox AddDados;
        private System.Windows.Forms.Button B_ADD;
        private System.Windows.Forms.Button B_DEL;
        private System.Windows.Forms.ListBox Caixa_de_lista;
        private System.Windows.Forms.GroupBox COMFLITO_SE_VIRA_RODRIGAO;
    }
}

