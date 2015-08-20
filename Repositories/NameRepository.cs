using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace NameGen.Repositories
{
    public static class NameRepository
    {
        public static String[] AllFirstNames { get; set; }
        public static String[] FemaleFirstNames { get; set; }
        public static String[] MaleFirstNames { get; set; }

        public NameRepository()
        {
            if(AllFirstNames == null)
            {
                AllFirstNames = System.IO.File.ReadAllLines(Server.MapPath("~/App_Data/all-first-names.txt"));
            }

            if (FemaleFirstNames == null)
            {
                FemaleFirstNames = System.IO.File.ReadAllLines(Server.MapPath("~/App_Data/female-first-names.txt"));
            }
            
            if(MaleFirstNames == null)
            {
                MaleFirstNames = System.IO.File.ReadAllLines(Server.MapPath("~/App_Data/male-first-names.txt"));
            }
        }
    }
}