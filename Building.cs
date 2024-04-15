using System.Dynamic;

namespace _0414_S3_Constructors
{
    internal class Building
    {
        private readonly int _floors;
        private readonly double _height;

        public Building() { }

        public Building(int floors): this()
        {
            _floors = floors;
            _height = floors * 3;
        }

        public Building(int floors, double height) : this(floors)
        {
            _height = height;
        }

        public double GetFloorMaxSize() => _height / _floors;

        public int GetFloorCount() => _floors;

        public double GetSize() => _height;
    }
}
