using Repositories.Entities;
using Services;

namespace BookStore_MinhDLH
{
    public partial class BookForm : Form
    {
        public int? BookId { get; set; }
        public string BookName { get; set; } = null!;
        private BookService _bookService = new();
        private BookCategoryService _categoryService = new();

        public BookForm()
        {
            InitializeComponent();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            cboCategory.DataSource = _categoryService.GetAllCategories();

            cboCategory.DisplayMember = "BookGenreType";
            cboCategory.ValueMember = "BookCategoryId";

            if (this.BookId != null)
            {
                var book = _bookService.GetABook((int)BookId);

                txtId.Text = book.BookId.ToString();
                txtName.Text = book.BookName;
                txtDescription.Text = book.Description;
                dtpReleasedDate.Value = book.ReleaseDate;
                txtQuantity.Text = book.Quantity.ToString();
                txtPrice.Text = book.Price.ToString();
                cboCategory.SelectedValue = book.BookCategoryId;
                txtAuthor.Text = book.Author;
                lblFormTitle.Text = "Update a BookModel...";
            }

            if(lblFormTitle.Text == "Update a BookModel...")
            {
                txtId.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Book book = new()
            //{
            //    BookId = int.Parse(txtId.Text.Trim()),
            //    BookName = txtName.Text.Trim(),
            //    Description = txtDescription.Text.Trim(),
            //    ReleaseDate = dtpReleasedDate.Value.Date, //chỉ lấy ngày, ko lấy giờ
            //    Author = txtAuthor.Text.Trim(),
            //    Quantity = int.Parse(txtQuantity.Text.Trim()),
            //    Price = double.Parse(txtPrice.Text.Trim()),
            //    BookCategoryId = int.Parse(cboCategory.SelectedValue.ToString())
            //};

            //if (BookId != null)  //mode update
            //    _bookService.UpdateABook(book);
            //else 
            //{
            //    var existingBook = _bookService.SearchBooksByName(book.BookName);
            //    if (existingBook != null)
            //    {
            //        MessageBox.Show("Book Exists", "Book already exists!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    _bookService.AddABook(book); 
            //}

            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtDescription.Text) || string.IsNullOrWhiteSpace(txtAuthor.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(cboCategory.SelectedValue.ToString()))
            {
                MessageBox.Show("Invalid Input", "Please fill in all fields!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = int.Parse(txtId.Text.Trim());
            if (id < 1)
            {
                MessageBox.Show("Invalid Input", "ID must be greater than 0!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Book book = new()
            {
                BookId = id,
                BookName = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                ReleaseDate = dtpReleasedDate.Value.Date,
                Author = txtAuthor.Text.Trim(),
                Quantity = int.Parse(txtQuantity.Text.Trim()),
                Price = double.Parse(txtPrice.Text.Trim()),
                BookCategoryId = int.Parse(cboCategory.SelectedValue.ToString())
            };

            if (BookId != null)
                _bookService.UpdateABook(book);
            else
            {
                var existingBook = _bookService.SearchBooksByName(book.BookName);
                if (existingBook != null)
                {
                    MessageBox.Show("Book Exists", "Book already exists!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _bookService.AddABook(book);
            }

            Close();

        }
    }
}
