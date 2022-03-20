using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Aegislash-Shield PokemonInstance Class
	#region Aegislash-Shield
	public class AegislashShield : PokemonInstance
	{
		#region Aegislash-Shield Constructors
		/// <summary>
		/// Aegislash-Shield Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AegislashShield(string nickname, int level)
		: base(
				AegislashShieldSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aegislash-Shield Constructor only waiting for a Level
		/// </summary>
		public AegislashShield(int level)
		: this( "Aegislash-Shield", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aegislash-Shield Constructor waiting for no params
		/// </summary>
		/*
		public AegislashShield() : this( "Aegislash-Shield", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}