using System;

namespace Shakespeare.Forms.Models
{
    /// <summary>
    /// Ugedage-enum repræsenterer alle ugens dage. Der findes allerede en DayOfWeek enum i .NET Framework,
    /// men da vi skal dem som flag, fungerede det ikke, da DayOfWeek hverken er dekoreret med [Flags] eller 
    /// er implementeret korrekt - altså at hver værdi i enum'en skal være et resultat af en potens med rod = 2.    
    /// </summary>
    [Flags]
    public enum Ugedage
    {
        // 00000000
        Ingen = 0,

        // 00000001
        Søndag = 1,

        // 00000010
        Mandag = 2,

        // 00000100
        Tirsdag = 4,

        // 00001000
        Onsdag = 8,

        // 00010000
        Torsdag = 16,

        // 00100000
        Fredag = 32,

        // 01000000
        Lørdag = 64
    }
}