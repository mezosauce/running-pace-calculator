namespace running_pace_calculator.Pages;

public partial class Index
{
    private double _distanceSliderValue = 12.5;
    private string[] _runningDistanceLabels = new string[] { "2mi", "5k", "4mi", "5mi", "10k", "15k", "10mi", "Half", "Full"};
    private TimeOnly? _raceTime = null;
    private int _minutes = 9;
    private int _seconds = 30;

    protected override Task OnInitializedAsync()
    {
        UpdateRaceTime();

        return base.OnInitializedAsync();
    }

    private void OnRaceDistanceChanged(double value)
    {
        _distanceSliderValue = value;

        UpdateRaceTime();
    }

    private void OnPaceMinutesChanged(int value)
    {
        _minutes = value;

        UpdateRaceTime();
    }

    private void OnPaceSecondsChanged(int value)
    {
        _seconds = value;

        UpdateRaceTime();
    }

    private void UpdateRaceTime()
    {
        double miles = MapValueToMiles(_distanceSliderValue);

        TimeSpan timeSpan = TimeSpan.FromMinutes(_minutes) + TimeSpan.FromSeconds(_seconds);

        double ticks = timeSpan.Ticks * miles;

        _raceTime = new TimeOnly((long)ticks);
    }

    private double MapValueToMiles(double sliderValue)
    {
        switch(sliderValue)
        {
            case 0:
                return 2;
            case 12.5:
                return 3.1;
            case 25:
                return 4;
            case 37.5:
                return 5;
            case 50:
                return 6.2;
            case 62.5:
                return 9.3;
            case 75:
                return 10;
            case 87.5:
                return 13.1;
            case 100:
                return 26.1;
            default:
                return 0;
        }
    }
}
