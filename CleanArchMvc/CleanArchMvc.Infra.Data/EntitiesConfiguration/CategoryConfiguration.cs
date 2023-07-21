using CleanArchMvc.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchMvc.Infra.Data.EntitiesConfiguration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            // Uma forma de povoar a tabela quando rodar a migration.
            builder.HasData(
                new Category(1, "Material escolar"),
                new Category(2, "Eletrônicos"),
                new Category(3, "Acessorios")
                );
        }
    }
}
/* Problemas  (por estes motivos fazemos essa configuração)
  O EF na abordagem code first segue convencões para gerar banco de dados e as tabelas e isso gera alguns problemas
  por default as strings são mapeadas para as colunas do tipo nvarchar(max) e nullable == true - Não queremos isso nesse projeto
  O tipo decimal sera mapeadopara um coluna do tipo decimal(18,2) e será emitido um alerta para perda de dados por problemas de precisão
 */
