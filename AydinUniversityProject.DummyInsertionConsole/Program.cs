using AydinUniversityProject.Data.POCOs;
using AydinUniversityProject.Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.DummyInsertionConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AydinUniversityProjectContext())
            {
                List<Period> Periods = context.Periods.ToList();

                Lesson lesson1 = new Lesson()
                {
                    Name = "OCCUPATIONAL HEALTH AND SAFETY",
                    Period = Periods.SingleOrDefault(w => w.ID == 1),
                    Credit=2,
                    ECTSCredit=2
                };

                Lesson lesson2 = new Lesson()
                {
                    Name = "PROFESSIONAL ENGLISH-I",
                    Period = Periods.SingleOrDefault(w => w.ID == 1),
                    Credit = 3,
                    ECTSCredit = 4
                };
                Lesson lesson3 = new Lesson()
                {
                    Name = "INTEGRATED OFFICE TOOLS",
                    Period = Periods.SingleOrDefault(w => w.ID == 1),
                    Credit = 2,
                    ECTSCredit = 5
                };
                Lesson lesson4= new Lesson()
                {
                    Name = "MATHEMATICS-I",
                    Period = Periods.SingleOrDefault(w => w.ID == 1),
                    Credit = 3,
                    ECTSCredit = 4
                };
                Lesson lesson5 = new Lesson()
                {
                    Name = "COMPUTER HARDWARE AND SOFTWARE BASICS",
                    Period = Periods.SingleOrDefault(w => w.ID == 1),
                    Credit = 3,
                    ECTSCredit = 5
                };
                Lesson lesson6 = new Lesson()
                {
                    Name = "INTRODUCTION TO ALGORITHMS AND PROGRAMMING",
                    Period = Periods.SingleOrDefault(w => w.ID == 1),
                    Credit = 3,
                    ECTSCredit = 6
                };
                Lesson lesson7 = new Lesson()
                {
                    Name = "TURKISH LANGUAGE-I",
                    Period = Periods.SingleOrDefault(w => w.ID == 1),
                    Credit = 2,
                    ECTSCredit = 2
                };

                Lesson lesson8 = new Lesson()
                {
                    Name = "PRINCIPLES OF ATATURK AND THE HISTORY OF REVOLUTIONS-I",
                    Period = Periods.SingleOrDefault(w => w.ID == 1),
                    Credit = 2,
                    ECTSCredit = 2
                };

                Periods[0].Lessons.Add(lesson1);
                Periods[0].Lessons.Add(lesson2);
                Periods[0].Lessons.Add(lesson3);
                Periods[0].Lessons.Add(lesson4);
                Periods[0].Lessons.Add(lesson5);
                Periods[0].Lessons.Add(lesson6);
                Periods[0].Lessons.Add(lesson7);
                Periods[0].Lessons.Add(lesson8);






                Lesson lesson9 = new Lesson()
                {
                    Name = "OPERATING SYSTEMS",
                    Period = Periods.SingleOrDefault(w => w.ID == 2),
                    Credit = 3,
                    ECTSCredit = 5
                };

                Lesson lesson10 = new Lesson()
                {
                    Name = "WORK PLACEMENT-I",
                    Period = Periods.SingleOrDefault(w => w.ID == 2),
                    Credit = 0,
                    ECTSCredit = 4
                };
                Lesson lesson11 = new Lesson()
                {
                    Name = "PROFESSIONAL ENGLISH-II",
                    Period = Periods.SingleOrDefault(w => w.ID == 2),
                    Credit = 3,
                    ECTSCredit = 4
                };
                Lesson lesson12= new Lesson()
                {
                    Name = "MATHEMATICS-II",
                    Period = Periods.SingleOrDefault(w => w.ID == 2),
                    Credit = 3,
                    ECTSCredit = 4
                };
                Lesson lesson13 = new Lesson()
                {
                    Name = "C PROGRAMMING",
                    Period = Periods.SingleOrDefault(w => w.ID == 2),
                    Credit = 3,
                    ECTSCredit = 5
                };
                Lesson lesson14 = new Lesson()
                {
                    Name = "COMPUTER NETWORKS",
                    Period = Periods.SingleOrDefault(w => w.ID == 2),
                    Credit = 3,
                    ECTSCredit = 4
                };
                Lesson lesson15 = new Lesson()
                {
                    Name = "PRINCIPLES OF ATATURK AND THE HISTORY OF REVOLUTIONS-II",
                    Period = Periods.SingleOrDefault(w => w.ID == 2),
                    Credit = 2,
                    ECTSCredit = 2
                };

                Lesson lesson16 = new Lesson()
                {
                    Name = "TURKISH LANGUAGE-II",
                    Period = Periods.SingleOrDefault(w => w.ID == 2),
                    Credit = 2,
                    ECTSCredit = 2
                };

                Periods[1].Lessons.Add(lesson9);
                Periods[1].Lessons.Add(lesson10);
                Periods[1].Lessons.Add(lesson11);
                Periods[1].Lessons.Add(lesson12);
                Periods[1].Lessons.Add(lesson13);
                Periods[1].Lessons.Add(lesson14);
                Periods[1].Lessons.Add(lesson15);
                Periods[1].Lessons.Add(lesson16);








                Lesson lesson17 = new Lesson()
                {
                    Name = "WEB SITE DESIGN AND CREATION-I",
                    Period = Periods.SingleOrDefault(w => w.ID == 3),
                    Credit = 3,
                    ECTSCredit = 4
                };

                Lesson lesson18 = new Lesson()
                {
                    Name = "SYSTEMS ANALYSIS AND DESIGN",
                    Period = Periods.SingleOrDefault(w => w.ID == 3),
                    Credit = 3,
                    ECTSCredit = 4
                };
                Lesson lesson19 = new Lesson()
                {
                    Name = "VISUAL PROGRAMMING-I",
                    Period = Periods.SingleOrDefault(w => w.ID == 3),
                    Credit = 3,
                    ECTSCredit = 4
                };
                Lesson lesson20 = new Lesson()
                {
                    Name = "DATABASE MANAGEMENT SYSTEMS",
                    Period = Periods.SingleOrDefault(w => w.ID == 3),
                    Credit = 3,
                    ECTSCredit = 3
                };
                Lesson lesson21 = new Lesson()
                {
                    Name = "OBJECT ORIENTED PROGRAMMING-I",
                    Period = Periods.SingleOrDefault(w => w.ID == 3),
                    Credit = 3,
                    ECTSCredit = 3
                };
                Lesson lesson22 = new Lesson()
                {
                    Name = "WORK PLACEMENT-II",
                    Period = Periods.SingleOrDefault(w => w.ID == 3),
                    Credit = 0,
                    ECTSCredit = 4
                };
                Lesson lesson23 = new Lesson()
                {
                    Name = "DATA STRUCTURES",
                    Period = Periods.SingleOrDefault(w => w.ID == 3),
                    Credit = 3,
                    ECTSCredit = 4
                };
                                

                Periods[2].Lessons.Add(lesson17);
                Periods[2].Lessons.Add(lesson18);
                Periods[2].Lessons.Add(lesson19);
                Periods[2].Lessons.Add(lesson20);
                Periods[2].Lessons.Add(lesson21);
                Periods[2].Lessons.Add(lesson22);
                Periods[2].Lessons.Add(lesson23);

                               






                Lesson lesson24 = new Lesson()
                {
                    Name = "ENTREPRENEURSHIP",
                    Period = Periods.SingleOrDefault(w => w.ID == 4),
                    Credit = 2,
                    ECTSCredit = 2
                };

                Lesson lesson25 = new Lesson()
                {
                    Name = "GRADUATION PROJECT",
                    Period = Periods.SingleOrDefault(w => w.ID == 4),
                    Credit = 2,
                    ECTSCredit = 2
                };

                Lesson lesson26 = new Lesson()
                {
                    Name = "WORK PLACEMENT-III",
                    Period = Periods.SingleOrDefault(w => w.ID == 4),
                    Credit = 0,
                    ECTSCredit = 4
                };

                Lesson lesson27 = new Lesson()
                {
                    Name = "MICROPROCESSORS AND ASSEMBLER PROGRAMMING",
                    Period = Periods.SingleOrDefault(w => w.ID == 4),
                    Credit = 3,
                    ECTSCredit = 5
                };

                Lesson lesson28 = new Lesson()
                {
                    Name = "WEB SITE DESIGN AND CREATION-II",
                    Period = Periods.SingleOrDefault(w => w.ID == 4),
                    Credit = 3,
                    ECTSCredit =5
                };

                Lesson lesson29 = new Lesson()
                {
                    Name = "VISUAL PROGRAMMING-II",
                    Period = Periods.SingleOrDefault(w => w.ID == 4),
                    Credit = 3,
                    ECTSCredit = 5
                };

                Lesson lesson30 = new Lesson()
                {
                    Name = "OBJECT ORIENTED PROGRAMMING-II",
                    Period = Periods.SingleOrDefault(w => w.ID == 4),
                    Credit = 3,
                    ECTSCredit = 5,
                };

                Periods[3].Lessons.Add(lesson24);
                Periods[3].Lessons.Add(lesson25);
                Periods[3].Lessons.Add(lesson26);
                Periods[3].Lessons.Add(lesson26);
                Periods[3].Lessons.Add(lesson27);
                Periods[3].Lessons.Add(lesson28);
                Periods[3].Lessons.Add(lesson29);
                Periods[3].Lessons.Add(lesson30);

                context.SaveChanges();
            }
        }
    }
}
