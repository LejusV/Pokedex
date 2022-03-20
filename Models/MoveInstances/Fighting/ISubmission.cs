using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISubmission : MoveInstance
	{
		public ISubmission() : base( MoveSubmission.Instance ) {}
	}
}