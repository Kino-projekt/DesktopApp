namespace DesktopApp.Backend.Data
{
    public class Hall
    {
        private int id;
        private string name;
        private int seats;

        public void SetId(int id)
        {
            this.id = id;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public int GetSeats()
        {
            return seats;
        }

        public void SetSeats(int number)
        {
            seats = number;
        }
    }
}