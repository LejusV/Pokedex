using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveEerieSpell : Move
	{
#nullable enable
		private static MoveEerieSpell? _instance = null;
#nullable restore
        public static MoveEerieSpell Instance => _instance ?? (_instance = new MoveEerieSpell());

		public MoveEerieSpell() : base(
			"Eerie-Spell",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}