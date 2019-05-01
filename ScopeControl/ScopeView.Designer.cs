namespace ScopeControl
{
    partial class ScopeView
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ScopeScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ScopeScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // ScopeScreen
            // 
            this.ScopeScreen.Location = new System.Drawing.Point(3, 3);
            this.ScopeScreen.Name = "ScopeScreen";
            this.ScopeScreen.Size = new System.Drawing.Size(300, 300);
            this.ScopeScreen.TabIndex = 0;
            this.ScopeScreen.TabStop = false;
            this.ScopeScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.OnScopeScreenPaint);
            // 
            // ScopeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ScopeScreen);
            this.Name = "ScopeView";
            this.Size = new System.Drawing.Size(300, 300);
            ((System.ComponentModel.ISupportInitialize)(this.ScopeScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ScopeScreen;
    }
}
