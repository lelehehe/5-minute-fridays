namespace SampleTests
{
    public class Person
    {
        public delegate void MyEventHandler(int cach);

        public event MyEventHandler cachEvent;

        private int cach;
        public int Cach
        {
            get
            {
                return cach;
            }
            set
            {
                cach = value;
                if (cach >= 100)
                {
                    if (cachEvent != null)
                    {
                        cachEvent(this.Cach);
                    }
                }
            }
        }

        public void AddCach(int amount)
        {
            Cach += amount;
        }
    }
}