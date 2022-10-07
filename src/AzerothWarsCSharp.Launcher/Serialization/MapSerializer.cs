using System.IO;
using System.Text.Json;
using War3Net.Build;
using War3Net.Build.Audio;
using War3Net.Build.Environment;
using War3Net.Build.Info;
using War3Net.Build.Object;
using War3Net.Build.Widget;
using War3Net.IO.Mpq;

namespace AzerothWarsCSharp.Launcher.Serialization
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
    
    /// <summary>
    /// Reads all .json files in the input folder path and creates a Warcraft 3 map file at the specified file path.
    /// </summary>
    public static void ExportToW3X(string inputFolderPath, string outputFilePath, string assetsPath)
    {
      var map = new Map
      {
        Units = Read<MapUnits>(inputFolderPath, UnitsPath),
        Doodads = Read<MapDoodads>(inputFolderPath, DoodadsPath),
        UnitObjectData = Read<UnitObjectData>(inputFolderPath, UnitObjectDataPath),
        DoodadObjectData = Read<DoodadObjectData>(inputFolderPath, DoodadObjectDataPath),
        Cameras = Read<MapCameras>(inputFolderPath, CamerasPath),
        Environment = Read<MapEnvironment>(inputFolderPath, EnvironmentPath),
        Info = Read<MapInfo>(inputFolderPath, InfoPath),
        Regions = Read<MapRegions>(inputFolderPath, RegionsPath),
        Sounds = Read<MapSounds>(inputFolderPath, SoundsPath),
        PathingMap = Read<MapPathingMap>(inputFolderPath, PathingMapPath),
        PreviewIcons = Read<MapPreviewIcons>(inputFolderPath, PreviewIconsPath),
        ShadowMap = Read<MapShadowMap>(inputFolderPath, ShadowMapPath),
        AbilityObjectData = Read<AbilityObjectData>(inputFolderPath, AbilityObjectDataPath),
        BuffObjectData = Read<BuffObjectData>(inputFolderPath, BuffObjectDataPath),
        DestructableObjectData = Read<DestructableObjectData>(inputFolderPath, DestructableObjectDataPath),
        ItemObjectData = Read<ItemObjectData>(inputFolderPath, ItemObjectDataPath),
        UpgradeObjectData = Read<UpgradeObjectData>(inputFolderPath, UpgradeObjectDataPath)
      };
      
      var archiveCreateOptions = new MpqArchiveCreateOptions
      {
        BlockSize = 3,
        AttributesCreateMode = MpqFileCreateMode.Overwrite,
        ListFileCreateMode = MpqFileCreateMode.Overwrite
      };
      
      var mapBuilder = new MapBuilder(map);
      mapBuilder.AddFiles(assetsPath, "*", SearchOption.AllDirectories);
      mapBuilder.Build(outputFilePath, archiveCreateOptions);
    }
    
    /// <summary>
    /// Reads the provided map and exports it to many .json files at the specified folder path.
    /// </summary>
    public static void ExportToJson(Map map, string folderPath)
    {
      var options = new JsonSerializerOptions { WriteIndented = true, IgnoreReadOnlyProperties = true};
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
    
    private static void Write(string folderPath, string fileName, object objectToWrite, JsonSerializerOptions options)
    {
      var json = JsonSerializer.Serialize(objectToWrite, options);
      File.WriteAllText(Path.Join(folderPath, fileName), json);
    }

    private static T Read<T>(string folderPath, string fileName, JsonSerializerOptions options = null)
    {
      return JsonSerializer.Deserialize<T>(File.ReadAllText(Path.Combine(folderPath, fileName)), options);
    }
  }
}