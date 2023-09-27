using FluentAssertions;
using SudokuKata;

namespace SudokuKataTests
{
    public class SudokuTests
    {
        [Fact]
        public void AcceptanceTest_GoodFile()
        {
            // Arrange
            FileReader fileReader = new();
            Parser parser = new();
            Validator validator = new();
            string path = "";

            var file = fileReader.Read(path);
            int[][] data = parser.Parse(file);

            // Act
            var success = validator.Validate(data);

            // Assert
            success.Should().Be(true);
        }
    }
}