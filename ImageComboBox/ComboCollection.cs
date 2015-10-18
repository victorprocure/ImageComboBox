//-----------------------------------------------------------------------
// <copyright file="ComboCollection.cs" company="Procure Development">
//     Copyright (c) Procure Development. All rights reserved.
// </copyright>
// <author>Victor Procure</author>
//-----------------------------------------------------------------------

namespace ImageComboBox
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    ///
    /// </summary>
    public class ComboCollection<TComboBoxItem> : CollectionBase
    {
        public event EventHandler<EventArgs> UpdateItems;

        public ComboBox.ObjectCollection ItemsBase { get; set; }

        public ComboBoxItem this[int index]
        {
            get
            {
                return ((ComboBoxItem)ItemsBase[index]);
            }
            set
            {
                ItemsBase[index] = value;
            }
        }

        public int Add(ComboBoxItem value)
        {
            var result = ItemsBase.Add(value);
            UpdateItems.Invoke(this, EventArgs.Empty);
            return result;
        }

        public int IndexOf(ComboBoxItem value)
        {
            return (ItemsBase.IndexOf(value));
        }

        public void Insert(int index, ComboBoxItem value)
        {
            ItemsBase.Insert(index, value);
            UpdateItems.Invoke(this, EventArgs.Empty);
        }

        public void Remove(ComboBoxItem value)
        {
            ItemsBase.Remove(value);
            UpdateItems.Invoke(this, EventArgs.Empty);
        }

        public bool Contains(ComboBoxItem value)
        {
            return (ItemsBase.Contains(value));
        }
    }
}