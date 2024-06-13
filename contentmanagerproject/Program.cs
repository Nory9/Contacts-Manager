
using System.Xml.Linq;
namespace contentmanagerproject
{

        public class Program
        {
            // public static List<string,string> contents = new List<string,string>();
            public static List<Tuple<string, string>> contacts = new List<Tuple<string, string>>(){
        new Tuple<string, string>("nory", "0782355078"),
        new Tuple<string, string>("misk", "0788654345"),
        new Tuple<string, string>("jawad", "0782345678"),
        new Tuple<string, string>("haya",  "0733654365"),
        new Tuple<string, string>("reem", "0756355078")
    };
            public static List<Tuple<string, string>> family = new List<Tuple<string, string>>(){
        new Tuple<string, string>("jawad", "0782345678"),
        new Tuple<string, string>("haya",  "0733654365")
    };
            public static List<Tuple<string, string>> friends = new List<Tuple<string, string>>(){
        new Tuple<string, string>("nory", "0782355078"),
        new Tuple<string, string>("misk", "0788654345")
    };
            public static List<Tuple<string, string>> work = new List<Tuple<string, string>>(){
        new Tuple<string, string>("reem", "0756355058")
    };

            static void Main(string[] args)
            {

                ContactsManager();
            }
            public static void ContactsManager()
            {

                Console.WriteLine("Wellcome to nory's Contact manager where you can safly save you contents\n you can view,search,add and delete Contacts\n\n lets get started!\n\n if you want to view the Contacts please enter 1 \n\n if you want to search for a Contact please enter 2 \n\n if you want to add a new Contact please enter 3 \n\n if you want to delete a Contact please enter 4");
                string s = "";
                s = Console.ReadLine();
                Boolean n = Int32.TryParse(s, out int num);
                if (!n || (num != 1 && num != 2 && num != 3 && num != 4))
                {
                    Console.WriteLine("you've entered an ivalid number, exit and try again");
                }
                else
                { // if the number is 1,2,3,4
                    if (num == 1)
                    { //start of view
                        Console.WriteLine("In our Contact Manager you can view All Contact, family list, friends list or work list \n\n enter 1 for all Contacts \n\n 2 for family Contacts \n\n 3 for friends Contacts \n\n 4 for work Contacts");

                        string category = Console.ReadLine();
                        if (!Int32.TryParse(category, out int cat))
                        {
                            Console.WriteLine("you've entered an ivalid number exit and try again");
                        }
                        else
                        {
                            if (cat == 1 || cat == 2 || cat == 3 || cat == 4)
                            {
                                List<Tuple<string, string>> res = GetContacts(cat);

                                foreach (var i in res)
                                {
                                    Console.WriteLine(i);

                                }
                            }
                            else
                            {
                                Console.WriteLine("this list number doesnt exist please try again and make sure the number you enter in 1,2,3 or 4 !!");
                            }
                        }
                    } // end of view 
                    else if (num == 2)
                    {  // sart of search 
                        Console.WriteLine("In our Contact manager app you can search for Contacts by name \n\n please enter the name you want to search for its Contact");
                        string name = Console.ReadLine();
                        string search_res = GetContact(name);
                        if (search_res == "")
                            Console.WriteLine("the name was not found please try again making sure the name exist!");
                        else
                            Console.WriteLine(search_res);
                    } //end of search 

                    else if (num == 3)
                    {
                        string newName = "";
                        string phoneNumber = "";
                        string category = "";
                        Console.WriteLine("please enter the following fields");
                        Console.WriteLine("enter the new Contact name");
                        newName = Console.ReadLine();
                        string search_res = GetContact(newName);
                        if (search_res != "")
                        {
                            while (search_res != "")
                            {
                                Console.WriteLine("the name already exist, please try again with a new name: ");
                                newName = Console.ReadLine();
                                search_res = GetContact(newName);
                            }
                        }
                        Console.WriteLine(" the name is accepted, now please enter the phone number");
                        phoneNumber = Console.ReadLine();
                        for (int i = 0; i < phoneNumber.Length; i++)
                        {
                            if (!Char.IsDigit(phoneNumber[i]) || phoneNumber.Length < 10)
                            {
                                while (!Char.IsDigit(phoneNumber[i]) || phoneNumber.Length < 10)
                                {
                                    Console.WriteLine("the number is invalid please try again!");
                                    phoneNumber = Console.ReadLine();

                                }

                            }
                        }
                        Console.WriteLine(" the phone number is valid and  accepted\n now please enter the category you want to add the number to (family,friends or work),\n if you dont want to added to any category, enter \"nothing\" ");
                        category = Console.ReadLine();
                        if (category != "friends" && category != "family" && category != "work" && category != "nothing")
                        {
                            Console.WriteLine("the category is dosent exist try again making sure its one of these (family, friends, work, nothing (so it wont be added to any category))");
                            while (category != "friends" && category != "family" && category != "work" && category != "nothing")
                            {
                                category = Console.ReadLine();
                            }
                        }
                        // add method
                        List<Tuple<string, string>> res = AddContact(newName, phoneNumber, category);
                        Console.WriteLine();
                        foreach (var i in res)
                        {
                            Console.WriteLine(i);
                        }
                        if (category == "family")
                        {
                            Console.WriteLine("\nthe name was also added to family category: \n");
                            foreach (var i in family)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        else if (category == "friends")
                        {
                            Console.WriteLine("\nthe name was also added to fioends category: \n");
                            foreach (var i in friends)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        else if (category == "work")
                        {
                            Console.WriteLine("\nthe name was also added to work category: \n");
                            foreach (var i in work)
                            {
                                Console.WriteLine(i);
                            }
                        }
                    }
                    else if (num == 4)
                    {
                        Console.WriteLine("to delete a contact from all contacts please enter the name you want to delete: ");
                        string delete_name = "";
                        delete_name = Console.ReadLine();
                        string res = GetContact(delete_name);
                        if (res == "")
                        {
                            Console.WriteLine("the name you entered doesnt exist, please try again and make sure the name is valid!");
                            while (res == "")
                            {
                                delete_name = Console.ReadLine();
                                //  Console.WriteLine("the name you entered doesnt exist, please try again and make sure the name is valid!");
                                res = GetContact(delete_name);

                            }
                        }
                        Console.WriteLine("the name exist and removed from the contacts");
                        // to delete 
                        List<Tuple<string, string>> deleted_res = RemoveContact(delete_name);
                        Console.WriteLine();
                        foreach (var i in deleted_res)
                        {
                            Console.WriteLine(i);
                        }

                    }
                }

            }
            public static List<Tuple<string, string>> GetContacts(int category) //view all method //testing passed
            {
                if (category == 1)
                    return contacts;
                else if (category == 2)
                    return family;
                else if (category == 3)
                    return friends;
                else if (category == 4)
                    return work;
                else return contacts; //
            }
            public static string GetContact(string name) //search method  //test passed
            {
                foreach (var item in contacts)
                {
                    if (item.Item1 == name)
                        return item.Item2;
                }
                return "";

            }

            public static List<Tuple<string, string>> AddContact(string name, string phonenumber, string category)
            { //add method //test passed
                var result = new Tuple<string, string>(name, phonenumber);
                contacts.Add(result);
                if (category == "family")
                    family.Add(result);
                else if (category == "friends")
                    friends.Add(result);
                else if (category == "work")
                    work.Add(result);
                return contacts;
            }

            public static List<Tuple<string, string>> RemoveContact(string name)
            { //remove method //test passed
                contacts.RemoveAll(item => item.Item1 == name);
                family.RemoveAll(item => item.Item1 == name);
                friends.RemoveAll(item => item.Item1 == name);
                work.RemoveAll(item => item.Item1 == name);
                return contacts;
            }
        }
    }

