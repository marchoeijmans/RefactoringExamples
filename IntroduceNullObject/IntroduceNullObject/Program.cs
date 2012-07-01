using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AR = IntroduceNullObject.AfterRefactor;
using BR = IntroduceNullObject.BeforeRefactor;


namespace IntroduceNullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            BR.Site siteBR = new BR.Site();

            if (siteBR.Customer != null)
            {
                Console.WriteLine(siteBR.Customer.getName());
            }
            else
            {
                Console.WriteLine("Occupant");
            }

            siteBR.Customer = new BR.Customer("Marc", "Hoeijmans");

            if (siteBR.Customer != null)
            {
                Console.WriteLine(siteBR.Customer.getName());
            }
            else
            {
                Console.WriteLine("Occupant");
            }

            AR.Site site = new AR.Site();
            Console.WriteLine(site.getCustomer().isNull());
            Console.WriteLine(site.getCustomer().getName()); // Empty customer, so display Occupant.

            site.setCustomer("Marc", "Hoeijmans");
            Console.WriteLine(site.getCustomer().isNull());
            Console.WriteLine(site.getCustomer().getName());

            try
            {
                site.setCustomer(null, "lastname");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                site.setCustomer(string.Empty, "lastname");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                site.setCustomer("firstname", null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                site.setCustomer("fistname", null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadLine();
        }
    }
}
