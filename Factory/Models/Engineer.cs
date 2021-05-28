using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }
    public int EngineerId { get; set; }
    public string Name { get; set; }

    [DisplayName("HireDate")]
    [DataType(DataType.Date)]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime HireDate { get; set; }
    public ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}