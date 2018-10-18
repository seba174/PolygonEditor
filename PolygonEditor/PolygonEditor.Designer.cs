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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CreateGroupBox = new System.Windows.Forms.GroupBox();
            this.CreateTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
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
            this.drawingArea = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.CreateGroupBox.SuspendLayout();
            this.CreateTableLayoutPanel.SuspendLayout();
            this.EditVerticeGroupBox.SuspendLayout();
            this.EditVerticeTableLayoutPanel.SuspendLayout();
            this.EditEdgeGroupBox.SuspendLayout();
            this.EditEdgeTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0813F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9187F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.drawingArea, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 661);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.CreateGroupBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.EditVerticeGroupBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.EditEdgeGroupBox, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(790, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.549619F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.01527F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(191, 655);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // CreateGroupBox
            // 
            this.CreateGroupBox.Controls.Add(this.CreateTableLayoutPanel);
            this.CreateGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateGroupBox.Location = new System.Drawing.Point(3, 439);
            this.CreateGroupBox.Name = "CreateGroupBox";
            this.CreateGroupBox.Size = new System.Drawing.Size(185, 213);
            this.CreateGroupBox.TabIndex = 3;
            this.CreateGroupBox.TabStop = false;
            this.CreateGroupBox.Text = "Create";
            // 
            // CreateTableLayoutPanel
            // 
            this.CreateTableLayoutPanel.ColumnCount = 1;
            this.CreateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CreateTableLayoutPanel.Controls.Add(this.button8, 0, 2);
            this.CreateTableLayoutPanel.Controls.Add(this.button7, 0, 1);
            this.CreateTableLayoutPanel.Controls.Add(this.button6, 0, 0);
            this.CreateTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.CreateTableLayoutPanel.Name = "CreateTableLayoutPanel";
            this.CreateTableLayoutPanel.RowCount = 4;
            this.CreateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.CreateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.CreateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.CreateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CreateTableLayoutPanel.Size = new System.Drawing.Size(179, 194);
            this.CreateTableLayoutPanel.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(3, 65);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(173, 25);
            this.button8.TabIndex = 7;
            this.button8.TabStop = false;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 34);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(173, 25);
            this.button7.TabIndex = 6;
            this.button7.TabStop = false;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(173, 25);
            this.button6.TabIndex = 5;
            this.button6.TabStop = false;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // EditVerticeGroupBox
            // 
            this.EditVerticeGroupBox.Controls.Add(this.EditVerticeTableLayoutPanel);
            this.EditVerticeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.DeleteVerticeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteVerticeButton.Location = new System.Drawing.Point(3, 3);
            this.DeleteVerticeButton.Name = "DeleteVerticeButton";
            this.DeleteVerticeButton.Size = new System.Drawing.Size(173, 25);
            this.DeleteVerticeButton.TabIndex = 0;
            this.DeleteVerticeButton.TabStop = false;
            this.DeleteVerticeButton.Text = "Delete vertice";
            this.DeleteVerticeButton.UseVisualStyleBackColor = true;
            // 
            // EditEdgeGroupBox
            // 
            this.EditEdgeGroupBox.Controls.Add(this.EditEdgeTableLayoutPanel);
            this.EditEdgeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditEdgeGroupBox.Location = new System.Drawing.Point(3, 59);
            this.EditEdgeGroupBox.Name = "EditEdgeGroupBox";
            this.EditEdgeGroupBox.Size = new System.Drawing.Size(185, 374);
            this.EditEdgeGroupBox.TabIndex = 1;
            this.EditEdgeGroupBox.TabStop = false;
            this.EditEdgeGroupBox.Text = "Edit edge";
            // 
            // EditEdgeTableLayoutPanel
            // 
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
            this.EditEdgeTableLayoutPanel.Size = new System.Drawing.Size(179, 355);
            this.EditEdgeTableLayoutPanel.TabIndex = 0;
            // 
            // MakeVerticalButton
            // 
            this.MakeVerticalButton.Location = new System.Drawing.Point(3, 3);
            this.MakeVerticalButton.Name = "MakeVerticalButton";
            this.MakeVerticalButton.Size = new System.Drawing.Size(173, 25);
            this.MakeVerticalButton.TabIndex = 1;
            this.MakeVerticalButton.TabStop = false;
            this.MakeVerticalButton.Text = "Make vertical";
            this.MakeVerticalButton.UseVisualStyleBackColor = true;
            // 
            // MakeHorizontalButton
            // 
            this.MakeHorizontalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MakeHorizontalButton.Location = new System.Drawing.Point(3, 34);
            this.MakeHorizontalButton.Name = "MakeHorizontalButton";
            this.MakeHorizontalButton.Size = new System.Drawing.Size(173, 25);
            this.MakeHorizontalButton.TabIndex = 2;
            this.MakeHorizontalButton.TabStop = false;
            this.MakeHorizontalButton.Text = "Make horizontal";
            this.MakeHorizontalButton.UseVisualStyleBackColor = true;
            // 
            // MakeFixedLengthButton
            // 
            this.MakeFixedLengthButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MakeFixedLengthButton.Location = new System.Drawing.Point(3, 65);
            this.MakeFixedLengthButton.Name = "MakeFixedLengthButton";
            this.MakeFixedLengthButton.Size = new System.Drawing.Size(173, 25);
            this.MakeFixedLengthButton.TabIndex = 3;
            this.MakeFixedLengthButton.TabStop = false;
            this.MakeFixedLengthButton.Text = "Make fixed length";
            this.MakeFixedLengthButton.UseVisualStyleBackColor = true;
            // 
            // ChangeLengthButton
            // 
            this.ChangeLengthButton.Location = new System.Drawing.Point(3, 127);
            this.ChangeLengthButton.Name = "ChangeLengthButton";
            this.ChangeLengthButton.Size = new System.Drawing.Size(173, 25);
            this.ChangeLengthButton.TabIndex = 4;
            this.ChangeLengthButton.TabStop = false;
            this.ChangeLengthButton.Text = "Change length";
            this.ChangeLengthButton.UseVisualStyleBackColor = true;
            // 
            // RemoveConstraintsButton
            // 
            this.RemoveConstraintsButton.Location = new System.Drawing.Point(3, 96);
            this.RemoveConstraintsButton.Name = "RemoveConstraintsButton";
            this.RemoveConstraintsButton.Size = new System.Drawing.Size(173, 25);
            this.RemoveConstraintsButton.TabIndex = 6;
            this.RemoveConstraintsButton.TabStop = false;
            this.RemoveConstraintsButton.Text = "Remove constraints";
            this.RemoveConstraintsButton.UseVisualStyleBackColor = true;
            // 
            // SplitButton
            // 
            this.SplitButton.Location = new System.Drawing.Point(3, 158);
            this.SplitButton.Name = "SplitButton";
            this.SplitButton.Size = new System.Drawing.Size(173, 25);
            this.SplitButton.TabIndex = 7;
            this.SplitButton.TabStop = false;
            this.SplitButton.Text = "Split";
            this.SplitButton.UseVisualStyleBackColor = true;
            // 
            // drawingArea
            // 
            this.drawingArea.BackColor = System.Drawing.Color.White;
            this.drawingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingArea.Location = new System.Drawing.Point(3, 3);
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.Size = new System.Drawing.Size(781, 655);
            this.drawingArea.TabIndex = 1;
            this.drawingArea.TabStop = false;
            // 
            // PolygonEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PolygonEditor";
            this.Text = "Polygon Editor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.CreateGroupBox.ResumeLayout(false);
            this.CreateTableLayoutPanel.ResumeLayout(false);
            this.EditVerticeGroupBox.ResumeLayout(false);
            this.EditVerticeTableLayoutPanel.ResumeLayout(false);
            this.EditEdgeGroupBox.ResumeLayout(false);
            this.EditEdgeTableLayoutPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button MakeHorizontalButton;
        private System.Windows.Forms.Button MakeFixedLengthButton;
        private System.Windows.Forms.Button ChangeLengthButton;
        private System.Windows.Forms.Button RemoveConstraintsButton;
        private System.Windows.Forms.Button SplitButton;
        private System.Windows.Forms.PictureBox drawingArea;
    }
}

