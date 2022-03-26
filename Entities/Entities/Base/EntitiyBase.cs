using System;

namespace Entities.Entities.Base
{
	/// <summary>
	/// Base class for entities. Every entity should extend this. Contains fields that every entity should have
	/// </summary>
	public class EntityBase
	{
		public EntityBase()
		{
			Id = Guid.NewGuid();
			CreatedDate = DateTime.Now;
			UpdatedDate = DateTime.Now;
		}
		public Guid Id { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }
	}
}
