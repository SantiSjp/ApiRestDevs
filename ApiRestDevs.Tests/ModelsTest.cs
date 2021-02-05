using ApiRestDevs.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace ApiRestDevs.Tests
{
    public class ModelsTest
    {
        [Fact]
        public void UserCreationTest()
        {
            //Arrange
            var id = 1;
            var username = "santi";
            var password = "santi";
            var role = "all";

            //Act
            var user = new User
            {
                Id = id,
                Username = username,
                Password = password,
                Role = role
            };

            //Assert

            Assert.NotNull(user);

        }

        [Fact]
        public void DevCreationTest()
        {
            //Arrange 
            var id = 1;
            var nome = "santi";
            var listaDeHoras = new List<LancamentoDeHora>();

            //Act

            var desenvolvedor = new Desenvolvedor
            {
                Id = id,
                Nome = nome,
                LancamentoDeHoras = listaDeHoras
            };

                        //Assert
            Assert.NotNull(desenvolvedor);
        }

        [Fact]
        public void ProjectCreationTest()
        {
            //Arrange
            var id = 1;
            var nome = "Meu Projeto";
            var listaDeHoras = new List<LancamentoDeHora>();

            //Act
            var projeto = new Projeto
            {
                Id = id,
                Nome = nome,
                LancamentoDeHoras = listaDeHoras
                
            };

            //Assert
            Assert.NotNull(projeto);
        }

        [Fact]
        public void LancamentoDeHoraCreation()
        {
            //Arrange
            var id = 1;
            var desenvolvedorId = 1;
            var projetoTrabalhadoId = 1;
            var desenvolvedor = new Desenvolvedor();
            var projeto = new Projeto();
            var dataDeInicio = new DateTime(2021, 1, 1);
            var dataFinal = new DateTime(2021, 1, 1);
            var qtdDeHoras = 20;

            //Act
            var lancamento = new LancamentoDeHora
            {
                Id = id,
                DesenvolvedorId = desenvolvedorId,
                ProjetoTrabalhadoId = projetoTrabalhadoId,
                Desenvolvedor = desenvolvedor,
                ProjetoTrabalhado = projeto,
                DataDeInicio = dataDeInicio,
                DataFinal = dataFinal,
                QtdHorasTrabalhadas =qtdDeHoras
            };


            //Assert
            Assert.NotNull(lancamento);
        }
    }
}
