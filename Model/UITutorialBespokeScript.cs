﻿// Decompiled with JetBrains decompiler
// Type: UITutorialBespokeScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C496ACE-0409-4428-BF50-DF04E26AD4C0
// Assembly location: D:\Steam\steamapps\common\Motorsport Manager\MM_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public abstract class UITutorialBespokeScript : MonoBehaviour
{
  public UITutorialBespokeScript.Activation activation;

  protected abstract void Activate();

  private void OnEnable()
  {
    if (this.activation != UITutorialBespokeScript.Activation.OnEnable)
      return;
    this.Activate();
  }

  private void OnDisable()
  {
    if (this.activation != UITutorialBespokeScript.Activation.OnDisable)
      return;
    this.Activate();
  }

  public enum Activation
  {
    OnEnable,
    OnDisable,
  }
}