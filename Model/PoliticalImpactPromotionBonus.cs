﻿public class PoliticalImpactPromotionBonus : PoliticalImpact
{
    public bool active;
    private string inName;
    private string inEffect;

    public PoliticalImpactPromotionBonus(string inName, string inEffect)
    {
        if (inEffect == null)
            return;

        switch (inName)
        {
            case "Active":
                this.active = true;
                break;
            case "Inactive":
                this.active = false;
                break;
        }
    }
}
