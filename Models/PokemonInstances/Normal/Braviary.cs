using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Braviary PokemonInstance Class
	#region Braviary
	public class Braviary : PokemonInstance
	{
		#region Braviary Constructors
		/// <summary>
		/// Braviary Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Braviary(string nickname, int level)
		: base(
				BraviarySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Braviary Constructor only waiting for a Level
		/// </summary>
		public Braviary(int level)
		: this( "Braviary", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Braviary Constructor waiting for no params
		/// </summary>
		/*
		public Braviary() : this( "Braviary", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}