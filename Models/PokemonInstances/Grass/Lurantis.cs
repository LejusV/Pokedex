using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Lurantis PokemonInstance Class
	#region Lurantis
	public class Lurantis : PokemonInstance
	{
		#region Lurantis Constructors
		/// <summary>
		/// Lurantis Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Lurantis(string nickname, int level)
		: base(
				LurantisSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lurantis Constructor only waiting for a Level
		/// </summary>
		public Lurantis(int level)
		: this( "Lurantis", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lurantis Constructor waiting for no params
		/// </summary>
		/*
		public Lurantis() : this( "Lurantis", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}