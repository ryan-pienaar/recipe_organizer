namespace recipe_organizer
{
    partial class SearchForm
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
            btnSearch = new Button();
            label1 = new Label();
            txtBoxSearch = new TextBox();
            grpBoxSearch = new GroupBox();
            dataGrdVwSearch = new DataGridView();
            grpBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrdVwSearch).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(340, 32);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 1;
            label1.Text = "Search Category:";
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.Location = new Point(30, 32);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(304, 27);
            txtBoxSearch.TabIndex = 2;
            // 
            // grpBoxSearch
            // 
            grpBoxSearch.Controls.Add(dataGrdVwSearch);
            grpBoxSearch.Location = new Point(12, 80);
            grpBoxSearch.Name = "grpBoxSearch";
            grpBoxSearch.Size = new Size(776, 358);
            grpBoxSearch.TabIndex = 3;
            grpBoxSearch.TabStop = false;
            grpBoxSearch.Text = "groupBox1";
            // 
            // dataGrdVwSearch
            // 
            dataGrdVwSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrdVwSearch.Location = new Point(6, 26);
            dataGrdVwSearch.Name = "dataGrdVwSearch";
            dataGrdVwSearch.RowHeadersWidth = 51;
            dataGrdVwSearch.Size = new Size(764, 332);
            dataGrdVwSearch.TabIndex = 0;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpBoxSearch);
            Controls.Add(txtBoxSearch);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Name = "Search";
            Text = "Search";
            Load += Search_Load;
            grpBoxSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrdVwSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private Label label1;
        private TextBox txtBoxSearch;
        private GroupBox grpBoxSearch;
        private DataGridView dataGrdVwSearch;
    }
}