/*
*	<copyright file="Excecoes.cs" company="IPCA">
*	Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>24/10/2023</date>
*	<description></description>
*/

using System;

namespace Excecoes
{
    /// <summary>
    /// Purpose: Classe de venda de exceções
    /// Created by: Diogo
    /// Created on: 24/10/2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class VendasExcecoes : Exception
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        public VendasExcecoes(string mensagem) : base(mensagem) { }
        public VendasExcecoes() : base("Erro na Venda") { }
        public VendasExcecoes(string mensagem, Exception e)
        {
            throw new VendasExcecoes("Erro na Venda - " + mensagem + "-" + e.Message);
        }
        #endregion

        #region Properties
        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region Other_Methods
        #endregion

        #endregion

    }
}