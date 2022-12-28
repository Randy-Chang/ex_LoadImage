namespace ex_LoadImage
{
    public partial class Form1 : Form
    {
        string sFilePath = "";
        string sFolderPath = "";
        Image? image;

        Dictionary<string, string> dcImageFilePath = new Dictionary<string, string>();
        List<string> listKeyWord = new List<string>();

        public Form1()
        {
            InitializeComponent();
            btnChooseFilePath.Click += btnChooseFilePath_Click;
            tbFilePath.KeyDown += tbFilePath_KeyDown;

            btnChooseFolderPath.Click += btnChooseFplderPath_Click;
            nudOrder.ValueChanged += NumericUpDown_ValueChanged;  
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

                lbFileName.Text = $"FileName : {Path.GetFileNameWithoutExtension(sFilePath)}";

                ShowImage(pbImage1, sFilePath);
            }
        }

        private void btnChooseFplderPath_Click(object? sender, EventArgs e)
        {
            ChooseFolderPath(ref sFolderPath, tbFolderPath);

            RecordImageFilePathFromFolder(sFolderPath, ref listKeyWord, ref dcImageFilePath);

            InitNumericalUpDown(nudOrder, listKeyWord);
        }
        #endregion

        private void ChooseFilePath(ref string sFilePath, TextBox tb)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                
                sFilePath = file.FileName;
                tb.Text = file.FileName;

                lbFileName.Text = $"FileName : {Path.GetFileNameWithoutExtension(sFilePath)}";
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


                Bitmap? bmp = null;

                ImageZoom(pb, image, ref bmp);

                //PictureBoxZoom(pb, image, ref bmp);

                pb.Image = bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          
        }

        /// <summary>
        /// 影像長寬隨著PictureBox長寬做比例改變
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
        /// PictureBox長寬隨著影像長寬做比例改變
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


        private void ChooseFolderPath(ref string sFolderPath, TextBox tb)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {

                sFolderPath = folder.SelectedPath;
                tb.Text = folder.SelectedPath;
            }
        }

        private void RecordImageFilePathFromFolder(string sFolderPath, ref List<string> listKeyWord, 
                                                        ref Dictionary<string, string> dcImageFilePath)
        {
            listKeyWord.Clear();
            dcImageFilePath.Clear();

            string[] sArray = Directory.GetFiles(sFolderPath, "*.jpg");

            for (int i = 0; i < sArray.Length; i++)
            {
                listKeyWord.Add(Path.GetFileNameWithoutExtension(sArray[i]));

                dcImageFilePath.Add(Path.GetFileNameWithoutExtension(sArray[i]), sArray[i]);
            }
        }

        private void InitNumericalUpDown(NumericUpDown nud, List<string> listKeyWord)
        {
            nud.Minimum = 1;
            nud.Maximum = listKeyWord.Count;
            nud.Value = 1;
        }

        private void NumericUpDown_ValueChanged(object? sender, EventArgs e)
        {
            if (listKeyWord.Count != 0)
            {
                NumericUpDown? nud = (NumericUpDown?)sender;

                int intValue = Convert.ToInt16(nud.Value) - 1;

                string sKeyWord = listKeyWord[intValue];
                string sFilePath = dcImageFilePath[sKeyWord];

                lbFileName.Text = $"FileName : {sKeyWord}";
                ShowImage(pbImage1, sFilePath);
            }
        }

    }
}