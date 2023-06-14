namespace Turnament.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Winner = c.String(),
                        Losser = c.String(),
                        IsDraw = c.Boolean(nullable: false),
                        FirstTeam_Id = c.Int(),
                        SeckondTeam_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.FirstTeam_Id)
                .ForeignKey("dbo.Teams", t => t.SeckondTeam_Id)
                .Index(t => t.FirstTeam_Id)
                .Index(t => t.SeckondTeam_Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Shortcut = c.String(),
                        VictoryNumber = c.Int(nullable: false),
                        DrawNumber = c.Int(nullable: false),
                        LossesNumber = c.Int(nullable: false),
                        Turnament_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Turnaments", t => t.Turnament_Id)
                .Index(t => t.Turnament_Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        age = c.Int(nullable: false),
                        NumberOfGames = c.Int(nullable: false),
                        Team_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .Index(t => t.Team_Id);
            
            CreateTable(
                "dbo.Referees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        age = c.Int(nullable: false),
                        NumberOfGames = c.Int(nullable: false),
                        Game_Id = c.Int(),
                        Turnament_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Games", t => t.Game_Id)
                .ForeignKey("dbo.Turnaments", t => t.Turnament_Id)
                .Index(t => t.Game_Id)
                .Index(t => t.Turnament_Id);
            
            CreateTable(
                "dbo.Turnaments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Date = c.DateTime(nullable: false),
                        TeamsNumber = c.Int(nullable: false),
                        GamesNumber = c.Int(nullable: false),
                        Winner_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Winner_Id)
                .Index(t => t.Winner_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Turnaments", "Winner_Id", "dbo.Teams");
            DropForeignKey("dbo.Teams", "Turnament_Id", "dbo.Turnaments");
            DropForeignKey("dbo.Referees", "Turnament_Id", "dbo.Turnaments");
            DropForeignKey("dbo.Games", "SeckondTeam_Id", "dbo.Teams");
            DropForeignKey("dbo.Referees", "Game_Id", "dbo.Games");
            DropForeignKey("dbo.Games", "FirstTeam_Id", "dbo.Teams");
            DropForeignKey("dbo.Players", "Team_Id", "dbo.Teams");
            DropIndex("dbo.Turnaments", new[] { "Winner_Id" });
            DropIndex("dbo.Referees", new[] { "Turnament_Id" });
            DropIndex("dbo.Referees", new[] { "Game_Id" });
            DropIndex("dbo.Players", new[] { "Team_Id" });
            DropIndex("dbo.Teams", new[] { "Turnament_Id" });
            DropIndex("dbo.Games", new[] { "SeckondTeam_Id" });
            DropIndex("dbo.Games", new[] { "FirstTeam_Id" });
            DropTable("dbo.Turnaments");
            DropTable("dbo.Referees");
            DropTable("dbo.Players");
            DropTable("dbo.Teams");
            DropTable("dbo.Games");
        }
    }
}
