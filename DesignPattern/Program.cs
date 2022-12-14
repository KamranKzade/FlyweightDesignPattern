using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class MovingParticle
    {
        public Particle particle { get; set; }


        private string coords { get; set; }
        private string vector { get; set; }
        private string speeed { get; set; }



        public MovingParticle(string coords, string vector, string speeed)
        {
            this.coords = coords;
            this.speeed = speeed;
            this.vector = vector;
        }

        public void Draw(string coords, string canvas)
        {
            particle.Draw(coords, canvas);
        }

        public void Move(string coords, string vector, string speed)
        {
            particle.Move(coords, vector, speed);
        }
    }


    class Particle
    {
        private string color { get; set; }
        private string sprite { get; set; }



        public Particle(string color, string sprite)
        {
            this.color = color;
            this.sprite = sprite;
        }


        public void Move(string coords, string vector, string speed)
        {
            Console.WriteLine("Coords -> 8 B");
            Console.WriteLine("vector -> 16 B");
            Console.WriteLine("speed -> 4 B");
        }


        public void Draw(string coords, string canvas)
        {
            Console.WriteLine("Coords -> 8 B");
        }
    }





    class Game
    {
        private List<Particle> particles { get; set; }
        public List<MovingParticle> mps { get; set; }


        public Particle NewParticle = new Particle("red", "gulle.png");


        public Game()
        {
            particles = new List<Particle>();
            mps = new List<MovingParticle>();
        }


        public void addParticle(string coords, string vector, string speeed)
        {

            mps.Add(new MovingParticle(coords, vector, speeed) { particle = NewParticle });

        }

        public void draw(string canvas)
        {
        }

        public void fireAt()
        {
            int random = new Random().Next(50, 200);
            for (int i = 0; i < random; i++)
            {
                Console.WriteLine($"Bullet {i} 32 Byte");

            }

            Console.WriteLine($"General Bullet -> {random * 32} bytes");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Game gamer = new Game();
            gamer.fireAt();


        }
    }
}







