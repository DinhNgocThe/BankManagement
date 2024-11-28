using BankManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.ViewModel
{
    internal class AddStaffViewModel
    {
        private StaffRepository staffRepository;

        private int id;
        private string staffName;
        private string password;
        private string role;
        private string username;
        private string workingBranch;
        private string jobPosition;
        private string email;
        private string staffPhoto;
        private DataTable dataTableStaff;

        public int Id { get =>  id; set => id = value; }
        public string StaffName { get => staffName; set => staffName = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public string Username { get => username; set => username = value; }
        public string WorkingBranch { get => workingBranch; set => workingBranch = value; }
        public string JobPosition { get => jobPosition; set => jobPosition = value; }
        public string Email { get => email; set => email = value; }
        public string StaffPhoto { get => staffPhoto; set => staffPhoto = value; }
        public DataTable DataTableStaff { get => dataTableStaff; set => dataTableStaff = value; }

        public AddStaffViewModel()
        {
            staffRepository = new StaffRepository();
        }

        private static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public void AddStaff()
        {
            Staff staff = new Staff(0, this.staffName, this.username, this.password, this.workingBranch, this.jobPosition, this.StaffPhoto, this.Email, "", this.Role);
            staff.Password = ComputeSha256Hash(staff.Password);
            staffRepository.AddStaff(staff);
        }

        public void LoadAllStaff()
        {
            this.dataTableStaff = staffRepository.LoadAllStaff();
        }

        public void DisableAccount()
        {
            staffRepository.DisableAccount(this.Id);
        }

        public void EnableAccount()
        {
            staffRepository.EnableAccount(this.Id);
        }
        public void UpdateStaff()
        {
            Staff staff = new Staff(this.Id, this.staffName, this.username, "", this.workingBranch, this.jobPosition, this.StaffPhoto, this.Email, "", this.Role);
            staffRepository.UpdateStaff(staff);
        }
    }
}
