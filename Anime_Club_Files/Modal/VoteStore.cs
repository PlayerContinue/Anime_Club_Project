using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anime_Club_Files.Modal
{
    /*!
    Class containing information about the objects being voted on
        */
    public class VoteStore
    {

        public VoteStore()
        {
            this.name = "";
            this.number_votes = 0;
        }

        public VoteStore(String name)
        {
            this.number_votes = 0;
            String[] split_up = name.Split(new string[] { "~" }, StringSplitOptions.None);
            this.name = split_up[0];
            if (split_up.Length > 1)
            {
                this.description = split_up[1];
            }
        }


        /**
        A getter and setter for the number of votes for the current value
        */
        public int Votes
        {
            get { return this.number_votes; }
            set { this.number_votes = value; }
        }

        /**
     A getter and setter for the Name for the current value
     */
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        /**
     A getter and setter for the Description for the current value
     */
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /**
   A getter and setter for if the current value is selectable.
            Returns false in all cases
   */
        public bool IsSelectable
        {
            get { return false; }
            set { }
        }
        private int number_votes; /**< Contains the number of votes for the current user */
        private string name; /**< The name of the current object value*/
        private string description; /**< A description about the current object */
    }
}
