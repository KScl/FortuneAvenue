using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace FSEditor.FSData {
	public class Position : INotifyPropertyChanged {
		#region Fields & Properties
		// ----------------------------------------------------------------------------------------------------
		/// <summary>
		/// Gets or sets the x-coordinate of this object.
		/// </summary>
        public virtual Int16 X
        {
            get
            {
                return _X;
            }

            set
            {
                _X = value;
                RaisePropertyChanged("X");
            }
        }
        private Int16 _X;
		/// <summary>
		/// Gets or sets the y-coordinate of this object.
		/// </summary>
        public virtual Int16 Y
        {
            get
            {
                return _Y;
            }

            set
            {
                _Y = value;
                RaisePropertyChanged("Y");
            }
        }
        private Int16 _Y;
		// ----------------------------------------------------------------------------------------------------
		#endregion

		#region Initialization
		// ----------------------------------------------------------------------------------------------------
		/// <summary>
		/// Default Constructor.
		/// </summary>
		/// <param name="x">The x-coordinate of the object.</param>
		/// <param name="y">The y-coordinate of the object.</param>
		public Position(Int16 x, Int16 y) {
			this.X = x;
			this.Y = y;
		} 
		// ----------------------------------------------------------------------------------------------------
		#endregion

        #region INotifyPropertyChanged Members
        [NonSerialized]
        protected System.ComponentModel.PropertyChangedEventHandler _PropertyChanged;
        public virtual event System.ComponentModel.PropertyChangedEventHandler PropertyChanged
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
            add
            {
                _PropertyChanged += value;
            }

            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
            remove
            {
                _PropertyChanged -= value;
            }
        }

        protected virtual void RaisePropertyChanged(string name)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = _PropertyChanged;
            if (handler != null)
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(name));
            }
        }
        #endregion
	}
}
