using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrunaDolavaleSocialNetwork.Domain.Interfaces
{
    public interface IMatchRepository
    {
        //Pessoa Um dá like
        //Pessoa Dois dá like
        //Os dois dão like, dá um match
        //Os dois se rejeitam, cancela possível combinação
        //Desfazer Match

        void FirstConfirmed();

        void SecondConfirmed();

        void SecondRejects();

        void Match();

        void Unmatched();


    }
}
