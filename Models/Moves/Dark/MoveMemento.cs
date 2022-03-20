using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Attack and Special Attack by two stages.  User faints.
	public class MoveMemento : Move
	{
#nullable enable
		private static MoveMemento? _instance = null;
#nullable restore
        public static MoveMemento Instance => _instance ?? (_instance = new MoveMemento());

		public MoveMemento() : base(
			"Memento",
			Dark.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}