using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
namespace WinForm
{
    public partial class GUI : Form
    {
        string deviceID = null;
        bool isstop;
        #region LoadData
        Bitmap En_level_48;
        Bitmap En_level_53;
        Bitmap En_level_59;
        Bitmap En_level_60;
        Bitmap En_level_61;
        Bitmap En_level_62;
        Bitmap En_level_65;
        Bitmap En_level_66;
        Bitmap En_level_67;
        Bitmap En_level_68;
        Bitmap En_level_70;
        Bitmap En_level_73;
        Bitmap En_level_75;
        Bitmap En_level_78;
        Bitmap En_level_80;
        Bitmap En_level_81;
        Bitmap En_level_82;
        Bitmap En_level_83;
        Bitmap fairy_queue;
        Bitmap empress_queue;
        Bitmap ironfire_queue;
        Bitmap fairy_fight;
        Bitmap empress_fight;
        Bitmap ironfire_fight;
        Bitmap En_battle;
        Bitmap En_attack;
        Bitmap En_rolling;

        //Gift to friend
        Bitmap gift_friend_1;
        Bitmap gift_friend_2;
        Bitmap gift_send_1;
        Bitmap gift_send_2;


        Bitmap anhtest;
        #endregion
        public GUI()
        {
            InitializeComponent();
            LoadData();
        }
        void checkDevice()
        {
            if (deviceID == null)
            {
                isstop = true;
                MessageBox.Show("Không tìm thấy thiết bị");
            }
        }
        void LoadData()
        {
            var listDevice = KAutoHelper.ADBHelper.GetDevices();
            if (listDevice != null && listDevice.Count > 0)
            {
                deviceID = listDevice.First();
            }
            En_level_48 = (Bitmap)Bitmap.FromFile("images/enchant/level/level_48.png");
            En_level_53 = (Bitmap)Bitmap.FromFile("images/enchant/level/level_53.png");
            En_level_59 = (Bitmap)Bitmap.FromFile("images/enchant/level/level_59.png");
            En_level_60 = (Bitmap)Bitmap.FromFile("images/enchant/level/level_60.png");
            En_level_61 = (Bitmap)Bitmap.FromFile("images/enchant/level/level_62.png");
            En_level_62 = (Bitmap)Bitmap.FromFile("images/enchant/level/level_65.png");
            En_level_65 = (Bitmap)Bitmap.FromFile("images/enchant/level/level_65.png");
            En_level_66 = (Bitmap)Bitmap.FromFile("images/enchant/level/level_66.png");
            En_level_67 = (Bitmap)Bitmap.FromFile("images/enchant/level/level_67.png");
            En_level_68 = (Bitmap)Bitmap.FromFile("images/enchant/level/level_68.png");
            En_level_70 = (Bitmap)Bitmap.FromFile("images/enchant/level/level_70.png");
            En_level_73 = (Bitmap)Bitmap.FromFile("images/enchant/level/level_73.png");
            En_level_75 = (Bitmap)Bitmap.FromFile("images/enchant/level/level_75.png");
            En_level_78 = (Bitmap)Bitmap.FromFile("images/enchant/level/level_78.png");
            En_level_80 = (Bitmap)Bitmap.FromFile("images/enchant/level/level_80.png");
            En_level_81 = (Bitmap)Bitmap.FromFile("images/enchant/level/level_81.png");
            En_level_82 = (Bitmap)Bitmap.FromFile("images/enchant/level/level_82.png");
            En_level_83 = (Bitmap)Bitmap.FromFile("images/enchant/level/level_83.png");

            fairy_queue= (Bitmap)Bitmap.FromFile("images/enchant/dragon/fairy_queue.png");
            empress_queue = (Bitmap)Bitmap.FromFile("images/enchant/dragon/empress_queue.png");
            ironfire_queue = (Bitmap)Bitmap.FromFile("images/enchant/dragon/ironfire_queue.png");
            fairy_fight = (Bitmap)Bitmap.FromFile("images/enchant/dragon/fairy_fight.png");
            empress_fight = (Bitmap)Bitmap.FromFile("images/enchant/dragon/empress_fight.png");
            ironfire_fight = (Bitmap)Bitmap.FromFile("images/enchant/dragon/ironfire_fight.png");

            En_attack= (Bitmap)Bitmap.FromFile("images/enchant/En_attack.png");
            En_battle = (Bitmap)Bitmap.FromFile("images/enchant/En_battle.png");
            En_rolling= (Bitmap)Bitmap.FromFile("images/enchant/En_rolling.png");
            //Gift to friend 
            gift_friend_1 = (Bitmap)Bitmap.FromFile("images/giftToFriend/friend_1.png");
            gift_friend_2 = (Bitmap)Bitmap.FromFile("images/giftToFriend/friend_2.png");
            gift_send_1 = (Bitmap)Bitmap.FromFile("images/giftToFriend/send_1.png");
            gift_send_2 = (Bitmap)Bitmap.FromFile("images/giftToFriend/send_2.png");

            //Test
            anhtest = (Bitmap)Bitmap.FromFile("images/enchant/anhtest.png");
        }
        void delay(int delay)
        {
            while (delay > 0)
            {
                Thread.Sleep(TimeSpan.FromMilliseconds(500));
                delay--;
                if (isstop)
                    break;
            }
        }
        public void addText(String text)
        {
            text = DateTime.Now.ToString() +": "+ text;
            Label label = new Label();
            label.Text = text;
            label.AutoSize = true;
            flowLayoutPanel.Controls.Add(label);
        }
        private void Btn_Start_Click(object sender, EventArgs e)
        {
            checkDevice();
            if (isstop)
                return;
        }
        private void Btn_enchantment_Click(object sender, EventArgs e)
        {
            isstop = false;
            //Bước 1: kiểm tra có tồn tại thiết bị không
            checkDevice();
            //Bước 2: Có thiết bị nhấn vào biểu tượng enchantment   
            if (isstop)
                return;
            //chụp màn hình thiết bị
            var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
            KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, fairy_queue);
            KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, empress_queue);
            KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, ironfire_queue);

            List<Bitmap> images = new List<Bitmap>();
            images.Add(En_level_48);
            images.Add(En_level_53);
            images.Add(En_level_59);
            images.Add(En_level_60);
            images.Add(En_level_61);
            images.Add(En_level_62);
            images.Add(En_level_65);
            images.Add(En_level_66);
            images.Add(En_level_67);
            images.Add(En_level_68);
            images.Add(En_level_70);
            images.Add(En_level_73);
            images.Add(En_level_75);
            images.Add(En_level_78);
            images.Add(En_level_80);
            images.Add(En_level_81);
            images.Add(En_level_82);
            images.Add(En_level_83);

            //tìm đối thủ 
            bool fi = true;
            while(fi)
            {
                screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                foreach(Bitmap item in images)
                {
                    var point = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, item);
                    if(point != null)
                    {
                        addText("Tìm được đối thủ");
                        fi = false;
                        break;
                    }
                }
                if (!fi)
                    break;
                addText("Làm mới đối thủ");
                var rollingPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, En_rolling);
                KAutoHelper.ADBHelper.Tap(deviceID, rollingPoint.Value.X, rollingPoint.Value.Y);
            }
            addText("Bắt đầu chiến đấu");


            //Bắt đầu trận đấu
            var battlePoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, En_battle);
            if (battlePoint != null)
                KAutoHelper.ADBHelper.Tap(deviceID, battlePoint.Value.X, battlePoint.Value.Y);
            var fairyPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, fairy_fight);
            var empressPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, empress_fight);
            var ironfirePoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, ironfire_fight);

            //chụp màn hình thiết bị
            screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
            addText("Chọn rồng để chiến đấu");
            delay(10);
            Point dragonPoint = new Point();
            if (fairyPoint != null)
            {
                dragonPoint.X = fairyPoint.Value.X;
                dragonPoint.Y = fairyPoint.Value.Y;
            }
            else
            {
                if (empressPoint != null)
                    dragonPoint = (Point)empressPoint;
                else
                    if (ironfirePoint != null)
                        dragonPoint = (Point)ironfirePoint;
            }
            //Chọn rồng để chiến đấu
            delay(10);
            //KAutoHelper.ADBHelper.Tap(deviceID, dragonPoint.X, dragonPoint.Y);
            KAutoHelper.ADBHelper.Tap(deviceID, fairyPoint.Value.X,fairyPoint.Value.Y);
            addText("Đã chọn được rồng chiến đấu");
            //chụp màn hình thiết bị
            screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
            var attackPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, En_attack);
            while(attackPoint != null)
            {
                KAutoHelper.ADBHelper.Tap(deviceID, attackPoint.Value.X, attackPoint.Value.Y);
                delay(4);
                attackPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, En_attack);
            }
            //Ấn tấn công
            
            
                    
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            isstop = true;
            this.Dispose();
        }
        int dem = 0;
        private void Btn_screen_Click(object sender, EventArgs e)
        { 
            isstop = false;
            checkDevice();
            if (isstop)
                return;
            var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID,false,"anhthu"+dem.ToString()+".png");
            addText("Đã chụp ảnh màn hình");
            dem++;
        }

        private void Btn_gift_Click(object sender, EventArgs e)
        {
            isstop = false;
            checkDevice();
            if (isstop)
                return;
            //nhấn vào icon friend
            var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
            var frienPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen,gift_friend_1);
            if (frienPoint != null)
                KAutoHelper.ADBHelper.Tap(deviceID,frienPoint.Value.X,frienPoint.Value.Y);

            //nhấn vào icon friend tiếp theo
            screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
            frienPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, gift_friend_2);
            if (frienPoint != null)
                KAutoHelper.ADBHelper.Tap(deviceID, frienPoint.Value.X, frienPoint.Value.Y);

            while(true)
            {
                screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                var giftPoint1 = KAutoHelper.ImageScanOpenCV.FindOutPoints(screen, gift_send_1);
                var giftPoint2 = KAutoHelper.ImageScanOpenCV.FindOutPoints(screen, gift_send_2);
                if (giftPoint1 == null && giftPoint2 == null)
                    break;
                else
                {
                    foreach(var point in giftPoint1)
                        KAutoHelper.ADBHelper.Tap(deviceID, point.X, point.Y);
                    foreach (var point in giftPoint2)
                        KAutoHelper.ADBHelper.Tap(deviceID, point.X, point.Y);
                    // kéo màn hình xuống để click tiếp
                    KAutoHelper.ADBHelper.SwipeByPercent(deviceID, 50, 90, 50, 75);
                }
            }
            addText("Tặng quà hoàn tất");
            return;
        }

        private void Btn_test_Click(object sender, EventArgs e)
        {
            var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
            var point = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, anhtest);
            if (point != null)
                addText("chưanull");

        }
    }
}
