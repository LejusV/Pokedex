using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IGastroAcid : MoveInstance
	{
		public IGastroAcid() : base( MoveGastroAcid.Instance ) {}
	}
}