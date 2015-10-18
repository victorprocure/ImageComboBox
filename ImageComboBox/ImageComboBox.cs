using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageComboBox
{
    public partial class ImageComboBox : ComboBox
    {
        public ImageComboBox()
        {
            InitializeComponent();

            DropDownStyle = ComboBoxStyle.DropDownList;
            DrawMode = DrawMode.OwnerDrawVariable;
            DrawItem += ImageComboBoxDrawItem;
            MeasureItem += ImageComboBoxMeasureItem;
        }

        protected override ControlCollection CreateControlsInstance()
        {
            items = new ComboCollection<ComboBoxItem>
            {
                ItemsBase = base.Items
            };

            items.UpdateItems += ItemsUpdateItems;

            return base.CreateControlsInstance();
        }

        private void ItemsUpdateItems(object sender, EventArgs e)
        {
        }

        private void ImageComboBoxMeasureItem(object sender, MeasureItemEventArgs e)
        {
            var g = CreateGraphics();
            var maxWidth = 0;
            foreach (var width in Items.ItemsBase.Cast<object>().Select(element => (int)g.MeasureString(element.ToString(), Font).Width).Where(width => width > maxWidth))
            {
                maxWidth = width;
            }

            DropDownWidth = maxWidth + 20;
        }

        private void ImageComboBoxDrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index != -1)
            {
                var comboBoxItem = Items[e.Index];

                e.Graphics.DrawImage(comboBoxItem.Image, e.Bounds.X, e.Bounds.Y, ItemHeight, ItemHeight);

                e.Graphics.DrawString(Items[e.Index].Value.ToString(), Font, Brushes.Black, new RectangleF(e.Bounds.X + ItemHeight, e.Bounds.Y, DropDownWidth, ItemHeight));
            }

            e.DrawFocusRectangle();
        }
    }
}