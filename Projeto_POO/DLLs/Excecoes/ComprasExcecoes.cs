/*
*	<copyright file="Excecoes.cs" company="IPCA">
*	Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>24/10/2023</date>
*	<description></description>
*/

using System;

namespace Excecoes
{
    /// <summary>
    /// Purpose: ComprasExcecoes de classe 
    /// Created by: Diogo
    /// Created on: 24/10/2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class ComprasExcecoes : Exception
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        public ComprasExcecoes(string mensagem) : base(mensagem) { }
        public ComprasExcecoes() : base("Erro na Compra") { }
        public ComprasExcecoes(string mensagem, Exception e)
        {
            throw new ComprasExcecoes("Erro na Compra - " + mensagem + "-" + e.Message);
        }
        #endregion

        #region Properties
        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region Other_Methods
        #endregion

        #endregion

    }
}