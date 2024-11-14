/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>20/12/2023 03:37:11</date>
*	<description></description>
*/


using System;

namespace ObjetosNegocio
{
    /// <summary>
    /// Purpose: Interface de produto
    /// Created by: Diogo
    /// Created on: 20/12/2023 03:37:11
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public interface IProduto
    {
        #region Methods

        #region Properties

        /// <summary>
        /// Propriedade para referencia de produto
        /// </summary>
        int RefProd
        {
            get;
            set;
        }

        /// <summary>
        /// Propriedade para quantidade do produto
        /// </summary>
        int Quantidade
        {
            get;
            set;
        }

        /// <summary>
        /// Propriedade para nome
        /// </summary>
        string Nome
        {
            get;
            set;
        }

        /// <summary>
        /// Propriedade para preco
        /// </summary>
        double Preco
        {
            get;
            set;
        }

        /// <summary>
        /// Propriedade para categoria do produto
        /// </summary>
        Categoria Cat
        {
            get;
            set;
        }

        /// <summary>
        /// Propriedade para marca do produto
        /// </summary>
        Marca Mar
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