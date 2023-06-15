namespace WeatherRevamped
{
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    internal class GearItem_Awake
    {
        private static void Postfix(GearItem gi)
        {
            
        }
    }
}