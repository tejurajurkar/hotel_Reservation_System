namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class projectcontext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.admins",
                c => new

                    {
                        adminid = c.Int(nullable: false, identity: true),
                        adminname = c.String(nullable: false),
                        email = c.String(nullable: false),
                        phone = c.String(nullable: false),
                        pass = c.String(nullable: false),
                        confpass = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.adminid);
            
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        bookingid = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        roomtype = c.String(nullable: false),
                        checkin = c.DateTime(nullable: false),
                        noofnight = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.bookingid);
            
            CreateTable(
                "dbo.Registers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        FName = c.String(nullable: false),
                        LName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        ValidId = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Pass = c.String(nullable: false),
                        ConfPass = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        roomtype = c.String(nullable: false, maxLength: 128),
                        price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.roomtype);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Rooms");
            DropTable("dbo.Registers");
            DropTable("dbo.Bookings");
            DropTable("dbo.admins");
        }
    }
}
