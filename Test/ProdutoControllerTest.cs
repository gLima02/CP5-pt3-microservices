using Microsoft.AspNetCore.Mvc;
using Moq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_app_domain;
using web_app_performance.Controllers;
using web_app_performance.Model;
using web_app_repository;

namespace Test
{
    public class ProdutoControllerTest
    {
        private readonly Mock<IProdutoRepository> _productRepositoryMock;
        private readonly ProdutoController _controller;

        public ProdutoControllerTest()
        {
            _productRepositoryMock = new Mock<IProdutoRepository>();
            //instancia da controller
            _controller = new ProdutoController(_productRepositoryMock.Object);
        }

        [Fact]
        public async Task Get_ListarProdutoOk()
        {
            //arrange
            var produtos = new List<Produto>() {
                new Produto()
                {
                    Id = 1,
                    nome = "Produto 1",
                    preco = 22.3,
                    quantidade_estoque = 4,
                    data_criacao = "08/08/2004"
                }

                };
            _productRepositoryMock.Setup(r => r.ListarProdutos()).ReturnsAsync(produtos);

            //Act
            var result = await _controller.GetProduto();

            //Asserts
            Assert.IsType<OkObjectResult>(result);
            var okResult = result as OkObjectResult;

            Assert.Equal(JsonConvert.SerializeObject(produtos), JsonConvert.SerializeObject(okResult.Value));
        }

    }
}

