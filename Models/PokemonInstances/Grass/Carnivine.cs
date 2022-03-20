using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Carnivine PokemonInstance Class
	#region Carnivine
	public class Carnivine : PokemonInstance
	{
		#region Carnivine Constructors
		/// <summary>
		/// Carnivine Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Carnivine(string nickname, int level)
		: base(
				CarnivineSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carnivine Constructor only waiting for a Level
		/// </summary>
		public Carnivine(int level)
		: this( "Carnivine", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carnivine Constructor waiting for no params
		/// </summary>
		/*
		public Carnivine() : this( "Carnivine", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}