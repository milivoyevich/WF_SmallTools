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
            this.lblNumer = new System.Windows.Forms.Label();
            this.lblBroj = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRegions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.btnDataSet = new System.Windows.Forms.Button();
            this.btnTabela = new System.Windows.Forms.Button();
            this.dgProcedure = new System.Windows.Forms.DataGrid();
            this.tpBaze = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBaza1 = new System.Windows.Forms.ComboBox();
            this.cbServer1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBaza0 = new System.Windows.Forms.ComboBox();
            this.cbServer0 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSpisakServera = new System.Windows.Forms.Button();
            this.dsProject1 = new WF_SmallTools.dsProject();
            this.tcExamples.SuspendLayout();
            this.tpProcedure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProcedure)).BeginInit();
            this.tpBaze.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsProject1)).BeginInit();
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
            this.tcExamples.Controls.Add(this.tpBaze);
            this.tcExamples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcExamples.Location = new System.Drawing.Point(0, 24);
            this.tcExamples.Name = "tcExamples";
            this.tcExamples.SelectedIndex = 0;
            this.tcExamples.Size = new System.Drawing.Size(643, 453);
            this.tcExamples.TabIndex = 2;
            this.tcExamples.SelectedIndexChanged += new System.EventHandler(this.tcExamples_SelectedIndexChanged);
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
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(50, 26);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(187, 21);
            this.cbCategories.TabIndex = 3;
            this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.cbCategories_SelectedIndexChanged);
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
            this.dgProcedure.Size = new System.Drawing.Size(510, 307);
            this.dgProcedure.TabIndex = 0;
            // 
            // tpBaze
            // 
            this.tpBaze.BackColor = System.Drawing.Color.RosyBrown;
            this.tpBaze.Controls.Add(this.btnSpisakServera);
            this.tpBaze.Controls.Add(this.label7);
            this.tpBaze.Controls.Add(this.dataGridView1);
            this.tpBaze.Controls.Add(this.groupBox2);
            this.tpBaze.Controls.Add(this.groupBox1);
            this.tpBaze.Location = new System.Drawing.Point(4, 22);
            this.tpBaze.Name = "tpBaze";
            this.tpBaze.Padding = new System.Windows.Forms.Padding(3);
            this.tpBaze.Size = new System.Drawing.Size(635, 427);
            this.tpBaze.TabIndex = 1;
            this.tpBaze.Text = "Поређење база";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 222);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbBaza1);
            this.groupBox2.Controls.Add(this.cbServer1);
            this.groupBox2.Location = new System.Drawing.Point(334, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 83);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тестна база";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(159, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "База";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(23, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Сервер";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbBaza1
            // 
            this.cbBaza1.FormattingEnabled = true;
            this.cbBaza1.Location = new System.Drawing.Point(162, 43);
            this.cbBaza1.Name = "cbBaza1";
            this.cbBaza1.Size = new System.Drawing.Size(121, 21);
            this.cbBaza1.TabIndex = 1;
            // 
            // cbServer1
            // 
            this.cbServer1.FormattingEnabled = true;
            this.cbServer1.Location = new System.Drawing.Point(6, 43);
            this.cbServer1.Name = "cbServer1";
            this.cbServer1.Size = new System.Drawing.Size(150, 21);
            this.cbServer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbBaza0);
            this.groupBox1.Controls.Add(this.cbServer0);
            this.groupBox1.Location = new System.Drawing.Point(10, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Контролна база";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(159, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "База";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(23, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сервер";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbBaza0
            // 
            this.cbBaza0.FormattingEnabled = true;
            this.cbBaza0.Location = new System.Drawing.Point(164, 43);
            this.cbBaza0.Name = "cbBaza0";
            this.cbBaza0.Size = new System.Drawing.Size(131, 21);
            this.cbBaza0.TabIndex = 1;
            // 
            // cbServer0
            // 
            this.cbServer0.FormattingEnabled = true;
            this.cbServer0.Location = new System.Drawing.Point(8, 43);
            this.cbServer0.Name = "cbServer0";
            this.cbServer0.Size = new System.Drawing.Size(150, 21);
            this.cbServer0.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Списак аутодетектованих сервера";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSpisakServera
            // 
            this.btnSpisakServera.BackColor = System.Drawing.Color.MistyRose;
            this.btnSpisakServera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpisakServera.Location = new System.Drawing.Point(10, 374);
            this.btnSpisakServera.Name = "btnSpisakServera";
            this.btnSpisakServera.Size = new System.Drawing.Size(167, 27);
            this.btnSpisakServera.TabIndex = 4;
            this.btnSpisakServera.Text = "Додавање сервера на листу";
            this.btnSpisakServera.UseVisualStyleBackColor = false;
            this.btnSpisakServera.Click += new System.EventHandler(this.btnSpisakServera_Click);
            // 
            // dsProject1
            // 
            this.dsProject1.DataSetName = "dsProject";
            this.dsProject1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msGlavni;
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.tcExamples.ResumeLayout(false);
            this.tpProcedure.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProcedure)).EndInit();
            this.tpBaze.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsProject1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msGlavni;
        private System.Windows.Forms.StatusStrip ssGlavni;
        private System.Windows.Forms.TabControl tcExamples;
        private System.Windows.Forms.TabPage tpProcedure;
        private System.Windows.Forms.TabPage tpBaze;
        private System.Windows.Forms.Button btnDataSet;
        private System.Windows.Forms.Button btnTabela;
        private System.Windows.Forms.DataGrid dgProcedure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRegions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Label lblNumer;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBaza1;
        private System.Windows.Forms.ComboBox cbServer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBaza0;
        private System.Windows.Forms.ComboBox cbServer0;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSpisakServera;
        private System.Windows.Forms.Label label7;
        private dsProject dsProject1;
    }
}

