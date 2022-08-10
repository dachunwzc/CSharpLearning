namespace 使用GDI绘制验证码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击更换验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            String str = null;
            for (int i = 0; i < 5; i++)
            {
                int rNumber = random.Next(0, 10);
                str += rNumber;
            }
            // MessageBox.Show(str);
            Bitmap bitmap = new Bitmap(300, 120);
            Graphics graphics = Graphics.FromImage(bitmap);

            for (int i = 0; i < 5; i++)
            {
                Point point = new Point(i * 50, 0);
                string[] fonts = { "宋体", "微软雅黑", "黑体", "隶书", "仿宋" };
                Color[] colors = {Color.SaddleBrown, Color.SteelBlue, Color.Tan, Color.Yellow, Color.Thistle};
                graphics.DrawString(str[i].ToString(), new Font(fonts[random.Next(0, 5)], 50, FontStyle.Bold), new SolidBrush(colors[random.Next(0, 5)]), point);
            }

            for (int i = 0; i < 50; i++)
            {
                Point point1 = new Point(random.Next(0, bitmap.Width), random.Next(0, bitmap.Height));
                Point point2 = new Point(random.Next(0, bitmap.Width), random.Next(0, bitmap.Height));
                graphics.DrawLine(new Pen(Brushes.BlueViolet), point1, point2);
            }

            for (int i = 0; i < 10000; i++)
            {
                Point point = new Point(random.Next(0, bitmap.Width), random.Next(0, bitmap.Height));
                bitmap.SetPixel(point.X, point.Y, Color.Black);
            }

            // 将图片镶嵌到PictureBox中
            pictureBox1.Image = bitmap;
        }
    }
}