﻿using FluentValidation.TestHelper;
using WebMotors.InfraStructure.AntiCorruption.Validator;
using Xunit;

namespace WebMotors.Tests.UnitTests
{
    public class WebmotorsVersionsValidatorTest
    {
        private readonly WebmotorsVersionValidator validator = new WebmotorsVersionValidator();

        [Trait("Category", "Unit")]
        [Theory]
        [InlineData("132465")] // Name
        [System.Obsolete]
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
