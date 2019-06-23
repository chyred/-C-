using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;
using System.Reflection;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.IO;
using WindowsFormsApplication2;

namespace WindowsFormsApplication2
{
    public delegate void ChangeformnotifyIcon(bool topmost);
    public partial class Main : Form
    {
        public event Changeform loginmianshow;

        public event ChangeformnotifyIcon ChangenotifyIcon;
        [DllImport("user32.dll", EntryPoint = "SystemParametersInfoA")]
        static extern Int32 SystemParametersInfo(Int32 uAction, Int32 uParam, string lpvparam, Int32 fuwinIni);
        private const int SPI_SETDESKWALLPAPER = 20;

        public Main()
        {
            InitializeComponent();
            trackBar1.Maximum = 255;
            trackBar1.Minimum = -255;
        }
        Bitmap bitmap;
        Bitmap newbitmap;
        Stopwatch sw = new Stopwatch();
        private float Mylight;
        private int degree;
        private int left_x;
        private int right_x;
        private int left_y;
        private int right_y;



        //打开图片
        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string s_path = openFileDialog1.FileName;
                bitmap = (Bitmap)Image.FromFile(s_path);
                pictureBox1.Image = bitmap.Clone() as Image;
                pictureBox2.Image = bitmap.Clone() as Image;
                listView1.Items.Clear();
                string[] files = openFileDialog1.FileNames;
                string[] fileinfo = new string[3];
                for (int i = 0; i < files.Length; i++)
                {
                    string path = files[i].ToString();
                    string fileName = path.Substring(path.LastIndexOf("//") + 1, path.Length - 1 - path.LastIndexOf("//"));
                    string filetype = fileName.Substring(fileName.LastIndexOf(".") + 1, fileName.Length - 1 - fileName.LastIndexOf("."));
                    listView1.GridLines = true;
                    listView1.Sorting = SortOrder.Ascending;
                    fileinfo[0] = fileName;
                    fileinfo[1] = path;
                    fileinfo[2] = filetype;
                    ListViewItem lvi = new ListViewItem(fileinfo, 0);

                    listView1.Items.Add(lvi);
                }
            }
        }

        //保存图片
        private void 保存图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isSave = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName.ToString();

                if (fileName != "" && fileName != null)
                {
                    string fileExtName = fileName.Substring(fileName.LastIndexOf(".") + 1).ToString();

                    System.Drawing.Imaging.ImageFormat imgformat = null;

                    if (fileExtName != "")
                    {
                        switch (fileExtName)
                        {
                            case "jpg":
                                imgformat = System.Drawing.Imaging.ImageFormat.Jpeg;
                                break;
                            case "bmp":
                                imgformat = System.Drawing.Imaging.ImageFormat.Bmp;
                                break;
                            case "gif":
                                imgformat = System.Drawing.Imaging.ImageFormat.Gif;
                                break;
                            default:
                                MessageBox.Show("只能存取为: jpg,bmp,gif 格式");
                                isSave = false;
                                break;
                        }

                    }

                    //默认保存为JPG格式   
                    if (imgformat == null)
                    {
                        imgformat = System.Drawing.Imaging.ImageFormat.Jpeg;
                    }

                    if (isSave)
                    {
                        try
                        {
                            this.pictureBox2.Image.Save(fileName, imgformat);
                            //MessageBox.Show("图片已经成功保存!");   
                        }
                        catch
                        {
                            MessageBox.Show("保存失败,你还没有截取过图片或已经清空图片!");
                        }
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public static bool Rotation(Bitmap srcBmp, double degree, out Bitmap dstBmp)
        {
            if (srcBmp == null)
            {
                dstBmp = null;
                return false;
            }
            dstBmp = null;
            BitmapData srcBmpData = null;
            BitmapData dstBmpData = null;
            switch ((int)degree)
            {
                case 0:
                    dstBmp = new Bitmap(srcBmp);
                    break;
                case -90:
                    dstBmp = new Bitmap(srcBmp.Height, srcBmp.Width);
                    srcBmpData = srcBmp.LockBits(new Rectangle(0, 0, srcBmp.Width, srcBmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                    dstBmpData = dstBmp.LockBits(new Rectangle(0, 0, dstBmp.Width, dstBmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                    unsafe
                    {
                        byte* ptrSrc = (byte*)srcBmpData.Scan0;
                        byte* ptrDst = (byte*)dstBmpData.Scan0;
                        for (int i = 0; i < srcBmp.Height; i++)
                        {
                            for (int j = 0; j < srcBmp.Width; j++)
                            {
                                ptrDst[j * dstBmpData.Stride + (dstBmp.Height - i - 1) * 3] = ptrSrc[i * srcBmpData.Stride + j * 3];
                                ptrDst[j * dstBmpData.Stride + (dstBmp.Height - i - 1) * 3 + 1] = ptrSrc[i * srcBmpData.Stride + j * 3 + 1];
                                ptrDst[j * dstBmpData.Stride + (dstBmp.Height - i - 1) * 3 + 2] = ptrSrc[i * srcBmpData.Stride + j * 3 + 2];
                            }
                        }
                    }
                    srcBmp.UnlockBits(srcBmpData);
                    dstBmp.UnlockBits(dstBmpData);
                    break;
                case 90:
                    dstBmp = new Bitmap(srcBmp.Height, srcBmp.Width);
                    srcBmpData = srcBmp.LockBits(new Rectangle(0, 0, srcBmp.Width, srcBmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                    dstBmpData = dstBmp.LockBits(new Rectangle(0, 0, dstBmp.Width, dstBmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                    unsafe
                    {
                        byte* ptrSrc = (byte*)srcBmpData.Scan0;
                        byte* ptrDst = (byte*)dstBmpData.Scan0;
                        for (int i = 0; i < srcBmp.Height; i++)
                        {
                            for (int j = 0; j < srcBmp.Width; j++)
                            {
                                ptrDst[(srcBmp.Width - j - 1) * dstBmpData.Stride + i * 3] = ptrSrc[i * srcBmpData.Stride + j * 3];
                                ptrDst[(srcBmp.Width - j - 1) * dstBmpData.Stride + i * 3 + 1] = ptrSrc[i * srcBmpData.Stride + j * 3 + 1];
                                ptrDst[(srcBmp.Width - j - 1) * dstBmpData.Stride + i * 3 + 2] = ptrSrc[i * srcBmpData.Stride + j * 3 + 2];
                            }
                        }
                    }
                    srcBmp.UnlockBits(srcBmpData);
                    dstBmp.UnlockBits(dstBmpData);
                    break;
                case 180:
                case -180:
                    dstBmp = new Bitmap(srcBmp.Width, srcBmp.Height);
                    srcBmpData = srcBmp.LockBits(new Rectangle(0, 0, srcBmp.Width, srcBmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                    dstBmpData = dstBmp.LockBits(new Rectangle(0, 0, dstBmp.Width, dstBmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                    unsafe
                    {
                        byte* ptrSrc = (byte*)srcBmpData.Scan0;
                        byte* ptrDst = (byte*)dstBmpData.Scan0;
                        for (int i = 0; i < srcBmp.Height; i++)
                        {
                            for (int j = 0; j < srcBmp.Width; j++)
                            {
                                ptrDst[(srcBmp.Width - i - 1) * dstBmpData.Stride + (dstBmp.Height - j - 1) * 3] = ptrSrc[i * srcBmpData.Stride + j * 3];
                                ptrDst[(srcBmp.Width - i - 1) * dstBmpData.Stride + (dstBmp.Height - j - 1) * 3 + 1] = ptrSrc[i * srcBmpData.Stride + j * 3 + 1];
                                ptrDst[(srcBmp.Width - i - 1) * dstBmpData.Stride + (dstBmp.Height - j - 1) * 3 + 2] = ptrSrc[i * srcBmpData.Stride + j * 3 + 2];
                            }
                        }
                    }
                    srcBmp.UnlockBits(srcBmpData);
                    dstBmp.UnlockBits(dstBmpData);
                    break;
                default://任意角度
                    double radian = degree * Math.PI / 180.0;//将角度转换为弧度
                                                             //计算正弦和余弦
                    double sin = Math.Sin(radian);
                    double cos = Math.Cos(radian);
                    //计算旋转后的图像大小
                    int widthDst = (int)(srcBmp.Height * Math.Abs(sin) + srcBmp.Width * Math.Abs(cos));
                    int heightDst = (int)(srcBmp.Width * Math.Abs(sin) + srcBmp.Height * Math.Abs(cos));

                    dstBmp = new Bitmap(widthDst, heightDst);
                    //确定旋转点
                    int dx = (int)(srcBmp.Width / 2 * (1 - cos) + srcBmp.Height / 2 * sin);
                    int dy = (int)(srcBmp.Width / 2 * (0 - sin) + srcBmp.Height / 2 * (1 - cos));

                    int insertBeginX = srcBmp.Width / 2 - widthDst / 2;
                    int insertBeginY = srcBmp.Height / 2 - heightDst / 2;

                    //插值公式所需参数
                    double ku = insertBeginX * cos - insertBeginY * sin + dx;
                    double kv = insertBeginX * sin + insertBeginY * cos + dy;
                    double cu1 = cos, cu2 = sin;
                    double cv1 = sin, cv2 = cos;

                    double fu, fv, a, b, F1, F2;
                    int Iu, Iv;
                    srcBmpData = srcBmp.LockBits(new Rectangle(0, 0, srcBmp.Width, srcBmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                    dstBmpData = dstBmp.LockBits(new Rectangle(0, 0, dstBmp.Width, dstBmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                    unsafe
                    {
                        byte* ptrSrc = (byte*)srcBmpData.Scan0;
                        byte* ptrDst = (byte*)dstBmpData.Scan0;
                        for (int i = 0; i < heightDst; i++)
                        {
                            for (int j = 0; j < widthDst; j++)
                            {
                                fu = j * cu1 - i * cu2 + ku;
                                fv = j * cv1 + i * cv2 + kv;
                                if ((fv < 1) || (fv > srcBmp.Height - 1) || (fu < 1) || (fu > srcBmp.Width - 1))
                                {

                                    ptrDst[i * dstBmpData.Stride + j * 3] = 150;
                                    ptrDst[i * dstBmpData.Stride + j * 3 + 1] = 150;
                                    ptrDst[i * dstBmpData.Stride + j * 3 + 2] = 150;
                                }
                                else
                                {//双线性插值
                                    Iu = (int)fu;
                                    Iv = (int)fv;
                                    a = fu - Iu;
                                    b = fv - Iv;
                                    for (int k = 0; k < 3; k++)
                                    {
                                        F1 = (1 - b) * *(ptrSrc + Iv * srcBmpData.Stride + Iu * 3 + k) + b * *(ptrSrc + (Iv + 1) * srcBmpData.Stride + Iu * 3 + k);
                                        F2 = (1 - b) * *(ptrSrc + Iv * srcBmpData.Stride + (Iu + 1) * 3 + k) + b * *(ptrSrc + (Iv + 1) * srcBmpData.Stride + (Iu + 1) * 3 + k);
                                        *(ptrDst + i * dstBmpData.Stride + j * 3 + k) = (byte)((1 - a) * F1 + a * F2);
                                    }
                                }
                            }
                        }
                    }
                    srcBmp.UnlockBits(srcBmpData);
                    dstBmp.UnlockBits(dstBmpData);
                    break;
            }
            
            return true;
        }

        //亮度调整
        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                newbitmap = pictureBox1.Image.Clone() as Bitmap;
                Color pixel;
                int red, green, blue;
                //RGB*后数值越低约暗，颜色分量不能超过255
                for (int x = 0; x < newbitmap.Width; x++)
                {
                    for (int y = 0; y < newbitmap.Height; y++)
                    {
                        pixel = newbitmap.GetPixel(x, y);
                        //red = (int)(pixel.R * 0.6);
                        //green = (int)(pixel.G * 0.6);
                        //blue = (int)(pixel.B * 0.6);
                        red = pixel.R + Convert.ToInt32(textBox1.Text);
                        if (red > 255)
                            red = 255;
                        if (red < 0)
                            red = 0;
                        green = pixel.G + Convert.ToInt32(textBox1.Text);
                        if (green > 255)
                            green = 255;
                        if (green < 0)
                            green = 0;
                        blue = pixel.B + Convert.ToInt32(textBox1.Text);
                        if (blue > 255)
                            blue = 255;
                        if (blue < 0)
                            blue = 0;
                        newbitmap.SetPixel(x, y, Color.FromArgb(red, green, blue));
                    }
                }
                pictureBox2.Image = newbitmap.Clone() as Image;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //还原
        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = bitmap.Clone() as Image;
        }

        private void 马赛克ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        ////突出显示颜色值大的像素点.
        private void 锐化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int Height = this.pictureBox2.Image.Height;
                int Width = this.pictureBox2.Image.Width;
                Bitmap newBitmap = new Bitmap(Width, Height);
                Bitmap oldBitmap = (Bitmap)this.pictureBox2.Image;
                Color pixel;
                //拉普拉斯模板
                int[] Laplacian = { -1, -1, -1, -1, 9, -1, -1, -1, -1 };
                for (int x = 1; x < Width - 1; x++)
                    for (int y = 1; y < Height - 1; y++)
                    {
                        int r = 0, g = 0, b = 0;
                        int Index = 0;
                        for (int col = -1; col <= 1; col++)
                            for (int row = -1; row <= 1; row++)
                            {
                                pixel = oldBitmap.GetPixel(x + row, y + col);
                                r += pixel.R * Laplacian[Index];
                                g += pixel.G * Laplacian[Index];
                                b += pixel.B * Laplacian[Index];
                                Index++;
                            }
                        //处理颜色值溢出
                        r = r > 255 ? 255 : r;
                        r = r < 0 ? 0 : r;
                        g = g > 255 ? 255 : g;
                        g = g < 0 ? 0 : g;
                        b = b > 255 ? 255 : b;
                        b = b < 0 ? 0 : b;
                        newBitmap.SetPixel(x - 1, y - 1, Color.FromArgb(r, g, b));
                    }
                this.pictureBox2.Image = newBitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show("未找到图片，请打开图片后再进行操作", "信息提示");
            }
        }


        //当前像素点与周围像素点的颜色差距较大时取其平均值.
        private void 柔化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int Height = this.pictureBox2.Image.Height;
                int Width = this.pictureBox2.Image.Width;
                Bitmap bitmap = new Bitmap(Width, Height);
                Bitmap MyBitmap = (Bitmap)this.pictureBox2.Image;
                Color pixel;
                //高斯模板
                int[] Gauss = { 1, 2, 1, 2, 4, 2, 1, 2, 1 };
                for (int x = 1; x < Width - 1; x++)
                    for (int y = 1; y < Height - 1; y++)
                    {
                        int r = 0, g = 0, b = 0;
                        int Index = 0;
                        for (int col = -1; col <= 1; col++)
                            for (int row = -1; row <= 1; row++)
                            {
                                pixel = MyBitmap.GetPixel(x + row, y + col);
                                r += pixel.R * Gauss[Index];
                                g += pixel.G * Gauss[Index];
                                b += pixel.B * Gauss[Index];
                                Index++;
                            }
                        r /= 16;
                        g /= 16;
                        b /= 16;
                        //处理颜色值溢出
                        r = r > 255 ? 255 : r;
                        r = r < 0 ? 0 : r;
                        g = g > 255 ? 255 : g;
                        g = g < 0 ? 0 : g;
                        b = b > 255 ? 255 : b;
                        b = b < 0 ? 0 : b;
                        bitmap.SetPixel(x - 1, y - 1, Color.FromArgb(r, g, b));
                    }
                this.pictureBox2.Image = bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show("未找到图片，请打开图片后再进行操作", "信息提示");
            }
        }

        //在图像中引入一定的随机值, 打乱图像中的像素值
        private void 雾化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int Height = this.pictureBox2.Image.Height;
                int Width = this.pictureBox2.Image.Width;
                Bitmap newBitmap = new Bitmap(Width, Height);
                Bitmap oldBitmap = (Bitmap)this.pictureBox2.Image;
                Color pixel;
                for (int x = 1; x < Width - 1; x++)
                    for (int y = 1; y < Height - 1; y++)
                    {
                        System.Random MyRandom = new Random();
                        int k = MyRandom.Next(123456);
                        //像素块大小
                        int dx = x + k % 5;
                        int dy = y + k % 5;
                        if (dx >= Width)
                            dx = Width - 1;
                        if (dy >= Height)
                            dy = Height - 1;
                        pixel = oldBitmap.GetPixel(dx, dy);
                        newBitmap.SetPixel(x, y, pixel);
                    }
                this.pictureBox2.Image = newBitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show("未找到图片，请打开图片后再进行操作", "信息提示");
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "支持图片格式|*.jpeg;*.png;*.bmp;*.jpg";
        }

        private void 灰度化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                newbitmap = pictureBox2.Image.Clone() as Bitmap;
                Color pixel;
                int gray;
                for (int x = 0; x < newbitmap.Width; x++)
                {
                    for (int y = 0; y < newbitmap.Height; y++)
                    {
                        pixel = newbitmap.GetPixel(x, y);
                        //gary = 0.3 * R + 0.59 * G + 0.11 * B
                        gray = (int)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);
                        newbitmap.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                    }
                }
                pictureBox2.Image = newbitmap.Clone() as Image;
            }
        }

        private void 暗角ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                newbitmap = pictureBox2.Image.Clone() as Bitmap;

                int width = newbitmap.Width;
                int height = newbitmap.Height;
                float cx = width / 2;
                float cy = height / 2;
                //顶点与中心的距离
                float maxDist = cx * cx + cy * cy;
                float currDist = 0, factor;
                Color pixel;

                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        //求当前像素点离中心点的距离
                        currDist = ((float)i - cx) * ((float)i - cx) + ((float)j - cy) * ((float)j - cy);
                        factor = currDist / maxDist;
                        //当前像素点颜色设置
                        pixel = newbitmap.GetPixel(i, j);
                        int red = (int)(pixel.R * (1 - factor));
                        int green = (int)(pixel.G * (1 - factor));
                        int blue = (int)(pixel.B * (1 - factor));
                        newbitmap.SetPixel(i, j, Color.FromArgb(red, green, blue));
                    }
                }

                pictureBox2.Image = newbitmap.Clone() as Image;
            }
        }

        private void 浮雕ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                newbitmap = pictureBox2.Image.Clone() as Bitmap;
                Color pixel;
                int red, green, blue;
                for (int x = 0; x < newbitmap.Width; x++)
                {
                    for (int y = 0; y < newbitmap.Height; y++)
                    {
                        //把RGB三色取反
                        pixel = newbitmap.GetPixel(x, y);
                        red = (int)(255 - pixel.R);
                        green = (int)(255 - pixel.G);
                        blue = (int)(255 - pixel.B);
                        newbitmap.SetPixel(x, y, Color.FromArgb(red, green, blue));
                    }
                }
                pictureBox2.Image = newbitmap.Clone() as Image;
            }
        }

        private void 光照效果ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 亮度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
                //以光照效果显示图像
                Graphics MyGraphics = this.pictureBox2.CreateGraphics();
                //通过反射ImageRectangle 属性获取最后显示的大小..
                //PropertyInfo rectangleProperty = this.pictureBox2.GetType().GetProperty("ImageRectangle", BindingFlags.Instance | BindingFlags.NonPublic);
                //Rectangle rectangle = (Rectangle)rectangleProperty.GetValue(this.pictureBox2, null);
                Bitmap MyBmp = new Bitmap(this.pictureBox2.Image, pictureBox2.Width, pictureBox2.Height);
                int MyWidth = MyBmp.Width;
                int MyHeight = MyBmp.Height;
                Bitmap MyImage = MyBmp.Clone(new RectangleF(0, 0, MyWidth, MyHeight), System.Drawing.Imaging.PixelFormat.DontCare);
                int A = Width / 2;
                int B = Height / 2;
                //MyCenter为图片中心点，发亮此值会让强光中心发生偏移
                Point MyCenter = new Point(MyWidth / 2, MyHeight / 2);
                //R强光照射面的半径，即”光晕”
                int R = Math.Min(MyWidth / 2, MyHeight / 2);
                for (int i = MyWidth - 1; i >= 1; i--)
                {
                    for (int j = MyHeight - 1; j >= 1; j--)
                    {
                        float MyLength = (float)Math.Sqrt(Math.Pow((i - MyCenter.X), 2) + Math.Pow((j - MyCenter.Y), 2));
                        //如果像素位于”光晕”之内
                        if (MyLength < R)
                        {
                            Color MyColor = MyImage.GetPixel(i, j);
                            int r, g, b;
                            //220亮度增加常量，该值越大，光亮度越强
                            float MyPixel = 220.0f * (1.0f - MyLength / R);
                            r = MyColor.R + (int)MyPixel;
                            r = Math.Max(0, Math.Min(r, 255));
                            g = MyColor.G + (int)MyPixel;
                            g = Math.Max(0, Math.Min(g, 255));
                            b = MyColor.B + (int)MyPixel;
                            b = Math.Max(0, Math.Min(b, 255));
                            //将增亮后的像素值回写到位图
                            Color MyNewColor = Color.FromArgb(255, r, g, b);
                            MyImage.SetPixel(i, j, MyNewColor);
                        }
                    }
                    //重新绘制图片
                    MyGraphics.DrawImage(MyImage, new Rectangle(0, 0, MyWidth, MyHeight));
                }
        }

        private void 自定义ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Light l = new Light();
            l.MessageSent += delegate (object caller, string msg)
            {
                Mylight = Convert.ToSingle(msg);
                Graphics MyGraphics = this.pictureBox2.CreateGraphics();
                //PropertyInfo rectangleProperty = this.pictureBox2.GetType().GetProperty("ImageRectangle", BindingFlags.Instance | BindingFlags.NonPublic);
                //Rectangle rectangle = (Rectangle)rectangleProperty.GetValue(this.pictureBox2, null);
                Bitmap MyBmp = new Bitmap(this.pictureBox2.Image, pictureBox2.Width, pictureBox2.Height);
                int MyWidth = MyBmp.Width;
                int MyHeight = MyBmp.Height;
                Bitmap MyImage = MyBmp.Clone(new RectangleF(0, 0, MyWidth, MyHeight), System.Drawing.Imaging.PixelFormat.DontCare);
                int A = Width / 2;
                int B = Height / 2;
                Point MyCenter = new Point(MyWidth / 2, MyHeight / 2);
                int R = Math.Min(MyWidth / 2, MyHeight / 2);
                for (int i = MyWidth - 1; i >= 1; i--)
                {
                    for (int j = MyHeight - 1; j >= 1; j--)
                    {
                        float MyLength = (float)Math.Sqrt(Math.Pow((i - MyCenter.X), 2) + Math.Pow((j - MyCenter.Y), 2));
                        if (MyLength < R)
                        {
                            
                            Color MyColor = MyImage.GetPixel(i, j);
                            int r, g, b;
                            //220亮度增加常量，该值越大，光亮度越强
                            float MyPixel = Mylight * (1.0f - MyLength / R);
                            r = MyColor.R + (int)MyPixel;
                            r = Math.Max(0, Math.Min(r, 255));
                            g = MyColor.G + (int)MyPixel;
                            g = Math.Max(0, Math.Min(g, 255));
                            b = MyColor.B + (int)MyPixel;
                            b = Math.Max(0, Math.Min(b, 255));
                            //将增亮后的像素值回写到位图
                            Color MyNewColor = Color.FromArgb(255, r, g, b);
                            MyImage.SetPixel(i, j, MyNewColor);
                        }
                    }
                    //重新绘制图片
                    MyGraphics.DrawImage(MyImage, new Rectangle(0, 0, MyWidth, MyHeight));
                }
            };
            l.Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "-")
                return;
            int x;
            bool result = int.TryParse(textBox1.Text, out x);
            if (result)
            {
                if (x > trackBar1.Maximum)
                {
                    textBox1.Text = trackBar1.Maximum.ToString();
                    trackBar1.Value = trackBar1.Maximum;
                }
                else if (x < trackBar1.Minimum)
                {
                    textBox1.Text = trackBar1.Minimum.ToString();
                    trackBar1.Value = trackBar1.Minimum;
                }
                else
                {
                    trackBar1.Value = int.Parse(textBox1.Text);
                }
            }
            else
            {
                MessageBox.Show("请不要输入非数字字符");
            }
        }

        private void 垂直百叶窗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                newbitmap = (Bitmap)this.pictureBox2.Image.Clone();
                int dw = newbitmap.Width / 30;
                int dh = newbitmap.Height;
                Graphics g = this.pictureBox2.CreateGraphics();
                g.Clear(Color.Gray);
                Point[] MyPoint = new Point[30];
                for (int x = 0; x < 30; x++)
                {
                    MyPoint[x].Y = 0;
                    MyPoint[x].X = x * dw;
                }
                Bitmap bitmap = new Bitmap(newbitmap.Width, newbitmap.Height);
                for (int i = 0; i < dw; i++)
                {
                    for (int j = 0; j < 30; j++)
                    {
                        for (int k = 0; k < dh; k++)
                        {
                            bitmap.SetPixel(MyPoint[j].X + i, MyPoint[j].Y + k,newbitmap.GetPixel(MyPoint[j].X + i, MyPoint[j].Y + k));
                        }
                    }
                    this.pictureBox2.Refresh();
                    this.pictureBox2.Image = bitmap;
                    System.Threading.Thread.Sleep(50);
                }
                for (int i = 0; i < dw; i++) 
                {
                    for (int j = 0; j < 30; j++)
                    {
                        for (int k = 0; k < dh; k++)
                        {
                            if (j % 2 == 1)
                            {
                                bitmap.SetPixel(MyPoint[j].X + i, MyPoint[j].Y + k, newbitmap.GetPixel(MyPoint[j].X + i, MyPoint[j].Y + k));
                            }
                            else
                            {
                                bitmap.SetPixel(MyPoint[j].X + i, MyPoint[j].Y + k, Color.FromArgb(255, 255, 255));
                            }
                        }
                    }
                    this.pictureBox2.Image = bitmap;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息提示");
            }
        }

        private void 水平百叶窗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                newbitmap = (Bitmap)this.pictureBox2.Image.Clone();
                int dh = newbitmap.Height / 20;
                int dw = newbitmap.Width;
                Graphics g = this.pictureBox2.CreateGraphics();
                g.Clear(Color.Gray);
                Point[] MyPoint = new Point[20];
                for (int y = 0; y < 20; y++)
                {
                    MyPoint[y].X = 0;
                    MyPoint[y].Y = y * dh;
                }
                Bitmap bitmap = new Bitmap(newbitmap.Width, newbitmap.Height);
                for (int i = 0; i < dh; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        for (int k = 0; k < dw; k++)
                        {
                            bitmap.SetPixel(MyPoint[j].X + k, MyPoint[j].Y + i, newbitmap.GetPixel(MyPoint[j].X + k, MyPoint[j].Y + i));
                        }
                    }
                    this.pictureBox2.Refresh();
                    this.pictureBox2.Image = bitmap;
                    System.Threading.Thread.Sleep(50);
                }
                for (int i = 0; i < dh; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        for (int k = 0; k < dw; k++)
                        {
                            if (j % 2 == 1)
                                bitmap.SetPixel(MyPoint[j].X + k, MyPoint[j].Y + i, newbitmap.GetPixel(MyPoint[j].X + k, MyPoint[j].Y + i));
                            else
                                bitmap.SetPixel(MyPoint[j].X + k, MyPoint[j].Y + i, Color.FromArgb(255, 255, 255));
                        }
                    }

                    this.pictureBox2.Image = bitmap;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息提示");
            }
        }

        private void 马赛克ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                newbitmap = (Bitmap)this.pictureBox2.Image.Clone();
                int dw = newbitmap.Width / 10;
                int dh = newbitmap.Height / 10;
                Graphics g = this.pictureBox2.CreateGraphics();
                g.Clear(Color.Gray);
                Point[] MyPoint = new Point[100];
                for (int x = 0; x < 10; x++)
                    for (int y = 0; y < 10; y++)
                    {
                        MyPoint[x * 10 + y].X = x * dw;
                        MyPoint[x * 10 + y].Y = y * dh;
                    }
                Bitmap bitmap = new Bitmap(newbitmap.Width, newbitmap.Height);
                for (int i = 0; i < 10000; i++)
                {
                    System.Random MyRandom = new Random();
                    int iPos = MyRandom.Next(100);
                    for (int m = 0; m < dw; m++)
                        for (int n = 0; n < dh; n++)
                        {
                            bitmap.SetPixel(MyPoint[iPos].X + m, MyPoint[iPos].Y + n, newbitmap.GetPixel(MyPoint[iPos].X + m, MyPoint[iPos].Y + n));
                        }
                    this.pictureBox2.Refresh();
                    this.pictureBox2.Image = bitmap;
                }
                /*for (int i = 0; i < 100; i++)
                    for (int m = 0; m < dw; m++)
                        for (int n = 0; n < dh; n++)
                        {
                            bitmap.SetPixel(MyPoint[i].X + m, MyPoint[i].Y + n, newbitmap.GetPixel(MyPoint[i].X + m, MyPoint[i].Y + n));
                        }
                this.pictureBox2.Refresh();
                this.pictureBox2.Image = bitmap;*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息提示");
            }
        }

        private void 边缘检测ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color c1 = new Color();
            Color c2 = new Color();
            Color c3 = new Color();
            Color c4 = new Color();
            int i, j;
            int rr, gg, bb;
            int r1, r2, r3, r4, fxr, fyr;
            int g1, g2, g3, g4, fxg, fyg;
            int b1, b2, b3, b4, fxb, fyb;
            newbitmap = (Bitmap)this.pictureBox2.Image.Clone();
            for (i = 0; i <= newbitmap.Width - 1; i++)
            {
                if(i!= newbitmap.Width - 1)
                {
                    for (j = 0; j <= newbitmap.Height - 1; j++)
                    {
                        if (j != newbitmap.Height - 1)
                        {
                            c1 = newbitmap.GetPixel(i, j);
                            c2 = newbitmap.GetPixel(i + 1, j + 1);
                            c3 = newbitmap.GetPixel(i + 1, j);
                            c4 = newbitmap.GetPixel(i, j + 1);
                            r1 = c1.R;
                            r2 = c2.R;
                            r3 = c3.R;
                            r4 = c4.R;
                            fxr = r1 - r2;
                            fyr = r3 - r4;
                            rr = Math.Abs(fxr) + Math.Abs(fyr) + 128;
                            if (rr < 0)
                                rr = 0;
                            if (rr > 255)
                                rr = 255;
                            g1 = c1.G;
                            g2 = c2.G;
                            g3 = c3.G;
                            g4 = c4.G;
                            fxg = g1 - g2;
                            fyg = g3 - g4;
                            gg = Math.Abs(fxg) + Math.Abs(fyg) + 128;
                            if (gg < 0)
                                gg = 0;
                            if (gg > 255)
                                gg = 255;
                            b1 = c1.B;
                            b2 = c2.B;
                            b3 = c3.B;
                            b4 = c4.B;
                            fxb = b1 - b2;
                            fyb = b3 - b4;
                            bb = Math.Abs(fxb) + Math.Abs(fyb) + 128;
                            if (bb < 0)
                                bb = 0;
                            if (bb > 255)
                                bb = 255;
                            Color cc = Color.FromArgb(rr, gg, bb);
                            newbitmap.SetPixel(i, j, cc);
                        }
                        else
                        {
                            c1 = newbitmap.GetPixel(i, j);
                            c3 = newbitmap.GetPixel(i + 1, j);
                            r1 = c1.R;
                            r3 = c3.R;
                            fxr = r1;
                            fyr = r3;
                            rr = Math.Abs(fxr) + Math.Abs(fyr) + 128;
                            if (rr < 0)
                                rr = 0;
                            if (rr > 255)
                                rr = 255;
                            g1 = c1.G;
                            g3 = c3.G;
                            fxg = g1;
                            fyg = g3;
                            gg = Math.Abs(fxg) + Math.Abs(fyg) + 128;
                            if (gg < 0)
                                gg = 0;
                            if (gg > 255)
                                gg = 255;
                            b1 = c1.B;
                            b3 = c3.B;
                            fxb = b1;
                            fyb = b3;
                            bb = Math.Abs(fxb) + Math.Abs(fyb) + 128;
                            if (bb < 0)
                                bb = 0;
                            if (bb > 255)
                                bb = 255;
                            Color cc = Color.FromArgb(rr, gg, bb);
                            newbitmap.SetPixel(i, j, cc);
                        }
                    }
                }
                else
                {
                    for (j = 0; j <= newbitmap.Height - 1; j++)
                    {
                        if (j != newbitmap.Height - 1)
                        {
                            c1 = newbitmap.GetPixel(i, j);
                            c4 = newbitmap.GetPixel(i, j + 1);
                            r1 = c1.R;
                            r4 = c4.R;
                            fxr = r1;
                            fyr = r4;
                            rr = Math.Abs(fxr) + Math.Abs(fyr) + 128;
                            if (rr < 0)
                                rr = 0;
                            if (rr > 255)
                                rr = 255;
                            g1 = c1.G;
                            g4 = c4.G;
                            fxg = g1;
                            fyg = g4;
                            gg = Math.Abs(fxg) + Math.Abs(fyg) + 128;
                            if (gg < 0)
                                gg = 0;
                            if (gg > 255)
                                gg = 255;
                            b1 = c1.B;
                            b4 = c4.B;
                            fxb = b1;
                            fyb = b4;
                            bb = Math.Abs(fxb) + Math.Abs(fyb) + 128;
                            if (bb < 0)
                                bb = 0;
                            if (bb > 255)
                                bb = 255;
                            Color cc = Color.FromArgb(rr, gg, bb);
                            newbitmap.SetPixel(i, j, cc);
                        }
                        else
                        {
                            c1 = newbitmap.GetPixel(i, j);
                            r1 = c1.R;
                            fxr = r1;
                            rr = Math.Abs(fxr) + 128;
                            if (rr < 0)
                                rr = 0;
                            if (rr > 255)
                                rr = 255;
                            g1 = c1.G;
                            fxg = g1;
                            gg = Math.Abs(fxg) + 128;
                            if (gg < 0)
                                gg = 0;
                            if (gg > 255)
                                gg = 255;
                            b1 = c1.B;
                            fxb = b1;
                            bb = Math.Abs(fxb) + 128;
                            if (bb < 0)
                                bb = 0;
                            if (bb > 255)
                                bb = 255;
                            Color cc = Color.FromArgb(rr, gg, bb);
                            newbitmap.SetPixel(i, j, cc);
                        }
                    }
                }
            }
            pictureBox2.Image = newbitmap.Clone() as Image; 
        }

        private void 图像增强ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newbitmap = (Bitmap)this.pictureBox2.Image.Clone();
            Bitmap srcBmp = (Bitmap)newbitmap.Clone();
            BitmapData bmData = newbitmap.LockBits(new Rectangle(0, 0, newbitmap.Width, newbitmap.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmSrcData = srcBmp.LockBits(new Rectangle(0, 0, srcBmp.Width, srcBmp.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = bmData.Stride;
            int stride2 = bmData.Stride * 2;
            System.IntPtr scan0 = bmData.Scan0;
            System.IntPtr srcScan0 = bmSrcData.Scan0;

            unsafe
            {
                byte* p = (byte*)scan0;
                byte* pSrc = (byte*)srcScan0;
                int nWidth = newbitmap.Width - 2;
                int nHeight = newbitmap.Height - 2;
                int nOffset = stride - newbitmap.Width * 3;

                int nPixel;
                List<int> array = new List<int>();
                for (int y = 0; y < nHeight; y++)
                {
                    for (int x = 0; x < nWidth; x++)
                    {
                        /*清空数组*/
                        array.Clear();
                        array.Add(pSrc[2]);
                        array.Add(pSrc[5]);
                        array.Add(pSrc[8]);
                        array.Add(pSrc[2 + stride]);
                        array.Add(pSrc[5 + stride]);
                        array.Add(pSrc[8 + stride]);
                        array.Add(pSrc[2 + stride2]);
                        array.Add(pSrc[5 + stride2]);
                        array.Add(pSrc[8 + stride2]);
                        /*对数据进行大小排序*/
                        array.Sort();
                        nPixel = array[array.Count / 2];
                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;
                        /*对像素进行赋值*/
                        pSrc[5 + stride] = (byte)nPixel;

                        array.Clear();
                        array.Add(pSrc[1]);
                        array.Add(pSrc[4]);
                        array.Add(pSrc[7]);
                        array.Add(pSrc[1 + stride]);
                        array.Add(pSrc[4 + stride]);
                        array.Add(pSrc[7 + stride]);
                        array.Add(pSrc[1 + stride2]);
                        array.Add(pSrc[4 + stride2]);
                        array.Add(pSrc[7 + stride2]);

                        /*对数据进行大小排序*/
                        array.Sort();
                        nPixel = array[array.Count / 2];
                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;
                        /*对像素进行赋值*/
                        pSrc[4 + stride] = (byte)nPixel;

                        array.Clear();
                        array.Add(pSrc[0]);
                        array.Add(pSrc[3]);
                        array.Add(pSrc[6]);
                        array.Add(pSrc[0 + stride]);
                        array.Add(pSrc[3 + stride]);
                        array.Add(pSrc[6 + stride]);
                        array.Add(pSrc[0 + stride2]);
                        array.Add(pSrc[3 + stride2]);
                        array.Add(pSrc[6 + stride2]);

                        /*对数据进行大小排序*/
                        array.Sort();
                        nPixel = array[array.Count / 2];
                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;
                        /*对像素进行赋值*/
                        pSrc[3 + stride] = (byte)nPixel;

                        p += 3;
                        pSrc += 3;
                    }/*inner for*/
                    p += nOffset;
                    p += nOffset;
                }/*outer for*/
            }/*unsafe*/
            newbitmap.UnlockBits(bmData);
            srcBmp.UnlockBits(bmSrcData);
            newbitmap = srcBmp;
            pictureBox2.Image = newbitmap.Clone() as Image;
        }

        private void 左旋90度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap MyBmp = new Bitmap(this.pictureBox2.Image, pictureBox2.Width, pictureBox2.Height);
            Rotation(MyBmp, 90, out MyBmp);
            pictureBox2.Image = MyBmp.Clone() as Image;
        }

        private void 右旋90度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap MyBmp = new Bitmap(this.pictureBox2.Image, pictureBox2.Width, pictureBox2.Height);
            Rotation(MyBmp, -90, out MyBmp);
            pictureBox2.Image = MyBmp.Clone() as Image;
        }

        private void 自定义ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Rotate r = new Rotate();
            r.MessageSent += delegate (object caller, string msg)
            {
                degree = Convert.ToInt32(msg);
                Bitmap MyBmp = new Bitmap(this.pictureBox2.Image, pictureBox2.Width, pictureBox2.Height);
                Rotation(MyBmp, degree, out MyBmp);
                pictureBox2.Image = MyBmp.Clone() as Image;
            };
            r.Show();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Show();
        }

        private void 百叶窗效果ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 全部ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //把一个像素点周围的点的像素取平均，然后把这些像素点的颜色设为平均值，像素点取的越多，马克赛的效果也就越明显。
            if (pictureBox2.Image != null)
            {
                newbitmap = pictureBox2.Image.Clone() as Bitmap;
                int RIDIO = 25;//马赛克的尺度
                for (int h = 0; h < newbitmap.Height; h += RIDIO)
                {
                    for (int w = 0; w < newbitmap.Width; w += RIDIO)
                    {
                        int avgRed = 0, avgGreen = 0, avgBlue = 0;
                        int count = 0;
                        //取周围的像素
                        for (int x = w; (x < w + RIDIO && x < newbitmap.Width); x++)
                        {
                            for (int y = h; (y < h + RIDIO && y < newbitmap.Height); y++)
                            {
                                Color pixel = newbitmap.GetPixel(x, y);
                                avgRed += pixel.R;
                                avgGreen += pixel.G;
                                avgBlue += pixel.B;
                                count++;
                            }
                        }

                        //取平均值
                        avgRed = avgRed / count;
                        avgBlue = avgBlue / count;
                        avgGreen = avgGreen / count;

                        //设置颜色
                        for (int x = w; (x < w + RIDIO && x < newbitmap.Width); x++)
                        {
                            for (int y = h; (y < h + RIDIO && y < newbitmap.Height); y++)
                            {
                                Color newColor = Color.FromArgb(avgRed, avgGreen, avgBlue);
                                newbitmap.SetPixel(x, y, newColor);
                            }
                        }
                    }
                }
                pictureBox2.Image = newbitmap.Clone() as Image;
            }
        }

        private void 部分区域ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Masaike m = new Masaike();
            m.MessageSent1 += delegate (object caller, string msg)
            {
                left_x = Convert.ToInt32(msg);
            };
            m.MessageSent2 += delegate (object caller, string msg)
            {
                right_x = Convert.ToInt32(msg);
            };
            m.MessageSent3 += delegate (object caller, string msg)
            {
                left_y = Convert.ToInt32(msg);
            };
            m.MessageSent4 += delegate (object caller, string msg)
            {
                right_y = Convert.ToInt32(msg);
                if (pictureBox2.Image != null)
                {
                    newbitmap = pictureBox2.Image.Clone() as Bitmap;
                    int RIDIO = 5;//马赛克的尺度
                    for (int h = left_y; h < right_y; h += RIDIO)
                    {
                        for (int w = left_x; w < right_x; w += RIDIO)
                        {
                            int avgRed = 0, avgGreen = 0, avgBlue = 0;
                            int count = 0;
                            //取周围的像素
                            for (int x = w; (x < w + RIDIO && x < newbitmap.Width); x++)
                            {
                                for (int y = h; (y < h + RIDIO && y < newbitmap.Height); y++)
                                {
                                    Color pixel = newbitmap.GetPixel(x, y);
                                    avgRed += pixel.R;
                                    avgGreen += pixel.G;
                                    avgBlue += pixel.B;
                                    count++;
                                }
                            }

                            //取平均值
                            avgRed = avgRed / count;
                            avgBlue = avgBlue / count;
                            avgGreen = avgGreen / count;

                            //设置颜色
                            for (int x = w; (x < w + RIDIO && x < newbitmap.Width); x++)
                            {
                                for (int y = h; (y < h + RIDIO && y < newbitmap.Height); y++)
                                {
                                    Color newColor = Color.FromArgb(avgRed, avgGreen, avgBlue);
                                    newbitmap.SetPixel(x, y, newColor);
                                }
                            }
                        }
                    }
                    pictureBox2.Image = newbitmap.Clone() as Image;
                }
            };
            m.Show();
        }

        private void 将目标图片设置为桌面壁纸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string fpath = listView1.SelectedItems[0].SubItems[1].Text;
                string sfiletype = fpath.Substring(fpath.LastIndexOf(".") + 1, (fpath.Length - fpath.LastIndexOf(".") - 1));
                sfiletype = sfiletype.ToLower();
                string sfilename = fpath.Substring(fpath.LastIndexOf("//") + 1, (fpath.LastIndexOf(".") - fpath.LastIndexOf("//") - 1));

                if (sfiletype == "bmp")        //判断文件类型是否是bmp格式
                {
                    SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, fpath, 1);//调用，filename为图片地址，最后一个参数需要为1，0的话在重启后就变回原来的了
                }
                else
                {
                    MessageBox.Show("请使用bmp格式的图片作为桌面背景！");
                    MessageBox.Show("提示：可以先保存为bmp图片再来更改背景！");
                }
            }
            else
            {
                MessageBox.Show("请选择文件路径！");
            }
        }

        private void 返回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginmianshow(true);
            this.Hide();
        }

        public void Close()
        {
            this.Dispose();
        }
    }
}
