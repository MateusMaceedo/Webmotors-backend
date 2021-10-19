using FluentValidation.TestHelper;
using WebMotors.InfraStructure.AntiCorruption.Validator;
using Xunit;

namespace WebMotors.Tests.UnitTests
{
    public class WebmotorsVehiclesValidatorTest
    {
        private readonly WebmotorsVehiclesValidator validator = new WebmotorsVehiclesValidator();

        [Trait("Category", "Unit")]
        [Theory]
        [InlineData("132465")] // Make
        [System.Obsolete]
        public void Campo_Make_Deve_Esta_Valido_Quando_Preenchido_Corretamente(string Make) => validator.ShouldNotHaveValidationErrorFor(p => p.Make, Make);



        [Trait("Category", "Unit")]
        [Fact]
        [System.Obsolete]
        public void Campo_Name_Deve_Estar_Invalido_Quando_Vazio()
        {
            validator.ShouldHaveValidationErrorFor(p => p.Make, string.Empty).WithErrorMessage("O campo Make é obrigatório");

            var makeVazio = validator;
            Assert.NotNull(makeVazio);
        }

        [Trait("Category", "Unit")]
        [Theory]
        [InlineData("132465")] // Model
        [System.Obsolete]
        public void Campo_Model_Deve_Esta_Valido_Quando_Preenchido_Corretamente(string Model) => validator.ShouldNotHaveValidationErrorFor(p => p.Model, Model);



        [Trait("Category", "Unit")]
        [Fact]
        [System.Obsolete]
        public void Campo_Model_Deve_Estar_Invalido_Quando_Vazio()
        {
            validator.ShouldHaveValidationErrorFor(p => p.Model, string.Empty).WithErrorMessage("O campo Model é obrigatório");

            var modelVazio = validator;
            Assert.NotNull(modelVazio);
        }

        [Trait("Category", "Unit")]
        [Theory]
        [InlineData("132465")] // Version
        [System.Obsolete]
        public void Campo_Version_Deve_Esta_Valido_Quando_Preenchido_Corretamente(string Version) => validator.ShouldNotHaveValidationErrorFor(p => p.Version, Version);



        [Trait("Category", "Unit")]
        [Fact]
        [System.Obsolete]
        public void Campo_Version_Deve_Estar_Invalido_Quando_Vazio()
        {
            validator.ShouldHaveValidationErrorFor(p => p.Version, string.Empty).WithErrorMessage("O campo Version é obrigatório");

            var versionVazio = validator;
            Assert.NotNull(versionVazio);
        }


        [Trait("Category", "Unit")]
        [Theory]
        [InlineData("132465")] // Image
        [System.Obsolete]
        public void Campo_Image_Deve_Esta_Valido_Quando_Preenchido_Corretamente(string Image) => validator.ShouldNotHaveValidationErrorFor(p => p.Image, Image);



        [Trait("Category", "Unit")]
        [Fact]
        [System.Obsolete]
        public void Campo_Image_Deve_Estar_Invalido_Quando_Vazio()
        {
            validator.ShouldHaveValidationErrorFor(p => p.Image, string.Empty).WithErrorMessage("O campo Image é obrigatório");

            var imageVazio = validator;
            Assert.NotNull(imageVazio);
        }


        [Trait("Category", "Unit")]
        [Theory]
        [InlineData("132465")] // Price
        [System.Obsolete]
        public void Campo_Price_Deve_Esta_Valido_Quando_Preenchido_Corretamente(string Price) => validator.ShouldNotHaveValidationErrorFor(p => p.Price, Price);



        [Trait("Category", "Unit")]
        [Fact]
        [System.Obsolete]
        public void Campo_Price_Deve_Estar_Invalido_Quando_Vazio()
        {
            validator.ShouldHaveValidationErrorFor(p => p.Price, string.Empty).WithErrorMessage("O campo Price é obrigatório");

            var priceVazio = validator;
            Assert.NotNull(priceVazio);
        }


        [Trait("Category", "Unit")]
        [Theory]
        [InlineData("132465")] // Color
        [System.Obsolete]
        public void Campo_Color_Deve_Esta_Valido_Quando_Preenchido_Corretamente(string Color) => validator.ShouldNotHaveValidationErrorFor(p => p.Color, Color);



        [Trait("Category", "Unit")]
        [Fact]
        [System.Obsolete]
        public void Campo_Color_Deve_Estar_Invalido_Quando_Vazio()
        {
            validator.ShouldHaveValidationErrorFor(p => p.Color, string.Empty).WithErrorMessage("O campo Color é obrigatório");

            var colorVazio = validator;
            Assert.NotNull(colorVazio);
        }
    }
}
