using Microsoft.AspNetCore.Builder;
using Site.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Cv.Any())
            {
                content.Cv.Add(getDefaultCV());
            }
            content.SaveChanges();
            int id = content.Cv.FirstOrDefault().id;
            if (!content.Skill.Any())
            {
                content.Skill.AddRange(new List<Skill>{
                new Skill{Name="C++",CVid=id},
                new Skill{Name="C#",CVid=id},
                new Skill{Name=".NET Core",CVid=id},
                new Skill{Name="Object-oriented programming",CVid=id},
                new Skill{Name="Multithreading",CVid=id},
                new Skill{Name="STL",CVid=id},
                new Skill{Name="WinSocket",CVid=id},
                new Skill{Name="WinForms/WPF/MFC",CVid=id},
                new Skill{Name="Git",CVid=id},
                new Skill{Name="Smart pointers",CVid=id},
                new Skill{Name="UML",CVid=id},
                new Skill{Name="MySQL",CVid=id},
                new Skill{Name="English",Level="Intermediate",CVid=id},
                new Skill{Name="Russian",Level="Native",CVid=id},
                new Skill{Name="Ukrainian",Level="Native",CVid=id}
                });
            }
            if (!content.Experience.Any())
            {
                content.Experience.AddRange(new List<Experience>
                {
                    new Experience{Text="Created a software project that can visualize temperature field in an orthotropic plate under the influence of a concentrated \"bending\" heat source",CVid=id},
                    new Experience{Text="Created a state machine for a calculator project",CVid=id},
                    new Experience{Text="Created a calculator using C# WinForms and state machine",CVid=id},
                    new Experience{Text="Created a program that implements chat using sockets and MySQL in C++",CVid=id}
                });
            }
            if (!content.Education.Any())
            {
                content.Education.Add(
                    new Education{Degree="Bachelor",End=2020,Faculty="Faculty of Mathematics and IT",Name="Donetsk National University",Speciality="Software engineer",Start=2016, CVid=id }
                );
            }
            if (!content.Contact.Any())
            {
                content.Contact.AddRange(new List<Contact>{
                    new Contact{Service="phone",Data="+380666874392",CVid=id},
                    new Contact{Service="mail",Data="ChoporovRoman@gmail.com",CVid=id},
                    new Contact{Service="GitHub",Data="github.com/Delrik",CVid=id}
                });
            }
            content.SaveChanges();
        }
        public static CV getDefaultCV()
        {
            CV result = new CV
            {
                FirstName = "Roman",
                LastName = "Choporov",
                Summary = "My name is Roma. I was born in a small town called Torez. Graduated from school and moved to Donetsk to go to university(DonNU). I finished 4 courses with honors and got a bachelor's degree. During my studies, I started playing badminton. I really liked it and I achieved some success in this matter. When I graduated from university I realized that there is nothing to do in Donetsk. So I moved to Kyiv.",
                Objectives = "Looking for C++ or C# developer position. I have knowledge of C++, C#/.NET Core. Have experience in SQL.\nWhen I started playing badminton, I was not good at it, but through diligence and the thought that I can't give up, I became better. Same way in programming. If I do not understand something then I can spend much energy to find the sollution and I'm sure that I will find it. I can learn fast. I am purposeful and have good logical thinking. Always ready to learn something new.",
                Jpg = "/img/photo.jpg"
            };
            return result;
        }
    }
}
