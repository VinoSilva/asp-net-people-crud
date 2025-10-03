using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;
using PeopleCrud.Api.Models.DTO;

namespace PeopleCrud.Api.Models;

[Table("Person")]
public class Person
{
    public int Id { get; set; }

    [Column(TypeName = "varchar(30)")]
    [Required]
    public required string Name { get; set; }

    // added code
    public static GetPersonDto ToGetPersonDto(Person person)
    {
        return new GetPersonDto
        {
            Id = person.Id,
            Name = person.Name
        };
    }
}