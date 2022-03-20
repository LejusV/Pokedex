using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Toxel PokemonInstance Class
	#region Toxel
	public class Toxel : PokemonInstance
	{
		#region Toxel Constructors
		/// <summary>
		/// Toxel Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Toxel(string nickname, int level)
		: base(
				ToxelSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toxel Constructor only waiting for a Level
		/// </summary>
		public Toxel(int level)
		: this( "Toxel", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toxel Constructor waiting for no params
		/// </summary>
		/*
		public Toxel() : this( "Toxel", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}