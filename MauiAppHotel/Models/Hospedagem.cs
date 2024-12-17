
namespace MauiAppHotel.Models
{
   public class Hospedagem
   {
      public Quarto quarto { get; set; }

      public int qtdAdultos { get; set; }

      public int qtdCriancas { get; set; }

      public DateTime dataCheckin { get; set; }

      public DateTime dataCheckout { get; set; }

      public int Estadia
      {
         get => dataCheckout.Subtract(dataCheckin).Days;
      }

      public double ValorTotal
      {
         get => ((qtdAdultos * quarto.ValorDiariaAdulto) + (qtdCriancas * quarto.ValorDiariaCrianca)) * Estadia; 
      }
   }
}
