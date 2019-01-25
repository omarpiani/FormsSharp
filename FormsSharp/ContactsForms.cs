using FormsSharp.Models;
using SharpRepository.EfRepository;
using SharpRepository.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FormsSharp
{
    public partial class ContactsForms : Form
    {
        protected IRepository<Contact, int> repo;

        public ContactsForms()
        {
            InitializeComponent();

            repo = new EfRepository<Contact, int>(new FormSharpDbContext());
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            contactsGrid.DataSource = repo.GetAll();

        }

        private void contactsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
