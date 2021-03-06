namespace BotDBService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ac : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BOT_ANSWER",
                c => new
                    {
                        ANSWER_ID = c.Int(nullable: false, identity: true),
                        CONTENT = c.String(nullable:false,maxLength:500),
                        QUESTION_ID = c.Int(),
                        PREVANSWER_ID = c.Int(),
                        IS_END = c.Boolean(),
                        RECORD_STATUS = c.Int(),
                    })
                .PrimaryKey(t => t.ANSWER_ID);
            
            CreateTable(
                "dbo.BOT_CUSTOMERINFO",
                c => new
                    {
                        CUSTOMER_ID = c.Int(nullable: false, identity: true),
                        DOMAIN_ID = c.Int(),
                        DOMAIN_NAME = c.String(nullable:false,maxLength:100),
                        NAME = c.String(nullable: false, maxLength: 100),
                        EMAIL = c.String(nullable: false, maxLength: 100),
                        PHONE = c.String(nullable: false, maxLength: 20),
                        RECORD_STATUS = c.Int(),
                    })
                .PrimaryKey(t => t.CUSTOMER_ID);
            
            CreateTable(
                "dbo.BOT_DOMAIN",
                c => new
                    {
                        DOMAIN_ID = c.Int(nullable: false, identity: true),
                        DOMAIN = c.String(nullable: false, maxLength: 100),
                        RECORD_STATUS = c.Int(),
                    })
                .PrimaryKey(t => t.DOMAIN_ID);
            
            CreateTable(
                "dbo.BOT_FORMTYPE",
                c => new
                    {
                        FORM_ID = c.Int(nullable: false, identity: true),
                        FROM_NAME = c.String(nullable: false, maxLength: 100),
                        DOMAIN_ID = c.Int(),
                        DOMAIN_NAME = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.FORM_ID);
            
            CreateTable(
                "dbo.BOT_QUESTION",
                c => new
                    {
                        QUESTION_ID = c.Int(nullable: false, identity: true),
                        CONTENT = c.String(nullable: false, maxLength: 500),
                        QUESTION_TYPE = c.Int(),
                        SCENARIO_ID = c.Int(),
                        DOMAIN_ID = c.Int(),
                        DOMAIN_NAME = c.String(nullable: false, maxLength: 100),
                        PREVQUESTION_ID = c.Int(),
                        IS_END = c.Boolean(),
                        RECORD_STATUS = c.Int(),
                        PREVANSWER_ID = c.Int(),
                    })
                .PrimaryKey(t => t.QUESTION_ID);
            
            CreateTable(
                "dbo.BOT_QUESTIONTYPE",
                c => new
                    {
                        QUESTIONTYPE_ID = c.Int(nullable: false, identity: true),
                        QUESTION_TYPE = c.String(nullable: false, maxLength: 100),
                        RECORD_STATUS = c.Int(),
                    })
                .PrimaryKey(t => t.QUESTIONTYPE_ID);
            
            CreateTable(
                "dbo.BOT_SCENARIO",
                c => new
                    {
                        SCENARIO_ID = c.Int(nullable: false, identity: true),
                        NAME = c.String(nullable: false, maxLength: 100),
                        DOMAIN_ID = c.Int(),
                        DOMAIN_NAME = c.String(nullable: false, maxLength: 100),
                        IS_ACTIVE = c.Boolean(),
                        RECORD_STATUS = c.Int(),
                    })
                .PrimaryKey(t => t.SCENARIO_ID);
            
            CreateTable(
                "dbo.BOT_USER",
                c => new
                    {
                        USERID = c.Int(nullable: false, identity: true),
                        USERNAME = c.String(nullable: false, maxLength: 50),
                        PASSWORD = c.String(nullable: false, maxLength: 100),
                        RECORD_STATUS = c.Int(),
                    })
                .PrimaryKey(t => t.USERID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BOT_USER");
            DropTable("dbo.BOT_SCENARIO");
            DropTable("dbo.BOT_QUESTIONTYPE");
            DropTable("dbo.BOT_QUESTION");
            DropTable("dbo.BOT_FORMTYPE");
            DropTable("dbo.BOT_DOMAIN");
            DropTable("dbo.BOT_CUSTOMERINFO");
            DropTable("dbo.BOT_ANSWER");
        }
    }
}
