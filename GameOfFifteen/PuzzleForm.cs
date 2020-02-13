using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GameOfFifteen
{
    public partial class PuzzleForm : Form, View
    {

        Image img;
        private static int user_score = 0;
        private List<PictureBox> pictureboxLists;
        private int puzzle_size;

        Presenter presenter;

        private void Form1_Load(object sender, EventArgs e)
        {
            presenter.NewGame();
        }

        public PuzzleForm()
        {
            InitializeComponent();
            presenter = new Presenter(this);
        }

        public void CreatePictureBox(int value, int puzzle_width, Image image )
        {
            int piece_width_pixel = Utils.puzzle_width_pixel/ puzzle_width;
            PictureBox pb = new PictureBox();
            pb.Parent = this.pnlPuzzle;
            pb.Name = "pictureBox" + (value).ToString();
            pb.Size = new Size(piece_width_pixel, piece_width_pixel);
            pb.Image = image;
            pb.Tag = value;
            pb.Location = new Point((value % puzzle_width) * piece_width_pixel, (value / puzzle_width) * piece_width_pixel); //400/scPiece = Size of each Piece
            pb.Click += new EventHandler(this.pictureBox_Click);
            pb.BorderStyle = BorderStyle.FixedSingle;
            pictureboxLists.Add(pb);
        }

        public void MoveSelectedPictureBox(int newlocation, int selectedPieceIndex)
        {
            PictureBox tempPB = pictureboxLists[newlocation];
            Point empty_spot = tempPB.Location;
            pictureboxLists[newlocation].Location = pictureboxLists[selectedPieceIndex].Location;
            pictureboxLists[newlocation] = pictureboxLists[selectedPieceIndex];
            pictureboxLists[selectedPieceIndex].Location = empty_spot;
            pictureboxLists[selectedPieceIndex] = tempPB;        }

        public void PuzzleCompleted()
        {
            pictureboxLists.Last().Visible = true;
            MessageBox.Show("YOU WON");
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            int index = pictureboxLists.IndexOf((PictureBox)sender);
            presenter.OnPuzzlePieceSelected(index);
        }

        public void resetUserScoreLable()
        {
            lblScore.Text = (user_score=0).ToString();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogBox = new OpenFileDialog();
            dialogBox.Filter = "Image Files(JPG,BMP,PNG)|*.jpeg;*.bmp;*.png;* .jpg";
            if (dialogBox.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(dialogBox.FileName);
                presenter.onImageChanged(puzzle_size);
            }
        }

        public void setCmbValue(int puzzle_width)
        {
            switch (puzzle_width)
            {
                case 3: cmbPuzzleSize.SelectedIndex = 0; break;
                case 4: cmbPuzzleSize.SelectedIndex = 1; break;
                case 5: cmbPuzzleSize.SelectedIndex = 2; break;
                case 6: cmbPuzzleSize.SelectedIndex = 3; break;
                case 7: cmbPuzzleSize.SelectedIndex = 4; break;
                case 8: cmbPuzzleSize.SelectedIndex = 5; break;
            }
        }

        private void CmbPuzzleSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            puzzle_size = int.Parse(cmbPuzzleSize.SelectedItem.ToString().Split('*')[0]);
            presenter.PuzzleSizeChanged(puzzle_size);
        }

        public Image GetCurrentImage()
        {
            if (img == null)
                img = Properties.Resources.myImage1;
            return img;
        }

        public void SetEmptyPictureBox(int empty_index)
        {
            pictureboxLists[empty_index].Visible = false;
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            presenter.OnRefreshPuzzle(puzzle_size);
        }

        public void AddUserScore()
        {
            lblScore.Text = (++user_score).ToString();
        }

        public void ClearPuzzlePanel()
        {
            this.pnlPuzzle.Controls.Clear();
        }

        public void ClearPictureBoxList()
        {
            pictureboxLists = new List<PictureBox>();
        }

        public void setPbOriginalImage()
        {
            pbOriginalImage.Image = Utils.ResizeImage(GetCurrentImage(),new Size(450,450));
        }

        public void SetInitialValues(int puzzle_width)
        {
            setCmbValue(puzzle_width);
            resetUserScoreLable();
            ClearPictureBoxList();
            setPbOriginalImage();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutMe aboutMe = new aboutMe();
            aboutMe.ShowDialog();
        }
    }
}