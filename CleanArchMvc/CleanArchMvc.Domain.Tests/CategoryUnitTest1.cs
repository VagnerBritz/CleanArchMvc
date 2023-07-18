using CleanArchMvc.Domain.Entities;
using FluentAssertions;

namespace CleanArchMvc.Domain.Tests
{
    public class CategoryUnitTest1
    {
        [Fact(DisplayName = "Create category with valid state")]
        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Category(1, "Category name");
            action.Should().NotThrow<Validation.DomainExceptionValidation>();            
        }
        [Fact(DisplayName = "Create category with valid state")]
        public void CreateCategory_WithValidParameters_ResultObjectValid()
        {
            Category category = new Category(1, "Category name");
            category.Should().NotBeNull();
            category.Id.Should().Be(1);
            category.Name.Should().Be("Category name");
        }

        [Fact(DisplayName = "Create category with invalid ID")]
        public void CreateCategory_WithNegativeId_DomainExceptionInvalidId()
        {
            Action action = () => new Category(-1, "Category name");
            action.Should().Throw<Validation.DomainExceptionValidation>().WithMessage("Invalid Id Value.");
        }
        
        [Fact(DisplayName = "Create category with invalid short name")]
        public void CreateCategory_ShortNameValue_DomainExceptionShortName()
        {
            Action action = () => new Category(1, "ca");
            action.Should().Throw<Validation.DomainExceptionValidation>().WithMessage("Invalid name, too short, minimum 3 characters.");
        }
        [Fact(DisplayName = "Create category with empty name")]
        public void CreateCategory_MissingNameValue_DomainExceptionRequiredName()
        {
            Action action = () => new Category(1, "");
            action.Should().Throw<Validation.DomainExceptionValidation>().WithMessage("Invalid name. Name is required.");
        }
    }
}