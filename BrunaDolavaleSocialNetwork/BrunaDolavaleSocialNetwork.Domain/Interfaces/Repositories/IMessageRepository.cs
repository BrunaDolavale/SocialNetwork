using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrunaDolavaleSocialNetwork.Domain.Interfaces
{
    public interface IMessageRepository
    {
        //Enviar Mensagem
        //Ler Mensagem
        //Deletar Mensagem

        void SendMessage();

        void ReadMessage();

        void DeleteMessage();
            


    }
}
