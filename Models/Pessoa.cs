using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpSolutions.Models
{
    public class Pessoa
    {
        private string _nome; // campo
        private int _idade;
        public string Nome //propriedade pois tem get ou set ou os dois
        {
            get => _nome.ToUpper();


            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }
        
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
                            
        public int Idade
        {
            get => _idade;

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Idade não pode ser menor que 0.");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }

}