using System;

namespace sock_pairs
{
    public class Pairs
    {
        public int PairCount(string s){
        int count = 0;
        string mutable = s;
        while(mutable.Length > 0)
        {
            string next = mutable.Replace(mutable[0].ToString(),"");
            count = (mutable.Length - next.Length);
            mutable = next;
        }

        return count;

        }
    }
}
