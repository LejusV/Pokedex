using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Pangoro PokemonInstance Class
	#region Pangoro
	public class Pangoro : PokemonInstance
	{
		#region Pangoro Constructors
		/// <summary>
		/// Pangoro Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Pangoro(string nickname, int level)
		: base(
				PangoroSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pangoro Constructor only waiting for a Level
		/// </summary>
		public Pangoro(int level)
		: this( "Pangoro", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pangoro Constructor waiting for no params
		/// </summary>
		/*
		public Pangoro() : this( "Pangoro", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}