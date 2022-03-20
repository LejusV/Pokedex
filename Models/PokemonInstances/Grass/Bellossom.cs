using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Bellossom PokemonInstance Class
	#region Bellossom
	public class Bellossom : PokemonInstance
	{
		#region Bellossom Constructors
		/// <summary>
		/// Bellossom Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Bellossom(string nickname, int level)
		: base(
				BellossomSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bellossom Constructor only waiting for a Level
		/// </summary>
		public Bellossom(int level)
		: this( "Bellossom", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bellossom Constructor waiting for no params
		/// </summary>
		/*
		public Bellossom() : this( "Bellossom", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}