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
            this.btnDataSet = new System.Windows.Forms.Button();
            this.btnTabela = new System.Windows.Forms.Button();
            this.dgProcedure = new System.Windows.Forms.DataGrid();
            this.tpExample = new System.Windows.Forms.TabPage();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRegions = new System.Windows.Forms.ComboBox();
            this.lblBroj = new System.Windows.Forms.Label();
            this.lblNumer = new System.Windows.Forms.Label();
            this.tcExamples.SuspendLayout();
            this.tpProcedure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProcedure)).BeginInit();
            this.SuspendLayout();
            // 
            // msGlavni
            // 
            this.msGlavni.BackColor = System.Drawing.Color.Goldenrod;
            this.msGlavni.GripMargin = new System.Windows.Forms.Padding(0);
            this.msGlavni.Location = new System.Drawing.Point(0, 0);
            this.msGlavni.Name = "msGlavni";
            this.msGlavni.Padding = new System.Windows.Forms.Padding(2);
            this.msGlavni.Size = new System.Drawing.Size(643, 24);
            this.msGlavni.TabIndex = 0;
            this.msGlavni.Text = "menuStrip1";
            // 
            // ssGlavni
            // 
            this.ssGlavni.Location = new System.Drawing.Point(0, 477);
            this.ssGlavni.Name = "ssGlavni";
            this.ssGlavni.Size = new System.Drawing.Size(643, 22);
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
            this.tcExamples.Size = new System.Drawing.Size(643, 453);
            this.tcExamples.TabIndex = 2;
            // 
            // tpProcedure
            // 
            this.tpProcedure.BackColor = System.Drawing.Color.Gray;
            this.tpProcedure.Controls.Add(this.lblNumer);
            this.tpProcedure.Controls.Add(this.lblBroj);
            this.tpProcedure.Controls.Add(this.label2);
            this.tpProcedure.Controls.Add(this.cbRegions);
            this.tpProcedure.Controls.Add(this.label1);
            this.tpProcedure.Controls.Add(this.cbCategories);
            this.tpProcedure.Controls.Add(this.btnDataSet);
            this.tpProcedure.Controls.Add(this.btnTabela);
            this.tpProcedure.Controls.Add(this.dgProcedure);
            this.tpProcedure.Location = new System.Drawing.Point(4, 22);
            this.tpProcedure.Name = "tpProcedure";
            this.tpProcedure.Padding = new System.Windows.Forms.Padding(3);
            this.tpProcedure.Size = new System.Drawing.Size(635, 427);
            this.tpProcedure.TabIndex = 0;
            this.tpProcedure.Text = "Ускладиштене процедуре";
            // 
            // btnDataSet
            // 
            this.btnDataSet.Location = new System.Drawing.Point(50, 375);
            this.btnDataSet.Name = "btnDataSet";
            this.btnDataSet.Size = new System.Drawing.Size(106, 23);
            this.btnDataSet.TabIndex = 2;
            this.btnDataSet.Text = "Врати Датасет";
            this.btnDataSet.UseVisualStyleBackColor = true;
            this.btnDataSet.Click += new System.EventHandler(this.btnDataSet_Click);
            // 
            // btnTabela
            // 
            this.btnTabela.Location = new System.Drawing.Point(454, 375);
            this.btnTabela.Name = "btnTabela";
            this.btnTabela.Size = new System.Drawing.Size(106, 23);
            this.btnTabela.TabIndex = 1;
            this.btnTabela.Text = "Врати Табелу";
            this.btnTabela.UseVisualStyleBackColor = true;
            this.btnTabela.Click += new System.EventHandler(this.btnTabela_Click);
            // 
            // dgProcedure
            // 
            this.dgProcedure.DataMember = "";
            this.dgProcedure.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgProcedure.Location = new System.Drawing.Point(50, 62);
            this.dgProcedure.Name = "dgProcedure";
            this.dgProcedure.Size = new System.Drawing.Size(510, 287);
            this.dgProcedure.TabIndex = 0;
            // 
            // tpExample
            // 
            this.tpExample.BackColor = System.Drawing.Color.RosyBrown;
            this.tpExample.Location = new System.Drawing.Point(4, 22);
            this.tpExample.Name = "tpExample";
            this.tpExample.Padding = new System.Windows.Forms.Padding(3);
            this.tpExample.Size = new System.Drawing.Size(635, 427);
            this.tpExample.TabIndex = 1;
            this.tpExample.Text = "Пример 2";
            // 
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(50, 26);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(187, 21);
            this.cbCategories.TabIndex = 3;
            this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.cbCategories_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Категорије";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(362, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Региони";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbRegions
            // 
            this.cbRegions.FormattingEnabled = true;
            this.cbRegions.Location = new System.Drawing.Point(360, 26);
            this.cbRegions.Name = "cbRegions";
            this.cbRegions.Size = new System.Drawing.Size(200, 21);
            this.cbRegions.TabIndex = 5;
            this.cbRegions.SelectedIndexChanged += new System.EventHandler(this.cbRegions_SelectedIndexChanged);
            // 
            // lblBroj
            // 
            this.lblBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBroj.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBroj.Location = new System.Drawing.Point(240, 29);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(46, 18);
            this.lblBroj.TabIndex = 8;
            this.lblBroj.Text = "0";
            this.lblBroj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumer
            // 
            this.lblNumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumer.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNumer.Location = new System.Drawing.Point(311, 29);
            this.lblNumer.Name = "lblNumer";
            this.lblNumer.Size = new System.Drawing.Size(46, 18);
            this.lblNumer.TabIndex = 9;
            this.lblNumer.Text = "0";
            this.lblNumer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(643, 499);
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
            this.tpProcedure.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProcedure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msGlavni;
        private System.Windows.Forms.StatusStrip ssGlavni;
        private System.Windows.Forms.TabControl tcExamples;
        private System.Windows.Forms.TabPage tpProcedure;
        private System.Windows.Forms.TabPage tpExample;
        private System.Windows.Forms.Button btnDataSet;
        private System.Windows.Forms.Button btnTabela;
        private System.Windows.Forms.DataGrid dgProcedure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRegions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Label lblNumer;
        private System.Windows.Forms.Label lblBroj;
    }
}

