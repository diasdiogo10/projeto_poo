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
    /// Purpose: Classe de exceções de fornecedores
    /// Created by: Diogo
    /// Created on: 24/10/2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class FornecedoresExcecoes : Exception
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors
        public FornecedoresExcecoes(string mensagem) : base(mensagem) { }
        public FornecedoresExcecoes() : base("Erro nos Fornecedores") { }
        public FornecedoresExcecoes(string mensagem, Exception e)
        {
            throw new FornecedoresExcecoes("Erro nos Fornecedores - " + mensagem + "-" + e.Message);
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