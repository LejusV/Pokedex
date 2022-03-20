using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Simisear PokemonInstance Class
	#region Simisear
	public class Simisear : PokemonInstance
	{
		#region Simisear Constructors
		/// <summary>
		/// Simisear Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Simisear(string nickname, int level)
		: base(
				SimisearSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Simisear Constructor only waiting for a Level
		/// </summary>
		public Simisear(int level)
		: this( "Simisear", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Simisear Constructor waiting for no params
		/// </summary>
		/*
		public Simisear() : this( "Simisear", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}