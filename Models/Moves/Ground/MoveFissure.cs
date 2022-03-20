using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Causes a one-hit KO.
	public class MoveFissure : Move
	{
#nullable enable
		private static MoveFissure? _instance = null;
#nullable restore
        public static MoveFissure Instance => _instance ?? (_instance = new MoveFissure());

		public MoveFissure() : base(
			"Fissure",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, null,// PP & Pow
			30, 0 // Acc & Priority
		) {}
	}
}