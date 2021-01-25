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
using System.Linq;

using Android.Widget;




namespace RunningApp
{
    [Activity(Label = "Activity")]
    public class AnalyzeAct : Activity
    {
        public static TextView SnelheidView;

       

        protected override void OnCreate(Bundle b)
        {

            base.OnCreate(b);

            SnelheidView = new TextView(this);
            SnelheidView.Text = "hallo";



            SetContentView(SnelheidView);
        }
    }

    //public List<Type>(PointF, DateTime)
    //{

    //}

    public class AnalyzeView : View
    {
        public AnalyzeView(Context c) : base(c)
        {

        }

        public static bool fake;

        protected override void OnDraw(Canvas canvas)
        {
            base.OnDraw(canvas);

            if(fake == false)
                {

                float[] afstanden = new float[RunningView1.Loctijden.Count];
                for (int i = 0; i < RunningView1.Loctijden.Count; i++)
                {
                    if (i == 0) afstanden[i] = 0;
                    else
                        afstanden[i] = Afstand(RunningView1.Loctijden.ElementAt(i - 1).Locatie, RunningView1.Loctijden.ElementAt(i).Locatie);
                }

                float totaleafstand = 0;
                for (int i = 0; i < afstanden.Length; i++)
                {
                    totaleafstand += afstanden[i];
                }


                double[] tijdsverschillen = new double[RunningView1.Loctijden.Count];
                for (int i = 0; i < RunningView1.Loctijden.Count; i++)
                {
                    if (i == 0) tijdsverschillen[i] = 0;
                    else
                        tijdsverschillen[i] = Tijdsverschil(RunningView1.Loctijden.ElementAt(i - 1).Tijd, RunningView1.Loctijden.ElementAt(i).Tijd);
                }

                double totaletijd = 0;
                for (int i = 0; i < tijdsverschillen.Length; i++)
                {
                    totaletijd += tijdsverschillen[i];
                }

            }

            if(fake == true)
            {
                float[] afstanden = new float[RunningView1.Loctijden.Count];
                for (int i = 0; i < RunningView1.Loctijden.Count; i++)
                {
                    if (i == 0) afstanden[i] = 0;
                    else
                        afstanden[i] = Afstand(RunningView1.FakeLoctijden.ElementAt(i - 1).Locatie, RunningView1.Loctijden.ElementAt(i).Locatie);
                }

                float totaleafstand = 0;
                for (int i = 0; i < afstanden.Length; i++)
                {
                    totaleafstand += afstanden[i];
                }


                double[] tijdsverschillen = new double[RunningView1.Loctijden.Count];
                for (int i = 0; i < RunningView1.Loctijden.Count; i++)
                {
                    if (i == 0) tijdsverschillen[i] = 0;
                    else
                        tijdsverschillen[i] = Tijdsverschil(RunningView1.Loctijden.ElementAt(i - 1).Tijd, RunningView1.Loctijden.ElementAt(i).Tijd);
                }

                double totaletijd = 0;
                for (int i = 0; i < tijdsverschillen.Length; i++)
                {
                    totaletijd += tijdsverschillen[i];
                }
            }
        }

        public float Afstand(PointF a, PointF b)
        {

            float x = Math.Max(a.X - b.X, b.X - a.X);
            float y = Math.Max(a.Y - b.Y, b.Y - a.Y);

            return (float)Math.Sqrt((x * x) + (y * y));

        }

        public double Tijdsverschil(DateTime a, DateTime b)
        {
            return (a - b).TotalSeconds;

        }

        public float Snelheid(double totaletijd, float totaleafstand)
        {
            float x = totaleafstand / (float)totaletijd;

            AnalyzeAct.SnelheidView.Text = x.ToString();

            return x;


        }

        
    }
}

