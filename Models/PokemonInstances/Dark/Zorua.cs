using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Zorua PokemonInstance Class
	#region Zorua
	public class Zorua : PokemonInstance
	{
		#region Zorua Constructors
		/// <summary>
		/// Zorua Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Zorua(string nickname, int level)
		: base(
				ZoruaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zorua Constructor only waiting for a Level
		/// </summary>
		public Zorua(int level)
		: this( "Zorua", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zorua Constructor waiting for no params
		/// </summary>
		/*
		public Zorua() : this( "Zorua", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}