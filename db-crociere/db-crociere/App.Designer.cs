﻿
namespace db_crociere
{
    partial class App
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
            this.menuContainer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.shipPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.shipListContainer = new System.Windows.Forms.SplitContainer();
            this.shipListBoxContainer = new System.Windows.Forms.GroupBox();
            this.shipListBox = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.AddShipBtn = new System.Windows.Forms.Button();
            this.DeleteShipBtn = new System.Windows.Forms.Button();
            this.InfoShipBox = new System.Windows.Forms.GroupBox();
            this.RouteShipBox = new System.Windows.Forms.GroupBox();
            this.NavigationBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.NavigationListBox = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddNavigationBtn = new System.Windows.Forms.Button();
            this.RemoveNavigationBtn = new System.Windows.Forms.Button();
            this.menuContainer.SuspendLayout();
            this.shipPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipListContainer)).BeginInit();
            this.shipListContainer.Panel1.SuspendLayout();
            this.shipListContainer.Panel2.SuspendLayout();
            this.shipListContainer.SuspendLayout();
            this.shipListBoxContainer.SuspendLayout();
            this.NavigationBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuContainer
            // 
            this.menuContainer.Controls.Add(this.tabPage1);
            this.menuContainer.Controls.Add(this.shipPage);
            this.menuContainer.Controls.Add(this.tabPage3);
            this.menuContainer.Location = new System.Drawing.Point(12, 12);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.SelectedIndex = 0;
            this.menuContainer.Size = new System.Drawing.Size(996, 608);
            this.menuContainer.TabIndex = 0;
            this.menuContainer.Click += new System.EventHandler(this.onShipTabClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(988, 582);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // shipPage
            // 
            this.shipPage.Controls.Add(this.splitContainer1);
            this.shipPage.Location = new System.Drawing.Point(4, 22);
            this.shipPage.Name = "shipPage";
            this.shipPage.Padding = new System.Windows.Forms.Padding(3);
            this.shipPage.Size = new System.Drawing.Size(988, 582);
            this.shipPage.TabIndex = 1;
            this.shipPage.Text = "Navi";
            this.shipPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.shipListContainer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.NavigationBox);
            this.splitContainer1.Panel2.Controls.Add(this.RouteShipBox);
            this.splitContainer1.Panel2.Controls.Add(this.InfoShipBox);
            this.splitContainer1.Size = new System.Drawing.Size(982, 576);
            this.splitContainer1.SplitterDistance = 225;
            this.splitContainer1.TabIndex = 0;
            // 
            // shipListContainer
            // 
            this.shipListContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shipListContainer.Location = new System.Drawing.Point(0, 0);
            this.shipListContainer.Name = "shipListContainer";
            this.shipListContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // shipListContainer.Panel1
            // 
            this.shipListContainer.Panel1.Controls.Add(this.shipListBoxContainer);
            // 
            // shipListContainer.Panel2
            // 
            this.shipListContainer.Panel2.Controls.Add(this.DeleteShipBtn);
            this.shipListContainer.Panel2.Controls.Add(this.AddShipBtn);
            this.shipListContainer.Size = new System.Drawing.Size(225, 576);
            this.shipListContainer.SplitterDistance = 465;
            this.shipListContainer.TabIndex = 0;
            // 
            // shipListBoxContainer
            // 
            this.shipListBoxContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shipListBoxContainer.Controls.Add(this.shipListBox);
            this.shipListBoxContainer.Location = new System.Drawing.Point(3, 3);
            this.shipListBoxContainer.Name = "shipListBoxContainer";
            this.shipListBoxContainer.Size = new System.Drawing.Size(219, 459);
            this.shipListBoxContainer.TabIndex = 0;
            this.shipListBoxContainer.TabStop = false;
            this.shipListBoxContainer.Text = "Navi";
            // 
            // shipListBox
            // 
            this.shipListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shipListBox.FormattingEnabled = true;
            this.shipListBox.Location = new System.Drawing.Point(6, 19);
            this.shipListBox.Name = "shipListBox";
            this.shipListBox.Size = new System.Drawing.Size(207, 433);
            this.shipListBox.TabIndex = 0;
            this.shipListBox.Click += new System.EventHandler(this.test);
            this.shipListBox.SelectedIndexChanged += new System.EventHandler(this.shipListBox_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(988, 582);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // AddShipBtn
            // 
            this.AddShipBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddShipBtn.Location = new System.Drawing.Point(9, 12);
            this.AddShipBtn.Name = "AddShipBtn";
            this.AddShipBtn.Size = new System.Drawing.Size(94, 79);
            this.AddShipBtn.TabIndex = 0;
            this.AddShipBtn.Text = "Aggiungi";
            this.AddShipBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteShipBtn
            // 
            this.DeleteShipBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteShipBtn.Location = new System.Drawing.Point(124, 12);
            this.DeleteShipBtn.Name = "DeleteShipBtn";
            this.DeleteShipBtn.Size = new System.Drawing.Size(92, 79);
            this.DeleteShipBtn.TabIndex = 1;
            this.DeleteShipBtn.Text = "Rimuovi";
            this.DeleteShipBtn.UseVisualStyleBackColor = true;
            // 
            // InfoShipBox
            // 
            this.InfoShipBox.Location = new System.Drawing.Point(3, 3);
            this.InfoShipBox.Name = "InfoShipBox";
            this.InfoShipBox.Size = new System.Drawing.Size(413, 245);
            this.InfoShipBox.TabIndex = 0;
            this.InfoShipBox.TabStop = false;
            this.InfoShipBox.Text = "Info Nave";
            // 
            // RouteShipBox
            // 
            this.RouteShipBox.Location = new System.Drawing.Point(423, 3);
            this.RouteShipBox.Name = "RouteShipBox";
            this.RouteShipBox.Size = new System.Drawing.Size(327, 245);
            this.RouteShipBox.TabIndex = 1;
            this.RouteShipBox.TabStop = false;
            this.RouteShipBox.Text = "Percorso";
            // 
            // NavigationBox
            // 
            this.NavigationBox.Controls.Add(this.flowLayoutPanel1);
            this.NavigationBox.Location = new System.Drawing.Point(3, 254);
            this.NavigationBox.Name = "NavigationBox";
            this.NavigationBox.Size = new System.Drawing.Size(747, 319);
            this.NavigationBox.TabIndex = 3;
            this.NavigationBox.TabStop = false;
            this.NavigationBox.Text = "Navigazioni";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.NavigationListBox);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(547, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 300);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // NavigationListBox
            // 
            this.NavigationListBox.FormattingEnabled = true;
            this.NavigationListBox.Location = new System.Drawing.Point(3, 3);
            this.NavigationListBox.Name = "NavigationListBox";
            this.NavigationListBox.Size = new System.Drawing.Size(197, 251);
            this.NavigationListBox.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.AddNavigationBtn);
            this.flowLayoutPanel2.Controls.Add(this.RemoveNavigationBtn);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 270);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(191, 30);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // AddNavigationBtn
            // 
            this.AddNavigationBtn.Location = new System.Drawing.Point(3, 3);
            this.AddNavigationBtn.Name = "AddNavigationBtn";
            this.AddNavigationBtn.Size = new System.Drawing.Size(75, 23);
            this.AddNavigationBtn.TabIndex = 0;
            this.AddNavigationBtn.Text = "Aggiungi";
            this.AddNavigationBtn.UseVisualStyleBackColor = true;
            // 
            // RemoveNavigationBtn
            // 
            this.RemoveNavigationBtn.Location = new System.Drawing.Point(84, 3);
            this.RemoveNavigationBtn.Name = "RemoveNavigationBtn";
            this.RemoveNavigationBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveNavigationBtn.TabIndex = 1;
            this.RemoveNavigationBtn.Text = "Cancella";
            this.RemoveNavigationBtn.UseVisualStyleBackColor = true;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 632);
            this.Controls.Add(this.menuContainer);
            this.Name = "App";
            this.Text = "App";
            this.menuContainer.ResumeLayout(false);
            this.shipPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.shipListContainer.Panel1.ResumeLayout(false);
            this.shipListContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shipListContainer)).EndInit();
            this.shipListContainer.ResumeLayout(false);
            this.shipListBoxContainer.ResumeLayout(false);
            this.NavigationBox.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menuContainer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage shipPage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer shipListContainer;
        private System.Windows.Forms.GroupBox shipListBoxContainer;
        private System.Windows.Forms.ListBox shipListBox;
        private System.Windows.Forms.Button DeleteShipBtn;
        private System.Windows.Forms.Button AddShipBtn;
        private System.Windows.Forms.GroupBox NavigationBox;
        private System.Windows.Forms.GroupBox RouteShipBox;
        private System.Windows.Forms.GroupBox InfoShipBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox NavigationListBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button AddNavigationBtn;
        private System.Windows.Forms.Button RemoveNavigationBtn;
    }
}