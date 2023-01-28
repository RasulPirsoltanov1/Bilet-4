using Bilet_4.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilet_4.Core.Entities
{
	public class Feature:IEntity
	{
		public int Id { get; set; }
		[Required,MaxLength(150)]
		public string? Title { get; set; }
		[Required, MaxLength(150)]
		public string? Description { get; set; }
		[Required, MaxLength(50)]
		public string? IconName { get; set; }	
	}
}
