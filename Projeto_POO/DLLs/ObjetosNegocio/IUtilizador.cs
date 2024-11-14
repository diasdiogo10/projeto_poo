/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>20/12/2023 03:40:31</date>
*	<description></description>
*/


using System;

namespace ObjetosNegocio
{
    /// <summary>
    /// Purpose: 
    /// Created by: Diogo
    /// Created on: 20/12/2023 03:40:31
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public interface IUtilizador
    {
        #region Methods

        #region Properties

        /// <summary>
        /// Propriedade para email
        /// </summary>
        string Email
        {
            get;
            set;
        }

        /// <summary>
        /// Propriedade para password
        /// </summary>
        string Password
        {
            get;
            set;
        }

        /// <summary>
        /// Propriedade para carrinho de compras
        /// </summary>
        CarrinhoCompra Carrinho
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