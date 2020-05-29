using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    [Serializable]
    class Fahrzeug
    {
        private String strKennzeichen;
        private String strEinrichtung;
        private String strFahrzeugtyp;
        private int iMandant;
        private int iKostenstelle;
        private DateTime dtErstzulassung;
        private String strWartungsfirma;
        private String strBesonderheiten;
        private String strVerantwortung;
        private String strStandort;
        private DateTime dtAblaufdatum;
        private DateTime dtNeubeschaffung;
        private int iLeasinglaufzeit;
        private int iLeasinglaufleistung;
    }
}
