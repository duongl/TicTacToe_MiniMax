using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class frm_settings : Form
    {
        // Khai báo các danh sách chứa tên người chơi và chế độ chơi
        List<String> TenNguoiChoi;
        List<String> CheDoChoi;
        // Khai báo danh sách chứa các điều khiển RadioButton
        List<RadioButton> radioButtonList;

        // Khai báo constructor của lớp frm_settings
        public frm_settings(ref List<String> TenNguoiChoi, ref List<String> CheDoChoi)
        {
            // Gọi hàm khởi tạo các thành phần giao diện
            InitializeComponent();
            // Khởi tạo các danh sách tên người chơi, chế độ chơi và danh sách RadioButton
            this.TenNguoiChoi = new List<string>();
            this.CheDoChoi = new List<String>();
            this.radioButtonList = new List<RadioButton>() { pieceX, pieceO, mode1, mode3 };
            // Gán giá trị các danh sách tên người chơi và chế độ chơi từ tham số truyền vào cho các danh sách khởi tạo trong constructor
            this.TenNguoiChoi = TenNguoiChoi;
            this.CheDoChoi = CheDoChoi;
            //hàm khởi tạo form
            initialisation();
        }

        // Hàm khởi tạo form
        private void initialisation()
        {
            // Gán tên người chơi 1 cho textbox txtPlayer1
            txtPlayer1.Text = TenNguoiChoi[0];
            // Gán tên người chơi 2 cho textbox txtPlayer2
            txtPlayer2.Text = TenNguoiChoi[1];
            // Nếu chế độ chơi là "P-C" (người chơi chơi với máy), thì ẩn textbox và label cho người chơi 2
            if (CheDoChoi[3] == "P-C")
            {
                txtPlayer2.Visible = false;
                labelPlayer2.Visible = false;
            }
            // Duyệt qua từng phần tử trong danh sách radioButtonList
            foreach (RadioButton rb in radioButtonList)
            {
                // Nếu radioButton có Tag là "X" hoặc "O" hoặc "1" hoặc "3"
                // (Tag là thuộc tính cho phép bạn lưu trữ một giá trị bất kỳ vào điều khiển)
                if (rb.Tag.ToString() == CheDoChoi[0] || rb.Tag.ToString() == CheDoChoi[2])
                {
                    // Đánh dấu radioButton đó là đã chọn
                    rb.Checked = true;
                }
            }
        }

        // Hàm sửa quân "X" hoặc "O" bởi người chơi
        private void pieceChecked(object sender, EventArgs e)
        {
            // Ép kiểu đối tượng sender thành RadioButton
            RadioButton rb = (RadioButton)sender;
            // Gán giá trị "X" cho chế độ chơi 0 và "O" cho chế độ chơi 1
            this.CheDoChoi[0] = "X";
            this.CheDoChoi[1] = "O";
            // Nếu radioButton đó có giá trị là "O"
            if (rb.Text == "O")
            {
                // Thì đảo ngược lại
                this.CheDoChoi[0] = rb.Text;
                this.CheDoChoi[1] = "X";
            }
        }
        /// Lưu cài đặt
        private void modeChecked(object sender, EventArgs e)
        {
            RadioButton rbMode = (RadioButton)sender;
            CheDoChoi[2] = rbMode.Tag.ToString();
        }


        #region Click

        /// Lưu các phần tử đã sửa đổi + thông báo lỗi
        private void saveClick(object sender, EventArgs e)
        {
            if (txtPlayer1.Text == "" || txtPlayer2.Text == "" || txtPlayer1.Text.Length >8 || txtPlayer2.Text.Length > 8)
            {
                lblError.Text = "Một trong các trường trống HOẶC tên quá dài";
                lblError.BackColor = Color.Red;
            }
            else
            {
                TenNguoiChoi[0] = txtPlayer1.Text;
                TenNguoiChoi[1] = txtPlayer2.Text;
                lblError.Text = "Tốt đã lưu";
                lblError.BackColor = Color.Orange;
            }
            lblError.ForeColor = Color.White;
        }


        /// đóng form
        private void picRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
