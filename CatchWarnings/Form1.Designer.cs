namespace CatchWarnings
{
    partial class SearchingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchingForm));
            this.PathBtn = new System.Windows.Forms.Button();
            this.PathNameTB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FindBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PathBtn
            // 
            this.PathBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(195)))), ((int)(((byte)(78)))));
            this.PathBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PathBtn.FlatAppearance.BorderSize = 0;
            this.PathBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PathBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PathBtn.Location = new System.Drawing.Point(592, 50);
            this.PathBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PathBtn.Name = "PathBtn";
            this.PathBtn.Size = new System.Drawing.Size(90, 32);
            this.PathBtn.TabIndex = 0;
            this.PathBtn.Text = "▪▪▪";
            this.PathBtn.UseVisualStyleBackColor = false;
            this.PathBtn.UseWaitCursor = true;
            this.PathBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // PathNameTB
            // 
            this.PathNameTB.BackColor = System.Drawing.Color.White;
            this.PathNameTB.Location = new System.Drawing.Point(26, 50);
            this.PathNameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PathNameTB.Multiline = true;
            this.PathNameTB.Name = "PathNameTB";
            this.PathNameTB.Size = new System.Drawing.Size(531, 33);
            this.PathNameTB.TabIndex = 1;
            this.PathNameTB.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 110);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(530, 315);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.UseWaitCursor = true;
            // 
            // FindBtn
            // 
            this.FindBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(195)))), ((int)(((byte)(78)))));
            this.FindBtn.FlatAppearance.BorderSize = 0;
            this.FindBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FindBtn.Location = new System.Drawing.Point(592, 110);
            this.FindBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(90, 32);
            this.FindBtn.TabIndex = 4;
            this.FindBtn.Text = "Find";
            this.FindBtn.UseVisualStyleBackColor = false;
            this.FindBtn.UseWaitCursor = true;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // SearchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(724, 454);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PathNameTB);
            this.Controls.Add(this.PathBtn);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchingForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error Finder";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.SearchingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PathNameTB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button FindBtn;
        public System.Windows.Forms.Button PathBtn;
    }
}

