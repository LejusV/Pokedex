using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Keldeo-Ordinary PokemonInstance Class
	#region Keldeo-Ordinary
	public class KeldeoOrdinary : PokemonInstance
	{
		#region Keldeo-Ordinary Constructors
		/// <summary>
		/// Keldeo-Ordinary Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KeldeoOrdinary(string nickname, int level)
		: base(
				KeldeoOrdinarySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Keldeo-Ordinary Constructor only waiting for a Level
		/// </summary>
		public KeldeoOrdinary(int level)
		: this( "Keldeo-Ordinary", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Keldeo-Ordinary Constructor waiting for no params
		/// </summary>
		/*
		public KeldeoOrdinary() : this( "Keldeo-Ordinary", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}