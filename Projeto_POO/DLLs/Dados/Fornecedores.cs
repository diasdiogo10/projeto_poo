/*
*	<copyright file="Dados.cs" company="IPCA">
*	Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>24/10/2023</date>
*	<description></description>
*/

using Excecoes;
using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;

namespace Dados
{
    /// <summary>
    /// Purpose: Fornecedores de classe 
    /// Created by: Diogo
    /// Created on: 24/10/2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Fornecedores
    {
        #region Attributes

        static List<Fornecedor> forns;
        static int totProd; // Ultima referencia de todos os produtos de todos os fornecedores

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Construtor estatico
        /// </summary>
        static Fornecedores()
        {
            forns = new List<Fornecedor>();
            totProd = 0;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Propriedade para fornecedores
        /// </summary>
        public static List<Fornecedor> Forns 
        { 
            get { return forns; }
        }

        /// <summary>
        /// Propriedade para total de produtos
        /// </summary>
        public static int TotProd
        {
            get { return totProd; }
        }

        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region Other_Methods

        /// <summary>
        /// Inicializa o atributo totProd após o carregamento com a ref de produto mais alta
        /// </summary>
        /// <param name="tot">ref de produto mais alta</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool InicializarTotProd(out int tot)
        {
            tot = 0;

            if (ReferenceEquals(forns, null)) return false;

            foreach (Fornecedor f in forns)
            {
                if (ReferenceEquals(f.Prods, null)) continue;

                if (f.Prods.Max(x => x.RefProd) > tot) tot = f.Prods.Max(x => x.RefProd);
            }

            return true;
        }

        /// <summary>
        /// Verifica se existe um produto nos fornecedores ou não
        /// </summary>
        /// <param name="nomeProd">nome do produto</param>
        /// <returns>true ou false, dependendo se existe ou não</returns>
        public static bool ExisteProdutoFornecedores(string nomeProd)
        {
            if (ReferenceEquals(forns, null)) return false;

            foreach (Fornecedor f in forns)
            {
                if (ReferenceEquals(f.Prods, null)) continue;

                if (f.Prods.Exists(x => x.Nome == nomeProd)) return true;
            }

            return false;
        }

        /// <summary>
        /// Verifica se existe um produto num certo fornecedor ou não
        /// </summary>
        /// <param name="nomeProd">nome do produto</param>
        /// <param name="nomeForn">nome do fornecedor</param>
        /// <returns>true ou false, dependendo se existe ou não</returns>
        public static bool ExisteProdutoFornecedor(string nomeProd, string nomeForn)
        {
            if (ReferenceEquals(forns, null)) return false;

            Fornecedor f = forns.Find(x => x.Nome == nomeForn);

            if(ReferenceEquals(f, null)) return false;

            if(ReferenceEquals(f.Prods,null)) return false;

            if (f.Prods.Exists(x => x.Nome == nomeProd)) return true;

            return false;
        }

        /// <summary>
        /// Dá uma referência de um produto já existente
        /// </summary>
        /// <param name="nomeProd">nome do produto</param>
        /// <param name="refNova">referencia nova</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool DarReferencia(string nomeProd, out int refNova)
        {
            refNova = 0;

            if (ReferenceEquals(forns, null)) return false;

            foreach (Fornecedor f in forns)
            {
                if (ReferenceEquals(f.Prods, null)) continue;

                if (!ExisteProdutoFornecedor(nomeProd, f.Nome)) continue;

                Produto aux = f.Prods.Find(x => x.Nome == nomeProd);

                refNova = aux.RefProd;

                return true;
            }

            return false;
        }

        /// <summary>
        /// Insere um produto nos Fornecedores
        /// </summary>
        /// <param name="prod">produto</param>
        /// <param name="nomeForn">nome do fornecedor</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool InserirProdutoFornecedor(Produto prod, string nomeForn)
        {
            if (!ExisteFornecedorSistema(nomeForn)) return false;

            if (ExisteProdutoFornecedor(prod.Nome, nomeForn)) return false;

            if (ExisteProdutoFornecedores(prod.Nome))
            {

                if (!DarReferencia(prod.Nome, out int refNova)) return false;

                prod.RefProd = refNova;
            }
            else prod.RefProd = ++totProd;

            Fornecedor f = forns.Find(x => x.Nome == nomeForn);

            if (ReferenceEquals(f.Prods, null)) f.Prods = new List<Produto>();

            f.Prods.Add(prod);

            return true;
        }

        /// <summary>
        /// Remove um produto de um fornecedor
        /// </summary>
        /// <param name="nomeProd">nome do produto</param>
        /// <param name="nomeForn">nome do fornecedor</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool RemoverProdutoFornecedor(string nomeProd, string nomeForn)
        {
            if (!ExisteFornecedorSistema(nomeForn)) return false;

            if (!ExisteProdutoFornecedor(nomeProd, nomeForn)) return false;

            Fornecedor f = forns.Find(x => x.Nome == nomeForn);

            f.Prods.Remove(f.Prods.Find(x => x.Nome == nomeProd));

            return true;
        }

        /// <summary>
        /// Verifica se existe um fornecedor
        /// </summary>
        /// <param name="nome">nome</param>
        /// <returns>true ou false, dependendo se existe ou não</returns>
        public static bool ExisteFornecedorSistema(string nome)
        {
            if (forns == null) return false;

            if (forns.Exists(x => x.Nome == nome)) return true;

            return false;
        }

        /// <summary>
        /// Insere um fornecedor
        /// </summary>
        /// <param name="forn">fornecedor</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool InserirFornecedorSistema(Fornecedor forn)
        {
            if (ReferenceEquals(forns, null)) return false;

            if (forns.Contains(forn)) return false;

            forns.Add(forn);

            return true;
        }

        /// <summary>
        /// Remove um fornecedor
        /// </summary>
        /// <param name="nome">nome</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool RemoverFornecedorSistema(string nome)
        {
            if (ReferenceEquals(forns, null)) return false;

            Fornecedor forn = forns.Find(x => x.Nome == nome);

            if (ReferenceEquals(forn, null)) return false;

            if (!forns.Contains(forn)) return false;

            forns.Remove(forn);

            return true;
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
                bin.Serialize(stream, forns);
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
                    forns = (List<Fornecedor>)bin.Deserialize(stream);
                    stream.Close();

                    InicializarTotProd(out totProd);

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
            forns = new List<Fornecedor>();
            totProd = 0;

            return true;
        }

        #endregion

        #endregion

    }
}