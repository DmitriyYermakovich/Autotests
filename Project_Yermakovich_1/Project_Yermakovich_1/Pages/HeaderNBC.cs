using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Yermakovich_1.Pages
{
    public class HeaderNBC
    {
        private static string lnkShowsLocator = "a[href='/shows']";
        private static string lnkEpisodesLocator = "a[href='/video']";
        private static string lnkScheduleLocator = "a[href='/schedule']";
        private static string lnkNewSportsLocator = "//*[contains(text(), 'Sports')]/..";
        private static string lnkShopLocator = "a[href$='shop']";
        private static string lnkAppLocator = "a[href='/apps']";
        private static string lnkSearchLocator = "[class$='search'] button";
    }
}
