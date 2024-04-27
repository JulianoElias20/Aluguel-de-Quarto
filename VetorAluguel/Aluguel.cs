using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorAluguel
{
    internal class Aluguel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public Aluguel()
        {

        }

        public Aluguel(string nome, string email, int quarto)
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

        public override string ToString()
        {
            

            StringBuilder sb = new StringBuilder();

           
            sb.Append(Quarto + ", " + Nome + ", " + Email);
            return sb.ToString();
        }
    }
}
