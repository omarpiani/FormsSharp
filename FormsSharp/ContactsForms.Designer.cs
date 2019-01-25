namespace FormsSharp
{
    partial class ContactsForms
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.contactsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.contactsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // contactsGrid
            // 
            this.contactsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactsGrid.Location = new System.Drawing.Point(184, 111);
            this.contactsGrid.Name = "contactsGrid";
            this.contactsGrid.Size = new System.Drawing.Size(393, 150);
            this.contactsGrid.TabIndex = 0;
            this.contactsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contactsGrid_CellContentClick);
            // 
            // ContactsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contactsGrid);
            this.Name = "ContactsForms";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.contactsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView contactsGrid;
    }
}

