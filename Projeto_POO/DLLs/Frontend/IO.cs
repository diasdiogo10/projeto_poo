/*
*	<copyright file="Frontend" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>06/12/2023 22:34:16</date>
*	<description></description>
*/


using System;
using ObjetosNegocio;
using Excecoes;
using Verificacoes;
using RegrasNegocio;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

namespace Frontend
{
    /// <summary>
    /// Purpose: 
    /// Created by: Diogo
    /// Created on: 06/12/2023 22:34:16
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class IO
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors
        #endregion

        #region Properties
        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        #region Armazem

        /// <summary>
        /// Imprime todos os produtos do armazem
        /// </summary>
        public static void MostrarProdutosArmazem()
        {
            try
            {
                if (RegrasArmazem.Produtos(out List<Produto> l))
                {
                    foreach (Produto p in l)
                    {
                        if (RegrasArmazem.QuantidadeProduto(p.RefProd, out int quantidade)) Console.WriteLine("Quantidade: " + quantidade.ToString() + " | " + p.ToString());
                        else Console.WriteLine("Ocorreu um erro no programa ao obter a quantidade do produto no armazem\n");
                    }
                }
                else Console.WriteLine("Ocorreu um erro no programa ao obter os produtos do armazem");
            }
            catch (ArmazemExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime todos os produtos de uma marca
        /// </summary>
        /// <param name="marca">marca</param>
        public static void MostrarProdutosMarcaArmazem(string marca)
        {
            try
            {
                if (RegrasArmazem.ProdutosMarca(marca, out List<Produto> l))
                {
                    foreach (Produto p in l)
                    {
                        if (RegrasArmazem.QuantidadeProduto(p.RefProd, out int quantidade)) Console.WriteLine("Quantidade: " + quantidade.ToString() + " | " + p.ToString());
                        else Console.WriteLine("Ocorreu um erro no programa ao obter a quantidade do produto no armazem\n");
                    }
                }
                else Console.WriteLine("Ocorreu um erro no programa ao obter os produtos do armazem");
            }
            catch (ArmazemExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime todos os produtos de uma categoria
        /// </summary>
        /// <param name="categoria">categoria</param>
        public static void MostrarProdutosCategoriaArmazem(string categoria)
        {
            try
            {
                if (RegrasArmazem.ProdutosCategoria(categoria, out List<Produto> l))
                {
                    foreach (Produto p in l)
                    {
                        if (RegrasArmazem.QuantidadeProduto(p.RefProd, out int quantidade)) Console.WriteLine("Quantidade: " + quantidade.ToString() + " | " + p.ToString());
                        else Console.WriteLine("Ocorreu um erro no programa ao obter a quantidade do produto no armazem\n");
                    }
                }
                else Console.WriteLine("Ocorreu um erro no programa ao obter os produtos do armazem");
            }
            catch (ArmazemExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime todos os produtos de uma marca e de uma categoria
        /// </summary>
        /// <param name="marca">marca</param>
        /// <param name="categoria">categoria</param>
        public static void MostrarProdutosMarcaCategoriaArmazem(string marca, string categoria)
        {
            try
            {
                if (RegrasArmazem.ProdutosMarcaCategoria(marca, categoria, out List<Produto> l))
                {
                    foreach (Produto p in l)
                    {
                        if (RegrasArmazem.QuantidadeProduto(p.RefProd, out int quantidade)) Console.WriteLine("Quantidade: " + quantidade.ToString() + " | " + p.ToString());
                        else Console.WriteLine("Ocorreu um erro no programa ao obter a quantidade do produto no armazem\n");
                    }
                }
                else Console.WriteLine("Ocorreu um erro no programa ao obter os produtos do armazem");
            }
            catch (ArmazemExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime o resultado da verificação da existência de um produto
        /// </summary>
        /// <param name="refProd">referencia de produto</param>
        public static void ExisteProdutoArmazem(int refProd)
        {
            try
            {
                if (RegrasArmazem.ExisteProduto(refProd)) Console.WriteLine("O produto existe.\n");
                else Console.WriteLine("O produto não existe.\n");
            }
            catch (ArmazemExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime o resultado da inserção de um produto
        /// </summary>
        /// <param name="p">produto</param>
        public static void InserirProdutoArmazem(Produto p)
        {
            try
            {
                if (RegrasArmazem.InserirProduto(p)) Console.WriteLine("O produto foi adicionado com sucesso.\n");
                else Console.WriteLine("O produto não foi adicionado com sucesso.\n");
            }
            catch (ArmazemExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime o resultado da remoção de um produto
        /// </summary>
        /// <param name="refProd">referência de produto</param>
        public static void RemoverProdutoArmazem(int refProd)
        {
            try
            {
                if (RegrasArmazem.RemoverProduto(refProd)) Console.WriteLine("O produto foi removido com sucesso.\n");
                else Console.WriteLine("O produto não foi removido com sucesso.\n");
            }
            catch (ArmazemExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime o resultado do guardamento dos dados num ficheiro
        /// </summary>
        /// <param name="nomeFicheiro">nome de ficheiro</param>
        public static void SalvarDadosArmazem(string nomeFicheiro)
        {
            try
            {
                if (RegrasArmazem.SalvarDados(nomeFicheiro)) Console.WriteLine("Os dados do armazem foram guardados com sucesso.\n");
                else Console.WriteLine("Os dados do armazem não foram guardados com sucesso.\n");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime o resultado do carregamento dos dados de um ficheiro
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        public static void CarregarDadosArmazem(string nomeFicheiro)
        {
            try
            {
                if (RegrasArmazem.CarregarDados(nomeFicheiro)) Console.WriteLine("Os dados do armazem foram carregados com sucesso.\n");
                else Console.WriteLine("Os dados do armazem não foram carregados com sucesso.\n");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        #endregion

        #region Utilizadores

        /// <summary>
        /// Imprime a quantidade de utilizadores do sistema
        /// </summary>
        public static void QuantidadeUtilizadoresSistema()
        {
            try
            {
                if (RegrasUtilizadores.QuantidadeUtilizadores(out int contador)) Console.WriteLine("O sistema tem {0} utilizadores.\n", contador);
                else Console.WriteLine("Ocorreu um erro no programa ao obter a quantidade de utilizadores no sistema\n");
            }
            catch (UtilizadoresExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime todos os utilizadores do sistema
        /// </summary>
        public static void MostrarUtilizadoresSistema()
        {
            try
            {
                if (RegrasUtilizadores.ListaUtilizadores(out List<Utilizador> l))
                {
                    foreach (Utilizador u in l)
                    {
                        Console.WriteLine(u.ToString());
                    }
                }
                else Console.WriteLine("Ocorreu um erro no programa ao obter os utilizadores do sistema\n");
            }
            catch (UtilizadoresExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime o resultado da verificação da existência de um email no sistema
        /// </summary>
        /// <param name="email">email</param>
        public static void ExisteEmailSistema(string email)
        {
            try
            {
                if (RegrasUtilizadores.ExisteEmail(email)) Console.WriteLine("O email existe.\n");
                else Console.WriteLine("O email não existe.\n");
            }
            catch (UtilizadoresExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        /// <summary>
        /// Imprime o resultado da verificação da existência de uma conta no sistema
        /// </summary>
        /// <param name="email">email</param>
        /// <param name="password">password</param>
        public static void ExisteContaSistema(string email, string password)
        {
            try
            {
                if (RegrasUtilizadores.ExisteConta(email, password)) Console.WriteLine("O utilizador existe.\n");
                else Console.WriteLine("O utilizador não existe.\n");
            }
            catch (UtilizadoresExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime o resultado da inserção de um utilizador
        /// </summary>
        /// <param name="util">utilizador</param>
        public static void InserirUtilizadorSistema(Utilizador util)
        {
            try
            {
                if (RegrasUtilizadores.InserirUtilizador(util)) Console.WriteLine("O utilizador foi adicionado com sucesso.\n");
                else Console.WriteLine("O utilizador não foi adicionado com sucesso.\n");
            }
            catch (UtilizadoresExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime o resultado da remoção de um utilzador
        /// </summary>
        /// <param name="email">email</param>
        public static void RemoverUtilizadorSistema(string email)
        {
            try
            {
                if (RegrasUtilizadores.RemoverUtilizador(email)) Console.WriteLine("O utilizador foi removido com sucesso.\n");
                else Console.WriteLine("O utilizador não foi removido com sucesso.\n");
            }
            catch (UtilizadoresExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime o resultado da alteração de email
        /// </summary>
        /// <param name="antigoEmail">antigo email</param>
        /// <param name="password">password</param>
        /// <param name="novoEmail">novo email</param>
        public static void AlterarEmailSistema(string antigoEmail, string password, string novoEmail)
        {
            try
            {
                if (RegrasUtilizadores.AlterarEmail(antigoEmail, password, novoEmail)) Console.WriteLine("O email foi alterado com sucesso.\n");
                else Console.WriteLine("O email não foi alterado com sucesso.\n");
            }
            catch (UtilizadoresExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime o resultado da alteração de password
        /// </summary>
        /// <param name="email">email</param>
        /// <param name="antigaPassword">antiga password</param>
        /// <param name="novaPassword">nova password</param>
        public static void AlterarPasswordSistema(string email, string antigaPassword, string novaPassword)
        {
            try
            {
                if (RegrasUtilizadores.AlterarPassword(email, antigaPassword, novaPassword)) Console.WriteLine("A password foi alterada com sucesso.\n");
                else Console.WriteLine("A password não foi alterada com sucesso.\n");
            }
            catch (UtilizadoresExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime o resultado do guardamento dos dados num ficheiro
        /// </summary>
        /// <param name="nomeFicheiro">nome de ficheiro</param>
        public static void SalvarDadosUtilizadores(string nomeFicheiro)
        {
            try
            {
                if (RegrasUtilizadores.SalvarDados(nomeFicheiro)) Console.WriteLine("Os dados de utilizadores foram guardados com sucesso.\n");
                else Console.WriteLine("Os dados de utilizadores não foram guardados com sucesso.\n");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime o resultado do carregamento dos dados de um ficheiro
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        public static void CarregarDadosUtilizadores(string nomeFicheiro)
        {
            try
            {
                if (RegrasUtilizadores.CarregarDados(nomeFicheiro)) Console.WriteLine("Os dados de utilizadores foram carregados com sucesso.\n");
                else Console.WriteLine("Os dados de utilizadores não foram carregados com sucesso.\n");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        #endregion

        #region Fornecedores

        /// <summary>
        /// Imprime o resultado da verificação da existência de um produto
        /// </summary>
        /// <param name="nomeProd">referencia de produto</param>
        public static void ExisteProdutoFornecedores(string nomeProd)
        {
            try
            {
                if (RegrasFornecedores.ExisteProdutoFornecedores(nomeProd)) Console.WriteLine("O produto existe.\n");
                else Console.WriteLine("O produto não existe.\n");
            }
            catch (FornecedoresExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime o resultado da verificação da existência de um produto num determinado fornecedor
        /// </summary>
        /// <param name="nomeProd">nome do produto</param>
        /// <param name="nomeForn">nome do fornecedor</param>
        public static void ExisteProdutoFornecedor(string nomeProd, string nomeForn)
        {
            try
            {
                if (RegrasFornecedores.ExisteProdutoFornecedor(nomeProd, nomeForn)) Console.WriteLine("O produto existe.\n");
                else Console.WriteLine("O produto não existe.\n");
            }
            catch (FornecedoresExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime o resultado da inserção de um produto
        /// </summary>
        /// <param name="p">produto</param>
        /// <param name="nomeForn">nome do fornecedor</param>
        public static void InserirProdutoFornecedor(Produto p, string nomeForn)
        {
            try
            {
                if (RegrasFornecedores.InserirProduto(p, nomeForn)) Console.WriteLine("O produto foi adicionado com sucesso.\n");
                else Console.WriteLine("O produto não foi adicionado com sucesso.\n");
            }
            catch (FornecedoresExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime o resultado da remoção de um produto
        /// </summary>
        /// <param name="nomeProd">nome do produto</param>
        /// <param name="nomeForn">nome do fornecedor</param>
        public static void RemoverProdutoFornecedor(string nomeProd, string nomeForn)
        {
            try
            {
                if (RegrasFornecedores.RemoverProduto(nomeProd, nomeForn)) Console.WriteLine("O produto foi removido com sucesso.\n");
                else Console.WriteLine("O produto não foi removido com sucesso.\n");
            }
            catch (FornecedoresExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime a quantidade de fornecedores do sistema
        /// </summary>
        public static void QuantidadeFornecedoresSistema()
        {
            try
            {
                if (RegrasFornecedores.QuantidadeFornecedores(out int contador)) Console.WriteLine("O sistema tem {0} fornecedores.\n", contador);
                else Console.WriteLine("Ocorreu um erro no programa ao obter a quantidade de fornecedores no sistema\n");
            }
            catch (FornecedoresExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime todos os fornecedores do sistema
        /// </summary>
        public static void MostrarFornecedoresSistema()
        {
            try
            {
                if (RegrasFornecedores.ListaFornecedores(out List<Fornecedor> l))
                {
                    foreach (Fornecedor u in l)
                    {
                        Console.WriteLine(u.ToString());
                    }
                }
                else Console.WriteLine("Ocorreu um erro no programa ao obter os fornecedores do sistema\n");
            }
            catch (FornecedoresExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime o resultado da verificação da existência de um fornecedor no sistema
        /// </summary>
        /// <param name="nome">nome</param>
        public static void ExisteFornecedorSistema(string nome)
        {
            try
            {
                if (RegrasFornecedores.ExisteFornecedor(nome)) Console.WriteLine("O fornecedor existe.\n");
                else Console.WriteLine("O fornecedor não existe.\n");
            }
            catch (FornecedoresExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime o resultado da inserção de um fornecedor
        /// </summary>
        /// <param name="forn">fornecedor</param>
        public static void InserirFornecedorSistema(Fornecedor forn)
        {
            try
            {
                if (RegrasFornecedores.InserirFornecedor(forn)) Console.WriteLine("O fornecedor foi adicionado com sucesso.\n");
                else Console.WriteLine("O fornecedor não foi adicionado com sucesso.\n");
            }
            catch (FornecedoresExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime o resultado da remoção de um fornecedor
        /// </summary>
        /// <param name="nome">nomel</param>
        public static void RemoverFornecedorSistema(string nome)
        {
            try
            {
                if (RegrasFornecedores.RemoverFornecedor(nome)) Console.WriteLine("O fornecedor foi removido com sucesso.\n");
                else Console.WriteLine("O fornecedor não foi removido com sucesso.\n");
            }
            catch (FornecedoresExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime o resultado do guardamento dos dados num ficheiro
        /// </summary>
        /// <param name="nomeFicheiro">nome de ficheiro</param>
        public static void SalvarDadosFornecedores(string nomeFicheiro)
        {
            try
            {
                if (RegrasFornecedores.SalvarDados(nomeFicheiro)) Console.WriteLine("Os dados de fornecedores foram guardados com sucesso.\n");
                else Console.WriteLine("Os dados de fornecedores não foram guardados com sucesso.\n");
            }
            catch (FornecedoresExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime o resultado do carregamento dos dados de um ficheiro
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        public static void CarregarDadosFornecedores(string nomeFicheiro)
        {
            try
            {
                if (RegrasFornecedores.CarregarDados(nomeFicheiro)) Console.WriteLine("Os dados de fornecedores foram carregados com sucesso.\n");
                else Console.WriteLine("Os dados de fornecedores não foram carregados com sucesso.\n");
            }
            catch (FornecedoresExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        #endregion

        #region Compras

        /// <summary>
        /// Imprime o resultado da inserção de uma compra
        /// </summary>
        /// <param name="c">compra</param>
        public static void InserirCompra(Compra c)
        {
            try
            {
                if (RegrasCompras.InserirCompra(c)) Console.WriteLine("A compra foi adicionada com sucesso.\n");
                else Console.WriteLine("A compra não foi adicionada com sucesso.\n");
            }
            catch (ComprasExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime todos as compras de uma certa data
        /// </summary>
        /// <param name="dataCompra">data de compra</param>
        public static void MostrarComprasData(DateTime dataCompra)
        {
            try
            {
                if (RegrasCompras.ComprasData(dataCompra, out List<Compra> l))
                {
                    foreach (Compra c in l) c.EmitirFatura();
                }
                else Console.WriteLine("Ocorreu um erro no programa ao obter as compras dessa data");
            }
            catch (ComprasExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime o resultado do guardamento dos dados num ficheiro
        /// </summary>
        /// <param name="nomeFicheiro">nome de ficheiro</param>
        public static void SalvarDadosCompras(string nomeFicheiro)
        {
            try
            {
                if (RegrasCompras.SalvarDados(nomeFicheiro)) Console.WriteLine("Os dados de compras foram guardados com sucesso.\n");
                else Console.WriteLine("Os dados de compras não foram guardados com sucesso.\n");
            }
            catch (ComprasExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime o resultado do carregamento dos dados de um ficheiro
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        public static void CarregarDadosCompras(string nomeFicheiro)
        {
            try
            {
                if (RegrasCompras.CarregarDados(nomeFicheiro)) Console.WriteLine("Os dados de compras foram carregados com sucesso.\n");
                else Console.WriteLine("Os dados de compras não foram carregados com sucesso.\n");
            }
            catch (ComprasExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        #endregion

        #region Vendas


        /// <summary>
        /// Imprime o resultado da inserção de uma venda
        /// </summary>
        /// <param name="v">venda</param>
        public static void InserirVenda(Venda v)
        {
            try
            {
                if (RegrasVendas.InserirVenda(v)) Console.WriteLine("A venda foi adicionada com sucesso.\n");
                else Console.WriteLine("A venda não foi adicionada com sucesso.\n");
            }
            catch (VendasExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime todos as vendas de uma certa data
        /// </summary>
        /// <param name="dataVenda">data de venda</param>
        public static void MostrarVendasData(DateTime dataVenda)
        {
            try
            {
                if (RegrasVendas.VendasData(dataVenda, out List<Venda> l))
                {
                    foreach (Venda v in l) v.EmitirFatura();
                }
                else Console.WriteLine("Ocorreu um erro no programa ao obter as vendas dessa data");
            }
            catch (VendasExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime o resultado do guardamento dos dados num ficheiro
        /// </summary>
        /// <param name="nomeFicheiro">nome de ficheiro</param>
        public static void SalvarDadosVendas(string nomeFicheiro)
        {
            try
            {
                if (RegrasVendas.SalvarDados(nomeFicheiro)) Console.WriteLine("Os dados de vendas foram guardados com sucesso.\n");
                else Console.WriteLine("Os dados de vendas não foram guardados com sucesso.\n");
            }
            catch (VendasExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Imprime o resultado do carregamento dos dados de um ficheiro
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        public static void CarregarDadosVendas(string nomeFicheiro)
        {
            try
            {
                if (RegrasVendas.CarregarDados(nomeFicheiro)) Console.WriteLine("Os dados de vendas foram carregados com sucesso.\n");
                else Console.WriteLine("Os dados de vendas não foram carregados com sucesso.\n");
            }
            catch (VendasExcecoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        #endregion

        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}