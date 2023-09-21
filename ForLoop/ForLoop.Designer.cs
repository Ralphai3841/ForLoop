
namespace ForLoop
{
    partial class ForLoop
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
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lstEvenNumbers = new System.Windows.Forms.ListBox();
            this.btnSelectEvenNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.ItemHeight = 16;
            this.lstNumbers.Location = new System.Drawing.Point(109, 111);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(296, 340);
            this.lstNumbers.TabIndex = 0;
            // 
            // lstEvenNumbers
            // 
            this.lstEvenNumbers.FormattingEnabled = true;
            this.lstEvenNumbers.ItemHeight = 16;
            this.lstEvenNumbers.Location = new System.Drawing.Point(654, 111);
            this.lstEvenNumbers.Name = "lstEvenNumbers";
            this.lstEvenNumbers.Size = new System.Drawing.Size(305, 340);
            this.lstEvenNumbers.TabIndex = 1;
            this.lstEvenNumbers.SelectedIndexChanged += new System.EventHandler(this.lstEvenNumbers_SelectedIndexChanged);
            // 
            // btnSelectEvenNumber
            // 
            this.btnSelectEvenNumber.Location = new System.Drawing.Point(443, 247);
            this.btnSelectEvenNumber.Name = "btnSelectEvenNumber";
            this.btnSelectEvenNumber.Size = new System.Drawing.Size(157, 78);
            this.btnSelectEvenNumber.TabIndex = 2;
            this.btnSelectEvenNumber.Text = "=>";
            this.btnSelectEvenNumber.UseVisualStyleBackColor = true;
            this.btnSelectEvenNumber.Click += new System.EventHandler(this.btnSelectEvenNumber_Click);
            // 
            // ForLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 581);
            this.Controls.Add(this.btnSelectEvenNumber);
            this.Controls.Add(this.lstEvenNumbers);
            this.Controls.Add(this.lstNumbers);
            this.Name = "ForLoop";
            this.Text = "ForLoop";
            this.Load += new System.EventHandler(this.ForLoop_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.ListBox lstEvenNumbers;
        private System.Windows.Forms.Button btnSelectEvenNumber;
    }
}