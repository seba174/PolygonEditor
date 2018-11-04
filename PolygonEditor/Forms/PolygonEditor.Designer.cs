namespace PolygonEditor
{
    partial class PolygonEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PolygonEditor));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.FakeButton = new System.Windows.Forms.Button();
            this.CreateGroupBox = new System.Windows.Forms.GroupBox();
            this.CreateTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.StartDrawingButton = new System.Windows.Forms.Button();
            this.StopDrawingButton = new System.Windows.Forms.Button();
            this.CreateCustomButton = new System.Windows.Forms.Button();
            this.CreateRectangleButton = new System.Windows.Forms.Button();
            this.CreateTriangleButton = new System.Windows.Forms.Button();
            this.EditVerticeGroupBox = new System.Windows.Forms.GroupBox();
            this.EditVerticeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteVerticeButton = new System.Windows.Forms.Button();
            this.EditEdgeGroupBox = new System.Windows.Forms.GroupBox();
            this.EditEdgeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MakeVerticalButton = new System.Windows.Forms.Button();
            this.MakeHorizontalButton = new System.Windows.Forms.Button();
            this.MakeFixedLengthButton = new System.Windows.Forms.Button();
            this.ChangeLengthButton = new System.Windows.Forms.Button();
            this.RemoveConstraintsButton = new System.Windows.Forms.Button();
            this.SplitButton = new System.Windows.Forms.Button();
            this.EditPolygonGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DeletePolygonButton = new System.Windows.Forms.Button();
            this.drawingArea = new System.Windows.Forms.PictureBox();
            this.ConvexHullButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.CreateGroupBox.SuspendLayout();
            this.CreateTableLayoutPanel.SuspendLayout();
            this.EditVerticeGroupBox.SuspendLayout();
            this.EditVerticeTableLayoutPanel.SuspendLayout();
            this.EditEdgeGroupBox.SuspendLayout();
            this.EditEdgeTableLayoutPanel.SuspendLayout();
            this.EditPolygonGroupBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.drawingArea, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 812);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.FakeButton, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.CreateGroupBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.EditVerticeGroupBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.EditEdgeGroupBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.EditPolygonGroupBox, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(990, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(191, 806);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // FakeButton
            // 
            this.FakeButton.Location = new System.Drawing.Point(3, 505);
            this.FakeButton.Name = "FakeButton";
            this.FakeButton.Size = new System.Drawing.Size(0, 0);
            this.FakeButton.TabIndex = 1;
            this.FakeButton.Text = "button1";
            this.FakeButton.UseVisualStyleBackColor = true;
            // 
            // CreateGroupBox
            // 
            this.CreateGroupBox.AutoSize = true;
            this.CreateGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateGroupBox.Controls.Add(this.CreateTableLayoutPanel);
            this.CreateGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CreateGroupBox.Location = new System.Drawing.Point(3, 270);
            this.CreateGroupBox.Name = "CreateGroupBox";
            this.CreateGroupBox.Size = new System.Drawing.Size(185, 174);
            this.CreateGroupBox.TabIndex = 3;
            this.CreateGroupBox.TabStop = false;
            this.CreateGroupBox.Text = "Create polygon";
            // 
            // CreateTableLayoutPanel
            // 
            this.CreateTableLayoutPanel.AutoSize = true;
            this.CreateTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateTableLayoutPanel.ColumnCount = 1;
            this.CreateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CreateTableLayoutPanel.Controls.Add(this.StartDrawingButton, 0, 3);
            this.CreateTableLayoutPanel.Controls.Add(this.StopDrawingButton, 0, 4);
            this.CreateTableLayoutPanel.Controls.Add(this.CreateCustomButton, 0, 2);
            this.CreateTableLayoutPanel.Controls.Add(this.CreateRectangleButton, 0, 1);
            this.CreateTableLayoutPanel.Controls.Add(this.CreateTriangleButton, 0, 0);
            this.CreateTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.CreateTableLayoutPanel.Name = "CreateTableLayoutPanel";
            this.CreateTableLayoutPanel.RowCount = 5;
            this.CreateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.CreateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.CreateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.CreateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.CreateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.CreateTableLayoutPanel.Size = new System.Drawing.Size(179, 155);
            this.CreateTableLayoutPanel.TabIndex = 0;
            // 
            // StartDrawingButton
            // 
            this.StartDrawingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StartDrawingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.StartDrawingButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.StartDrawingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StartDrawingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartDrawingButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StartDrawingButton.Location = new System.Drawing.Point(3, 96);
            this.StartDrawingButton.Name = "StartDrawingButton";
            this.StartDrawingButton.Size = new System.Drawing.Size(173, 25);
            this.StartDrawingButton.TabIndex = 1;
            this.StartDrawingButton.TabStop = false;
            this.StartDrawingButton.Text = "Start drawing";
            this.StartDrawingButton.UseVisualStyleBackColor = false;
            // 
            // StopDrawingButton
            // 
            this.StopDrawingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StopDrawingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.StopDrawingButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.StopDrawingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StopDrawingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopDrawingButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StopDrawingButton.Location = new System.Drawing.Point(3, 127);
            this.StopDrawingButton.Name = "StopDrawingButton";
            this.StopDrawingButton.Size = new System.Drawing.Size(173, 25);
            this.StopDrawingButton.TabIndex = 2;
            this.StopDrawingButton.TabStop = false;
            this.StopDrawingButton.Text = "Stop drawing";
            this.StopDrawingButton.UseVisualStyleBackColor = false;
            // 
            // CreateCustomButton
            // 
            this.CreateCustomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreateCustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateCustomButton.Location = new System.Drawing.Point(3, 65);
            this.CreateCustomButton.Name = "CreateCustomButton";
            this.CreateCustomButton.Size = new System.Drawing.Size(173, 25);
            this.CreateCustomButton.TabIndex = 7;
            this.CreateCustomButton.TabStop = false;
            this.CreateCustomButton.Text = "Custom";
            this.CreateCustomButton.UseVisualStyleBackColor = false;
            // 
            // CreateRectangleButton
            // 
            this.CreateRectangleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreateRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateRectangleButton.Location = new System.Drawing.Point(3, 34);
            this.CreateRectangleButton.Name = "CreateRectangleButton";
            this.CreateRectangleButton.Size = new System.Drawing.Size(173, 25);
            this.CreateRectangleButton.TabIndex = 6;
            this.CreateRectangleButton.TabStop = false;
            this.CreateRectangleButton.Text = "Rectangle";
            this.CreateRectangleButton.UseVisualStyleBackColor = false;
            // 
            // CreateTriangleButton
            // 
            this.CreateTriangleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreateTriangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTriangleButton.Location = new System.Drawing.Point(3, 3);
            this.CreateTriangleButton.Name = "CreateTriangleButton";
            this.CreateTriangleButton.Size = new System.Drawing.Size(173, 25);
            this.CreateTriangleButton.TabIndex = 5;
            this.CreateTriangleButton.TabStop = false;
            this.CreateTriangleButton.Text = "Triangle";
            this.CreateTriangleButton.UseVisualStyleBackColor = false;
            // 
            // EditVerticeGroupBox
            // 
            this.EditVerticeGroupBox.Controls.Add(this.EditVerticeTableLayoutPanel);
            this.EditVerticeGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EditVerticeGroupBox.Location = new System.Drawing.Point(3, 3);
            this.EditVerticeGroupBox.Name = "EditVerticeGroupBox";
            this.EditVerticeGroupBox.Size = new System.Drawing.Size(185, 50);
            this.EditVerticeGroupBox.TabIndex = 0;
            this.EditVerticeGroupBox.TabStop = false;
            this.EditVerticeGroupBox.Text = "Edit vertice";
            // 
            // EditVerticeTableLayoutPanel
            // 
            this.EditVerticeTableLayoutPanel.ColumnCount = 1;
            this.EditVerticeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EditVerticeTableLayoutPanel.Controls.Add(this.DeleteVerticeButton, 0, 0);
            this.EditVerticeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditVerticeTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.EditVerticeTableLayoutPanel.Name = "EditVerticeTableLayoutPanel";
            this.EditVerticeTableLayoutPanel.RowCount = 1;
            this.EditVerticeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.EditVerticeTableLayoutPanel.Size = new System.Drawing.Size(179, 31);
            this.EditVerticeTableLayoutPanel.TabIndex = 0;
            // 
            // DeleteVerticeButton
            // 
            this.DeleteVerticeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteVerticeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteVerticeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteVerticeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteVerticeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteVerticeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteVerticeButton.Location = new System.Drawing.Point(3, 3);
            this.DeleteVerticeButton.Name = "DeleteVerticeButton";
            this.DeleteVerticeButton.Size = new System.Drawing.Size(173, 25);
            this.DeleteVerticeButton.TabIndex = 0;
            this.DeleteVerticeButton.TabStop = false;
            this.DeleteVerticeButton.Text = "Delete vertice";
            this.DeleteVerticeButton.UseVisualStyleBackColor = false;
            // 
            // EditEdgeGroupBox
            // 
            this.EditEdgeGroupBox.AutoSize = true;
            this.EditEdgeGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditEdgeGroupBox.Controls.Add(this.EditEdgeTableLayoutPanel);
            this.EditEdgeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditEdgeGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EditEdgeGroupBox.Location = new System.Drawing.Point(3, 59);
            this.EditEdgeGroupBox.Name = "EditEdgeGroupBox";
            this.EditEdgeGroupBox.Size = new System.Drawing.Size(185, 205);
            this.EditEdgeGroupBox.TabIndex = 1;
            this.EditEdgeGroupBox.TabStop = false;
            this.EditEdgeGroupBox.Text = "Edit edge";
            // 
            // EditEdgeTableLayoutPanel
            // 
            this.EditEdgeTableLayoutPanel.AutoSize = true;
            this.EditEdgeTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditEdgeTableLayoutPanel.ColumnCount = 1;
            this.EditEdgeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EditEdgeTableLayoutPanel.Controls.Add(this.MakeVerticalButton, 0, 0);
            this.EditEdgeTableLayoutPanel.Controls.Add(this.MakeHorizontalButton, 0, 1);
            this.EditEdgeTableLayoutPanel.Controls.Add(this.MakeFixedLengthButton, 0, 2);
            this.EditEdgeTableLayoutPanel.Controls.Add(this.ChangeLengthButton, 0, 4);
            this.EditEdgeTableLayoutPanel.Controls.Add(this.RemoveConstraintsButton, 0, 3);
            this.EditEdgeTableLayoutPanel.Controls.Add(this.SplitButton, 0, 5);
            this.EditEdgeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditEdgeTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.EditEdgeTableLayoutPanel.Name = "EditEdgeTableLayoutPanel";
            this.EditEdgeTableLayoutPanel.RowCount = 7;
            this.EditEdgeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.EditEdgeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.EditEdgeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.EditEdgeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.EditEdgeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.EditEdgeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.EditEdgeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.EditEdgeTableLayoutPanel.Size = new System.Drawing.Size(179, 186);
            this.EditEdgeTableLayoutPanel.TabIndex = 0;
            // 
            // MakeVerticalButton
            // 
            this.MakeVerticalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MakeVerticalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeVerticalButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MakeVerticalButton.Location = new System.Drawing.Point(3, 3);
            this.MakeVerticalButton.Name = "MakeVerticalButton";
            this.MakeVerticalButton.Size = new System.Drawing.Size(173, 25);
            this.MakeVerticalButton.TabIndex = 1;
            this.MakeVerticalButton.TabStop = false;
            this.MakeVerticalButton.Text = "Make vertical";
            this.MakeVerticalButton.UseVisualStyleBackColor = false;
            // 
            // MakeHorizontalButton
            // 
            this.MakeHorizontalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MakeHorizontalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeHorizontalButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MakeHorizontalButton.Location = new System.Drawing.Point(3, 34);
            this.MakeHorizontalButton.Name = "MakeHorizontalButton";
            this.MakeHorizontalButton.Size = new System.Drawing.Size(173, 25);
            this.MakeHorizontalButton.TabIndex = 2;
            this.MakeHorizontalButton.TabStop = false;
            this.MakeHorizontalButton.Text = "Make horizontal";
            this.MakeHorizontalButton.UseVisualStyleBackColor = false;
            // 
            // MakeFixedLengthButton
            // 
            this.MakeFixedLengthButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MakeFixedLengthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeFixedLengthButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MakeFixedLengthButton.Location = new System.Drawing.Point(3, 65);
            this.MakeFixedLengthButton.Name = "MakeFixedLengthButton";
            this.MakeFixedLengthButton.Size = new System.Drawing.Size(173, 25);
            this.MakeFixedLengthButton.TabIndex = 3;
            this.MakeFixedLengthButton.TabStop = false;
            this.MakeFixedLengthButton.Text = "Make fixed length";
            this.MakeFixedLengthButton.UseVisualStyleBackColor = false;
            // 
            // ChangeLengthButton
            // 
            this.ChangeLengthButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ChangeLengthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeLengthButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ChangeLengthButton.Location = new System.Drawing.Point(3, 127);
            this.ChangeLengthButton.Name = "ChangeLengthButton";
            this.ChangeLengthButton.Size = new System.Drawing.Size(173, 25);
            this.ChangeLengthButton.TabIndex = 4;
            this.ChangeLengthButton.TabStop = false;
            this.ChangeLengthButton.Text = "Change length";
            this.ChangeLengthButton.UseVisualStyleBackColor = false;
            // 
            // RemoveConstraintsButton
            // 
            this.RemoveConstraintsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RemoveConstraintsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveConstraintsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RemoveConstraintsButton.Location = new System.Drawing.Point(3, 96);
            this.RemoveConstraintsButton.Name = "RemoveConstraintsButton";
            this.RemoveConstraintsButton.Size = new System.Drawing.Size(173, 25);
            this.RemoveConstraintsButton.TabIndex = 6;
            this.RemoveConstraintsButton.TabStop = false;
            this.RemoveConstraintsButton.Text = "Remove constraints";
            this.RemoveConstraintsButton.UseVisualStyleBackColor = false;
            // 
            // SplitButton
            // 
            this.SplitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SplitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SplitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SplitButton.Location = new System.Drawing.Point(3, 158);
            this.SplitButton.Name = "SplitButton";
            this.SplitButton.Size = new System.Drawing.Size(173, 25);
            this.SplitButton.TabIndex = 7;
            this.SplitButton.TabStop = false;
            this.SplitButton.Text = "Split";
            this.SplitButton.UseVisualStyleBackColor = false;
            // 
            // EditPolygonGroupBox
            // 
            this.EditPolygonGroupBox.Controls.Add(this.tableLayoutPanel3);
            this.EditPolygonGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditPolygonGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EditPolygonGroupBox.Location = new System.Drawing.Point(3, 450);
            this.EditPolygonGroupBox.Name = "EditPolygonGroupBox";
            this.EditPolygonGroupBox.Size = new System.Drawing.Size(185, 81);
            this.EditPolygonGroupBox.TabIndex = 1;
            this.EditPolygonGroupBox.TabStop = false;
            this.EditPolygonGroupBox.Text = "Edit polygon";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.ConvexHullButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.DeletePolygonButton, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(179, 62);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // DeletePolygonButton
            // 
            this.DeletePolygonButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeletePolygonButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeletePolygonButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.DeletePolygonButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeletePolygonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePolygonButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeletePolygonButton.Location = new System.Drawing.Point(3, 3);
            this.DeletePolygonButton.Name = "DeletePolygonButton";
            this.DeletePolygonButton.Size = new System.Drawing.Size(173, 25);
            this.DeletePolygonButton.TabIndex = 0;
            this.DeletePolygonButton.TabStop = false;
            this.DeletePolygonButton.Text = "Delete polygon";
            this.DeletePolygonButton.UseVisualStyleBackColor = false;
            // 
            // drawingArea
            // 
            this.drawingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.drawingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingArea.Location = new System.Drawing.Point(3, 3);
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.Size = new System.Drawing.Size(981, 806);
            this.drawingArea.TabIndex = 1;
            this.drawingArea.TabStop = false;
            // 
            // ConvexHullButton
            // 
            this.ConvexHullButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ConvexHullButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConvexHullButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.ConvexHullButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ConvexHullButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvexHullButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ConvexHullButton.Location = new System.Drawing.Point(3, 34);
            this.ConvexHullButton.Name = "ConvexHullButton";
            this.ConvexHullButton.Size = new System.Drawing.Size(173, 25);
            this.ConvexHullButton.TabIndex = 1;
            this.ConvexHullButton.TabStop = false;
            this.ConvexHullButton.Text = "Convex hull";
            this.ConvexHullButton.UseVisualStyleBackColor = false;
            // 
            // PolygonEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1184, 812);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 850);
            this.Name = "PolygonEditor";
            this.Text = "Polygon Editor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.CreateGroupBox.ResumeLayout(false);
            this.CreateGroupBox.PerformLayout();
            this.CreateTableLayoutPanel.ResumeLayout(false);
            this.EditVerticeGroupBox.ResumeLayout(false);
            this.EditVerticeTableLayoutPanel.ResumeLayout(false);
            this.EditEdgeGroupBox.ResumeLayout(false);
            this.EditEdgeGroupBox.PerformLayout();
            this.EditEdgeTableLayoutPanel.ResumeLayout(false);
            this.EditPolygonGroupBox.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox EditVerticeGroupBox;
        private System.Windows.Forms.TableLayoutPanel EditVerticeTableLayoutPanel;
        private System.Windows.Forms.Button DeleteVerticeButton;
        private System.Windows.Forms.GroupBox CreateGroupBox;
        private System.Windows.Forms.TableLayoutPanel CreateTableLayoutPanel;
        private System.Windows.Forms.GroupBox EditEdgeGroupBox;
        private System.Windows.Forms.TableLayoutPanel EditEdgeTableLayoutPanel;
        private System.Windows.Forms.Button MakeVerticalButton;
        private System.Windows.Forms.Button CreateCustomButton;
        private System.Windows.Forms.Button CreateRectangleButton;
        private System.Windows.Forms.Button CreateTriangleButton;
        private System.Windows.Forms.Button MakeHorizontalButton;
        private System.Windows.Forms.Button MakeFixedLengthButton;
        private System.Windows.Forms.Button ChangeLengthButton;
        private System.Windows.Forms.Button RemoveConstraintsButton;
        private System.Windows.Forms.Button SplitButton;
        private System.Windows.Forms.PictureBox drawingArea;
        private System.Windows.Forms.Button FakeButton;
        private System.Windows.Forms.GroupBox EditPolygonGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button DeletePolygonButton;
        private System.Windows.Forms.Button StartDrawingButton;
        private System.Windows.Forms.Button StopDrawingButton;
        private System.Windows.Forms.Button ConvexHullButton;
    }
}

