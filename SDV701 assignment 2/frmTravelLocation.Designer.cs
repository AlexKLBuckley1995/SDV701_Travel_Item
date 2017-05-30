namespace SDV701_assignment_2
{
    partial class frmTravelLocation
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
            this.btnCategoryClose = new System.Windows.Forms.Button();
            this.lstMapItems = new System.Windows.Forms.ListBox();
            this.btnEditMap = new System.Windows.Forms.Button();
            this.btnDeleteMap = new System.Windows.Forms.Button();
            this.lblMapName = new System.Windows.Forms.Label();
            this.lblMapType = new System.Windows.Forms.Label();
            this.lblMapRegion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCategoryClose
            // 
            this.btnCategoryClose.Location = new System.Drawing.Point(527, 259);
            this.btnCategoryClose.Name = "btnCategoryClose";
            this.btnCategoryClose.Size = new System.Drawing.Size(75, 23);
            this.btnCategoryClose.TabIndex = 0;
            this.btnCategoryClose.Text = "Close";
            this.btnCategoryClose.UseVisualStyleBackColor = true;
            // 
            // lstMapItems
            // 
            this.lstMapItems.FormattingEnabled = true;
            this.lstMapItems.Items.AddRange(new object[] {
            "Europe Guide\t   Book\t\tSouthern Europe\t",
            "Greece Road Map\t   Folded map \tSouthern Europe\t",
            "Top 10 Greece           Book                    Southern Europe     "});
            this.lstMapItems.Location = new System.Drawing.Point(36, 91);
            this.lstMapItems.Name = "lstMapItems";
            this.lstMapItems.Size = new System.Drawing.Size(469, 199);
            this.lstMapItems.TabIndex = 3;
            // 
            // btnEditMap
            // 
            this.btnEditMap.Location = new System.Drawing.Point(527, 184);
            this.btnEditMap.Name = "btnEditMap";
            this.btnEditMap.Size = new System.Drawing.Size(75, 40);
            this.btnEditMap.TabIndex = 4;
            this.btnEditMap.Text = "Add/Edit Item";
            this.btnEditMap.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMap
            // 
            this.btnDeleteMap.Location = new System.Drawing.Point(527, 230);
            this.btnDeleteMap.Name = "btnDeleteMap";
            this.btnDeleteMap.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMap.TabIndex = 5;
            this.btnDeleteMap.Text = "Delete";
            this.btnDeleteMap.UseVisualStyleBackColor = true;
            // 
            // lblMapName
            // 
            this.lblMapName.AutoSize = true;
            this.lblMapName.Location = new System.Drawing.Point(47, 70);
            this.lblMapName.Name = "lblMapName";
            this.lblMapName.Size = new System.Drawing.Size(35, 13);
            this.lblMapName.TabIndex = 6;
            this.lblMapName.Text = "Name";
            // 
            // lblMapType
            // 
            this.lblMapType.AutoSize = true;
            this.lblMapType.Location = new System.Drawing.Point(151, 70);
            this.lblMapType.Name = "lblMapType";
            this.lblMapType.Size = new System.Drawing.Size(31, 13);
            this.lblMapType.TabIndex = 7;
            this.lblMapType.Text = "Type";
            // 
            // lblMapRegion
            // 
            this.lblMapRegion.AutoSize = true;
            this.lblMapRegion.Location = new System.Drawing.Point(251, 70);
            this.lblMapRegion.Name = "lblMapRegion";
            this.lblMapRegion.Size = new System.Drawing.Size(41, 13);
            this.lblMapRegion.TabIndex = 8;
            this.lblMapRegion.Text = "Region";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Southern Europe ";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(397, 70);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Description";
            // 
            // frmTravelLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 318);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMapRegion);
            this.Controls.Add(this.lblMapType);
            this.Controls.Add(this.lblMapName);
            this.Controls.Add(this.btnDeleteMap);
            this.Controls.Add(this.btnEditMap);
            this.Controls.Add(this.lstMapItems);
            this.Controls.Add(this.btnCategoryClose);
            this.Name = "frmTravelLocation";
            this.Text = "View location items";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCategoryClose;
        private System.Windows.Forms.ListBox lstMapItems;
        private System.Windows.Forms.Button btnEditMap;
        private System.Windows.Forms.Button btnDeleteMap;
        private System.Windows.Forms.Label lblMapName;
        private System.Windows.Forms.Label lblMapType;
        private System.Windows.Forms.Label lblMapRegion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescription;
    }
}