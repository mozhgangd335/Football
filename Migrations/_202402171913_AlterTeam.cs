using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations
{
    [Migration(202402171749)]
    public class _202402171913_AlterTeam : Migration
    {
        public override void Up()
        {
            Create.ForeignKey("Fk_Player_Teams")
                .FromTable("Players").ForeignColumn("TeamId").ToTable("Teams")
           .PrimaryColumns("Id");
        }
        public override void Down()
        {
            Delete.Column("TeamId");
        }

    }
}
