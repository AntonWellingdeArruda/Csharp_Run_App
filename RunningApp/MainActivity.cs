using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Content.PM;
using System;
using Android.Views;


namespace RunningApp
{
    [Activity(Label = "RunApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button centreerknop, startknop, verwijderknop, shareknop, analyzeknop;
        RunningView1 plaatje;


        protected override void OnCreate(Bundle b)
        {
            base.OnCreate(b);

            plaatje = new RunningView1(this);

            this.centreerknop = new Button(this);
            this.centreerknop.Text = "Centreer";
            this.centreerknop.Click += plaatje.Centreer;

            this.startknop = new Button(this);
            this.startknop.Text = "Start";
            this.startknop.Click += plaatje.Start;

            this.verwijderknop = new Button(this);
            this.verwijderknop.Text = "Verwijder";

            this.shareknop = new Button(this);
            this.shareknop.Text = "Share";
            this.shareknop.Click += plaatje.Deel;
   
            this.analyzeknop = new Button(this);
            this.analyzeknop.Text = "Analyze";
            this.analyzeknop.Click += plaatje.Analyze;


            LinearLayout rij;
            rij = new LinearLayout(this);
            rij.Orientation = Orientation.Horizontal;

            rij.AddView(centreerknop);
            rij.AddView(startknop);
            rij.AddView(verwijderknop);
            rij.AddView(shareknop);
            rij.AddView(analyzeknop);



            LinearLayout stapel;
            stapel = new LinearLayout(this);
            stapel.Orientation = Orientation.Vertical;

            stapel.AddView(rij);
            stapel.AddView(plaatje);


            SetContentView(stapel);

        }



    }
}

