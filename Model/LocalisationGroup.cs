﻿// Decompiled with JetBrains decompiler
// Type: LocalisationGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C496ACE-0409-4428-BF50-DF04E26AD4C0
// Assembly location: D:\Steam\steamapps\common\Motorsport Manager\MM_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;

public class LocalisationGroup
{
  public List<LocalisationEntry> entries = new List<LocalisationEntry>();

  public string GetName()
  {
    if (this.entries.Count > 0)
      return this.entries[0].group;
    return string.Empty;
  }
}
