/*
*	<copyright file="Dados" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>06/12/2023 23:09:36</date>
*	<description></description>
*/


using Excecoes;
using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Dados
{
    /// <summary>
    /// Purpose: 
    /// Created by: Diogo
    /// Created on: 06/12/2023 23:09:36
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Armazem
    {
        #region Attributes

        Morada localizacao;
        static List<Produto> produtos; // conjunto de todos os produtos existentes em todos os armazens

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Construtor de classe por defeito
        /// </summary>
        public Armazem()
        {
            localizacao = new Morada();
        }

        /// <summary>
        /// Construtor de classe com atributos declarados
        /// </summary>
        /// <param name="localizacao">localizacao para a criacao do objeto</param>
        public Armazem(Morada localizacao)
        {
            this.localizacao = localizacao;
        }

        /// <summary>
        /// Construtor de classe para os atributos static(são iniciados automaticamente logo na primeira vez que é criado um objeto)
        /// </summary>
        static Armazem()
        {
            produtos = new List<Produto>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Propriedade para localizacao de um armazém
        /// </summary>
        public Morada Localizacao
        {
            get { return localizacao; }
            set { localizacao = value; }
        }

        /// <summary>
        /// Propriedade para lista de produto(produtos)
        /// </summary>
        public static List<Produto> Produtos
        {
            get { return produtos; }
        }

        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region Other_Methods

        /// <summary>
        /// Verifica se um produto existe
        /// </summary>
        /// <param name="refProd">referência de produto</param>
        /// <returns>true ou false, dependendo se existe ou não</returns>
        public static bool ExisteProdutoArmazem(int refProd)
        {
            if (ReferenceEquals(produtos, null)) return false;

            if (produtos.Exists(x => x.RefProd == refProd)) return true;

            return false;
        }

        /// <summary>
        /// Procura a quantidade de um produto
        /// </summary>
        /// <param name="refProd">referencia de produto</param>
        /// <param name="contador">quantidade</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool QuantidadeProdutoArmazem(int refProd, out int contador)
        {
            contador = 0;

            if (ReferenceEquals(produtos, null)) return false;

            Produto aux = produtos.Find(x => x.RefProd == refProd);

            contador = aux.Quantidade;

            return true;
        }

        /// <summary>
        /// Procura todos os produtos de uma marca
        /// </summary>
        /// <param name="marca">marca</param>
        /// <param name="p">produtos</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool ProdutosMarcaArmazem(string marca, out List<Produto> p)
        {
            p = new List<Produto>();

            if (ReferenceEquals(produtos, null)) return false;

            p = produtos.FindAll(x => x.Mar.Nome == marca);

            return true;
        }

        /// <summary>
        /// Procura todos os produtos de uma categoria
        /// </summary>
        /// <param name="categoria">categoria</param>
        /// <param name="p">produtos</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool ProdutosCategoriaArmazem(string categoria, out List<Produto> p)
        {
            p = new List<Produto>();

            if (ReferenceEquals(produtos, null)) return false;

            p = produtos.FindAll(x => x.Cat.Nome == categoria);

            return true;
        }

        /// <summary>
        /// Procura todos os produtos de uma marca e categoria
        /// </summary>
        /// <param name="marca">marca</param>
        /// <param name="categoria">categoria</param>
        /// <param name="p">produtos</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool ProdutosMarcaCategoriaArmazem(string marca, string categoria, out List<Produto> p)
        {
            p = new List<Produto>();

            if (ReferenceEquals(produtos, null)) return false;

            p = produtos.FindAll(x => x.Mar.Nome == marca && x.Cat.Nome == categoria);

            return true;
        }

        /// <summary>
        /// Acrescenta produtos "fisicamente" no armazém
        /// </summary>
        /// <param name="refProd">referência do produto</param>
        /// <param name="quantidade">quantidade que queremos acrescentar</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool AcrescentarProdutosArmazem(int refProd, int quantidade)
        {
            if (ReferenceEquals(produtos, null)) return false;

            Produto aux = produtos.Find(x => x.RefProd == refProd);

            if (ReferenceEquals(aux, null)) return false;

            aux.Quantidade += quantidade;

            return true;
        }

        /// <summary>
        /// Retira produtos "fiscamente" no armazém
        /// </summary>
        /// <param name="refProd">referência do produto</param>
        /// <param name="quantidade">quantidade que queremos acrescentar</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool RetirarProdutosArmazem(int refProd, int quantidade)
        {
            if (ReferenceEquals(produtos, null)) return false;

            Produto aux = produtos.Find(x => x.RefProd == refProd);

            if (ReferenceEquals(aux, null)) return false;

            if (aux.Quantidade < quantidade) return false;

            aux.Quantidade -= quantidade;

            return true;
        }

        /// <summary>
        /// Insere um produto nos dados do armazem
        /// </summary>
        /// <param name="produto">produto</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool InserirProdutoArmazem(Produto produto)
        {
            if (ReferenceEquals(produtos, null)) return false;

            if (ExisteProdutoArmazem(produto.RefProd)) return false;

            produtos.Add(produto);

            return true;
        }

        /// <summary>
        /// Remove um produto dos dados do armazem
        /// </summary>
        /// <param name="refProd">referencia de produto</param>
        /// <returns>true ou false, dependendo se correu tudo bem ou não</returns>
        public static bool RemoverProdutoArmazem(int refProd)
        {
            if (ReferenceEquals(produtos, null)) return false;

            Produto aux = produtos.Find(x => x.RefProd == refProd);

            if(ReferenceEquals(aux,null)) return false;

            produtos.Remove(aux);

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
                bin.Serialize(stream, produtos);
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
                    produtos = (List<Produto>)bin.Deserialize(stream);
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
            produtos = new List<Produto>();

            return true;
        }
        #endregion

        #endregion
    }
}