using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User is immune to Ground moves and effects for five turns.
	public class MoveMagnetRise : Move
	{
#nullable enable
		private static MoveMagnetRise? _instance = null;
#nullable restore
        public static MoveMagnetRise Instance => _instance ?? (_instance = new MoveMagnetRise());

		public MoveMagnetRise() : base(
			"Magnet-Rise",
			Electric.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}