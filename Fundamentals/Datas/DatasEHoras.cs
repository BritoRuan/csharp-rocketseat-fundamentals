
using System.Globalization;

namespace HelloWorld.Datas;

class DatasEHoras
{
    DateOnly dia = new DateOnly(2025, 04, 1);

    /* 
     * Pesquisar sobre a classe DateTime na documentação
     * string diaEmTexto = dia.ToShortDateString(); // 01/04/2025
     *
     * string diaEmTexto = dia.ToLongDateString(); // quinta-feira, 1 de abril de 2025  
     *  
     * string diaEmTexto = dia.ToString(new CultureInfo("pt-BR"); // 01/04/2025
     * 
     * string diaEmTexto = dia.ToString("dd MMMM yyyy", new CultureInfo("pt-BR"); // 01 abril 2025
    */

    DateTime dia1 = new DateTime(2025, 04, 1, 21, 37, 0);
    
    DateTime hoje = DateTime.Now; // Data e hora atual
    DateTime dataDeHoje = DateTime.Today; // Data atual

    DateTime horaEmUtc = DateTime.UtcNow; // Hora atual em UTC

    // DateTime novaData = hoje.AddDays(1); // Adiciona um dia
}
