/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>29/12/2023 21:20:29</date>
*	<description></description>
*/


using System;
using System.Collections.Generic;

namespace ObjetosNegocio
{
    /// <summary>
    /// Purpose: 
    /// Created by: Diogo
    /// Created on: 29/12/2023 21:20:29
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    [Serializable]
    public abstract class Operacao : IOperacao
    {
        #region Attributes

        Dictionary<int, int> prods;
        string username;
        DateTime dataOp;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Construtor de classe por defeito
        /// </summary>
        public Operacao()
        {
            prods = new Dictionary<int, int>();
            username = "";
            dataOp = new DateTime();
        }

        /// <summary>
        /// Construtor de classe com os parâmetros definidos
        /// </summary>
        /// <param name="prods">produtos</param>
        /// <param name="username">username</param>
        /// <param name="dataOp">data de operacao</param>
        public Operacao(Dictionary<int, int> prods, string username, DateTime dataOp)
        {
            this.prods = prods;
            this.username = username;
            this.dataOp = dataOp;
        }


        #endregion

        #region Properties

        /// <summary>
        /// Propriedade para data de venda
        /// </summary>
        public DateTime DataOp
        {
            get { return dataOp; }
            set { dataOp = value; }
        }

        /// <summary>
        /// Propriedade para username
        /// </summary>
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        /// <summary>
        /// Propriedade para produtos
        /// </summary>
        public Dictionary<int, int> Prods
        {
            get { return prods; }
            set { prods = value; }
        }

        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// Emite uma fatura
        /// </summary>
        /// <returns>true ou false, dependendo se tudo correu bem ou não</returns>
        public abstract bool EmitirFatura();

        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}