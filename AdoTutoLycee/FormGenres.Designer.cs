namespace AdoTutoLycee
{
    partial class FormGenres
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
            this.components = new System.ComponentModel.Container();
            this.btn_nouveau = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_Afficher = new System.Windows.Forms.Button();
            this.dgv_ListeGenres = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_nouveau
            // 
            this.btn_nouveau.Location = new System.Drawing.Point(602, 86);
            this.btn_nouveau.Name = "btn_nouveau";
            this.btn_nouveau.Size = new System.Drawing.Size(64, 20);
            this.btn_nouveau.TabIndex = 3;
            this.btn_nouveau.Text = "Nouveau";
            this.btn_nouveau.UseVisualStyleBackColor = true;
            this.btn_nouveau.Click += new System.EventHandler(this.btn_nouveau_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(602, 61);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(64, 20);
            this.btn_supprimer.TabIndex = 4;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(602, 36);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(64, 20);
            this.btn_modifier.TabIndex = 5;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_Afficher
            // 
            this.btn_Afficher.Location = new System.Drawing.Point(602, 10);
            this.btn_Afficher.Name = "btn_Afficher";
            this.btn_Afficher.Size = new System.Drawing.Size(64, 20);
            this.btn_Afficher.TabIndex = 6;
            this.btn_Afficher.Text = "Afficher";
            this.btn_Afficher.UseVisualStyleBackColor = true;
            this.btn_Afficher.Click += new System.EventHandler(this.btn_Afficher_Click);
            // 
            // dgv_ListeGenres
            // 
            this.dgv_ListeGenres.AllowUserToAddRows = false;
            this.dgv_ListeGenres.AllowUserToDeleteRows = false;
            this.dgv_ListeGenres.AutoGenerateColumns = false;
            this.dgv_ListeGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListeGenres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Nom});
            this.dgv_ListeGenres.DataSource = this.bs;
            this.dgv_ListeGenres.Location = new System.Drawing.Point(21, 10);
            this.dgv_ListeGenres.MultiSelect = false;
            this.dgv_ListeGenres.Name = "dgv_ListeGenres";
            this.dgv_ListeGenres.ReadOnly = true;
            this.dgv_ListeGenres.RowTemplate.Height = 25;
            this.dgv_ListeGenres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListeGenres.Size = new System.Drawing.Size(545, 369);
            this.dgv_ListeGenres.TabIndex = 2;
            // 
            // Num
            // 
            this.Num.DataPropertyName = "Num";
            this.Num.HeaderText = "Numéro";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "Libelle";
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 200;
            // 
            // FormGenres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.btn_nouveau);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_Afficher);
            this.Controls.Add(this.dgv_ListeGenres);
            this.Name = "FormGenres";
            this.Text = "Genres";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_nouveau;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_Afficher;
        private System.Windows.Forms.DataGridView dgv_ListeGenres;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
    }
}