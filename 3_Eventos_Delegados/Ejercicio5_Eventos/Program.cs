class AlarmClock

{

    // EVENTO ONALARMRING
    public event EventHandler OnAlarmRing;

    // METODO DE CONFIGURACION
    public void SetAlarm(DateTime alarmTime)
    {
        Console.WriteLine($"Alarma configurada para: {alarmTime.ToLongTimeString()}");

        // ALCANCE DE LA HORA
        while (DateTime.Now < alarmTime)
        {
            Thread.Sleep(1000);  // ESPERA UN SEGUNDO Y VERIFICA
        }

        // Dispara el evento OnAlarmRing
        OnAlarmRing?.Invoke(this, EventArgs.Empty);
    }
}

class Program
{
    static void Main()
    {
        AlarmClock alarma = new AlarmClock();
        alarma.OnAlarmRing += HandleAlarmRing;

        DateTime horaAlarma = GetAlarmTimeFromUser();
        alarma.SetAlarm(horaAlarma);
    }

    // METODO DE LA HORA
    private static DateTime GetAlarmTimeFromUser()
    {
        Console.Write("Ingresa la hora para la alarma (en formato HH:mm:ss): ");
        string input = Console.ReadLine();

        if (TimeSpan.TryParse(input, out TimeSpan timeOfDay))
        {
            DateTime now = DateTime.Now;
            DateTime alarmTime = new DateTime(now.Year, now.Month, now.Day, timeOfDay.Hours, timeOfDay.Minutes, timeOfDay.Seconds);
            return alarmTime;
        }
        else
        {
            Console.WriteLine("Formato de hora no válido. Usa HH:mm:ss.");
            return DateTime.Now;  // EXCEPCION
        }
    }

    // AVISO DE ALARMA
    private static void HandleAlarmRing(object sender, EventArgs e)
    {
        Console.WriteLine("¡Alarma sonando!");
    }
}
