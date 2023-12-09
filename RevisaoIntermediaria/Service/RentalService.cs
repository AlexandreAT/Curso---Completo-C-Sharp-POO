using RevisaoIntermediaria.Entities;

namespace RevisaoIntermediaria.Service
{
    public class RentalService
    {
        
        public double PricePerHour {get; private set;}
        public double PricePerDay {get; private set;}
        private ITaxService _taxService;
        
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService) 
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental){

            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double BasicPayment;
            
            if(duration.TotalHours <= 12){

                BasicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);

            }
            else{
                BasicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }
            carRental.Invoice = new Invoice (BasicPayment, _taxService.Tax(BasicPayment));

        }
    }
}