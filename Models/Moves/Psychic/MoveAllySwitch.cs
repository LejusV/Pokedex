using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User switches places with the friendly Pokémon opposite it.
	public class MoveAllySwitch : Move
	{
#nullable enable
		private static MoveAllySwitch? _instance = null;
#nullable restore
        public static MoveAllySwitch Instance => _instance ?? (_instance = new MoveAllySwitch());

		public MoveAllySwitch() : base(
			"Ally-Switch",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 2 // Acc & Priority
		) {}
	}
}