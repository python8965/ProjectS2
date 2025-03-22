using Unity.Properties;
using UnityEngine;

public class UIBinding
{
    public HUD hud;
    
    [CreateProperty]
    public float Hp => hud.Hp;
    [CreateProperty]
    public int Level => hud.Level;
    [CreateProperty]
    public string Time => $"{(int)hud.GameTime / 60} : {(int)hud.GameTime % 60}";
    [CreateProperty]
    public float XPratio => hud.XP / (float)hud.GetLevelUpXP();

    public UIBinding(HUD hud)
    {
        this.hud = hud;
    }
}
