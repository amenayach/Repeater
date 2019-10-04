namespace Repeator
{
    partial class TextTemplateDialog
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblCommaSeperatedList = new System.Windows.Forms.Label();
            this.tbCommaSeperatedList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(642, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 37);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Ca&ncel";
            this.toolTip1.SetToolTip(this.btnCancel, "Escape");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(523, 346);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(111, 37);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "&Ok";
            this.toolTip1.SetToolTip(this.btnOk, "Ctrl+Enter");
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblCommaSeperatedList
            // 
            this.lblCommaSeperatedList.AutoSize = true;
            this.lblCommaSeperatedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblCommaSeperatedList.ForeColor = System.Drawing.Color.White;
            this.lblCommaSeperatedList.Location = new System.Drawing.Point(12, 22);
            this.lblCommaSeperatedList.Name = "lblCommaSeperatedList";
            this.lblCommaSeperatedList.Size = new System.Drawing.Size(183, 22);
            this.lblCommaSeperatedList.TabIndex = 11;
            this.lblCommaSeperatedList.Text = "Comma seperated list";
            // 
            // tbCommaSeperatedList
            // 
            this.tbCommaSeperatedList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCommaSeperatedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tbCommaSeperatedList.Location = new System.Drawing.Point(16, 47);
            this.tbCommaSeperatedList.Multiline = true;
            this.tbCommaSeperatedList.Name = "tbCommaSeperatedList";
            this.tbCommaSeperatedList.Size = new System.Drawing.Size(737, 293);
            this.tbCommaSeperatedList.TabIndex = 0;
            this.tbCommaSeperatedList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCommaSeperatedList_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(12, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Note: use $t in the text template to be replaced with this list";
            // 
            // TextTemplateDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(765, 397);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCommaSeperatedList);
            this.Controls.Add(this.lblCommaSeperatedList);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = global::Repeator.Properties.Resources.Iconsmind_Outline_Code_Window;
            this.KeyPreview = true;
            this.Name = "TextTemplateDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repeator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextTemplateDialog_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblCommaSeperatedList;
        private System.Windows.Forms.TextBox tbCommaSeperatedList;
        private System.Windows.Forms.Label label1;
    }
}