namespace Vidly.Dtos
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Models;

    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        public MembershipType MembershipType { get; set; }

        public byte MembershipTypeId { get; set; }

        // [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }
    }
}