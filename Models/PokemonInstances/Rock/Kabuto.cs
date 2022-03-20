using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Kabuto PokemonInstance Class
	#region Kabuto
	public class Kabuto : PokemonInstance
	{
		#region Kabuto Constructors
		/// <summary>
		/// Kabuto Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Kabuto(string nickname, int level)
		: base(
				KabutoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kabuto Constructor only waiting for a Level
		/// </summary>
		public Kabuto(int level)
		: this( "Kabuto", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kabuto Constructor waiting for no params
		/// </summary>
		/*
		public Kabuto() : this( "Kabuto", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}