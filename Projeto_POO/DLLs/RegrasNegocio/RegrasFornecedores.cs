/*
*	<copyright file="RegrasNegocio.cs" company="IPCA">
*	Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>24/10/2023</date>
*	<description></description>
*/

using Dados;
using Excecoes;
using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.IO;

namespace RegrasNegocio
{
    /// <summary>
    /// Purpose: RegrasFornecedores de classe 
    /// Created by: Diogo
    /// Created on: 24/10/2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class RegrasFornecedores
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

        #region Other_Methods

        /// <summary>
        /// Verifica se existe um produto nos fornecedores ou não
        /// </summary>
        /// <param name="nomeProd">nome do produto</param>
        /// <returns>true ou false, dependendo se existe ou não</returns>
        public static bool ExisteProdutoFornecedores(string nomeProd)
        {
            try
            {
                return Fornecedores.ExisteProdutoFornecedores(nomeProd);
            }
            catch (FornecedoresExcecoes e)
            {
                throw new FornecedoresExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new FornecedoresExcecoes("Passou nas regras", e);
            }
        }

        /// <summary>
        /// Verifica se existe um produto num certo fornecedor ou não
        /// </summary>
        /// <param name="nomeProd">nome do produto</param>
        /// <param name="nomeForn">nome do fornecedor</param>
        /// <returns>true ou false, dependendo se existe ou não</returns>
        public static bool ExisteProdutoFornecedor(string nomeProd, string nomeForn)
        {
            try
            {
                return Fornecedores.ExisteProdutoFornecedor(nomeProd, nomeForn);
            }
            catch (FornecedoresExcecoes e)
            {
                throw new FornecedoresExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new FornecedoresExcecoes("Passou nas regras", e);
            }
        }

        /// <summary>
        /// Insere um produto nos Fornecedores
        /// </summary>
        /// <param name="prod">produto</param>
        /// <param name="nomeForn">nome do fornecedor</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool InserirProduto(Produto prod, string nomeForn)
        {
            try
            {
                return Fornecedores.InserirProdutoFornecedor(prod, nomeForn);
            }
            catch (FornecedoresExcecoes e)
            {
                throw new FornecedoresExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new FornecedoresExcecoes("Passou nas regras", e);
            }
        }

        /// <summary>
        /// Remove um produto de um fornecedor
        /// </summary>
        /// <param name="nomeProd">nome do produto</param>
        /// <param name="nomeForn">nome do fornecedor</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool RemoverProduto(string nomeProd, string nomeForn)
        {
            try
            {
                return Fornecedores.RemoverProdutoFornecedor(nomeProd, nomeForn);
            }
            catch (FornecedoresExcecoes e)
            {
                throw new FornecedoresExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new FornecedoresExcecoes("Passou nas regras", e);
            }
        }

        /// <summary>
        /// Verifica se existe um fornecedor
        /// </summary>
        /// <param name="nome">nome</param>
        /// <returns>true ou false, dependendo se existe ou não</returns>
        /// <exception cref="FornecedoresExcecoes">possivel exceção lançada</exception>
        public static bool ExisteFornecedor(string nome)
        {
            try
            {
                return Fornecedores.ExisteFornecedorSistema(nome);
            }
            catch (FornecedoresExcecoes e)
            {
                throw new FornecedoresExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new FornecedoresExcecoes("Passou nas regras", e);
            }
        }

        /// <summary>
        /// Obtém a quantidade de fornecedores do sistema
        /// </summary>
        /// <param name="contador">quantidade de fornecedores</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool QuantidadeFornecedores(out int contador)
        {
            contador = Fornecedores.Forns.Count;
            return true;
        }

        /// <summary>
        /// Obtém a lista de todos os fornecedores do sistema
        /// </summary>
        /// <param name="lista">fornecedores</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool ListaFornecedores(out List<Fornecedor> lista)
        {
            lista = Fornecedores.Forns;
            return true;
        }

        /// <summary>
        /// Insere um fornecedor
        /// </summary>
        /// <param name="forn">fornecedor</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="FornecedoresExcecoes">possivel exceção lançada</exception>
        public static bool InserirFornecedor(Fornecedor forn)
        {
            try
            {
                return Fornecedores.InserirFornecedorSistema(forn);
            }
            catch (FornecedoresExcecoes e)
            {
                throw new FornecedoresExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new FornecedoresExcecoes("Passou nas regras", e);
            }
        }

        /// <summary>
        /// Remove um fornecedor
        /// </summary>
        /// <param name="nome">nome</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="FornecedoresExcecoes">possivel exceção lançada</exception>
        public static bool RemoverFornecedor(string nome)
        {
            try
            {
                return Fornecedores.RemoverFornecedorSistema(nome);
            }
            catch (FornecedoresExcecoes e)
            {
                throw new FornecedoresExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new FornecedoresExcecoes("Passou nas regras", e);
            }
        }

        /// <summary>
        /// Salva os dados num ficheiro
        /// </summary>
        /// <param name="nomeFicheiro">nome de ficheiro</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="FornecedoresExcecoes">possivel exceção lançada</exception>
        public static bool SalvarDados(string nomeFicheiro)
        {
            try
            {
                return Fornecedores.SalvarDados(nomeFicheiro);
            }
            catch (IOException e)
            {
                throw new FornecedoresExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new FornecedoresExcecoes("Passou nas regras", e);
            }
        }

        /// <summary>
        /// Carrega os dados para o programa
        /// </summary>
        /// <param name="nomeFicheiro">nome de ficheiro</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="FornecedoresExcecoes">possivel exceção lançada</exception>
        public static bool CarregarDados(string nomeFicheiro)
        {
            try
            {
                return Fornecedores.CarregarDados(nomeFicheiro);
            }
            catch (IOException e)
            {
                throw new FornecedoresExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new FornecedoresExcecoes("Passou nas regras", e);
            }
        }

        #endregion

        #endregion

    }
}