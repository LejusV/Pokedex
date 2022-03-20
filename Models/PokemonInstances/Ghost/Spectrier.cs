using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Spectrier PokemonInstance Class
	#region Spectrier
	public class Spectrier : PokemonInstance
	{
		#region Spectrier Constructors
		/// <summary>
		/// Spectrier Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Spectrier(string nickname, int level)
		: base(
				SpectrierSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spectrier Constructor only waiting for a Level
		/// </summary>
		public Spectrier(int level)
		: this( "Spectrier", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spectrier Constructor waiting for no params
		/// </summary>
		/*
		public Spectrier() : this( "Spectrier", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}