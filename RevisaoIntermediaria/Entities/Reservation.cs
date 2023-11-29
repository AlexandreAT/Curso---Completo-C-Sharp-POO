using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RevisaoIntermediaria.Entities.Exceptions;

namespace RevisaoIntermediaria.Entities
{
    public class Reservation
    {
        public int RoomNumber {get; set;}
        public DateTime CheckIn {get; set;}
        public DateTime CheckOut {get; set;}

        public Reservation(){
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut){

            if(checkOut <= checkIn){

                throw new DomainException ("A data de CheckOut é igual ou anterior a data de CheckIn!");

            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;

        }

        public int Duration(){

            TimeSpan comparison = CheckOut.Subtract(CheckIn);
            return (int)comparison.TotalDays;

        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut){

            DateTime Now = DateTime.Now;

            if(checkIn < Now || checkOut < Now){

                throw new DomainException ("As datas de reserva são anteriores a data atual!");

            }

            if(checkOut <= checkIn){

                throw new DomainException ("A data de CheckOut é igual ou anterior a data de CheckIn!");

            }

            CheckIn = checkIn;
            CheckOut = checkOut;

        }

        public override string ToString()
        {
            return "Dados da reserva: Número do quarto "+RoomNumber+" - CheckIn "+CheckIn.ToString("dd/MM/yyyy")+
            " | CheckOut "+CheckOut.ToString("dd/MM/yyyy")+" - Duração total: "+Duration()+" dias.";
        }

    }
}