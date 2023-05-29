using EstoqueApp.Application.Notifications;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Application.Handlers.Notifications
{
    public class EstoqueNotificationHandler : INotificationHandler<EstoqueNotification>
    {
        public Task Handle(EstoqueNotification notification, CancellationToken cancellationToken)
        {
            //TODO enviar para o MongoDb
            throw new NotImplementedException();
        }
    }
}
