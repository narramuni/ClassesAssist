using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAssist
{
    public class Students
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

		private string _contact;

		public string contact
        {
			get { return _contact; }
			set { _contact = value; }
		}




	}
}
