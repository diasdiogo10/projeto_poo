/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>20/12/2023 03:25:35</date>
*	<description></description>
*/


using System;
using System.Diagnostics.Contracts;

namespace ObjetosNegocio
{
    /// <summary>
    /// Purpose: Interface de marca
    /// Created by: Diogo
    /// Created on: 20/12/2023 03:25:35
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public interface IMarca
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