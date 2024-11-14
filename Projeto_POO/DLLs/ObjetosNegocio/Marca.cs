/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>06/12/2023 23:03:12</date>
*	<description></description>
*/


using System;

namespace ObjetosNegocio
{
    /// <summary>
    /// Purpose: Classe de marca
    /// Created by: Diogo
    /// Created on: 06/12/2023 23:03:12
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    [Serializable]
    public class Marca : IMarca
    {
        #region Attributes

        string nome;
        string contacto;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Construtor de classe por defeito
        /// </summary>
        public Marca()
        {
            nome = string.Empty;
            contacto = string.Empty;
        }

        /// <summary>
        /// Construtor de classe com os atributos declarados
        /// </summary>
        /// <param name="nome">nome da marca</param>
        /// <param name="contacto">contacto da marca</param>
        public Marca(string nome, string contacto)
        {
            this.nome = nome;
            this.contacto = contacto;
        }


        #endregion

        #region Properties

        /// <summary>
        /// Propriedade para nome
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { this.nome = value; }
        }

        /// <summary>
        /// Propriedade para contacto
        /// </summary>
        public string Contacto
        {
            get { return contacto; }
            set { this.contacto = value; }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Metodo que compara a igualdade de 2 marcas através dos seus parâmetros
        /// </summary>
        /// <param name="m1">marca 1</param>
        /// <param name="m2">marca 2</param>
        /// <returns>true ou false, dependendo se for igual ou não</returns>
        public static bool operator ==(Marca m1, Marca m2)
        {
            if (m1.Nome == m2.Nome) return true;
            return false;
        }

        /// <summary>
        /// Metodo que compara a diferenciabilidade de 2 marcas através dos seus parâmetros
        /// </summary>
        /// <param name="m1">marca 1</param>
        /// <param name="m2">marca 2</param>
        /// <returns>true ou false, dependendo se for diferente ou não</returns>
        public static bool operator !=(Marca m1, Marca m2)
        {
            if (m1 == m2)   return false;
            return true;
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Compara 2 objetos
        /// </summary>
        /// <param name="obj">objeto o qual se compara</param>
        /// <returns>true ou false, dependendo se for igual ou não</returns>
        public override bool Equals(object obj)
        {
            if (obj is Marca)
            {
                Marca m = (Marca)obj;
                if (this == m)  return true;
            }
            return false;
        }

        /// <summary>
        /// Devolve uma string com todos os atributos de uma marca
        /// </summary>
        /// <returns>string final</returns>
        public override string ToString()
        {
            return string.Format("Nome: {0} | Contacto: {1}", Nome, Contacto);
        }

        #endregion

        #region Other_Methods
        #endregion

        #endregion
    }
}