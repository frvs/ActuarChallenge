using Flunt.Notifications;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.ValueObjects
{
    [NotMapped]
    public class Entity : Notifiable, IEquatable<Entity>
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        public bool Equals(Entity other)
        {
            return Id == other.Id;
        }

    }
}
