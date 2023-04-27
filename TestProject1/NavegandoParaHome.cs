using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TestProject1.Fixtures;
using TestProject1.Helpers;
using Xunit;

namespace TestProject1
{
    public class NavegandoParaHome : IClassFixture<TestFixture>
    {
        #region Comentarios

        /*

       <- SETUP ->
        O Construtor, irá instanciar o IWebDriver quando a pagina for construida, eliminando assim duplicações de codigo de instanciamento 
        Metodo privado ChromeDriver

        Instancio o IWebDriver, criando um componente usando o ChromeDrive
        passando como parametro o Path para capturar o caminho do drive na pasta do projeto.

        <- SETUP ->

        <- TEAR DOWN ->

        Liberar a memoria após os testes
        Iremos usar a Interface IDispable

        <- TEAR DOWN ->

        Com o componente instanciado, vou no metodo NAVIGATE().GOTOURL() passando como parametro o site em que desejo realizar o teste.

        Apos uso o Assert.CONTAINS() passando dois paramentros, o primeiro o titulo do site, o segundo com o componente informo para capturar o titulo.

        Por fim realizo um quit para fechar o navegador.

        */

        #endregion


        #region Setup

        private readonly IWebDriver drive;
        public NavegandoParaHome(TestFixture _fixture)
        {
            drive = _fixture.drive;
        }

        #endregion

        #region Teste

        [Fact]
        public void ChromeAbertoMostrandoNoticiasGlobo()
        {

            var url = "https://www.globo.com/";

            drive.Navigate().GoToUrl(url);

            Assert.Contains("globo.com - Absolutamente tudo sobre notícias, esportes e entretenimento", drive.Title);

        }

        #endregion

    }
}
