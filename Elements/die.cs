using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameToolbox.Elements
{
    public class Die
    {       
        private int sides;
        private List<float> chances;
        private protected int seed;
        private Random random;
        private bool izi;

        public uint Sides { get => (uint)sides; set { sides = (int)value; Setup(); } }
        public bool IsZeroIndexed { get => izi; set => izi = value; }
        public float ChancePerSide { get => 1.0f / sides * 100; }

        public Die(uint sides, int seed = 0, bool isZeroIndexed = false) 
        {
            this.seed = seed;
            IsZeroIndexed = isZeroIndexed;
            Sides = sides;
        }

        private void Setup()
        {
            random = new Random(seed);
            float cps = 1.0f / sides; //cps = chance per side
            chances = new List<float>(sides);
            float c = 0;
            for (int i = 0; i < sides; i++)
            {
                chances.Add(c);
                c += cps;
            }
        }

        /// <summary>
        /// Rolls the die once.
        /// </summary>
        /// <param name="roll">Outputs the rolled value.</param>
        /// <returns>Returns a boolean indentifying if the roll was valid.</returns>
        public bool Roll(out int roll)
        {
            float value = (float)random.NextDouble();
            roll = -1;
            for(int i = 0; i < sides; i++)
            {
                if (i == sides - 1 && value >= chances[i]) roll = IsZeroIndexed ? i : i + 1;
                else if (value >= chances[i] && value < chances[i + 1])
                {
                    roll = IsZeroIndexed ? i : i + 1;
                }
            }
            return roll != -1;
        }
        public int Roll()
        {
            float value = (float)random.NextDouble();
            int roll = -1;
            for (int i = 0; i < sides; i++)
            {
                if (i == sides - 1) roll = IsZeroIndexed ? i : i + 1;
                else if (value >= chances[i] && value < chances[i + 1])
                {
                    roll = IsZeroIndexed ? i : i + 1;
                }
            }
            return roll;
        }

        #region Operators
        public static int operator+(Die d1, Die d2)
        {
            if (d1.Roll(out int r1))
            {
                if (d2.Roll(out int r2))
                {
                    return r1 + r2;
                }
                else throw new Exception("The second roll was invalid.");
            }
            else throw new Exception("The first roll was invalid.");
        }

        public static int operator*(Die d1, Die d2)
        {
            if (d1.Roll(out int r1))
            {
                if (d2.Roll(out int r2))
                {
                    return r1 * r2;
                }
                else throw new Exception("The second roll was invalid.");
            }
            else throw new Exception("The first roll was invalid.");
        }

        public static int operator/(Die d1, Die d2)
        {
            if (d1.Roll(out int r1))
            {
                if (d2.Roll(out int r2))
                {
                    return r1 / r2;
                }
                else throw new Exception("The second roll was invalid.");
            }
            else throw new Exception("The first roll was invalid.");
        }

        public static int operator-(Die d1, Die d2)
        {
            if (d1.Roll(out int r1))
            {
                if (d2.Roll(out int r2))
                {
                    return r1 - r2;
                }
                else throw new Exception("The second roll was invalid.");
            }
            else throw new Exception("The first roll was invalid.");
        }

        public static int operator%(Die d1, Die d2)
        {
            if (d1.Roll(out int r1))
            {
                if (d2.Roll(out int r2))
                {
                    return r1 % r2;
                }
                else throw new Exception("The second roll was invalid.");
            }
            else throw new Exception("The first roll was invalid.");
        }

        public static implicit operator int(Die d1)
        {
            if (d1.Roll(out int r1))
            {
                return r1;
            }
            else throw new Exception("The roll was invalid");
        }
        #endregion
    }
}
