namespace CustomVisualizer
{
    partial class MyObjectVizForm
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
            this.MyObjectPropGrid = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // MyObjectPropGrid
            // 
            this.MyObjectPropGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyObjectPropGrid.Location = new System.Drawing.Point(0, 0);
            this.MyObjectPropGrid.Name = "MyObjectPropGrid";
            this.MyObjectPropGrid.Size = new System.Drawing.Size(800, 450);
            this.MyObjectPropGrid.TabIndex = 0;
            // 
            // MyObjectVizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MyObjectPropGrid);
            this.Name = "MyObjectVizForm";
            this.Text = "MyObjectVizForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid MyObjectPropGrid;
    }
}