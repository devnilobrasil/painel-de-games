
namespace PainelGames_nbr
{
    partial class frm_painel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_painel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_side_menu = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_bn_menu = new System.Windows.Forms.Button();
            this.btn_jdv_menu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel_content = new System.Windows.Forms.Panel();
            this.jogo_da_velha1 = new PainelGames_nbr.jogo_da_velha();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_side_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_content.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(207, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_side_menu
            // 
            this.panel_side_menu.BackColor = System.Drawing.Color.Black;
            this.panel_side_menu.Controls.Add(this.btn_home);
            this.panel_side_menu.Controls.Add(this.btn_exit);
            this.panel_side_menu.Controls.Add(this.panel1);
            this.panel_side_menu.Controls.Add(this.btn_bn_menu);
            this.panel_side_menu.Controls.Add(this.btn_jdv_menu);
            this.panel_side_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_side_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_side_menu.Name = "panel_side_menu";
            this.panel_side_menu.Size = new System.Drawing.Size(176, 450);
            this.panel_side_menu.TabIndex = 1;
            // 
            // btn_home
            // 
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.Location = new System.Drawing.Point(42, 410);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(33, 37);
            this.btn_home.TabIndex = 8;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(3, 411);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(33, 37);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 100);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btn_bn_menu
            // 
            this.btn_bn_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bn_menu.FlatAppearance.BorderSize = 0;
            this.btn_bn_menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_bn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bn_menu.Font = new System.Drawing.Font("Candara", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bn_menu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_bn_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_bn_menu.Image")));
            this.btn_bn_menu.Location = new System.Drawing.Point(0, 164);
            this.btn_bn_menu.Name = "btn_bn_menu";
            this.btn_bn_menu.Size = new System.Drawing.Size(176, 59);
            this.btn_bn_menu.TabIndex = 1;
            this.btn_bn_menu.Text = "  Batalha Naval";
            this.btn_bn_menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_bn_menu.UseVisualStyleBackColor = true;
            // 
            // btn_jdv_menu
            // 
            this.btn_jdv_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_jdv_menu.FlatAppearance.BorderSize = 0;
            this.btn_jdv_menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_jdv_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_jdv_menu.Font = new System.Drawing.Font("Candara", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jdv_menu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_jdv_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_jdv_menu.Image")));
            this.btn_jdv_menu.Location = new System.Drawing.Point(0, 99);
            this.btn_jdv_menu.Name = "btn_jdv_menu";
            this.btn_jdv_menu.Size = new System.Drawing.Size(176, 59);
            this.btn_jdv_menu.TabIndex = 0;
            this.btn_jdv_menu.Text = "  Jogo da Velha";
            this.btn_jdv_menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_jdv_menu.UseVisualStyleBackColor = true;
            this.btn_jdv_menu.Click += new System.EventHandler(this.btn_jdv_menu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Painel de jogos desenvolvido em C#";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(546, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 29);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(482, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 29);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(514, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 29);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel_content
            // 
            this.panel_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_content.Controls.Add(this.pictureBox1);
            this.panel_content.Controls.Add(this.button3);
            this.panel_content.Controls.Add(this.button1);
            this.panel_content.Controls.Add(this.label1);
            this.panel_content.Controls.Add(this.button2);
            this.panel_content.Location = new System.Drawing.Point(173, 0);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(593, 450);
            this.panel_content.TabIndex = 6;
            // 
            // jogo_da_velha1
            // 
            this.jogo_da_velha1.Location = new System.Drawing.Point(173, 0);
            this.jogo_da_velha1.Name = "jogo_da_velha1";
            this.jogo_da_velha1.Size = new System.Drawing.Size(584, 450);
            this.jogo_da_velha1.TabIndex = 7;
            // 
            // frm_painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.panel_content);
            this.Controls.Add(this.panel_side_menu);
            this.Controls.Add(this.jogo_da_velha1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_painel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_side_menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_content.ResumeLayout(false);
            this.panel_content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_side_menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_jdv_menu;
        private System.Windows.Forms.Button btn_bn_menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel_content;
        private jogo_da_velha jogo_da_velha1;
        private System.Windows.Forms.Button btn_home;
    }
}

