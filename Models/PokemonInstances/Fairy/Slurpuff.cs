using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Slurpuff PokemonInstance Class
	#region Slurpuff
	public class Slurpuff : PokemonInstance
	{
		#region Slurpuff Constructors
		/// <summary>
		/// Slurpuff Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Slurpuff(string nickname, int level)
		: base(
				SlurpuffSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slurpuff Constructor only waiting for a Level
		/// </summary>
		public Slurpuff(int level)
		: this( "Slurpuff", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slurpuff Constructor waiting for no params
		/// </summary>
		/*
		public Slurpuff() : this( "Slurpuff", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}