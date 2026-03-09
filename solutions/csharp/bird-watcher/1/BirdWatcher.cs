class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => [0, 2, 5, 3, 7, 8, 4];
        
    public int Today()
    {
        int todaysIndex =  this.birdsPerDay.Length -1;
        return  this.birdsPerDay[todaysIndex];
    }

    public void IncrementTodaysCount(){
        var td = Today() + 1;
        int todaysIndex =  this.birdsPerDay.Length;
        this.birdsPerDay[todaysIndex - 1] = td;
    }

    public bool HasDayWithoutBirds()
    {
        var dayWithoutBirds = this.birdsPerDay.Any(b => b == 0);

        if(dayWithoutBirds)
        {
            return true;
        }else{
            return false;
        }
    }

    public int CountForFirstDays(int numberOfDays) => this.birdsPerDay.Take(numberOfDays).Sum();

    public int BusyDays()
    {
        return this.birdsPerDay.Where(b => b >= 5).Count();
    }
}
