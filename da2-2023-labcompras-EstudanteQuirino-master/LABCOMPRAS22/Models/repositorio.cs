namespace LABCOMPRAS22.Models
{
    
    public class repositorio
    {
        private static List<Despesa> despesas = new List<Despesa>();
        public static List<Despesa> Despesas
        {
            get
            { return despesas; }

        }
        public static void AdicionarDespesa(Despesa novaDespesa)
        {
            despesas.Add(novaDespesa);
        }

        private static List<Conta> Contas = new List<Conta>();

        public static List<Conta> contas
        {
            get { return contas; }
            
        }
        public static void AdicionarConta(Conta novaConta)
        {
            Contas.Add(novaConta);
        }

    }
}
