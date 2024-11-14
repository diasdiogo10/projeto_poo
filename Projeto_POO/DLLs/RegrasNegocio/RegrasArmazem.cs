/*
*	<copyright file="RegrasNegocio" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>06/12/2023 23:16:25</date>
*	<description></description>
*/


using System;
using Excecoes;
using Dados;
using ObjetosNegocio;
using System.Collections.Generic;
using System.IO;

namespace RegrasNegocio
{
    /// <summary>
    /// Purpose: 
    /// Created by: Diogo
    /// Created on: 06/12/2023 23:16:25
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class RegrasArmazem
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

        /// <summary>
        /// Verifica se um produto existe
        /// </summary>
        /// <param name="refProd">referência de produto</param>
        /// <returns>true ou false, dependendo se existe ou não</returns>
        /// <exception cref="ArmazemExcecoes">possivel exceção lançada</exception>
        public static bool ExisteProduto(int refProd)
        {
            try
            {
                return Armazem.ExisteProdutoArmazem(refProd);
            }
            catch (ArmazemExcecoes e)
            {
                throw new ArmazemExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new ArmazemExcecoes("Passou nas regras", e);
            }
        }

        /// <summary>
        /// Procura a quantidade de um produto
        /// </summary>
        /// <param name="refProd">referencia de produto</param>
        /// <param name="contador">quantidade</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="ArmazemExcecoes">possivel exceção lançada</exception>
        public static bool QuantidadeProduto(int refProd, out int contador)
        {
            try
            {
                return Armazem.QuantidadeProdutoArmazem(refProd, out contador);
            }
            catch (ArmazemExcecoes e)
            {
                throw new ArmazemExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new ArmazemExcecoes("Passou nas regras", e);
            }
        }

        /// <summary>
        /// Procura todos os produtos de uma marca
        /// </summary>
        /// <param name="marca">marca</param>
        /// <param name="p">produtos</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="ArmazemExcecoes">possivel exceção lançada</exception>
        public static bool ProdutosMarca(string marca, out List<Produto> p)
        {
            try
            {
                return Armazem.ProdutosMarcaArmazem(marca, out p);
            }
            catch (ArmazemExcecoes e)
            {
                throw new ArmazemExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new ArmazemExcecoes("Passou nas regras", e);
            }
        }

        /// <summary>
        /// Procura todos os produtos de uma categoria
        /// </summary>
        /// <param name="categoria">categoria</param>
        /// <param name="p">produtos</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="ArmazemExcecoes">possivel exceção lançada</exception>
        public static bool ProdutosCategoria(string categoria, out List<Produto> p)
        {
            try
            {
                return Armazem.ProdutosCategoriaArmazem(categoria, out p);
            }
            catch (ArmazemExcecoes e)
            {
                throw new ArmazemExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new ArmazemExcecoes("Passou nas regras", e);
            }
        }

        /// <summary>
        /// Procura todos os produtos de uma marca e categoria
        /// </summary>
        /// <param name="marca">marca</param>
        /// <param name="categoria">categoria</param>
        /// <param name="p">produtos</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="ArmazemExcecoes">possivel exceção lançada</exception>
        public static bool ProdutosMarcaCategoria(string marca, string categoria, out List<Produto> p)
        {
            try
            {
                return Armazem.ProdutosMarcaCategoriaArmazem(marca, categoria, out p);
            }
            catch (ArmazemExcecoes e)
            {
                throw new ArmazemExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new ArmazemExcecoes("Passou nas regras", e);
            }
        }

        /// <summary>
        /// Obtém a lista de produtos do armazém
        /// </summary>
        /// <param name="lista"></param>
        /// <returns>true</returns>
        public static bool Produtos(out List<Produto> lista)
        {
                lista = Armazem.Produtos;
                return true;
        }

        /// <summary>
        /// Insere um produto no armazem
        /// </summary>
        /// <param name="produto">produto</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="ArmazemExcecoes">possivel exceção lançada</exception>
        public static bool InserirProduto(Produto produto)
        {
            try
            {
                return Armazem.InserirProdutoArmazem(produto);
            }
            catch (ArmazemExcecoes e)
            {
                throw new ArmazemExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new ArmazemExcecoes("Passou nas regras", e);
            }
        }

        /// <summary>
        /// Remove um produto do armazem
        /// </summary>
        /// <param name="refProd">referencia de produto</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="ArmazemExcecoes">possivel exceção lançada</exception>
        public static bool RemoverProduto(int refProd)
        {
            try
            {
                return Armazem.RemoverProdutoArmazem(refProd);
            }
            catch (ArmazemExcecoes e)
            {
                throw new ArmazemExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new ArmazemExcecoes("Passou nas regras", e);
            }
        }


        /// <summary>
        /// Salva os dados num ficheiro
        /// </summary>
        /// <param name="nomeFicheiro">nome de ficheiro</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="ArmazemExcecoes">possivel exceção lançada</exception>
        public static bool SalvarDados(string nomeFicheiro)
        {
            try
            {
                return Armazem.SalvarDados(nomeFicheiro);
            }
            catch (IOException e)
            {
                throw new ArmazemExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new ArmazemExcecoes("Passou nas regras", e);
            }
        }

        /// <summary>
        /// Carrega os dados para o programa
        /// </summary>
        /// <param name="nomeFicheiro">nome de ficheiro</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="ArmazemExcecoes">possivel exceção lançada</exception>
        public static bool CarregarDados(string nomeFicheiro)
        {
            try
            {
                return Armazem.CarregarDados(nomeFicheiro);
            }
            catch (IOException e)
            {
                throw new ArmazemExcecoes("Passou nas regras:", e);
            }
            catch (Exception e)
            {
                throw new ArmazemExcecoes("Passou nas regras", e);
            }
        }
        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}