using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentSystem_DomainLayer
{
    class Section
    {
		public int SectionId { get; set; }
		public string SectionName { get; set; }
		public string Time { get; set; }
		public string Day { get; set; }
		public int Capacity { get; set; }
		public int AvailableSlot { get; set; }
	}
}
