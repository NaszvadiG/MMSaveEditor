﻿// Decompiled with JetBrains decompiler
// Type: TemperatureOptimisationDesignData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C496ACE-0409-4428-BF50-DF04E26AD4C0
// Assembly location: D:\Steam\steamapps\common\Motorsport Manager\MM_Data\Managed\Assembly-CSharp.dll

using FullSerializer;
using System.Xml.Serialization;

[fsObject(MemberSerialization = fsMemberSerialization.OptOut)]
public class TemperatureOptimisationDesignData : PerformanceDesignData
{
  [XmlElement("MaxTemperatureOptimisationTimeCost")]
  public float maxTemperatureOptimisationTimeCost = 0.5f;
}
