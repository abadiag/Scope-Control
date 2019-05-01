namespace ScopeControl
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.trackBarValue = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarGridScale = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarMatrixJump = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarTimerInt = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGridScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMatrixJump)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTimerInt)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarValue
            // 
            this.trackBarValue.Location = new System.Drawing.Point(393, 39);
            this.trackBarValue.Maximum = 100;
            this.trackBarValue.Minimum = -100;
            this.trackBarValue.Name = "trackBarValue";
            this.trackBarValue.Size = new System.Drawing.Size(398, 45);
            this.trackBarValue.TabIndex = 0;
            this.trackBarValue.ValueChanged += new System.EventHandler(this.trackBarValue_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "input Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "GridScale (px)";
            // 
            // trackBarGridScale
            // 
            this.trackBarGridScale.Location = new System.Drawing.Point(390, 103);
            this.trackBarGridScale.Maximum = 100;
            this.trackBarGridScale.Minimum = 5;
            this.trackBarGridScale.Name = "trackBarGridScale";
            this.trackBarGridScale.Size = new System.Drawing.Size(398, 45);
            this.trackBarGridScale.TabIndex = 2;
            this.trackBarGridScale.Value = 10;
            this.trackBarGridScale.ValueChanged += new System.EventHandler(this.trackBarGridScale_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Refresh Time (Matrix jump)";
            // 
            // trackBarMatrixJump
            // 
            this.trackBarMatrixJump.Location = new System.Drawing.Point(393, 167);
            this.trackBarMatrixJump.Maximum = 6;
            this.trackBarMatrixJump.Minimum = 1;
            this.trackBarMatrixJump.Name = "trackBarMatrixJump";
            this.trackBarMatrixJump.Size = new System.Drawing.Size(398, 45);
            this.trackBarMatrixJump.TabIndex = 4;
            this.trackBarMatrixJump.Value = 1;
            this.trackBarMatrixJump.ValueChanged += new System.EventHandler(this.trackBarMatrixJump_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "TimerStep (ms)";
            // 
            // trackBarTimerInt
            // 
            this.trackBarTimerInt.Location = new System.Drawing.Point(393, 228);
            this.trackBarTimerInt.Maximum = 50;
            this.trackBarTimerInt.Minimum = 1;
            this.trackBarTimerInt.Name = "trackBarTimerInt";
            this.trackBarTimerInt.Size = new System.Drawing.Size(398, 45);
            this.trackBarTimerInt.TabIndex = 6;
            this.trackBarTimerInt.Value = 1;
            this.trackBarTimerInt.ValueChanged += new System.EventHandler(this.trackBarTimerInt_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBarTimerInt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBarMatrixJump);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarGridScale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarValue);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGridScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMatrixJump)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTimerInt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarGridScale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarMatrixJump;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarTimerInt;
    }
}

