using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Vanillite PokemonInstance Class
	#region Vanillite
	public class Vanillite : PokemonInstance
	{
		#region Vanillite Constructors
		/// <summary>
		/// Vanillite Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Vanillite(string nickname, int level)
		: base(
				VanilliteSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vanillite Constructor only waiting for a Level
		/// </summary>
		public Vanillite(int level)
		: this( "Vanillite", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vanillite Constructor waiting for no params
		/// </summary>
		/*
		public Vanillite() : this( "Vanillite", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}