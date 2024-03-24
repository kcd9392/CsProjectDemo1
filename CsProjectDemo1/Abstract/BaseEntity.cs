using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entity.Abstract;

public class BaseEntity
{
    public Guid Id { get; set; }= Guid.NewGuid();
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedDate { get; set; }= DateTime.Now;

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime? UpdatedDate { get; set; }=DateTime.Now;
}
    
