﻿using System;
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
    public partial class Form1 : Form
    {
        List<Particle> particles = new List<Particle>();
        //Emitter emitter = new Emitter();
        Emitter emitter; // добавим поле для эмиттера

        // добавляем переменные для хранения положения мыши
        private int MousePositionX = 0;
        private int MousePositionY = 0;
        public Form1()
        {
            InitializeComponent();

            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            emitter = new TopEmitter  /*Для снега!*/
            {
                Width = picDisplay.Width,
                GravitationY = 0.25f
            };/**/
        }

        //int counter = 0; // добавлю счетчик чтобы считать вызовы функции
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

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            // в обработчике заносим положение мыши в переменные для хранения положения мыши
            emitter.MousePositionX = e.X;
            emitter.MousePositionY = e.Y;
        }
    }
}
