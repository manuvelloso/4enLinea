using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class User
    {
        public string name { get; set; } //user's name
        public string surname { get; set; } //user's surname
        public string password { get; set; } //user's password

        public string username { get; set; } //user's game-name
        public uint wins { get; set; } //total of games won
        public uint lost { get; set; } //total of games lost

        public User(string[] data)
        {
            name = data[0];
            surname = data[1];
            username = data[2];
            password = data[3];
            wins = uint.Parse(data[4]);
            lost = uint.Parse(data[5]);
        }
        public User()
        {

        } 
        public void SetData(string[] data)
        {
           name = data[0];
           surname = data[1];
            username = data[2];
           password = data[3];
            wins = uint.Parse(data[4]);
            lost = uint.Parse(data[5]);
        }
    }