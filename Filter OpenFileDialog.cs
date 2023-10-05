private void Add_Files_Click(object sender, RoutedEventArgs e)
  {
    OpenFileDialog openFileDialog = new OpenFileDialog();
    openFileDialog.Multiselect = true;
    openFileDialog.Filter = "All Images Files (*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif)|*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif";
    openFileDialog.Filter = "PNG Portable Network Graphics (*.png)|" + "*.png";
    openFileDialog.Filter = "JPEG File Interchange Format (*.jpg *.jpeg *jfif)|" + "*.jpg;*.jpeg;*.jfif";
    openFileDialog.Filter = "BMP Windows Bitmap (*.bmp)|" + "*.bmp";
    openFileDialog.Filter = "TIF Tagged Imaged File Format (*.tif *.tiff)|" + "*.tif;*.tiff";
    openFileDialog.Filter = "GIF Graphics Interchange Format (*.gif)|" + "*.gif";
  }