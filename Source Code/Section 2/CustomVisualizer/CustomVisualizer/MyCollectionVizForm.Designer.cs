namespace CustomVisualizer
{
    partial class MyCollectionVizForm
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
            this.MyCollectionDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MyCollectionDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MyCollectionDataGrid
            // 
            this.MyCollectionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyCollectionDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyCollectionDataGrid.Location = new System.Drawing.Point(0, 0);
            this.MyCollectionDataGrid.Name = "MyCollectionDataGrid";
            this.MyCollectionDataGrid.Size = new System.Drawing.Size(800, 450);
            this.MyCollectionDataGrid.TabIndex = 0;
            // 
            // MyCollectionVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MyCollectionDataGrid);
            this.Name = "MyCollectionVisualizer";
            this.Text = "MyCollectionVisualizer";
            ((System.ComponentModel.ISupportInitialize)(this.MyCollectionDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MyCollectionDataGrid;
    }
}