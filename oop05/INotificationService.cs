using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop05
{
    internal interface INotificationService
    {
        public void SendNotification(string message, string recipient);
    }
}
