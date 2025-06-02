using System;

namespace Marshell_Web.Models
{
    public class Users
    {
        public int ID { get; set; }               // Primary key, auto-incremented
        public string UNAME { get; set; }          // User's first name
        public string SRNAME { get; set; }         // User's surname
        public string IDNUMBER { get; set; }       // User's national ID or similar
        public string MOBILE { get; set; }         // User's mobile number
        public DateTime REGDATE { get; set; }      // Registration date
        public string NATIONALITY { get; set; }    // Nationality (default is 'NIC')
        public string GENDER { get; set; }         // Gender of the user
        public string LOCATION { get; set; }       // User's location (default is 'PEARL LAGOON')
        public string LOGIN { get; set; }          // User's login (unique)
        public string PASS { get; set; }           // User's password (hashed typically)
        public int FIRED { get; set; }             // Indicates if user is fired (0 for not, 1 for fired)
        public string ROLE { get; set; }           // Role (e.g., 'CASHIER', 'ADMIN', etc.)
        public DateTime? CreatedAt { get; set; }   // Date the user was created
        public DateTime? UpdatedAt { get; set; }   // Date the user was last updated
        public bool IsDeleted { get; set; }        // Soft delete flag (1 for deleted, 0 for not)

        // Constructor
        public Users()
        {
            // Initialize properties with default values
            REGDATE = DateTime.Now;
            NATIONALITY = "NIC";
            LOCATION = "PEARL LAGOON";
            FIRED = 0;
            ROLE = "CASHIER";
            IsDeleted = false;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
    }
}