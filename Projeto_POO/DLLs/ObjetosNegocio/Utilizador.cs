/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>06/12/2023 23:04:52</date>
*	<description></description>
*/


using System;

namespace ObjetosNegocio
{
    /// <summary>
    /// Purpose: Classe de utilizador
    /// Created by: Diogo
    /// Created on: 06/12/2023 23:04:52
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    [Serializable]
    public class Utilizador : Pessoa, IUtilizador
    {
        #region Attributes

        string email;
        string password;
        CarrinhoCompra carrinho;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Construtor de classe por defeito
        /// </summary>
        public Utilizador()
        {
            email = string.Empty;
            password = string.Empty;
            carrinho = new CarrinhoCompra();
        }

        /// <summary>
        /// Construtor de classe com os atributos declarados
        /// </summary>
        /// <param name="email">email para login do utilizador</param>
        /// <param name="password">password para login do utilizador</param>
        public Utilizador(string email, string password)
        {
            this.email = email;
            this.password = password;
            carrinho = new CarrinhoCompra();
        }

        /// <summary>
        /// Construtor de classe com os atributos declarados
        /// </summary>
        /// <param name="email">email para login do utilizador</param>
        /// <param name="password">password para login do utilizador</param>
        /// <param name="nome">nome</param>
        /// <param name="dataNasc">data de nascimento</param>
        /// <param name="localizacao">localizacao</param>
        public Utilizador(string email, string password, string nome, DateTime dataNasc, Morada localizacao)
        {
            this.email = email;
            this.password = password;
            carrinho = new CarrinhoCompra();
            Nome = nome;
            DataNascimento = dataNasc;
            Localizacao = localizacao;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Propriedade para email
        /// </summary>
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        /// <summary>
        /// Propriedade para password
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        /// <summary>
        /// Propriedade para carrinho de compras
        /// </summary>
        public CarrinhoCompra Carrinho
        {
            get { return carrinho; }
            set { carrinho = value; }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Compara a igualdade de dois utilizadores através dos seus parâmetros
        /// </summary>
        /// <param name="u1">utilizador 1</param>
        /// <param name="u2">utilizador 2</param>
        /// <returns>true ou false, dependendo se for igual ou não</returns>
        public static bool operator ==(Utilizador u1, Utilizador u2)
        {
            if (u1.Email == u2.Email && u1.Password == u2.Password)
                return true;
            return false;
        }

        /// <summary>
        /// Compara a diferenciabilidade de dois utilizadores através de seus utilizadores
        /// </summary>
        /// <param name="u1">utilizador 1</param>
        /// <param name="u2">utilizador 2</param>
        /// <returns>true ou false, dependendo se for diferente ou não</returns>
        public static bool operator !=(Utilizador u1, Utilizador u2)
        {
            if (u1 == u2)
                return false;
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
            if (obj is Utilizador)
            {
                Utilizador u = (Utilizador)obj;
                if (this == u)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Devolve os dados do método da classe base(Pessoa) deste utilizador
        /// </summary>
        /// <returns>string final</returns>
        public override string ToString()
        {
            return string.Format(base.ToString());
        }
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}