using System.IO;
using System.Reflection;

namespace TestProject1.Helpers
{
    public class TestHelper
    {
        #region Comentarios

        /*
        
        Dentro da Helpers irão ficar alguns metodos estaticos para funcionamento do teste.

        O metodo PastaChrome -> Contem um lambda com a informação de onde está o drive do navegador.

        */

        #endregion
        public static string PastaChromeDriver => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

    }
}
