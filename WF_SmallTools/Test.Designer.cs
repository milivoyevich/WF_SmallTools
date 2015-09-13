namespace WF_SmallTools
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.msGlavni = new System.Windows.Forms.MenuStrip();
            this.ssGlavni = new System.Windows.Forms.StatusStrip();
            this.tcExamples = new System.Windows.Forms.TabControl();
            this.tpProcedure = new System.Windows.Forms.TabPage();
            this.tpExample = new System.Windows.Forms.TabPage();
            this.tcExamples.SuspendLayout();
            this.SuspendLayout();
            // 
            // msGlavni
            // 
            this.msGlavni.BackColor = System.Drawing.Color.Transparent;
            this.msGlavni.Location = new System.Drawing.Point(0, 0);
            this.msGlavni.Name = "msGlavni";
            this.msGlavni.Size = new System.Drawing.Size(653, 24);
            this.msGlavni.TabIndex = 0;
            this.msGlavni.Text = "menuStrip1";
            // 
            // ssGlavni
            // 
            this.ssGlavni.Location = new System.Drawing.Point(0, 477);
            this.ssGlavni.Name = "ssGlavni";
            this.ssGlavni.Size = new System.Drawing.Size(653, 22);
            this.ssGlavni.TabIndex = 1;
            this.ssGlavni.Text = "statusStrip1";
            // 
            // tcExamples
            // 
            this.tcExamples.Controls.Add(this.tpProcedure);
            this.tcExamples.Controls.Add(this.tpExample);
            this.tcExamples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcExamples.Location = new System.Drawing.Point(0, 24);
            this.tcExamples.Name = "tcExamples";
            this.tcExamples.SelectedIndex = 0;
            this.tcExamples.Size = new System.Drawing.Size(653, 453);
            this.tcExamples.TabIndex = 2;
            // 
            // tpProcedure
            // 
            this.tpProcedure.BackColor = System.Drawing.Color.Gray;
            this.tpProcedure.Location = new System.Drawing.Point(4, 22);
            this.tpProcedure.Name = "tpProcedure";
            this.tpProcedure.Padding = new System.Windows.Forms.Padding(3);
            this.tpProcedure.Size = new System.Drawing.Size(645, 427);
            this.tpProcedure.TabIndex = 0;
            this.tpProcedure.Text = "Ускладиштене процедуре";
            // 
            // tpExample
            // 
            this.tpExample.BackColor = System.Drawing.Color.RosyBrown;
            this.tpExample.Location = new System.Drawing.Point(4, 22);
            this.tpExample.Name = "tpExample";
            this.tpExample.Padding = new System.Windows.Forms.Padding(3);
            this.tpExample.Size = new System.Drawing.Size(642, 438);
            this.tpExample.TabIndex = 1;
            this.tpExample.Text = "Пример 2";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(653, 499);
            this.Controls.Add(this.tcExamples);
            this.Controls.Add(this.ssGlavni);
            this.Controls.Add(this.msGlavni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msGlavni;
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.tcExamples.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msGlavni;
        private System.Windows.Forms.StatusStrip ssGlavni;
        private System.Windows.Forms.TabControl tcExamples;
        private System.Windows.Forms.TabPage tpProcedure;
        private System.Windows.Forms.TabPage tpExample;
    }
}

