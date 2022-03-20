using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage.
	public class MovePetalBlizzard : Move
	{
#nullable enable
		private static MovePetalBlizzard? _instance = null;
#nullable restore
        public static MovePetalBlizzard Instance => _instance ?? (_instance = new MovePetalBlizzard());

		public MovePetalBlizzard() : base(
			"Petal-Blizzard",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}