using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations
{
    [Migration(20240217)]
    public class _20240217_Team : Migration
    {

        public override void Up()
        {
            Create.Table("Teams").WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("FullName").AsString(50).NotNullable()
                .WithColumn("Firstcolor").AsInt32().NotNullable()
                .WithColumn("Secondcolor").AsInt32().NotNullable();
        }
        public override void Down()
        {
            Delete.Table("Teams");
        }
    }
}
