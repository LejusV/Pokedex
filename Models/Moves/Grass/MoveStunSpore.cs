using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Paralyzes the target.
	public class MoveStunSpore : Move
	{
#nullable enable
		private static MoveStunSpore? _instance = null;
#nullable restore
        public static MoveStunSpore Instance => _instance ?? (_instance = new MoveStunSpore());

		public MoveStunSpore() : base(
			"Stun-Spore",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			75, 0 // Acc & Priority
		) {}
	}
}