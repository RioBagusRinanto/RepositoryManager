using System;
using RepositoryManagerLibrary;
using Xunit;

public class RepositoryManagerTests
{
    [Fact]
    public void Register_ValidJsonItem_ShouldStoreAndRetrieveSuccessfully()
    {
        // Arrange
        var repoManager = new RepositoryManagerLibrary.RepositoryManager();
        repoManager.Initialize();
        
        // Act
        repoManager.Register("item1", "{\"key\": \"value\"}", 1); // Register a JSON item
        
        // Retrieve the item
        var retrievedItem = repoManager.Retrieve("item1");

        // Assert
        Assert.Equal("{\"key\": \"value\"}", retrievedItem); // Assert the content is correct
    }

    [Fact]
    public void Register_ValidXmlItem_ShouldStoreAndRetrieveSuccessfully()
    {
        // Arrange
        var repoManager = new RepositoryManagerLibrary.RepositoryManager();
        repoManager.Initialize();

        // Act
        repoManager.Register("item2", "<item><key>value</key></item>", 2); // Register an XML item

        // Retrieve the item
        var retrievedItem = repoManager.Retrieve("item2");

        // Assert
        Assert.Equal("<item><key>value</key></item>", retrievedItem); // Assert the content is correct
    }
}
