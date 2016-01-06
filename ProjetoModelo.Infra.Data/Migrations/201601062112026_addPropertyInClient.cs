namespace ProjetoModelo.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPropertyInClient : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Clients", newName: "Client");
            AlterColumn("dbo.Client", "Name", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Client", "LastName", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Client", "Email", c => c.String(maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Client", "Email", c => c.String());
            AlterColumn("dbo.Client", "LastName", c => c.String());
            AlterColumn("dbo.Client", "Name", c => c.String());
            RenameTable(name: "dbo.Client", newName: "Clients");
        }
    }
}
