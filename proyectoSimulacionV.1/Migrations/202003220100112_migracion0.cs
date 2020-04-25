namespace proyectoSimulacionV._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracion0 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.cliente",
                c => new
                    {
                        cod_cliente = c.Int(nullable: false, identity: true),
                        tiempo_servicio = c.Double(),
                        nombre = c.String(unicode: false),
                        cod_hora = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cod_cliente)
                .ForeignKey("dbo.hora_simulacion", t => t.cod_hora, cascadeDelete: true)
                .Index(t => t.cod_hora);
            
            CreateTable(
                "dbo.hora_simulacion",
                c => new
                    {
                        cod_hora = c.Int(nullable: false, identity: true),
                        hora = c.Int(nullable: false),
                        cod_simulacion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cod_hora)
                .ForeignKey("dbo.simulacion", t => t.cod_simulacion, cascadeDelete: true)
                .Index(t => t.cod_simulacion);
            
            CreateTable(
                "dbo.simulacion",
                c => new
                    {
                        cod_simulacion = c.Int(nullable: false, identity: true),
                        indice_simulacion = c.Int(nullable: false),
                        horas_simulacion = c.Int(nullable: false),
                        fecha = c.DateTime(nullable: false, storeType: "date"),
                        cod_escenario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cod_simulacion)
                .ForeignKey("dbo.escenario", t => t.cod_escenario, cascadeDelete: true)
                .Index(t => t.cod_escenario);
            
            CreateTable(
                "dbo.escenario",
                c => new
                    {
                        cod_escenario = c.Int(nullable: false, identity: true),
                        fecha = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.cod_escenario);
            
            CreateTable(
                "dbo.detalle_venta",
                c => new
                    {
                        cod_detalle_venta = c.Int(nullable: false, identity: true),
                        cantidad_producto = c.Int(),
                        cod_cliente = c.Int(nullable: false),
                        cod_prod_simulacion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cod_detalle_venta)
                .ForeignKey("dbo.cliente", t => t.cod_cliente, cascadeDelete: true)
                .ForeignKey("dbo.producto_simulacion", t => t.cod_prod_simulacion, cascadeDelete: true)
                .Index(t => t.cod_cliente)
                .Index(t => t.cod_prod_simulacion);
            
            CreateTable(
                "dbo.producto_simulacion",
                c => new
                    {
                        cod_prod_simulacion = c.Int(nullable: false, identity: true),
                        precio_compra = c.Double(nullable: false),
                        precio_venta = c.Double(nullable: false),
                        tiempo_preparacion = c.Double(nullable: false),
                        stock = c.Int(nullable: false),
                        cod_producto = c.Int(nullable: false),
                        cod_simulacion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cod_prod_simulacion)
                .ForeignKey("dbo.producto", t => t.cod_producto, cascadeDelete: true)
                .ForeignKey("dbo.simulacion", t => t.cod_simulacion, cascadeDelete: true)
                .Index(t => t.cod_producto)
                .Index(t => t.cod_simulacion);
            
            CreateTable(
                "dbo.producto",
                c => new
                    {
                        cod_producto = c.Int(nullable: false, identity: true),
                        precio_compra = c.Double(nullable: false),
                        nom_producto = c.String(unicode: false),
                        precio_venta = c.Double(nullable: false),
                        tiempo_preparacion = c.Double(nullable: false),
                        stock = c.Int(nullable: false),
                        habilitado = c.Boolean(nullable: false),
                        cod_tipo_producto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cod_producto)
                .ForeignKey("dbo.tipo_producto", t => t.cod_tipo_producto, cascadeDelete: true)
                .Index(t => t.cod_tipo_producto);
            
            CreateTable(
                "dbo.tipo_producto",
                c => new
                    {
                        cod_tipo_producto = c.Int(nullable: false, identity: true),
                        nombre = c.String(unicode: false),
                        habilitado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.cod_tipo_producto);
            
            CreateTable(
                "dbo.gasto_fijo",
                c => new
                    {
                        cod_gasto_fijo = c.Int(nullable: false, identity: true),
                        nombre_gasto = c.String(unicode: false),
                        valor_gasto = c.Double(nullable: false),
                        cod_escenario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cod_gasto_fijo)
                .ForeignKey("dbo.escenario", t => t.cod_escenario, cascadeDelete: true)
                .Index(t => t.cod_escenario);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.gasto_fijo", "cod_escenario", "dbo.escenario");
            DropForeignKey("dbo.detalle_venta", "cod_prod_simulacion", "dbo.producto_simulacion");
            DropForeignKey("dbo.producto_simulacion", "cod_simulacion", "dbo.simulacion");
            DropForeignKey("dbo.producto_simulacion", "cod_producto", "dbo.producto");
            DropForeignKey("dbo.producto", "cod_tipo_producto", "dbo.tipo_producto");
            DropForeignKey("dbo.detalle_venta", "cod_cliente", "dbo.cliente");
            DropForeignKey("dbo.cliente", "cod_hora", "dbo.hora_simulacion");
            DropForeignKey("dbo.hora_simulacion", "cod_simulacion", "dbo.simulacion");
            DropForeignKey("dbo.simulacion", "cod_escenario", "dbo.escenario");
            DropIndex("dbo.gasto_fijo", new[] { "cod_escenario" });
            DropIndex("dbo.producto", new[] { "cod_tipo_producto" });
            DropIndex("dbo.producto_simulacion", new[] { "cod_simulacion" });
            DropIndex("dbo.producto_simulacion", new[] { "cod_producto" });
            DropIndex("dbo.detalle_venta", new[] { "cod_prod_simulacion" });
            DropIndex("dbo.detalle_venta", new[] { "cod_cliente" });
            DropIndex("dbo.simulacion", new[] { "cod_escenario" });
            DropIndex("dbo.hora_simulacion", new[] { "cod_simulacion" });
            DropIndex("dbo.cliente", new[] { "cod_hora" });
            DropTable("dbo.gasto_fijo");
            DropTable("dbo.tipo_producto");
            DropTable("dbo.producto");
            DropTable("dbo.producto_simulacion");
            DropTable("dbo.detalle_venta");
            DropTable("dbo.escenario");
            DropTable("dbo.simulacion");
            DropTable("dbo.hora_simulacion");
            DropTable("dbo.cliente");
        }
    }
}
