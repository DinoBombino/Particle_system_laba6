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
        public int Power = 100; // сила притяжения
        public Color FromColor;
        public Color ToColor;

        // а сюда по сути скопировали с минимальными правками то что было в UpdateState
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY); // считаем расстояние от центра точки до центра частицы
            if (r - particle.Radius < Power / 2) // если частица оказалось внутри окружности
            {
                particle.FromColor = FromColor;
                particle.ToColor = ToColor;

            }
        }
        public override void Render(Graphics g)
        {
            // буду рисовать окружность с диаметром равным Power
            g.DrawEllipse(
                   new Pen(FromColor, 5),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
               );
        }
    }

    public class TopEmitter : Emitter
    {
        public int Width; // длина экрана

        public override void ResetParticle(Particle particle)
        {
            base.ResetParticle(particle); // вызываем базовый сброс частицы, там жизнь переопределяется и все такое

            // а теперь тут уже подкручиваем параметры движения
            particle.X = Particle.rand.Next(Width); // позиция X -- произвольная точка от 0 до Width
            particle.Y = 0;  // ноль -- это верх экрана 

            particle.SpeedY = 1; // падаем вниз по умолчанию
            particle.SpeedX = Particle.rand.Next(-2, 2); // разброс влево и вправа у частиц 
        }
    }
}

