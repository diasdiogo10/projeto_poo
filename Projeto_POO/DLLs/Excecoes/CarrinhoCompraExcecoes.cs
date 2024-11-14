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
    /// Purpose: Classe de exceções de carrinho de compra
    /// Created by: Diogo
    /// Created on: 24/10/2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class CarrinhoCompraExcecoes : Exception
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        public CarrinhoCompraExcecoes(string mensagem) : base(mensagem) { }
        public CarrinhoCompraExcecoes() : base("Erro no CarrinhoCompra") { }
        public CarrinhoCompraExcecoes(string mensagem, Exception e)
        {
            throw new CarrinhoCompraExcecoes("Erro no CarrinhoCompra - " + mensagem + "-" + e.Message);
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