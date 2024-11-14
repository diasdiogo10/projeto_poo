/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Diogo</author>
*   <date>06/12/2023 23:01:07</date>
*	<description></description>
*/


using System;


namespace ObjetosNegocio
{
    /// <summary>
    /// Purpose: Classe de morada
    /// Created by: Diogo
    /// Created on: 06/12/2023 23:01:07
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    [Serializable]
    public class Morada : IMorada
    {
        #region Attributes

        string cidade;
        string distrito;
        string rua;
        string codigoPostal;
        int numPorta;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Construtor de classe por defeito
        /// </summary>
        public Morada()
        {
            cidade = string.Empty;
            distrito = string.Empty;
            rua = string.Empty;
            codigoPostal = string.Empty;
            numPorta = -1;
        }

        /// <summary>
        /// Construtor de classe com os atributos declarados
        /// </summary>
        /// <param name="cidade">cidade</param>
        /// <param name="distrito">distrito</param>
        /// <param name="rua">rua</param>
        /// <param name="codigoPostal">codigo postal</param>
        /// <param name="numPorta">numero da porta</param>
        public Morada(string cidade, string distrito, string rua, string codigoPostal, int numPorta)
        {
            this.cidade = cidade;
            this.distrito = distrito;
            this.rua = rua;
            this.codigoPostal = codigoPostal;
            this.numPorta = numPorta;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Propriedade para cidade
        /// </summary>
        public string Cidade
        {
            get { return cidade; }
            set { this.cidade = value; }
        }

        /// <summary>
        /// Propriedade para distrito
        /// </summary>
        public string Distrito
        {
            get { return distrito; }
            set { this.distrito = value; }
        }

        /// <summary>
        /// Propriedade para rua
        /// </summary>
        public string Rua
        {
            get { return rua; }
            set { this.rua = value; }
        }

        /// <summary>
        /// Propriedade para numero de porta
        /// </summary>
        public int NumPorta
        {
            get { return numPorta; }
            set { numPorta = value; }
        }

        /// <summary>
        /// Propriedade para codigo postal
        /// </summary>
        public string CodigoPostal
        {
            get { return codigoPostal; }
            set { this.codigoPostal = value; }
        }


        #endregion

        #region Operators

        /// <summary>
        /// Compara a igualdade de duas moradas através dos seus parâmetros
        /// </summary>
        /// <param name="m1">morada 1</param>
        /// <param name="m2">morada 2</param>
        /// <returns>true ou false, dependendo se for igual ou não</returns>
        public static bool operator ==(Morada m1, Morada m2)
        {
            if ((m1.Cidade == m2.Cidade) && (m1.Distrito == m2.Distrito) && (m1.Rua == m2.Rua) && (m1.CodigoPostal == m2.CodigoPostal) && (m1.NumPorta == m2.NumPorta)) return true;
            return false;
        }

        /// <summary>
        /// Compara a diferenciabilidade de duas moradas através dos seus parâmetros
        /// </summary>
        /// <param name="m1">morada 1</param>
        /// <param name="m2">morada 2</param>
        /// <returns>true ou false, dependendo se for diferente ou não</returns>
        public static bool operator !=(Morada m1, Morada m2)
        {
            if (m1 == m2)   return false;
            return true;
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Devolve uma string com todas as propriedades de uma morada
        /// </summary>
        /// <returns>string final</returns>
        public override string ToString()
        {
            return String.Format("Distrito : {0} - Cidade : {1} - Rua : {2} - Código Postal : {3} - Num Porta : {4}", Distrito, Cidade, Rua, CodigoPostal, NumPorta.ToString());
        }

        /// <summary>
        /// Compara a igualdade de dois objetos
        /// </summary>
        /// <param name="obj">objeto</param>
        /// <returns>true ou false, dependendo se for igual ou não</returns>
        public override bool Equals(object obj)
        {
            if (obj is Morada)
            {
                Morada p = (Morada)obj;
                if (this == p)  return true;
            }
            return false;
        }
        #endregion

        #region Other_Methods
        #endregion

        #endregion
    }
}