/*
*	<copyright file="ObjetosNegocio.cs" company="IPCA">
*	Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>24/10/2023</date>
*	<description></description>
*/

using System;

namespace ObjetosNegocio
{
    /// <summary>
    /// Purpose: Compra de classe 
    /// Created by: Diogo
    /// Created on: 24/10/2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    [Serializable]
    public class Compra : Operacao, IComparable<Compra>
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

        /// <summary>
        /// Emite uma fatura
        /// </summary>
        /// <returns>true ou false, dependendo se tudo correu bem ou não</returns>
        public override bool EmitirFatura()
        {
            if (ReferenceEquals(Prods, null)) return false;

            Console.WriteLine("Fornecedor: {0}", Username);

            foreach (var chave in Prods)
            {
                Console.WriteLine("Produto: {0} | Quantidade: {1}", chave.Key.ToString(), chave.Value.ToString());
            }

            Console.WriteLine("Comprado em: {0}", DataOp.ToString());

            return true;
        }

        #endregion

        #region Other_Methods

        /// <summary>
        /// Compara 2 compras e é útil para utilizar o .Sort na classe de compras
        /// </summary>
        /// <param name="c1"></param>
        /// <returns></returns>
        public int CompareTo(Compra c1)
        {
            return DataOp.CompareTo(c1.DataOp);
        }
        #endregion

        #endregion

    }
}