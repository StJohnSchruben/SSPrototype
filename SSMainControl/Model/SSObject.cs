using SSMainControl.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SSMainControl.Model
{
    public class SSObject : INotifyPropertyChanged
    {
        readonly List<SSObject> items = new List<SSObject>();
        private readonly Guid Id = new Guid();
        private bool isSelected;

        public event PropertyChangedEventHandler PropertyChanged;

        public IList<SSObject> Items
        {
            get { return items; }
        }
        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                this.isSelected = value;
                this.OnPropertyChanged();
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public string Name { get; set; }
        public SSObjectType FileType { get; set; }
    }
}
