namespace BayMed
{
    partial class Excluir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Excluir));
            this.Excluir1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.excluirBotao = new System.Windows.Forms.Button();
            this.voltarExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Excluir1
            // 
            this.Excluir1.AutoSize = true;
            this.Excluir1.BackColor = System.Drawing.Color.Transparent;
            this.Excluir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excluir1.Location = new System.Drawing.Point(43, 198);
            this.Excluir1.Name = "Excluir1";
            this.Excluir1.Size = new System.Drawing.Size(254, 73);
            this.Excluir1.TabIndex = 0;
            this.Excluir1.Text = "Código:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.IndianRed;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(293, 195);
            this.maskedTextBox1.Mask = "_________";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(259, 80);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "Excluir";
            // 
            // excluirBotao
            // 
            this.excluirBotao.BackColor = System.Drawing.Color.IndianRed;
            this.excluirBotao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.excluirBotao.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.excluirBotao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirBotao.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirBotao.Location = new System.Drawing.Point(36, 308);
            this.excluirBotao.Name = "excluirBotao";
            this.excluirBotao.Size = new System.Drawing.Size(175, 69);
            this.excluirBotao.TabIndex = 19;
            this.excluirBotao.Text = "Excluir";
            this.excluirBotao.UseVisualStyleBackColor = false;
            this.excluirBotao.Click += new System.EventHandler(this.excluirBotao_Click);
            // 
            // voltarExcluir
            // 
            this.voltarExcluir.BackColor = System.Drawing.Color.IndianRed;
            this.voltarExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltarExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.voltarExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltarExcluir.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltarExcluir.Location = new System.Drawing.Point(397, 308);
            this.voltarExcluir.Name = "voltarExcluir";
            this.voltarExcluir.Size = new System.Drawing.Size(175, 69);
            this.voltarExcluir.TabIndex = 20;
            this.voltarExcluir.Text = "Voltar";
            this.voltarExcluir.UseVisualStyleBackColor = false;
            this.voltarExcluir.Click += new System.EventHandler(this.voltarExcluir_Click);
            // 
            // Excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 582);
            this.Controls.Add(this.voltarExcluir);
            this.Controls.Add(this.excluirBotao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.Excluir1);
            this.DoubleBuffered = true;
            this.Name = "Excluir";
            this.Text = "Excluir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Excluir1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button excluirBotao;
        private System.Windows.Forms.Button voltarExcluir;
    }
}