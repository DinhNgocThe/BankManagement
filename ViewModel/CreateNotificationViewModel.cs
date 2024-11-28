using BankManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.ViewModel
{
    internal class CreateNotificationViewModel
    {
        private NotifyRepository notifyRepository;

        private string title;
        private string content;

        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }

        public CreateNotificationViewModel()
        {
            notifyRepository = new NotifyRepository();
        }

        public void CreateNotification()
        {
            Notify notify = new Notify(this.title, this.content);
            notifyRepository.CreateNotification(notify);
        }
    }
}
