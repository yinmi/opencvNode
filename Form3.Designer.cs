
namespace opencvNode
{
    partial class Form3
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
            this.stNodeTreeView1 = new ST.Library.UI.NodeEditor.STNodeTreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.stNodeEditor1 = new ST.Library.UI.NodeEditor.STNodeEditor();
            this.addTabpage = new Sunny.UI.UISymbolButton();
            this.deleteTabpage = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stNodeTreeView1
            // 
            this.stNodeTreeView1.AllowDrop = true;
            this.stNodeTreeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.stNodeTreeView1.FolderCountColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stNodeTreeView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.stNodeTreeView1.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.stNodeTreeView1.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.stNodeTreeView1.Location = new System.Drawing.Point(0, 34);
            this.stNodeTreeView1.MinimumSize = new System.Drawing.Size(100, 60);
            this.stNodeTreeView1.Name = "stNodeTreeView1";
            this.stNodeTreeView1.ShowFolderCount = true;
            this.stNodeTreeView1.Size = new System.Drawing.Size(177, 636);
            this.stNodeTreeView1.TabIndex = 0;
            this.stNodeTreeView1.Text = "stNodeTreeView1";
            this.stNodeTreeView1.TextBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.stNodeTreeView1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Location = new System.Drawing.Point(175, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1252, 672);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.addTapage);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage1.Controls.Add(this.stNodeEditor1);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1244, 632);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // stNodeEditor1
            // 
            this.stNodeEditor1.AllowDrop = true;
            this.stNodeEditor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.stNodeEditor1.Curvature = 0.3F;
            this.stNodeEditor1.Location = new System.Drawing.Point(-4, 1);
            this.stNodeEditor1.LocationBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stNodeEditor1.MarkBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stNodeEditor1.MarkForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stNodeEditor1.MinimumSize = new System.Drawing.Size(100, 100);
            this.stNodeEditor1.Name = "stNodeEditor1";
            this.stNodeEditor1.Size = new System.Drawing.Size(1251, 634);
            this.stNodeEditor1.TabIndex = 0;
            this.stNodeEditor1.Text = "stNodeEditor1";
            this.stNodeEditor1.Click += new System.EventHandler(this.stNodeEditor1_Click);
            // 
            // addTabpage
            // 
            this.addTabpage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTabpage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addTabpage.Location = new System.Drawing.Point(0, 0);
            this.addTabpage.MinimumSize = new System.Drawing.Size(1, 1);
            this.addTabpage.Name = "addTabpage";
            this.addTabpage.Size = new System.Drawing.Size(36, 34);
            this.addTabpage.Symbol = 61543;
            this.addTabpage.TabIndex = 2;
            this.addTabpage.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addTabpage.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // deleteTabpage
            // 
            this.deleteTabpage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteTabpage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deleteTabpage.Location = new System.Drawing.Point(59, 2);
            this.deleteTabpage.MinimumSize = new System.Drawing.Size(1, 1);
            this.deleteTabpage.Name = "deleteTabpage";
            this.deleteTabpage.Size = new System.Drawing.Size(36, 31);
            this.deleteTabpage.TabIndex = 3;
            this.deleteTabpage.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton2.Location = new System.Drawing.Point(118, 2);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.Size = new System.Drawing.Size(37, 32);
            this.uiSymbolButton2.Symbol = 61459;
            this.uiSymbolButton2.TabIndex = 4;
            this.uiSymbolButton2.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // Form3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1426, 668);
            this.Controls.Add(this.uiSymbolButton2);
            this.Controls.Add(this.deleteTabpage);
            this.Controls.Add(this.addTabpage);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.stNodeTreeView1);
            this.Name = "Form3";
            this.PageIndex = 1003;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ST.Library.UI.NodeEditor.STNodeTreeView stNodeTreeView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private ST.Library.UI.NodeEditor.STNodeEditor stNodeEditor1;
        private Sunny.UI.UISymbolButton addTabpage;
        private Sunny.UI.UISymbolButton deleteTabpage;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
    }
}