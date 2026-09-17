using AIDocumentPlatform.API.Models;

namespace AIDocumentPlatform.UnitTests;

public class DocumentTests
{
    [Fact]
    public void Document_ShouldHaveFileName()
    {
        // Arrange
        var document = new Document
        {
            FileName = "research-paper.pdf"
        };

        // Act
        var fileName = document.FileName;

        // Assert
        Assert.Equal("research-paper.pdf", fileName);
    }
}