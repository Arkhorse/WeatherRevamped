namespace WeatherRevamped
{
    public class ForcastGenerator
    {
        internal static WeatherStage MorningWeather     = WeatherStage.Undefined;
        internal static WeatherStage AfternoonWeather   = WeatherStage.Undefined;
        internal static WeatherStage EveningWeather     = WeatherStage.Undefined;
        internal static WeatherStage NightWeather       = WeatherStage.Undefined;
        public void ChooseMorningWeather()
        {
            float random = UnityEngine.Random.Range(0.00f, 1.00f);
            float weatherChoice = UnityEngine.Random.Range(0, 7);

            switch (weatherChoice)
            {
                case 0:
                    if (random >= GetWeatherTypeChance(WeatherStage.DenseFog))
                    {

                    }
                    break;
                case 1:
                    if (random >= GetWeatherTypeChance(WeatherStage.LightSnow))
                    {

                    }
                    break;
                case 2:
                    if (random >= GetWeatherTypeChance(WeatherStage.HeavySnow))
                    {

                    }
                    break;
                case 3:
                    if (random >= GetWeatherTypeChance(WeatherStage.PartlyCloudy))
                    {

                    }
                    break;
                case 4:
                    if (random >= GetWeatherTypeChance(WeatherStage.Clear))
                    {

                    }
                    break;
                case 5:
                    if (random >= GetWeatherTypeChance(WeatherStage.Cloudy))
                    {

                    }
                    break;
                case 6:
                    if (random >= GetWeatherTypeChance(WeatherStage.LightFog))
                    {

                    }
                    break;
                case 7:
                    if (random >= GetWeatherTypeChance(WeatherStage.Blizzard))
                    {

                    }
                    break;
                default:
                    break;
            }
        }
        public void ChooseAfternoonWeather()
        {

        }
        public void ChooseEveningWeather()
        {

        }
        public void ChooseNightWeather()
        {

        }

        public float GetWeatherTypeChance(WeatherStage weatherStage, bool morning = true, bool afternoon = true, bool night = true, bool onlyNight = false)
        {
            bool IsMorning      = GameManager.GetUniStorm().IsMorning();
            bool IsAfternoon    = GameManager.GetUniStorm().IsAfternoon();
            bool IsEvening      = false;
            bool IsNight        = GameManager.GetUniStorm().IsNight();

            if ((night || onlyNight) && IsNight)
            {
                return 0.60f; // 60% chance for night weather
            }

            if (weatherStage == WeatherStage.Clear && (IsEvening || IsNight))
            {
                return 0.5f;
            }

            if ((weatherStage == WeatherStage.LightFog || weatherStage == WeatherStage.DenseFog) && IsMorning)
            {
                return 0.25f;
            }

            if ((weatherStage == WeatherStage.LightFog || weatherStage == WeatherStage.DenseFog) && (IsAfternoon || IsEvening))
            {
                return 0f;
            }

            return 0.1f; // 10% base chance
        }

        public void ForceWeatherChange(WeatherStage weatherStage)
        {
            if (GetWeatherTypeChance(weatherStage) == 0f)
            {
                GameManager.GetWeatherTransitionComponent().ChooseNextWeatherSet(); // TEMP, REPLACE
            }
        }
    }
}
