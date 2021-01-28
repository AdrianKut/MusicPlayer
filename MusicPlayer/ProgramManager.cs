using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media;

namespace MusicPlayer
{
    class ProgramManager
    {

        public Button buttonFolder { get; private set; }
        public Button buttonPrevious { get; private set; }
        public Button buttonPlay { get; private set; }
        public Button buttonPause { get; private set; }
        public Button buttonNext { get; private set; }

        public Label labelCurrentSong { get; private set; }
        public Label labelLength { get; private set; }
        public Label labelLengthMax { get; private set; }

        public ListBox listBoxPlaylist { get; private set; }

        public OpenFileDialog openFile { get; private set; }

        private List<string> songsPath = new List<string>();

        public MediaPlayer mediaPlayer = new MediaPlayer();

        private TimeSpan currentMusicPosition;

        private int counterToSplitPartSongs = 0;
        private bool firstPartOfSong = true;
        private bool secondPartOfSong = false;

        static string currentSongName = "";

        public ProgramManager(Button buttonFolder, Button buttonPrevious, Button buttonPlay, Button buttonPause,
            Button buttonNext, Label labelCurrentSong, Label labelLength, Label labelLengthMax,
            ListBox listBoxPlaylist, OpenFileDialog openFile)
        {
            this.buttonFolder = buttonFolder;
            this.buttonPrevious = buttonPrevious;
            this.buttonPlay = buttonPlay;
            this.buttonPause = buttonPause;
            this.buttonNext = buttonNext;
            this.labelCurrentSong = labelCurrentSong;
            this.labelLength = labelLength;
            this.labelLengthMax = labelLengthMax;
            this.listBoxPlaylist = listBoxPlaylist;
            this.openFile = openFile;

            this.counterToSplitPartSongs = 0;
            this.firstPartOfSong = true;
            this.secondPartOfSong = false;
        }

        public void InitialImageButtons()
        {
            buttonFolder.Image = Properties.Resources.Folder;
            buttonPrevious.Image = Properties.Resources.Previous;
            buttonPlay.Image = Properties.Resources.Play;
            buttonNext.Image = Properties.Resources.Next;
            buttonPause.Image = Properties.Resources.Pause;
        }

        public void NextSong()
        {

            if (listBoxPlaylist.Items.Count != 0)
            {
                if (listBoxPlaylist.SelectedIndex == listBoxPlaylist.Items.Count - 1)
                {
                    listBoxPlaylist.SelectedIndex = 0;
                    PlaySelectedMusic();
                }
                else
                {
                    listBoxPlaylist.SelectedIndex = listBoxPlaylist.SelectedIndex + 1;
                    PlaySelectedMusic();
                }
            }
        }

        public void PreviousSong()
        {
            if (listBoxPlaylist.Items.Count != 0)
            {
                if (listBoxPlaylist.SelectedIndex == 0)
                {
                    listBoxPlaylist.SelectedIndex = listBoxPlaylist.Items.Count - 1;
                    PlaySelectedMusic();
                }
                else
                {
                    try
                    {
                        listBoxPlaylist.SelectedIndex = listBoxPlaylist.SelectedIndex - 1;
                        PlaySelectedMusic();
                    }
                    catch (Exception)
                    {
                        listBoxPlaylist.SelectedIndex = 0;
                        PlaySelectedMusic();
                    }
                }
            }
        }

        public void OpenFile()
        {
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFile.Title = "Select song";
            openFile.FileName = "yoursong";
            openFile.Filter = "mp3 files (*.mp3)|*.mp3|wav files (*.wav)|*wav";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                AddFileToPlaylist(openFile.FileName);
                listBoxPlaylist.Items.Add(Path.GetFileName(openFile.FileName));
                listBoxPlaylist.SelectedIndex = 0;
            }
        }

        public void CurrentMusicPosition()
        {
            if (mediaPlayer.NaturalDuration.HasTimeSpan)
            {
                var lengthMax = mediaPlayer.NaturalDuration.TimeSpan;

                labelLengthMax.Text = ($"{lengthMax.Hours}:{lengthMax.Minutes}:{lengthMax.Seconds}:{lengthMax.Milliseconds}");

                if (mediaPlayer.Position.TotalMilliseconds == mediaPlayer.NaturalDuration.TimeSpan.TotalMilliseconds)
                {
                    NextSong();
                }

            }

            currentMusicPosition = mediaPlayer.Position;
            labelLength.Text = ($"{currentMusicPosition.Hours}:{currentMusicPosition.Minutes}" +
                $":{currentMusicPosition.Seconds}:{currentMusicPosition.Milliseconds}");
        }

        public void RemovePlaylistItem(KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    listBoxPlaylist.Items.RemoveAt(listBoxPlaylist.SelectedIndex);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Choose your file to remove", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void AddFileToPlaylist(string item)
        {
            songsPath.Add(item);
        }

        public void DropFile(DragEventArgs e)
        {

            string[] droppedFile = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (var item in droppedFile)
            {

                AddFileToPlaylist(item);
                string temp = Path.GetFileName(item);
                listBoxPlaylist.Items.Add(temp);
                listBoxPlaylist.SelectedIndex = 0;
            }
        }

        bool isPaused = false;
        public void Pause()
        {
            isPaused = !isPaused;
            if (isPaused)
            {
                mediaPlayer.Pause();
                mediaPlayer.Position = currentMusicPosition;
            }
            if (!isPaused)
            {
                mediaPlayer.Play();
           }
        }
        public void SetLabelCurrentSong()
        {

            if (listBoxPlaylist.Items.Count > 0)
            {
                int wordsLength = currentSongName.Length;

                if (wordsLength > 25)
                {
                    string[] tempSongNameToSplit = currentSongName.Split(new char[] { '-' });

                    if (counterToSplitPartSongs < 5 && firstPartOfSong)
                    {
                        secondPartOfSong = false;
                        labelCurrentSong.Text = tempSongNameToSplit[0];
                        counterToSplitPartSongs++;
                    }
                    else
                    {
                        secondPartOfSong = true;
                    }

                    if (counterToSplitPartSongs > 0 && secondPartOfSong)
                    {
                        firstPartOfSong = false;
                        labelCurrentSong.Text = tempSongNameToSplit[1];
                        counterToSplitPartSongs--;
                    }
                    else
                    {
                        firstPartOfSong = true;
                    }
                }
                else { labelCurrentSong.Text = "" + currentSongName; }
            }
        }

        public void PlaySelectedMusic()
        {
            foreach (string item in songsPath)
            {
                if (Path.GetFileName(item).Equals(listBoxPlaylist.SelectedItem))
                {
                    mediaPlayer.Open(new Uri(item));
                    mediaPlayer.Play();

                    currentSongName = listBoxPlaylist.SelectedItem.ToString();

                }
            }
        }

    }
}
