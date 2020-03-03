namespace Repeator
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
            this.components = new System.ComponentModel.Container();
            this.tbText = new System.Windows.Forms.RichTextBox();
            this.btnRepeat = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.btnInitialText = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnRepeatOver = new System.Windows.Forms.Button();
            this.btnDefaultTemplate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.SuspendLayout();
            // 
            // tbText
            // 
            this.tbText.AcceptsTab = true;
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.BackColor = System.Drawing.Color.Black;
            this.tbText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbText.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbText.ForeColor = System.Drawing.Color.White;
            this.tbText.Location = new System.Drawing.Point(2, 2);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(912, 384);
            this.tbText.TabIndex = 0;
            this.tbText.Text = "{\n\t\"id\": $i,\n\t\"name\": \"Someone$i\",\n\t\"enabled\": $bool,\n\t\"bit\": $b,\n\t\"guid\": \"$g\",\n" +
    "\t\"date\": new Date($i, 1, 1)\n},\\r\\n";
            this.tbText.TextChanged += new System.EventHandler(this.tbText_TextChanged);
            this.tbText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbText_KeyDown);
            // 
            // btnRepeat
            // 
            this.btnRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRepeat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepeat.ForeColor = System.Drawing.Color.White;
            this.btnRepeat.Location = new System.Drawing.Point(511, 402);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(111, 37);
            this.btnRepeat.TabIndex = 1;
            this.btnRepeat.Text = "&Repeat It!";
            this.toolTip1.SetToolTip(this.btnRepeat, "F5");
            this.btnRepeat.UseVisualStyleBackColor = true;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(252, 409);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(134, 22);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "&Count to repeat";
            // 
            // numCount
            // 
            this.numCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.numCount.Location = new System.Drawing.Point(385, 407);
            this.numCount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(120, 27);
            this.numCount.TabIndex = 3;
            this.toolTip1.SetToolTip(this.numCount, "F4");
            this.numCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnInitialText
            // 
            this.btnInitialText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInitialText.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInitialText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInitialText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitialText.ForeColor = System.Drawing.Color.White;
            this.btnInitialText.Location = new System.Drawing.Point(789, 402);
            this.btnInitialText.Name = "btnInitialText";
            this.btnInitialText.Size = new System.Drawing.Size(111, 37);
            this.btnInitialText.TabIndex = 4;
            this.btnInitialText.Text = "&Initial text";
            this.toolTip1.SetToolTip(this.btnInitialText, "Ctrl+Z");
            this.btnInitialText.UseVisualStyleBackColor = true;
            this.btnInitialText.Click += new System.EventHandler(this.btnInitialText_Click);
            // 
            // btnRepeatOver
            // 
            this.btnRepeatOver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRepeatOver.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRepeatOver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepeatOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepeatOver.ForeColor = System.Drawing.Color.White;
            this.btnRepeatOver.Location = new System.Drawing.Point(628, 402);
            this.btnRepeatOver.Name = "btnRepeatOver";
            this.btnRepeatOver.Size = new System.Drawing.Size(155, 37);
            this.btnRepeatOver.TabIndex = 5;
            this.btnRepeatOver.Text = "Repeat &over...";
            this.toolTip1.SetToolTip(this.btnRepeatOver, "F6");
            this.btnRepeatOver.UseVisualStyleBackColor = true;
            this.btnRepeatOver.Click += new System.EventHandler(this.btnRepeatOver_Click);
            // 
            // btnDefaultTemplate
            // 
            this.btnDefaultTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDefaultTemplate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDefaultTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefaultTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefaultTemplate.ForeColor = System.Drawing.Color.White;
            this.btnDefaultTemplate.Location = new System.Drawing.Point(12, 402);
            this.btnDefaultTemplate.Name = "btnDefaultTemplate";
            this.btnDefaultTemplate.Size = new System.Drawing.Size(111, 37);
            this.btnDefaultTemplate.TabIndex = 7;
            this.btnDefaultTemplate.Text = "&Defaut text";
            this.toolTip1.SetToolTip(this.btnDefaultTemplate, "Ctrl+Z");
            this.btnDefaultTemplate.UseVisualStyleBackColor = true;
            this.btnDefaultTemplate.Click += new System.EventHandler(this.btnDefaultTemplate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(912, 451);
            this.Controls.Add(this.btnDefaultTemplate);
            this.Controls.Add(this.btnRepeatOver);
            this.Controls.Add(this.btnRepeat);
            this.Controls.Add(this.btnInitialText);
            this.Controls.Add(this.numCount);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.tbText);
            this.Icon = global::Repeator.Properties.Resources.Iconsmind_Outline_Code_Window;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Repeator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbText;
        private System.Windows.Forms.Button btnRepeat;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Button btnInitialText;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnRepeatOver;
        private System.Windows.Forms.Button btnDefaultTemplate;
    }
}

