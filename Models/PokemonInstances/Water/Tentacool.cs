using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Tentacool PokemonInstance Class
	#region Tentacool
	public class Tentacool : PokemonInstance
	{
		#region Tentacool Constructors
		/// <summary>
		/// Tentacool Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Tentacool(string nickname, int level)
		: base(
				TentacoolSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tentacool Constructor only waiting for a Level
		/// </summary>
		public Tentacool(int level)
		: this( "Tentacool", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tentacool Constructor waiting for no params
		/// </summary>
		/*
		public Tentacool() : this( "Tentacool", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}