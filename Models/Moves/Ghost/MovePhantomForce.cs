using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User vanishes, dodging all attacks, and hits next turn.  Hits through Protect and Detect.
	public class MovePhantomForce : Move
	{
#nullable enable
		private static MovePhantomForce? _instance = null;
#nullable restore
        public static MovePhantomForce Instance => _instance ?? (_instance = new MovePhantomForce());

		public MovePhantomForce() : base(
			"Phantom-Force",
			Ghost.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}