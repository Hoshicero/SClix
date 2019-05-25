using System;
using System.Collections.Generic;
using System.Text;

namespace ShowClix
{
    class Theatre
    {
        public int Rows {private set; get;}
        public int Seats { private set; get;}
        public RowList SeatChart = new RowList();
        public void Init()
        {
            for (int row = 1; row <= Rows; row++ )
            {
                for(int seats = 0; seats <= Seats; seats++)
                {
                    
                    
                SeatChart.FrontAdd(new SeatNode(new Seat(String.Concat(row.ToString(), seats.ToString()))).SeatObj);
                    
                 
                }
            }
        }
        public Theatre(int rows, int seats) {Rows = rows; Seats = seats; Init();}
        public Theatre() {Init();}
    }
}
