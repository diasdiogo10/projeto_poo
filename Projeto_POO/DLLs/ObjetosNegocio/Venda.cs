/*
*	<copyright file="ObjetosNegocio.cs" company="IPCA">
*	Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>24/10/2023</date>
*	<description></description>
*/

using System;
using System.Collections.Generic;
using System.Data;

namespace ObjetosNegocio
{
    /// <summary>
    /// Purpose: Venda de classe 
    /// Created by: Diogo
    /// Created on: 24/10/2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    [Serializable]
    public class Venda : Operacao, IComparable<Venda>
    {
        #region Attributes

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Construtor de classe por defeito
        /// </summary>
        public Venda()
        {
            Prods = new Dictionary<int, int>();
            Username = "";
            DataOp = new DateTime();
        }

        /// <summary>
        /// Construtor de classe com os parâmetros definidos
        /// </summary>
        /// <param name="prods">produtos</param>
        /// <param name="username">username</param>
        /// <param name="dataOp">data de operacao</param>
        public Venda(Dictionary<int, int> prods, string username, DateTime dataOp)
        {
            Prods = prods;
            Username = username;
            DataOp = dataOp;
        }

        #endregion

        #region Properties

        #endregion

        #region Operators
        #endregion

        #region Overrides

        /// <summary>
        /// Emite uma fatura
        /// </summary>
        /// <returns>true ou false, dependendo se tudo correu bem ou não</returns>
        public override bool EmitirFatura()
        {
            if (ReferenceEquals(Prods, null)) return false;

            Console.WriteLine("Comprador: {0}", Username);

            foreach (var chave in Prods)
            {
                Console.WriteLine("Produto: {0} | Quantidade: {1}", chave.Key.ToString(), chave.Value.ToString());
            }

            Console.WriteLine("Vendido em: {0}", DataOp.ToString());

            return true;
        }

        #endregion

        #region Other_Methods

        /// <summary>
        /// Compara 2 vendas e é útil para utilizar o .Sort na classe de vendas
        /// </summary>
        /// <param name="v1">venda</param>
        /// <returns></returns>
        public int CompareTo(Venda v1)
        {
            return DataOp.CompareTo(v1.DataOp);
        }

        #endregion

        #endregion

    }
}