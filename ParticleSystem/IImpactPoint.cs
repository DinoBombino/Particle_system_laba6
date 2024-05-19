using ParticleSystem;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    public abstract class IImpactPoint
    {
        public float X; 
        public float Y;
        
        // Абстрактный метод для изменения состояния частиц
        public abstract void ImpactParticle(Particle particle);

        // Метод для отрисовки кольца
        public virtual void Render(Graphics g)
        {
            g.FillEllipse(
                   new SolidBrush(Color.Red),
                   X - 5,
                   Y - 5,
                   10,
                   10
               );
        }
    }

    public class ColorPoint : IImpactPoint
    {
        public int Size = 100; // сила притяжения
        public Color FromColor;
        public Color ToColor;

        // а сюда по сути скопировали с минимальными правками то что было в UpdateState
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY); // считаем расстояние от центра точки до центра частицы
            if (r - particle.Radius < Size / 2) // если частица оказалось внутри окружности
            {
                particle.FromColor = FromColor;
                particle.ToColor = ToColor;

            }
        }
        public override void Render(Graphics g)
        {
            // буду рисовать окружность с диаметром равным Size
            g.DrawEllipse(
                   new Pen(FromColor, 5),
                   X - Size / 2,
                   Y - Size / 2,
                   Size,
                   Size
               );
        }
    }
}

