using Android.Graphics;
using System;
using System.Collections.Generic;
using Android.Hardware;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Kaart;
using Android.Locations;
using Android.Util;
using Android.App;

namespace RunningApp
{
 
    public class LocatieTijd
    {
        public PointF Locatie;
        public DateTime Tijd;
        
        public LocatieTijd(PointF locatie, DateTime tijd)
        {
            Locatie = new PointF(locatie.X, locatie.Y);
            Tijd = tijd;
        
        }
    }
}
