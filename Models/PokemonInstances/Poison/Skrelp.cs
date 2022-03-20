using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Skrelp PokemonInstance Class
	#region Skrelp
	public class Skrelp : PokemonInstance
	{
		#region Skrelp Constructors
		/// <summary>
		/// Skrelp Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Skrelp(string nickname, int level)
		: base(
				SkrelpSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skrelp Constructor only waiting for a Level
		/// </summary>
		public Skrelp(int level)
		: this( "Skrelp", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skrelp Constructor waiting for no params
		/// </summary>
		/*
		public Skrelp() : this( "Skrelp", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}