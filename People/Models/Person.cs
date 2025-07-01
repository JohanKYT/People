using SQLite;
namespace People.Models;
[Table("people")]
public class Person
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    [PrimaryKey, AutoIncrement]
    public string Name { get; set; }
}
