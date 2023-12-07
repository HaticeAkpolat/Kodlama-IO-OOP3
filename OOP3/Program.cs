using OOP3;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        //Bu şekilde yazılması ile aşağıdaki gibi yazılması arasında bir fark yoktur!!!!!
        //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
        //ihtiyacKrediManager.Hesapla();

        //TasitKrediManager tasitKrediManager = new TasitKrediManager();
        //tasitKrediManager.Hesapla();

        //KonutKrediManager konutKrediManager = new KonutKrediManager();
        //konutKrediManager.Hesapla();

        IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
        //ihtiyacKrediManager.Hesapla();

        IKrediManager tasitKrediManager = new TasitKrediManager();
        //tasitKrediManager.Hesapla();

        IKrediManager konutKrediManager = new KonutKrediManager();
        //konutKrediManager.Hesapla();
        ILoggerService fileLoggerService = new FileLoggerService();
        ILoggerService databaseLoggerService = new DatabaseLoggerService();

        BasvuruManager basvuruManager = new BasvuruManager();
        List<ILoggerService> loggerServices = new List<ILoggerService>() { databaseLoggerService,fileLoggerService};
        basvuruManager.BasvuruYap(tasitKrediManager,loggerServices);

        List<IKrediManager> krediler = new List<IKrediManager>() {tasitKrediManager ,konutKrediManager};
        //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

    }
}