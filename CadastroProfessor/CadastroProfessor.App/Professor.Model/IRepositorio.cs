using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Professor.Model
{
    // Genérica
    public interface IRepositorio<T>
    {
        void Adicionar(T ojb);

        void Excluir(T obj);
    }

    // Especializada
    public interface IRepositorioProfessor
    {
        void Adicionar(Professor obj);
    }
}