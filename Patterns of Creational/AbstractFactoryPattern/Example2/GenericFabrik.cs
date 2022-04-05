namespace AbstractFactoryPattern.Example2
{
    public class GenericFabrika
    {
        private IFabrikaOtomobil _fabrikaOtomobil;
        private ILastik _lastik;
        private IMotor _motor;

        public GenericFabrika(IFabrikaOtomobil fabrikaOtomobil, ILastik lastik, IMotor motor)
        {
            _fabrikaOtomobil = fabrikaOtomobil;
            _lastik = fabrikaOtomobil.LastikTak(lastik);
            _motor = fabrikaOtomobil.MotorTak(motor);
        }

        public void Yazdir()
        {
            var exp = (_fabrikaOtomobil.GetType() + " fabrikası" + _lastik.Lastik() + " lastiği ve " + _motor.Motor() + " motoru tercih etti.");
            Console.WriteLine(exp);
        }
    }

    public interface IFabrikaOtomobil
    {
        ILastik LastikTak(ILastik lastik);
        IMotor MotorTak(IMotor motor);
    }

    public class Mercedes : IFabrikaOtomobil
    {
        public ILastik LastikTak(ILastik lastik)
        {
            if (lastik is Lassa)
            {
                Lassa lassa = new Lassa();
                return lassa;
            }
            else if (lastik is Petlas)
            {
                Petlas petlas = new Petlas();
                return petlas;
            }
            else
            {
                Console.WriteLine("Geçersiz lastik");
                return null;
            }
        }

        public IMotor MotorTak(IMotor motor)
        {
            if (motor is EngineA)
            {
                EngineA engineA = new EngineA();
                return engineA;
            }
            else if (motor is EngineB)
            {
                EngineB engineB = new EngineB();
                return engineB;
            }
            else
            {
                Console.WriteLine("Geçersiz motor türü");
                return null;
            }
        }
    }
    public class Fiat : IFabrikaOtomobil
    {
        public ILastik LastikTak(ILastik lastik)
        {
            if (lastik is Lassa)
            {
                Lassa lassa = new Lassa();
                return lassa;
            }
            else if (lastik is Petlas)
            {
                Petlas petlas = new Petlas();
                return petlas;
            }
            else
            {
                Console.WriteLine("Geçersiz lastik");
                return null;
            }
        }

        public IMotor MotorTak(IMotor motor)
        {
            if (motor is EngineA)
            {
                EngineA engineA = new EngineA();
                return engineA;
            }
            else if (motor is EngineB)
            {
                EngineB engineB = new EngineB();
                return engineB;
            }
            else
            {
                Console.WriteLine("Geçersiz motor türü");
                return null;
            }
        }
    }

    public interface ILastik
    {
        string Lastik();
    }

    public interface IMotor
    {
        string Motor();
    }


    public class Lassa : ILastik
    {
        public string Lastik()
        {
            return "Lassa";
        }
    }
    public class Petlas : ILastik
    {
        public string Lastik()
        {
            return "Petlas";
        }
    }

    public class EngineA : IMotor
    {
        public string Motor()
        {
            return "EngineA";
        }
    }

    public class EngineB : IMotor
    {
        public string Motor()
        {
            return "EngineB";
        }
    }
}



