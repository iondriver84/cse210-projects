class OutdoorEvent: BasicEvent
{
    private string weatherForecast;

    public OutdoorEvent(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast) : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather Forecast: {weatherForecast})";
    }
    
}