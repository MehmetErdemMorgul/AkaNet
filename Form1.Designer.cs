namespace AkaNet
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnBfs = new System.Windows.Forms.Button();
            this.btnDfs = new System.Windows.Forms.Button();
            this.btnDijkstra = new System.Windows.Forms.Button();
            this.cmbStart = new System.Windows.Forms.ComboBox();
            this.cmbTarget = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAStar = new System.Windows.Forms.Button();
            this.btnComponents = new System.Windows.Forms.Button();
            this.btnCentrality = new System.Windows.Forms.Button();
            this.btnColoring = new System.Windows.Forms.Button();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.btnLoadCsv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(643, 575);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 173);
            this.listBox1.TabIndex = 0;
            // 
            // btnBfs
            // 
            this.btnBfs.Location = new System.Drawing.Point(862, 605);
            this.btnBfs.Name = "btnBfs";
            this.btnBfs.Size = new System.Drawing.Size(300, 30);
            this.btnBfs.TabIndex = 1;
            this.btnBfs.Text = "BFS";
            this.btnBfs.UseVisualStyleBackColor = true;
            this.btnBfs.Click += new System.EventHandler(this.btnBfs_Click);
            // 
            // btnDfs
            // 
            this.btnDfs.Location = new System.Drawing.Point(1200, 605);
            this.btnDfs.Name = "btnDfs";
            this.btnDfs.Size = new System.Drawing.Size(300, 30);
            this.btnDfs.TabIndex = 2;
            this.btnDfs.Text = "DFS";
            this.btnDfs.UseVisualStyleBackColor = true;
            this.btnDfs.Click += new System.EventHandler(this.btnDfs_Click);
            // 
            // btnDijkstra
            // 
            this.btnDijkstra.Location = new System.Drawing.Point(1200, 677);
            this.btnDijkstra.Name = "btnDijkstra";
            this.btnDijkstra.Size = new System.Drawing.Size(300, 30);
            this.btnDijkstra.TabIndex = 3;
            this.btnDijkstra.Text = "Dijkstra";
            this.btnDijkstra.UseVisualStyleBackColor = true;
            this.btnDijkstra.Click += new System.EventHandler(this.btnDijkstra_Click);
            // 
            // cmbStart
            // 
            this.cmbStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStart.FormattingEnabled = true;
            this.cmbStart.Location = new System.Drawing.Point(862, 575);
            this.cmbStart.Name = "cmbStart";
            this.cmbStart.Size = new System.Drawing.Size(300, 21);
            this.cmbStart.TabIndex = 4;
            // 
            // cmbTarget
            // 
            this.cmbTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarget.FormattingEnabled = true;
            this.cmbTarget.Location = new System.Drawing.Point(1200, 575);
            this.cmbTarget.Name = "cmbTarget";
            this.cmbTarget.Size = new System.Drawing.Size(300, 21);
            this.cmbTarget.TabIndex = 5;
            this.cmbTarget.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(981, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Start Node";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1314, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Target Node";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAStar
            // 
            this.btnAStar.Location = new System.Drawing.Point(1200, 641);
            this.btnAStar.Name = "btnAStar";
            this.btnAStar.Size = new System.Drawing.Size(300, 30);
            this.btnAStar.TabIndex = 9;
            this.btnAStar.Text = "A*";
            this.btnAStar.UseVisualStyleBackColor = true;
            this.btnAStar.Click += new System.EventHandler(this.btnAStar_Click);
            // 
            // btnComponents
            // 
            this.btnComponents.Location = new System.Drawing.Point(862, 677);
            this.btnComponents.Name = "btnComponents";
            this.btnComponents.Size = new System.Drawing.Size(300, 30);
            this.btnComponents.TabIndex = 10;
            this.btnComponents.Text = "Components";
            this.btnComponents.UseVisualStyleBackColor = true;
            this.btnComponents.Click += new System.EventHandler(this.btnComponents_Click);
            // 
            // btnCentrality
            // 
            this.btnCentrality.Location = new System.Drawing.Point(862, 717);
            this.btnCentrality.Name = "btnCentrality";
            this.btnCentrality.Size = new System.Drawing.Size(300, 30);
            this.btnCentrality.TabIndex = 11;
            this.btnCentrality.Text = "Top5 Centrality";
            this.btnCentrality.UseVisualStyleBackColor = true;
            this.btnCentrality.Click += new System.EventHandler(this.btnCentrality_Click);
            // 
            // btnColoring
            // 
            this.btnColoring.Location = new System.Drawing.Point(1200, 717);
            this.btnColoring.Name = "btnColoring";
            this.btnColoring.Size = new System.Drawing.Size(300, 30);
            this.btnColoring.TabIndex = 12;
            this.btnColoring.Text = "Welsh-Powell";
            this.btnColoring.UseVisualStyleBackColor = true;
            this.btnColoring.Click += new System.EventHandler(this.btnColoring_Click);
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlCanvas.Location = new System.Drawing.Point(12, 12);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(1488, 539);
            this.pnlCanvas.TabIndex = 13;
            this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
            // 
            // btnLoadCsv
            // 
            this.btnLoadCsv.Location = new System.Drawing.Point(862, 641);
            this.btnLoadCsv.Name = "btnLoadCsv";
            this.btnLoadCsv.Size = new System.Drawing.Size(300, 30);
            this.btnLoadCsv.TabIndex = 14;
            this.btnLoadCsv.Text = "Load CSV Folder";
            this.btnLoadCsv.UseVisualStyleBackColor = true;
            this.btnLoadCsv.Click += new System.EventHandler(this.btnLoadCsv_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1512, 779);
            this.Controls.Add(this.btnLoadCsv);
            this.Controls.Add(this.pnlCanvas);
            this.Controls.Add(this.btnColoring);
            this.Controls.Add(this.btnCentrality);
            this.Controls.Add(this.btnComponents);
            this.Controls.Add(this.btnAStar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTarget);
            this.Controls.Add(this.cmbStart);
            this.Controls.Add(this.btnDijkstra);
            this.Controls.Add(this.btnDfs);
            this.Controls.Add(this.btnBfs);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "AkaNet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnBfs;
        private System.Windows.Forms.Button btnDfs;
        private System.Windows.Forms.Button btnDijkstra;
        private System.Windows.Forms.ComboBox cmbStart;
        private System.Windows.Forms.ComboBox cmbTarget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAStar;
        private System.Windows.Forms.Button btnComponents;
        private System.Windows.Forms.Button btnCentrality;
        private System.Windows.Forms.Button btnColoring;
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.Button btnLoadCsv;
    }
}
