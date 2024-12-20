using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ServiceLayer.Models;
using ServiceLayer.Services;

namespace FragrantWorld.Pages
{
    /// <summary>
    /// Логика взаимодействия для ShopPage.xaml
    /// </summary>
    public partial class ShopPage : Page
    {
        private readonly ProductService _productService = new();
        public ShopPage(User user = null)
        {
            InitializeComponent();
            if (user == null)
            {
                UserTextBlock.Text = "Гость";
            }
            else
            {
                UserTextBlock.Text = user.Surname + " " + user.Name + " " + user.Patronymic;
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (App.CurrentFrame.CanGoBack)
                App.CurrentFrame.GoBack();
        }

        private void CreatProductCard(Product productItem)
        {
            try
            {
                StackPanel panel = new()
                {
                    Width = 630,
                    Background = new SolidColorBrush(Color.FromRgb(173, 216, 230)),
                    
                };

                Border border = new()
                {
                    Width = 634,
                    Margin = new Thickness(20),
                    BorderBrush = new SolidColorBrush(Color.FromRgb(0, 0, 0)),
                    BorderThickness = new Thickness(1),
                    CornerRadius = new CornerRadius(5),
                };

                Grid grid = new() { };
                grid.RowDefinitions.Add(new RowDefinition());
                grid.RowDefinitions.Add(new RowDefinition());
                grid.RowDefinitions.Add(new RowDefinition());
                grid.RowDefinitions.Add(new RowDefinition());
                grid.ColumnDefinitions.Add(new ColumnDefinition());
                grid.ColumnDefinitions.Add(new ColumnDefinition());

                TextBlock ProductTextBlock = new TextBlock()
                {
                    Text = productItem.Name,
                    FontWeight = FontWeights.Bold
                };
                Grid.SetRow(ProductTextBlock, 0);
                Grid.SetColumn(ProductTextBlock, 0);
                grid.Children.Add(ProductTextBlock);

                TextBlock DescriptionTextBlock = new TextBlock
                {
                    Text = productItem.Description
                };
                Grid.SetRow(DescriptionTextBlock, 1);
                Grid.SetColumn(DescriptionTextBlock, 0);
                grid.Children.Add(DescriptionTextBlock);

                TextBlock ManufacturerTextBlock = new TextBlock
                {
                    Text = $"Производитель: {productItem.Manufacturer}",
                };
                Grid.SetRow(ManufacturerTextBlock, 2);
                Grid.SetColumn(ManufacturerTextBlock, 0);
                grid.Children.Add(ManufacturerTextBlock);

                TextBlock PriceTextBlock = new TextBlock
                {
                    Text = $"Цена: {productItem.Cost}",
                };
                Grid.SetRow(PriceTextBlock, 3);
                Grid.SetColumn(PriceTextBlock, 0);
                grid.Children.Add(PriceTextBlock);

                Button OrderButton = new Button
                {
                    Content = "Заказать",
                    HorizontalAlignment = HorizontalAlignment.Right,
                };
                Grid.SetRow(OrderButton, 3);
                Grid.SetColumn(OrderButton, 1);
                grid.Children.Add(OrderButton);

                panel.Children.Add(grid);
                border.Child = panel;
                ProductStackPanel.Children.Add(border);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            await LoadProductsAsync();
        }
        private async Task LoadProductsAsync()
        {
            try
            {
                var products = await _productService.GetProductsAsync();
                foreach (Product product in products)
                    CreatProductCard(product);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
