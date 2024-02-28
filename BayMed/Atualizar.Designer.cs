namespace BayMed
{
    partial class Atualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Atualizar));
            this.label9 = new System.Windows.Forms.Label();
            this.telefoneA = new System.Windows.Forms.MaskedTextBox();
            this.RGA = new System.Windows.Forms.MaskedTextBox();
            this.estadoA = new System.Windows.Forms.TextBox();
            this.cidade2A = new System.Windows.Forms.TextBox();
            this.idadeA = new System.Windows.Forms.TextBox();
            this.nomeA = new System.Windows.Forms.TextBox();
            this.codigoA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buscarAtualizar = new System.Windows.Forms.Button();
            this.Atualizar1 = new System.Windows.Forms.Button();
            this.VoltarAtualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(173, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 55);
            this.label9.TabIndex = 36;
            this.label9.Text = "Atualizar";
            // 
            // telefoneA
            // 
            this.telefoneA.Font = new System.Drawing.Font("Modern No. 20", 14.25F);
            this.telefoneA.Location = new System.Drawing.Point(135, 412);
            this.telefoneA.Mask = "() _____-____";
            this.telefoneA.Name = "telefoneA";
            this.telefoneA.Size = new System.Drawing.Size(129, 28);
            this.telefoneA.TabIndex = 35;
            this.telefoneA.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.telefoneA_MaskInputRejected);
            // 
            // RGA
            // 
            this.RGA.Font = new System.Drawing.Font("Modern No. 20", 14.25F);
            this.RGA.Location = new System.Drawing.Point(135, 367);
            this.RGA.Mask = "__.___.___-__";
            this.RGA.Name = "RGA";
            this.RGA.Size = new System.Drawing.Size(129, 28);
            this.RGA.TabIndex = 34;
            this.RGA.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.RGA_MaskInputRejected);
            // 
            // estadoA
            // 
            this.estadoA.Font = new System.Drawing.Font("Modern No. 20", 14.25F);
            this.estadoA.Location = new System.Drawing.Point(135, 327);
            this.estadoA.Name = "estadoA";
            this.estadoA.Size = new System.Drawing.Size(129, 28);
            this.estadoA.TabIndex = 32;
            this.estadoA.TextChanged += new System.EventHandler(this.estadoA_TextChanged);
            // 
            // cidade2A
            // 
            this.cidade2A.Font = new System.Drawing.Font("Modern No. 20", 14.25F);
            this.cidade2A.Location = new System.Drawing.Point(135, 286);
            this.cidade2A.Name = "cidade2A";
            this.cidade2A.Size = new System.Drawing.Size(129, 28);
            this.cidade2A.TabIndex = 31;
            this.cidade2A.TextChanged += new System.EventHandler(this.cidade2A_TextChanged);
            // 
            // idadeA
            // 
            this.idadeA.Font = new System.Drawing.Font("Modern No. 20", 14.25F);
            this.idadeA.Location = new System.Drawing.Point(135, 244);
            this.idadeA.Name = "idadeA";
            this.idadeA.Size = new System.Drawing.Size(129, 28);
            this.idadeA.TabIndex = 30;
            this.idadeA.TextChanged += new System.EventHandler(this.idadeA_TextChanged);
            // 
            // nomeA
            // 
            this.nomeA.Font = new System.Drawing.Font("Modern No. 20", 14.25F);
            this.nomeA.Location = new System.Drawing.Point(135, 206);
            this.nomeA.Name = "nomeA";
            this.nomeA.Size = new System.Drawing.Size(129, 28);
            this.nomeA.TabIndex = 29;
            this.nomeA.TextChanged += new System.EventHandler(this.nomeA_TextChanged);
            // 
            // codigoA
            // 
            this.codigoA.BackColor = System.Drawing.Color.White;
            this.codigoA.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoA.Location = new System.Drawing.Point(135, 168);
            this.codigoA.Name = "codigoA";
            this.codigoA.Size = new System.Drawing.Size(129, 28);
            this.codigoA.TabIndex = 28;
            this.codigoA.TextChanged += new System.EventHandler(this.codigoA_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 20.25F);
            this.label8.Location = new System.Drawing.Point(31, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 29);
            this.label8.TabIndex = 27;
            this.label8.Text = "Telefone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 20.25F);
            this.label7.Location = new System.Drawing.Point(33, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 29);
            this.label7.TabIndex = 26;
            this.label7.Text = "RG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 20.25F);
            this.label6.Location = new System.Drawing.Point(33, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 29);
            this.label6.TabIndex = 24;
            this.label6.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 20.25F);
            this.label5.Location = new System.Drawing.Point(31, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "Cidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 20.25F);
            this.label4.Location = new System.Drawing.Point(33, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "Idade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 20.25F);
            this.label3.Location = new System.Drawing.Point(33, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Código";
            // 
            // buscarAtualizar
            // 
            this.buscarAtualizar.BackColor = System.Drawing.Color.IndianRed;
            this.buscarAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buscarAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarAtualizar.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarAtualizar.Location = new System.Drawing.Point(368, 176);
            this.buscarAtualizar.Name = "buscarAtualizar";
            this.buscarAtualizar.Size = new System.Drawing.Size(175, 69);
            this.buscarAtualizar.TabIndex = 37;
            this.buscarAtualizar.Text = "Buscar";
            this.buscarAtualizar.UseVisualStyleBackColor = false;
            this.buscarAtualizar.Click += new System.EventHandler(this.buscarAtualizar_Click);
            // 
            // Atualizar1
            // 
            this.Atualizar1.BackColor = System.Drawing.Color.IndianRed;
            this.Atualizar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Atualizar1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Atualizar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Atualizar1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atualizar1.Location = new System.Drawing.Point(368, 251);
            this.Atualizar1.Name = "Atualizar1";
            this.Atualizar1.Size = new System.Drawing.Size(175, 69);
            this.Atualizar1.TabIndex = 38;
            this.Atualizar1.Text = "Atualizar";
            this.Atualizar1.UseVisualStyleBackColor = false;
            this.Atualizar1.Click += new System.EventHandler(this.Atualizar1_Click);
            // 
            // VoltarAtualizar
            // 
            this.VoltarAtualizar.BackColor = System.Drawing.Color.IndianRed;
            this.VoltarAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VoltarAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.VoltarAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VoltarAtualizar.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoltarAtualizar.Location = new System.Drawing.Point(368, 326);
            this.VoltarAtualizar.Name = "VoltarAtualizar";
            this.VoltarAtualizar.Size = new System.Drawing.Size(175, 69);
            this.VoltarAtualizar.TabIndex = 39;
            this.VoltarAtualizar.Text = "Voltar";
            this.VoltarAtualizar.UseVisualStyleBackColor = false;
            this.VoltarAtualizar.Click += new System.EventHandler(this.VoltarAtualizar_Click);
            // 
            // Atualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(617, 608);
            this.Controls.Add(this.VoltarAtualizar);
            this.Controls.Add(this.Atualizar1);
            this.Controls.Add(this.buscarAtualizar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.telefoneA);
            this.Controls.Add(this.RGA);
            this.Controls.Add(this.estadoA);
            this.Controls.Add(this.cidade2A);
            this.Controls.Add(this.idadeA);
            this.Controls.Add(this.nomeA);
            this.Controls.Add(this.codigoA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Atualizar";
            this.Text = "Atualizar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox telefoneA;
        private System.Windows.Forms.MaskedTextBox RGA;
        private System.Windows.Forms.TextBox estadoA;
        private System.Windows.Forms.TextBox cidade2A;
        private System.Windows.Forms.TextBox idadeA;
        private System.Windows.Forms.TextBox nomeA;
        private System.Windows.Forms.TextBox codigoA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buscarAtualizar;
        private System.Windows.Forms.Button Atualizar1;
        private System.Windows.Forms.Button VoltarAtualizar;
    }
}