using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio_3.Interfaces;

namespace Exercicio_3.Models.ClassesAnimais
{
    public class Pinguim : Ave, IAquatico, IOviparo
    {
        public Pinguim(DateTime dataNascimento, char sexo, string corPena)
        {
            this.Nome = "Pinguim";
            this.DataDeNascimento = dataNascimento;
            this.Sexo = sexo;
            TimeSpan IdadeEmData = DateTime.Now - DataDeNascimento;
            this.Idade = (IdadeEmData.Days / 365);
            this.Carnívoro = false;
            this.Peconhento = false;
            this.Rapina = false;
            this.CorPena = corPena;
        }

        public bool ViveEmTerra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Mergulho { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AguaDoce { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool BotouOvo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Botar()
        {
            Console.WriteLine($"O {this.Nome} está botando um ovo...");
            Thread.Sleep(3000);
            Console.WriteLine($"O {this.Nome} botou um ovo!");
            this.BotouOvo = true;
        }

        public void Chocar()
        {
            Console.WriteLine($"O {this.Nome} está chocando o ovo...");
            Thread.Sleep(3000);
            Console.WriteLine($"Ovo chocado!");
            this.BotouOvo = false;
        }

        public void Nadar()
        {
            Console.WriteLine($"{this.Nome} está nadando...");
            Thread.Sleep(3000);
        }
    }
}