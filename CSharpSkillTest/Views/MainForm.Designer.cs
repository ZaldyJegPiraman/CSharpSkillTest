namespace CSharpSkillTest.Views
{
    partial class MainForm
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
            splitContainer1 = new SplitContainer();
            lblStrategy = new Label();
            lblInput = new Label();
            cboStrategy = new ComboBox();
            txtInput = new TextBox();
            btnSort = new Button();
            lblOutput = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Location = new Point(16, 20);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lblStrategy);
            splitContainer1.Panel1.Controls.Add(lblInput);
            splitContainer1.Panel1.Controls.Add(cboStrategy);
            splitContainer1.Panel1.Controls.Add(txtInput);
            splitContainer1.Panel1.Controls.Add(btnSort);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lblOutput);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(601, 323);
            splitContainer1.SplitterDistance = 106;
            splitContainer1.TabIndex = 6;
            // 
            // lblStrategy
            // 
            lblStrategy.AutoSize = true;
            lblStrategy.Location = new Point(14, 53);
            lblStrategy.Name = "lblStrategy";
            lblStrategy.Size = new Size(65, 15);
            lblStrategy.TabIndex = 10;
            lblStrategy.Text = "STRATEGY:";
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(14, 26);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(44, 15);
            lblInput.TabIndex = 9;
            lblInput.Text = "INPUT:";
            // 
            // cboStrategy
            // 
            cboStrategy.FormattingEnabled = true;
            cboStrategy.Location = new Point(81, 50);
            cboStrategy.Name = "cboStrategy";
            cboStrategy.Size = new Size(348, 23);
            cboStrategy.TabIndex = 8;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(81, 21);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(348, 23);
            txtInput.TabIndex = 7;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(435, 21);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(111, 51);
            btnSort.TabIndex = 6;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click_1;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutput.ForeColor = Color.Red;
            lblOutput.Location = new Point(14, 18);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(58, 15);
            lblOutput.TabIndex = 2;
            lblOutput.Text = "OUTPUT:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 383);
            Controls.Add(splitContainer1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label lblStrategy;
        private Label lblInput;
        private ComboBox cboStrategy;
        private TextBox txtInput;
        private Button btnSort;
        private Label lblOutput;
    }
}