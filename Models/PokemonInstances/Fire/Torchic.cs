using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Torchic PokemonInstance Class
	#region Torchic
	public class Torchic : PokemonInstance
	{
		#region Torchic Constructors
		/// <summary>
		/// Torchic Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Torchic(string nickname, int level)
		: base(
				TorchicSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Torchic Constructor only waiting for a Level
		/// </summary>
		public Torchic(int level)
		: this( "Torchic", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Torchic Constructor waiting for no params
		/// </summary>
		/*
		public Torchic() : this( "Torchic", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}