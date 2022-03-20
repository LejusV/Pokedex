using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Genesect PokemonInstance Class
	#region Genesect
	public class Genesect : PokemonInstance
	{
		#region Genesect Constructors
		/// <summary>
		/// Genesect Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Genesect(string nickname, int level)
		: base(
				GenesectSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Genesect Constructor only waiting for a Level
		/// </summary>
		public Genesect(int level)
		: this( "Genesect", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Genesect Constructor waiting for no params
		/// </summary>
		/*
		public Genesect() : this( "Genesect", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}