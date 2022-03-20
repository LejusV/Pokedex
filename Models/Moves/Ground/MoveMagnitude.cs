using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Power varies randomly from 10 to 150.
	public class MoveMagnitude : Move
	{
#nullable enable
		private static MoveMagnitude? _instance = null;
#nullable restore
        public static MoveMagnitude Instance => _instance ?? (_instance = new MoveMagnitude());

		public MoveMagnitude() : base(
			"Magnitude",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			30, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}