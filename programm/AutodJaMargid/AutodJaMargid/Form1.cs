using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace AutodJaMargid
{
    public partial class MainForm : Form
    {
        private CarsContext? _carsContext;
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this._carsContext = new CarsContext();
            this._carsContext.Database.EnsureCreated();
            this._carsContext.Brands.Load();
            this.brandBindingSource.DataSource = _carsContext.Brands.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this._carsContext?.Dispose();
            this._carsContext = null;
        }

        private void dataGridViewBrands_SelectionChanged(object sender, EventArgs e)
        {
            if (this._carsContext != null)
            {
                var brand = (Brand)this.dataGridViewBrands.CurrentRow.DataBoundItem;

                if (brand != null)
                {
                    this._carsContext.Entry(brand).Collection(e => e.Cars).Load();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this._carsContext?.SaveChanges();
            this.dataGridViewBrands.Refresh();
            this.dataGridViewCars.Refresh();
        }
    }
}
