﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Features.Tests._03___Order
{
    public class OrdemTestes
    {
        public static bool Teste1Chamado;
        public static bool Teste2Chamado;
        public static bool Teste3Chamado;
        public static bool Teste4Chamado;
        
        [Fact(DisplayName = "Teste 04")]
        [Trait("Categoria", "Ordenacao Testes")]
        public void Test04()
        {
            Teste4Chamado = true;

            Assert.True(Teste3Chamado);
            Assert.True(Teste1Chamado);
            Assert.False(Teste2Chamado);
        }

        [Fact(DisplayName = "Teste 03")]
        [Trait("Categoria", "Ordenacao Testes")]
        public void Test03()
        {
            Teste3Chamado = true;

            Assert.False(Teste1Chamado);
            Assert.False(Teste3Chamado);
            Assert.False(Teste4Chamado);
        }

        [Fact(DisplayName = "Teste 01")]
        [Trait("Categoria", "Ordenacao Testes")]
        public void Test01()
        {
            Teste1Chamado = true;

            Assert.True(Teste3Chamado);
            Assert.False(Teste4Chamado);
            Assert.False(Teste2Chamado);
        }

        [Fact(DisplayName = "Teste 02")]
        [Trait("Categoria", "Ordenacao Testes")]
        public void Test02()
        {
            Teste2Chamado = true;

            Assert.True(Teste3Chamado);
            Assert.True(Teste4Chamado);
            Assert.True(Teste1Chamado);
        }

    }
}