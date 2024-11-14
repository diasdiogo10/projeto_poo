/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>20/12/2023 03:28:55</date>
*	<description></description>
*/


using System;
using System.Security.Cryptography;

namespace ObjetosNegocio
{
    /// <summary>
    /// Purpose: Interface de morada
    /// Created by: Diogo
    /// Created on: 20/12/2023 03:28:55
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public interface IMorada
    {
        #region Methods

        #region Properties

        /// <summary>
        /// Propriedade para cidade
        /// </summary>
        string Cidade
        {
            get;
            set;
        }

        /// <summary>
        /// Propriedade para distrito
        /// </summary>
        string Distrito
        {
            get;
            set;
        }

        /// <summary>
        /// Propriedade para rua
        /// </summary>
        string Rua
        {
            get;
            set;
        }

        /// <summary>
        /// Propriedade para numero de porta
        /// </summary>
        int NumPorta
        {
            get;
            set;
        }

        /// <summary>
        /// Propriedade para codigo postal
        /// </summary>
        string CodigoPostal
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