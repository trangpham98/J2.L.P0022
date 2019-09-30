using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace J2.L.P0022
{
    public partial class Form1 : Form
    {
        
        string view;
        double result;// kêt quả của phép toán
        double MR;// gia trị của lưu trữ
        string dau="smile!";// dấu
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
       
        private void ClickNumber(object sender, EventArgs e)
        {
            Button p = (Button)sender;
            
            view += p.Text;
            //Int32.TryParse(view, out num);
            txtOut.Text = view;
        }
     
        //ham cộng
        private double sum(double a)
        {
            result += a;
            return result;
        }

        //ham trừ
        private double sub(double b)
        {
            result -= b;
            return result;
        }

        //ham chia
        private double div( double c)
        {
           

            result /= c;
            return result;
        }

        //ham nhân
        private double mul(double d)
        {
            result *= d;
            return result;
        }
       
        //ham %
        private double percent(double f)
        {
            f = f / 100;
            return f;
        }

        // ham tính 1/x
        private double inverse(double k)
        {
            k = 1 / k;
            return k;

        }

        // hàm tính căn
        private double square(double e)
        {
            double m;

            m = Math.Sqrt(e);
            return m;
        }

        //khi click vào button +
        private void btnSum_Click(object sender, EventArgs e)
        {
            // xem trước đó bấm số thì  lưu lại
            if (int.TryParse(view, out int BossDepZai))
            {

                result = Convert.ToDouble(view);

            }
            view = "";
            dau = "Sum";//lưu lại dấu vừa bấm

        }

       
        //khi click vào button -
        private void BtnSub_Click(object sender, EventArgs e)
        {

            if (int.TryParse(view, out int BossDepZai))
            {

                result = Convert.ToDouble(view);

            }
            view = "";
            dau = "Sub";
        }

        //khi click vào button x
        private void BtnMul_Click(object sender, EventArgs e)
        {

            if (int.TryParse(view, out int BossDepZai))
            {

                result = Convert.ToDouble(view);

            }
            view = "";
            dau = "Mul";
        }

        //khi click vào button /
        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if(int.TryParse(view,out int BossDepZai))
            {

                result = Convert.ToDouble(view);

               
            }
            view = "";
            dau = "Div";
        }

        //khi click vào button 1/x
        private void BtnInverse_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(view);
            if (result == 0)
            {
                error();
                
            }
            else
            {
                result = inverse(result);

                view = result.ToString();
                txtOut.Text = view;
            }

        }

        //khi click vào button %
        private void BtnPercent_Click(object sender, EventArgs e)
        {

            result = percent(Convert.ToDouble(view));

            view = result.ToString();
            txtOut.Text = view;

        }

        //khi click vào button căn
        private void BtnSquare_Click(object sender, EventArgs e)
        {

            if (result < 0)
            {
                error();

            }
            else
            {
                result = square(Convert.ToDouble(view));
                view = result.ToString();
                txtOut.Text = view;
            }
            

        }
        
        //khi click vào button .
        private void BtnChange_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(view);
            result = -1 * x;
            view = result.ToString();
            txtOut.Text = view;
        }

        //khi click vào button M+
        private void BtnMPlus_Click(object sender, EventArgs e)
        {
            if (dau == "smile!")
                result = Convert.ToDouble(view);
            else
                Handle(dau);
            MR += result;
            result = 0;
            view = "";

        }

        ////khi click vào button M-
        private void BtnMminus_Click(object sender, EventArgs e)
        {
            if (dau == "smile!")
                result = Convert.ToDouble(view);
            else
                Handle(dau);
            Handle(dau);
            MR -= result;
            result = 0;
            view = "";
        }

        //xóa bỏ giá trị của MR
        private void BtnMC_Click(object sender, EventArgs e)
        {
            MR = 0;
            view = "";
            txtOut.Text = "0";
        }

        //Xuất giá trị của MR, và xóa gtri result
        private void BtnMR_Click(object sender, EventArgs e)
        {
            txtOut.Text = MR.ToString();
            result = 0;
        }

        //thông báo lỗi
        private void error()
        {
            MessageBox.Show("Boss đẹp trai ơi, lỗi rồi ^^!", "Trang xí gái thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtOut.Text = "ERROR";
        }

        private void lbClear_Click(object sender, EventArgs e)
        {
            view = "";
            txtOut.Text = "0";
            result = 0;
            MR = 0;
        }



        private void BtnHandle_Click(object sender, EventArgs e)
        {
            Handle(dau);
            view = result.ToString();
            txtOut.Text = view;
            view = "";

        }
        private double Handle(string dau)
        {
            switch (dau)
            {
                case "Sum":

                    result = sum(Convert.ToDouble(view));
                    break;
                case "Sub":
                    result = sub(Convert.ToDouble(view));
                    break;
                case "Mul":
                    result = mul(Convert.ToDouble(view));
                    break;
                case "Div":
                    if (Convert.ToDouble(view) == 0)
                        error();
                    result = div(Convert.ToDouble(view));
                    break;
                default:
                    result = Convert.ToDouble(view);
                    break;

            }

            return result;
        }
       
    }
}