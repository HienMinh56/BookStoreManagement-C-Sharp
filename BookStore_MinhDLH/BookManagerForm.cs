using Repositories.Entities;
using Services;

namespace BookStore_MinhDLH
{
    public partial class BookManagerForm : Form
    {
        public BookManagementMember Account { get; set; }

        private BookService _bookService = new BookService();
        private BookCategoryService _categoryService = new BookCategoryService();

        public BookManagerForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BookManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BookManagerForm_Load(object sender, EventArgs e)
        {
            var result = _bookService.GetAllBooks();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;

            cboCategory.DataSource = _categoryService.GetAllCategories();
            cboCateSearch.DataSource = _categoryService.GetAllCategories();

            cboCategory.DisplayMember = "BookGenreType";
            cboCategory.ValueMember = "BookCategoryId";

            cboCateSearch.DisplayMember = "BookGenreType";
            cboCateSearch.ValueMember = "BookCategoryId";

            lblHello.Text = "Hello: " + Account.FullName;

            if (Account.MemberRole == 2)
            {
                txtId.Enabled = false;
                btnDelete.Enabled = false;
                btnModify.Enabled = false;
            }

            if (Account.MemberRole == 3)
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                txtId.Enabled = false;
                btnDelete.Enabled = false;
                btnModify.Enabled = false;
            }

        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count > 0)
            {
                var selectedBook = (Book)dgvBookList.SelectedRows[0].DataBoundItem;

                txtId.Text = selectedBook.BookId.ToString();
                txtName.Text = selectedBook.BookName;
                txtDescription.Text = selectedBook.Description;
                dtpReleasedDate.Value = selectedBook.ReleaseDate;
                txtQuantity.Text = selectedBook.Quantity.ToString();
                txtPrice.Text = selectedBook.Price.ToString();
                cboCategory.SelectedValue = selectedBook.BookCategoryId;
                txtAuthor.Text = selectedBook.Author;
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

            var result = _bookService.SearchBooks(txtKeyword.Text.Trim());

            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;

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
            _bookService.DeleteABook(id);

            var result = _bookService.GetAllBooks();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("The BookModel ID is invalid. Please select a row in the grid to edit or input a number!!!",
                    "Invalid BookModel ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            BookForm bookForm = new BookForm();
            bookForm.BookId = int.Parse(txtId.Text);
            bookForm.ShowDialog();

            var result = _bookService.GetAllBooks();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.BookId = null;
            bookForm.ShowDialog();

            var result = _bookService.GetAllBooks();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
        }

        private void btnCateSearch_Click(object sender, EventArgs e)
        {

            var result = _bookService.SearchBooksByCate(cboCateSearch.SelectedValue.ToString());

            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.ShowDialog();
        }
    }
}
