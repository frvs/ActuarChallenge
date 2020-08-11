using Domain.ValueObjects;
using Flunt.Validations;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Product : Entity, IValidatable
    {
        public Product() : base()
        {
            RegisterDate = DateTime.Now;
        }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public decimal Value { get; set; }

        [Required]
        public string Barcode { get; set; }

        public DateTime RegisterDate { get; set; }

        public DateTime? ExitDate { get; set; }

        public void Remove()
        {
            ExitDate = DateTime.Now;
        }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
