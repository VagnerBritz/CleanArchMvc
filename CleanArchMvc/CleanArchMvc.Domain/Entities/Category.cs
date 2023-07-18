using CleanArchMvc.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entities
{
    public sealed class Category
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public ICollection<Product> Products { get; private set; }
        public Category(string name)
        {
            ValidateDomain(name);
        }
        // vou precisar desse construtor quando for povoar a tabela.
        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id Values");
            Id = id;
            ValidateDomain(name);
        }
        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name is required");
            DomainExceptionValidation.When(name.Length < 3, "Invalid name, too short, minimum 3 characters");

            Name = name;
        }
    }
}
