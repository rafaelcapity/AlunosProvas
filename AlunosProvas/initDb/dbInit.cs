using AlunosProvas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlunosProvas.InitDb
{
    public class dbInit : IEntityTypeConfiguration<Aluno>
    {

        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.HasData(
                new Aluno { Id = 1, nomeMae = "Cida", cidade = "RP", cpf = "656565656", idade = 20, nome = "Paulo" },
                new Aluno { Id = 2, nomeMae = "Vera", cidade = "SJC", cpf = "65659689898", idade = 21, nome = "Andre" },
                new Aluno { Id = 3, nomeMae = "Josefa", cidade = "SP", cpf = "9898989898989", idade = 89, nome = "Edilton" },
                new Aluno { Id = 4, nomeMae = "Claudia", cidade = "SJC", cpf = "8787878787", idade = 18, nome = "Carlos" },
                new Aluno { Id = 5, nomeMae = "Andrea", cidade = "Franca", cpf = "9898798", idade = 71, nome = "bibi" },
                new Aluno { Id = 6, nomeMae = "Leonor", cidade = "SJC", cpf = "56497898", idade = 52, nome = "Daeniel" },
                new Aluno { Id = 7, nomeMae = "Maria", cidade = "SP", cpf = "56498798", idade = 45, nome = "sdsd" },
                new Aluno { Id = 8, nomeMae = "Paty", cidade = "SP", cpf = "5646896898", idade = 78, nome = "23232" },
                new Aluno { Id = 9, nomeMae = "Ze Maria", cidade = "SJC", cpf = "989821632", idade = 51, nome = "fdfd" },
                new Aluno { Id = 10, nomeMae = "Tia", cidade = "Franca", cpf = "685987989", idade = 87, nome = "dfdfd" }
                
                );
        }

    }
}
