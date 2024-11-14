/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>20/12/2023 03:40:49</date>
*	<description></description>
*/


using System;
using System.Collections.Generic;

namespace ObjetosNegocio
{
    /// <summary>
    /// Purpose: 
    /// Created by: Diogo
    /// Created on: 20/12/2023 03:40:49
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public interface ICarrinhoCompra
    {
        #region Methods

        #region Properties

        /// <summary>
        /// Propriedade de produtos
        /// </summary>
        Dictionary<int, int> Prods
        {
            get;
            set;
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