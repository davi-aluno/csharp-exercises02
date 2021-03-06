﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CalcularFrete
{
    class Compras
    {
        private string _nome;
        private string _tipo;
        private string _preco;

        public Compras(string nome, string tipo, string preco)
        {
            this._nome = nome;
            this._tipo = tipo;
            this._preco = preco;
        }

        public string nome
        {
            get => _nome;
        }

        public string tipo
        {
            get => _tipo;
        }

        public string preco
        {
            get => _preco;
        }
    }
}
