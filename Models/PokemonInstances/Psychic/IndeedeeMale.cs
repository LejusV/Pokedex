using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Indeedee-Male PokemonInstance Class
	#region Indeedee-Male
	public class IndeedeeMale : PokemonInstance
	{
		#region Indeedee-Male Constructors
		/// <summary>
		/// Indeedee-Male Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public IndeedeeMale(string nickname, int level)
		: base(
				IndeedeeMaleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Indeedee-Male Constructor only waiting for a Level
		/// </summary>
		public IndeedeeMale(int level)
		: this( "Indeedee-Male", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Indeedee-Male Constructor waiting for no params
		/// </summary>
		/*
		public IndeedeeMale() : this( "Indeedee-Male", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}