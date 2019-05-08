namespace WindowsFormsApp1
{
    partial class mainForm
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
            this.grpboxInstruction = new System.Windows.Forms.GroupBox();
            this.lblTestingToolDir = new System.Windows.Forms.Label();
            this.lblSolutionDir = new System.Windows.Forms.Label();
            this.txtTestingToolDir = new System.Windows.Forms.TextBox();
            this.txtSolutionFileDir = new System.Windows.Forms.TextBox();
            this.btnTestingDirSelector = new System.Windows.Forms.Button();
            this.btnSolutionDirSelector = new System.Windows.Forms.Button();
            this.txtVerdict = new System.Windows.Forms.TextBox();
            this.btnJudge = new System.Windows.Forms.Button();
            this.rbtn1 = new System.Windows.Forms.RadioButton();
            this.rbtn2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.grpboxInstruction.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxInstruction
            // 
            this.grpboxInstruction.Controls.Add(this.lblInstruction);
            this.grpboxInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxInstruction.Location = new System.Drawing.Point(8, 8);
            this.grpboxInstruction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpboxInstruction.Name = "grpboxInstruction";
            this.grpboxInstruction.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpboxInstruction.Size = new System.Drawing.Size(622, 106);
            this.grpboxInstruction.TabIndex = 0;
            this.grpboxInstruction.TabStop = false;
            this.grpboxInstruction.Text = "Steps to do:";
            // 
            // lblTestingToolDir
            // 
            this.lblTestingToolDir.AutoSize = true;
            this.lblTestingToolDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestingToolDir.Location = new System.Drawing.Point(5, 116);
            this.lblTestingToolDir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTestingToolDir.Name = "lblTestingToolDir";
            this.lblTestingToolDir.Size = new System.Drawing.Size(133, 16);
            this.lblTestingToolDir.TabIndex = 1;
            this.lblTestingToolDir.Text = "Testing Tool (.py file)";
            // 
            // lblSolutionDir
            // 
            this.lblSolutionDir.AutoSize = true;
            this.lblSolutionDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolutionDir.Location = new System.Drawing.Point(325, 116);
            this.lblSolutionDir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSolutionDir.Name = "lblSolutionDir";
            this.lblSolutionDir.Size = new System.Drawing.Size(118, 16);
            this.lblSolutionDir.TabIndex = 2;
            this.lblSolutionDir.Text = "Solution File (.cpp)";
            // 
            // txtTestingToolDir
            // 
            this.txtTestingToolDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestingToolDir.Location = new System.Drawing.Point(8, 140);
            this.txtTestingToolDir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTestingToolDir.Name = "txtTestingToolDir";
            this.txtTestingToolDir.Size = new System.Drawing.Size(268, 22);
            this.txtTestingToolDir.TabIndex = 3;
            // 
            // txtSolutionFileDir
            // 
            this.txtSolutionFileDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolutionFileDir.Location = new System.Drawing.Point(328, 140);
            this.txtSolutionFileDir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSolutionFileDir.Name = "txtSolutionFileDir";
            this.txtSolutionFileDir.Size = new System.Drawing.Size(268, 22);
            this.txtSolutionFileDir.TabIndex = 5;
            // 
            // btnTestingDirSelector
            // 
            this.btnTestingDirSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestingDirSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestingDirSelector.Location = new System.Drawing.Point(280, 140);
            this.btnTestingDirSelector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTestingDirSelector.Name = "btnTestingDirSelector";
            this.btnTestingDirSelector.Size = new System.Drawing.Size(30, 22);
            this.btnTestingDirSelector.TabIndex = 4;
            this.btnTestingDirSelector.Text = "...";
            this.btnTestingDirSelector.UseVisualStyleBackColor = true;
            this.btnTestingDirSelector.Click += new System.EventHandler(this.btnTestingDirSelector_Click);
            // 
            // btnSolutionDirSelector
            // 
            this.btnSolutionDirSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolutionDirSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolutionDirSelector.Location = new System.Drawing.Point(600, 140);
            this.btnSolutionDirSelector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSolutionDirSelector.Name = "btnSolutionDirSelector";
            this.btnSolutionDirSelector.Size = new System.Drawing.Size(30, 22);
            this.btnSolutionDirSelector.TabIndex = 6;
            this.btnSolutionDirSelector.Text = "...";
            this.btnSolutionDirSelector.UseVisualStyleBackColor = true;
            this.btnSolutionDirSelector.Click += new System.EventHandler(this.btnSolutionDirSelector_Click);
            // 
            // txtVerdict
            // 
            this.txtVerdict.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerdict.Location = new System.Drawing.Point(8, 221);
            this.txtVerdict.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVerdict.Multiline = true;
            this.txtVerdict.Name = "txtVerdict";
            this.txtVerdict.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVerdict.Size = new System.Drawing.Size(622, 132);
            this.txtVerdict.TabIndex = 9;
            // 
            // btnJudge
            // 
            this.btnJudge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJudge.Location = new System.Drawing.Point(220, 357);
            this.btnJudge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnJudge.Name = "btnJudge";
            this.btnJudge.Size = new System.Drawing.Size(198, 41);
            this.btnJudge.TabIndex = 10;
            this.btnJudge.Text = "JUDGE";
            this.btnJudge.UseVisualStyleBackColor = true;
            this.btnJudge.Click += new System.EventHandler(this.btnJudge_Click);
            // 
            // rbtn1
            // 
            this.rbtn1.AutoSize = true;
            this.rbtn1.Checked = true;
            this.rbtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn1.Location = new System.Drawing.Point(8, 167);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.Size = new System.Drawing.Size(84, 20);
            this.rbtn1.TabIndex = 7;
            this.rbtn1.TabStop = true;
            this.rbtn1.Text = "Test set 1";
            this.rbtn1.UseVisualStyleBackColor = true;
            // 
            // rbtn2
            // 
            this.rbtn2.AutoSize = true;
            this.rbtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn2.Location = new System.Drawing.Point(328, 167);
            this.rbtn2.Name = "rbtn2";
            this.rbtn2.Size = new System.Drawing.Size(84, 20);
            this.rbtn2.TabIndex = 8;
            this.rbtn2.Text = "Test set 2";
            this.rbtn2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Verdict";
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(7, 17);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(80, 15);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = "Lorem ipsum";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtn2);
            this.Controls.Add(this.rbtn1);
            this.Controls.Add(this.btnJudge);
            this.Controls.Add(this.txtVerdict);
            this.Controls.Add(this.btnSolutionDirSelector);
            this.Controls.Add(this.btnTestingDirSelector);
            this.Controls.Add(this.txtSolutionFileDir);
            this.Controls.Add(this.txtTestingToolDir);
            this.Controls.Add(this.lblSolutionDir);
            this.Controls.Add(this.lblTestingToolDir);
            this.Controls.Add(this.grpboxInstruction);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "mainForm";
            this.Text = "Interactive GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpboxInstruction.ResumeLayout(false);
            this.grpboxInstruction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxInstruction;
        private System.Windows.Forms.Label lblTestingToolDir;
        private System.Windows.Forms.Label lblSolutionDir;
        private System.Windows.Forms.TextBox txtTestingToolDir;
        private System.Windows.Forms.TextBox txtSolutionFileDir;
        private System.Windows.Forms.Button btnTestingDirSelector;
        private System.Windows.Forms.Button btnSolutionDirSelector;
        private System.Windows.Forms.TextBox txtVerdict;
        private System.Windows.Forms.Button btnJudge;
        private System.Windows.Forms.RadioButton rbtn1;
        private System.Windows.Forms.RadioButton rbtn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInstruction;
    }
}

