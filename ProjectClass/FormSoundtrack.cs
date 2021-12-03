using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WinPlay
{
    public partial class FormSoundtrack : Form
    {
        public FormSoundtrack()
        {
            InitializeComponent();
        }
        private void btnLoadFiles_Click(object sender, EventArgs e)
        {
            Stream mystream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "C:\\Users\\Admin\\Desktop";
            openFileDialog1.Filter = "MP3 Audio File (*.mp3)|*.mp3|Windows Media Audio File(*.wma)|*.wma|WAV Audio File (*.wav)|*.wav|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = false;
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((mystream = openFileDialog1.OpenFile()) != null)
                    {
                        using (mystream)
                        {
                            string[] filename = openFileDialog1.SafeFileNames;
                            string[] fileNameAndPath = openFileDialog1.FileNames;

                            for (int i = 0; i < openFileDialog1.SafeFileNames.Count(); i++)
                            {
                                string[] saLvwItem = new string[2];

                                saLvwItem[0] = filename[i];
                                saLvwItem[1] = fileNameAndPath[i];

                                ListViewItem lvi = new ListViewItem(saLvwItem);

                                listView1.Items.Add(lvi);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void btnPlayAll_Click(object sender, EventArgs e)
        {
            WMPLib.IWMPPlaylist playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist("myplaylist");
            WMPLib.IWMPMedia media;

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                int ii = 1;
                media = axWindowsMediaPlayer1.newMedia(listView1.Items[i].SubItems[ii].Text);
                playlist.appendItem(media);
                ii++;
                axWindowsMediaPlayer1.currentPlaylist = playlist;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string selectedFile = listView1.FocusedItem.SubItems[1].Text;
            axWindowsMediaPlayer1.URL = selectedFile;
        }

        private void FormSoundtrack_FormClosing(object sender, FormClosingEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void DeleteList1_Click(object sender, EventArgs e)
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected)
                {
                    listView1.Items[i].Remove();
                }
            }
        }
    }
}
