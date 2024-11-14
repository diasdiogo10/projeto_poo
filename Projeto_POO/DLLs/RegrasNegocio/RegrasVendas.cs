/*
*	<copyright file="RegrasNegocio.cs" company="IPCA">
*	Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>24/10/2023</date>
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
    /// Purpose: RegrasVendas de classe 
    /// Created by: Diogo
    /// Created on: 24/10/2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class RegrasVendas
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
        /// Insere uma venda nos dados das vendas
        /// </summary>
        /// <param name="v">venda</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool InserirVenda(Venda v)
        {
            try
            {
                return Vendas.InserirVenda(v);
            }
            catch (VendasExcecoes e)
            {
                throw new VendasExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new VendasExcecoes("Passou nas regras", e);
            }
        }

        /// <summary>
        /// Procura todas as vendas numa determinada data
        /// </summary>
        /// <param name="dataVenda">data de venda</param>
        /// <param name="v">vendas</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="VendasExcecoes">possivel exceção lançada</exception>
        public static bool VendasData(DateTime dataVenda, out List<Venda> v)
        {
            try
            {
                return Vendas.VendasData(dataVenda, out v);
            }
            catch (VendasExcecoes e)
            {
                throw new VendasExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new VendasExcecoes("Passou nas regras", e);
            }
        }
        /// <summary>
        /// Salva os dados num ficheiro
        /// </summary>
        /// <param name="nomeFicheiro">nome de ficheiro</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="VendasExcecoes">possivel exceção lançada</exception>
        public static bool SalvarDados(string nomeFicheiro)
        {
            try
            {
                return Vendas.SalvarDados(nomeFicheiro);
            }
            catch (IOException e)
            {
                throw new VendasExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new VendasExcecoes("Passou nas regras", e);
            }
        }
        /// <summary>
        /// Carrega os dados para o programa
        /// </summary>
        /// <param name="nomeFicheiro">nome de ficheiro</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="VendasExcecoes">possivel exceção lançada</exception>
        public static bool CarregarDados(string nomeFicheiro)
        {
            try
            {
                return Vendas.CarregarDados(nomeFicheiro);
            }
            catch (IOException e)
            {
                throw new VendasExcecoes("Passou nas regras:", e);
            }
            catch (Exception e)
            {
                throw new VendasExcecoes("Passou nas regras", e);
            }
        }

        #endregion

        #endregion

    }
}