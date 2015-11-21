namespace BinaryTreeCalculator
{
    partial class BinaryTree
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
            this.TreeViewData = new System.Windows.Forms.TreeView();
            this.GenerateTreeButton = new System.Windows.Forms.Button();
            this.TxtData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TreeViewData
            // 
            this.TreeViewData.Location = new System.Drawing.Point(12, 74);
            this.TreeViewData.Name = "TreeViewData";
            this.TreeViewData.Size = new System.Drawing.Size(196, 150);
            this.TreeViewData.TabIndex = 0;
            this.TreeViewData.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewData_AfterSelect);
            // 
            // GenerateTreeButton
            // 
            this.GenerateTreeButton.Location = new System.Drawing.Point(226, 30);
            this.GenerateTreeButton.Name = "GenerateTreeButton";
            this.GenerateTreeButton.Size = new System.Drawing.Size(93, 23);
            this.GenerateTreeButton.TabIndex = 1;
            this.GenerateTreeButton.Text = "Generate Tree";
            this.GenerateTreeButton.UseVisualStyleBackColor = true;
            this.GenerateTreeButton.Click += new System.EventHandler(this.GenerateTreeButton_Click);
            // 
            // TxtData
            // 
            this.TxtData.Location = new System.Drawing.Point(12, 30);
            this.TxtData.Name = "TxtData";
            this.TxtData.Size = new System.Drawing.Size(196, 20);
            this.TxtData.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input Operad and Operation";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(12, 252);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 13);
            this.ResultLabel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result:";
            // 
            // BinaryTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 294);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtData);
            this.Controls.Add(this.GenerateTreeButton);
            this.Controls.Add(this.TreeViewData);
            this.Name = "BinaryTree";
            this.Text = "BirnaryTree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TreeViewData;
        private System.Windows.Forms.Button GenerateTreeButton;
        private System.Windows.Forms.TextBox TxtData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label label2;
    }
}

