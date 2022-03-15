using System;


namespace stonksomware.controllers
{
    public static class ActionsController 
    {
        static String[] errorMsg =
        {
            "HAHA, FUNNY NUMBER",
            "Get rekt",
            "You've been ransomwared by the Stonks Life Inc",
            "Error 420",
            "(maybe) the final university project from the Stonks Life Inc",
            "Such Stonks",
            "We love STONKSITUDE",
            "ERROR MESSAGE",
            "Real _xXG@m3rzXx_",
            "Real _xXH@c43rzXx_",
            "Arthur Quad Avanture",
            "OMICRON, EXPLOSION",
            "SailfishOS <3",
            "Oui oui baugette, fou de fafa",
        };

        public static void displayRandomErrorMessages()
        {
            Random rnd = new Random();
            int msgIndex = rnd.Next(0, errorMsg.Length);
            //int nbMsg = rnd.Next(0, 10);

            /*for(int i = 0; i < nbMsg; i++)
            {
                MessageBox.Show(errorMsg[msgIndex]);
            }*/
            MessageBox.Show(errorMsg[msgIndex]);

        }
    }
}