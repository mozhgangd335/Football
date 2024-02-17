using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations
{
    [Migration(202402171749)]
    public class _202402171749_Player : Migration
    {
        public override void Up()
        {

            Create.Table("Players")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                 .WithColumn("FullName").AsString(50).NotNullable()

                 .WithColumn("DateTime").AsDateTime().NotNullable();
                 

        }


        public override void Down()
        {
            Delete.Table("players");

        }

    }
}