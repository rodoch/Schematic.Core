namespace Schematic.Core
{
    public interface ISchematicSettings
    {
        string ApplicationName { get; set; } 
        string ApplicationDescription { get; set; }
        string ApplicationIcon { get; set; }
        string ApplicationIconStyle { get; set; }
        double SetPasswordTimeLimitHours { get; set; }
        string ContactEmail { get; set; }
        EmailSettings EmailSettings { get; set; }
    }
}