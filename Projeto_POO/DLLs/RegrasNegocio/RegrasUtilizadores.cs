/*
*	<copyright file="RegrasNegocio" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>09/12/2023 00:23:58</date>
*	<description></description>
*/


using Dados;
using Excecoes;
using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.IO;

namespace RegrasNegocio
{
    /// <summary>
    /// Purpose: 
    /// Created by: Diogo
    /// Created on: 09/12/2023 00:23:58
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class RegrasUtilizadores
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
        /// Verifica se existe um email igual no sistema
        /// </summary>
        /// <param name="email">email</param>
        /// <returns>true ou false, dependendo se existir ou não</returns>
        /// <exception cref="UtilizadoresExcecoes">possivel exceção lançada</exception>
        public static bool ExisteEmail(string email)
        {
            try
            {
                return Utilizadores.ExisteEmailSistema(email);
            }
            catch ( UtilizadoresExcecoes e)
            {
                throw new UtilizadoresExcecoes("Passou nas regras", e);
            }
            catch ( Exception e)
            {
                throw new UtilizadoresExcecoes("Passou nas regras", e);
            }
        }

        /// <summary>
        /// Verifica se existe um utiizador com aqueles dados no sistema
        /// </summary>
        /// <param name="email">email</param>
        /// <param name="password">password</param>
        /// <returns>true ou false, dependendo se existir ou não</returns>
        /// <exception cref="UtilizadoresExcecoes">possivel exceção lançada</exception>
        public static bool ExisteConta(string email, string password)
        {
            try
            {
                return Utilizadores.ExisteContaSistema(email, password);
            }
            catch (UtilizadoresExcecoes e)
            {
                throw new UtilizadoresExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new UtilizadoresExcecoes("Passou nas regras", e);
            }
        }

        /// <summary>
        /// Obtém a quantidade de utilizadores no sistema
        /// </summary>
        /// <param name="contador">quantidade de utilizadores</param>
        /// <returns>true</returns>
        public static bool QuantidadeUtilizadores(out int contador)
        {
            contador = Utilizadores.Users.Count;
            return true;
        }

        /// <summary>
        /// Obtém todos os utilizadores do sistema
        /// </summary>
        /// <param name="util">utilizadores do sistema</param>
        /// <returns>true</returns>
        public static bool ListaUtilizadores(out List<Utilizador> util)
        {
            util = Utilizadores.Users;
            return true;
        }

        /// <summary>
        /// Insere um utilizador na lista de utilizadores do sistema
        /// </summary>
        /// <param name="util">utilizador</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="UtilizadoresExcecoes">possivel exceção lançada</exception>
        public static bool InserirUtilizador(Utilizador util)
        {
            try
            {
                return Utilizadores.InserirUtilizadorSistema(util);
            }
            catch (UtilizadoresExcecoes e)
            {
                throw new UtilizadoresExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new UtilizadoresExcecoes("Passou nas regras", e);
            }
        }

        /// <summary>
        /// Remove um utilizador do sistema
        /// </summary>
        /// <param name="email">email</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="UtilizadoresExcecoes">possivel exceção lançada</exception>
        public static bool RemoverUtilizador(string email)
        {
            try
            {
                return Utilizadores.RemoverUtilizadorSistema(email);
            }
            catch (UtilizadoresExcecoes e)
            {
                throw new UtilizadoresExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new UtilizadoresExcecoes("Passou nas regras", e);
            }
        }

        /// <summary>
        /// Altera um email de um utilizador do sistema
        /// </summary>
        /// <param name="antigoEmail">email antigo</param>
        /// <param name="password">passowrd</param>
        /// <param name="novoEmail">novo email</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="UtilizadoresExcecoes">possivel exceção lançada</exception>
        public static bool AlterarEmail(string antigoEmail, string password, string novoEmail)
        {
            try
            {
                return Utilizadores.AlterarEmailSistema(antigoEmail, password, novoEmail);
            }
            catch (UtilizadoresExcecoes e)
            {
                throw new UtilizadoresExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new UtilizadoresExcecoes("Passou nas regras", e);
            }
        }

        /// <summary>
        /// Altera uma password de um utilizador do sistema
        /// </summary>
        /// <param name="email"></param>
        /// <param name="antigaPassword"></param>
        /// <param name="novaPassword"></param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="UtilizadoresExcecoes">possivel exceção lançada</exception>
        public static bool AlterarPassword(string email, string antigaPassword, string novaPassword)
        {
            try
            {
                return Utilizadores.AlterarPasswordSistema(email, antigaPassword, novaPassword);
            }
            catch (UtilizadoresExcecoes e)
            {
                throw new UtilizadoresExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new UtilizadoresExcecoes("Passou nas regras", e);
            }
        }

        /// <summary>
        /// Salva os dados num ficheiro
        /// </summary>
        /// <param name="nomeFicheiro">nome de ficheiro</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="UtilizadoresExcecoes">possivel exceção lançada</exception>
        public static bool SalvarDados(string nomeFicheiro)
        {
            try
            {
                return Utilizadores.SalvarDados(nomeFicheiro);
            }
            catch(IOException e)
            {
                throw new UtilizadoresExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new UtilizadoresExcecoes("Passou nas regras", e);
            }
        }

        /// <summary>
        /// Carrega os dados para o programa
        /// </summary>
        /// <param name="nomeFicheiro">nome de ficheiro</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="UtilizadoresExcecoes">possivel exceção lançada</exception>
        public static bool CarregarDados(string nomeFicheiro)
        {
            try
            {
                return Utilizadores.CarregarDados(nomeFicheiro);
            }
            catch (IOException e)
            {
                throw new UtilizadoresExcecoes("Passou nas regras", e);
            }
            catch (Exception e)
            {
                throw new UtilizadoresExcecoes("Passou nas regras", e);
            }
        }

        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}