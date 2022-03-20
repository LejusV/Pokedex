using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Shelgon PokemonInstance Class
	#region Shelgon
	public class Shelgon : PokemonInstance
	{
		#region Shelgon Constructors
		/// <summary>
		/// Shelgon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Shelgon(string nickname, int level)
		: base(
				ShelgonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shelgon Constructor only waiting for a Level
		/// </summary>
		public Shelgon(int level)
		: this( "Shelgon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shelgon Constructor waiting for no params
		/// </summary>
		/*
		public Shelgon() : this( "Shelgon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}