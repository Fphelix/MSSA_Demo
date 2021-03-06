namespace ParkingLot
{


    class ParkingLot
    {

        private int large;
        private int medium;
        public int small;

        public ParkingLot(int _Large, int _Medium, int _Small)
        {
            large = _Large;
            medium = _Medium;
            small = _Small;

        }

        //public void SetLarge
        //    {
        //      large = value; 
        //    }
        //public void getLarge
        //{
        //    return large;
        //}


        public int Large
        {
            set{large = value;}
            get{return large;}
        }
         public int Medium
        {
            set { medium = value;}
            get { return medium; }
       
        }
        public int Small
        {
            set
            { small = value;}
            get {return small;}
           
        }

        public bool AddCar(string CarSize)
        {
            if (CarSize == "Large" && large > 0)
            {
                large--;
                return true;
            }      
                 
            if (CarSize == "Medium" && medium > 0)
            {                
                    medium --;
                    return true;                
               
            }          

            if (CarSize == "Small" && small >0)
            {
                
                    small --;
                    return true;               
            }         
                return false;

        }

    }
}
