// See https://aka.ms/new-console-template for more information

public interface IDisplay: IObserver
{
    void DisplayData();
    void UnSubcribe();
    void Subcribe();
}

public interface IObserver
{
    void Update(int newHumidity, int newPressure, int newTemp);
}
