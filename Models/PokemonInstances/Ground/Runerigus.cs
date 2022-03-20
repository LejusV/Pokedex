using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Runerigus PokemonInstance Class
	#region Runerigus
	public class Runerigus : PokemonInstance
	{
		#region Runerigus Constructors
		/// <summary>
		/// Runerigus Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Runerigus(string nickname, int level)
		: base(
				RunerigusSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Runerigus Constructor only waiting for a Level
		/// </summary>
		public Runerigus(int level)
		: this( "Runerigus", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Runerigus Constructor waiting for no params
		/// </summary>
		/*
		public Runerigus() : this( "Runerigus", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}