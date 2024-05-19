using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleSystem
{
    public partial class Rainbow : Form
    {
        List<Particle> particles = new List<Particle>();
        Emitter emitter; // добавим поле для эмиттера

        ColorPoint point1; // добавил поле под первую точку
        ColorPoint point2; // добавил поле под вторую точку
        ColorPoint point3; // добавил поле под третью точку
        ColorPoint point4; // добавил поле под первую точку
        ColorPoint point5; // добавил поле под вторую точку
        ColorPoint point6; // добавил поле под третью точку
        ColorPoint point7;

        public Rainbow()
        {
            InitializeComponent();

            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            emitter = new TopEmitter
            {
                Width = picDisplay.Width,
                GravitationY = 0.25f
            };

            point1 = new ColorPoint
            {
                Size = 50,
                X = /*(float)(picDisplay.Width * 0.25)*/50,
                Y = /*picDisplay.Height / 2*/50,
                //ToColor = Color.Black,
                FromColor = Color.Red,
            };
            point2 = new ColorPoint
            {
                Size = 50,
                X = /*picDisplay.Width / 2 - 100*/150,
                Y = /*picDisplay.Height / 2*/60,
                //ToColor = Color.Black,
                FromColor = Color.Orange,
            };
            point3 = new ColorPoint
            {
                Size = 50,
                X = /*(float)(picDisplay.Width * 0.75)*/250,
                Y = /*picDisplay.Height / 2*/70,
                //ToColor = Color.Black,
                FromColor = Color.Yellow,
            };
            point4 = new ColorPoint
            {
                Size = 50,
                X = 350,
                Y = 80,
                //ToColor = Color.Black,
                FromColor = Color.Green,
            };
            point5 = new ColorPoint
            {
                Size = 50,
                X = 450,
                Y = 70,
                //ToColor = Color.Black,
                FromColor = Color.Blue,
            };
            point6 = new ColorPoint
            {
                Size = 50,
                X = 550,
                Y = 60,
                //ToColor = Color.Black,
                FromColor = Color.Violet,
            };
            point7 = new ColorPoint
            {
                Size = 50,
                X = 650,
                Y = 50,
                //ToColor = Color.Black,
                FromColor = Color.Indigo,
            };

            emitter.impactPoints.Add(point1);
            emitter.impactPoints.Add(point2);
            emitter.impactPoints.Add(point3);
            emitter.impactPoints.Add(point4);
            emitter.impactPoints.Add(point5);
            emitter.impactPoints.Add(point6);
            emitter.impactPoints.Add(point7);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState();

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black); // А ЕЩЕ ЧЕРНЫЙ ФОН СДЕЛАЮ
                emitter.Render(g);
            }

            picDisplay.Invalidate();
        }

        private void trackBarForRed_Scroll(object sender, EventArgs e)
        {
            point1.Y = trackBarForRed.Value;
        }

        private void trackBarForOrange_Scroll(object sender, EventArgs e)
        {
            point2.Y = trackBarForOrange.Value;
        }

        private void trackBarForYellow_Scroll(object sender, EventArgs e)
        {
            point3.Y = trackBarForYellow.Value;
        }

        private void trackBarForGreen_Scroll(object sender, EventArgs e)
        {
            point4.Y = trackBarForGreen.Value;
        }

        private void trackBarForBlue_Scroll(object sender, EventArgs e)
        {
            point5.Y = trackBarForBlue.Value;
        }
        private void trackBarForViolet_Scroll(object sender, EventArgs e)
        {
            point6.Y = trackBarForViolet.Value;
        }
        private void trackBarForIndigo_Scroll(object sender, EventArgs e)
        {
            point7.Y = trackBarForIndigo.Value;
        }
    }
}
