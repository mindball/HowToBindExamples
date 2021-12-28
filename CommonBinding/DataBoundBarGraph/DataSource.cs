﻿using System.Collections.ObjectModel;

namespace CommonBinding.DataBoundBarGraph
{
    public class DataSource
    {
        private ObservableCollection<int> valueCollection;

        public ObservableCollection<int> ValueCollection
        {
            get
            {
                return valueCollection;
            }
            set
            {
                valueCollection = value;
            }
        }

            public DataSource()
            {
            valueCollection = new ObservableCollection<int>();
            valueCollection.Add(50);
            valueCollection.Add(75);
            valueCollection.Add(48);
            valueCollection.Add(63);
            valueCollection.Add(71);
        }

    }
}
