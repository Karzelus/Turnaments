namespace Turnament.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Referees", "Game_Id", "dbo.Games");
            DropIndex("dbo.Referees", new[] { "Game_Id" });
            RenameColumn(table: "dbo.Games", name: "SeckondTeam_Id", newName: "SecondTeam_Id");
            RenameIndex(table: "dbo.Games", name: "IX_SeckondTeam_Id", newName: "IX_SecondTeam_Id");
            AddColumn("dbo.Games", "Referee_Id", c => c.Int());
            AddColumn("dbo.Teams", "LossesGoals", c => c.Int(nullable: false));
            AddColumn("dbo.Teams", "ScoredGoals", c => c.Int(nullable: false));
            AddColumn("dbo.Teams", "Image", c => c.String());
            AddColumn("dbo.Players", "NumberOfGoals", c => c.Int(nullable: false));
            CreateIndex("dbo.Games", "Referee_Id");
            AddForeignKey("dbo.Games", "Referee_Id", "dbo.Referees", "Id");
            DropColumn("dbo.Games", "IsDraw");
            DropColumn("dbo.Teams", "DrawNumber");
            DropColumn("dbo.Players", "NumberOfGames");
            DropColumn("dbo.Referees", "Game_Id");
            DropColumn("dbo.Turnaments", "GamesNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Turnaments", "GamesNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Referees", "Game_Id", c => c.Int());
            AddColumn("dbo.Players", "NumberOfGames", c => c.Int(nullable: false));
            AddColumn("dbo.Teams", "DrawNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Games", "IsDraw", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.Games", "Referee_Id", "dbo.Referees");
            DropIndex("dbo.Games", new[] { "Referee_Id" });
            DropColumn("dbo.Players", "NumberOfGoals");
            DropColumn("dbo.Teams", "Image");
            DropColumn("dbo.Teams", "ScoredGoals");
            DropColumn("dbo.Teams", "LossesGoals");
            DropColumn("dbo.Games", "Referee_Id");
            RenameIndex(table: "dbo.Games", name: "IX_SecondTeam_Id", newName: "IX_SeckondTeam_Id");
            RenameColumn(table: "dbo.Games", name: "SecondTeam_Id", newName: "SeckondTeam_Id");
            CreateIndex("dbo.Referees", "Game_Id");
            AddForeignKey("dbo.Referees", "Game_Id", "dbo.Games", "Id");
        }
    }
}
