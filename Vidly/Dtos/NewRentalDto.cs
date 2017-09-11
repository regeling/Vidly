namespace Vidly.Dtos
{
    using System.Collections.Generic;

    public class NewRentalDto
    {
        public int CustomerId { get; set; }
        public List<int> MovieIds { get; set; }
    }
}