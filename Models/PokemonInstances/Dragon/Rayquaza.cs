using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Rayquaza PokemonInstance Class
	#region Rayquaza
	public class Rayquaza : PokemonInstance
	{
		#region Rayquaza Constructors
		/// <summary>
		/// Rayquaza Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Rayquaza(string nickname, int level)
		: base(
				RayquazaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rayquaza Constructor only waiting for a Level
		/// </summary>
		public Rayquaza(int level)
		: this( "Rayquaza", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rayquaza Constructor waiting for no params
		/// </summary>
		/*
		public Rayquaza() : this( "Rayquaza", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}