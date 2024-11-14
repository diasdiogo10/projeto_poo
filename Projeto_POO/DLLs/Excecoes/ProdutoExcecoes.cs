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
    /// Purpose: Classe de exceções de produto
    /// Created by: Diogo
    /// Created on: 24/10/2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class ProdutoExcecoes : Exception
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        public ProdutoExcecoes(string mensagem) : base(mensagem) { }
        public ProdutoExcecoes() : base("Erro no Produto") { }
        public ProdutoExcecoes(string mensagem, Exception e)
        {
            throw new ProdutoExcecoes("Erro no Produto - " + mensagem + "-" + e.Message);
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