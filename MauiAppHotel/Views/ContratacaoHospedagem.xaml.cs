namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
   App PropriedadesApp;

   public ContratacaoHospedagem()
   {
      InitializeComponent();

      PropriedadesApp = (App)Application.Current;

      pck_quarto.ItemsSource = PropriedadesApp.quartos;

      dtpck_checkin.MinimumDate = DateTime.Now;
      dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(1);

      dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
      dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddDays(10);
   }

   private void Button_Clicked(object sender, EventArgs e)
   {
      try
      {
         Navigation.PushAsync(new HospedagemContratada());
      }
      catch (Exception ex)
      {
         DisplayAlert("Erro", ex.Message, "OK");

      }
   }

   private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
   {
      try
      {
         DatePicker elemento = sender as DatePicker;

         DateTime data_selecionada_checkin = elemento.Date;

         dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
         dtpck_checkout.MaximumDate = data_selecionada_checkin.AddDays(10);
      }
      catch (Exception ex)
      {
         DisplayAlert("Erro", ex.Message, "OK");

      }
   }
}