using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FSEditor.FSData {
	public enum SquareType : byte
    {
		Property = 0x00,
		Bank = 0x01,
		VentureSquare = 0x02,

		SuitSquareSpade = 0x03,
		SuitSquareHeart = 0x04,
		SuitSquareDiamond = 0x05,
		SuitSquareClub = 0x06,
		ChangeOfSuitSquareSpade = 0x07,
		ChangeOfSuitSquareHeart = 0x08,
		ChangeOfSuitSquareDiamond = 0x09,
		ChangeOfSuitSquareClub = 0x0A,

		TakeABreakSquare = 0x0B,
		BoonSquare = 0x0C,
		BoomSquare = 0x0D,
		StockBrokerSquare = 0x0E,
		RollOnSquare = 0x10,
		ArcadeSquare = 0x11,
		SwitchSquare = 0x12,
		CannonSquare = 0x13,

		BackStreetSquareA = 0x14,
		BackStreetSquareB = 0x15,
		BackStreetSquareC = 0x16,
		BackStreetSquareD = 0x17,
		BackStreetSquareE = 0x18,

		OneWayAlleyDoorA = 0x1C,
		OneWayAlleyDoorB = 0x1D,
		OneWayAlleyDoorC = 0x1E,
		OneWayAlleyDoorD = 0x1F,

		LiftMagmaliceSquareStart = 0x20,
		MagmaliceSquare = 0x21,
		OneWayAlleySquare = 0x22,
		LiftSquareEnd = 0x23,

		VacantPlot = 0x30
	}
}
