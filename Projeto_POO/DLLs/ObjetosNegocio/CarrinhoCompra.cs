/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>07/12/2023 21:21:00</date>
*	<description></description>
*/


using System;
using System.Collections.Generic;

namespace ObjetosNegocio
{
    /// <summary>
    /// Purpose: Classe de carrinho de compra
    /// Created by: Diogo
    /// Created on: 07/12/2023 21:21:00
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    [Serializable]
    public class CarrinhoCompra : ICarrinhoCompra
    {
        #region Attributes

        Dictionary<int, int> prods;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Construtor de classe por defeito
        /// </summary>
        public CarrinhoCompra()
        {
            prods = new Dictionary<int, int>();
        }

        /// <summary>
        /// Construtor de classe com ôs parâmetros definidos
        /// </summary>
        /// <param name="prods">produtos</param>
        public CarrinhoCompra(Dictionary<int,int> prods)
        {
            this.prods = prods;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Propriedade de produtos
        /// </summary>
        public Dictionary<int, int> Prods
        {
            get {  return prods; }
            set { prods = value; }
        }

        #endregion

        #region Operators
        #endregion

        #region Overrides

        #endregion

        #region OtherMethods

        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}