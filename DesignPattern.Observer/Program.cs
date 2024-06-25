using DesignPattern.Observer;

WeatherStationObservable weatherStation = new WeatherStationObservable();

weatherStation.Add(new Cockpit());
weatherStation.Add(new Terminal());

weatherStation.SetTemperature(10);

weatherStation.Add(new FoodCourt());

weatherStation.SetTemperature(15);