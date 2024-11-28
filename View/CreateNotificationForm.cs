using BankManagement.Language;
using BankManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement.View
{
    public partial class CreateNotificationForm : Form
    {
        private int staffId;
        private CreateNotificationViewModel viewModel;
        public CreateNotificationForm(int staffId)
        {
            InitializeComponent();
            this.staffId = staffId;
            ShowInTaskbar = false;
            viewModel = new CreateNotificationViewModel();
        }

        private void CreateNotificationForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }

        void ChangeLanguage()
        {
            lbCreateNotification.Text = LangHelper.Instance.GetString("Create Notification");
            lbTitle.Text = LangHelper.Instance.GetString("Title");
            lbContent.Text = LangHelper.Instance.GetString("Content");
            txtTitle.PlaceholderText = LangHelper.Instance.GetString("Title and Summary of content");
            txtContent.PlaceholderText = LangHelper.Instance.GetString("Detailed content");
            btnCreate.Text = LangHelper.Instance.GetString("Create");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtContent.Text == "")
            {
                CustomMessageBox.ShowBox(LangHelper.Instance.GetString("Please fill in all information!"), "Error");
                return;
            }
            UpdateViewModelFromForm();
            try
            {
                viewModel.CreateNotification();
                CustomMessageBox.ShowBox(LangHelper.Instance.GetString("Create notification successfully!"), "Success");
                reset();
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowBox("Error when create notification: " + ex.Message, "Error");
            }
        }

        void UpdateViewModelFromForm()
        {
            viewModel.Title = txtTitle.Text;
            viewModel.Content = txtContent.Text;
        }
        void reset()
        {
            txtTitle.Text = "";
            txtContent.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset(); 
        }
    }
}
