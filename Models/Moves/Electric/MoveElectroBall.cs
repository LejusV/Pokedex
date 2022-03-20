using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Power is higher when the user has greater Speed than the target, up to a maximum of 150.
	public class MoveElectroBall : Move
	{
#nullable enable
		private static MoveElectroBall? _instance = null;
#nullable restore
        public static MoveElectroBall Instance => _instance ?? (_instance = new MoveElectroBall());

		public MoveElectroBall() : base(
			"Electro-Ball",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}