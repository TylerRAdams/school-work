using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TweetApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTweet_Click(object sender, RoutedEventArgs e)
            //Calls a function/method from the Methods class to send a tweet
        {
            Methods.SendTweet(txtTweetBox);
        }

        private void tbPassword_GotFocus(object sender, RoutedEventArgs e)
        //Clear textbox when user clicks
        {
            tbPassword.Password = null;
        }


        private void btnTeam8Timeline_Click(object sender, RoutedEventArgs e) 
            //Pulls tweets from timeline
        {
            Methods.Timeline(txtTimeline);
        }

        private void txtTweetBox_TextChanged(object sender, TextChangedEventArgs e) 
            //Counts characters left available to use.
        {
            lblChars.Content = 140 - txtTweetBox.Text.Length;
        }

        private void Message_Button_Click(object sender, RoutedEventArgs e) 
            //Sends private messages. Recipient must be following account.
        {
            Methods.SendPM(txtMessageBox, txtUserBox);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
            //Clears the timeline textbox
        {
            txtTimeline.Clear();
        }

        private void btnMessagePull_Click(object sender, RoutedEventArgs e)
            //Calls a function/method form the Methods class in order to pull the private messages
        {
            Methods.MessagePull(rtxtMessages);
        }

        private void btnClearMessages_Click(object sender, RoutedEventArgs e)
            //Clears the PM textbox
        {
            rtxtMessages.Clear();
        }

        private void btnLogin(object sender, RoutedEventArgs e)
        //Calls a function/method from the Methods class allowing the user to login
        {
            Methods.Login(tbUser, tbPassword);            
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        //Calls a function/method from the Methods class allowing the user to logout
        {
            Methods.Logout();
        }

        private void TabItem_GotFocus(object sender, RoutedEventArgs e)
        //Calls a function/method from the Methods class to pull the profile stats
        {
            Methods.ProfileStats(); 
        }

        private void tbUser_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        //Calls a function/method from the Methods class to send a tweet
        {
            tbUser.Clear();
        }
        

        private void BtnCreateUser_Click(object sender, RoutedEventArgs e)
        //Allows th euser to double-click to clear the textbox
        {
            Account account = new Account();
            account.CreateUser();
        }

        private void btnSaveToFile_Click_1(object sender, RoutedEventArgs e)
        //Calls a function/method from the Methods class allowing the user to save the content in the textbox
        {
            Methods.SaveAs(rtxtMessages);
        }
    }
}
