using DesafioProjetoHospedagem.Exceptions;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Verificando capacidade da suíte");
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
                Console.WriteLine("Hospodes cadastrados com sucesso!");
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
                throw new CapacityViolationException("Violção de capacidade detectada. Não há espaçao suficente para a quantidade de hospede");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Calculando valor da diária..");
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados>=10)
            {
                Console.WriteLine("Parabéns, pelo tempo que passou em nossa suíte você ganhará um desconto de 10%");
                double desconto = .10; //O que seria melhor definir como 90% ou 10%
                valor -= valor *(decimal) desconto;
            }

            return valor;
        }
    }
}