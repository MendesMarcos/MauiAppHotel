using MauiAppHotel.Models;

namespace MauiAppHotel
{
   public partial class App : Application
   {
      public List<Quarto> quartos = new List<Quarto>
      { 
         new Quarto()
         {
            Descricao = "Suíte super luxo",
            ValorDiariaAdulto = 110.0,
            ValorDiariaCrianca = 55.0,
         },
         new Quarto()
         {
            Descricao = "Suíte luxo",
            ValorDiariaAdulto = 80,
            ValorDiariaCrianca = 40.0,
         },
         new Quarto()
         {
            Descricao = "Suíte single",
            ValorDiariaAdulto = 50,
            ValorDiariaCrianca = 25,
         },
         new Quarto()
         {
            Descricao = "Suíte crise",
            ValorDiariaAdulto = 35,
            ValorDiariaCrianca = 15.5,
         }
      };

      public App()
      {
         InitializeComponent();

         MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
      }

      protected override Window CreateWindow(IActivationState? activationState)
      {
         try
         {
            //var window = new Window(new AppShell());
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
         }
         catch (Exception ex)
         {
            throw new Exception(ex.Message);
         }
      }
   }
}