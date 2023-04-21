using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace T2207A.assignment5
{
    public class News : INews
    {
        private int id;
        private String title;
        private String publishDate;
        private String author;
        private String content;
        private float averageRate;

        public int[] RateList = new int[3];
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Title
        {
            get { return title; }
            set { title = value; }
        }
        public String PublishDate
        {
            get { return publishDate; }
            set { publishDate = value; }
        }
        public String Author
        {
            get { return author; }
            set { author = value; }
        }
        public String Content
        {
            get { return content; }
            set { content = value; }
        }
        public float AverageRate
        {
            get { return averageRate; }
        }
        public void Display()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Publish Date: " + PublishDate);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Content: " + Content);
            Console.WriteLine("Average Rate: " + AverageRate);
        }
        public void Calculate()
        {
            int sum = 0;
            for(int i = 0; i < RateList.Length; i++)
            {
                sum += RateList[i];
            }
            Console.WriteLine(sum);
            averageRate =(float) sum / RateList.Length;
        }
    }
}
