﻿using System;
using System.Collections.Generic;

    public enum Genre
    {
        Sport,
        Politics,
        Economy,
        Science
    }

    public interface IObserver
    {
        void Update(ISubject subject);
    }

    public interface ISubject
    {
        void Notify();
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void setNewsHeadline(Genre state, string news);


    }

    public class NewsAgency : ISubject
    {
        public string NewsHeadline;
        public Genre State;

        public void setNewsHeadline(Genre state, string news)
        {
            NewsHeadline = news;
            State = state;
        }

        private List<IObserver> Observers = new List<IObserver>();

        

        public void Detach(IObserver observer)
        {
            this.Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in Observers)
            {
                observer.Update(this);
            }
        }

        public void Attach(IObserver observer)
        {
            this.Observers.Add(observer);
        }

    }

    class DailyEconomy : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as NewsAgency).State == Genre.Economy)
            {
                Console.WriteLine($"DailyEconomy publikuje artykuł \"{(subject as NewsAgency).NewsHeadline}\"");
            }
        }
    }

    class NewYorkTimes : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as NewsAgency).State == Genre.Politics)
            {
                Console.WriteLine($"NewYorkTimes publikuje artykuł \"{(subject as NewsAgency).NewsHeadline}\"");
            }
            if ((subject as NewsAgency).State == Genre.Economy)
            {
                Console.WriteLine($"NewYorkTimes publikuje artykuł \"{(subject as NewsAgency).NewsHeadline}\"");
            }
            if ((subject as NewsAgency).State == Genre.Science)
            {
                Console.WriteLine($"NewYorkTimes publikuje artykuł \"{(subject as NewsAgency).NewsHeadline}\"");
            }
            if ((subject as NewsAgency).State == Genre.Sport)
            {
                Console.WriteLine($"NewYorkTimes publikuje artykuł \"{(subject as NewsAgency).NewsHeadline}\"");
            }
        }
    }

    class NationalGeographic : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as NewsAgency).State == Genre.Science)
            {
                Console.WriteLine($"NationalGeographic publikuje artykuł \"{(subject as NewsAgency).NewsHeadline}\"");
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            var newsAgency = new NewsAgency();

            var dailyEconomy = new DailyEconomy();
            var newYork = new NewYorkTimes();
            var nationalGeographic = new NationalGeographic();

            

            newsAgency.setNewsHeadline(Genre.Economy, "USA is going bancrupt!");
            dailyEconomy.Update(newsAgency);
            newYork.Update(newsAgency);
            nationalGeographic.Update(newsAgency);

            newsAgency.setNewsHeadline(Genre.Science, "Life on Alpha Centauri");
            dailyEconomy.Update(newsAgency);
            newYork.Update(newsAgency);
            nationalGeographic.Update(newsAgency);

            newsAgency.setNewsHeadline(Genre.Sport, "Adam Małysz is the greatest sportsman in the history of mankind");
            dailyEconomy.Update(newsAgency);
            newYork.Update(newsAgency);
            nationalGeographic.Update(newsAgency);

            newsAgency.setNewsHeadline(Genre.Economy, "CD Project RED value has grown by 500% in 2020");
            dailyEconomy.Update(newsAgency);
            newYork.Update(newsAgency);
            nationalGeographic.Update(newsAgency);

            newsAgency.setNewsHeadline(Genre.Science, "Kirkendall effect causing airplanes' engine deteriorate");
            dailyEconomy.Update(newsAgency);
            newYork.Update(newsAgency);
            nationalGeographic.Update(newsAgency);

            newsAgency.setNewsHeadline(Genre.Politics, "Texas is going bancrupt!");
            dailyEconomy.Update(newsAgency);
            newYork.Update(newsAgency);
            nationalGeographic.Update(newsAgency);

            newsAgency.Notify();

        }
    }