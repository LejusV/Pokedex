using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Aerodactyl PokemonInstance Class
	#region Aerodactyl
	public class Aerodactyl : PokemonInstance
	{
		#region Aerodactyl Constructors
		/// <summary>
		/// Aerodactyl Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Aerodactyl(string nickname, int level)
		: base(
				AerodactylSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aerodactyl Constructor only waiting for a Level
		/// </summary>
		public Aerodactyl(int level)
		: this( "Aerodactyl", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aerodactyl Constructor waiting for no params
		/// </summary>
		/*
		public Aerodactyl() : this( "Aerodactyl", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}