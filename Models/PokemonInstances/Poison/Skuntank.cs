using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Skuntank PokemonInstance Class
	#region Skuntank
	public class Skuntank : PokemonInstance
	{
		#region Skuntank Constructors
		/// <summary>
		/// Skuntank Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Skuntank(string nickname, int level)
		: base(
				SkuntankSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skuntank Constructor only waiting for a Level
		/// </summary>
		public Skuntank(int level)
		: this( "Skuntank", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skuntank Constructor waiting for no params
		/// </summary>
		/*
		public Skuntank() : this( "Skuntank", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}