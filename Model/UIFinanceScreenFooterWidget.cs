﻿// Decompiled with JetBrains decompiler
// Type: UIFinanceScreenFooterWidget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C496ACE-0409-4428-BF50-DF04E26AD4C0
// Assembly location: D:\Steam\steamapps\common\Motorsport Manager\MM_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;

public class UIFinanceScreenFooterWidget : MonoBehaviour
{
  public UICharacterPortrait portrait;
  public TextMeshProUGUI nameLabel;
  public Flag flag;
  public TextMeshProUGUI seasonTarget;
  public TextMeshProUGUI seasonStatus;
  public GameObject seasonObjective;
  public GameObject seasonDeciding;
  public UIGauge happinessGauge;
  public UIJobSecurity jobSecurity;
  public UIFinanceGraphWidget graph;
  public GameObject positiveHappinessIconModifier;
  public GameObject negativeHappinessIconModifier;

  public void OnEnter()
  {
    Person chairman = (Person) Game.instance.player.team.chairman;
    Team team = Game.instance.player.team;
    this.happinessGauge.SetValueRange(0.0f, 1f);
    this.happinessGauge.SetValue(((Chairman) chairman).happinessNormalized, UIGauge.AnimationSetting.Animate);
    float happinessModifier = team.chairman.GetHappinessModifier();
    GameUtility.SetActive(this.positiveHappinessIconModifier, (double) happinessModifier > 0.0);
    GameUtility.SetActive(this.negativeHappinessIconModifier, (double) happinessModifier < 0.0);
    this.portrait.SetPortrait(chairman);
    this.nameLabel.text = chairman.name;
    this.flag.SetNationality(chairman.nationality);
    this.jobSecurity.SetJobSecurity(Game.instance.player.jobSecurity);
    GameUtility.SetActive(this.seasonObjective, team.chairman.hasSelectedExpectedPosition);
    GameUtility.SetActive(this.seasonDeciding, !team.chairman.hasSelectedExpectedPosition);
    if (this.seasonObjective.activeSelf)
    {
      bool flag1 = team.championship.eventNumber == 0;
      bool flag2 = team.championship.standings.GetEntry((Entity) team).GetCurrentChampionshipPosition() <= team.chairman.playerChosenExpectedTeamChampionshipPosition;
      this.seasonTarget.text = GameUtility.FormatForPositionOrAbove(team.chairman.playerChosenExpectedTeamChampionshipPosition, (string) null);
      this.seasonStatus.text = !flag1 ? (!flag2 ? Localisation.LocaliseID("PSG_10009313", (GameObject) null) : Localisation.LocaliseID("PSG_10009312", (GameObject) null)) : Localisation.LocaliseID("PSG_10010360", (GameObject) null);
      this.seasonStatus.color = !flag1 ? (!flag2 ? UIConstants.negativeColor : UIConstants.positiveColor) : UIConstants.whiteColor;
    }
    this.graph.OnEnter();
  }

  private void OnMouseEnter()
  {
    Chairman chairman = Game.instance.player.team.chairman;
    if (chairman.GetPersonalityTraitHappinessModifiers().Count <= 0 && chairman.happinessModificationHistory.historyEntryCount <= 0)
      return;
    UIManager.instance.dialogBoxManager.GetDialog<DriverStatsModifiersRollover>().ShowRollover(chairman);
  }

  private void OnMouseExit()
  {
    UIManager.instance.dialogBoxManager.GetDialog<DriverStatsModifiersRollover>().Hide();
  }
}
