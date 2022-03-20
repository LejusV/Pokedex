using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Ponyta PokemonInstance Class
	#region Ponyta
	public class Ponyta : PokemonInstance
	{
		#region Ponyta Constructors
		/// <summary>
		/// Ponyta Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Ponyta(string nickname, int level)
		: base(
				PonytaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ponyta Constructor only waiting for a Level
		/// </summary>
		public Ponyta(int level)
		: this( "Ponyta", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ponyta Constructor waiting for no params
		/// </summary>
		/*
		public Ponyta() : this( "Ponyta", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}