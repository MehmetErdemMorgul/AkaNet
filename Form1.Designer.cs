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
            this.grpNode = new System.Windows.Forms.Panel();
            this.btnDeleteNode = new System.Windows.Forms.Button();
            this.btnClearNode = new System.Windows.Forms.Button();
            this.btnUpdateNode = new System.Windows.Forms.Button();
            this.btnAddNode = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConnCount = new System.Windows.Forms.TextBox();
            this.txtActivity = new System.Windows.Forms.TextBox();
            this.txtInteraction = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEdgeA = new System.Windows.Forms.ComboBox();
            this.cmbEdgeB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddEdge = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDeleteEdge = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.grpNode.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(646, 629);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 173);
            this.listBox1.TabIndex = 0;
            // 
            // btnBfs
            // 
            this.btnBfs.Location = new System.Drawing.Point(862, 659);
            this.btnBfs.Name = "btnBfs";
            this.btnBfs.Size = new System.Drawing.Size(300, 30);
            this.btnBfs.TabIndex = 1;
            this.btnBfs.Text = "BFS";
            this.btnBfs.UseVisualStyleBackColor = true;
            this.btnBfs.Click += new System.EventHandler(this.btnBfs_Click);
            // 
            // btnDfs
            // 
            this.btnDfs.Location = new System.Drawing.Point(1200, 659);
            this.btnDfs.Name = "btnDfs";
            this.btnDfs.Size = new System.Drawing.Size(300, 30);
            this.btnDfs.TabIndex = 2;
            this.btnDfs.Text = "DFS";
            this.btnDfs.UseVisualStyleBackColor = true;
            this.btnDfs.Click += new System.EventHandler(this.btnDfs_Click);
            // 
            // btnDijkstra
            // 
            this.btnDijkstra.Location = new System.Drawing.Point(1200, 731);
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
            this.cmbStart.Location = new System.Drawing.Point(862, 629);
            this.cmbStart.Name = "cmbStart";
            this.cmbStart.Size = new System.Drawing.Size(300, 21);
            this.cmbStart.TabIndex = 4;
            // 
            // cmbTarget
            // 
            this.cmbTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarget.FormattingEnabled = true;
            this.cmbTarget.Location = new System.Drawing.Point(1200, 629);
            this.cmbTarget.Name = "cmbTarget";
            this.cmbTarget.Size = new System.Drawing.Size(300, 21);
            this.cmbTarget.TabIndex = 5;
            this.cmbTarget.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(981, 632);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Start Node";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1314, 632);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Target Node";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAStar
            // 
            this.btnAStar.Location = new System.Drawing.Point(1200, 695);
            this.btnAStar.Name = "btnAStar";
            this.btnAStar.Size = new System.Drawing.Size(300, 30);
            this.btnAStar.TabIndex = 9;
            this.btnAStar.Text = "A*";
            this.btnAStar.UseVisualStyleBackColor = true;
            this.btnAStar.Click += new System.EventHandler(this.btnAStar_Click);
            // 
            // btnComponents
            // 
            this.btnComponents.Location = new System.Drawing.Point(862, 731);
            this.btnComponents.Name = "btnComponents";
            this.btnComponents.Size = new System.Drawing.Size(300, 30);
            this.btnComponents.TabIndex = 10;
            this.btnComponents.Text = "Components";
            this.btnComponents.UseVisualStyleBackColor = true;
            this.btnComponents.Click += new System.EventHandler(this.btnComponents_Click);
            // 
            // btnCentrality
            // 
            this.btnCentrality.Location = new System.Drawing.Point(862, 771);
            this.btnCentrality.Name = "btnCentrality";
            this.btnCentrality.Size = new System.Drawing.Size(300, 30);
            this.btnCentrality.TabIndex = 11;
            this.btnCentrality.Text = "Top5 Centrality";
            this.btnCentrality.UseVisualStyleBackColor = true;
            this.btnCentrality.Click += new System.EventHandler(this.btnCentrality_Click);
            // 
            // btnColoring
            // 
            this.btnColoring.Location = new System.Drawing.Point(1200, 771);
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
            this.pnlCanvas.Size = new System.Drawing.Size(1488, 593);
            this.pnlCanvas.TabIndex = 13;
            this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
            this.pnlCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseClick);
            this.pnlCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseDown);
            this.pnlCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseMove);
            this.pnlCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseUp);
            // 
            // btnLoadCsv
            // 
            this.btnLoadCsv.Location = new System.Drawing.Point(862, 695);
            this.btnLoadCsv.Name = "btnLoadCsv";
            this.btnLoadCsv.Size = new System.Drawing.Size(300, 30);
            this.btnLoadCsv.TabIndex = 14;
            this.btnLoadCsv.Text = "Load CSV Folder";
            this.btnLoadCsv.UseVisualStyleBackColor = true;
            this.btnLoadCsv.Click += new System.EventHandler(this.btnLoadCsv_Click);
            // 
            // grpNode
            // 
            this.grpNode.Controls.Add(this.btnDeleteNode);
            this.grpNode.Controls.Add(this.btnClearNode);
            this.grpNode.Controls.Add(this.btnUpdateNode);
            this.grpNode.Controls.Add(this.btnAddNode);
            this.grpNode.Controls.Add(this.label8);
            this.grpNode.Controls.Add(this.label7);
            this.grpNode.Controls.Add(this.label6);
            this.grpNode.Controls.Add(this.label5);
            this.grpNode.Controls.Add(this.label4);
            this.grpNode.Controls.Add(this.txtConnCount);
            this.grpNode.Controls.Add(this.txtActivity);
            this.grpNode.Controls.Add(this.txtInteraction);
            this.grpNode.Controls.Add(this.txtName);
            this.grpNode.Controls.Add(this.txtId);
            this.grpNode.Location = new System.Drawing.Point(12, 629);
            this.grpNode.Name = "grpNode";
            this.grpNode.Size = new System.Drawing.Size(444, 173);
            this.grpNode.TabIndex = 15;
            // 
            // btnDeleteNode
            // 
            this.btnDeleteNode.Location = new System.Drawing.Point(266, 93);
            this.btnDeleteNode.Name = "btnDeleteNode";
            this.btnDeleteNode.Size = new System.Drawing.Size(78, 71);
            this.btnDeleteNode.TabIndex = 12;
            this.btnDeleteNode.Text = "Sil";
            this.btnDeleteNode.UseVisualStyleBackColor = true;
            this.btnDeleteNode.Click += new System.EventHandler(this.btnDeleteNode_Click);
            // 
            // btnClearNode
            // 
            this.btnClearNode.Location = new System.Drawing.Point(360, 93);
            this.btnClearNode.Name = "btnClearNode";
            this.btnClearNode.Size = new System.Drawing.Size(78, 71);
            this.btnClearNode.TabIndex = 13;
            this.btnClearNode.Text = "Temizle";
            this.btnClearNode.UseVisualStyleBackColor = true;
            this.btnClearNode.Click += new System.EventHandler(this.btnClearNode_Click);
            // 
            // btnUpdateNode
            // 
            this.btnUpdateNode.Location = new System.Drawing.Point(360, 3);
            this.btnUpdateNode.Name = "btnUpdateNode";
            this.btnUpdateNode.Size = new System.Drawing.Size(78, 71);
            this.btnUpdateNode.TabIndex = 11;
            this.btnUpdateNode.Text = "Güncelle";
            this.btnUpdateNode.UseVisualStyleBackColor = true;
            this.btnUpdateNode.Click += new System.EventHandler(this.btnUpdateNode_Click);
            // 
            // btnAddNode
            // 
            this.btnAddNode.Location = new System.Drawing.Point(266, 3);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(78, 71);
            this.btnAddNode.TabIndex = 10;
            this.btnAddNode.Text = "Ekle";
            this.btnAddNode.UseVisualStyleBackColor = true;
            this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Bağlantı Sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Aktivite:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Etkileşim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "İsim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID:";
            // 
            // txtConnCount
            // 
            this.txtConnCount.Location = new System.Drawing.Point(150, 148);
            this.txtConnCount.Name = "txtConnCount";
            this.txtConnCount.Size = new System.Drawing.Size(100, 20);
            this.txtConnCount.TabIndex = 4;
            // 
            // txtActivity
            // 
            this.txtActivity.Location = new System.Drawing.Point(150, 112);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(100, 20);
            this.txtActivity.TabIndex = 3;
            // 
            // txtInteraction
            // 
            this.txtInteraction.Location = new System.Drawing.Point(150, 76);
            this.txtInteraction.Name = "txtInteraction";
            this.txtInteraction.Size = new System.Drawing.Size(100, 20);
            this.txtInteraction.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(150, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 608);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Düğüm Bilgileri";
            // 
            // cmbEdgeA
            // 
            this.cmbEdgeA.FormattingEnabled = true;
            this.cmbEdgeA.Location = new System.Drawing.Point(474, 655);
            this.cmbEdgeA.Name = "cmbEdgeA";
            this.cmbEdgeA.Size = new System.Drawing.Size(121, 21);
            this.cmbEdgeA.TabIndex = 17;
            // 
            // cmbEdgeB
            // 
            this.cmbEdgeB.FormattingEnabled = true;
            this.cmbEdgeB.Location = new System.Drawing.Point(474, 708);
            this.cmbEdgeB.Name = "cmbEdgeB";
            this.cmbEdgeB.Size = new System.Drawing.Size(121, 21);
            this.cmbEdgeB.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(471, 608);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Bağlantı Durumları";
            // 
            // btnAddEdge
            // 
            this.btnAddEdge.Location = new System.Drawing.Point(474, 746);
            this.btnAddEdge.Name = "btnAddEdge";
            this.btnAddEdge.Size = new System.Drawing.Size(121, 23);
            this.btnAddEdge.TabIndex = 22;
            this.btnAddEdge.Text = "Bağlantı Ekle";
            this.btnAddEdge.Click += new System.EventHandler(this.btnAddEdge_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(471, 629);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Merkez Düğüm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(471, 690);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Diğer Düğüm";
            // 
            // btnDeleteEdge
            // 
            this.btnDeleteEdge.Location = new System.Drawing.Point(474, 779);
            this.btnDeleteEdge.Name = "btnDeleteEdge";
            this.btnDeleteEdge.Size = new System.Drawing.Size(121, 23);
            this.btnDeleteEdge.TabIndex = 25;
            this.btnDeleteEdge.Text = "Bağlantı Sil";
            this.btnDeleteEdge.Click += new System.EventHandler(this.btnDeleteEdge_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1506, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Tool Box";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1506, 37);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(471, 629);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Merkez Düğüm";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1594, 843);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnDeleteEdge);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAddEdge);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbEdgeB);
            this.Controls.Add(this.cmbEdgeA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpNode);
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
            this.grpNode.ResumeLayout(false);
            this.grpNode.PerformLayout();
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
        private System.Windows.Forms.Panel grpNode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtInteraction;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtConnCount;
        private System.Windows.Forms.TextBox txtActivity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClearNode;
        private System.Windows.Forms.Button btnDeleteNode;
        private System.Windows.Forms.Button btnUpdateNode;
        private System.Windows.Forms.Button btnAddNode;
        private System.Windows.Forms.ComboBox cmbEdgeA;
        private System.Windows.Forms.ComboBox cmbEdgeB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddEdge;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDeleteEdge;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label13;
    }
}
