using Xunit;
using contentmanagerproject;
namespace contentmanager
{
    public class UnitTest1
    {
        [Fact]
        public void GetcntactsCase() //testnig viewing all contacts
        {
            //arrange
            int cat = 1;
            List<Tuple<string, string>> contacts = new List<Tuple<string, string>>(){
        new Tuple<string, string>("nory", "0782355078"),
        new Tuple<string, string>("misk", "0788654345"),
        new Tuple<string, string>("jawad", "0782345678"),
        new Tuple<string, string>("haya",  "0733654365"),
        new Tuple<string, string>("reem", "0756355078"),
         new Tuple<string, string>("aya", "07823446789")
    };
            // act 
            List<Tuple<string, string>> ss = contentmanagerproject.Program.GetContacts(cat);

            // assert
            Assert.Equal(ss, contacts);
        }

        [Fact]
        public void GetContactCase() {  // testing search contact by name

            //arrange
            string name = "jawad";
            string phonenumber = "0782345678";
            //act
            string test_res = contentmanagerproject.Program.GetContact(name);
            //assert
            Assert.Equal(test_res, phonenumber);
        }


        [Fact]
        public void AddContactCase() {

            //arrange
            string name = "aya";
            string phonenumber = "07823446789";
            string category = "friends";
            List<Tuple<string, string>> contacts = new List<Tuple<string, string>>(){
        new Tuple<string, string>("nory", "0782355078"),
        new Tuple<string, string>("misk", "0788654345"),
        new Tuple<string, string>("jawad", "0782345678"),
        new Tuple<string, string>("haya",  "0733654365"),
        new Tuple<string, string>("reem", "0756355078"),
        new Tuple<string, string>("aya", "07823446789")
    };
            //act
            List<Tuple<string, string>> output = contentmanagerproject.Program.AddContact(name, phonenumber, category);

            //assert
            Assert.Equal(output, contacts);
        }


        [Fact]
        public void RemoveContactCasse() {

            string name = "reem";
            List<Tuple<string, string>> contacts = new List<Tuple<string, string>>(){
        new Tuple<string, string>("nory", "0782355078"),
        new Tuple<string, string>("misk", "0788654345"),
        new Tuple<string, string>("jawad", "0782345678"),
        new Tuple<string, string>("haya",  "0733654365"),
         new Tuple<string, string>("aya", "07823446789")
            };

            List<Tuple<string, string>> output = contentmanagerproject.Program.RemoveContact(name);

            Assert.Equal(output, contacts);


        }
    }
}