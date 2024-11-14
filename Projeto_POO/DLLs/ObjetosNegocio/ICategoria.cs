/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>20/12/2023 03:20:54</date>
*	<description></description>
*/


using System;

namespace ObjetosNegocio
{
    /// <summary>
    /// Purpose: Interface de categoria
    /// Created by: Diogo
    /// Created on: 20/12/2023 03:20:54
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public interface ICategoria
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
        /// Propriedade para descricao
        /// </summary>
        string Descricao
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