﻿namespace KSU.CIS300.TowersOfHanoi
{
    partial class UserInterface
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
            this.uxButtonNewPuzzle = new System.Windows.Forms.Button();
            this.uxNumDiscs = new System.Windows.Forms.NumericUpDown();
            this.uxMoveCount = new System.Windows.Forms.Label();
            this.uxMoves = new System.Windows.Forms.Label();
            this.uxButtonSolve = new System.Windows.Forms.Button();
            this.uxDelay = new System.Windows.Forms.Label();
            this.uxNumSeconds = new System.Windows.Forms.NumericUpDown();
            this.uxFlowLayoutPanelPegA = new System.Windows.Forms.FlowLayoutPanel();
            this.uxFlowLayoutPanelPegB = new System.Windows.Forms.FlowLayoutPanel();
            this.uxFlowLayoutPanelPegC = new System.Windows.Forms.FlowLayoutPanel();
            this.uxMoveLeft1 = new System.Windows.Forms.Button();
            this.uxMoveRight1 = new System.Windows.Forms.Button();
            this.uxMoveRight2 = new System.Windows.Forms.Button();
            this.uxMoveLeft2 = new System.Windows.Forms.Button();
            this.uxMoveRight3 = new System.Windows.Forms.Button();
            this.uxMoveLeft3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumDiscs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // uxButtonNewPuzzle
            // 
            this.uxButtonNewPuzzle.BackColor = System.Drawing.Color.LightSlateGray;
            this.uxButtonNewPuzzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.uxButtonNewPuzzle.Location = new System.Drawing.Point(16, 12);
            this.uxButtonNewPuzzle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxButtonNewPuzzle.Name = "uxButtonNewPuzzle";
            this.uxButtonNewPuzzle.Size = new System.Drawing.Size(114, 31);
            this.uxButtonNewPuzzle.TabIndex = 0;
            this.uxButtonNewPuzzle.Text = "New Game";
            this.uxButtonNewPuzzle.UseVisualStyleBackColor = false;
            this.uxButtonNewPuzzle.Click += new System.EventHandler(this.uxButtonNewPuzzle_Click);
            // 
            // uxNumDiscs
            // 
            this.uxNumDiscs.Location = new System.Drawing.Point(138, 17);
            this.uxNumDiscs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxNumDiscs.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.uxNumDiscs.Name = "uxNumDiscs";
            this.uxNumDiscs.Size = new System.Drawing.Size(77, 22);
            this.uxNumDiscs.TabIndex = 1;
            this.uxNumDiscs.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // uxMoveCount
            // 
            this.uxMoveCount.AutoSize = true;
            this.uxMoveCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.uxMoveCount.Location = new System.Drawing.Point(355, 17);
            this.uxMoveCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxMoveCount.Name = "uxMoveCount";
            this.uxMoveCount.Size = new System.Drawing.Size(111, 22);
            this.uxMoveCount.TabIndex = 2;
            this.uxMoveCount.Text = "Move Count:";
            // 
            // uxMoves
            // 
            this.uxMoves.AutoSize = true;
            this.uxMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.uxMoves.Location = new System.Drawing.Point(473, 18);
            this.uxMoves.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxMoves.Name = "uxMoves";
            this.uxMoves.Size = new System.Drawing.Size(20, 22);
            this.uxMoves.TabIndex = 3;
            this.uxMoves.Text = "0";
            // 
            // uxButtonSolve
            // 
            this.uxButtonSolve.BackColor = System.Drawing.Color.LightSlateGray;
            this.uxButtonSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.uxButtonSolve.Location = new System.Drawing.Point(721, 11);
            this.uxButtonSolve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxButtonSolve.Name = "uxButtonSolve";
            this.uxButtonSolve.Size = new System.Drawing.Size(71, 32);
            this.uxButtonSolve.TabIndex = 4;
            this.uxButtonSolve.Text = "Solve";
            this.uxButtonSolve.UseVisualStyleBackColor = false;
            this.uxButtonSolve.Click += new System.EventHandler(this.uxButtonSolve_Click);
            // 
            // uxDelay
            // 
            this.uxDelay.AutoSize = true;
            this.uxDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.uxDelay.Location = new System.Drawing.Point(801, 17);
            this.uxDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxDelay.Name = "uxDelay";
            this.uxDelay.Size = new System.Drawing.Size(61, 22);
            this.uxDelay.TabIndex = 5;
            this.uxDelay.Text = "Delay:";
            // 
            // uxNumSeconds
            // 
            this.uxNumSeconds.Location = new System.Drawing.Point(867, 17);
            this.uxNumSeconds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxNumSeconds.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.uxNumSeconds.Name = "uxNumSeconds";
            this.uxNumSeconds.Size = new System.Drawing.Size(79, 22);
            this.uxNumSeconds.TabIndex = 7;
            this.uxNumSeconds.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // uxFlowLayoutPanelPegA
            // 
            this.uxFlowLayoutPanelPegA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.uxFlowLayoutPanelPegA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxFlowLayoutPanelPegA.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.uxFlowLayoutPanelPegA.Location = new System.Drawing.Point(16, 68);
            this.uxFlowLayoutPanelPegA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxFlowLayoutPanelPegA.Name = "uxFlowLayoutPanelPegA";
            this.uxFlowLayoutPanelPegA.Size = new System.Drawing.Size(293, 473);
            this.uxFlowLayoutPanelPegA.TabIndex = 8;
            // 
            // uxFlowLayoutPanelPegB
            // 
            this.uxFlowLayoutPanelPegB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.uxFlowLayoutPanelPegB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxFlowLayoutPanelPegB.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.uxFlowLayoutPanelPegB.Location = new System.Drawing.Point(332, 68);
            this.uxFlowLayoutPanelPegB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxFlowLayoutPanelPegB.Name = "uxFlowLayoutPanelPegB";
            this.uxFlowLayoutPanelPegB.Size = new System.Drawing.Size(293, 473);
            this.uxFlowLayoutPanelPegB.TabIndex = 9;
            // 
            // uxFlowLayoutPanelPegC
            // 
            this.uxFlowLayoutPanelPegC.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.uxFlowLayoutPanelPegC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxFlowLayoutPanelPegC.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.uxFlowLayoutPanelPegC.Location = new System.Drawing.Point(649, 68);
            this.uxFlowLayoutPanelPegC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxFlowLayoutPanelPegC.Name = "uxFlowLayoutPanelPegC";
            this.uxFlowLayoutPanelPegC.Size = new System.Drawing.Size(293, 473);
            this.uxFlowLayoutPanelPegC.TabIndex = 10;
            this.uxFlowLayoutPanelPegC.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.uxFlowLayoutPanelPegC_ControlAdded);
            // 
            // uxMoveLeft1
            // 
            this.uxMoveLeft1.BackColor = System.Drawing.Color.SteelBlue;
            this.uxMoveLeft1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.uxMoveLeft1.Location = new System.Drawing.Point(15, 548);
            this.uxMoveLeft1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxMoveLeft1.Name = "uxMoveLeft1";
            this.uxMoveLeft1.Size = new System.Drawing.Size(144, 37);
            this.uxMoveLeft1.TabIndex = 11;
            this.uxMoveLeft1.Text = "Move Left";
            this.uxMoveLeft1.UseVisualStyleBackColor = false;
            this.uxMoveLeft1.Click += new System.EventHandler(this.uxMoveLeft1_Click);
            // 
            // uxMoveRight1
            // 
            this.uxMoveRight1.BackColor = System.Drawing.Color.SteelBlue;
            this.uxMoveRight1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.uxMoveRight1.Location = new System.Drawing.Point(167, 548);
            this.uxMoveRight1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxMoveRight1.Name = "uxMoveRight1";
            this.uxMoveRight1.Size = new System.Drawing.Size(144, 37);
            this.uxMoveRight1.TabIndex = 12;
            this.uxMoveRight1.Text = "Move Right";
            this.uxMoveRight1.UseVisualStyleBackColor = false;
            this.uxMoveRight1.Click += new System.EventHandler(this.uxMoveRight1_Click);
            // 
            // uxMoveRight2
            // 
            this.uxMoveRight2.BackColor = System.Drawing.Color.SteelBlue;
            this.uxMoveRight2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.uxMoveRight2.Location = new System.Drawing.Point(483, 549);
            this.uxMoveRight2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxMoveRight2.Name = "uxMoveRight2";
            this.uxMoveRight2.Size = new System.Drawing.Size(144, 37);
            this.uxMoveRight2.TabIndex = 14;
            this.uxMoveRight2.Text = "Move Right";
            this.uxMoveRight2.UseVisualStyleBackColor = false;
            this.uxMoveRight2.Click += new System.EventHandler(this.uxMoveRight2_Click);
            // 
            // uxMoveLeft2
            // 
            this.uxMoveLeft2.BackColor = System.Drawing.Color.SteelBlue;
            this.uxMoveLeft2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.uxMoveLeft2.Location = new System.Drawing.Point(331, 549);
            this.uxMoveLeft2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxMoveLeft2.Name = "uxMoveLeft2";
            this.uxMoveLeft2.Size = new System.Drawing.Size(144, 37);
            this.uxMoveLeft2.TabIndex = 13;
            this.uxMoveLeft2.Text = "Move Left";
            this.uxMoveLeft2.UseVisualStyleBackColor = false;
            this.uxMoveLeft2.Click += new System.EventHandler(this.uxMoveLeft2_Click);
            // 
            // uxMoveRight3
            // 
            this.uxMoveRight3.BackColor = System.Drawing.Color.SteelBlue;
            this.uxMoveRight3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.uxMoveRight3.Location = new System.Drawing.Point(799, 549);
            this.uxMoveRight3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxMoveRight3.Name = "uxMoveRight3";
            this.uxMoveRight3.Size = new System.Drawing.Size(144, 37);
            this.uxMoveRight3.TabIndex = 16;
            this.uxMoveRight3.Text = "Move Right";
            this.uxMoveRight3.UseVisualStyleBackColor = false;
            this.uxMoveRight3.Click += new System.EventHandler(this.uxMoveRight3_Click);
            // 
            // uxMoveLeft3
            // 
            this.uxMoveLeft3.BackColor = System.Drawing.Color.SteelBlue;
            this.uxMoveLeft3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.uxMoveLeft3.Location = new System.Drawing.Point(647, 549);
            this.uxMoveLeft3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxMoveLeft3.Name = "uxMoveLeft3";
            this.uxMoveLeft3.Size = new System.Drawing.Size(144, 37);
            this.uxMoveLeft3.TabIndex = 15;
            this.uxMoveLeft3.Text = "Move Left";
            this.uxMoveLeft3.UseVisualStyleBackColor = false;
            this.uxMoveLeft3.Click += new System.EventHandler(this.uxMoveLeft3_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 599);
            this.Controls.Add(this.uxMoveRight3);
            this.Controls.Add(this.uxMoveLeft3);
            this.Controls.Add(this.uxMoveRight2);
            this.Controls.Add(this.uxMoveLeft2);
            this.Controls.Add(this.uxMoveRight1);
            this.Controls.Add(this.uxMoveLeft1);
            this.Controls.Add(this.uxFlowLayoutPanelPegC);
            this.Controls.Add(this.uxFlowLayoutPanelPegB);
            this.Controls.Add(this.uxFlowLayoutPanelPegA);
            this.Controls.Add(this.uxNumSeconds);
            this.Controls.Add(this.uxDelay);
            this.Controls.Add(this.uxButtonSolve);
            this.Controls.Add(this.uxMoves);
            this.Controls.Add(this.uxMoveCount);
            this.Controls.Add(this.uxNumDiscs);
            this.Controls.Add(this.uxButtonNewPuzzle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserInterface";
            this.Text = "Tower of Hanoi";
            ((System.ComponentModel.ISupportInitialize)(this.uxNumDiscs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxButtonNewPuzzle;
        private System.Windows.Forms.NumericUpDown uxNumDiscs;
        private System.Windows.Forms.Label uxMoveCount;
        private System.Windows.Forms.Label uxMoves;
        private System.Windows.Forms.Button uxButtonSolve;
        private System.Windows.Forms.Label uxDelay;
        private System.Windows.Forms.NumericUpDown uxNumSeconds;
        private System.Windows.Forms.FlowLayoutPanel uxFlowLayoutPanelPegA;
        private System.Windows.Forms.FlowLayoutPanel uxFlowLayoutPanelPegB;
        private System.Windows.Forms.FlowLayoutPanel uxFlowLayoutPanelPegC;
        private System.Windows.Forms.Button uxMoveLeft1;
        private System.Windows.Forms.Button uxMoveRight1;
        private System.Windows.Forms.Button uxMoveRight2;
        private System.Windows.Forms.Button uxMoveLeft2;
        private System.Windows.Forms.Button uxMoveRight3;
        private System.Windows.Forms.Button uxMoveLeft3;
    }
}

