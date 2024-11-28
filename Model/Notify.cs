using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Model
{
    internal class Notify
    {
        private int id;
        private string message;
        private string title;
        private DateTime DateCreated;

        public Notify(string title, string message)
        {
            this.message = message;
            this.title = title;
        }

        public int Id { get => id; set => id = value; }
        public string Message { get => message; set => message = value; }
        public string Title { get => title; set => title = value; }
        public DateTime DateCreated1 { get => DateCreated; set => DateCreated = value; }
    }
}
