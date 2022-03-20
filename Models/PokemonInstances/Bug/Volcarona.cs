using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Volcarona PokemonInstance Class
	#region Volcarona
	public class Volcarona : PokemonInstance
	{
		#region Volcarona Constructors
		/// <summary>
		/// Volcarona Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Volcarona(string nickname, int level)
		: base(
				VolcaronaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Volcarona Constructor only waiting for a Level
		/// </summary>
		public Volcarona(int level)
		: this( "Volcarona", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Volcarona Constructor waiting for no params
		/// </summary>
		/*
		public Volcarona() : this( "Volcarona", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}