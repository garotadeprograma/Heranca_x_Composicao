using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Professor.Model
{
    public class Composition : IRepositorioProfessor
    {
        // O objetivo desta declaracao é ter acesso aos métodos de _professor
        private readonly Repositorio<ProfessorInfo> _professor;
        
        public Composition(Repositorio<ProfessorInfo> professor)
        {
            _professor = professor;
        }

        // Implementa a interface direto
        public void Adicionar(ProfessorInfo professor)
        {
             Console.WriteLine("Repositorio Especializado");
        }
    }

    public class Heranca : Repositorio<ProfessorInfo>, IRepositorioProfessor
    {

    }

    public class TesteImplementacao
    {
        public void TesteComposicao()
        {
            var rep = new Composition(new Repositorio<ProfessorInfo>());
            rep.Adicionar(new ProfessorInfo());    
        }

        public void TesteHeranca()
        {
            var rep = new Heranca();
            rep.Adicionar(new ProfessorInfo());
        }


    }
}