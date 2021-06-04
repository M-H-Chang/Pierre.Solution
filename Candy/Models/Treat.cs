using System.Collections.Generic;
namespace Candy.Models
{
  public class Treat
  {
    public Treat()
    {
      TreatFlavors = new HashSet<TreatFlavor>();
    }

    public string Name { get; set; }
    public int TreatId { get; set; }
    public virtual ICollection<TreatFlavor> TreatFlavors { get; set; }
  }
}