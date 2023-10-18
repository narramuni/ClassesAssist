using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAssist
{
    public class Teachers
    {
		private int _Id;

		public int Id
        {
			get { return _Id; }
			set { _Id = value; }
		}

		private string _name;

		public string name
        {
			get { return _name; }
			set { _name = value; }
		}

		private string _address;

		public string address
        {
			get { return _address; }
			set { _address = value; }
		}

		private DateTime _dateOfJoining;

		public DateTime dateOfJoining
        {
			get { return _dateOfJoining; }
			set { _dateOfJoining = value; }
		}


	}
}
