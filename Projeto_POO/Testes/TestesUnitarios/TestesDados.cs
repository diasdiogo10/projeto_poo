using Dados;
using ObjetosNegocio;
using Excecoes;
using Verificacoes;
using System.Text.Json.Serialization;

namespace TestesUnitarios
{
    [TestClass]
    public class TestesDados
    {
        #region Comum

        /// <summary>
        /// Limpa todos os dados antes de cada teste
        /// </summary>
        [TestInitialize]
        public void InicializarTeste()
        {
            Armazem.ReiniciarStatic();
            Fornecedores.ReiniciarStatic();
        }

        #endregion

        #region Fornecedores
        /// <summary>
        /// Testa adicionar o produto nos Fornecedores
        /// </summary>
        [TestMethod]
        public void TesteAcrescentarProdFornecedores()
        {
            // Arrange
            Categoria c = new Categoria("Calcado", "Para por nos pés");

            Marca m = new Marca("Nike", "nike@hotmail.com");

            Produto prod1 = new Produto("Chuteiras", 12.5, c, m);

            Fornecedor forn = new Fornecedor("AA", "91919191");

            Fornecedores.InserirFornecedorSistema(forn);

            // Act
            bool result = Fornecedores.InserirProdutoFornecedor(prod1, forn.Nome);

            // Assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Testa adicionar produto nos Fornecedores que já existe
        /// </summary>
        [TestMethod]
        public void TesteAcrescentarProdIgualFornecedores()
        {
            // Arrange
            Categoria c = new Categoria("Calcado", "Para por nos pés");

            Marca m = new Marca("Nike", "nike@hotmail.com");

            Produto prod1 = new Produto("Chuteiras", 12.5, c, m);

            Fornecedor forn = new Fornecedor("AA", "91919191");

            Fornecedores.InserirFornecedorSistema(forn);

            Fornecedores.InserirProdutoFornecedor(prod1, forn.Nome);

            // Act
            bool result = Fornecedores.InserirProdutoFornecedor(prod1, forn.Nome);

            // Assert
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Testa adicionar produto nos Fornecedores diferente
        /// </summary>
        [TestMethod]
        public void TesteAcrescentarProdDiferenteFornecedores()
        {
            // Arrange
            Categoria c = new Categoria("Calcado", "Para por nos pés");

            Marca m = new Marca("Nike", "nike@hotmail.com");

            Produto prod1 = new Produto("Chuteiras", 12.5, c, m);

            Produto prod2 = new Produto("Sapatilhas", 12.5, c, m);

            Fornecedor forn = new Fornecedor("AA", "91919191");

            Fornecedores.InserirFornecedorSistema(forn);

            Fornecedores.InserirProdutoFornecedor(prod1, forn.Nome);

            // Act
            bool result = Fornecedores.InserirProdutoFornecedor(prod2, forn.Nome);

            // Assert
            Assert.IsTrue(result);
        }
        #endregion

        #region Armazem

        /// <summary>
        /// Testa se o produto existe se não tiver lá nenhum produto
        /// </summary>
        [TestMethod]
        public void TesteExistenciaArmazemSemAcrescentar()
        {
            // Arrange

            // Act
            bool result = Armazem.ExisteProdutoArmazem(1);

            // Assert
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Testa adicionar o produto no Armazem
        /// </summary>
        [TestMethod]
        public void TesteAcrescentarProdArmazem()
        {
            // Arrange
            Categoria c = new Categoria("Calcado", "Para por nos pés");

            Marca m = new Marca("Nike", "nike@hotmail.com");

            Produto prod1 = new Produto("Chuteiras", 12.5, c, m);

            Fornecedor forn = new Fornecedor("AA", "91919191");

            Fornecedores.InserirFornecedorSistema(forn);

            Fornecedores.InserirProdutoFornecedor(prod1, forn.Nome);

            // Act
            bool result = Armazem.InserirProdutoArmazem(prod1);

            // Assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Testa se ao adicionar o produto no Armazem, o produto vem com o id igual ao do fornecedor
        /// </summary>
        [TestMethod]
        public void TesteIDAcrescentarProdArmazem()
        {
            // Arrange
            Categoria c = new Categoria("Calcado", "Para por nos pés");

            Marca m = new Marca("Nike", "nike@hotmail.com");

            Produto prod1 = new Produto("Chuteiras", 12.5, c, m);

            Produto prod2 = new Produto("Sapatilhas", 12.5, c, m);

            Fornecedor forn = new Fornecedor("AA", "91919191");

            Fornecedores.InserirFornecedorSistema(forn);

            Fornecedores.InserirProdutoFornecedor(prod1, forn.Nome);

            Fornecedores.InserirProdutoFornecedor(prod2, forn.Nome);

            Armazem.InserirProdutoArmazem(prod1);

            Armazem.InserirProdutoArmazem(prod2);

            // Act
            bool result = Armazem.ExisteProdutoArmazem(2);

            // Assert
            Assert.IsTrue(result);
        }
        #endregion
    }
}