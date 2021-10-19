using Xunit;
using FluentValidation.TestHelper;
using WebMotors.InfraStructure.AntiCorruption.Validator;

namespace WebMotors.InfraStructure.AntiCorruption.Tests.UnitTests
{
    public class WebmotorsMakeValidatorTest
    {
        private readonly WebmotorsMakeValidator validator = new WebmotorsMakeValidator();

        [Trait("Category", "Unit")]
        [Theory]
        [InlineData("132465")] // Name
        public void Campo_Name_Deve_Esta_Valido_Quando_Preenchido_Corretamente(string Name) => validator.ShouldNotHaveValidationErrorFor(p => p.Name, Name);



        [Trait("Category", "Unit")]
        [Fact]
        [System.Obsolete]
        public void Campo_Name_Deve_Estar_Invalido_Quando_Vazio()
        {
            validator.ShouldHaveValidationErrorFor(p => p.Name, string.Empty).WithErrorMessage("O campo Name é obrigatório");

            var nameVazio = validator;
            Assert.NotNull(nameVazio);
        }
    }

}