using SampleApp.Models;
using SampleApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {

            if(string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
               

                string quertString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VALUES
                                        (@FirstName, @LastName, @EmailAddress)";

                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(quertString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }    
                return View("Success");
            }
        }

        public ActionResult Admin()
        {
            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, SocialSecruityNumber from SignUps";

            List<NewsletterSignUp> signUps = new List<NewsletterSignUp>();

            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    var signUp = new NewsletterSignUp();
                    signUp.Id = Convert.ToInt32(reader["Id"]);
                    signUp.FirstName = reader["FirstName"].ToString();
                    signUp.LastName = reader["LastName"].ToString();
                    signUp.EmailAddress = reader["EmailAddress"].ToString();
                    signUp.SocialSecrityNumber = reader["SocialSecurityNumber"].ToString();
                    signUps.Add(signUp);
                }

                var signUpVMs = new List<SignUpVM>();

                foreach(var signUp in signUps)
                {
                    var signUpVM = new SignUpVM();
                    signUpVM.FirstName = signUp.FirstName;
                    signUpVM.LastName = signUp.LastName;
                    signUpVM.EmailAddress = signUp.EmailAddress;
                    signUpVMs.Add(signUpVM);
                }

            }

            return View(SignUpVMs);
        }
    }
}