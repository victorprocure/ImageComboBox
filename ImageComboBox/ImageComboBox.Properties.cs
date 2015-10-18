//-----------------------------------------------------------------------
// <copyright file="ImageComboBox.cs" company="Procure Development">
//     Copyright (c) Procure Development. All rights reserved.
// </copyright>
// <author>Victor Procure</author>
//-----------------------------------------------------------------------

namespace ImageComboBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Contains all properties for the combo box
    /// </summary>
    public partial class ImageComboBox : ComboBox
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new ComboCollection<ComboBoxItem> Items
        {
            get { return this.items; }
            set { items = value; }
        }
    }
}