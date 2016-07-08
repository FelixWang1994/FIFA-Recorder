using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实况八记录器
{
    
    public class Season
    {
        public Season() { }
        public Season(string year,int order,int win,int draw,int lose,int point,
                      int goalDifference,int redCard,int yellowCard,int totalGoalScored
                      ,int totalGoalAgainst,int totalAssist,string topScorer,string topAssistant){
                          this.Year = year;
                          this.Order = order;
                          this.Win = win;
                          this.Draw = draw;
                          this.Lose = lose;
                          this.Point = point;
                          this.GoalDifference = goalDifference;
                          this.RedCard = redCard;
                          this.YellowCard = yellowCard;
                          this.TotalGoalScored = totalGoalScored;
                          this.TotalGoalAgainst = totalGoalAgainst;
                          this.TotalAssist = totalAssist;
                          this.TopScorer = topScorer;
                          this.TopAssistant = topAssistant;
        }

        private string year;

        public string Year
        {
            get { return year; }
            set { year = value; }
        }
        private int order;

        public int Order
        {
            get { return order; }
            set { order = value; }
        }
        private int win;

        public int Win
        {
            get { return win; }
            set { win = value; }
        }
        private int draw;

        public int Draw
        {
            get { return draw; }
            set { draw = value; }
        }
        private int lose;

        public int Lose
        {
            get { return lose; }
            set { lose = value; }
        }
        private int point;

        public int Point
        {
            get { return point; }
            set { point = value; }
        }
        private int goalDifference;

        public int GoalDifference
        {
            get { return goalDifference; }
            set { goalDifference = value; }
        }
        private int redCard;

        public int RedCard
        {
            get { return redCard; }
            set { redCard = value; }
        }
        private int yellowCard;

        public int YellowCard
        {
            get { return yellowCard; }
            set { yellowCard = value; }
        }
        private int totalGoalScored;

        public int TotalGoalScored
        {
            get { return totalGoalScored; }
            set { totalGoalScored = value; }
        }
        private int totalGoalAgainst;

        public int TotalGoalAgainst
        {
            get { return totalGoalAgainst; }
            set { totalGoalAgainst = value; }
        }
        private int totalAssist;

        public int TotalAssist
        {
            get { return totalAssist; }
            set { totalAssist = value; }
        }
        private string topScorer;

        public string TopScorer
        {
            get { return topScorer; }
            set { topScorer = value; }
        }
        private string topAssistant;

        public string TopAssistant
        {
            get { return topAssistant; }
            set { topAssistant = value; }
        }
    }
}
