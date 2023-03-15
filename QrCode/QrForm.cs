using QRCoder;
using System;
using System.Windows.Forms;

namespace QrCode
{
    public partial class QrForm : Form
    {
        public QrForm()
        {
            InitializeComponent();
        }
        private void GenerateQrCode(string info)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrData = qrGenerator.CreateQrCode(info, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrData);

            pictureBox1.Image = qrCode.GetGraphic(20);
        }
        //We can go to youtube with link
        private void btn_youtube_Click(object sender, EventArgs e)
        {
            PayloadGenerator.Url connectYoutube = new PayloadGenerator.Url("https://www.youtube.com/watch?v=GhQxrCrVSyw&ab_channel=DanMusic");
            string info = connectYoutube.ToString();
            GenerateQrCode(info);
        }
        //We can connect automatically to wifi with this QR generator method
        private void btn_wifi_Click(object sender, EventArgs e)
        {
            PayloadGenerator.WiFi connectWifi = new PayloadGenerator.WiFi(ssid: "WifiName", password: "WifiPassword", PayloadGenerator.WiFi.Authentication.WPA);
            string info = connectWifi.ToString();
            GenerateQrCode(info);
        }
        //we can direct to calling part of guide
        private void btn_Call_Click(object sender, EventArgs e)
        {
            PayloadGenerator.PhoneNumber connectCall = new PayloadGenerator.PhoneNumber("PhoneNumber");
            string info = connectCall.ToString();
            GenerateQrCode(info);
        }
    }
}
