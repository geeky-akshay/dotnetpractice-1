namespace SearchDemo
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowPanelSearchCriterias = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddNewCriteria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(468, 266);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 24);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 122);
            this.label1.TabIndex = 1;
            this.label1.Text = "Output";
            // 
            // flowPanelSearchCriterias
            // 
            this.flowPanelSearchCriterias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPanelSearchCriterias.Location = new System.Drawing.Point(12, 12);
            this.flowPanelSearchCriterias.Name = "flowPanelSearchCriterias";
            this.flowPanelSearchCriterias.Size = new System.Drawing.Size(547, 248);
            this.flowPanelSearchCriterias.TabIndex = 2;
            // 
            // btnAddNewCriteria
            // 
            this.btnAddNewCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewCriteria.Location = new System.Drawing.Point(565, 12);
            this.btnAddNewCriteria.Name = "btnAddNewCriteria";
            this.btnAddNewCriteria.Size = new System.Drawing.Size(28, 22);
            this.btnAddNewCriteria.TabIndex = 3;
            this.btnAddNewCriteria.Text = "+";
            this.btnAddNewCriteria.UseVisualStyleBackColor = true;
            this.btnAddNewCriteria.Click += new System.EventHandler(this.btnAddNewCriteria_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 424);
            this.Controls.Add(this.btnAddNewCriteria);
            this.Controls.Add(this.flowPanelSearchCriterias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowPanelSearchCriterias;
        private System.Windows.Forms.Button btnAddNewCriteria;
    }
}

