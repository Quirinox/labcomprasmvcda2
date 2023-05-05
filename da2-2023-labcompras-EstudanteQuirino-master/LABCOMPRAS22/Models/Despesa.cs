using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
namespace LABCOMPRAS22.Models
{
    public class Despesa
    {
        //[Required(ErrorMessage="Por favor introduza um nome")]
        public string NomeDespesa
        {get; set; }
        public int Quantidade
        { get; set;}
        public double Valor
        {   
            get;set;
        }
        public string Categoria
        {
            get; set;
        }
        public bool Pago
        {
            get;set;
        }
    }
}
