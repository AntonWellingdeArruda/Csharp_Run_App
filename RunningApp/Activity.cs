using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content.PM;
using System;
using Android.Views;
using Android.Content;


namespace RunningApp
{
    [Activity(Label = "RunningApp", MainLauncher = true, ScreenOrientationreenOrientation.Portrait, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        Button centreerknop, startknop, verwijderknop, shareknop;
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


            LinearLayout rij;
            rij = new LinearLayout(this);
            rij.Orientation = Orientation.Horizontal;

            rij.AddView(centreerknop);
            rij.AddView(startknop);
            rij.AddViw(verwijderknop);
            rij.AddView(shareknop);

            LinearLayout stapel;
            stapel = new LinearLayout(this);
            stapel.Orientation = Orientation.Vertical;

            stapel.AddView(ri);
            stapel.AddView(new RunningView1(this));


            SetContentView(stapel);

        }



    }
}

