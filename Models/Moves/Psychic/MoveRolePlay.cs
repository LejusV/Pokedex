using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Copies the target's ability.
	public class MoveRolePlay : Move
	{
#nullable enable
		private static MoveRolePlay? _instance = null;
#nullable restore
        public static MoveRolePlay Instance => _instance ?? (_instance = new MoveRolePlay());

		public MoveRolePlay() : base(
			"Role-Play",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}