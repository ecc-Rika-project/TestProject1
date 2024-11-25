using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class ProductServiceTests
{
    [Fact]
    public void UpdatePrice_ShouldReturnTrue_WhenProductExistsAndPriceIsValid()
    {
        // Arrange
        var mockRepo = new Mock<IProductRepository>();
        mockRepo.Setup(repo => repo.UpdatePrice(1, 2000)).Returns(true);

        var service = new ProductService(mockRepo.Object);

        // Act
        var result = service.UpdatePrice(1, 2000);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void UpdatePrice_ShouldReturnFalse_WhenProductDoesNotExist()
    {
        // Arrange
        var mockRepo = new Mock<IProductRepository>();
        mockRepo.Setup(repo => repo.UpdatePrice(99, 2000)).Returns(false);

        var service = new ProductService(mockRepo.Object);

        // Act
        var result = service.UpdatePrice(99, 2000);

        // Assert
        Assert.False(result);
    }
}

