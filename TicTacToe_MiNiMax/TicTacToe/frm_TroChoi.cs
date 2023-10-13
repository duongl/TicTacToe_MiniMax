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
    public partial class frm_TroChoi : Form
    {

        #region Variable

        Random random; // biến để sinh số ngẫu nhiên
        TableLayoutPanel table; // biến để lưu trữ bảng
        List<String> playerName; // biến để lưu trữ tên người chơi
        List<String> CheDo; // biến để lưu trữ chế độ chơi
        String Thongtin; // biến để lưu trữ thông tin
        int countNameBtn = 0; // biến để đếm số lượng nút đã được đánh
        int nbColRow; // biến để lưu trữ số cột và dòng trong bảng
        int DemNguoi; // biến để lưu trữ lượt chơi hiện tại
        bool DuLieuDoc, DuLieuNgang, DuLieuCheoPhai, DuLieuCheoTrai; // biến để kiểm tra kết quả trò chơi
        List<Control> buttonListEnabled; // biến để lưu trữ danh sách các nút đã được kích hoạt
        bool stop; // biến để dừng lại trò chơi
        Control Chon; // biến để lưu trữ nút được chọn
        int GiaTriPhanTu; // biến để lưu trữ giá trị của ô trong bảng
        int DiemSo1; // biến để lưu trữ điểm số của người chơi 1
        int DiemSo2; // biến để lưu trữ điểm số của người chơi 2
        #endregion

        public frm_TroChoi(List<String> playerName, List<String> CheDo)
        {
            InitializeComponent();
            this.playerName = new List<string>();
            this.CheDo = new List<String>();
            this.playerName = playerName;
            this.CheDo = CheDo;
            buttonListEnabled = new List<Control>();
            DiemSo1 = 0;
            DiemSo2 = 0;
            nbColRow = 3;
            table = createTableLayoutPanel(nbColRow);
            GiaTriPhanTu = 0;
            random = new Random();
            btnAffichageJoueur1.SendToBack();
            btnAffichageJoueur2.SendToBack();
            MoiLuot(DemNguoi);
            KhoiTao();
        }


        // Khởi tạo
        private void KhoiTao()
        {
            DuLieuDoc = false;
            DuLieuNgang = false;
            DuLieuCheoPhai = false;
            DuLieuCheoTrai = false;
            DemNguoi = 0;
            countNameBtn = 0;
            deleteButton();
            addButtonTable();
            stop = false;
            lblJoueur1.Text = CheDo[0];
            lblScoreJoueur1.Text = DiemSo1.ToString();
            lblJoueur2.Text = CheDo[1];
            lblScoreJoueur2.Text = DiemSo2.ToString();
            MoiLuot(DemNguoi);
            if (Thongtin == CheDo[0])
            {
                if (CheDo[3] == "P-C")
                {
                    DemNguoi++;
                    buttonEnabledFalse();
                    TuyChonMayHayNguoi(buttonListEnabled, stop);
                }

            }   
            else
            {
                DemNguoi = 0;
            }
            Thongtin = "";
        }
        /// Xóa nút trong bảng
        private void deleteButton()
        {
            for (int i = 0; i < table.RowCount; i++)
            {
                for (int j = 0; j < table.ColumnCount; j++)
                {
                    table.Controls.Remove(table.GetControlFromPosition(j, i));
                }
            }
        }
        /// Tạo nút cho bảng
        private void addButtonTable()
        {
            for (int i = 0; i < table.RowCount; i++)
            {
                for (int j = 0; j < table.ColumnCount; j++)
                {
                    Button btn = createButton();
                    table.Controls.Add(btn, j, i);
                }
            }
        }

        /// Tạo nút
        /// Trả về = "tạo nút xong"
        private void buttonEnabledFalse()
        {
            buttonListEnabled.Clear();
            foreach (Control ctrl in table.Controls)
            {
                if (ctrl.Enabled == true)
                {
                    buttonListEnabled.Add(ctrl);
                }
            }
        }

        private void rendreButtonEnabled(bool enabled)
        {
            foreach (Button ctrl in buttonListEnabled)
            {
                ctrl.Enabled = enabled;
            }
        }

        private Button createButton()
        {
            countNameBtn++;
            Button btn = new Button();
            btn.Name = "button" + (countNameBtn).ToString();
            btn.Text = "";
            btn.Tag = btn.Name;
            btn.Font = new Font("Courier New", 35F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Dock = DockStyle.Fill;
            btn.BackColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(144)))), ((int)(((byte)(240)))));
            btn.Click += new System.EventHandler(this.buttonTableClick);
            return btn;
        }
        /// Thủ tục khi bấm vào nút của một bảng
        private void buttonTableClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DemNguoi++;
            btn.Text = MoiLuot(DemNguoi);
            btn.Tag = MoiLuot(DemNguoi);
            btn.Enabled = false;
            ChienThang(nbColRow, ref stop);
            
            buttonEnabledFalse();
            if (buttonListEnabled.Count != 0)
            {
                if (CheDo[3] == "P-C" && !stop)
                {
                    timerOrdinateur.Start();
                    foreach(Control ctrl in buttonListEnabled)
                    {
                        ctrl.Enabled = false;
                    }
                }
            }
            else if(buttonListEnabled.Count == 0 && !stop)
            {
                TroChoiKetThuc("X/O", "Hòa");
            }
            
        }
        /// Máy tính đang chơi
        private void TuyChonMayHayNguoi( List<Control> buttonListEnabled, bool stop)
        {
            int entier;
            GiaTriPhanTu = 0;
            entier = random.Next(0,buttonListEnabled.Count); 
            
            switch (CheDo[2])
            {
                case "easy":
                    Chon = buttonListEnabled[entier];
                    break;
                case "moyen":
                    Chon = buttonListEnabled[entier];
                    ĐoKho();
                    break;
            }
            DemNguoi++;
            Chon.Text = MoiLuot(DemNguoi);
            Chon.Tag = MoiLuot(DemNguoi);
            Chon.Enabled = false;
            ChienThang(nbColRow, ref stop);
            buttonEnabledFalse();
            if (buttonListEnabled.Count == 0 && !stop)
            {
                TroChoiKetThuc("X/O", "Hòa");
            }
        }
        /// Máy tính tính toán các nước đi chiến thắng và các nước đi để chống lại
        private void ĐoKho()
        {
            XacDinhCotHangPhanTu(CheDo[1], ref Chon, ref GiaTriPhanTu, false);

            if (GiaTriPhanTu < 2)
            {
                HangCotXacDinhPhanTu(CheDo[1], ref Chon, ref GiaTriPhanTu, false);
            }
            if (GiaTriPhanTu < 2)
            {
                XacDinhPhanTuDuongCheoBenPhai(CheDo[1], ref Chon, ref GiaTriPhanTu, false);
            }
            if (GiaTriPhanTu < 2)
            {
                XacDinhPhanTuDuongCheoTrai(CheDo[1], ref Chon, ref GiaTriPhanTu, false);
            }
            if (GiaTriPhanTu < 2)
            {
                XacDinhCotHangPhanTu(CheDo[0], ref Chon, ref GiaTriPhanTu, false);
            }
            if (GiaTriPhanTu < 2)
            {
                HangCotXacDinhPhanTu(CheDo[0], ref Chon, ref GiaTriPhanTu, false);
            }
            if (GiaTriPhanTu < 2)
            {
                XacDinhPhanTuDuongCheoBenPhai(CheDo[0], ref Chon, ref GiaTriPhanTu, false);
            }
            if (GiaTriPhanTu < 2)
            {
                XacDinhPhanTuDuongCheoTrai(CheDo[0], ref Chon, ref GiaTriPhanTu, false);
            }

        }
        private void XacDinhCotHangPhanTu(String caractere, ref Control Chon, ref int GiaTriPhanTu, bool GiaTriCotHangDaBat)
        {
            int colonne = 0;
            int ligne = 0;
            for (int i = 0; i < table.RowCount; i++)
            {
                GiaTriPhanTu = 0;
                for (int j = 0; j < table.ColumnCount; j++)
                {
                    if (table.GetControlFromPosition(j, i).Tag.ToString() == caractere)
                    {
                        GiaTriPhanTu++;
                    }
                    if (table.GetControlFromPosition(j, i).Enabled == true)
                    {
                        colonne = j;
                        ligne = i;
                        GiaTriCotHangDaBat = true;
                    }
                }
                if (GiaTriPhanTu >= 2 && GiaTriCotHangDaBat)
                {
                    Chon = table.GetControlFromPosition(colonne, ligne);
                    GiaTriCotHangDaBat = false;
                    break;
                }
            }
        }
        private void HangCotXacDinhPhanTu(String caractere, ref Control Chon, ref int GiaTriPhanTu, bool GiaTriCotHangDaBat)
        {
            int colonne = 0;
            int ligne = 0;
            for (int j = 0; j < table.ColumnCount; j++)
            {
                GiaTriPhanTu = 0;
                for (int i = 0; i < table.RowCount; i++)
                {
                    if (table.GetControlFromPosition(j, i).Tag.ToString() == caractere)
                    {
                        GiaTriPhanTu++;
                    }
                    if (table.GetControlFromPosition(j, i).Enabled == true)
                    {
                        colonne = j;
                        ligne = i;
                        GiaTriCotHangDaBat = true;
                    }
                }
                if (GiaTriPhanTu >= 2 && GiaTriCotHangDaBat)
                {
                    Chon = table.GetControlFromPosition(colonne, ligne);
                    GiaTriCotHangDaBat = false;
                    break;
                }
            }
        }

        private void XacDinhPhanTuDuongCheoBenPhai(String caractere, ref Control Chon, ref int GiaTriPhanTu, bool GiaTriCotHangDaBat)
        {
            int colonne = 0;
            int ligne = 0;
            GiaTriPhanTu = 0;
            for (int i = 0; i < nbColRow; i++)
            {
                if (table.GetControlFromPosition(i, i).Tag.ToString() == caractere)
                {
                    GiaTriPhanTu++;
                }
                if (table.GetControlFromPosition(i, i).Enabled == true)
                {
                    colonne = i;
                    ligne = i;
                    GiaTriCotHangDaBat = true;
                }
            }
            if (GiaTriPhanTu >= 2 && GiaTriCotHangDaBat)
            {
                Chon = table.GetControlFromPosition(colonne, ligne);
                GiaTriCotHangDaBat = false;
            }
        }

        private void XacDinhPhanTuDuongCheoTrai(String caractere, ref Control Chon, ref int GiaTriPhanTu, bool GiaTriCotHangDaBat)
        {
            int colonne = 0;
            int ligne = 0;
            GiaTriPhanTu = 0;
            for (int i = 0; i < nbColRow; i++)
            {
                if (table.GetControlFromPosition(nbColRow-1-i, i).Tag.ToString() == caractere)
                {
                    GiaTriPhanTu++;
                }
                if (table.GetControlFromPosition(nbColRow - 1 - i, i).Enabled == true)
                {
                    colonne = nbColRow - 1 - i;
                    ligne = i;
                    GiaTriCotHangDaBat = true;
                }
            }
            if (GiaTriPhanTu >= 2 && GiaTriCotHangDaBat)
            {
                Chon = table.GetControlFromPosition(colonne, ligne);
                GiaTriCotHangDaBat = false;
            }
        }
        /// Hàm đưa ra thẻ của một bảng điều khiển theo vị trí của nó
        /// Trả về thẻ nút của bảng
        private Object MoiTheBTn(int column, int row)
        {
            return table.GetControlFromPosition(column, row).Tag;
        }
        /// Hàm cho phép tô màu 3 mảnh thẳng hàng giống nhau
        /// tênthamsố = "vị trí"
        /// Vị trí của 3 quân cờ giống nhau thẳng hàng
        /// "V" = các quân được xếp theo chiều dọc
        /// "H" = các quân được xếp theo chiều ngang
        /// "DD" = các quân được xếp theo đường chéo bắt đầu từ bên phải
        /// "DG" = các quân được xếp theo đường chéo bắt đầu từ bên trái
        /// cột nút chiến thắng
        /// hàng nút chiến thắng
        /// Trả về thẻ nút chiến thắng
        private String MauWin(Object tagBtn, String position, int column, int row)
        {
            List<int> columnRowBtnPrecAct = new List<int>();
            switch (position)
            {
                case "V":
                    columnRowBtnPrecAct = new List<int>() { 1, 0 };
                    break;
                case "H":
                    columnRowBtnPrecAct = new List<int>() { 0, 1 };
                    break;
                case "DD":
                    columnRowBtnPrecAct = new List<int>() { 1, 1 };
                    break;
                case "DG":
                    columnRowBtnPrecAct = new List<int>() { 1, -1 };
                    break;
            }
            rendreButtonEnabled(false);
            for (int i=0; i<2; i++)
            {
                table.GetControlFromPosition(column, row).BackColor = Color.Gold;
                table.GetControlFromPosition(column + columnRowBtnPrecAct[0], row + columnRowBtnPrecAct[1]).BackColor = Color.Gold;
                table.GetControlFromPosition(column -columnRowBtnPrecAct[0], row - columnRowBtnPrecAct[1]).BackColor = Color.Gold;
            }

            return tagBtn.ToString();
        }
        // win
        private void ChienThang(int nbColRow, ref bool stop)
        {
            for(int i=0; i<table.RowCount; i++)
            {
                for(int j=0; j<table.ColumnCount; j++)
                {
                    if ((j!=0 || i!=0) && (j!= nbColRow-1 || i != nbColRow -1) && (j != 0 || i != nbColRow - 1) && (j != nbColRow - 1 || i != 0))
                    {
                        Object tagBtn = table.GetControlFromPosition(j, i).Tag;

                        TruongHopKhacNhauWin(i, j, nbColRow, tagBtn);
                    }
                }
            }

            if (DuLieuCheoPhai || DuLieuCheoTrai ||  DuLieuNgang || DuLieuDoc)
            {
                stop = true;
                timer1.Start();

            }
        }
        /// Quy trình tính các trường hợp trúng thưởng khác nhau
        private void TruongHopKhacNhauWin(int i, int j, int nbColRow, Object tagBtn)
        {
            if (j != 0 && j != nbColRow - 1)
            {
                if (MoiTheBTn(j + 1, i) == tagBtn && MoiTheBTn(j - 1, i) == tagBtn)
                {
                    DuLieuDoc = true;
                    Thongtin = MauWin(tagBtn, "V", j, i);
                }
            }
            if (i != 0 && i != nbColRow - 1)
            {
                if (MoiTheBTn(j, i + 1) == tagBtn && MoiTheBTn(j, i - 1) == tagBtn)
                {
                    DuLieuNgang = true;
                    Thongtin = MauWin(tagBtn, "H", j, i);
                }
            }
            if (i != 0 && i != nbColRow - 1 && j != 0 && j != nbColRow - 1)
            {
                if (MoiTheBTn(j + 1, i + 1) == tagBtn && MoiTheBTn(j - 1, i - 1) == tagBtn)
                {
                    DuLieuCheoPhai = true;
                    Thongtin = MauWin(tagBtn, "DD", j, i);
                }
                if (MoiTheBTn(j + 1, i - 1) == tagBtn && MoiTheBTn(j - 1, i + 1) == tagBtn)
                {
                    DuLieuCheoTrai = true;
                    Thongtin = MauWin(tagBtn, "DG", j, i);
                }
            }
        }

        /// Quy trình hẹn giờ được sử dụng để tạo hiệu ứng khi kết thúc trò chơi
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if ((DemNguoi - 1) % 2 == 0)
            {
                DiemSo1++;
            }
            else
            {
                DiemSo2++;
            }
            TroChoiKetThuc(Thongtin, playerName[(DemNguoi - 1) % 2] + " Thắng !!");
            
        }
        // Kết thúc trò chơi
        private void TroChoiKetThuc(String letterGagnant, String gagnant)
        {
            table.Visible = false;
            lblLettreGagnant.Text = letterGagnant;
            lblGagnant.Text = gagnant;
            lblScoreJoueur1.Text = DiemSo1.ToString();
            lblScoreJoueur2.Text = DiemSo2.ToString(); 
            HienThiMau(btnAffichageJoueur2, lblScoreJoueur2, lblJoueur2, false, Color.White, Color.White);
            labelIndicationJoueur.Text = "Bạn có muốn phát lại không ?";
            lblLettreGagnant.Visible = true;
            lblGagnant.Visible = true;
            btnThoat.Visible = true;
            btnChoiLai.Visible = true;
        }
        /// Quy trình khi nhấp vào nút phát lại hoặc thoát
        private void buttonQuitRejouer(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            timer1.Stop();
            lblGagnant.Text = "";
            lblLettreGagnant.Visible = false;
            lblGagnant.Visible = false;
            btnThoat.Visible = false;
            btnChoiLai.Visible = false;
            if(btn.Name == "btnChoiLai")
            {
                table.Visible = true;
                KhoiTao();
            }
            else if(btn.Name == "btnThoat")
            {
                this.Close();
            }

        }

        private void timerOrdinateur_Tick(object sender, EventArgs e)
        {
            timerOrdinateur.Stop();
            foreach(Control ctrl in buttonListEnabled)
            {
                ctrl.Enabled = true;
            }
            TuyChonMayHayNguoi(buttonListEnabled, stop);
        }
        /// Chức năng cho phép chơi từng người chơi một
        /// DemNguoi
        /// quân do người chơi chọn
        private String MoiLuot(int DemNguoi)
        {
            String letter = CheDo[0];
            HienThiMau(btnAffichageJoueur1, lblScoreJoueur1, lblJoueur1, false, Color.LightGray, Color.White);
            labelIndicationJoueur.Text = playerName[1] + ", đến lượt bạn !";

            if (DemNguoi%2 == 0)
            {
                letter = CheDo[1];
                HienThiMau(btnAffichageJoueur2, lblScoreJoueur2, lblJoueur2, true, Color.LightGray, Color.White);
                labelIndicationJoueur.Text = playerName[0] + ", đến lượt bạn !";
            }
            return letter;
        }
        /// Thủ tục đổi màu khi đến lượt người dùng
        private void HienThiMau(Button btnAffichageJoueur, Label lblScoreJoueur, Label lblJoueur, bool affichage1, Color couleur, Color couleurInitiale)
        {
            Color couleurBack = couleur;
            Color nonAffichageBack = couleurInitiale;
            if (affichage1)
            {
                couleurBack = couleurInitiale;
                nonAffichageBack = couleur;
            }
            btnAffichageJoueur2.BackColor = couleurBack;
            lblScoreJoueur2.BackColor = couleurBack;
            lblJoueur2.BackColor = couleurBack;
            btnAffichageJoueur1.BackColor = nonAffichageBack;
            lblScoreJoueur1.BackColor = nonAffichageBack;
            lblJoueur1.BackColor = nonAffichageBack;
        }


        /// Hàm tạo bảng theo kích thước đã chọn
        private TableLayoutPanel createTableLayoutPanel(int nbColRow)
        {
            TableLayoutPanel table = new TableLayoutPanel();
            table.Location = new Point(30, 150);
            table.Size = new Size(300, 300);
            float oui = 100 / nbColRow;
            table.ColumnCount = nbColRow;
            table.RowCount = nbColRow;
            table.BackColor = Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(189)))), ((int)(((byte)(172)))));
            for (int i=0; i<nbColRow; i++)
            {
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            }
            this.Controls.Add(table);

            return table;
        }

    }
}
