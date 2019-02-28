using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;
using System.Windows;
using System.IO;
using Newtonsoft.Json;

namespace TweetApp
{
    class Account
    {
        public String[] masterCredentials = { "FSO5Y9kl3T1RBck11jvaWsVvH", "CvdT8IEO4mIkbZxWGBlCL5C9IItQGlZ3HJMiSelMiw8GD4Q7Gy", "915239441806929921-ZiIP0X5E2EOf4T6J9boXyULKG36Ilf0", "1XfBPnakLxIOg6uT15deJsY8BiZj7VHs732D0WfscLv0t" };
        public void Logout()
        {
            Auth.SetUserCredentials(null, null, null, null);
            var user = User.GetAuthenticatedUser();
        }
        public IAuthenticatedUser UserCredentials()
        {
            Auth.SetUserCredentials(masterCredentials[0], masterCredentials[1], masterCredentials[2], masterCredentials[3]);
            
            User.GetAuthenticatedUser();
            string JsonUser = JsonConvert.SerializeObject(User.GetAuthenticatedUser());
            return User.GetAuthenticatedUser();  
        }
        public string SetJson()
        {
            Auth.SetUserCredentials(masterCredentials[0], masterCredentials[1], masterCredentials[2], masterCredentials[3]);

            User.GetAuthenticatedUser();
            string JsonUser = JsonConvert.SerializeObject(User.GetAuthenticatedUser());
            return JsonUser;
        }
        public void CreateUser()
        {
            if (File.Exists(@"user_list.csv") == false)
            {
                File.WriteAllText(@"user_list.csv","");
                
            }
            string username = Microsoft.VisualBasic.Interaction.InputBox("Please enter in your desired Username below:", "Create a User", "Enter Username here", -1, -1);
            string password = Microsoft.VisualBasic.Interaction.InputBox("Please enter please enter the desired password for Username " + username + ":", "Create a User", "Enter " + username + "'s password here", -1, -1);
            if (DoesUserExist(username))
            {
                System.Windows.MessageBox.Show("Error. Username already exists.", "Error");
            }
            else
            {
                File.AppendAllText(@"user_list.csv", username + "," + password + "\n");
            }
        }
        public void LoginCSV(String Username, String Password)
        {
            try
            {
                var strLines = File.ReadLines(@"user_list.csv");
                bool success = false;
                foreach (var line in strLines)
                {
                    if (line.Split(',')[0].Equals(Username) && line.Split(',')[1].Equals(Password))
                    {
                        ((MainWindow)System.Windows.Application.Current.MainWindow).tabMessage.IsEnabled = true;
                        ((MainWindow)System.Windows.Application.Current.MainWindow).tabPM.IsEnabled = true;
                        ((MainWindow)System.Windows.Application.Current.MainWindow).tabProfile.IsEnabled = true;
                        ((MainWindow)System.Windows.Application.Current.MainWindow).tabTimeline.IsEnabled = true;
                        ((MainWindow)System.Windows.Application.Current.MainWindow).tabTweet.IsEnabled = true;
                        ((MainWindow)System.Windows.Application.Current.MainWindow).lblActiveUser.Content = Username;
                        success = true;
                    }
                }
                if(success == false)
                {
                    MessageBox.Show("Invalid login. Check username and password.", "Invalid Login.");
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Error! User information file not found.","Error!");
            }
        }
        public bool DoesUserExist(String Username)
        {
            var strLines = File.ReadLines(@"user_list.csv");
            foreach (var line in strLines)
            {
                if (line.Split(',')[0].Equals(Username))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
