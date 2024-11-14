/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>06/12/2023 23:02:38</date>
*	<description></description>
*/

using System;

namespace ObjetosNegocio
{
    /// <summary>
    /// Purpose: Classe de categoria
    /// Created by: Diogo
    /// Created on: 06/12/2023 23:02:38
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    [Serializable]
    public class Categoria : ICategoria
    {
        #region Attributes

        string nome;
        string descricao;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Construtor de classe por defeito
        /// </summary>
        public Categoria()
        {
            nome = string.Empty;
            descricao = string.Empty;
        }

        /// <summary>
        /// Construtor de classe com os atributos declarados
        /// </summary>
        /// <param name="nome">nome da categoria</param>
        /// <param name="descricao">descricao da categoria</param>
        public Categoria(string nome, string descricao)
        {
            this.nome = nome;
            this.descricao = descricao;
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
        /// Propriedade para descricao
        /// </summary>
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Compara a igualdade de duas categorias através dos seus parâmetros
        /// </summary>
        /// <param name="c1">categoria 1</param>
        /// <param name="c2">categoria 2</param>
        /// <returns>true ou false, dependendo se for igual ou não</returns>
        public static bool operator ==(Categoria c1, Categoria c2)
        {
            if (c1.Nome == c2.Nome) return true;
            return false;
        }

        /// <summary>
        /// Compara a diferenciabilidade de duas categorias através dos seus parâmetros
        /// </summary>
        /// <param name="c1">categoria 1</param>
        /// <param name="c2">categoria 2</param>
        /// <returns>true ou false, dependendo se for diferente ou não</returns>
        public static bool operator !=(Categoria c1, Categoria c2)
        {
            if (c1 == c2)   return false;
            return true;
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Compara 2 objetos
        /// </summary>
        /// <param name="obj">objeto</param>
        /// <returns>true ou false, dependendo se for diferente ou não</returns>
        public override bool Equals(object obj)
        {
            if (obj is Categoria)
            {
                Categoria c = (Categoria)obj;
                if (this == c) return true;
            }
            return false;
        }

        /// <summary>
        /// Devolve uma string com todos os atributos de uma categoria
        /// </summary>
        /// <returns>string final</returns>
        public override string ToString()
        {
            return string.Format("Nome: {0} | Descrição: {1}", Nome, Descricao);
        }

        #endregion

        #region Other_Methods
        #endregion

        #endregion
    }
}