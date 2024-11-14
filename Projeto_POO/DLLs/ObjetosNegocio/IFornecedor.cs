/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>20/12/2023 03:32:38</date>
*	<description></description>
*/


using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace ObjetosNegocio
{
    /// <summary>
    /// Purpose: Interface de fornecedor
    /// Created by: Diogo
    /// Created on: 20/12/2023 03:32:38
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public interface IFornecedor
    {
        #region Methods

        #region Properties

        /// <summary>
        /// Propriedade para nome
        /// </summary>
        string Nome
        {
            get;
            set;
        }

        /// <summary>
        /// Propriedade para contacto
        /// </summary>
        string Contacto
        {
            get;
            set;
        }

        /// <summary>
        /// Propriedade para produtos
        /// </summary>
        List<Produto> Prods
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