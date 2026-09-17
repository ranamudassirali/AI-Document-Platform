using AIDocumentPlatform.API.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace AIDocumentPlatform.UnitTests;

public class HealthControllerTests
{
    [Fact]
    public void Get_ShouldReturnOkResult()
    {
        // Arrange
        var controller = new HealthController();

        // Act
        var result = controller.Get();

        // Assert
        Assert.IsType<BadRequestObjectResult>(result);
    }
}