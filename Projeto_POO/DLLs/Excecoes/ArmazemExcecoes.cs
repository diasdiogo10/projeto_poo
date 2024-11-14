/*
*	<copyright file="Excecoes" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>06/12/2023 22:34:55</date>
*	<description></description>
*/


using System;

namespace Excecoes
{
    /// <summary>
    /// Purpose: Classe de exceções de armazem
    /// Created by: Diogo
    /// Created on: 06/12/2023 22:34:55
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class ArmazemExcecoes : Exception
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        public ArmazemExcecoes(string mensagem) : base(mensagem) { }
        public ArmazemExcecoes() : base("Erro no Armazem") { }
        public ArmazemExcecoes(string mensagem, Exception e) 
        {
            throw new ArmazemExcecoes("Erro no Armazem - " + mensagem + "-" + e.Message);
        }
        #endregion

        #region Properties
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