/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>06/12/2023 23:35:37</date>
*	<description></description>
*/


using System;
using System.Collections.Generic;

namespace ObjetosNegocio
{
    /// <summary>
    /// Purpose: Classe de fornecedor
    /// Created by: Diogo
    /// Created on: 06/12/2023 23:35:37
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    [Serializable]
    public class Fornecedor : IFornecedor
    {
        #region Attributes

        string nome;
        string contacto;
        List<Produto> prods;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Construtor de classe por defeito
        /// </summary>
        public Fornecedor() 
        { 
            nome = "";
            contacto = "";
            prods = new List<Produto>();
        }

        /// <summary>
        /// Construtor de classe com os parâmetros definidos
        /// </summary>
        /// <param name="nome">nome</param>
        /// <param name="contacto">contacto</param>
        /// <param name="prods">produtos</param>
        public Fornecedor(string nome, string contacto)
        {
            this.nome = nome;
            this.contacto = contacto;
            prods = new List<Produto>();
        }


        #endregion

        #region Properties

        /// <summary>
        /// Propriedade para nome
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Propriedade para contacto
        /// </summary>
        public string Contacto
        {
            get { return contacto; }
            set { contacto = value; }
        }

        /// <summary>
        /// Propriedade para produtos
        /// </summary>
        public List<Produto> Prods
        {
            get { return prods; }
            set { prods = value; }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Compara a igualdade de dois fornecedores através dos seus parâmetros
        /// </summary>
        /// <param name="f1">fornecedor 1</param>
        /// <param name="f2">fornecedor 2</param>
        /// <returns>true ou false, dependendo se for igual ou não</returns>
        public static bool operator ==(Fornecedor f1, Fornecedor f2)
        {
            if(f1.Nome == f2.Nome) return true;
            return false;
        }

        /// <summary>
        /// Compara a diferenciabilidade de dois fornecedores através dos seus parâmetros
        /// </summary>
        /// <param name="f1">fornecedor 1</param>
        /// <param name="f2">fornecedor 2</param>
        /// <returns>true ou false, dependendo se for diferente ou não</returns>
        public static bool operator !=(Fornecedor f1, Fornecedor f2)
        {
            if (f1 == f2) return false;
            return true;
        }
        #endregion

        #region Overrides

        /// <summary>
        /// Compara 2 objetos
        /// </summary>
        /// <param name="obj">objeto</param>
        /// <returns>true ou false, dependendo se for igual ou não</returns>
        public override bool Equals(object obj)
        {
            if (obj is Fornecedor)
            {
                Fornecedor f = (Fornecedor)obj;
                if (this == f)  return true;
            }
            return false;
        }

        /// <summary>
        /// Devolve uma string com o atributo de nome e contacto do fornecedor
        /// </summary>
        /// <returns>string final</returns>
        public override string ToString()
        {
            return string.Format("Nome: {0} | Contacto: {1}", Nome, Contacto);
        }
        #endregion

        #region OtherMethods



        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}