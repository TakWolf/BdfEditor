using System;
using System.IO;

namespace BdfEditor.Define;

public static class PathDefine
{
    public static readonly string AppDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), AppDefine.Name);
}
