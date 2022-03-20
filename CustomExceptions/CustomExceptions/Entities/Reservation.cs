using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomExceptions.Entities.Exceptions;
using CustomExceptions;

namespace CustomExceptions.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; private set; }
        public DateTime CheckOut { get; private set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            CheckValues(checkIn,checkOut);
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn,DateTime checkOut)
        {   
            CheckValuesUpdate(checkIn,checkOut);
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
        }

        public override string ToString()
        {
            return $"Room:{this.RoomNumber}," +
                $" Check-in date {CheckIn.ToString("dd/MM/yyyy")}," +
                $" Check-out date {CheckOut.ToString("dd/MM/yyyy")}," +
                $" {this.Duration()} nights.";
        }

        private void CheckValues(DateTime dateIn, DateTime dateOut)
        {
            if ((dateOut - dateIn).Days < 0)
            {
                throw new DomainException("The check-out date cannot be earlier" +
                    " than ckeck-in date.");
            }
        }

        private void CheckValuesUpdate(DateTime In, DateTime Out)
        {
            CheckValues(In, Out);
            if (In < DateTime.Now || Out < DateTime.Now)
            {
                throw new DomainException("The chek-in date and check-out date " +
                    "cannot be earlier today's date.");
            }
        }



    }
}
