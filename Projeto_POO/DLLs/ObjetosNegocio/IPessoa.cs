/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>20/12/2023 03:35:05</date>
*	<description></description>
*/


using System;

namespace ObjetosNegocio
{
    /// <summary>
    /// Purpose: Interface de pessoa
    /// Created by: Diogo
    /// Created on: 20/12/2023 03:35:05
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public interface IPessoa
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
        /// Propriedade para data de nascimento
        /// </summary>
        DateTime DataNascimento
        {
            get;
            set;
        }

        /// <summary>
        /// Propriedade para localizacao
        /// </summary>
        Morada Localizacao
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