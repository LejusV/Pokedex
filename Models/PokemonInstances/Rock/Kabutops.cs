using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Kabutops PokemonInstance Class
	#region Kabutops
	public class Kabutops : PokemonInstance
	{
		#region Kabutops Constructors
		/// <summary>
		/// Kabutops Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Kabutops(string nickname, int level)
		: base(
				KabutopsSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kabutops Constructor only waiting for a Level
		/// </summary>
		public Kabutops(int level)
		: this( "Kabutops", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kabutops Constructor waiting for no params
		/// </summary>
		/*
		public Kabutops() : this( "Kabutops", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}