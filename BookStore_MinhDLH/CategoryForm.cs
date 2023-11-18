using Repositories.Entities;
using Services;

namespace BookStore_MinhDLH
{
    public partial class CategoryForm : Form
    {
        private BookCategoryService _categoryService = new BookCategoryService();

        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            dgvCateList.DataSource = null;
            dgvCateList.DataSource = _categoryService.GetAllCategories();
            dgvCateList.Columns["Books"].Visible = false;
        }

        private void dgvCateList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCateList.SelectedRows.Count > 0)
            {
                var selectedCate = (BookCategory)dgvCateList.SelectedRows[0].DataBoundItem;

                txtId.Text = selectedCate.BookCategoryId.ToString();
                txtBookGenreType.Text = selectedCate.BookGenreType.ToString();
                txtDescription.Text = selectedCate.Description.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKeyword.Text))
            {
                MessageBox.Show("The search keyword is required!!!",
                    "Search keyword required",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = _categoryService.SearchCates(txtKeyword.Text.Trim());

            dgvCateList.DataSource = null;
            dgvCateList.DataSource = result;
            dgvCateList.Columns["Books"].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;

            if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("The BookModel ID is invalid. Please input a number!!!",
                    "Invalid BookModel ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            _categoryService.DeleteCate(id);

            var result = _categoryService.GetAllCategories();
            dgvCateList.DataSource = null;
            dgvCateList.DataSource = result;
            dgvCateList.Columns["Books"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BookCategory cate = new BookCategory();
            int id;
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Invalid Input", "Input ID Pls!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (int.TryParse(txtId.Text, out id))
            {
                if (id <= 0)
                {
                    MessageBox.Show("Invalid Input", "Input Integer Greater Than 0 Pls!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var existingCate = _categoryService.GetCategoryById(id);
                if (existingCate != null)
                {
                    MessageBox.Show("ID Exists", "ID already exists!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cate.BookCategoryId = id;
            }
            else
            {
                MessageBox.Show("Invalid Input", "Input Integer Pls!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existingGenre = _categoryService.GetCategoryByGenre(txtBookGenreType.Text);
            if (existingGenre == null)
            {
                if (string.IsNullOrWhiteSpace(txtBookGenreType.Text))
                {
                    MessageBox.Show("Invalid Input", "Input Genre Type Pls!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cate.BookGenreType = txtBookGenreType.Text;
            }
            else
            {
                MessageBox.Show("Genre Type is Exist!!!", "Enter the new Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Invalid Input", "Input Description Pls!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cate.Description = txtDescription.Text;

            _categoryService.AddCate(cate);
            var result = _categoryService.GetAllCategories();
            dgvCateList.DataSource = null;
            dgvCateList.DataSource = result;
            dgvCateList.Columns["Books"].Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //BookCategory cate = new BookCategory();
            //int id;
            //if (int.TryParse(txtId.Text, out id))
            //{
            //    var existingCate = _categoryService.GetCategoryById(id);
            //    if (existingCate == null)
            //    {
            //        MessageBox.Show("ID Not Found", "ID does not exist!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    cate.BookCategoryId = id;
            //}
            //else
            //{
            //    MessageBox.Show("Invalid Input", "Input Integer Pls!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //cate.BookGenreType = txtBookGenreType.Text;
            //cate.Description = txtDescription.Text;
            //_categoryService.UpdateCate(cate);
            //var result = _categoryService.GetAllCategories();
            //dgvCateList.DataSource = null;    //vip, xoá lưới, lấy danh sách mới
            //dgvCateList.DataSource = result;
            //dgvCateList.Columns["Books"].Visible = false;
            BookCategory cate = new BookCategory();
            int id;
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Invalid Input", "Input ID Pls!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (int.TryParse(txtId.Text, out id))
            {
                if (id <= 0)
                {
                    MessageBox.Show("Invalid Input", "Input Integer Greater Than 0 Pls!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var existingCate = _categoryService.GetCategoryById(id);
                if (existingCate == null)
                {
                    MessageBox.Show("ID Not Found", "ID does not exist!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cate.BookCategoryId = id;
            }
            else
            {
                MessageBox.Show("Invalid Input", "Input Integer Pls!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBookGenreType.Text))
            {
                MessageBox.Show("Invalid Input", "Input Genre Type Pls!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cate.BookGenreType = txtBookGenreType.Text;

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Invalid Input", "Input Description Pls!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cate.Description = txtDescription.Text;

            _categoryService.UpdateCate(cate);
            var result = _categoryService.GetAllCategories();
            dgvCateList.DataSource = null;
            dgvCateList.DataSource = result;
            dgvCateList.Columns["Books"].Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
