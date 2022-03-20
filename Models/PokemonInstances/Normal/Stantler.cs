using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Stantler PokemonInstance Class
	#region Stantler
	public class Stantler : PokemonInstance
	{
		#region Stantler Constructors
		/// <summary>
		/// Stantler Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Stantler(string nickname, int level)
		: base(
				StantlerSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stantler Constructor only waiting for a Level
		/// </summary>
		public Stantler(int level)
		: this( "Stantler", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stantler Constructor waiting for no params
		/// </summary>
		/*
		public Stantler() : this( "Stantler", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}