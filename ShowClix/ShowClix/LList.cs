using System;
using System.Collections.Generic;
using System.Text;

namespace ShowClix
{
    public abstract class LList<T>
    {
        public T Head { get; set; }
        public T Rear { get; set; }
        //public T Current { get; protected set; }
        public int ListSize {get; set;}
        //public abstract void RearAdd(T Node);
        //public abstract void FrontAdd(T Node);
        public abstract void Delete(string key);
        //public abstract void Start(T Node);
        public abstract void Print();
        public abstract T Search(string key);
        public bool IsEmpty() { if (Head == null && Rear == null) { return true; } return false; }

    }
        public class RowList : LList<SeatNode>
        {
            
            public RowList(){ Head = null; Rear = null;}

            public void FrontAdd(Seat _Seat)
            {
            if (Head == null) InitHead(_Seat);

            else
            {
                SeatNode PrevHead = Head;

                Head = new SeatNode();
                {
                    Head.SeatObj = _Seat;
                    Head.Next = PrevHead;
                    PrevHead.Previous = Head;
                }
            }
             
                ListSize++;
            }
            public  void RearAdd(Seat _Seat)
            {
               if(Head == null) InitHead(_Seat);

               else
               {
                SeatNode PrevRear = Rear;

                 Rear = new SeatNode();
                 {
                    Rear.SeatObj = _Seat;
                    Rear.Previous = PrevRear;
                    PrevRear.Next = Rear;
                 }
                
               }
          
            ListSize++;
            }
            public override void Delete(string key)
            {
            SeatNode current = Head;

              while (current != null)
              {
                  if (current.SeatObj.ID == key)
                  {
                     if (Head == current)
                     {
                        var NewHead = Head.Next;
                        NewHead.Previous = null;
                        Head.Next = null;
                        Head.Previous = null;
                        Head = NewHead;
                     }

                     if (Rear == current)
                     {
                        Rear = current.Previous;
                     }

                     if (current.Next != null)
                     {
                        current.Next.Previous = current.Next;
                     }

                     if (current.Previous != null)
                     {
                        current.Previous.Next = current.Next;
                     }
                    current = current.Next;
                  }
              }
            }
            public void InitHead(Seat _Seat)
            {
              if (Head == null)
              {
                Head = new SeatNode(_Seat);
                Rear = Head;
              }

                else
                {
                  SeatNode PrevHead = Head;

                  Head = new SeatNode();
                  {
                    Head.SeatObj = _Seat;
                    Rear = PrevHead;
                  }

                Rear.Previous = Head;
                }

              }
            public override void Print()
            {
            SeatNode Temp = new SeatNode();
            Temp = Head;

              do
              {
                Console.WriteLine(Temp.SeatObj.ID);
                Temp = Temp.Next;
              } while (Temp != null);

           return;
            }
            public override SeatNode Search(string key)
            {
              SeatNode current = new SeatNode();
              current = Head;
              if (IsEmpty())
              {
                  return null;
              }
              else if(current != null && !key.Equals(current.SeatObj.ID))
              {
                current = current.Next;
              }
            return current;
            }
    }

        
    
}
