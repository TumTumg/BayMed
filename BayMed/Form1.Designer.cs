namespace BayMed
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button cadastrar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Button excluir;
            System.Windows.Forms.Button consultar;
            System.Windows.Forms.Button atualizar;
            this.ranking = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            cadastrar = new System.Windows.Forms.Button();
            excluir = new System.Windows.Forms.Button();
            consultar = new System.Windows.Forms.Button();
            atualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cadastrar
            // 
            cadastrar.BackColor = System.Drawing.Color.Transparent;
            cadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cadastrar.BackgroundImage")));
            cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            cadastrar.FlatAppearance.BorderSize = 0;
            cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cadastrar.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cadastrar.ForeColor = System.Drawing.Color.Firebrick;
            cadastrar.Location = new System.Drawing.Point(40, 121);
            cadastrar.Name = "cadastrar";
            cadastrar.Size = new System.Drawing.Size(109, 101);
            cadastrar.TabIndex = 0;
            cadastrar.Text = "Cadastrar";
            cadastrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            cadastrar.UseVisualStyleBackColor = false;
            cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // excluir
            // 
            excluir.BackColor = System.Drawing.Color.Transparent;
            excluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("excluir.BackgroundImage")));
            excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            excluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            excluir.FlatAppearance.BorderSize = 0;
            excluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            excluir.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            excluir.ForeColor = System.Drawing.Color.Firebrick;
            excluir.Location = new System.Drawing.Point(456, 348);
            excluir.Name = "excluir";
            excluir.Size = new System.Drawing.Size(109, 101);
            excluir.TabIndex = 1;
            excluir.Text = "Excluir";
            excluir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            excluir.UseVisualStyleBackColor = false;
            excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // consultar
            // 
            consultar.BackColor = System.Drawing.Color.Transparent;
            consultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("consultar.BackgroundImage")));
            consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            consultar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            consultar.FlatAppearance.BorderSize = 0;
            consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            consultar.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            consultar.ForeColor = System.Drawing.Color.Firebrick;
            consultar.Location = new System.Drawing.Point(456, 121);
            consultar.Name = "consultar";
            consultar.Size = new System.Drawing.Size(109, 101);
            consultar.TabIndex = 2;
            consultar.Text = "Consultar";
            consultar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            consultar.UseVisualStyleBackColor = false;
            consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // atualizar
            // 
            atualizar.BackColor = System.Drawing.Color.Transparent;
            atualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("atualizar.BackgroundImage")));
            atualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            atualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            atualizar.FlatAppearance.BorderSize = 0;
            atualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            atualizar.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            atualizar.ForeColor = System.Drawing.Color.Firebrick;
            atualizar.Location = new System.Drawing.Point(40, 348);
            atualizar.Name = "atualizar";
            atualizar.Size = new System.Drawing.Size(109, 101);
            atualizar.TabIndex = 3;
            atualizar.Text = "Atualizar";
            atualizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            atualizar.UseVisualStyleBackColor = false;
            atualizar.Click += new System.EventHandler(this.atualizar_Click);
            // 
            // ranking
            // 
            this.ranking.BackColor = System.Drawing.Color.Transparent;
            this.ranking.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.ranking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ranking.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.ranking.ForeColor = System.Drawing.Color.Red;
            this.ranking.Location = new System.Drawing.Point(191, 450);
            this.ranking.Name = "ranking";
            this.ranking.Size = new System.Drawing.Size(234, 95);
            this.ranking.TabIndex = 4;
            this.ranking.Text = "#Ranking De Farmácias";
            this.ranking.UseVisualStyleBackColor = false;
            this.ranking.Click += new System.EventHandler(this.ranking_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(143, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sejam bem-vindos!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(622, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ranking);
            this.Controls.Add(atualizar);
            this.Controls.Add(consultar);
            this.Controls.Add(excluir);
            this.Controls.Add(cadastrar);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ranking;
        private System.Windows.Forms.Label label1;
    }
}

