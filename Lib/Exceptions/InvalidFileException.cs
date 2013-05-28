using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FSEditor.Exceptions {
	public class InvalidFileException : ApplicationException {
		public InvalidFileException() : base("Error while loading file. This does not seem to be a valid Fortune Street Board file.") { }
	}
}
