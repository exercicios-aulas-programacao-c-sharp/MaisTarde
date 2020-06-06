using System;

namespace MaisTarde
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataHoraAtual = DateTime.Now;
            TimeSpan seisHorasEMeia = new TimeSpan(6,30,00);

            DateTime dataHoraApos = dataHoraAtual.AddHours(6).AddMinutes(30).Date;
            DateTime dataHoraAposComIntervalo = dataHoraAtual + seisHorasEMeia;

            Console.WriteLine($"Agora {dataHoraAtual.ToShortTimeString()}, mais tarde {dataHoraApos.ToShortTimeString()}.");          
            Console.WriteLine($"Agora {dataHoraAtual.ToShortTimeString()}, mais tarde, com intervalo {dataHoraAposComIntervalo.ToShortTimeString()}.");
        }
    }
}
