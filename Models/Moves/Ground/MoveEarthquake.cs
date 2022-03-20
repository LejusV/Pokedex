using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage and can hit Dig users.
	public class MoveEarthquake : Move
	{
#nullable enable
		private static MoveEarthquake? _instance = null;
#nullable restore
        public static MoveEarthquake Instance => _instance ?? (_instance = new MoveEarthquake());

		public MoveEarthquake() : base(
			"Earthquake",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 100,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}