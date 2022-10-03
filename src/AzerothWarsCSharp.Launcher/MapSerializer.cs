using System;
using System.IO;
using System.Text.Json;
using War3Net.Build;

namespace AzerothWarsCSharp.Launcher
{
  public static class MapSerializer
  {
    private const string UnitsPath = "Units.json";
    private const string DoodadsPath = "Doodads.json";
    private const string CamerasPath = "Cameras.json";
    private const string EnvironmentPath = "Environment.json";
    private const string InfoPath = "Info.json";
    private const string RegionsPath = "Regions.json";
    private const string SoundsPath = "Sounds.json";
    private const string PathingMapPath = "PathingMap.json";
    private const string PreviewIconsPath = "PreviewIcons.json";
    private const string ShadowMapPath = "ShadowMap.json";

    private const string UnitObjectDataPath = "ObjectData/Units.json";
    private const string DoodadObjectDataPath = "ObjectData/Doodads.json";
    private const string AbilityObjectDataPath = "ObjectData/Abilities.json";
    private const string BuffObjectDataPath = "ObjectData/Buffs.json";
    private const string DestructableObjectDataPath = "ObjectData/Destructables.json";
    private const string ItemObjectDataPath = "ObjectData/Items.json";
    private const string UpgradeObjectDataPath = "ObjectData/Upgrades.json";

    private static void Write(string folderPath, string fileName, object objectToWrite, JsonSerializerOptions options)
    {
      try
      {
        var json = JsonSerializer.Serialize(objectToWrite, options);
        File.WriteAllText(Path.Join(folderPath, fileName), json);
      }
      catch
      {
        Console.WriteLine($"Warning: failed to serialize {fileName}");
      }
    }

    public static void Serialize(Map map, string folderPath)
    {
      var options = new JsonSerializerOptions { WriteIndented = true };
      Write(folderPath, UnitsPath, map.Units, options);
      Write(folderPath, DoodadsPath, map.Doodads, options);
      Write(folderPath, UnitObjectDataPath, map.UnitObjectData, options);
      Write(folderPath, DoodadObjectDataPath, map.DoodadObjectData, options);
      Write(folderPath, CamerasPath, map.Cameras, options);
      Write(folderPath, EnvironmentPath, map.Environment, options);
      Write(folderPath, InfoPath, map.Info, options);
      Write(folderPath, RegionsPath, map.Regions, options);
      Write(folderPath, SoundsPath, map.Sounds, options);
      Write(folderPath, PathingMapPath, map.PathingMap, options);
      Write(folderPath, PreviewIconsPath, map.PreviewIcons, options);
      Write(folderPath, ShadowMapPath, map.ShadowMap, options);
      Write(folderPath, AbilityObjectDataPath, map.AbilityObjectData, options);
      Write(folderPath, BuffObjectDataPath, map.BuffObjectData, options);
      Write(folderPath, DestructableObjectDataPath, map.DestructableObjectData, options);
      Write(folderPath, ItemObjectDataPath, map.ItemObjectData, options);
      Write(folderPath, UpgradeObjectDataPath, map.UpgradeObjectData, options);
    }
  }
}