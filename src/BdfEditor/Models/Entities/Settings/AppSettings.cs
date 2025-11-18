using System.IO;
using BdfEditor.Define;

namespace BdfEditor.Models.Entities.Settings;

public class AppSettings
{
    private static readonly string FilePath = Path.Combine(PathDefine.AppDataFolder, "app-settings.json");

    private static AppSettings? _instance;
    
    public static AppSettings Instance => _instance ??= Load();
    
    private static AppSettings Load()
    {
        if (File.Exists(FilePath))
        {
            var json = File.ReadAllText(FilePath);
            var appSettings = EntityConvert.JsonDeserialize<AppSettings>(json);
            if (appSettings is not null)
            {
                return appSettings;
            }
        }
        
        return new AppSettings();
    }

    public static void Save()
    {
        if (!Directory.Exists(PathDefine.AppDataFolder))
        {
            Directory.CreateDirectory(PathDefine.AppDataFolder);
        }
        
        var appSettings = Instance;
        var json = EntityConvert.JsonSerialize(appSettings);
        File.WriteAllText(FilePath, json);
    }
}
