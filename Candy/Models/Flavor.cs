using System;
using System.Collections.Generic;

namespace Candy.Models
{
  public class Flavor
  {
    public Flavor()
    {
      TreatFlavors = new HashSet<TreatFlavor>();
    }
    public string Name { get; set; }
    public string Description { get; set; }
    public int FlavorId { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<TreatFlavor> TreatFlavors { get; set; }
  }
}