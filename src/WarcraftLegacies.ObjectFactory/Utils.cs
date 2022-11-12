﻿using System;
using System.Drawing;
using System.Text;

namespace WarcraftLegacies.ObjectFactory
{
  public static class Utils
  {
    private static char[,] _hotkeyByButtonPosition = new char[,]
    {
      { 'Z', 'X', 'C', 'V' },
      { 'A', 'S', 'D', 'F' },
      { 'Q', 'W', 'E', 'R' },
    };

    public static char GetHotkeyByButtonPosition(Point buttonPosition)
    {
      throw new NotImplementedException();
      return _hotkeyByButtonPosition[buttonPosition.X, buttonPosition.Y];
    }
  }
}