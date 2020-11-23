using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objekturientierung_1
{
	/// <summary>
	/// Eine Klasse, die eine Person darstellt. Und deine Mutter fickt du Hund
	/// </summary>
    public class Person
    {
		private string _augenFarbe = ""; //oder string.Empty

		/// <summary>
		/// Augenfarbe wird gestzt bzw. ausgelesen und in deine Fresse geschoben.
		/// </summary>
		public string AugenFarbe
		{
			get
			{ 
				return _augenFarbe;
			}
			set
			{ 
				_augenFarbe = value; 
			}
		
		}

		private string _vorName = "";

		public string VorName
		{
			get { return _vorName; }
			set { _vorName = value; }
		}

		private string _nachName = "";

		public string NachName
		{
			get { return _nachName; }
			set { _nachName = value; }

		}


	}
}
