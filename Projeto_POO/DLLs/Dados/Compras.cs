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
    /// Purpose: Compras de classe 
    /// Created by: Diogo
    /// Created on: 24/10/2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Compras
    {
        #region Attributes

        static List<Compra> cs; // lista de todas as compras
        #endregion

        #region Methods

        #region Constructors
        /// <summary>
        /// Construtor estático
        /// </summary>
        static Compras()
        {
            cs = new List<Compra>();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Propriedade para compras
        /// </summary>
        public static List<Compra> VS
        {
            get { return cs; }

        }
        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region Other_Methods

        /// <summary>
        /// Insere uma compra nos dados das compras
        /// </summary>
        /// <param name="c">compra</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool InserirCompra(Compra c)
        {
            if (ReferenceEquals(cs, null)) return false;

            cs.Add(c);

            return true;
        }

        /// <summary>
        /// Procura todas as compras numa determinada data
        /// </summary>
        /// <param name="dataCompra">data de compra</param>
        /// <param name="c">compras</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool ComprasData(DateTime dataCompra, out List<Compra> c)
        {
            c = new List<Compra>();

            if (ReferenceEquals(cs, null)) return false;

            c = cs.FindAll(x => x.DataOp == dataCompra);

            if (c.Count > 0) return true;

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
                bin.Serialize(stream, cs);
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
                    cs = (List<Compra>)bin.Deserialize(stream);
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
            cs = new List<Compra>();

            return true;
        }
        #endregion

        #endregion

    }
}