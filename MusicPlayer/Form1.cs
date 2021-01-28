using System;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        ProgramManager programManager;

        public Form1()
        {
            InitializeComponent();

            programManager = new ProgramManager(buttonFolder, buttonPrevious, buttonPlay, buttonPause, buttonNext,
                labelCurrentSong, labelLengthCurrent, labelLengthMax, listBoxPlaylist, openFileDialogMain);
            programManager.InitialImageButtons();

            timerMain.Start();
            timerLabel.Start();
        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            programManager.OpenFile();
        }

        #region Changing buttonImages
        private void buttonFolder_MouseDown(object sender, MouseEventArgs e)
        {
            buttonFolder.Image = Properties.Resources.FolderDown;
        }

        private void buttonFolder_MouseUp(object sender, MouseEventArgs e)
        {
            buttonFolder.Image = Properties.Resources.Folder;
        }


        private void buttonPrevious_MouseDown(object sender, MouseEventArgs e)
        {
            buttonPrevious.Image = Properties.Resources.PreviousDown;
        }

        private void buttonPrevious_MouseUp(object sender, MouseEventArgs e)
        {
            buttonPrevious.Image = Properties.Resources.Previous;
        }

        private void buttonPlay_MouseDown(object sender, MouseEventArgs e)
        {
            buttonPlay.Image = Properties.Resources.PlayDown;
        }

        private void buttonPlay_MouseUp(object sender, MouseEventArgs e)
        {
            buttonPlay.Image = Properties.Resources.Play;
        }

        private void buttonPause_MouseDown(object sender, MouseEventArgs e)
        {
            buttonPause.Image = Properties.Resources.PauseDown;
        }

        private void buttonPause_MouseUp(object sender, MouseEventArgs e)
        {
            buttonPause.Image = Properties.Resources.Pause;
        }

        private void buttonNext_MouseDown(object sender, MouseEventArgs e)
        {
            buttonNext.Image = Properties.Resources.NextDown;
        }

        private void buttonNext_MouseUp(object sender, MouseEventArgs e)
        {
            buttonNext.Image = Properties.Resources.Next;
        }
        #endregion

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            programManager.PreviousSong();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            programManager.PlaySelectedMusic();
            timerMain.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            programManager.Pause();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            programManager.NextSong();
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            programManager.DropFile(e);
        }

        private void listBoxPlaylist_DoubleClick(object sender, EventArgs e)
        {
            programManager.PlaySelectedMusic();
        }

        private void listBoxPlaylist_KeyDown(object sender, KeyEventArgs e)
        {
            programManager.RemovePlaylistItem(e);
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            programManager.CurrentMusicPosition();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void timerLabel_Tick(object sender, EventArgs e)
        {
            programManager.SetLabelCurrentSong();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
