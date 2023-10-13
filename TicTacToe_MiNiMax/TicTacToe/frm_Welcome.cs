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
    public partial class frm_Welcome : Form
    {
        #region BienDoi
        frm_settings settings; // Form cài đặt
        frm_TroChoi TroChoi; // Form chơi trò chơi
        List<String> TenNguoiChoi; // Danh sách tên người chơi
        List<String> CheDoDangKiNguoiChoi; // Danh sách chế độ chơi của người chơi
        int count; // Biến đếm số lần người dùng nhấp vào nút "Đối thủ"
        #endregion

        public frm_Welcome()
        {
            InitializeComponent();
            TenNguoiChoi = new List<string>() { "Player1", "Computer" };
            CheDoDangKiNguoiChoi = new List<String>() { "X", "O", "easy", "P-C" };
            count = 0;
            panelBienvenue.BringToFront();
            panelBienvenue.Dock = DockStyle.Fill;
            timer1.Start();
        }

        // Hiển thị màn hình chào mừng khi form được mở. Màn hình này sẽ tự động biến mất sau một khoảng thời gian nhất định sử dụng một timer.
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            panelBienvenue.Visible = false;
        }

        // Quy trình sửa đổi lựa chọn của đối thủ
        private void DoiNguoiChoi()
        {
            if (count % 2 == 0)
            {
                btnPlayer.BackgroundImage = Properties.Resources.buttonPlayer_Player;
                CheDoDangKiNguoiChoi[3] = "P-P";
                TenNguoiChoi[1] = "Player2";
            }
            else
            {
                btnPlayer.BackgroundImage = Properties.Resources.buttonPlayer_Computer;
                CheDoDangKiNguoiChoi[3] = "P-C";
                TenNguoiChoi[1] = "Computer";
            }
            count++;
        }


        #region Click
        // Nhấp vào thủ tục trong nút biểu mẫu
        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Name)
            {
                case "btnPlay":
                    TroChoi = new frm_TroChoi(TenNguoiChoi, CheDoDangKiNguoiChoi);
                    TroChoi.ShowDialog();
                    break;
                case "btnSettings":
                    settings = new frm_settings(ref TenNguoiChoi, ref CheDoDangKiNguoiChoi);
                    settings.ShowDialog();
                    break;
                case "btnPlayer":
                    DoiNguoiChoi();
                    break;
                case "btnQuit":
                    Application.Exit();
                    break;
            }
        }




    #endregion

    private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
