using System.Xml.XPath;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Reserva(Suite suite)
        {
            this.Suite = suite;

        }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {

            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                Exception();

            }
        }

        private void Exception()
        {
            Console.WriteLine(" A quantidade de hospedes não pode exceder a capacidade da suíte.");
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            var quantidadeHospedes = Hospedes.Count;
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            decimal result = this.DiasReservados * Suite.ValorDiaria;

            if (this.DiasReservados >= 10)
            {
                decimal valor = result - (result * 10 / 100);
                return valor;
            }
            else
            {
                return result;
            }

        }
    }
}
