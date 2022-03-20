using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveCorrosiveGas : Move
	{
#nullable enable
		private static MoveCorrosiveGas? _instance = null;
#nullable restore
        public static MoveCorrosiveGas Instance => _instance ?? (_instance = new MoveCorrosiveGas());

		public MoveCorrosiveGas() : base(
			"Corrosive-Gas",
			Poison.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}