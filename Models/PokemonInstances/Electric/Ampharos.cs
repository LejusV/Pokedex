using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Ampharos PokemonInstance Class
	#region Ampharos
	public class Ampharos : PokemonInstance
	{
		#region Ampharos Constructors
		/// <summary>
		/// Ampharos Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Ampharos(string nickname, int level)
		: base(
				AmpharosSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ampharos Constructor only waiting for a Level
		/// </summary>
		public Ampharos(int level)
		: this( "Ampharos", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ampharos Constructor waiting for no params
		/// </summary>
		/*
		public Ampharos() : this( "Ampharos", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}