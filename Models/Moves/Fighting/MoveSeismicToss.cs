using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts damage equal to the user's level.
	public class MoveSeismicToss : Move
	{
#nullable enable
		private static MoveSeismicToss? _instance = null;
#nullable restore
        public static MoveSeismicToss Instance => _instance ?? (_instance = new MoveSeismicToss());

		public MoveSeismicToss() : base(
			"Seismic-Toss",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}