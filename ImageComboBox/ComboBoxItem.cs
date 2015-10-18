//-----------------------------------------------------------------------
// <copyright file="ComboBoxItem.cs" company="Procure Development">
//     Copyright (c) Procure Development. All rights reserved.
// </copyright>
// <author>Victor Procure</author>
//-----------------------------------------------------------------------
namespace ImageComboBox
{
    using System;
    using System.Drawing;

    /// <summary>
    /// Combo box item with image
    /// </summary>
    [Serializable]
    public class ComboBoxItem
    {
        /// <summary>
        /// The value
        /// </summary>
        private object value;

        /// <summary>
        /// The image
        /// </summary>
        private Image image;

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public object Value
        {
            get
            {
                return this.value;
            }

            set
            {
                this.value = value;
            }
        }

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>
        /// The image.
        /// </value>
        public Image Image
        {
            get
            {
                return image;
            }

            set
            {
                this.image = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComboBoxItem"/> class.
        /// </summary>
        public ComboBoxItem() : this(string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComboBoxItem"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public ComboBoxItem(object value) : this(value, new Bitmap(1, 1))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComboBoxItem"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="image">The image.</param>
        public ComboBoxItem(object value, Image image)
        {
            this.value = value;

            this.image = image;
        }
    }
}