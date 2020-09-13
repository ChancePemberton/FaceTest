namespace Facial_Detection
{
    partial class FacialDetection
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
            this.uxDisplay = new System.Windows.Forms.PictureBox();
            this.uxSelect = new System.Windows.Forms.Button();
            this.uxDeviceBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.uxDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // uxDisplay
            // 
            this.uxDisplay.Location = new System.Drawing.Point(12, 12);
            this.uxDisplay.Name = "uxDisplay";
            this.uxDisplay.Size = new System.Drawing.Size(557, 426);
            this.uxDisplay.TabIndex = 0;
            this.uxDisplay.TabStop = false;
            // 
            // uxSelect
            // 
            this.uxSelect.Location = new System.Drawing.Point(648, 232);
            this.uxSelect.Name = "uxSelect";
            this.uxSelect.Size = new System.Drawing.Size(75, 23);
            this.uxSelect.TabIndex = 1;
            this.uxSelect.Text = "Select";
            this.uxSelect.UseVisualStyleBackColor = true;
            this.uxSelect.Click += new System.EventHandler(this.uxSelect_Click);
            // 
            // uxDeviceBox
            // 
            this.uxDeviceBox.FormattingEnabled = true;
            this.uxDeviceBox.Location = new System.Drawing.Point(575, 205);
            this.uxDeviceBox.Name = "uxDeviceBox";
            this.uxDeviceBox.Size = new System.Drawing.Size(213, 21);
            this.uxDeviceBox.TabIndex = 2;
            // 
            // FacialDetection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxDeviceBox);
            this.Controls.Add(this.uxSelect);
            this.Controls.Add(this.uxDisplay);
            this.Name = "FacialDetection";
            this.Text = "Facial Detection";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FacialDetection_FormClosing);
            this.Load += new System.EventHandler(this.FacialDetection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox uxDisplay;
        private System.Windows.Forms.Button uxSelect;
        private System.Windows.Forms.ComboBox uxDeviceBox;
    }
}

