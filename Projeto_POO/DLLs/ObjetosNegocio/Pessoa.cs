/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>06/12/2023 23:00:29</date>
*	<description></description>
*/


using System;

namespace ObjetosNegocio
{
    /// <summary>
    /// Purpose: Classe de Pessoa
    /// Created by: Diogo
    /// Created on: 06/12/2023 23:00:29
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    [Serializable]
    public class Pessoa : IPessoa, IComparable<Pessoa>
    {
        #region Attributes

        string nome;
        DateTime dataNascimento;
        Morada localizacao;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Construtor de classe por defeito
        /// </summary>
        public Pessoa()
        {
            nome = string.Empty;
            dataNascimento = DateTime.Now;
            localizacao = new Morada();
        }

        /// <summary>
        /// Construtor de classe com os parâmetros definidos
        /// </summary>
        /// <param name="nome">nome da pessoa</param>
        /// <param name="dataNascimento">data de nascimento</param>
        /// <param name="localizacao">localizacao da pessoa</param>
        public Pessoa(string nome, DateTime dataNascimento, Morada localizacao)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.localizacao = localizacao;
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
        /// Propriedade para data de nascimento
        /// </summary>
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        /// <summary>
        /// Propriedade para localizacao
        /// </summary>
        public Morada Localizacao
        {
            get { return localizacao; }
            set { localizacao = value; }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Compara a igualdade de duas pessoas através dos seus parâmetros
        /// </summary>
        /// <param name="p1">pessoa 1</param>
        /// <param name="p2">pessoa 2</param>
        /// <returns>true ou false, dependendo se for igual ou não</returns>
        public static bool operator ==(Pessoa p1, Pessoa p2)
        {
            if (p1.Nome == p2.Nome && p1.DataNascimento == p2.DataNascimento && p1.Localizacao == p2.Localizacao)   return true;
            return false;
        }

        /// <summary>
        /// Compara a diferenciabilidade de duas pessoas através dos seus parâmetros
        /// </summary>
        /// <param name="p1">pessoa 1</param>
        /// <param name="p2">pessoa 2</param>
        /// <returns>true ou false, dependendo se for diferente ou não</returns>
        public static bool operator !=(Pessoa p1, Pessoa p2)
        {
            if (p1 == p2)   return false;
            return true;
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Compara a igualdade de dois objetos
        /// </summary>
        /// <param name="obj">objeto</param>
        /// <returns>true ou false, dependendo se for diferente ou não</returns>
        public override bool Equals(object obj)
        {
            if (obj is Pessoa)
            {
                Pessoa p = (Pessoa)obj;
                if (this == p)  return true;
            }
            return false;
        }

        /// <summary>
        /// Devolve uma string com todos o nome e idade de uma pessoa
        /// </summary>
        /// <returns>string final</returns>
        public override string ToString()
        {
            return string.Format("Nome: {0} | Idade: {1}", Nome, (int)((DateTime.Now - DataNascimento).TotalDays / 365.25));
        }

        #endregion

        #region Other_Methods

        /// <summary>
        /// Compara 2 pessoas e é útil para utilizar o .Sort na classe de pessoas
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int CompareTo(Pessoa p)
        {
            return this.DataNascimento.CompareTo(p.DataNascimento);
        }

        #endregion

        #endregion
    }
}