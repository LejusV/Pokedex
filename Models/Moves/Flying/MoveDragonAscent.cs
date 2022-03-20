using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the user's Defense and Special Defense by one stage after inflicting damage.
	public class MoveDragonAscent : Move
	{
#nullable enable
		private static MoveDragonAscent? _instance = null;
#nullable restore
        public static MoveDragonAscent Instance => _instance ?? (_instance = new MoveDragonAscent());

		public MoveDragonAscent() : base(
			"Dragon-Ascent",
			Flying.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 120,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}