using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Xamarin.Forms;

namespace Util.XamariN.FileExplorer
{
    public class FileSort : DynamicSort
    {
        public FileSort(string fieldNameOrPropertyName, SortDirection sortingType = SortDirection.Ascending)
            : base(fieldNameOrPropertyName, sortingType)
        {

        }

        private ImageSource _SortTypeImage;
        public ImageSource SortTypeImage
        {
            get { return _SortTypeImage; }
            set { _SortTypeImage = value; }
        }

        private ImageSource _DirectionImage;
        public ImageSource DirectionImage
        {
            get { return _DirectionImage; }
            set { _DirectionImage = value; }
        }

        private string _DisplayName;
        public string DisplayName
        {
            get { return _DisplayName; }
            set { _DisplayName = value; }
        }
    }
}
