using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrunaDolavaleSocialNetwork.Domain.Interfaces
{
    public interface IConversationRepository
    {
        //Deve exibir todas minhas mensagens
        //Deve ser capaz de deletar a conversa inteira

        void ShowConversation();

        void DeleteConversation();


    }
}
