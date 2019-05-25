using System;
using System.Collections.Generic;
using System.Text;

namespace ShowClix
{
    public class SeatNode
    {
        public SeatNode Previous { get; set; }
        public SeatNode Next { get; set; }
        public Seat SeatObj { get; set; }
        public SeatNode() { }
        public SeatNode(SeatNode prev, SeatNode nex, Seat obj) { Previous = prev; Next = nex; SeatObj = obj;}
        public bool IsEmpty() {if(SeatObj.IsEmpty()) { return true; } return false;}
        public SeatNode(Seat seat) {SeatObj = seat;}
    }
    public class Seat
    {
        public String ID { get; private set;}
        public bool Reserved { get; private set;}
        public Seat() { }
        public Seat(string init) {ID = init;}
        public bool IsEmpty() { if (ID == null) { return true; } return false; }
    }
}
