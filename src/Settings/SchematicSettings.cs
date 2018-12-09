namespace Schematic.Core
{
    public class SchematicSettings
    {
        public SchematicSettings() 
        {
            ApplicationName = "Schematic";
            ApplicationDescription = "Schematic data management system";
            SetPasswordTimeLimitHours = 24;
        }

        public string ApplicationName { get; set; }

        public string ApplicationDescription { get; set; }

        public ApplicationIconSettings ApplicationIcon { get; set; }

        public string AssetDirectory { get; set; }

        public string AssetWebPath { get; set; }

        public CloudStorageSettings CloudStorage { get; set; }

        public string ContactEmail { get; set; }

        public EmailSettings Email { get; set; }

        public double SetPasswordTimeLimitHours { get; set; }
    }
}