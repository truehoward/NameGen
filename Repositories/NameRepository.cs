using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace NameGen.Repositories
{
    public static class NameRepository
    {
        private static String[] _allFirstNames { get; set; }
        private static String[] _femaleFirstNames { get; set; }
        private static String[] _maleFirstNames { get; set; }

        private static string _allFirstNamesFilename = "all-first-names.txt";
        private static string _femaleFirstNamesFilename = "female-first-names.txt";
        private static string _maleFirstNamesFilename = "male-first-names.txt";

        private static string _allFirstNamesPath = Path.Combine(new string[] {System.Web.HttpContext.Current.Server.MapPath("~/App_Data/"), _allFirstNamesFilename});
        private static string _femaleFirstNamesPath = Path.Combine(new string[] { System.Web.HttpContext.Current.Server.MapPath("~/App_Data/"), _femaleFirstNamesFilename });
        private static string _maleFirstNamesPath = Path.Combine(new string[] { System.Web.HttpContext.Current.Server.MapPath("~/App_Data/"), _maleFirstNamesFilename });

        public static String[] AllFirstNames
        {
            get 
            {
                if (_allFirstNames == null)
                {
                    _allFirstNames = System.IO.File.ReadAllLines(_allFirstNamesPath);
                }

                return _allFirstNames;
            }
            
        }

        public static String[] FemaleFirstNames
        {
            get
            {
                if (_femaleFirstNames == null)
                {
                    _femaleFirstNames = System.IO.File.ReadAllLines(_femaleFirstNamesPath);
                }

                return _femaleFirstNames;
            }

        }

        public static String[] MaleFirstNames
        {
            get
            {
                if (_maleFirstNames== null)
                {
                    _maleFirstNames = System.IO.File.ReadAllLines(_maleFirstNamesPath);
                }

                return _maleFirstNames;
            }
        }

    }
}