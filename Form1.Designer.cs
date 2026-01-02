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
            this.label2 = new System.Windows.Forms.Label();
            this.btnAStar = new System.Windows.Forms.Button();
            this.btnComponents = new System.Windows.Forms.Button();
            this.btnCentrality = new System.Windows.Forms.Button();
            this.btnColoring = new System.Windows.Forms.Button();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.btnDeleteEdge = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAddEdge = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEdgeB = new System.Windows.Forms.ComboBox();
            this.cmbEdgeA = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.btnLoadCsv = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNodeAddMode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAvgWeight = new System.Windows.Forms.Label();
            this.lblAvgDegree = new System.Windows.Forms.Label();
            this.lblEdgeCount = new System.Windows.Forms.Label();
            this.lblNodeCount = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnExportCsv = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlRightContent = new System.Windows.Forms.Panel();
            this.pnlToolbox = new System.Windows.Forms.Panel();
            this.pnlAlgorithms = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.pnlRightTop = new System.Windows.Forms.Panel();
            this.btnShowAlgorithms = new System.Windows.Forms.Button();
            this.btnShowToolbox = new System.Windows.Forms.Button();
            this.grpNode.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlRightContent.SuspendLayout();
            this.pnlToolbox.SuspendLayout();
            this.pnlAlgorithms.SuspendLayout();
            this.pnlRightTop.SuspendLayout();
            this.SuspendLayout();
            
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(649, 526);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(223, 180);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            
            this.btnBfs.Location = new System.Drawing.Point(0, 36);
            this.btnBfs.Name = "btnBfs";
            this.btnBfs.Size = new System.Drawing.Size(200, 30);
            this.btnBfs.TabIndex = 1;
            this.btnBfs.Text = "BFS";
            this.btnBfs.UseVisualStyleBackColor = true;
            this.btnBfs.Click += new System.EventHandler(this.btnBfs_Click);
            
            this.btnDfs.Location = new System.Drawing.Point(0, 0);
            this.btnDfs.Name = "btnDfs";
            this.btnDfs.Size = new System.Drawing.Size(200, 30);
            this.btnDfs.TabIndex = 2;
            this.btnDfs.Text = "DFS";
            this.btnDfs.UseVisualStyleBackColor = true;
            this.btnDfs.Click += new System.EventHandler(this.btnDfs_Click);
             
            this.btnDijkstra.Location = new System.Drawing.Point(0, 109);
            this.btnDijkstra.Name = "btnDijkstra";
            this.btnDijkstra.Size = new System.Drawing.Size(200, 30);
            this.btnDijkstra.TabIndex = 3;
            this.btnDijkstra.Text = "Dijkstra";
            this.btnDijkstra.UseVisualStyleBackColor = true;
            this.btnDijkstra.Click += new System.EventHandler(this.btnDijkstra_Click);
             
            this.cmbStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStart.FormattingEnabled = true;
            this.cmbStart.Location = new System.Drawing.Point(0, 296);
            this.cmbStart.Name = "cmbStart";
            this.cmbStart.Size = new System.Drawing.Size(200, 24);
            this.cmbStart.TabIndex = 4;
            
            this.cmbTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarget.FormattingEnabled = true;
            this.cmbTarget.Location = new System.Drawing.Point(0, 326);
            this.cmbTarget.Name = "cmbTarget";
            this.cmbTarget.Size = new System.Drawing.Size(200, 24);
            this.cmbTarget.TabIndex = 5;
            this.cmbTarget.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
           
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Başlangıç Node\'u";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            
            this.btnAStar.Location = new System.Drawing.Point(0, 72);
            this.btnAStar.Name = "btnAStar";
            this.btnAStar.Size = new System.Drawing.Size(200, 30);
            this.btnAStar.TabIndex = 9;
            this.btnAStar.Text = "A*";
            this.btnAStar.UseVisualStyleBackColor = true;
            this.btnAStar.Click += new System.EventHandler(this.btnAStar_Click);
            
            this.btnComponents.Location = new System.Drawing.Point(0, 182);
            this.btnComponents.Name = "btnComponents";
            this.btnComponents.Size = new System.Drawing.Size(200, 30);
            this.btnComponents.TabIndex = 10;
            this.btnComponents.Text = "Components";
            this.btnComponents.UseVisualStyleBackColor = true;
            this.btnComponents.Click += new System.EventHandler(this.btnComponents_Click);
            
            this.btnCentrality.Location = new System.Drawing.Point(0, 218);
            this.btnCentrality.Name = "btnCentrality";
            this.btnCentrality.Size = new System.Drawing.Size(200, 30);
            this.btnCentrality.TabIndex = 11;
            this.btnCentrality.Text = "Top5 Centrality";
            this.btnCentrality.UseVisualStyleBackColor = true;
            this.btnCentrality.Click += new System.EventHandler(this.btnCentrality_Click);
            
            this.btnColoring.Location = new System.Drawing.Point(0, 146);
            this.btnColoring.Name = "btnColoring";
            this.btnColoring.Size = new System.Drawing.Size(200, 30);
            this.btnColoring.TabIndex = 12;
            this.btnColoring.Text = "Welsh-Powell";
            this.btnColoring.UseVisualStyleBackColor = true;
            this.btnColoring.Click += new System.EventHandler(this.btnColoring_Click);
            
            this.pnlCanvas.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlCanvas.Location = new System.Drawing.Point(12, 6);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(1275, 490);
            this.pnlCanvas.TabIndex = 13;
            this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
            this.pnlCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseClick);
            this.pnlCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseDown);
            this.pnlCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseMove);
            this.pnlCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseUp);
            
            this.btnDeleteEdge.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteEdge.Location = new System.Drawing.Point(478, 641);
            this.btnDeleteEdge.Name = "btnDeleteEdge";
            this.btnDeleteEdge.Size = new System.Drawing.Size(121, 23);
            this.btnDeleteEdge.TabIndex = 25;
            this.btnDeleteEdge.Text = "Bağlantı Sil";
            this.btnDeleteEdge.UseVisualStyleBackColor = false;
            this.btnDeleteEdge.Click += new System.EventHandler(this.btnDeleteEdge_Click);
             
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(483, 587);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Diğer Düğüm";
            
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(483, 557);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Merkez Düğüm";
            
            this.btnAddEdge.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddEdge.Location = new System.Drawing.Point(478, 614);
            this.btnAddEdge.Name = "btnAddEdge";
            this.btnAddEdge.Size = new System.Drawing.Size(121, 23);
            this.btnAddEdge.TabIndex = 22;
            this.btnAddEdge.Text = "Bağlantı Ekle";
            this.btnAddEdge.UseVisualStyleBackColor = false;
            this.btnAddEdge.Click += new System.EventHandler(this.btnAddEdge_Click);
             
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(483, 526);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Bağlantı Durumları";
            
            this.cmbEdgeB.FormattingEnabled = true;
            this.cmbEdgeB.Location = new System.Drawing.Point(478, 584);
            this.cmbEdgeB.Name = "cmbEdgeB";
            this.cmbEdgeB.Size = new System.Drawing.Size(121, 24);
            this.cmbEdgeB.TabIndex = 20;
             
            this.cmbEdgeA.FormattingEnabled = true;
            this.cmbEdgeA.Location = new System.Drawing.Point(478, 554);
            this.cmbEdgeA.Name = "cmbEdgeA";
            this.cmbEdgeA.Size = new System.Drawing.Size(121, 24);
            this.cmbEdgeA.TabIndex = 17;
            
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Düğüm Bilgileri";
            
            this.grpNode.BackColor = System.Drawing.Color.White;
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
            this.grpNode.Location = new System.Drawing.Point(12, 526);
            this.grpNode.Name = "grpNode";
            this.grpNode.Size = new System.Drawing.Size(444, 180);
            this.grpNode.TabIndex = 15;
            this.grpNode.Paint += new System.Windows.Forms.PaintEventHandler(this.grpNode_Paint);
             
            this.btnDeleteNode.Location = new System.Drawing.Point(266, 93);
            this.btnDeleteNode.Name = "btnDeleteNode";
            this.btnDeleteNode.Size = new System.Drawing.Size(78, 71);
            this.btnDeleteNode.TabIndex = 12;
            this.btnDeleteNode.Text = "Sil";
            this.btnDeleteNode.UseVisualStyleBackColor = true;
            this.btnDeleteNode.Click += new System.EventHandler(this.btnDeleteNode_Click);
            
            this.btnClearNode.Location = new System.Drawing.Point(360, 93);
            this.btnClearNode.Name = "btnClearNode";
            this.btnClearNode.Size = new System.Drawing.Size(78, 71);
            this.btnClearNode.TabIndex = 13;
            this.btnClearNode.Text = "Temizle";
            this.btnClearNode.UseVisualStyleBackColor = true;
            this.btnClearNode.Click += new System.EventHandler(this.btnClearNode_Click);
            
            this.btnUpdateNode.Location = new System.Drawing.Point(360, 3);
            this.btnUpdateNode.Name = "btnUpdateNode";
            this.btnUpdateNode.Size = new System.Drawing.Size(78, 71);
            this.btnUpdateNode.TabIndex = 11;
            this.btnUpdateNode.Text = "Güncelle";
            this.btnUpdateNode.UseVisualStyleBackColor = true;
            this.btnUpdateNode.Click += new System.EventHandler(this.btnUpdateNode_Click);
             
            this.btnAddNode.Location = new System.Drawing.Point(266, 3);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(78, 71);
            this.btnAddNode.TabIndex = 10;
            this.btnAddNode.Text = "Ekle";
            this.btnAddNode.UseVisualStyleBackColor = true;
            this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);
            
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Bağlantı Sayısı:";
             
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Aktivite:";
             
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Etkileşim";
             
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "İsim:";
             
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID:";
             
            this.txtConnCount.Location = new System.Drawing.Point(150, 148);
            this.txtConnCount.Name = "txtConnCount";
            this.txtConnCount.Size = new System.Drawing.Size(100, 22);
            this.txtConnCount.TabIndex = 4;
             
            this.txtActivity.Location = new System.Drawing.Point(150, 112);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(100, 22);
            this.txtActivity.TabIndex = 3;
             
            this.txtInteraction.Location = new System.Drawing.Point(150, 76);
            this.txtInteraction.Name = "txtInteraction";
            this.txtInteraction.Size = new System.Drawing.Size(100, 22);
            this.txtInteraction.TabIndex = 2;
            
            this.txtName.Location = new System.Drawing.Point(150, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 1;
             
            this.txtId.Location = new System.Drawing.Point(150, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 0;
             
            this.btnLoadCsv.Location = new System.Drawing.Point(0, 58);
            this.btnLoadCsv.Name = "btnLoadCsv";
            this.btnLoadCsv.Size = new System.Drawing.Size(197, 23);
            this.btnLoadCsv.TabIndex = 14;
            this.btnLoadCsv.Text = "Dosya Yükle";
            this.btnLoadCsv.UseVisualStyleBackColor = true;
            this.btnLoadCsv.Click += new System.EventHandler(this.btnLoadCsv_Click);
             
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(0, 0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(200, 23);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
             
            this.btnNodeAddMode.Location = new System.Drawing.Point(0, 29);
            this.btnNodeAddMode.Name = "btnNodeAddMode";
            this.btnNodeAddMode.Size = new System.Drawing.Size(200, 23);
            this.btnNodeAddMode.TabIndex = 28;
            this.btnNodeAddMode.Text = "Node Ekle (Tıkla)";
            this.btnNodeAddMode.UseVisualStyleBackColor = true;
            this.btnNodeAddMode.Click += new System.EventHandler(this.btnNodeAddMode_Click);
            
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lblAvgWeight);
            this.groupBox1.Controls.Add(this.lblAvgDegree);
            this.groupBox1.Controls.Add(this.lblEdgeCount);
            this.groupBox1.Controls.Add(this.lblNodeCount);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(906, 526);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 180);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graph İstatistikleri";
             
            this.lblAvgWeight.AutoSize = true;
            this.lblAvgWeight.Location = new System.Drawing.Point(128, 112);
            this.lblAvgWeight.Name = "lblAvgWeight";
            this.lblAvgWeight.Size = new System.Drawing.Size(87, 16);
            this.lblAvgWeight.TabIndex = 7;
            this.lblAvgWeight.Text = "lblAvgWeight";
             
            this.lblAvgDegree.AutoSize = true;
            this.lblAvgDegree.Location = new System.Drawing.Point(128, 85);
            this.lblAvgDegree.Name = "lblAvgDegree";
            this.lblAvgDegree.Size = new System.Drawing.Size(91, 16);
            this.lblAvgDegree.TabIndex = 6;
            this.lblAvgDegree.Text = "lblAvgDegree";
            
            this.lblEdgeCount.AutoSize = true;
            this.lblEdgeCount.Location = new System.Drawing.Point(128, 56);
            this.lblEdgeCount.Name = "lblEdgeCount";
            this.lblEdgeCount.Size = new System.Drawing.Size(88, 16);
            this.lblEdgeCount.TabIndex = 5;
            this.lblEdgeCount.Text = "lblEdgeCount";
             
            this.lblNodeCount.AutoSize = true;
            this.lblNodeCount.Location = new System.Drawing.Point(128, 26);
            this.lblNodeCount.Name = "lblNodeCount";
            this.lblNodeCount.Size = new System.Drawing.Size(89, 16);
            this.lblNodeCount.TabIndex = 4;
            this.lblNodeCount.Text = "lblNodeCount";
            
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 112);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 16);
            this.label17.TabIndex = 3;
            this.label17.Text = "Ortalama Ağırlık:";
             
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "Ortalama Derece:";
            
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "Edge Sayısı:";
            
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Node Sayısı:";
            
            this.btnExportCsv.Location = new System.Drawing.Point(0, 87);
            this.btnExportCsv.Name = "btnExportCsv";
            this.btnExportCsv.Size = new System.Drawing.Size(200, 23);
            this.btnExportCsv.TabIndex = 30;
            this.btnExportCsv.Text = "Dosya Kaydet";
            this.btnExportCsv.UseVisualStyleBackColor = true;
            this.btnExportCsv.Click += new System.EventHandler(this.btnExportCsv_Click);
            
            this.pnlRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlRight.Controls.Add(this.pnlRightContent);
            this.pnlRight.Controls.Add(this.pnlRightTop);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(1287, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(200, 909);
            this.pnlRight.TabIndex = 31;
            
            this.pnlRightContent.Controls.Add(this.pnlToolbox);
            this.pnlRightContent.Controls.Add(this.pnlAlgorithms);
            this.pnlRightContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightContent.Location = new System.Drawing.Point(0, 62);
            this.pnlRightContent.Name = "pnlRightContent";
            this.pnlRightContent.Size = new System.Drawing.Size(200, 847);
            this.pnlRightContent.TabIndex = 1;
            
            this.pnlToolbox.BackColor = System.Drawing.Color.Brown;
            this.pnlToolbox.Controls.Add(this.btnReset);
            this.pnlToolbox.Controls.Add(this.btnExportCsv);
            this.pnlToolbox.Controls.Add(this.btnNodeAddMode);
            this.pnlToolbox.Controls.Add(this.btnLoadCsv);
            this.pnlToolbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlToolbox.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbox.Name = "pnlToolbox";
            this.pnlToolbox.Size = new System.Drawing.Size(200, 847);
            this.pnlToolbox.TabIndex = 15;
            this.pnlToolbox.Visible = false;
            
            this.pnlAlgorithms.BackColor = System.Drawing.Color.Brown;
            this.pnlAlgorithms.Controls.Add(this.btnDfs);
            this.pnlAlgorithms.Controls.Add(this.label19);
            this.pnlAlgorithms.Controls.Add(this.btnAStar);
            this.pnlAlgorithms.Controls.Add(this.btnDijkstra);
            this.pnlAlgorithms.Controls.Add(this.btnColoring);
            this.pnlAlgorithms.Controls.Add(this.btnComponents);
            this.pnlAlgorithms.Controls.Add(this.label2);
            this.pnlAlgorithms.Controls.Add(this.btnCentrality);
            this.pnlAlgorithms.Controls.Add(this.btnBfs);
            this.pnlAlgorithms.Controls.Add(this.cmbStart);
            this.pnlAlgorithms.Controls.Add(this.cmbTarget);
            this.pnlAlgorithms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAlgorithms.Location = new System.Drawing.Point(0, 0);
            this.pnlAlgorithms.Name = "pnlAlgorithms";
            this.pnlAlgorithms.Size = new System.Drawing.Size(200, 847);
            this.pnlAlgorithms.TabIndex = 0;
            
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(66, 329);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 16);
            this.label19.TabIndex = 32;
            this.label19.Text = "Hedef Node";
            
            this.pnlRightTop.Controls.Add(this.btnShowAlgorithms);
            this.pnlRightTop.Controls.Add(this.btnShowToolbox);
            this.pnlRightTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightTop.Location = new System.Drawing.Point(0, 0);
            this.pnlRightTop.Name = "pnlRightTop";
            this.pnlRightTop.Size = new System.Drawing.Size(200, 62);
            this.pnlRightTop.TabIndex = 0;
            this.pnlRightTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRightTop_Paint);
            
            this.btnShowAlgorithms.BackColor = System.Drawing.Color.IndianRed;
            this.btnShowAlgorithms.Location = new System.Drawing.Point(99, 0);
            this.btnShowAlgorithms.Name = "btnShowAlgorithms";
            this.btnShowAlgorithms.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnShowAlgorithms.Size = new System.Drawing.Size(101, 62);
            this.btnShowAlgorithms.TabIndex = 1;
            this.btnShowAlgorithms.Text = "Algoritmalar";
            this.btnShowAlgorithms.UseVisualStyleBackColor = false;
            this.btnShowAlgorithms.Click += new System.EventHandler(this.btnShowAlgorithms_Click);
            
            this.btnShowToolbox.BackColor = System.Drawing.Color.IndianRed;
            this.btnShowToolbox.Location = new System.Drawing.Point(0, 0);
            this.btnShowToolbox.Name = "btnShowToolbox";
            this.btnShowToolbox.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnShowToolbox.Size = new System.Drawing.Size(101, 62);
            this.btnShowToolbox.TabIndex = 0;
            this.btnShowToolbox.Text = "Toolbox";
            this.btnShowToolbox.UseVisualStyleBackColor = false;
            this.btnShowToolbox.Click += new System.EventHandler(this.btnShowToolbox_Click);
             
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1487, 909);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDeleteEdge);
            this.Controls.Add(this.pnlCanvas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grpNode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbEdgeA);
            this.Controls.Add(this.cmbEdgeB);
            this.Controls.Add(this.btnAddEdge);
            this.Name = "Form1";
            this.Text = "AkaNet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpNode.ResumeLayout(false);
            this.grpNode.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRightContent.ResumeLayout(false);
            this.pnlToolbox.ResumeLayout(false);
            this.pnlAlgorithms.ResumeLayout(false);
            this.pnlAlgorithms.PerformLayout();
            this.pnlRightTop.ResumeLayout(false);
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDeleteEdge;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnNodeAddMode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblAvgWeight;
        private System.Windows.Forms.Label lblAvgDegree;
        private System.Windows.Forms.Label lblEdgeCount;
        private System.Windows.Forms.Label lblNodeCount;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlRightContent;
        private System.Windows.Forms.Panel pnlRightTop;
        private System.Windows.Forms.Panel pnlAlgorithms;
        private System.Windows.Forms.Panel pnlToolbox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnShowAlgorithms;
        private System.Windows.Forms.Button btnShowToolbox;
    }
}
