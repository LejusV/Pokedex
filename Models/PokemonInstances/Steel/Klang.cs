using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Klang PokemonInstance Class
	#region Klang
	public class Klang : PokemonInstance
	{
		#region Klang Constructors
		/// <summary>
		/// Klang Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Klang(string nickname, int level)
		: base(
				KlangSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Klang Constructor only waiting for a Level
		/// </summary>
		public Klang(int level)
		: this( "Klang", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Klang Constructor waiting for no params
		/// </summary>
		/*
		public Klang() : this( "Klang", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}