using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Darmanitan-Standard PokemonInstance Class
	#region Darmanitan-Standard
	public class DarmanitanStandard : PokemonInstance
	{
		#region Darmanitan-Standard Constructors
		/// <summary>
		/// Darmanitan-Standard Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DarmanitanStandard(string nickname, int level)
		: base(
				DarmanitanStandardSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Darmanitan-Standard Constructor only waiting for a Level
		/// </summary>
		public DarmanitanStandard(int level)
		: this( "Darmanitan-Standard", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Darmanitan-Standard Constructor waiting for no params
		/// </summary>
		/*
		public DarmanitanStandard() : this( "Darmanitan-Standard", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}