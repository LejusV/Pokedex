using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Parasect PokemonInstance Class
	#region Parasect
	public class Parasect : PokemonInstance
	{
		#region Parasect Constructors
		/// <summary>
		/// Parasect Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Parasect(string nickname, int level)
		: base(
				ParasectSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Parasect Constructor only waiting for a Level
		/// </summary>
		public Parasect(int level)
		: this( "Parasect", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Parasect Constructor waiting for no params
		/// </summary>
		/*
		public Parasect() : this( "Parasect", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}