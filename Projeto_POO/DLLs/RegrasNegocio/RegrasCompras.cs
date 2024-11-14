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
    /// Purpose: RegrasCompras de classe 
    /// Created by: Diogo
    /// Created on: 24/10/2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class RegrasCompras
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
        /// Insere uma compra nos dados das compras
        /// </summary>
        /// <param name="c">compra</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool InserirCompra(Compra c)
        {
            try
            {
                return Compras.InserirCompra(c);
            }
            catch (ComprasExcecoes e)
            {
                throw new ComprasExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new ComprasExcecoes("Passou nas regras", e);
            }
        }

        /// <summary>
        /// Procura todas as compras numa determinada data
        /// </summary>
        /// <param name="dataCompra">data de compra</param>
        /// <param name="c">compras</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="ComprasExcecoes">possivel exceção lançada</exception>
        public static bool ComprasData(DateTime dataCompra, out List<Compra> c)
        {
            try
            {
                return Compras.ComprasData(dataCompra, out c);
            }
            catch(ComprasExcecoes e)
            {
                throw new ComprasExcecoes("Passou nas regras", e);
            }
            catch(Exception e)
            {
                throw new ComprasExcecoes("Passou nas regras", e);
            }
        }
        /// <summary>
        /// Salva os dados num ficheiro
        /// </summary>
        /// <param name="nomeFicheiro">nome de ficheiro</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="ComprasExcecoes">possivel exceção lançada</exception>
        public static bool SalvarDados(string nomeFicheiro)
        {
            try
            {
                return Compras.SalvarDados(nomeFicheiro);
            }
            catch (IOException e)
            {
                throw new ComprasExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new ComprasExcecoes("Passou nas regras", e);
            }
        }
        /// <summary>
        /// Carrega os dados para o programa
        /// </summary>
        /// <param name="nomeFicheiro">nome de ficheiro</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="ComprasExcecoes">possivel exceção lançada</exception>
        public static bool CarregarDados(string nomeFicheiro)
        {
            try
            {
                return Compras.CarregarDados(nomeFicheiro);
            }
            catch (IOException e)
            {
                throw new ComprasExcecoes("Passou nas regras:", e);
            }
            catch (Exception e)
            {
                throw new ComprasExcecoes("Passou nas regras", e);
            }
        }
        #endregion

        #endregion

    }
}