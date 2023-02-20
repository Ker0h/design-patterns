namespace Domain;

using Observer;

public class WeatherData : ISubject
{
    public List<IObserver> Observers { get; set; }
    public float Temperature { get; set; }
    public float Humidity { get; set; }
    public float Pressure { get; set; }
    
    public WeatherData()
    {
        Observers = new List<IObserver>();
    }
    
    public void RegisterObserver(IObserver o)
    {
        Observers.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        Observers.Remove(o);
    }

    public void NotifyObservers()
    {
        foreach (var observer in Observers)
        {
            observer.Update(Temperature, Humidity, Pressure);
        }
    }
    
    private void MeasurementsChanged()
    {
        NotifyObservers();
        Console.WriteLine("Measurements changed...");
    }
    
    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
        MeasurementsChanged();
    }
}