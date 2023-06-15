namespace WeatherRevamped
{
    internal class RegionSettings
    {

    }
    class Region
    {
        public string Name                             = "";
        public List<WeatherStage> BlacklistedWeather   = new();
    }

    class Airfield : Region
    {
        Region.Name = "";
    }
}
