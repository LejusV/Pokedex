using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//
	public class MoveDragonDarts : Move
	{
#nullable enable
		private static MoveDragonDarts? _instance = null;
#nullable restore
        public static MoveDragonDarts Instance => _instance ?? (_instance = new MoveDragonDarts());

		public MoveDragonDarts() : base(
			"Dragon-Darts",
			Dragon.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 50,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}