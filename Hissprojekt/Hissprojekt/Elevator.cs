namespace Hissprojekt
{
    class Elevator
    {
        public string Name { get; set; }
        public int LowestFloor { get; set; }
        public int HighestFloor { get; set; }
        public int CurrentFloor { get; set; }
        public int TimeToMaintenance { get; set; }
        public string Power = "På";
      



        public Elevator(string a, int b, int c, int d, int e)
        {
            Name = a;
            LowestFloor = b;
            HighestFloor = c;
            CurrentFloor = d;
            TimeToMaintenance = e;
    
        }

        public Elevator(string a, int b, int c)
        {
            Name = a;
            LowestFloor = b;
            HighestFloor = c;
            CurrentFloor = LowestFloor;
            TimeToMaintenance = 5;
        }


        public string Report()
        {
            return $"{Name} är på våning {CurrentFloor}. Hissen är {Power} Tills underhåll: {TimeToMaintenance}";

        }

        public void GoUp()
        {
            if (CurrentFloor < HighestFloor)
            {

                if (TimeToMaintenance == 0)
                    Power = "Av";
                else
                {
                    TimeToMaintenance--;
                    CurrentFloor++;
                }
            }
            
        }

        public void GoDown()
        {
            if (CurrentFloor > LowestFloor)
            {
                if (TimeToMaintenance == 0)
                    Power = "Av";
                else
                {
                    CurrentFloor--;
                    TimeToMaintenance--;
                }
            }

        }

    }












}


