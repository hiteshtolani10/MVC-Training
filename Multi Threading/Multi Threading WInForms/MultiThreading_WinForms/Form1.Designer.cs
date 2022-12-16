namespace MultiThreading_WinForms
{
    partial class MultiThreading
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
            this.btn_freeze = new System.Windows.Forms.Button();
            this.btn_printList = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_freeze
            // 
            this.btn_freeze.Location = new System.Drawing.Point(119, 87);
            this.btn_freeze.Name = "btn_freeze";
            this.btn_freeze.Size = new System.Drawing.Size(125, 26);
            this.btn_freeze.TabIndex = 0;
            this.btn_freeze.Text = "Task 1 (Freeze)";
            this.btn_freeze.UseVisualStyleBackColor = true;
            this.btn_freeze.Click += new System.EventHandler(this.btn_freeze_Click);
            // 
            // btn_printList
            // 
            this.btn_printList.Location = new System.Drawing.Point(119, 137);
            this.btn_printList.Name = "btn_printList";
            this.btn_printList.Size = new System.Drawing.Size(125, 24);
            this.btn_printList.TabIndex = 1;
            this.btn_printList.Text = "Task 2 (Print List)";
            this.btn_printList.UseVisualStyleBackColor = true;
            this.btn_printList.Click += new System.EventHandler(this.btn_printList_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(101, 185);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(160, 186);
            this.listBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Multi Threading Example";
            // 
            // MultiThreading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 408);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btn_printList);
            this.Controls.Add(this.btn_freeze);
            this.Name = "MultiThreading";
            this.Text = "Multi Threading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_freeze;
        private System.Windows.Forms.Button btn_printList;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
    }
}

