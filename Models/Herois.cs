using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafioLogica.Models
{
    public class Heroi
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Tipo { get; set; } 

        public Heroi(string nome, int idade, string tipo)
        {
            Nome = nome;
            Idade = idade;
            Tipo = tipo;
        }
        public void Atacar()
        {
            string ataque = "";
            switch (Tipo.ToLower())
            {
                case "mago":
                    ataque = "usou magia";
                    break;
                case "guerreiro":
                    ataque = "usou espada";
                    break;
                case "monge":
                    ataque = "usou artes marciais";
                    break;
                case "ninja":
                    ataque = "usou shuriken";
                    break;
                default:
                    ataque = "usou um ataque básico";
                    break;
            }

            // Exibindo a mensagem de ataque
            Console.WriteLine($"O {Tipo} atacou usando {ataque}");
        }
    }
}