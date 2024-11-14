/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>06/12/2023 23:11:28</date>
*	<description></description>
*/


using System;

namespace ObjetosNegocio
{
    /// <summary>
    /// Purpose: Classe de Produto
    /// Created by: Diogo
    /// Created on: 06/12/2023 23:11:28
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    [Serializable]
    public class Produto : IProduto, IComparable<Produto>
    {
        #region Attributes

        int refProd;
        int quantidade;
        string nome;
        double preco;
        Categoria cat;
        Marca mar;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Construtor de classe por defeito
        /// </summary>
        public Produto()
        {
            refProd = -1;
            quantidade = 0;
            nome = "";
            preco = -1;
            cat = new Categoria();
            mar = new Marca();
        }

        /// <summary>
        /// Construtor de classe com os atributos declarados
        /// </summary>
        /// <param name="nome">nome do produto</param>
        /// <param name="preco">preco do produto</param>
        /// <param name="cat">categoria do produto</param>
        /// <param name="mar">marca do produto</param>
        public Produto(string nome, double preco, Categoria cat, Marca mar)
        {
            refProd = -1;
            quantidade = 0;
            this.nome = nome;
            this.preco = preco;
            this.cat = cat;
            this.mar = mar;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Propriedade para referencia de produto
        /// </summary>
        public int RefProd
        {
            get { return refProd; }
            set { refProd = value; }
        }

        /// <summary>
        /// Propriedade para quantidade do produto
        /// </summary>
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        /// <summary>
        /// Propriedade para nome
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Propriedade para preco
        /// </summary>
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        /// <summary>
        /// Propriedade para categoria do produto
        /// </summary>
        public Categoria Cat
        {
            get { return cat; }
            set { cat = value; }
        }

        /// <summary>
        /// Propriedade para marca do produto
        /// </summary>
        public Marca Mar
        {
            get { return mar; }
            set { mar = value; }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Compara a igualdade de dois produtos através dos seus parâmetros
        /// </summary>
        /// <param name="p1">produto 1</param>
        /// <param name="p2">produto 2</param>
        /// <returns>true ou false, dependendo se for igual ou não</returns>
        public static bool operator ==(Produto p1, Produto p2)
        {
            if (p1.Nome == p2.Nome)
                return true;
            return false;
        }

        /// <summary>
        /// Compara a diferenciabilidade de dois produtos através dos seus parâmetros
        /// </summary>
        /// <param name="p1">produto 1</param>
        /// <param name="p2">produto 2</param>
        /// <returns>true ou false, dependendo se for igual ou não</returns>
        public static bool operator !=(Produto p1, Produto p2)
        {
            if (p1 == p2)   return false;
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
            if (obj is Produto)
            {
                Produto p = (Produto)obj;
                if (this == p)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Devolve uma string com todos os atributos de um produto
        /// </summary>
        /// <returns>string final</returns>
        public override string ToString()
        {
            return string.Format("Referência: {0} | Nome: {1} | Quantidade: {2} | Preço: {3} | Categoria: {4} | Marca: {5}", RefProd, Nome, Quantidade, Preco, Cat, Mar);
        }
        #endregion

        #region Other_Methods

        /// <summary>
        /// Compara 2 produtos e é útil para utilizar o .Sort na classe de produtos
        /// </summary>
        /// <param name="p">produto</param>
        /// <returns></returns>
        public int CompareTo(Produto p)
        {
            return (this.Preco.CompareTo(p.Preco));
        }

        #endregion

        #endregion
    }
}