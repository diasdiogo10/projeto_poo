/*
*	<copyright file="Dados" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>06/12/2023 23:09:52</date>
*	<description></description>
*/

using ObjetosNegocio;
using System.Collections.Generic;
using Excecoes;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Dados
{
    /// <summary>
    /// Purpose: Classe de utilizadores
    /// Created by: Diogo
    /// Created on: 06/12/2023 23:09:52
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Utilizadores
    {
        #region Attributes

        static List<Utilizador> users; // Lista de todos os utilizadores da nossa plataforma

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Construtor estátitoc para utilizadores
        /// </summary>
        static Utilizadores()
        {
            users = new List<Utilizador>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Propriedade para utilizadores
        /// </summary>
        public static List<Utilizador> Users
        { 
            get { return users; }
        }

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
        public static bool ExisteEmailSistema(string email)
        {
            if (ReferenceEquals(users, null)) return false;

            if (users.Exists(x => x.Email == email)) return true;

            return false;
        }

        /// <summary>
        /// Verifica se existe um utiizador com aqueles dados no sistema
        /// </summary>
        /// <param name="email">email</param>
        /// <param name="password">password</param>
        /// <returns>true ou false, dependendo se existir ou não</returns>
        public static bool ExisteContaSistema(string email, string password)
        {
            if (ReferenceEquals(users, null)) return false;

            if (users.Exists(x => x.Email == email && x.Password == password)) return true;

            return false;
        }

        /// <summary>
        /// Insere um utilizador na lista de utilizadores do sistema
        /// </summary>
        /// <param name="util">utilizador</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool InserirUtilizadorSistema(Utilizador util)
        {
            if (ReferenceEquals(users, null)) return false;

            if (users.Contains(util)) return false;

            users.Add(util);

            return true;
        }

        /// <summary>
        /// Remove um utilizador do sistema
        /// </summary>
        /// <param name="email">email</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool RemoverUtilizadorSistema(string email)
        {
            if (ReferenceEquals(users, null)) return false;

            Utilizador util = users.Find(x => x.Email == email);

            if (ReferenceEquals(util, null)) return false;

            if (!users.Contains(util)) return false;

            users.Remove(util);

            return true;
        }

        /// <summary>
        /// Altera um email de um utilizador do sistema
        /// </summary>
        /// <param name="antigoEmail">email antigo</param>
        /// <param name="password">passowrd</param>
        /// <param name="novoEmail">novo email</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool AlterarEmailSistema(string antigoEmail, string password, string novoEmail)
        {
            if (ReferenceEquals(users, null)) return false;

            Utilizador a = users.Find(x => x.Email == antigoEmail && x.Password == password);

            if (ReferenceEquals(a, null)) return false;

            a.Email = novoEmail;
            return true;
        }

        /// <summary>
        /// Altera uma password de um utilizador do sistema
        /// </summary>
        /// <param name="email"></param>
        /// <param name="antigaPassword"></param>
        /// <param name="novaPassword"></param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool AlterarPasswordSistema(string email, string antigaPassword, string novaPassword)
        {
            if (ReferenceEquals(users, null)) return false;

            Utilizador a = users.Find(x => x.Email == email && x.Password == antigaPassword);

            if (ReferenceEquals(a, null)) return false;

            a.Password = novaPassword;
            return true;
        }


        /// <summary>
        /// Salva os dados num ficheiro
        /// </summary>
        /// <param name="nomeFicheiro">nome de ficheiro</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="IOException"possivel exceção lancada></exception>
        /// <exception cref="Exception">possivel exceção lancada</exception>
        public static bool SalvarDados(string nomeFicheiro)
        {
            try
            {
                Stream stream = File.Open(nomeFicheiro, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, users);
                stream.Close();
                return true;
            }
            catch (IOException e)
            {
                throw new IOException(e.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Carrega os dados para o programa
        /// </summary>
        /// <param name="nomeFicheiro">nome de ficheiro</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="IOException">possivel exceção lancada</exception>
        /// <exception cref="Exception">possivel exceção lancada</exception>
        public static bool CarregarDados(string nomeFicheiro)
        {
            if (File.Exists(nomeFicheiro))
            {
                try
                {
                    Stream stream = File.Open(nomeFicheiro, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    users = (List<Utilizador>)bin.Deserialize(stream);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
                    throw new IOException(e.Message);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
            return false;
        }

        /// <summary>
        /// Reinicia os atributos static
        /// </summary>
        /// <returns>true</returns>
        public static bool ReiniciarStatic()
        {
            users = new List<Utilizador>();

            return true;
        }
        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}