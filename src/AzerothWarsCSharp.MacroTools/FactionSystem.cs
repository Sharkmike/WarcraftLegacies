﻿using System.Collections.Generic;
using System.Linq;
using static War3Api.Common;

namespace AzerothWarsCSharp.MacroTools
{
  public static class FactionSystem
  {
    private static readonly List<Faction> AllFactions = new();
    private static readonly List<Team> AllTeams = new();

    public static void PlayerSetFaction(player player, Faction faction)
    {
      faction.Player = player;
      foreach (var quest in faction.GetQuests())
      {
        quest.Render(player);
      }
    }
    
    public static void FactionRemoveQuest(Faction faction, Quest quest)
    {
      faction.RemoveQuest(quest);
      quest.Faction = null;
    }
    
    public static void FactionAddQuest(Faction faction, Quest quest)
    {
      faction.AddQuest(quest);
      quest.Faction = faction;

      if (faction.Player != null)
      {
        quest.Render(faction.Player);
      }
    }
    
    public static void FactionSetTeam(Faction faction, Team? team)
    {
      faction.Team = team;
      team.AddFaction(faction);
    }
    
    public static List<Faction> GetAllFactions()
    {
      return AllFactions.ToList();
    }

    public static List<Team> GetAllTeams()
    {
      return AllTeams.ToList();
    }
    
    public static void Add(Team team)
    {
      AllTeams.Add(team);
    }

    public static void Add(Faction faction)
    {
      AllFactions.Add(faction);
    }
  }
}