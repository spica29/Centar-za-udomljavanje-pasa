using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memory
{
    class Igrac
    {
        private int Vrijeme;

        public int vrijeme
        {
            get { return Vrijeme; }
            set { Vrijeme = value; }
        }

        private string Nick;

        public string nick
        {
            get { return Nick; }
            set { Nick = value; }
        }

        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Igrac()
        {

        }

        public Igrac(string _nick, int _id, int _vrijeme)
        {
            nick = _nick;
            id = _id;
            vrijeme = _vrijeme;
        }

        public void evidentirajVrijeme(int _vrijeme)
        {
            vrijeme = _vrijeme;
        }
    }
}
