using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Regice PokemonInstance Class
	#region Regice
	public class Regice : PokemonInstance
	{
		#region Regice Constructors
		/// <summary>
		/// Regice Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Regice(string nickname, int level)
		: base(
				RegiceSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regice Constructor only waiting for a Level
		/// </summary>
		public Regice(int level)
		: this( "Regice", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regice Constructor waiting for no params
		/// </summary>
		/*
		public Regice() : this( "Regice", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}