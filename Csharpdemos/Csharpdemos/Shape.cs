using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpdemos
{
    public abstract class shape
    {
        public abstract void CalculateArea();
    }
    public class Circle : shape
    {
          public override void CalculateArea()
        {
            //int radius = int.Parse(Console.ReadLine());
            Console.WriteLine("PI*R^2");

        }
    }
    public class Rectangle : shape
    {
        public override void CalculateArea()
        {
            Console.WriteLine("l * b");
        }
    }
    interface IPlayable
    {
        void play();
    }
    public class MusicPlayer : IPlayable
    {
        public void play()
        {
            Console.WriteLine("Playing Music");
        }
    }
    public class VideoPlayer : IPlayable
    {
        public void play()
        {
            Console.WriteLine("Playing Video");
        }
    }

}
