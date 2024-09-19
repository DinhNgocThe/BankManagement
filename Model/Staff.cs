using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Model
{
	internal class Staff
	{
		private int id;
		private string name;
		private string username;
		private string password;
		private string workingBranch;
		private string jobPosition;

		public Staff(int id, string name, string username, string password, string workingBranch, string jobPosition)
		{
			this.id = id;
			this.name = name;
			this.username = username;
			this.password = password;
			this.workingBranch = workingBranch;
			this.jobPosition = jobPosition;
		}
		public int GetId()
		{
			return id;
		}
		public string GetName()
		{
			return name;
		}
		public string GetUsername()
		{
			return username;
		}
		public string GetWorkingBranch() { return workingBranch; }
		public string GetJobPosition() { return jobPosition; }
	}
}
