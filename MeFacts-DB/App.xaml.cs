using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;
using MeFacts_DB.Data;
using MeFacts_DB.Models;

namespace MeFacts_DB
{
    public partial class App : Application
    {
        static PersonalItemDatabase database;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static PersonalItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new PersonalItemDatabase();
                    prefillDatabase();

                }
                return database;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
        static void prefillDatabase()
        {
            database.ClearAllAsync();
            List<PersonalItem> items = new List<PersonalItem>();
            items.Add(new PersonalItem() { Detail = "I write PL/I as my day job.", Title = "Mainframe", ImageName = "mainframe.png" });
            items.Add(new PersonalItem() { Detail = "I have bowled a perfect 300 game.", Title = "Bowling", ImageName = "bowling.png" });
            items.Add(new PersonalItem() { Detail = "Developing blockchain apps is a hobby of mine.", Title = "Blockchain", ImageName = "blockchain.png" });
            items.Add(new PersonalItem() { Detail = "I am a certified beer judge and home brewer.", Title = "Beer Guy", ImageName = "beer.png" });
            items.Add(new PersonalItem() { Detail = "I have a wife and a daughter.", Title = "Family", ImageName = "family.png" });
            database.InsertList(items);

        }
    }
}
