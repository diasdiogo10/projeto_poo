/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>29/12/2023 21:17:59</date>
*	<description></description>
*/


using System;
using System.Collections.Generic;

namespace ObjetosNegocio
{
    /// <summary>
    /// Purpose: 
    /// Created by: Diogo
    /// Created on: 29/12/2023 21:17:59
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public interface IOperacao
    {
        #region Methods

        #region Properties

        /// <summary>
        /// Propriedade para data de venda
        /// </summary>
        DateTime DataOp
        {
            get;
            set;
        }

        /// <summary>
        /// Propriedade para username
        /// </summary>
        string Username
        {
            get;
            set;
        }

        /// <summary>
        /// Propriedade para produtos
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