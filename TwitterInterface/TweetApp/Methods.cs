using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Tweetinvi;

namespace TweetApp
{
    class Methods
    {
        public static void MessagePull(System.Windows.Controls.TextBox textBox)
        {
            textBox.AppendText("Your DMs:" + Environment.NewLine);
            MessagePuller puller = new MessagePuller();
            List<String> messages = puller.PullMessages();
            for (int i = 0; i < messages.Count; i++)
            {
                textBox.AppendText(Environment.NewLine + (i + 1) + ". " + messages[i]);
            }
        }

        public static void Timeline(System.Windows.Controls.TextBox textBox)
        {
            textBox.Clear();
            textBox.AppendText("BACS 387 - Team 2's Timeline:\n\n");
            TimelinePuller puller = new TimelinePuller();
            List<String> timelineTweets = puller.PullTimeline();
            for (int i = 0; i < timelineTweets.Count; i++)
            {
                textBox.AppendText(timelineTweets[i] + "\n");
            }
        }

        public static void SendTweet(System.Windows.Controls.TextBox textBox)
        {
            TweetMessage twt = new TweetMessage();
            TweetSender twtSender = new TweetSender();
            twt.Content = textBox.Text + "\n-" + SavedUsername.SavedUser;
            twt.Length = textBox.Text.Length;
            twtSender.SendMessage(twt, "");
            textBox.Text = "";
        }

        public static void SendPM(System.Windows.Controls.TextBox message, System.Windows.Controls.TextBox user)
        {
            PrivateMessage Msg = new PrivateMessage();
            PMSender pMSender = new PMSender();
            Msg.Content = message.Text + "\n-" + SavedUsername.SavedUser;
            Msg.Recepient = user.Text;
            pMSender.SendMessage(Msg, Msg.Recepient);
            message.Clear();
            user.Clear();
        }

        public static void Login(System.Windows.Controls.TextBox user, System.Windows.Controls.PasswordBox password)
        {
            Account LoginAccount = new Account();
            ActiveUser ActiveUser = new ActiveUser();
            ActiveUser.UserName = user.Text;
            ActiveUser.Password = password.Password;
            LoginAccount.LoginCSV(ActiveUser.UserName, ActiveUser.Password);
            user.Text = ("Enter UserName");
            password.Password = ("password");
            SavedUsername.SavedUser = ActiveUser.UserName;
        }

        public static void Logout()
        {
            Account LogoutAccount = new Account();
            LogoutAccount.Logout();
            ((MainWindow)System.Windows.Application.Current.MainWindow).tbUser.Text = ("Enter UserName");
            ((MainWindow)System.Windows.Application.Current.MainWindow).tbPassword.Password = ("password");
            ((MainWindow)System.Windows.Application.Current.MainWindow).tabMessage.IsEnabled = false;
            ((MainWindow)System.Windows.Application.Current.MainWindow).tabPM.IsEnabled = false;
            ((MainWindow)System.Windows.Application.Current.MainWindow).tabProfile.IsEnabled = false;
            ((MainWindow)System.Windows.Application.Current.MainWindow).tabTimeline.IsEnabled = false;
            ((MainWindow)System.Windows.Application.Current.MainWindow).tabTweet.IsEnabled = false;
            ((MainWindow)System.Windows.Application.Current.MainWindow).lblActiveUser.Content = "[No User]";
            SavedUsername.SavedUser = "[No User]";
        }

        public static void ProfileStats()
        {
            Account account = new Account();
            JsonUser jsonUser = new JsonUser();
            Profile profile = new Profile();
            jsonUser.JsonU=account.SetJson();
            profile.Json(jsonUser);
            ((MainWindow)System.Windows.Application.Current.MainWindow).lblFollowersCalc.Content = profile.Followers().ToString();
            ((MainWindow)System.Windows.Application.Current.MainWindow).lblFavoritesCalc.Content = profile.Favorites().ToString();
            ((MainWindow)System.Windows.Application.Current.MainWindow).lblScreenNameCalc.Content = profile.ScrnName().ToString();
            ((MainWindow)System.Windows.Application.Current.MainWindow).lblNameCalc.Content = profile.Name().ToString();
        }

        public static void SaveAs(System.Windows.Controls.TextBox textBox)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "*.txt";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile()))
                {
                    sw.Write(textBox.Text);
                }
            }
        }
        public static class SavedUsername //Only exists so that tweets and messages can be signed.
        {
            public static String SavedUser { get; set; }
            
        }
    }
}
