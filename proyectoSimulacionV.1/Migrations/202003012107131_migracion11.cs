namespace proyectoSimulacionV._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracion11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.producto", "nom_producto", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.producto", "nom_producto");
        }
    }
}
