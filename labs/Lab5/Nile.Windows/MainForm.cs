/*
* Luisalberto Castaneda
* 12/07/2021
* ITSE 1430
*/

using System;
using System.Linq;
using System.Windows.Forms;

using Microsoft.Extensions.Configuration;

using Nile.Stores.Sql;

namespace Nile.Windows
{
    public partial class MainForm : Form
    {
        #region Construction

        public MainForm ()
        {
            InitializeComponent();
            _database = new SqlProductDatabase(GetConnectionString("ProductDatabase"));
        }
        #endregion

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);

            _gridProducts.AutoGenerateColumns = false;

            UpdateList();
        }

        #region Event Handlers

        private void OnFileExit ( object sender, EventArgs e )
        {
            Close();
        }

        private void OnProductAdd ( object sender, EventArgs e )
        {
            var child = new ProductDetailForm("Product Details");

            do
            {
                if (child.ShowDialog(this) != DialogResult.OK)
                    return;

                try
                {
                    _database.Add(child.Product);
                    UpdateList();
                    return;
                } catch (Exception ex)
                {
                    DisplayError(ex.Message, "Add Failed");
                }
            } while (true);
        }

        private void OnProductEdit ( object sender, EventArgs e )
        {
            var product = GetSelectedProduct();
            if (product == null)
            {
                MessageBox.Show("No products available.");
                return;
            };

            EditProduct(product);
        }

        private void OnProductDelete ( object sender, EventArgs e )
        {
            var product = GetSelectedProduct();
            if (product == null)
                return;

            DeleteProduct(product);
        }

        private void OnEditRow ( object sender, DataGridViewCellEventArgs e )
        {
            var grid = sender as DataGridView;

            //Handle column clicks
            if (e.RowIndex < 0)
                return;

            var row = grid.Rows[e.RowIndex];
            var item = row.DataBoundItem as Product;

            if (item != null)
                EditProduct(item);
        }

        private void OnKeyDownGrid ( object sender, KeyEventArgs e )
        {
            if (e.KeyCode != Keys.Delete)
                return;

            var product = GetSelectedProduct();
            if (product != null)
                DeleteProduct(product);

            //Don't continue with key
            e.SuppressKeyPress = true;
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var child = new AboutForm();

            child.ShowDialog();
        }

        private void DisplayError ( string message, string title )
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region Private Members

        private void DeleteProduct ( Product product )
        {
            if (MessageBox.Show(this, $"Are you sure you want to delete '{product.Name}'?",
                                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                _database.Delete(product.Id);
                UpdateList();
            } catch (Exception ex)
            {
                DisplayError(ex.Message, "Delete Failed");
            }
        }

        private void EditProduct ( Product product )
        {
            var child = new ProductDetailForm("Product Details");
            child.Product = product;

            do
            {
                if (child.ShowDialog(this) != DialogResult.OK)
                    return;

                try
                {
                    _database.Update(child.Product);
                    UpdateList();
                    return;
                } catch (Exception ex)
                {
                    DisplayError(ex.Message, "Update Failed");
                }
            } while (true);
        }

        private Product GetSelectedProduct ()
        {
            if (_gridProducts.SelectedRows.Count > 0)
                return _gridProducts.SelectedRows[0].DataBoundItem as Product;

            return null;
        }

        private void UpdateList ()
        {
            try
            {
                _bsProducts.DataSource = _database.GetAll().OrderBy(x => x.Name);
            } catch (Exception ex)
            {
                DisplayError(ex.Message, "Retrival Failed");
            }
        }

        private string GetConnectionString ( string name ) => Program.Configuration.GetConnectionString(name);

        private readonly IProductDatabase _database;

        #endregion
    }
}