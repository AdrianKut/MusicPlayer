namespace MusicPlayer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.listBoxPlaylist = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLengthMax = new System.Windows.Forms.Label();
            this.labelLengthCurrent = new System.Windows.Forms.Label();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.labelCurrentSong = new System.Windows.Forms.Label();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Timer(this.components);
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogMain
            // 
            this.openFileDialogMain.FileName = "openFileDialog1";
            // 
            // timerMain
            // 
            this.timerMain.Interval = 25;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BackgroundImage = global::MusicPlayer.Properties.Resources.BacgroundMiddleTransparent;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.listBoxPlaylist);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.labelLengthMax);
            this.panelMain.Controls.Add(this.labelLengthCurrent);
            this.panelMain.Controls.Add(this.buttonFolder);
            this.panelMain.Controls.Add(this.labelCurrentSong);
            this.panelMain.Controls.Add(this.buttonPause);
            this.panelMain.Controls.Add(this.buttonNext);
            this.panelMain.Controls.Add(this.buttonPlay);
            this.panelMain.Controls.Add(this.buttonPrevious);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(292, 469);
            this.panelMain.TabIndex = 0;
            // 
            // listBoxPlaylist
            // 
            this.listBoxPlaylist.AllowDrop = true;
            this.listBoxPlaylist.BackColor = System.Drawing.Color.GhostWhite;
            this.listBoxPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPlaylist.Font = new System.Drawing.Font("Lato", 8F);
            this.listBoxPlaylist.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBoxPlaylist.FormattingEnabled = true;
            this.listBoxPlaylist.Location = new System.Drawing.Point(88, 9);
            this.listBoxPlaylist.Name = "listBoxPlaylist";
            this.listBoxPlaylist.Size = new System.Drawing.Size(190, 65);
            this.listBoxPlaylist.TabIndex = 10;
            this.listBoxPlaylist.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBoxPlaylist.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            this.listBoxPlaylist.DoubleClick += new System.EventHandler(this.listBoxPlaylist_DoubleClick);
            this.listBoxPlaylist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxPlaylist_KeyDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lato", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(136, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "/";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelLengthMax
            // 
            this.labelLengthMax.Font = new System.Drawing.Font("Lato", 12F);
            this.labelLengthMax.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelLengthMax.Location = new System.Drawing.Point(172, 92);
            this.labelLengthMax.Name = "labelLengthMax";
            this.labelLengthMax.Size = new System.Drawing.Size(88, 23);
            this.labelLengthMax.TabIndex = 8;
            this.labelLengthMax.Text = "00:00:00";
            this.labelLengthMax.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelLengthCurrent
            // 
            this.labelLengthCurrent.Font = new System.Drawing.Font("Lato", 12F);
            this.labelLengthCurrent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLengthCurrent.Location = new System.Drawing.Point(31, 92);
            this.labelLengthCurrent.Name = "labelLengthCurrent";
            this.labelLengthCurrent.Size = new System.Drawing.Size(88, 23);
            this.labelLengthCurrent.TabIndex = 7;
            this.labelLengthCurrent.Text = "label1";
            this.labelLengthCurrent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonFolder
            // 
            this.buttonFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFolder.FlatAppearance.BorderSize = 0;
            this.buttonFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFolder.Location = new System.Drawing.Point(22, 20);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(45, 40);
            this.buttonFolder.TabIndex = 1;
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            this.buttonFolder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonFolder_MouseDown);
            this.buttonFolder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonFolder_MouseUp);
            // 
            // labelCurrentSong
            // 
            this.labelCurrentSong.AutoSize = true;
            this.labelCurrentSong.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentSong.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrentSong.ForeColor = System.Drawing.Color.Transparent;
            this.labelCurrentSong.Location = new System.Drawing.Point(46, 342);
            this.labelCurrentSong.Name = "labelCurrentSong";
            this.labelCurrentSong.Size = new System.Drawing.Size(133, 19);
            this.labelCurrentSong.TabIndex = 0;
            this.labelCurrentSong.Text = "Choose your song";
            this.labelCurrentSong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonPause
            // 
            this.buttonPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPause.FlatAppearance.BorderSize = 0;
            this.buttonPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPause.Location = new System.Drawing.Point(88, 386);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(55, 55);
            this.buttonPause.TabIndex = 11;
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.button1_Click);
            this.buttonPause.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPause_MouseDown);
            this.buttonPause.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonPause_MouseUp);
            // 
            // buttonNext
            // 
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Location = new System.Drawing.Point(209, 386);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(55, 55);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            this.buttonNext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonNext_MouseDown);
            this.buttonNext.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonNext_MouseUp);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Location = new System.Drawing.Point(150, 386);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(55, 55);
            this.buttonPlay.TabIndex = 4;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            this.buttonPlay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPlay_MouseDown);
            this.buttonPlay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonPlay_MouseUp);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrevious.FlatAppearance.BorderSize = 0;
            this.buttonPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevious.Location = new System.Drawing.Point(29, 386);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(55, 55);
            this.buttonPrevious.TabIndex = 3;
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            this.buttonPrevious.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPrevious_MouseDown);
            this.buttonPrevious.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonPrevious_MouseUp);
            // 
            // timerLabel
            // 
            this.timerLabel.Interval = 1000;
            this.timerLabel.Tick += new System.EventHandler(this.timerLabel_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(291, 466);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player by Adrian Kut @2020";
            this.TransparencyKey = System.Drawing.Color.DarkGray;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelCurrentSong;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Label labelLengthCurrent;
        private System.Windows.Forms.Label labelLengthMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPlaylist;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Timer timerLabel;
    }
}

