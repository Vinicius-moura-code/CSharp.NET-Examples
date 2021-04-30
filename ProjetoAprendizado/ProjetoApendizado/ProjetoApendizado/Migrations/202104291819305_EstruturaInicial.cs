namespace ProjetoApendizado.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EstruturaInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sexos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Idade = c.Int(nullable: false),
                        DatadeNascimeto = c.DateTime(nullable: false),
                        IdSexo = c.Int(nullable: false),
                        Cpf = c.String(nullable: false),
                        DataInclusao = c.DateTime(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sexos", t => t.IdSexo, cascadeDelete: true)
                .Index(t => t.IdSexo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "IdSexo", "dbo.Sexos");
            DropIndex("dbo.Usuarios", new[] { "IdSexo" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Sexos");
        }
    }
}
