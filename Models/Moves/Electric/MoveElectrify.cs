using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Changes the target's move's type to electric if it hasn't moved yet this turn.
	public class MoveElectrify : Move
	{
#nullable enable
		private static MoveElectrify? _instance = null;
#nullable restore
        public static MoveElectrify Instance => _instance ?? (_instance = new MoveElectrify());

		public MoveElectrify() : base(
			"Electrify",
			Electric.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}