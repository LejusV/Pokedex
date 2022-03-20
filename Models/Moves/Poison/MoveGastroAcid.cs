using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Nullifies target's ability until it leaves battle.
	public class MoveGastroAcid : Move
	{
#nullable enable
		private static MoveGastroAcid? _instance = null;
#nullable restore
        public static MoveGastroAcid Instance => _instance ?? (_instance = new MoveGastroAcid());

		public MoveGastroAcid() : base(
			"Gastro-Acid",
			Poison.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}