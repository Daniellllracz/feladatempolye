namespace feladatempolye
{
    internal class ProgramBase
    {
        static void Main(string[] args)
        {
            //1.Készíts egy osztályt, amely tartalmazza a szükséges mezőket. Nem kötelező kidolgozni a property - ket.

            //2.Írd meg a konstruktort.

            //3.Készíts egy osztályon belüli virtuális metódust az adatok kiírására.

            //4.Propertyk kidolgozása(Szorgalmi feladat)
            //Dolgozd ki a property-ket is, és használd őket az adatokhoz való korrekt hozzáférésre és módosításra.

            //5.Hibakezelés(Szorgalmi feladat)
            //Implementálj hibakezelést az alkalmazásban, például az adatok beolvasásakor vagy a fájlba írás során.

            //6.Az osztály segítségével hozz létre egy listát, amely objektumpéldányokat tartalmaz a forrásfájlból beolvasott adatokkal.
            var adatok = new List<Osztaly>();
            var sr = new StreamReader(
                path: @"..\..\..\src\Adatok.txt",
                encoding: System.Text.Encoding.UTF8);

            while (!sr.EndOfStreamException)
            {
                public override string ToString()
        {
            return base.ToString();
        }
    }
}