namespace aula_wpf_14_04_2020.Infraestrutura.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Versao_1_0_0_0 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PRODUTO",
                c => new
                    {
                        CD_PRODUTO = c.Guid(nullable: false),
                        DS_PRODUTO = c.String(nullable: false, unicode: false),
                        VL_PRODUTO = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.CD_PRODUTO);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PRODUTO");
        }
    }
}
