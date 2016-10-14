Enable-Migrations -ContextTypeName ZenithContext -MigrationsDirectory Migrations\Zenith

Add-Migration -ConfigurationTypeName ZenithWebsite.Migrations.Zenith.Configuration "FirstMigration"

Update-Database -ConfigurationTypeName ZenithWebsite.Migrations.Zenith.Configuration

ApplicationDbContext
======================

Enable-Migrations -ContextTypeName ApplicationDbContext -MigrationsDirectory Migrations\Identity

Add-Migration -ConfigurationTypeName ZenithWebsite.Migrations.Identity.Configuration "FirstMigration"

Update-Database -ConfigurationTypeName ZenithWebsite.Migrations.Identity.Configuration