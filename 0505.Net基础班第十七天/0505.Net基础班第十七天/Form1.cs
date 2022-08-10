namespace _0505.Net基础班第十七天
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 一根笔  颜色  一张纸  两点  绘制直线的对象

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 创建GDI对象
            // new Graphics();
            Graphics g = this.CreateGraphics();
            // 创建画笔对象
            Pen pen = new Pen(Brushes.Red);
            // 创建两个点
            Point p1 = new Point(30, 50);
            Point p2 = new Point(250, 250);

            g.DrawLine(pen, p1, p2);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // 创建GDI对象
            // new Graphics();
            Graphics g = this.CreateGraphics();
            // 创建画笔对象
            Pen pen = new Pen(Brushes.Red);
            // 创建两个点
            Point p1 = new Point(30, 50);
            Point p2 = new Point(250, 250);

            g.DrawLine(pen, p1, p2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Red);
            Size size = new Size(80, 80);
            Rectangle rectangle = new Rectangle(new Point(50, 50), size);
            graphics.DrawRectangle(pen, rectangle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Blue);
            Size size = new Size(180, 180);
            Rectangle rectangle = new Rectangle(new Point(150, 150), size);
            graphics.DrawPie(pen, rectangle, 60, 60);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.DrawString("武正春是最帅的", new Font("宋体", 20, FontStyle.Underline), Brushes.Black, new Point(300, 300));
        }
    }
}