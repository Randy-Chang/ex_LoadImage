namespace ex_LoadImage
{
    public partial class Form1 : Form
    {
        string sFilePath = "";
        Image image;

        public Form1()
        {
            InitializeComponent();
            btnChooseFilePath.Click += btnChooseFilePath_Click;
            tbFilePath.KeyDown += tbFilePath_KeyDown;
        }

        #region UI 相關函式
        private void btnChooseFilePath_Click(object? sender, EventArgs e)
        {
            ChooseFilePath(ref sFilePath, tbFilePath);

            ShowImage(pbImage1, sFilePath);
        }

        private void tbFilePath_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sFilePath = tbFilePath.Text;

                ShowImage(pbImage1, sFilePath);
            }
        }
        #endregion

        private void ChooseFilePath(ref string sFilePath, TextBox tb)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                
                sFilePath = file.FileName;
                tb.Text = file.FileName;
            }
            
        }

        /// <summary>
        /// 顯示圖片
        /// </summary>
        /// <param name="pb">顯示圖片對應的PictureBox</param>
        /// <param name="sFilePath">圖片檔的路徑</param>
        void ShowImage(PictureBox pb, string sFilePath)
        {
            try
            {
                pb.Image = null;
                
                image = Image.FromFile(sFilePath);


                Bitmap bmp = null;

                ImageZoom(pb, image, ref bmp);

                PictureBoxZoom(pb, image, ref bmp);

                pb.Image = bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pb"></param>
        /// <param name="image"></param>
        /// <param name="bmp"></param>
        void ImageZoom(PictureBox pb, Image image, ref Bitmap bmp)
        {
            int pbWidth = pb.Width;
            int pbHeight = pb.Height;

            int imageWidth = image.Width;
            int imageHeight = image.Height;

            double WidthFactor = (double)pbWidth / (double)imageWidth;
            double HeightFactor = (double)pbHeight / (double)imageHeight;

            Size newSize = new Size((int)(image.Width * WidthFactor), (int)(image.Height * HeightFactor));

            bmp = new Bitmap(image, newSize);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pb"></param>
        /// <param name="image"></param>
        /// <param name="bmp"></param>
        void PictureBoxZoom(PictureBox pb, Image image, ref Bitmap bmp)
        {
            int pbWidth = pb.Width;
            int pbHeight = pb.Height;

            int imageWidth = image.Width;
            int imageHeight = image.Height;

            double WidthFactor = (double)imageWidth / (double)pbWidth;
            double HeightFactor = (double)imageHeight / (double)pbHeight;

            pb.Width = Convert.ToInt16(pbWidth * WidthFactor);
            pb.Height = Convert.ToInt16(pbHeight * HeightFactor);

            bmp = new Bitmap(image);
        }




    }
}