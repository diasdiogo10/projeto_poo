/*
*	<copyright file="Verificacoes" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>06/12/2023 22:36:07</date>
*	<description></description>
*/


using System;
using System.Linq;

namespace Verificacoes
{
    /// <summary>
    /// Purpose: 
    /// Created by: Diogo
    /// Created on: 06/12/2023 22:36:07
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Verificacoes
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors
        #endregion

        #region Properties
        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// Verifica se a referência de um produto introduzida é válida
        /// </summary>
        /// <param name="refProd">referência de produto</param>
        /// <returns>true ou false, dependendo se é ou não válido</returns>
        public static bool Referencia(int refProd)
        {
            if (refProd < 0) return false;
            return true;
        }

        /// <summary>
        /// Verifica se a quantidade de um produto que se deseja remover é válida
        /// </summary>
        /// <param name="quantidade">quantidade que se deseja remover</param>
        /// <returns>true ou false, dependendo se é ou não válido</returns>
        public static bool Quantidade(int quantidade)
        {
            if (quantidade < 1) return false;
            return true;
        }

        /// <summary>
        /// Verifica se um email introduzido é válido
        /// </summary>
        /// <param name="email">email</param>
        /// <returns>true ou false, dependendo se é ou não válido</returns>
        public static bool Email(string email)
        {
            if (email == null && email.Length < 15) return false;
            return true;
        }

        /// <summary>
        /// Verifica se uma password introduzida é válida
        /// </summary>
        /// <param name="password">password</param>
        /// <returns>true ou false, dependendo se é ou não válido</returns>
        public static bool Password(string password)
        {
            if(password == null && password.Length < 5) return false;
            return true;
        }

        /// <summary>
        /// Verifica se um nome introduzido é válido
        /// </summary>
        /// <param name="nome">nome</param>
        /// <returns>true ou false, dependendo se é ou não válido</returns>
        public static bool Nome(string nome)
        {
            if(nome == null && nome.Any(char.IsDigit)) return false;
            return true;
        }

        /// <summary>
        /// Verifica se um contacto introduzido é válido
        /// </summary>
        /// <param name="contacto">contacto</param>
        /// <returns>true ou false, dependendo se é ou não válido</returns>
        public static bool Contacto(string contacto)
        {
            if(contacto == null && contacto.Length < 9) return false;
            return true;
        }

        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}