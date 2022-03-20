using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Protects all friendly Pokémon from damaging moves.  Only works on the first turn after the user is sent out.
	public class MoveMatBlock : Move
	{
#nullable enable
		private static MoveMatBlock? _instance = null;
#nullable restore
        public static MoveMatBlock Instance => _instance ?? (_instance = new MoveMatBlock());

		public MoveMatBlock() : base(
			"Mat-Block",
			Fighting.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}