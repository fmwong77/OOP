using System;


namespace OOP
{
   
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();
            text.Hyperlink("www.google.com");

            var dbMigrator = new DBMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);
            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
