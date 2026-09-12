namespace Random_Generato_project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblresulttitle = new System.Windows.Forms.Label();
            this.lblreslt = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.btngenrate = new System.Windows.Forms.Button();
            this.btnrestar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.rdMix = new System.Windows.Forms.RadioButton();
            this.rdNumbers = new System.Windows.Forms.RadioButton();
            this.rdspecialcharchter = new System.Windows.Forms.RadioButton();
            this.rdleters = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblresulttitle
            // 
            this.lblresulttitle.AutoSize = true;
            this.lblresulttitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresulttitle.Location = new System.Drawing.Point(379, 46);
            this.lblresulttitle.Name = "lblresulttitle";
            this.lblresulttitle.Size = new System.Drawing.Size(160, 55);
            this.lblresulttitle.TabIndex = 0;
            this.lblresulttitle.Text = "Result";
            // 
            // lblreslt
            // 
            this.lblreslt.AutoSize = true;
            this.lblreslt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreslt.Location = new System.Drawing.Point(379, 132);
            this.lblreslt.Name = "lblreslt";
            this.lblreslt.Size = new System.Drawing.Size(0, 55);
            this.lblreslt.TabIndex = 1;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(379, 132);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(160, 55);
            this.lblresult.TabIndex = 2;
            this.lblresult.Text = "Result";
            // 
            // btngenrate
            // 
            this.btngenrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btngenrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btngenrate.Location = new System.Drawing.Point(213, 516);
            this.btngenrate.Name = "btngenrate";
            this.btngenrate.Size = new System.Drawing.Size(166, 54);
            this.btngenrate.TabIndex = 3;
            this.btngenrate.Text = "Generate";
            this.btngenrate.UseVisualStyleBackColor = false;
            this.btngenrate.Click += new System.EventHandler(this.btngenrate_Click);
            // 
            // btnrestar
            // 
            this.btnrestar.BackColor = System.Drawing.Color.Yellow;
            this.btnrestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrestar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnrestar.Location = new System.Drawing.Point(554, 516);
            this.btnrestar.Name = "btnrestar";
            this.btnrestar.Size = new System.Drawing.Size(166, 54);
            this.btnrestar.TabIndex = 4;
            this.btnrestar.Text = "Reset";
            this.btnrestar.UseVisualStyleBackColor = false;
            this.btnrestar.Click += new System.EventHandler(this.btnrestar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cyan;
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdMix);
            this.groupBox1.Controls.Add(this.rdNumbers);
            this.groupBox1.Controls.Add(this.rdspecialcharchter);
            this.groupBox1.Controls.Add(this.rdleters);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(213, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 225);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.Cyan;
            this.numericUpDown1.Location = new System.Drawing.Point(328, 33);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(136, 44);
            this.numericUpDown1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number Of Degits";
            // 
            // rdMix
            // 
            this.rdMix.AutoSize = true;
            this.rdMix.Location = new System.Drawing.Point(328, 166);
            this.rdMix.Name = "rdMix";
            this.rdMix.Size = new System.Drawing.Size(90, 41);
            this.rdMix.TabIndex = 3;
            this.rdMix.TabStop = true;
            this.rdMix.Text = "Mix";
            this.rdMix.UseVisualStyleBackColor = true;
            this.rdMix.CheckedChanged += new System.EventHandler(this.rdMix_CheckedChanged);
            // 
            // rdNumbers
            // 
            this.rdNumbers.AutoSize = true;
            this.rdNumbers.Location = new System.Drawing.Point(328, 107);
            this.rdNumbers.Name = "rdNumbers";
            this.rdNumbers.Size = new System.Drawing.Size(173, 41);
            this.rdNumbers.TabIndex = 2;
            this.rdNumbers.TabStop = true;
            this.rdNumbers.Text = "Numbers";
            this.rdNumbers.UseVisualStyleBackColor = true;
            this.rdNumbers.CheckedChanged += new System.EventHandler(this.rdNumbers_CheckedChanged);
            // 
            // rdspecialcharchter
            // 
            this.rdspecialcharchter.AutoSize = true;
            this.rdspecialcharchter.Location = new System.Drawing.Point(26, 166);
            this.rdspecialcharchter.Name = "rdspecialcharchter";
            this.rdspecialcharchter.Size = new System.Drawing.Size(296, 41);
            this.rdspecialcharchter.TabIndex = 1;
            this.rdspecialcharchter.TabStop = true;
            this.rdspecialcharchter.Text = "Special Charchter";
            this.rdspecialcharchter.UseVisualStyleBackColor = true;
            this.rdspecialcharchter.CheckedChanged += new System.EventHandler(this.rdspecialcharchter_CheckedChanged);
            // 
            // rdleters
            // 
            this.rdleters.AutoSize = true;
            this.rdleters.ContextMenuStrip = this.contextMenuStrip1;
            this.rdleters.Location = new System.Drawing.Point(26, 107);
            this.rdleters.Name = "rdleters";
            this.rdleters.Size = new System.Drawing.Size(139, 41);
            this.rdleters.TabIndex = 0;
            this.rdleters.TabStop = true;
            this.rdleters.Text = "Letters";
            this.rdleters.UseVisualStyleBackColor = true;
            this.rdleters.CheckedChanged += new System.EventHandler(this.rdleters_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(196, 68);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(240, 32);
            this.toolStripMenuItem1.Text = "Capital Letters";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(240, 32);
            this.toolStripMenuItem2.Text = "Small Letters";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(813, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 55);
            this.label2.TabIndex = 6;
            this.label2.Text = "Close";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(972, 643);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnrestar);
            this.Controls.Add(this.btngenrate);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblreslt);
            this.Controls.Add(this.lblresulttitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblresulttitle;
        private System.Windows.Forms.Label lblreslt;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btngenrate;
        private System.Windows.Forms.Button btnrestar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdMix;
        private System.Windows.Forms.RadioButton rdNumbers;
        private System.Windows.Forms.RadioButton rdspecialcharchter;
        private System.Windows.Forms.RadioButton rdleters;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
    }
}

