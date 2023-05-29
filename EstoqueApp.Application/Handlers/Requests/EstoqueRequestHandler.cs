using EstoqueApp.Application.Models.Commands;
using EstoqueApp.Application.Models.Queries;
using EstoqueApp.Application.Notifications;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Application.Handlers.Requests
{
    public class EstoqueRequestHandler :
        IRequestHandler<EstoqueCreateCommand, EstoqueQuery>,
        IRequestHandler<EstoqueUpdateCommand, EstoqueQuery>,
        IRequestHandler<EstoqueDeleteCommand, EstoqueQuery>
    {
        private readonly IMediator _mediator;

        public EstoqueRequestHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<EstoqueQuery> Handle(EstoqueCreateCommand request, CancellationToken cancellationToken)
        {
            //TODO Realizar o cadastro do estoque no domínio
            var estoqueQuery = new EstoqueQuery();
            await _mediator.Publish(
                new EstoqueNotification
                {
                    Action = ActionNotification.Create,
                    Estoque = estoqueQuery
                }
            );
            await Console.Out.WriteLineAsync("Estoque Cadastrado");

            return estoqueQuery;
        }

        public async Task<EstoqueQuery> Handle(EstoqueUpdateCommand request, CancellationToken cancellationToken)
        {
            //TODO Realizar o atualização do estoque no domínio
            var estoqueQuery = new EstoqueQuery();
            await _mediator.Publish(
                new EstoqueNotification
                {
                    Action = ActionNotification.Update,
                    Estoque = estoqueQuery
                }
            );
            return estoqueQuery;
        }

        public async Task<EstoqueQuery> Handle(EstoqueDeleteCommand request, CancellationToken cancellationToken)
        {
            //TODO Realizar o delete do estoque no domínio
            var estoqueQuery = new EstoqueQuery();
            await _mediator.Publish(
                new EstoqueNotification
                {
                    Action = ActionNotification.Delete,
                    Estoque = estoqueQuery
                }
            );
            return estoqueQuery;
        }
    }
}
