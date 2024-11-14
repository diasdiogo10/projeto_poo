/*
*	<copyright file="Dados.cs" company="IPCA">
*	Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>24/10/2023</date>
*	<description></description>
*/

using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Dados
{
    /// <summary>
    /// Purpose: Vendas de classe 
    /// Created by: Diogo
    /// Created on: 24/10/2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Vendas
    {
        #region Attributes

        static List<Venda> vs; // lista de todas as vendas

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Construtor estático
        /// </summary>
        static Vendas()
        {
           vs = new List<Venda>(); 
        }

        #endregion

        #region Properties

        /// <summary>
        /// Propriedade para vendas
        /// </summary>
        public static List<Venda> VS
        {
            get { return vs; }
            
        }

        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region Other_Methods

        /// <summary>
        /// Insere uma venda nos dados das vendas
        /// </summary>
        /// <param name="v">venda</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool InserirVenda(Venda v)
        {
            if (ReferenceEquals(vs, null)) return false;

            vs.Add(v);

            return true;
        }

        /// <summary>
        /// Procura todas as vendas numa determinada data
        /// </summary>
        /// <param name="dataVenda">data de venda</param>
        /// <param name="v">vendas</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool VendasData(DateTime dataVenda, out List<Venda> v)
        {
            v = new List<Venda>();

            if (ReferenceEquals(vs, null)) return false;

            v = vs.FindAll(x => x.DataOp == dataVenda);

            if (v.Count > 0) return true;

            return false;
        }
        

        /// <summary>
        /// Salva os dados num ficheiro
        /// </summary>
        /// <param name="nomeFicheiro">nome de ficheiro</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        /// <exception cref="IOException">possivel exceção lancada</exception>
        /// <exception cref="Exception">possivel exceção lancada</exception>
        public static bool SalvarDados(string nomeFicheiro)
        {
            try
            {
                Stream stream = File.Open(nomeFicheiro, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, vs);
                stream.Close();
                return true;
            }
            catch (IOException e)
            {
                throw new IOException(e.Message);
            }
            catch(Exception e)
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
                    vs = (List<Venda>)bin.Deserialize(stream);
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
            vs = new List<Venda>();

            return true;
        }

        #endregion

        #endregion

    }
}