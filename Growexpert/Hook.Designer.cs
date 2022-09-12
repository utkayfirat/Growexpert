namespace Growexpert
{
    partial class Hook
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
            this.clickOnePanel = new System.Windows.Forms.Panel();
            this.clickTwoPanel = new System.Windows.Forms.Panel();
            this.clickThreePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clickOnePanel.SuspendLayout();
            this.clickTwoPanel.SuspendLayout();
            this.clickThreePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // clickOnePanel
            // 
            this.clickOnePanel.BackColor = System.Drawing.Color.Blue;
            this.clickOnePanel.Controls.Add(this.label1);
            this.clickOnePanel.Location = new System.Drawing.Point(31, 33);
            this.clickOnePanel.Name = "clickOnePanel";
            this.clickOnePanel.Size = new System.Drawing.Size(19, 19);
            this.clickOnePanel.TabIndex = 3;
            // 
            // clickTwoPanel
            // 
            this.clickTwoPanel.BackColor = System.Drawing.Color.Blue;
            this.clickTwoPanel.Controls.Add(this.label2);
            this.clickTwoPanel.Location = new System.Drawing.Point(31, 72);
            this.clickTwoPanel.Name = "clickTwoPanel";
            this.clickTwoPanel.Size = new System.Drawing.Size(19, 19);
            this.clickTwoPanel.TabIndex = 4;
            // 
            // clickThreePanel
            // 
            this.clickThreePanel.BackColor = System.Drawing.Color.Blue;
            this.clickThreePanel.Controls.Add(this.label3);
            this.clickThreePanel.Location = new System.Drawing.Point(31, 112);
            this.clickThreePanel.Name = "clickThreePanel";
            this.clickThreePanel.Size = new System.Drawing.Size(19, 19);
            this.clickThreePanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "3";
            // 
            // Hook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 175);
            this.Controls.Add(this.clickThreePanel);
            this.Controls.Add(this.clickTwoPanel);
            this.Controls.Add(this.clickOnePanel);
            this.Name = "Hook";
            this.Opacity = 0.5D;
            this.clickOnePanel.ResumeLayout(false);
            this.clickOnePanel.PerformLayout();
            this.clickTwoPanel.ResumeLayout(false);
            this.clickTwoPanel.PerformLayout();
            this.clickThreePanel.ResumeLayout(false);
            this.clickThreePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel clickOnePanel;
        private System.Windows.Forms.Panel clickTwoPanel;
        private System.Windows.Forms.Panel clickThreePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}