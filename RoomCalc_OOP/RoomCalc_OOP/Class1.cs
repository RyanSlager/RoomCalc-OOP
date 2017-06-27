namespace RoomCalc_OOP
{
    class Room
    {
        private double width;
        private double length;

        public Room(double w, double l)
        {
            this.width = w;
            this.length = l;
        }

        public double Area()
        {
            return width * length;
        }

        public double Perimeter()
        {
            return (2 * width) + (2 * length);
        }

        public string PrintInfo()
        {
            double a = this.Area();
            double p = this.Perimeter();

            string info = $"The area of the room is {a} and the perimeter of the room is {p}";
            return info;
        }
    }
}
