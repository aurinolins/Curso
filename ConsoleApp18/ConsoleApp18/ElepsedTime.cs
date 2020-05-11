using System.Globalization;
namespace System
  
{
    public static class Tempo
    {
        public static string CalculaTempo(this DateTime dtinfo)
        {
            TimeSpan Duracao = DateTime.Now.Subtract(dtinfo);
            if (Duracao.TotalHours <= 24)
            {

                return "Duracao : " + Duracao.TotalHours + " Horas";
            }
            else
            {

                return "Duracao : " + Duracao.TotalDays + " Dias";
            }
        }
    }
}
