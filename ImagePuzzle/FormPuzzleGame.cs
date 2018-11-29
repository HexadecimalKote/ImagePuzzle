using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImagePuzzle
{
    public partial class FormPuzzleGame : Form
    {
        Game game;
        int size = 3;
        Image[,] img;
        PictureBox[,] box;

        public FormPuzzleGame()
        {
            InitializeComponent();
        }

        private void StartGame()
        {
            game = new Game(size);
            CropImage();
            InitPictures();
            game.Start();
            for (int i = 0; i < size * size * 10; i++)  
                game.ShiftRandom();
            RefreshImage();
        }

        private void CropImage()
        {
            img = new Image[size, size];
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                    img[x, y] = GetImagePart(x, y);
        }

        private Bitmap GetImagePart(int x, int y)
        {
            Bitmap bmp = Properties.Resources.PuzzleImage_2;
            int w, h; 
            w = bmp.Width / size;
            h = bmp.Height / size;
            Rectangle cropPart = new Rectangle(x * w, y * h, w, h);
            Bitmap target = new Bitmap(w, h);
            Graphics grp = Graphics.FromImage(target);
            grp.DrawImage(bmp, new Rectangle(0, 0, target.Width, target.Height), cropPart, GraphicsUnit.Pixel);
            return target;
        }

        private void InitPictures()
        {
            int w, h;
            w = ImagePanel.Width / size;
            h = ImagePanel.Height / size;

            ImagePanel.Controls.Clear();
            box = new PictureBox[size, size];
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                {
                    PictureBox pb = new PictureBox();

                    pb.BorderStyle = BorderStyle.FixedSingle;
                    pb.Location = new Point(x * w, y * h);
                    pb.Size = new Size(w, h);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Click += new EventHandler(PB_ImagePart_Click);
                    pb.Tag = y * size + x;

                    ImagePanel.Controls.Add(pb);
                    box[x, y] = pb;
                }
        }

        private void RefreshImage()
        {
            for (int position = 0; position < size * size; position++)
            {
                int nr = game.GetNumber(position);
                box[position % size, position / size].Visible = (nr >= 0);

                if (nr >= 0)
                    box[position % size, position / size].Image = img[nr % size, nr / size];
            }
        }

        #region Events
        private void FormPuzzleGame_Load(object sender, EventArgs e) => StartGame();

        private void Menu_StartGame_Click(object sender, EventArgs e) => StartGame();

        private void Menu_Level_3_Click(object sender, EventArgs e)
        {
            size = 3;
            StartGame();
        }

        private void Menu_Level_4_Click(object sender, EventArgs e)
        {
            size = 4;
            StartGame();
        }

        private void Menu_Level_5_Click(object sender, EventArgs e)
        {
            size = 5;
            StartGame();
        }

        private void Menu_Level_6_Click(object sender, EventArgs e)
        {
            size = 6;
            StartGame();
        }

        private void PB_ImagePart_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt16(((PictureBox)sender).Tag);
            game.Shift(position);
            RefreshImage();
            if (game.CheckNumbers())
            {
                MessageBox.Show("Вы победили!", "Поздравление");
                StartGame();
            }
        }
        #endregion
    }
}