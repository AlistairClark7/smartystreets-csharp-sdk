﻿using System;
using System.Runtime.Serialization;

namespace SmartyStreets
{
	[DataContract]
	public class Lookup
	{
		#region [ Fields ]

		public Result Result { get; set; }

		public string InputId { get; set; }

		[DataMember(Name = "city")]
		public string City { get; set; }

		[DataMember(Name = "state")]
		public string State { get; set; }

		[DataMember(Name = "zipcode")]
		public string Zipcode { get; set; }

		#endregion

		#region [ Constructors ]

		public Lookup()
		{
			this.Result = new Result();			
		}

		public Lookup(string zipcode) : this()
		{
			this.Zipcode = zipcode;
		}

		public Lookup(string city, string state) : this()
		{
			this.City = city;
			this.State = state;
		}

		public Lookup(string city, string state, string zipcode) : this()
		{
			this.City = city;
			this.State = state;
			this.Zipcode = zipcode;
		}

		#endregion
	}
}

