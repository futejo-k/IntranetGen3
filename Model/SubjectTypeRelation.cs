﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensaGymnazium.IntranetGen3.Model
{
	/// <summary>
	/// M:N relation representing Subject.Types
	/// </summary>
	public class SubjectTypeRelation
	{
		public Subject Subject { get; set; }
		public int SubjectId { get; set; }

		public SubjectType SubjectType { get; set; }
		public int SubjectTypeId { get; set; }
	}
}