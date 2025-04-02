
using System.Text;

namespace HelloWorld.Textos;

class OperacoesComTextos
{
    // Lei de Murphy
    string texto1 = "Qualquer coisa que possa ocorrer mal,";
    string texto2 = "acontecerá mal, no pior momento possível.";

    /* 
    
    "Qualquer coisa que possa ocorrer mal, acontecerá mal, no pior momento possível."
    string paragrafo = texto1 + texto2; 

    "Qualquer coisa que possa ocorrer mal, acontecerá mal, no pior momento possível."
    string paragrafo2 = $"{texto1} {texto2}";

    */

    StringBuilder stringBuilder = new StringBuilder();

    //stringBuilder.Append(texto1);
    //stringBuilder.Append(texto2);

    // Qualquer coisa que possa ocorrer mal, acontecerá mal, no pior momento possível.
    
    // string resultadoStringBuilder = stringBuilder.ToString();


    string textoCompleto = "O usuário {0} gosta muito de {1}";

    // O usuário Ruan gosta muito de programar

    // string resultado = string.format(textoCompleto, "Ruan", "programar");

    string caminho = @"C:\teste";
}
