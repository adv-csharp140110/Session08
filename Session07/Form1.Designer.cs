namespace Session07
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonProductList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonProductList
            // 
            this.buttonProductList.Location = new System.Drawing.Point(12, 12);
            this.buttonProductList.Name = "buttonProductList";
            this.buttonProductList.Size = new System.Drawing.Size(139, 36);
            this.buttonProductList.TabIndex = 0;
            this.buttonProductList.Text = "Product List";
            this.buttonProductList.UseVisualStyleBackColor = true;
            this.buttonProductList.Click += new System.EventHandler(this.buttonProductList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 528);
            this.Controls.Add(this.buttonProductList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonProductList;
    }
}