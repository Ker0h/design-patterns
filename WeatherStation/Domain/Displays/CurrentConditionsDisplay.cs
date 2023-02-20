namespace Domain.Displays;

using Observer;

public class CurrentConditionsDisplay : IDisplayElement, IObserver
{
    private float _temperature;
    private float _humidity;
    private float _pressure;
    private ISubject _weatherData;

    public CurrentConditionsDisplay(ISubject weatherData)
    {
        this._weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    public void Update(float temperature, float humidity, float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {_temperature}F degrees and {_humidity}% humidity");
    }
}