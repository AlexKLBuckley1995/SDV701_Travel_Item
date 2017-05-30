namespace SDV701_assignment_2
{
    partial class frmEditLocation
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
            this.lblLocationName = new System.Windows.Forms.Label();
            this.lblLocationDescription = new System.Windows.Forms.Label();
            this.txtMapName = new System.Windows.Forms.TextBox();
            this.btnLocationClose = new System.Windows.Forms.Button();
            this.rtxtLocationDescription = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Location = new System.Drawing.Point(12, 40);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(35, 13);
            this.lblLocationName.TabIndex = 2;
            this.lblLocationName.Text = "Name";
            // 
            // lblLocationDescription
            // 
            this.lblLocationDescription.AutoSize = true;
            this.lblLocationDescription.Location = new System.Drawing.Point(12, 87);
            this.lblLocationDescription.Name = "lblLocationDescription";
            this.lblLocationDescription.Size = new System.Drawing.Size(60, 13);
            this.lblLocationDescription.TabIndex = 3;
            this.lblLocationDescription.Text = "Description";
            // 
            // txtMapName
            // 
            this.txtMapName.Location = new System.Drawing.Point(69, 40);
            this.txtMapName.Name = "txtMapName";
            this.txtMapName.Size = new System.Drawing.Size(100, 20);
            this.txtMapName.TabIndex = 8;
            this.txtMapName.Text = "Southern Africa";
            // 
            // btnLocationClose
            // 
            this.btnLocationClose.Location = new System.Drawing.Point(211, 202);
            this.btnLocationClose.Name = "btnLocationClose";
            this.btnLocationClose.Size = new System.Drawing.Size(75, 23);
            this.btnLocationClose.TabIndex = 19;
            this.btnLocationClose.Text = "Close";
            this.btnLocationClose.UseVisualStyleBackColor = true;
            // 
            // rtxtLocationDescription
            // 
            this.rtxtLocationDescription.Location = new System.Drawing.Point(69, 84);
            this.rtxtLocationDescription.Name = "rtxtLocationDescription";
            this.rtxtLocationDescription.Size = new System.Drawing.Size(160, 96);
            this.rtxtLocationDescription.TabIndex = 20;
            this.rtxtLocationDescription.Text = "This region includes South Africa, Lesotho, Swaziland, Mozambique, Zambia, Zimbab" +
    "we, Botswana and Namibia";
            // 
            // frmEditLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 246);
            this.Controls.Add(this.rtxtLocationDescription);
            this.Controls.Add(this.btnLocationClose);
            this.Controls.Add(this.txtMapName);
            this.Controls.Add(this.lblLocationDescription);
            this.Controls.Add(this.lblLocationName);
            this.Name = "frmEditLocation";
            this.Text = "Add/Edit Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.Label lblLocationDescription;
        private System.Windows.Forms.TextBox txtMapName;
        private System.Windows.Forms.Button btnLocationClose;
        private System.Windows.Forms.RichTextBox rtxtLocationDescription;
    }
}