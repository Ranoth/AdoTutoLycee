namespace AdoTutoLycee
{
    partial class FormLivres
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
            this.dgv_ListeLivres = new System.Windows.Forms.DataGridView();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editeurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anneeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.langueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeLivres)).BeginInit();
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
            // dgv_ListeLivres
            // 
            this.dgv_ListeLivres.AllowUserToAddRows = false;
            this.dgv_ListeLivres.AllowUserToDeleteRows = false;
            this.dgv_ListeLivres.AutoGenerateColumns = false;
            this.dgv_ListeLivres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListeLivres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.titreDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.editeurDataGridViewTextBoxColumn,
            this.anneeDataGridViewTextBoxColumn,
            this.langueDataGridViewTextBoxColumn,
            this.Auteur,
            this.Genre});
            this.dgv_ListeLivres.DataSource = this.bs;
            this.dgv_ListeLivres.Location = new System.Drawing.Point(21, 10);
            this.dgv_ListeLivres.MultiSelect = false;
            this.dgv_ListeLivres.Name = "dgv_ListeLivres";
            this.dgv_ListeLivres.ReadOnly = true;
            this.dgv_ListeLivres.RowTemplate.Height = 25;
            this.dgv_ListeLivres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListeLivres.Size = new System.Drawing.Size(545, 369);
            this.dgv_ListeLivres.TabIndex = 2;
            // 
            // bs
            // 
            this.bs.DataSource = typeof(AdoTutoLycee.QLivre);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Auteur";
            this.dataGridViewTextBoxColumn1.HeaderText = "Auteur";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Genre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Genre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn.HeaderText = "Num";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            this.numDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titreDataGridViewTextBoxColumn
            // 
            this.titreDataGridViewTextBoxColumn.DataPropertyName = "Titre";
            this.titreDataGridViewTextBoxColumn.HeaderText = "Titre";
            this.titreDataGridViewTextBoxColumn.Name = "titreDataGridViewTextBoxColumn";
            this.titreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "Prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            this.prixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editeurDataGridViewTextBoxColumn
            // 
            this.editeurDataGridViewTextBoxColumn.DataPropertyName = "Editeur";
            this.editeurDataGridViewTextBoxColumn.HeaderText = "Editeur";
            this.editeurDataGridViewTextBoxColumn.Name = "editeurDataGridViewTextBoxColumn";
            this.editeurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anneeDataGridViewTextBoxColumn
            // 
            this.anneeDataGridViewTextBoxColumn.DataPropertyName = "Annee";
            this.anneeDataGridViewTextBoxColumn.HeaderText = "Annee";
            this.anneeDataGridViewTextBoxColumn.Name = "anneeDataGridViewTextBoxColumn";
            this.anneeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // langueDataGridViewTextBoxColumn
            // 
            this.langueDataGridViewTextBoxColumn.DataPropertyName = "Langue";
            this.langueDataGridViewTextBoxColumn.HeaderText = "Langue";
            this.langueDataGridViewTextBoxColumn.Name = "langueDataGridViewTextBoxColumn";
            this.langueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Auteur
            // 
            this.Auteur.DataPropertyName = "nomAuteur";
            this.Auteur.HeaderText = "Auteur";
            this.Auteur.Name = "Auteur";
            this.Auteur.ReadOnly = true;
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "libelleGenre";
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            // 
            // FormLivres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.btn_nouveau);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_Afficher);
            this.Controls.Add(this.dgv_ListeLivres);
            this.Name = "FormLivres";
            this.Text = "Livres";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeLivres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_nouveau;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_Afficher;
        private System.Windows.Forms.DataGridView dgv_ListeLivres;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.DataGridViewTextBoxColumn auteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editeurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anneeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn langueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
    }
}