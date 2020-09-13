using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Use AForge
using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Facial_Detection
{
    public partial class FacialDetection : Form
    {
        public FacialDetection()
        {
            InitializeComponent();
        }

        //Filter
        FilterInfoCollection filter;
        //Users device
        VideoCaptureDevice webcam;
        //Testing Data
        static readonly CascadeClassifier data = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
        private void FacialDetection_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo f in filter) uxDeviceBox.Items.Add(f.Name);
            
            uxDeviceBox.SelectedIndex = 0;
            webcam = new VideoCaptureDevice();
        }

        private void uxSelect_Click(object sender, EventArgs e)
        {
            webcam = new VideoCaptureDevice(filter[uxDeviceBox.SelectedIndex].MonikerString);
            webcam.NewFrame += NewFrame;
            webcam.Start();
        }

        private void NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap map = (Bitmap)eventArgs.Frame.Clone();
            Image<Bgr, byte> image = new Image<Bgr, byte>(map);
            Rectangle[] rectangles = data.DetectMultiScale(image, 1.2, 1);
            foreach(Rectangle r in rectangles)
            {
                using(Graphics g = Graphics.FromImage(map))
                {
                    using (Pen p = new Pen(Color.Green, 2))
                    {
                        g.DrawRectangle(p, r);
                    }
                }
            }
            uxDisplay.Image = map;
        }

        private void FacialDetection_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (webcam.IsRunning) webcam.Stop();
        }
    }
}
